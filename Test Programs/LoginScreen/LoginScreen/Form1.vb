Public Class FrmLogin
    'description: This program simulates a logon sequence.
    'you can enter  the following combinations
    'admin admin
    'mark mk123
    'jane jj123
    Dim mypassword As String
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Select Case TxtUsername.Text
            Case "admin"
                mypassword = "admin"
            Case "mark"
                mypassword = "mk123"
            Case "Jane"
                mypassword = "jj123"
        End Select

        If TxtPassword.Text = mypassword Then
            MsgBox("well done - you have logged in sucessfully")
            frmMainMenu.Show()
            Me.Hide()
        Else
            MsgBox("sorry password incorrect", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
