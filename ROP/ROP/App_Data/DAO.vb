﻿Imports System.Data
Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient



Public Class DAO
    Shared MysqlConn As MySqlConnection
    Shared COMMAND As MySqlCommand
    Shared READER As MySqlDataReader



    'Funcion publica que recibe el año de nacimiento y el sexo, y retorna un data table con todos los qx'
    Public Shared Function Get_qx(anio_nac As Integer, sex As Integer) As DataTable

        'En este string va todo lo necesario para conectarse a la base de datos, si es necesario cambiar el userid o el password aqui es'
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=root;database=sec_des"
        }
        Dim READER As MySqlDataReader

        'Extrae el anio actual para calcular la tabla de vida a partir de este anio'
        Dim currentYear As Integer = System.DateTime.Now.Year

        Try
            MysqlConn.Open()
            Dim Query As String
            Dim dt As New DataTable

            'Selecciona el qx para la tabla de vida segun el anio actual, el sexo y el anio de nacimiento'
            Query = "SELECT qx from sec_des.sec_des_tabla_vida WHERE year>='" & currentYear & "' AND year-edad = '" & anio_nac & "' AND sex='" & sex & "' order by edad;"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            dt.Load(READER)

            Return dt

        Catch ex As MySqlException
            'Imprime el error en un messagebox'
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    'Funcion publica que recibe el año de nacimiento y el sexo, y retorna un data table con todos los ex'
    Public Shared Function Get_ex(anio_nac As Integer, sex As Integer) As DataTable

        'En este string va todo lo necesario para conectarse a la base de datos, si es necesario cambiar el userid o el password aqui es'
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=root;database=sec_des"
        }
        Dim READER As MySqlDataReader

        'Extrae el anio actual para calcular la tabla de vida a partir de este anio'
        Dim currentYear As Integer = System.DateTime.Now.Year

        Try
            MysqlConn.Open()
            Dim Query As String
            Dim dt As New DataTable

            'Selecciona el ex para la tabla de vida segun el anio actual, el sexo y el anio de nacimiento'
            Query = "SELECT ex from sec_des.sec_des_tabla_vida WHERE year >= '" & currentYear & "' AND year-edad = '" & anio_nac & "' AND sex ='" & sex & "' order by edad;"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            dt.Load(READER)

            Return dt

        Catch ex As MySqlException
            'Imprime el error en un messagebox'
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    'Funcion publica que recibe el año de nacimiento y el sexo, y retorna un data table con todos los qobs_2005_10'
    Public Shared Function Get_qobs(anio_nac As Integer, sex As Integer) As DataTable

        'En este string va todo lo necesario para conectarse a la base de datos, si es necesario cambiar el userid o el password aqui es'
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=root;database=sec_des"
        }
        Dim READER As MySqlDataReader

        'Extrae el anio actual para calcular la tabla de vida a partir de este anio'
        Dim currentYear As Integer = System.DateTime.Now.Year

        Try
            MysqlConn.Open()
            Dim Query As String
            Dim dt As New DataTable

            'Selecciona el qobs para la tabla de vida segun el anio actual, el sexo y el anio de nacimiento'
            Query = "SELECT qobs_2005_10 from sec_des.sec_des_tabla_vida WHERE year >= '" & currentYear & "' AND year-edad = '" & anio_nac & "' AND sex ='" & sex & "' order by edad;"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            dt.Load(READER)

            Return dt
        Catch ex As MySqlException
            'Imprime el error en un messagebox'
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

End Class