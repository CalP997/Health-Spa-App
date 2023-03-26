Public Class Form1
    Dim arraysize As Integer
    'used to keep employee number
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Main()
        TxtName.Text = emps(0).EmpName
        TxtJob.Text = emps(0).EmpJob
        TxtCity.Text = emps(0).EmpCity
        TxtSal.Text = emps(0).EmpSal
        TxtID.Text = emps(0).EmpID

        'get no of emps in array
        arraysize = emps.GetUpperBound(0)
        MsgBox(arraysize)

        LblNum.Text = i
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        i = LblNum.Text
        If i > 9 Then
            i = 10
        Else
            i = i + i
        End If
        LblNum.Text = i
        emps(i).EmpName = TxtName.Text
        emps(i).EmpJob = TxtJob.Text
        emps(i).EmpCity = TxtCity.Text
        emps(i).EmpSal = TxtSal.Text
        emps(i).EmpID = TxtID.Text
    End Sub

    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles BtnPrev.Click
        LblNum.Text = i
        If i < 1 Then
            i = 0
        Else
            i = i - i
        End If
        LblNum.Text = i
        TxtName.Text = emps(i).EmpName
        TxtJob.Text = emps(i).EmpJob
        TxtCity.Text = emps(i).EmpCity
        TxtSal.Text = emps(i).EmpSal
        TxtID.Text = emps(i).EmpID
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged
        emps(i).EmpName = TxtName.Text
    End Sub

    Private Sub TxtJob_TextChanged(sender As Object, e As EventArgs) Handles TxtJob.TextChanged
        emps(i).EmpJob = TxtJob.Text
    End Sub

    Private Sub TxtCity_TextChanged(sender As Object, e As EventArgs) Handles TxtCity.TextChanged
        emps(i).EmpCity = TxtCity.Text
    End Sub

    Private Sub TxtSal_TextChanged(sender As Object, e As EventArgs) Handles TxtSal.TextChanged
        emps(i).EmpSal = TxtSal.Text
    End Sub

    Private Sub TxtID_TextChanged(sender As Object, e As EventArgs) Handles TxtID.TextChanged
        emps(i).EmpID = TxtID.Text
    End Sub
End Class
