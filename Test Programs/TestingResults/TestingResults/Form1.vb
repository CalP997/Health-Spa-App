Public Class Form1
    Dim number1 As Integer
    Dim number2 As Integer
    Dim number3 As Integer
    Dim number As Integer
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        number1 = 1
        number2 = 2
        number3 = number1 + number2
        number3 = number3 / 1
        MsgBox(number3 * 2 ^ 100)
    End Sub
End Class