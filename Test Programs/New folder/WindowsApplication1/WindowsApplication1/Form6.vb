Public Class Form6

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles BtnViewHome.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPrice_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrice.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub BtnBronze_Click(sender As System.Object, e As System.EventArgs) Handles BtnBronze.Click
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSilver_Click(sender As System.Object, e As System.EventArgs) Handles BtnSilver.Click
        Form11.Show()
        Me.Hide()
    End Sub

    Private Sub BtnGold_Click(sender As System.Object, e As System.EventArgs) Handles BtnGold.Click
        Form12.Show()
        Me.Hide()
    End Sub

    Private Sub BtnViewHelp_Click(sender As System.Object, e As System.EventArgs) Handles BtnViewHelp.Click
        Form17.Show()
    End Sub
End Class