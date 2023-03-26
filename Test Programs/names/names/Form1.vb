Public Class Form1
    Dim firstname As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        firstname = TxtDisplay.Text
        If firstname = "Bill" Then
            MsgBox("firstname = Bill")
        Else
            MsgBox("Firstname doesnt = Bill")
        End If
    End Sub
End Class
