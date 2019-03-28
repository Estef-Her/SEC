Public Class CalculadoraIncentivoFiscal

    'Definicion de atributos'
    Private porcentajeLimiteSalario As Double
    Private primerTramoRenta As Double
    Private segundoTramoRenta As Double
    Private tercerTramoRenta As Double
    Private primerLimiteRenta As Double
    Private segundoLimiteRenta As Double
    Private primerPorcentajeCargaSocial As Double
    Private segundoPorcentajeCargaSocial As Double

    Public Sub New()
        Me.porcentajeLimiteSalario = 10 / 100
        Me.primerTramoRenta = 15 / 100
        Me.segundoTramoRenta = 10 / 100
        Me.tercerTramoRenta = 0
        Me.primerLimiteRenta = 799000.0
        Me.segundoLimiteRenta = 1199000.0
        Me.primerPorcentajeCargaSocial = 5.5 / 100
        Me.segundoPorcentajeCargaSocial = 3.34 / 100
    End Sub

    'Definicion de metodos'
    Public Sub cambiarPorcentajeLimiteSalario(ByVal porcentaje As Double)
        porcentajeLimiteSalario = porcentaje / 100
    End Sub

    Public Sub cambiarPrimerTramoRenta(ByVal tramo As Double)
        primerTramoRenta = tramo / 100
    End Sub

    Public Sub cambiarSegundoTramoRenta(ByVal tramo As Double)
        segundoTramoRenta = tramo / 100
    End Sub

    Public Sub cambiarTercerTramoRenta(ByVal tramo As Double)
        tercerTramoRenta = tramo / 100
    End Sub

    Public Sub cambiarPrimerLimiteRenta(ByVal limite As Double)
        primerLimiteRenta = limite
    End Sub

    Public Sub cambiarSegundoLimiteRenta(ByVal limite As Double)
        segundoLimiteRenta = limite
    End Sub

    Public Sub cambiarPrimerPorcentajeCargaSocial(ByVal monto As Double)
        primerPorcentajeCargaSocial = monto / 100
    End Sub

    Public Sub cambiarSegundoPorcentajeCargaSocial(ByVal monto As Double)
        segundoPorcentajeCargaSocial = monto / 100
    End Sub

    Public Function obtenerPorcentajeLimiteSalario() As Double
        Return porcentajeLimiteSalario
    End Function

    Public Function obtenerPrimerTramoRenta() As Double
        Return primerTramoRenta
    End Function

    Public Function obtenerSegundoTramoRenta() As Double
        Return segundoTramoRenta
    End Function

    Public Function obtenerTercerTramoRenta() As Double
        Return tercerTramoRenta
    End Function

    Public Function obtenerPrimerLimiteRenta() As Double
        Return primerLimiteRenta
    End Function

    Public Function obtenerSegundoLimiteRenta() As Double
        Return segundoLimiteRenta
    End Function

    Public Function obtenerPrimerPorcentajeCargaSocial() As Double
        Return primerPorcentajeCargaSocial
    End Function

    Public Function obtenerSegundoPorcentajeCargaSocial() As Double
        Return segundoPorcentajeCargaSocial
    End Function

    Public Function calculoMontoMaximoPorExonerar(ByVal usuario As Usuario) As Double
        Return (usuario.obtenerSalarioMensual() * obtenerPorcentajeLimiteSalario())
    End Function

    Public Function calculoSalarioParaImpuestos(ByVal usuario As Usuario) As Double
        Dim salario As Double

        If (usuario.obtenerSalarioMensual() * obtenerPorcentajeLimiteSalario()) > usuario.obtenerMontoAporte() Then
            salario = usuario.obtenerSalarioMensual() - usuario.obtenerMontoAporte()
        Else
            salario = usuario.obtenerSalarioMensual() - (usuario.obtenerSalarioMensual() * obtenerPorcentajeLimiteSalario())
        End If

        Return salario
    End Function

    Public Function calculoMontoImpuestoRenta(ByVal valor As Double) As Double
        Dim primerValor As Double = 0.00
        Dim segundoValor As Double = 0.00
        Dim tercerValor As Double = 0.00
        Dim monto As Double

        If valor <= obtenerPrimerLimiteRenta() Then
            primerValor = valor * obtenerTercerTramoRenta()
        End If

        If valor > obtenerPrimerLimiteRenta() And valor <= obtenerSegundoLimiteRenta() Then
            segundoValor = valor * obtenerSegundoTramoRenta()
        End If

        If valor > obtenerSegundoLimiteRenta() Then
            tercerValor = valor * obtenerPrimerTramoRenta()
        End If

        monto = primerValor + segundoValor + tercerValor

        Return monto
    End Function

    Public Function calculoMontoCargasSociales(ByVal valor As Double) As Double
        Return (valor * obtenerPrimerPorcentajeCargaSocial()) + (valor * obtenerSegundoPorcentajeCargaSocial())
    End Function

    Public Function sumaTotalImpuestos(ByVal primerValor As Double, ByVal segundoValor As Double) As Double
        Return primerValor + segundoValor
    End Function

    Public Function diferenciaImpuestos(ByVal primerValor As Double, ByVal segundoValor As Double) As Double
        Return primerValor - segundoValor
    End Function

    Public Function calculoProyeccion(ByVal valor As Double, ByVal usuario As Usuario) As Double
        Return usuario.obtenerMontoAporte() - valor
    End Function

End Class
