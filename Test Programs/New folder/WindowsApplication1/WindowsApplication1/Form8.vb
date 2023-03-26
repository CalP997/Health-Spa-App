Public Class Form8

    Private Sub BtnNext_Click(sender As System.Object, e As System.EventArgs) Handles BtnNext.Click
        Filename = "BankHealthSpa.txt"
        FileOpen(1, Filename, OpenMode.Random, , , Len(members))
        NumberOfRecords = LOF(1) / Len(members)
        LstOutput.Items.Clear()
        For index = 1 To NumberOfRecords
            FileGet(1, members) 'show all member details
            LstOutput.Items.Add(members.MemberName & " " & members.AdressLine1 & " " & members.AdressLine2 & " " & members.AdressLine3 & " " & members.Email & " " & members.Notes & members.MemberNo & " " & members.MemberType & " " & members.StartDate & "    " & members.EndDate)
        Next index
        FileClose(1)
    End Sub
   
    Private Sub BtnMemberHome_Click(sender As System.Object, e As System.EventArgs) Handles BtnMemberHome.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMemberHelp_Click(sender As System.Object, e As System.EventArgs) Handles BtnMemberHelp.Click
        Form18.Show()
    End Sub
End Class