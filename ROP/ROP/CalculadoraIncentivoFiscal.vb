Public Class CalculadoraIncentivoFiscal

    'Definicion de atributos'
    Private porcentajeLimite As Double
    Private primerTramoRenta As Double
    Private segundoTramoRenta As Double
    Private tercerTramoRenta As Double
    Private primerLimiteRenta As Double
    Private segundoLimiteRenta As Double
    Private primerMontoCarga As Double
    Private segundoMontoCarga As Double

    Public Sub New()
        Me.porcentajeLimite = 10 / 100
        Me.primerTramoRenta = 15 / 100
        Me.segundoTramoRenta = 10 / 100
        Me.tercerTramoRenta = 0
        Me.primerLimiteRenta = 799000.0
        Me.segundoLimiteRenta = 1199000.0
        Me.primerMontoCarga = 5.5 / 100
        Me.segundoMontoCarga = 3.34 / 100
    End Sub

    'Definicion de metodos'
    Public Sub cambiarPorcentajeLimite(ByVal porcentaje As Double)
        porcentajeLimite = porcentaje / 100
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

    Public Sub cambiarPrimerMontoCarga(ByVal monto As Double)
        primerMontoCarga = monto / 100
    End Sub

    Public Sub cambiarSegundoMontoCarga(ByVal monto As Double)
        segundoMontoCarga = monto / 100
    End Sub

    Public Function obtenerPorcentajeLimite() As Double
        Return porcentajeLimite
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

    Public Function obtenerPrimerMontoCarga() As Double
        Return primerMontoCarga
    End Function

    Public Function obtenerSegundoMontoCarga() As Double
        Return segundoMontoCarga
    End Function

    Public Function calculoMontoPorExonerar(ByVal usuario As Usuario) As Double
        Return (usuario.obtenerSalarioMensual() * obtenerPorcentajeLimite())
    End Function

    Public Function calculoSalarioImpuestos(ByVal usuario As Usuario) As Double
        Dim salario As Double

        If (usuario.obtenerSalarioMensual() * obtenerPorcentajeLimite()) > usuario.obtenerMontoAporte() Then
            salario = usuario.obtenerSalarioMensual() - usuario.obtenerMontoAporte()
        Else
            salario = usuario.obtenerSalarioMensual() - (usuario.obtenerSalarioMensual() * obtenerPorcentajeLimite())
        End If

        Return salario
    End Function

    Public Function calculoMontoImpuestoRenta(ByVal valor As Double) As Double
        Dim monto As Double

        If valor <= obtenerPrimerLimiteRenta() Then
            monto = valor * obtenerTercerTramoRenta()
        End If

        If valor > obtenerPrimerLimiteRenta() And valor <= obtenerSegundoLimiteRenta() Then
            monto = valor * obtenerSegundoTramoRenta()
        End If

        If valor > obtenerSegundoLimiteRenta() Then
            monto = valor * obtenerPrimerTramoRenta()
        End If

        Return monto
    End Function

    Public Function calculoMontoCargasSociales(ByVal valor As Double) As Double
        Return (valor * obtenerPrimerMontoCarga()) + (valor * obtenerSegundoMontoCarga())
    End Function

    Public Function sumaTotalImpuestos(ByVal primerValor As Double, ByVal segundoValor As Double) As Double
        Return primerValor + segundoValor
    End Function

    Public Function diferenciaImpuestos(ByVal primerValor As Double, ByVal segundoValor As Double) As Double
        Return primerValor - segundoValor
    End Function

    Public Function calculoFinal(ByVal valor As Double, ByVal usuario As Usuario) As Double
        Return usuario.obtenerMontoAporte() - valor
    End Function

End Class
