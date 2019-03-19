﻿Public Class Usuario

    'Definicion de Atributos'

    Private fechaNacimiento As String
    Private capitalPension As Integer
    Private sexo As Integer
    Private rendimientos(12) As Double
    Private comisiones(12) As Double

    'Definicion de Metodos'

    Public Sub New()
        Me.fechaNacimiento = ""
        Me.capitalPension = 0
        Me.sexo = 0
    End Sub

    Public Sub cambiarFechaNacimiento(ByVal fecha As String)
        fechaNacimiento = fecha
    End Sub

    Public Sub cambiarCapitalPension(ByVal capital As Integer)
        capitalPension = capital
    End Sub

    Public Sub cambiarSexo(ByVal valorSexo As Integer)
        sexo = valorSexo
    End Sub

    Public Sub cambiarRendimientos(ByVal arregloRendimientos() As Double)
        rendimientos = arregloRendimientos
    End Sub

    Public Sub cambiarComisiones(ByVal arregloComisiones() As Double)
        comisiones = arregloComisiones
    End Sub

    Public Function obtenerFechaNacimiento() As String
        Return fechaNacimiento
    End Function

    Public Function obtenerCapitalPension() As Integer
        Return capitalPension
    End Function

    Public Function obtenerSexo() As Integer
        Return sexo
    End Function

    Public Function obtenerRendimientos() As Double()
        Return rendimientos
    End Function

    Public Function obtenerComisiones() As Double()
        Return comisiones
    End Function

End Class
