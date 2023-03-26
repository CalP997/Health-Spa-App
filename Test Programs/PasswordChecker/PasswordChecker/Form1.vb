Public Class Form1

    Private Sub Btncheck_Click(sender As Object, e As EventArgs) Handles Btncheck.Click
        If Txtpass.Text <> "password" Then
            MsgBox("wrong password try again", vbCritical, "password error")
        End If
        If Txtpass.Text = "password" Then
            MsgBox("correct password", vbExclamation, "password ok")
        End If
    End Sub
End Class
