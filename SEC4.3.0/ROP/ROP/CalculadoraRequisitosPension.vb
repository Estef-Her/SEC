Public Class CalculadoraRequisitosPension

    Public Sub New()

    End Sub

    Public Function calculoCotizacionesContinuas(ByVal usuario As Usuario) As String

        Dim s As String = ""
        Dim anios As Integer
        Dim meses As Integer
        Dim cotizaciones As Integer = usuario.obtenerCotizaciones()
        Dim fechaNacimiento As String = usuario.obtenerFechaNacimiento()
        Dim primeraFecha As DateTime = DateTime.ParseExact(fechaNacimiento, "dd/MM/yyyy", Nothing)
        Dim fechaActual As DateTime = System.DateTime.Now.Date
        Dim segundaFecha = fechaActual
        'Dim segundaFecha As DateTime = DateTime.ParseExact(fechaActual, "dd/MM/yyyy", Nothing)
        Dim cantidadAnios As Integer = DateDiff("yyyy", primeraFecha, segundaFecha)
        Dim anioActual As Integer = System.DateTime.Now.Year
        Dim cumpleanios As String = fechaNacimiento.Remove(6, 4) + CStr(anioActual)
        Dim terceraFecha As DateTime = DateTime.ParseExact(cumpleanios, "dd/MM/yyyy", Nothing)
        Dim cantidadMeses As Integer = DateDiff("yyyy", segundaFecha, terceraFecha)
        anios = cantidadAnios
        meses = 12 - cantidadMeses

        If meses = 12 Then
            meses = 11
        End If

        'Dim cotizacionesUsuario As Integer = usuario.obtenerCotizaciones()
        Dim tablaValor As New DataTable
        tablaValor = DAO.obtenerCotizacionesHombres(anios, meses)
        Dim cotizacionesValor As Integer = CInt(tablaValor.Rows(0).Item(0))

        If cotizaciones >= cotizacionesValor Then
            s = "Se pensiona con " + CStr(cotizacionesValor) + " cotizaciones a los " + CStr(anios) + " años con " + CStr(meses) + " meses"
        Else
            While (cotizaciones < cotizacionesValor)
                meses = meses + 1
                If meses = 12 Then
                    meses = 0
                    anios = anios + 1
                End If
                usuario.cambiarCotizaciones(usuario.obtenerCotizaciones() + 1)
                tablaValor = DAO.obtenerCotizacionesHombres(anios, meses)
                cotizacionesValor = CInt(tablaValor.Rows(0).Item(0))
            End While
            s = "Se pensiona con " + CStr(cotizacionesValor) + " cotizaciones a los " + CStr(anios) + " años con " + CStr(meses) + " meses"

        End If

        Return s


    End Function

End Class
