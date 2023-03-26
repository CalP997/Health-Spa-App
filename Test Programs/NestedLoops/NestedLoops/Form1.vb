Public Class Form1

    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles BtnGo.Click
        Dim startnumber As Integer
        Dim endnumber As Integer
        Dim multiplier As Byte
        Dim answer As Integer
        Dim i As Byte
        startnumber = TxtStart.Text
        endnumber = TxtEnd.Text
        Do While multiplier < 3
            For i = startnumber To endnumber
                answer = i * multiplier
                LstOutput.Items.Add(i & " Times " & multiplier & " = " & answer)
            Next i
            multiplier = multiplier + 1
        Loop
    End Sub
End Class
