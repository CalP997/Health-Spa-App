Public Class Form1
    Const payrate = 5
    Const overtime = 5.25
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        If Val(Txthours.Text) <= 30 Then
            Txtpay.Text = Str(Val(Txthours.Text) * payrate)
        End If
        If Val(Txthours.Text) > 30 Then
            Txtpay.Text = Str(Val(Txthours.Text) * overtime)
        End If
    End Sub
End Class
