Public Class Form1

    Private Sub BtnLetters_Click(sender As Object, e As EventArgs) Handles BtnLetters.Click
        Dim numberofletters As Byte
        Dim letters As String
        Dim counter As Byte
        numberofletters = TxtNum.Text
        For counter = 1 To numberofletters
            letters = letters & Chr(64 + counter)
        Next counter
        Lblletters.Text = letters
        End If
    End Sub
End Class
