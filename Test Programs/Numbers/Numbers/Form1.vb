Public Class Form1
    Dim num1, num2, largenum As Integer
    Private Sub BtnNumber_Click(sender As Object, e As EventArgs) Handles BtnNumber.Click
        num1 = Val(Txtnum1.Text)
        num2 = Val(Txtnum2.Text)
        If num1 > num2 Then
            largenum = num1
            TxtDisplay.Text = "The largest number is " + largenum
        ElseIf num1 < num2 Then
            largenum = num2
            TxtDisplay.Text = "The largest number is " + largenum
        Else : num1 = num2
            TxtDisplay.Text = "Both numbers are the same"
        End If
        TxtDisplay.Clear()

    End Sub
End Class
