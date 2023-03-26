Public Class Form4

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles BtnStartHome.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCreate_Click(sender As System.Object, e As System.EventArgs) Handles BtnCreate.Click
        i = 0
        Filename = "BankHealthSpa.txt"
        members.MemberName = TxtName.Text
        members.AdressLine1 = TxtAdLine1.Text
        members.AdressLine2 = TxtAdLine2.Text
        members.AdressLine3 = TxtAdLine3.Text
        members.PostCode = TxtPostcode.Text
        members.Mobile = TxtMobile.Text
        members.Email = TxtEmail.Text
        members.Notes = TxtNotes.Text
        members.StartDate = StartDate.Value
        members.EndDate = EndDate.Value
        members.MemberNo = TxtMemberID.Text
        members.MemberType = CbxType.Text
        StartDate.MinDate = Date.Today
        EndDate.MinDate = Date.Now.AddYears(1)
        If Len(TxtMobile.Text) <> 11 Then
            MsgBox("Mobile number not accepted. Please ensure your details are correct.")
        Else
            FileOpen(1, Filename, OpenMode.Random, , , Len(members))
            NumberOfRecords = LOF(1) / Len(members)
            i = i + i
            FilePut(1, members, NumberOfRecords + 1)
            FileClose(1)
            MsgBox("Membership created successfully")
        End If
    End Sub

    Private Sub BtnStartHelp_Click(sender As System.Object, e As System.EventArgs) Handles BtnStartHelp.Click
        Form15.Show()
    End Sub
End Class