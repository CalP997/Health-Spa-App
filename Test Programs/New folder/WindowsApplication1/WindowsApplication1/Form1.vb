Public Class Form1
    Dim MyPassword As String
    Private Sub BtnLogin_Click(sender As System.Object, e As System.EventArgs) Handles BtnLogin.Click
        Select Case TxtUsername.Text
            Case "admin"
                MyPassword = "admin" 'input for admin
                Form2.Show()
                Me.Hide()
            Case "Guest"
                MyPassword = "Guest" 'input for startup user
                Form4.Show()
                Me.Hide()
            Case "Callum"
                MyPassword = "Callump97" 'valid user input
                Form2.Show()
                Me.Hide()
        End Select
                If TxtPassword.Text = "" Then
            MsgBox("No input given")
        Else
            If TxtPassword.Text <> MyPassword Then
                MsgBox("Incorrect input")
            End If
            End If
    End Sub

    Private Sub BtnExit_Click(sender As System.Object, e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnLoginHelp_Click(sender As System.Object, e As System.EventArgs) Handles BtnLoginHelp.Click
        Form7.Show()
    End Sub
End Class
