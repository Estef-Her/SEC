Public Class ROP
    Inherits System.Web.UI.Page

    Protected Sub Text_Changed(sender As Object, e As EventArgs)
        Dim s As String = String.Format("{0:n0}", CInt(campoTextoCapital.Text))
        campoTextoCapital.Text = s
    End Sub

    'Limpia/Resetea todos los campos'
    Protected Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles botonLimpiar.Click
        campoTextoNacimiento.Text = String.Empty
        campoTextoCapital.Text = ""
        campoTextoTasa.Text = "3"
        etiquetaVanuLarga.Visible = False
        etiquetaVanuCorta.Visible = False
        etiquetaRopLarga.Visible = False
        etiquetaRopCorta.Visible = False
    End Sub

    'Realiza el calculo del estimado'
    Protected Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles botonCalcular.Click

        Dim anio As Integer
        Dim sexo As Integer
        Dim tablaDatos As New DataTable
        Dim tasa As Double = CDbl(campoTextoTasa.Text) / 100

        'Convierte el texto del anio de nacimiento a integer'
        Dim cadena As String = ""

        For index As Integer = 4 To 1 Step -1
            cadena = cadena + campoTextoNacimiento.Text.ElementAt(campoTextoNacimiento.Text.Length - index)
        Next

        anio = CInt(cadena)

        sexo = CInt(listaSexo.SelectedValue)

        Dim primeraFecha As String = campoTextoNacimiento.Text.Remove(6, 4)
        Dim segundaFecha As String = campoTextoNacimiento.Text.Remove(6, 4)
        Dim anioActual As Integer = System.DateTime.Now.Year
        Dim anioSiguiente As Integer = System.DateTime.Now.Year + 1
        Dim primerAnio As String = CStr(anioActual)
        Dim segundoAnio As String = CStr(anioSiguiente)
        primeraFecha = primeraFecha + primerAnio
        segundaFecha = segundaFecha + segundoAnio

        Dim fechaActual As DateTime = System.DateTime.Now.Date
        Dim primerCumpleanios As DateTime = DateTime.ParseExact(primeraFecha, "dd/MM/yyyy", Nothing)
        Dim segundoCumpleanios As DateTime = DateTime.ParseExact(segundaFecha, "dd/MM/yyyy", Nothing)
        Dim cantidadDias As Integer = DateDiff("d", fechaActual, primerCumpleanios)

        If cantidadDias < 0 Then
            cantidadDias = DateDiff("d", fechaActual, segundoCumpleanios)
            If cantidadDias <= 182 Then
                anio = anio - 1
                tablaDatos = DAO.Get_qx(anio, sexo)
            Else
                tablaDatos = DAO.Get_qx(anio, sexo)
            End If
        Else
            If cantidadDias <= 182 Then
                tablaDatos = DAO.Get_qx(anio, sexo)
            Else
                anio = anio + 1
                tablaDatos = DAO.Get_qx(anio, sexo)
            End If
        End If

        'Declaracion de variables esenciales'

        Dim iteracion As Integer = 0
        Dim datoExtraido As String
        Dim primerDato As Double = 0
        Dim segundoDato As Double = 0
        Dim tercerDato As Double = 0
        Dim dato As Double = 0
        Dim suma As Double = 0

        'Se procede a realizar una tabla de probabilidad de muerte'

        Dim tablaProbabilidadMuerte(tablaDatos.Rows.Count + 1) As String

        For Each fila As DataRow In tablaDatos.Rows
            datoExtraido = tablaDatos.Rows(iteracion).Item(0)
            tablaProbabilidadMuerte(iteracion) = datoExtraido
            iteracion = iteracion + 1
        Next
        tablaProbabilidadMuerte(tablaDatos.Rows.Count) = "1"

        'Se procede a realizar una tabla de periodo'

        Dim tablaPeriodo(tablaDatos.Rows.Count + 1) As String
        For iteracion = 0 To tablaDatos.Rows.Count
            tablaPeriodo(iteracion) = CStr(iteracion)
        Next

        'Se procede a realizar una tabla de probabilidad de vida'

        Dim tablaProbabilidadVida(tablaDatos.Rows.Count + 1) As String
        tablaProbabilidadVida(0) = "1"
        For iteracion = 1 To tablaDatos.Rows.Count - 1
            primerDato = CDbl(tablaProbabilidadVida(iteracion - 1))
            segundoDato = 1 - CDbl(tablaProbabilidadMuerte(iteracion - 1))
            tercerDato = primerDato * segundoDato
            tablaProbabilidadVida(iteracion) = CStr(tercerDato)
        Next
        tablaProbabilidadVida(tablaDatos.Rows.Count) = "0"

        'Se procede a realizar una tabla de 1/(1+r)^t'

        Dim tablaFormula(tablaDatos.Rows.Count + 1) As String
        For iteracion = 0 To tablaDatos.Rows.Count
            dato = 1 / (((1 + tasa)) ^ CDbl(tablaPeriodo(iteracion)))
            tablaFormula(iteracion) = CStr(dato)
        Next

        'Se procede a realizar una tabla de multiplicacion'

        Dim tablaMultiplicacion(tablaDatos.Rows.Count + 1) As String
        For iteracion = 0 To tablaDatos.Rows.Count
            dato = CDbl(tablaProbabilidadVida(iteracion)) * CDbl(tablaFormula(iteracion))
            tablaMultiplicacion(iteracion) = CStr(dato)
        Next

        'Se realiza la sumatoria final'

        For iteracion = 0 To tablaDatos.Rows.Count
            suma = suma + tablaMultiplicacion(iteracion)
        Next

        'Calculo VANU'

        Dim vanu As Double = 12 * (suma - (11 / 24))

        'Se realiza el calculo final'

        Dim capital As Double = CDbl(campoTextoCapital.Text)
        Dim vanuFinal As String = FormatNumber(vanu, 4)
        Dim resultado As Double = capital / vanu
        Dim resultadoFinal As String = FormatNumber(resultado, 2)
        etiquetaVanuCorta.Text = CStr(vanuFinal)
        etiquetaRopCorta.Text = CStr("₡" + resultadoFinal)
        etiquetaVanuLarga.Visible = True
        etiquetaVanuCorta.Visible = True
        etiquetaRopLarga.Visible = True
        etiquetaRopCorta.Visible = True
    End Sub
End Class