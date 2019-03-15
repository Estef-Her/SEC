Public Class RentaPermanente
    Inherits System.Web.UI.Page

    Dim numeroDigitado As String
    Dim meses(12) As String
    Dim fechas(12) As String
    Dim iteracion As Integer
    Dim anio As Integer
    Dim posicion As Integer
    Dim indice As Integer
    Dim sumaRendimientos As Double
    Dim sumaComisiones As Double
    Dim resultado As Double
    Dim resultadoFinal As String

    Protected Sub Text_Changed_R1(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento1.Text))
        rendimiento1.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_C1(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(comision1.Text))
        comision1.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_R2(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento2.Text))
        rendimiento2.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_C2(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(comision2.Text))
        comision2.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_R3(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento3.Text))
        rendimiento3.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_C3(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(comision3.Text))
        comision3.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_R4(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento4.Text))
        rendimiento4.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_C4(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(comision4.Text))
        comision4.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_R5(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento5.Text))
        rendimiento5.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_C5(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(comision5.Text))
        comision5.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_R6(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento6.Text))
        rendimiento6.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_C6(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(comision6.Text))
        comision6.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_R7(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento7.Text))
        rendimiento7.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_C7(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(comision7.Text))
        comision7.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_R8(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento8.Text))
        rendimiento8.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_C8(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(comision8.Text))
        comision8.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_R9(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento9.Text))
        rendimiento9.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_C9(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(comision9.Text))
        comision9.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_R10(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento10.Text))
        rendimiento10.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_C10(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(comision10.Text))
        comision10.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_R11(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento11.Text))
        rendimiento11.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_C11(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(comision11.Text))
        comision11.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_R12(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(rendimiento12.Text))
        rendimiento12.Text = numeroDigitado
    End Sub

    Protected Sub Text_Changed_C12(sender As Object, e As EventArgs)
        numeroDigitado = String.Format("{0:n2}", CDbl(comision12.Text))
        comision12.Text = numeroDigitado
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
        sumaRendimientos = CDbl(rendimiento1.Text) + CDbl(rendimiento2.Text) + CDbl(rendimiento3.Text) +
                           CDbl(rendimiento4.Text) + CDbl(rendimiento5.Text) + CDbl(rendimiento6.Text) +
                           CDbl(rendimiento7.Text) + CDbl(rendimiento8.Text) + CDbl(rendimiento9.Text) +
                           CDbl(rendimiento10.Text) + CDbl(rendimiento11.Text) + CDbl(rendimiento12.Text)

        sumaComisiones = Math.Abs(CDbl(comision1.Text)) + Math.Abs(CDbl(comision2.Text)) + Math.Abs(CDbl(comision3.Text)) +
                         Math.Abs(CDbl(comision4.Text)) + Math.Abs(CDbl(comision5.Text)) + Math.Abs(CDbl(comision6.Text)) +
                         Math.Abs(CDbl(comision7.Text)) + Math.Abs(CDbl(comision8.Text)) + Math.Abs(CDbl(comision9.Text)) +
                         Math.Abs(CDbl(comision10.Text)) + Math.Abs(CDbl(comision11.Text)) + Math.Abs(CDbl(comision12.Text))

        resultado = (sumaRendimientos - sumaComisiones) / 12

        resultadoFinal = FormatNumber(resultado, 2)

        etiquetaLarga.Visible = True
        etiquetaCorta.Text = "₡" + resultadoFinal
        etiquetaCorta.Visible = True
    End Sub

End Class