
Public Class ROP
    Inherits System.Web.UI.Page
    Dim Dao As DAO





    'Limpia/Resetea todos los campos'



    'Realiza el calculo del estimado'
    Protected Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Dim anio As Integer
        Dim sex As Integer
        Dim dt As New DataTable
        Dim tasa As Double = CDbl(txtTasa.Text) / 100

        'Convierte el texto del anio de nacimiento a integer'
        Dim s As String = ""

        For index As Integer = 4 To 1 Step -1
            s = s + txtNacim.Text.ElementAt(txtNacim.Text.Length - index)
        Next

        anio = CInt(s)

        sex = CInt(radioListSexo.SelectedValue)

        Dim fechaCumpleanos1 As String = txtNacim.Text.Remove(6, 4)
        Dim fechaCumpleanos2 As String = txtNacim.Text.Remove(6, 4)
        Dim actualYear As Integer = System.DateTime.Now.Year
        Dim nextYear As Integer = System.DateTime.Now.Year + 1
        Dim year1 As String = CStr(actualYear)
        Dim year2 As String = CStr(nextYear)
        fechaCumpleanos1 = fechaCumpleanos1 + year1
        fechaCumpleanos2 = fechaCumpleanos2 + year2

        Dim fechaActual As DateTime = System.DateTime.Now.Date
        Dim cumpleanios As DateTime = DateTime.ParseExact(fechaCumpleanos1, "dd/MM/yyyy", Nothing)
        Dim cumpleanios2 As DateTime = DateTime.ParseExact(fechaCumpleanos2, "dd/MM/yyyy", Nothing)
        Dim cantidadDias As Integer = DateDiff("d", fechaActual, cumpleanios)

        If cantidadDias < 0 Then
            cantidadDias = DateDiff("d", fechaActual, cumpleanios2)
            If cantidadDias <= 182 Then
                anio = anio - 1
                dt = DAO.Get_qx(anio, sex)
            Else
                dt = DAO.Get_qx(anio, sex)
            End If
        Else
            If cantidadDias <= 182 Then
                dt = DAO.Get_qx(anio, sex)
            Else
                anio = anio - 1
                dt = DAO.Get_qx(anio, sex)
            End If
        End If

        'Se procede a realizar un array de qx'

        Dim myArray(dt.Rows.Count + 1) As String
        Dim i As Integer = 0
        For Each dr As DataRow In dt.Rows
            Dim myString = dt.Rows(i).Item(0)
            myArray(i) = myString
            i = i + 1
        Next
        myArray(dt.Rows.Count) = "1"

        'Se procede a realizar un array de t'

        Dim arrayT(dt.Rows.Count + 1) As String
        For j As Integer = 0 To dt.Rows.Count
            arrayT(j) = CStr(j)
        Next

        'Se procede a realizar un array de tPx'

        Dim arrayTPX(dt.Rows.Count + 1) As String
        arrayTPX(0) = "1"
        For x As Integer = 1 To dt.Rows.Count - 1
            Dim dato1 = CDbl(arrayTPX(x - 1))
            Dim dato2 = 1 - CDbl(myArray(x - 1))
            Dim dato3 = dato1 * dato2
            arrayTPX(x) = CStr(dato3)
        Next
        arrayTPX(dt.Rows.Count) = "0"

        'Se procede a realizar un array de 1/(1+r)^t'
        Dim arrayR(dt.Rows.Count + 1) As String
        For y As Integer = 0 To dt.Rows.Count
            Dim dato1 = 1 / (((1 + tasa)) ^ CInt(arrayT(y)))
            arrayR(y) = CStr(dato1)
        Next

        'Se procede a realizar un array de multiplicacion'
        Dim arrayM(dt.Rows.Count + 1) As String
        For z As Integer = 0 To dt.Rows.Count
            Dim dato1 = CDbl(arrayTPX(z)) * CDbl(arrayR(z))
            arrayM(z) = CStr(dato1)
        Next

        'Se realiza la sumatoria final'
        Dim suma As Double = 0
        For w As Integer = 0 To dt.Rows.Count
            suma = suma + arrayM(w)
        Next

        'Calculo VANU'
        Dim VANU = 12 * (suma - (11 / 24))


        'Se realiza el calculo final'
        Dim capital = CDbl(txtCapital.Text)
        Dim resultadoF = capital / VANU
        Dim resultadoFinal = FormatNumber(resultadoF, 2)
        txtEstimado.Text = CStr("₡" + resultadoFinal)
        Label4.Visible = True
        txtEstimado.Visible = True


    End Sub

End Class