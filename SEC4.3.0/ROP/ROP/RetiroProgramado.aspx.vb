﻿Public Class ROP
    Inherits System.Web.UI.Page

    Dim usuario As New Usuario()
    Dim calculadora As New CalculadoraRetiroProgramado()

    Protected Sub Text_Changed(sender As Object, e As EventArgs)
        Try
            Dim s As String = String.Format("{0:n0}", CInt(campoTextoCapital.Text))
            campoTextoCapital.Text = s
        Catch ex As Exception
        End Try
    End Sub

    'Limpia/Resetea todos los campos'
    Protected Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles botonLimpiar.Click
        campoTextoNacimiento.Text = String.Empty
        campoTextoCapital.Text = String.Empty
        campoTextoTasa.Text = "3"
        etiquetaVanuLarga.Visible = False
        etiquetaVanuCorta.Visible = False
        etiquetaRopLarga.Visible = False
        etiquetaRopCorta.Visible = False
    End Sub

    'Realiza el calculo del estimado'
    Protected Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles botonCalcular.Click
        Try
            usuario.cambiarFechaNacimiento(campoTextoNacimiento.Text)
            usuario.cambiarCapitalPension(CInt(campoTextoCapital.Text))
            usuario.cambiarSexo(listaSexo.SelectedValue)
            Dim tasa As Double = CDbl(campoTextoTasa.Text)
            calculadora.cambiarTasaInteres(tasa)
            Dim vanuFinal As String = FormatNumber(calculadora.calculoVanu(usuario), 4)
            Dim resultadoFinal As String = FormatNumber(calculadora.calculo(usuario), 2)
            etiquetaVanuCorta.Text = CStr(vanuFinal)
            etiquetaRopCorta.Text = CStr("₡" + resultadoFinal)
            etiquetaVanuLarga.Visible = True
            etiquetaVanuCorta.Visible = True
            etiquetaRopLarga.Visible = True
            etiquetaRopCorta.Visible = True
        Catch ex As Exception
        End Try
    End Sub

End Class