
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles botonLimpiar.Click
        monto.Text = ""


    End Sub


    Protected Sub botonCalcular_Click(sender As Object, e As EventArgs) Handles botonCalcular.Click
        Dim tasaSeleccionado As String = Page.Request(tasaDeInteres.UniqueID)
        Dim fechaSeleccionada As String = calendarioFecha.SelectedDate.ToShortDateString
        Dim montoSeleccionado As Double = Double.Parse(monto.Text)

    End Sub
End Class
