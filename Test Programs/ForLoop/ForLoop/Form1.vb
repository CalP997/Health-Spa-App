Public Class Form1

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim startnumber As Byte
        Dim endnumber As Byte
        Dim answer As Integer
        Dim counter As Byte
        Dim range As String
        range = ""
        startnumber = TxtStart.Text
        endnumber = TxtEnd.Text
        For counter = startnumber To endnumber
            answer = answer + counter
            range = range & counter & ", "
        Next counter
        Label4.Text = answer
        Label6.Text = range
    End Sub
End Class
