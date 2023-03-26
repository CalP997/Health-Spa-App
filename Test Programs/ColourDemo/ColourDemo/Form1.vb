Public Class Form1

    Private Sub RadRed_CheckedChanged(sender As Object, e As EventArgs) Handles RadRed.CheckedChanged
        If Chk1.Checked = True Then
            Txt1.BackColor = Color.Red
        End If
        If Chk2.Checked = True Then
            Txt2.BackColor = Color.Red
        End If

    End Sub

    Private Sub RadBlue_CheckedChanged(sender As Object, e As EventArgs) Handles RadBlue.CheckedChanged
        If Chk1.Checked = True Then
            Txt1.BackColor = Color.Blue
        End If
        If Chk2.Checked = True Then
            Txt2.BackColor = Color.Blue
        End If
    End Sub

    Private Sub RadGreen_CheckedChanged(sender As Object, e As EventArgs) Handles RadGreen.CheckedChanged
        If Chk1.Checked = True Then
            Txt1.BackColor = Color.Green
        End If
        If Chk2.Checked = True Then
            Txt2.BackColor = Color.Green
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
