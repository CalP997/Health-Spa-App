Public Class Form1
    'declare text
    Dim text1 As String = ""
    Dim text2 As String = ""
    Dim text3 As String = ""
    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        If CheckBox1.Checked = True Then
            text1 = "check 1 "
        End If
        If CheckBox2.Checked = True Then
            text2 = "check 2 "
        End If
        If CheckBox3.Checked = True Then
            text3 = "check 3 "
        End If
        'msg box display those clicked
        MsgBox(text1 & text2 & text3 & "selected")
    End Sub
End Class
