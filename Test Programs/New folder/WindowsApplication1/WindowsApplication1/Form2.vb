Public Class Form2

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles BtnLogout.Click
        Form1.Show()
        Me.Hide()
        MsgBox("Logout successful", MsgBoxStyle.Information)
    End Sub

    Private Sub BtnMember_Click(sender As System.Object, e As System.EventArgs) Handles BtnMember.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPrices_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrices.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub BtnHelpHome_Click(sender As System.Object, e As System.EventArgs) Handles BtnHelpHome.Click
        Form13.Show()
    End Sub
End Class