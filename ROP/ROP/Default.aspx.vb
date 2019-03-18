Public Class ROP
    Inherits System.Web.UI.Page

    Dim objeto As New RetiroProgramado

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
        objeto.cambiarFechaNacimiento(campoTextoNacimiento.Text)
        objeto.cambiarCapitalPension(CInt(campoTextoCapital.Text))
        Dim valorTasa As Double = CDbl(campoTextoTasa.Text) / 100
        objeto.cambiarTasaTecnica(CDbl(valorTasa))
        objeto.cambiarSexo(listaSexo.SelectedValue)
        objeto.cambiarVanu(objeto.calculoVANU())
        Dim vanuFinal As String = FormatNumber(objeto.obtenerVanu(), 4)
        Dim resultado As Double = objeto.calculo()
        Dim resultadoFinal As String = FormatNumber(resultado, 2)
        etiquetaVanuCorta.Text = CStr(vanuFinal)
        etiquetaRopCorta.Text = CStr("₡" + resultadoFinal)
        etiquetaVanuLarga.Visible = True
        etiquetaVanuCorta.Visible = True
        etiquetaRopLarga.Visible = True
        etiquetaRopCorta.Visible = True
    End Sub
End Class