Public Class Form5
    Dim counter As Integer
    Dim found As Boolean
    Dim searchitem As Integer
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles BtnEditHome.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BtnShow.Click
        counter = 0 'initialise the counter
        found = False
        Filename = "BankHealthSpa.txt"
        FileOpen(1, Filename, OpenMode.Random, , , Len(members))
        searchitem = InputBox("Enter member ID")
        Do While found = False And (Not EOF(1))
            counter = counter + 1
            FileGet(1, members, counter)
            If Trim(members.MemberNo) = searchitem Then
                found = True
            End If
        Loop
        If found = True Then
            TxtEditName.Text = members.MemberName 'display details in textboxes
            TxtEditAdLine1.Text = members.AdressLine1
            TxtEditAdLine2.Text = members.AdressLine2
            TxtEditAdLine3.Text = members.AdressLine3
            TxtEditPostcode.Text = members.PostCode
            TxtEditEmail.Text = members.Email
            TxtEditNotes.Text = members.Notes
            TxtEditMemberID.Text = members.MemberNo
            TxtEditType.Text = members.MemberType
            TxtStart.Text = members.StartDate
            TxtEnd.Text = members.EndDate
            GbxEdit.Visible = True 'show groupbox
        Else
            MsgBox("Member not found")
        End If
        FileClose()
    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        Filename = "BankHealthSpa.txt" 'file name/location
        FileOpen(1, Filename, OpenMode.Random, , , Len(members))
        NumberOfRecords = LOF(1) / Len(members)
        members.MemberName = TxtEditName.Text 'set attribute = to edit
        members.AdressLine1 = TxtEditAdLine1.Text
        members.AdressLine2 = TxtEditAdLine2.Text
        members.AdressLine3 = TxtEditAdLine3.Text
        members.PostCode = TxtEditPostcode.Text
        members.Email = TxtEditEmail.Text
        members.Notes = TxtEditNotes.Text
        members.MemberType = TxtEditType.Text
        members.StartDate = TxtStart.Text
        members.EndDate = TxtEnd.Text
        FilePut(1, members, counter)
        MsgBox("Record editted")
        FileClose()
    End Sub

    Private Sub BtnEditHelp_Click(sender As System.Object, e As System.EventArgs) Handles BtnEditHelp.Click
        Form16.Show()
    End Sub
End Class