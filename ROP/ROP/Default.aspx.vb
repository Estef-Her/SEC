
Public Class ROP
    Inherits System.Web.UI.Page
    Dim Dao As DAO



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub



    'Limpia/Resetea todos los campos'
    Protected Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtNacim.Text = ""
        txtCapital.Text = ""
        txtEstimado.Text = ""
        radioListSexo.ClearSelection()

    End Sub


    'Realiza el calculo del estimado'
    Protected Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Dim anio As Integer
        Dim sex As Integer
        Dim dt As New DataTable
        Dim tasa As Double
        Dim tasaSeleccionada As String = Page.Request(DpDLtasaDeInteres.UniqueID)

        If tasaSeleccionada = "1%" Then
            tasa = 0.01
        End If

        If tasaSeleccionada = "2%" Then
            tasa = 0.02
        End If

        If tasaSeleccionada = "3%" Then
            tasa = 0.03
        End If

        If tasaSeleccionada = "4%" Then
            tasa = 0.04
        End If

        If tasaSeleccionada = "5%" Then
            tasa = 0.05
        End If

        'Convierte el texto del anio de nacimiento a integer'
        anio = CInt(txtNacim.Text)

        sex = CInt(radioListSexo.SelectedValue)

        dt = DAO.Get_qx(anio, sex)

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
        Dim resultadoFinal = Format(resultadoF, "0.0000")

        txtEstimado.Text = CStr(resultadoFinal)
    End Sub

End Class