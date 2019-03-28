Public Class CalculadoraRetiroProgramado

    'Definicion de Atributos'

    Private tasaInteres As Double

    'Definicion de Metodos'

    Public Sub New()
        Me.tasaInteres = 0
    End Sub

    Public Sub cambiarTasaInteres(ByVal tasa As Double)
        tasaInteres = tasa / 100
    End Sub

    Public Function obtenerTasaInteres() As Double
        Return tasaInteres
    End Function

    Public Function calculoVanu(ByVal usuario As Usuario) As Double
        Dim anio As Integer
        Dim tablaDatos As New DataTable
        Dim fechaNacimiento As String = usuario.obtenerFechaNacimiento()
        Dim cadena As String = ""


        For index As Integer = 4 To 1 Step -1
            cadena = cadena + fechaNacimiento.ElementAt(fechaNacimiento.Length - index)
        Next

        anio = CInt(cadena)

        Dim primeraFecha As String = fechaNacimiento.Remove(6, 4)
        Dim segundaFecha As String = primeraFecha
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
                tablaDatos = DAO.Get_qx(anio, usuario.obtenerSexo())
            Else
                tablaDatos = DAO.Get_qx(anio, usuario.obtenerSexo())
            End If
        Else
            If cantidadDias <= 182 Then
                tablaDatos = DAO.Get_qx(anio, usuario.obtenerSexo())
            Else
                anio = anio + 1
                tablaDatos = DAO.Get_qx(anio, usuario.obtenerSexo())
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
            dato = 1 / (((1 + tasaInteres)) ^ CDbl(tablaPeriodo(iteracion)))
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
        Return vanu
    End Function

    Public Function calculo(ByVal usuario As Usuario) As Double
        Return usuario.obtenerCapitalPension() / calculoVanu(usuario)
    End Function

End Class
