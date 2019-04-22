Public Class RentaPermanente
    Inherits System.Web.UI.Page

    Dim numeroDigitado As String
    Dim meses(12) As String
    Dim fechas(12) As String
    Dim otrosMeses(12) As String
    Dim otrasFechas(12) As String
    Dim iteracion As Integer
    Dim anio As Integer
    Dim posicion As Integer
    Dim indice As Integer
    Dim usuario As New Usuario
    Dim calculadora As New CalculadoraRentaPermanente

    Protected Sub cargandoAnios(sender As Object, e As EventArgs)
        Try
            For item As Integer = 1950 To System.DateTime.Now.Year
                listaAnios.Items.Add(CStr(item))
            Next
        Catch ex As Exception
        End Try

    End Sub

    Protected Sub Text_Changed_R1(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento1.Text))
            rendimiento1.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_C1(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(comision1.Text))
            comision1.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_R2(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento2.Text))
            rendimiento2.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_C2(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(comision2.Text))
            comision2.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_R3(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento3.Text))
            rendimiento3.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_C3(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(comision3.Text))
            comision3.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_R4(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento4.Text))
            rendimiento4.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_C4(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(comision4.Text))
            comision4.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_R5(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento5.Text))
            rendimiento5.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_C5(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(comision5.Text))
            comision5.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_R6(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento6.Text))
            rendimiento6.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_C6(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(comision6.Text))
            comision6.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_R7(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento7.Text))
            rendimiento7.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_C7(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(comision7.Text))
            comision7.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_R8(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento8.Text))
            rendimiento8.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_C8(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(comision8.Text))
            comision8.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_R9(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento9.Text))
            rendimiento9.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_C9(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(comision9.Text))
            comision9.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_R10(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento10.Text))
            rendimiento10.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_C10(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(comision10.Text))
            comision10.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_R11(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento11.Text))
            rendimiento11.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_C11(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(comision11.Text))
            comision11.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_R12(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento12.Text))
            rendimiento12.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Text_Changed_C12(sender As Object, e As EventArgs)
        Try
            numeroDigitado = String.Format("{0:n2}", CDbl(comision12.Text))
            comision12.Text = numeroDigitado
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub cargaFechasRecientes(sender As Object, e As EventArgs)

        meses(0) = "Enero"
        meses(1) = "Febrero"
        meses(2) = "Marzo"
        meses(3) = "Abril"
        meses(4) = "Mayo"
        meses(5) = "Junio"
        meses(6) = "Julio"
        meses(7) = "Agosto"
        meses(8) = "Septiembre"
        meses(9) = "Octubre"
        meses(10) = "Noviembre"
        meses(11) = "Diciembre"

        fechas(0) = ""
        fechas(1) = ""
        fechas(2) = ""
        fechas(3) = ""
        fechas(4) = ""
        fechas(5) = ""
        fechas(6) = ""
        fechas(7) = ""
        fechas(8) = ""
        fechas(9) = ""
        fechas(10) = ""
        fechas(11) = ""

        anio = System.DateTime.Now.Year
        posicion = 0

        If System.DateTime.Now.Month <> 1 Then
            For iteracion = System.DateTime.Now.Month - 1 To 1 Step -1
                fechas(posicion) = meses(iteracion - 1) + " " + CStr(anio)
                posicion = posicion + 1
            Next
        End If

        anio = anio - 1
        indice = 11

        For posicion = posicion To 11
            fechas(posicion) = meses(indice) + " " + CStr(anio)
            indice = indice - 1
        Next

        mes1.Text = fechas(11)
        mes2.Text = fechas(10)
        mes3.Text = fechas(9)
        mes4.Text = fechas(8)
        mes5.Text = fechas(7)
        mes6.Text = fechas(6)
        mes7.Text = fechas(5)
        mes8.Text = fechas(4)
        mes9.Text = fechas(3)
        mes10.Text = fechas(2)
        mes11.Text = fechas(1)
        mes12.Text = fechas(0)

    End Sub

    Protected Sub actualizarFechas(sender As Object, e As EventArgs) Handles botonActualizar.Click

        otrosMeses(0) = "Enero"
        otrosMeses(1) = "Febrero"
        otrosMeses(2) = "Marzo"
        otrosMeses(3) = "Abril"
        otrosMeses(4) = "Mayo"
        otrosMeses(5) = "Junio"
        otrosMeses(6) = "Julio"
        otrosMeses(7) = "Agosto"
        otrosMeses(8) = "Septiembre"
        otrosMeses(9) = "Octubre"
        otrosMeses(10) = "Noviembre"
        otrosMeses(11) = "Diciembre"

        Dim s As String = listaMeses.SelectedValue
        Dim c As String = listaAnios.SelectedValue
        Dim i As Integer = 0

        If s = "Enero" Then
            i = 0
        End If

        If s = "Febrero" Then
            i = 1
        End If

        If s = "Marzo" Then
            i = 2
        End If

        If s = "Abril" Then
            i = 3
        End If

        If s = "Mayo" Then
            i = 4
        End If

        If s = "Junio" Then
            i = 5
        End If

        If s = "Julio" Then
            i = 6
        End If

        If s = "Agosto" Then
            i = 7
        End If

        If s = "Septiembre" Then
            i = 8
        End If

        If s = "Octubre" Then
            i = 9
        End If

        If s = "Noviembre" Then
            i = 10
        End If

        If s = "Diciembre" Then
            i = 11
        End If

        Dim iteracion As Integer = 0
        Dim contador As Integer = 0

        For i = i To 11
            otrasFechas(iteracion) = otrosMeses(i) + " " + c
            iteracion = iteracion + 1
            contador = contador + 1
        Next

        i = 0
        c = CStr(CInt(c) + 1)

        If contador <> 12 Then
            Dim cantidadFaltante As Integer = 12 - contador - 1
            For i = i To cantidadFaltante
                otrasFechas(iteracion) = otrosMeses(i) + " " + c
                iteracion = iteracion + 1
            Next
        End If

        mes1.Text = otrasFechas(0)
        mes2.Text = otrasFechas(1)
        mes3.Text = otrasFechas(2)
        mes4.Text = otrasFechas(3)
        mes5.Text = otrasFechas(4)
        mes6.Text = otrasFechas(5)
        mes7.Text = otrasFechas(6)
        mes8.Text = otrasFechas(7)
        mes9.Text = otrasFechas(8)
        mes10.Text = otrasFechas(9)
        mes11.Text = otrasFechas(10)
        mes12.Text = otrasFechas(11)

    End Sub

    Protected Sub botonLimpiar_Click(sender As Object, e As EventArgs) Handles botonLimpiar.Click
        rendimiento1.Text = String.Empty
        rendimiento2.Text = String.Empty
        rendimiento3.Text = String.Empty
        rendimiento4.Text = String.Empty
        rendimiento5.Text = String.Empty
        rendimiento6.Text = String.Empty
        rendimiento7.Text = String.Empty
        rendimiento8.Text = String.Empty
        rendimiento9.Text = String.Empty
        rendimiento10.Text = String.Empty
        rendimiento11.Text = String.Empty
        rendimiento12.Text = String.Empty
        comision1.Text = String.Empty
        comision2.Text = String.Empty
        comision3.Text = String.Empty
        comision4.Text = String.Empty
        comision5.Text = String.Empty
        comision6.Text = String.Empty
        comision7.Text = String.Empty
        comision8.Text = String.Empty
        comision9.Text = String.Empty
        comision10.Text = String.Empty
        comision11.Text = String.Empty
        comision12.Text = String.Empty
        etiquetaLarga.Visible = False
        etiquetaCorta.Visible = False
    End Sub

    Protected Sub botonCalcular_Click(sender As Object, e As EventArgs) Handles botonCalcular.Click
        Try
            Dim arregloRendimientos(12) As Double
            Dim arregloComisiones(12) As Double
            arregloRendimientos(0) = CDbl(rendimiento1.Text)
            arregloRendimientos(1) = CDbl(rendimiento2.Text)
            arregloRendimientos(2) = CDbl(rendimiento3.Text)
            arregloRendimientos(3) = CDbl(rendimiento4.Text)
            arregloRendimientos(4) = CDbl(rendimiento5.Text)
            arregloRendimientos(5) = CDbl(rendimiento6.Text)
            arregloRendimientos(6) = CDbl(rendimiento7.Text)
            arregloRendimientos(7) = CDbl(rendimiento8.Text)
            arregloRendimientos(8) = CDbl(rendimiento9.Text)
            arregloRendimientos(9) = CDbl(rendimiento10.Text)
            arregloRendimientos(10) = CDbl(rendimiento11.Text)
            arregloRendimientos(11) = CDbl(rendimiento12.Text)
            arregloComisiones(0) = CDbl(comision1.Text)
            arregloComisiones(1) = CDbl(comision2.Text)
            arregloComisiones(2) = CDbl(comision3.Text)
            arregloComisiones(3) = CDbl(comision4.Text)
            arregloComisiones(4) = CDbl(comision5.Text)
            arregloComisiones(5) = CDbl(comision6.Text)
            arregloComisiones(6) = CDbl(comision7.Text)
            arregloComisiones(7) = CDbl(comision8.Text)
            arregloComisiones(8) = CDbl(comision9.Text)
            arregloComisiones(9) = CDbl(comision10.Text)
            arregloComisiones(10) = CDbl(comision11.Text)
            arregloComisiones(11) = CDbl(comision12.Text)
            usuario.cambiarRendimientos(arregloRendimientos)
            usuario.cambiarComisiones(arregloComisiones)
            etiquetaLarga.Visible = True
            etiquetaCorta.Text = "₡" + FormatNumber(calculadora.calculo(usuario), 2)
            etiquetaCorta.Visible = True
        Catch ex As Exception
        End Try

    End Sub

End Class