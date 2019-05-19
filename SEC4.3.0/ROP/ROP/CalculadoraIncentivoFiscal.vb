Public Class CalculadoraIncentivoFiscal

    'Definicion de atributos'
    Private porcentajeLimiteSalario As Double
    Private primerTramoRentaAsalariado As Double
    Private segundoTramoRentaAsalariado As Double
    Private tercerTramoRentaAsalariado As Double
    Private primerLimiteRentaAsalariado As Double
    Private segundoLimiteRentaAsalariado As Double
    Private primerTramoRentaIndependiente As Double
    Private segundoTramoRentaIndependiente As Double
    Private tercerTramoRentaIndependiente As Double
    Private cuartoTramoRentaIndependiente As Double
    Private quintoTramoRentaIndependiente As Double
    Private primerLimiteRentaIndependiente As Double
    Private segundoLimiteRentaIndependiente As Double
    Private tercerLimiteRentaIndependiente As Double
    Private cuartoLimiteRentaIndependiente As Double
    Private primerPorcentajeCargaSocial As Double
    Private segundoPorcentajeCargaSocial As Double

    Public Sub New()
        Me.porcentajeLimiteSalario = 10 / 100
        Me.primerTramoRentaAsalariado = 15 / 100
        Me.segundoTramoRentaAsalariado = 10 / 100
        Me.tercerTramoRentaAsalariado = 0
        Me.primerLimiteRentaAsalariado = 817000.0
        Me.segundoLimiteRentaAsalariado = 1226000.0
        Me.primerTramoRentaIndependiente = 25 / 100
        Me.segundoTramoRentaIndependiente = 20 / 100
        Me.tercerTramoRentaIndependiente = 15 / 100
        Me.cuartoTramoRentaIndependiente = 10 / 100
        Me.quintoTramoRentaIndependiente = 0
        Me.primerLimiteRentaIndependiente = 3628000.0
        Me.segundoLimiteRentaIndependiente = 5418000.0
        Me.tercerLimiteRentaIndependiente = 9038000.0
        Me.cuartoLimiteRentaIndependiente = 18113000.0
        Me.primerPorcentajeCargaSocial = 5.5 / 100
        Me.segundoPorcentajeCargaSocial = 3.34 / 100
    End Sub

    'Definicion de metodos'
    Public Sub cambiarPorcentajeLimiteSalario(ByVal porcentaje As Double)
        porcentajeLimiteSalario = porcentaje / 100
    End Sub

    Public Sub cambiarPrimerTramoRentaAsalariado(ByVal tramo As Double)
        primerTramoRentaAsalariado = tramo / 100
    End Sub

    Public Sub cambiarSegundoTramoRentaAsalariado(ByVal tramo As Double)
        segundoTramoRentaAsalariado = tramo / 100
    End Sub

    Public Sub cambiarTercerTramoRentaAsalariado(ByVal tramo As Double)
        tercerTramoRentaAsalariado = tramo / 100
    End Sub

    Public Sub cambiarPrimerLimiteRentaAsalariado(ByVal limite As Double)
        primerLimiteRentaAsalariado = limite
    End Sub

    Public Sub cambiarSegundoLimiteRentaAsalariado(ByVal limite As Double)
        segundoLimiteRentaAsalariado = limite
    End Sub

    Public Sub cambiarPrimerTramoRentaIndependiente(ByVal tramo As Double)
        primerTramoRentaIndependiente = tramo / 100
    End Sub

    Public Sub cambiarSegundoTramoRentaIndependiente(ByVal tramo As Double)
        segundoTramoRentaIndependiente = tramo / 100
    End Sub

    Public Sub cambiarTercerTramoRentaIndependiente(ByVal tramo As Double)
        tercerTramoRentaIndependiente = tramo / 100
    End Sub

    Public Sub cambiarCuartoTramoRentaIndependiente(ByVal tramo As Double)
        cuartoTramoRentaIndependiente = tramo / 100
    End Sub

    Public Sub cambiarQuintoTramoRentaIndependiente(ByVal tramo As Double)
        quintoTramoRentaIndependiente = tramo / 100
    End Sub

    Public Sub cambiarPrimerLimiteRentaIndependiente(ByVal limite As Double)
        primerLimiteRentaIndependiente = limite
    End Sub

    Public Sub cambiarSegundoLimiteRentaIndependiente(ByVal limite As Double)
        segundoLimiteRentaIndependiente = limite
    End Sub

    Public Sub cambiarTercerLimiteRentaIndependiente(ByVal limite As Double)
        tercerLimiteRentaIndependiente = limite
    End Sub

    Public Sub cambiarCuartoLimiteRentaIndependiente(ByVal limite As Double)
        cuartoLimiteRentaIndependiente = limite
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

    Public Function obtenerPrimerTramoRentaAsalariado() As Double
        Return primerTramoRentaAsalariado
    End Function

    Public Function obtenerSegundoTramoRentaAsalariado() As Double
        Return segundoTramoRentaAsalariado
    End Function

    Public Function obtenerTercerTramoRentaAsalariado() As Double
        Return tercerTramoRentaAsalariado
    End Function

    Public Function obtenerPrimerLimiteRentaAsalariado() As Double
        Return primerLimiteRentaAsalariado
    End Function

    Public Function obtenerSegundoLimiteRentaAsalariado() As Double
        Return segundoLimiteRentaAsalariado
    End Function

    Public Function obtenerPrimerTramoRentaIndependiente() As Double
        Return primerTramoRentaIndependiente
    End Function

    Public Function obtenerSegundoTramoRentaIndependiente() As Double
        Return segundoTramoRentaIndependiente
    End Function

    Public Function obtenerTercerTramoRentaIndependiente() As Double
        Return tercerTramoRentaIndependiente
    End Function

    Public Function obtenerCuartoTramoRentaIndependiente() As Double
        Return cuartoTramoRentaIndependiente
    End Function

    Public Function obtenerQuintoTramoRentaIndependiente() As Double
        Return quintoTramoRentaIndependiente
    End Function

    Public Function obtenerPrimerLimiteRentaIndependiente() As Double
        Return primerLimiteRentaIndependiente
    End Function

    Public Function obtenerSegundoLimiteRentaIndependiente() As Double
        Return segundoLimiteRentaIndependiente
    End Function

    Public Function obtenerTercerLimiteRentaIndependiente() As Double
        Return tercerLimiteRentaIndependiente
    End Function

    Public Function obtenerCuartoLimiteRentaIndependiente() As Double
        Return cuartoLimiteRentaIndependiente
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

    Public Function calculoMontoImpuestoRentaAsalariado(ByVal valor As Double) As Double
        Dim primerValor As Double = 0.00
        Dim segundoValor As Double = 0.00
        Dim tercerValor As Double = 0.00
        Dim monto As Double

        If valor <= obtenerPrimerLimiteRentaAsalariado() Then
            primerValor = valor * obtenerTercerTramoRentaAsalariado()
        End If

        If valor > obtenerPrimerLimiteRentaAsalariado() And valor <= obtenerSegundoLimiteRentaAsalariado() Then
            segundoValor = valor * obtenerSegundoTramoRentaAsalariado()
        End If

        If valor > obtenerSegundoLimiteRentaAsalariado() Then
            tercerValor = valor * obtenerPrimerTramoRentaAsalariado()
        End If

        monto = primerValor + segundoValor + tercerValor

        Return monto
    End Function

    Public Function calculoMontoImpuestoRentaIndependiente(ByVal valor As Double) As Double
        Dim primerValor As Double = 0.00
        Dim segundoValor As Double = 0.00
        Dim tercerValor As Double = 0.00
        Dim cuartoValor As Double = 0.00
        Dim quintoValor As Double = 0.00
        Dim monto As Double

        If valor <= obtenerPrimerLimiteRentaIndependiente() Then
            primerValor = valor * obtenerQuintoTramoRentaIndependiente()
        End If

        If valor > obtenerPrimerLimiteRentaIndependiente() And valor <= obtenerSegundoLimiteRentaIndependiente() Then
            segundoValor = valor * obtenerCuartoTramoRentaIndependiente()
        End If

        If valor > obtenerSegundoLimiteRentaIndependiente() And valor <= obtenerTercerLimiteRentaIndependiente() Then
            tercerValor = valor * obtenerTercerTramoRentaIndependiente()
        End If

        If valor > obtenerTercerLimiteRentaIndependiente() And valor <= obtenerCuartoLimiteRentaIndependiente() Then
            cuartoValor = valor * obtenerSegundoTramoRentaIndependiente()
        End If

        If valor > obtenerCuartoLimiteRentaIndependiente() Then
            quintoValor = valor * obtenerPrimerTramoRentaAsalariado()
        End If

        monto = primerValor + segundoValor + tercerValor + cuartoValor + quintoValor

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
