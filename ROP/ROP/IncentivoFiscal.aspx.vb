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
        primeraEtiqueta.Visible = False
        segundaEtiqueta.Visible = False
        terceraEtiqueta.Visible = False
        cuartaEtiqueta.Visible = False
        quintaEtiqueta.Visible = False
        sextaEtiqueta.Visible = False
        septimaEtiqueta.Visible = False
        octavaEtiqueta.Visible = False
        novenaEtiqueta.Visible = False
        decimaEtiqueta.Visible = False
        undecimaEtiqueta.Visible = False
        duodecimaEtiqueta.Visible = False
        etiquetaQuince.Visible = False
        etiquetaDieciseis.Visible = False
        etiquetaDiecisiete.Visible = False
        etiquetaDieciocho.Visible = False
        etiquetaDiecinueve.Visible = False
        etiquetaVeintidos.Visible = False
        etiquetaVeintitres.Visible = False
        etiquetaVeinticuatro.Visible = False
        etiquetaVeinticinco.Visible = False
        etiquetaVeintiseis.Visible = False
        etiquetaVeintisiete.Visible = False
        etiquetaVeintiocho.Visible = False
        etiquetaVeintinueve.Visible = False
        etiquetaTreinta.Visible = False
        etiquetaTreintaiuno.Visible = False
        etiquetaTreintaidos.Visible = False
        etiquetaTreintaitres.Visible = False
        etiquetaFaltante.Visible = False
        campoTextoSalario.Text = String.Empty
        campoTextoAporte.Text = String.Empty
    End Sub

    Protected Sub botonCalcular_Click(sender As Object, e As EventArgs) Handles botonCalcular.Click
        usuario.cambiarSalarioMensual(CDbl(campoTextoSalario.Text))
        usuario.cambiarMontoAporte(CDbl(campoTextoAporte.Text))
        cuartaEtiqueta.Text = "₡0.00"
        sextaEtiqueta.Text = "₡" + FormatNumber(calculadora.calculoMontoMaximoPorExonerar(usuario), 2)
        novenaEtiqueta.Text = "₡" + FormatNumber(usuario.obtenerSalarioMensual(), 2)
        undecimaEtiqueta.Text = "₡" + FormatNumber(calculadora.calculoSalarioParaImpuestos(usuario))
        etiquetaDieciseis.Text = "₡" + FormatNumber(calculadora.calculoMontoImpuestoRenta(usuario.obtenerSalarioMensual()))
        etiquetaDieciocho.Text = "₡" + FormatNumber(calculadora.calculoMontoImpuestoRenta(calculadora.calculoSalarioParaImpuestos(usuario)), 2)
        etiquetaVeintitres.Text = "₡" + FormatNumber(calculadora.calculoMontoCargasSociales(usuario.obtenerSalarioMensual()), 2)
        etiquetaFaltante.Text = "₡" + FormatNumber(calculadora.calculoMontoCargasSociales(calculadora.calculoSalarioParaImpuestos(usuario)), 2)
        etiquetaVeintisiete.Text = "₡" + FormatNumber(calculadora.sumaTotalImpuestos(calculadora.calculoMontoImpuestoRenta(usuario.obtenerSalarioMensual()), calculadora.calculoMontoCargasSociales(usuario.obtenerSalarioMensual())), 2)
        etiquetaVeintinueve.Text = "₡" + FormatNumber(calculadora.sumaTotalImpuestos(calculadora.calculoMontoImpuestoRenta(calculadora.calculoSalarioParaImpuestos(usuario)), calculadora.calculoMontoCargasSociales(calculadora.calculoSalarioParaImpuestos(usuario))), 2)
        Dim x As Double = calculadora.sumaTotalImpuestos(calculadora.calculoMontoImpuestoRenta(usuario.obtenerSalarioMensual()), calculadora.calculoMontoCargasSociales(usuario.obtenerSalarioMensual()))
        Dim y As Double = calculadora.sumaTotalImpuestos(calculadora.calculoMontoImpuestoRenta(calculadora.calculoSalarioParaImpuestos(usuario)), calculadora.calculoMontoCargasSociales(calculadora.calculoSalarioParaImpuestos(usuario)))
        etiquetaTreintaiuno.Text = "₡" + FormatNumber(calculadora.diferenciaImpuestos(x, y), 2)
        Dim z = calculadora.diferenciaImpuestos(x, y)
        etiquetaTreintaitres.Text = "₡" + FormatNumber(calculadora.calculoProyeccion(z, usuario), 2)
        primeraEtiqueta.Visible = True
        segundaEtiqueta.Visible = True
        terceraEtiqueta.Visible = True
        cuartaEtiqueta.Visible = True
        quintaEtiqueta.Visible = True
        sextaEtiqueta.Visible = True
        septimaEtiqueta.Visible = True
        octavaEtiqueta.Visible = True
        novenaEtiqueta.Visible = True
        decimaEtiqueta.Visible = True
        undecimaEtiqueta.Visible = True
        duodecimaEtiqueta.Visible = True
        etiquetaQuince.Visible = True
        etiquetaDieciseis.Visible = True
        etiquetaDiecisiete.Visible = True
        etiquetaDieciocho.Visible = True
        etiquetaDiecinueve.Visible = True
        etiquetaVeintidos.Visible = True
        etiquetaVeintitres.Visible = True
        etiquetaVeinticuatro.Visible = True
        etiquetaVeinticinco.Visible = True
        etiquetaVeintiseis.Visible = True
        etiquetaVeintisiete.Visible = True
        etiquetaVeintiocho.Visible = True
        etiquetaVeintinueve.Visible = True
        etiquetaTreinta.Visible = True
        etiquetaTreintaiuno.Visible = True
        etiquetaTreintaidos.Visible = True
        etiquetaTreintaitres.Visible = True
        etiquetaFaltante.Visible = True
    End Sub

End Class