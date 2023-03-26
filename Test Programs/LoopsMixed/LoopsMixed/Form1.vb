Public Class Form1
    Private Sub BtnFor_Click(sender As Object, e As EventArgs) Handles BtnFor.Click
        Dim count As Integer
        count = 1
        For count = 1 To 10
            LstOutput.Items.Add(count)
        Next
    End Sub

    Private Sub BtnDo_Click(sender As Object, e As EventArgs) Handles BtnDo.Click
        Dim count As Integer
        count = 1
        Do
            LstOutput.Items.Add(count)
            count = count + 1
        Loop While (count < 11)
    End Sub

    Private Sub BtnWhile_Click(sender As Object, e As EventArgs) Handles BtnWhile.Click
        Dim count As Integer
        While (count < 11)
            LstOutput.Items.Add(count)
            count = count + 1
        End While
    End Sub
End Class
