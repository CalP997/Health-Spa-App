Public Class Form12

    Private Sub BtnHomeGold_Click(sender As Object, e As EventArgs) Handles BtnHomeGold.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub BtnGoldDiscount_Click(sender As Object, e As EventArgs) Handles BtnGoldDiscount.Click
        LblType.Text = "Gold"
        LblPriceM.Text = "£20"
        LblJacuzzi.Text = "Free"
        LblSauna.Text = "Free"
        LblSPool.Text = "Free"
    End Sub

    Private Sub BtnGoldHelp_Click(sender As System.Object, e As System.EventArgs) Handles BtnGoldHelp.Click
        Form22.Show()
    End Sub
End Class