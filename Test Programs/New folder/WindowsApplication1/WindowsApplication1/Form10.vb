Public Class Form10

    Private Sub BtnHomeBronze_Click(sender As Object, e As EventArgs) Handles BtnHomeBronze.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub BtnBronzeDiscount_Click(sender As Object, e As EventArgs) Handles BtnBronzeDiscount.Click
        LblType.Text = "Bronze"
        LblPriceM.Text = "£10"
        LblJacuzzi.Text = "£1.20"
        LblSauna.Text = "£1.20"
        LblSPool.Text = "£1.20"
    End Sub

    Private Sub BtnBronzeHelp_Click(sender As System.Object, e As System.EventArgs) Handles BtnBronzeHelp.Click
        Form20.Show()
    End Sub
End Class