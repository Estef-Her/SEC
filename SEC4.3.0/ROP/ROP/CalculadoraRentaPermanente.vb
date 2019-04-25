Public Class CalculadoraRentaPermanente

    'Definicion de Metodos'

    Public Sub New()

    End Sub

    Public Function calculo(ByVal usuario As Usuario) As Double
        Dim rendimientos As Double() = usuario.obtenerRendimientos()
        Dim comisiones As Double() = usuario.obtenerComisiones()

        Dim sumaRendimientos = rendimientos(0) + rendimientos(1) + rendimientos(2) + rendimientos(3) +
                               rendimientos(4) + rendimientos(5) + rendimientos(6) + rendimientos(7) +
                               rendimientos(8) + rendimientos(9) + rendimientos(10) + rendimientos(11)

        Dim sumaComisiones = Math.Abs(comisiones(0)) + Math.Abs(comisiones(1)) + Math.Abs(comisiones(2)) +
                             Math.Abs(comisiones(3)) + Math.Abs(comisiones(4)) + Math.Abs(comisiones(5)) +
                             Math.Abs(comisiones(6)) + Math.Abs(comisiones(7)) + Math.Abs(comisiones(8)) +
                             Math.Abs(comisiones(9)) + Math.Abs(comisiones(10)) + Math.Abs(comisiones(11))

        Dim resultado = (sumaRendimientos - sumaComisiones) / 12
        Return resultado

    End Function

End Class
