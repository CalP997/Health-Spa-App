Public Class Form1
    Dim mark As Integer
    Private Sub BtnIf_Click(sender As Object, e As EventArgs) Handles BtnIf.Click
        mark = Val(TxtMark.Text)
        If mark > 70 Then
            TxtResult.Text = "Distinction"
            TxtMark.BackColor = Color.Gold
        ElseIf mark > 40 Then
            TxtResult.Text = "Credit"
            TxtMark.BackColor = Color.Green
        Else
            TxtResult.Text = "Fail"
            TxtMark.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnCase_Click(sender As Object, e As EventArgs) Handles BtnCase.Click
        mark = Val(TxtMark.Text)
        Select Case mark
            Case 100
                TxtResult.Text = "100%"
                TxtResult.BackColor = Color.Gold

        End Select
    End Sub
End Class
