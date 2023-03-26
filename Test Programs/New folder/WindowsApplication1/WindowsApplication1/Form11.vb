Public Class Form11

    Private Sub BtnHomeSilver_Click(sender As Object, e As EventArgs) Handles BtnHomeSilver.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSilverDiscount_Click(sender As Object, e As EventArgs) Handles BtnSilverDiscount.Click
        LblType.Text = "Silver"
        LblPriceM.Text = "£15"
        LblJacuzzi.Text = "80p"
        LblSauna.Text = "80p"
        LblSPool.Text = "Free"
    End Sub

    Private Sub BtnSilverHelp_Click(sender As System.Object, e As System.EventArgs) Handles BtnSilverHelp.Click
        Form21.Show()
    End Sub
End Class