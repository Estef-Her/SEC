Public Class IncentivoFiscal
    Inherits System.Web.UI.Page

    Dim usuario As New Usuario
    Dim calculadora As New CalculadoraIncentivoFiscal

    Protected Sub Text_Changed(sender As Object, e As EventArgs)
        Dim s As String = String.Format("{0:n2}", CInt(campoTextoSalario.Text))
        campoTextoSalario.Text = s
    End Sub

    Protected Sub Text_Changed2(sender As Object, e As EventArgs)
        Dim s As String = String.Format("{0:n2}", CInt(campoTextoAporte.Text))
        campoTextoAporte.Text = s
    End Sub

    Protected Sub botonLimpiar_Click(sender As Object, e As EventArgs) Handles botonLimpiar.Click
        etiquetaTreinta.Visible = False
        etiquetaTreintaiuno.Visible = False
        campoTextoSalario.Text = String.Empty
        campoTextoAporte.Text = String.Empty
    End Sub

    Protected Sub botonCalcular_Click(sender As Object, e As EventArgs) Handles botonCalcular.Click
        usuario.cambiarSalarioMensual(CDbl(campoTextoSalario.Text))
        usuario.cambiarMontoAporte(CDbl(campoTextoAporte.Text))
        usuario.cambiarTipoTrabajador(listaTrabajador.SelectedValue)
        If usuario.obtenerTipoTrabajador() = 1 Then
            Dim x As Double = calculadora.sumaTotalImpuestos(calculadora.calculoMontoImpuestoRentaAsalariado(usuario.obtenerSalarioMensual()), calculadora.calculoMontoCargasSociales(usuario.obtenerSalarioMensual()))
            Dim y As Double = calculadora.sumaTotalImpuestos(calculadora.calculoMontoImpuestoRentaAsalariado(calculadora.calculoSalarioParaImpuestos(usuario)), calculadora.calculoMontoCargasSociales(calculadora.calculoSalarioParaImpuestos(usuario)))
            etiquetaTreintaiuno.Text = "₡" + FormatNumber(calculadora.diferenciaImpuestos(x, y), 2)
        Else
            Dim z As Double = calculadora.calculoMontoImpuestoRentaIndependiente(usuario.obtenerSalarioMensual())
            Dim w As Double = calculadora.calculoMontoImpuestoRentaIndependiente(calculadora.calculoSalarioParaImpuestos(usuario))
            etiquetaTreintaiuno.Text = "₡" + FormatNumber(calculadora.diferenciaImpuestos(z, w))
        End If


        'sextaEtiqueta.Text = "₡" + FormatNumber(calculadora.calculoMontoMaximoPorExonerar(usuario), 2)
        'novenaEtiqueta.Text = "₡" + FormatNumber(usuario.obtenerSalarioMensual(), 2)
        'undecimaEtiqueta.Text = "₡" + FormatNumber(calculadora.calculoSalarioParaImpuestos(usuario))
        'etiquetaDieciseis.Text = "₡" + FormatNumber(calculadora.calculoMontoImpuestoRenta(usuario.obtenerSalarioMensual()))
        'etiquetaDieciocho.Text = "₡" + FormatNumber(calculadora.calculoMontoImpuestoRenta(calculadora.calculoSalarioParaImpuestos(usuario)), 2)
        'etiquetaVeintitres.Text = "₡" + FormatNumber(calculadora.calculoMontoCargasSociales(usuario.obtenerSalarioMensual()), 2)
        'etiquetaFaltante.Text = "₡" + FormatNumber(calculadora.calculoMontoCargasSociales(calculadora.calculoSalarioParaImpuestos(usuario)), 2)
        'etiquetaVeintisiete.Text = "₡" + FormatNumber(calculadora.sumaTotalImpuestos(calculadora.calculoMontoImpuestoRenta(usuario.obtenerSalarioMensual()), calculadora.calculoMontoCargasSociales(usuario.obtenerSalarioMensual())), 2)
        'etiquetaVeintinueve.Text = "₡" + FormatNumber(calculadora.sumaTotalImpuestos(calculadora.calculoMontoImpuestoRenta(calculadora.calculoSalarioParaImpuestos(usuario)), calculadora.calculoMontoCargasSociales(calculadora.calculoSalarioParaImpuestos(usuario))), 2)


        'etiquetaTreintaitres.Text = "₡" + FormatNumber(calculadora.calculoProyeccion(z, usuario), 2)

        etiquetaTreinta.Visible = True
        etiquetaTreintaiuno.Visible = True

    End Sub

End Class