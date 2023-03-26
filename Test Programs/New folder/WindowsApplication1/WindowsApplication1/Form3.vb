Public Class Form3

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles BtnMemberHome.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BtStartMembership_Click(sender As System.Object, e As System.EventArgs) Handles BtStartMembership.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub BtnEditMembership_Click(sender As System.Object, e As System.EventArgs) Handles BtnEditMembership.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub BtnView_Click(sender As System.Object, e As System.EventArgs) Handles BtnView.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMemberHelp_Click(sender As System.Object, e As System.EventArgs) Handles BtnMemberHelp.Click
        Form14.Show()
    End Sub
End Class