Public Class Form1
    Dim total1 As Integer
    Dim total2 As Integer
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn0_Click(sender As System.Object, e As System.EventArgs) Handles Btn0.Click
        TxtDisplay.Text = TxtDisplay.Text & Btn0.Text
    End Sub

    Private Sub Btn1_Click(sender As System.Object, e As System.EventArgs) Handles Btn1.Click
        TxtDisplay.Text = TxtDisplay.Text & Btn1.Text
    End Sub

    Private Sub Btn2_Click(sender As System.Object, e As System.EventArgs) Handles Btn2.Click
        TxtDisplay.Text = TxtDisplay.Text & Btn2.Text
    End Sub

    Private Sub Btn3_Click(sender As System.Object, e As System.EventArgs) Handles Btn3.Click
        TxtDisplay.Text = TxtDisplay.Text & Btn3.Text
    End Sub

    Private Sub Btn4_Click(sender As System.Object, e As System.EventArgs) Handles Btn4.Click
        TxtDisplay.Text = TxtDisplay.Text & Btn4.Text
    End Sub

    Private Sub Btn5_Click(sender As System.Object, e As System.EventArgs) Handles Btn5.Click
        TxtDisplay.Text = TxtDisplay.Text & Btn5.Text
    End Sub

    Private Sub Btn6_Click(sender As System.Object, e As System.EventArgs) Handles Btn6.Click
        TxtDisplay.Text = TxtDisplay.Text & Btn6.Text
    End Sub

    Private Sub Btn7_Click(sender As System.Object, e As System.EventArgs) Handles Btn7.Click
        TxtDisplay.Text = TxtDisplay.Text & Btn7.Text
    End Sub

    Private Sub Btn8_Click(sender As System.Object, e As System.EventArgs) Handles Btn8.Click
        TxtDisplay.Text = TxtDisplay.Text & Btn8.Text
    End Sub

    Private Sub Btn9_Click(sender As System.Object, e As System.EventArgs) Handles Btn9.Click
        TxtDisplay.Text = TxtDisplay.Text & Btn9.Text
    End Sub

    Private Sub cmdClear_Click(sender As System.Object, e As System.EventArgs) Handles cmdClear.Click
        TxtDisplay.Clear()
    End Sub

    Private Sub cmdPlus_Click(sender As System.Object, e As System.EventArgs) Handles cmdPlus.Click
        total1 = total1 + Val(TxtDisplay.Text)
        TxtDisplay.Clear()
    End Sub

    Private Sub cmdEquals_Click(sender As System.Object, e As System.EventArgs) Handles cmdEquals.Click
        total2 = total1 + Val(TxtDisplay.Text)
        TxtDisplay.Text = total2
        total1 = 0
    End Sub
End Class
