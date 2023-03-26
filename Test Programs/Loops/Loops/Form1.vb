Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Byte
        For a = 1 To 4
            MessageBox.Show(a)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim b As Byte
        Do Until b = 5
            MessageBox.Show(b)
            b = b + 1
        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim c As Byte
        While c < 5
            MessageBox.Show(c)
            c = c + 1
        End While
    End Sub
End Class
