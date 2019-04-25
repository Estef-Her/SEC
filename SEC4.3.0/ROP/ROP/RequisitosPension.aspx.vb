Public Class RequisitosPension
    Inherits System.Web.UI.Page

    Dim calculadora As New CalculadoraRequisitosPension
    Dim usuario As New Usuario

    'Limpia los campos'
    Protected Sub botonLimpiar_Click(sender As Object, e As EventArgs) Handles botonLimpiar.Click
        campoNumerosCotizaciones.Text = String.Empty
        campoTextoNacimiento.Text = String.Empty
        etiqueta.Visible = False
    End Sub

    Protected Sub botonCalcular_Click(sender As Object, e As EventArgs) Handles botonCalcular.Click
        usuario.cambiarFechaNacimiento(campoTextoNacimiento.Text)
        usuario.cambiarCotizaciones(CInt(campoNumerosCotizaciones.Text))
        etiqueta.Text = calculadora.calculoCotizacionesContinuas(usuario)
        etiqueta.Visible = True
    End Sub

End Class