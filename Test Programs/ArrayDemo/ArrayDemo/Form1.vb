Public Class Form1
    Dim myArray(10) As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myArray(0) = 23
        myArray(1) = 34
        myArray(2) = 55
    End Sub
    Private Sub BtnInitialise_Click(sender As Object, e As EventArgs) Handles BtnInitialise.Click
        Dim i As Integer
        For i = 0 To 10
            myArray(i) = 0
        Next
    End Sub

    Private Sub BtnSetVal_Click(sender As Object, e As EventArgs) Handles BtnSetVal.Click
        myArray(0) = 100
        myArray(10) = 99
    End Sub

    Private Sub BtnList_Click(sender As Object, e As EventArgs) Handles BtnList.Click
        Dim i As Integer
        Dim line As String
        line = ""
        For i = 0 To 10
            line = line & "element " & i & " = " & myArray(i) & vbCrLf
        Next
        MsgBox(line)
    End Sub

    Private Sub BtnChange_Click(sender As Object, e As EventArgs) Handles BtnChange.Click
        Dim element As Integer
        Dim value As Integer
        element = TextBox1.Text
        value = TextBox2.Text
        myArray(element) = value
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub BtnSort_Click(sender As Object, e As EventArgs) Handles BtnSort.Click
        Dim x, y, temp As Integer
        ' MsgBox(UBound(myArray))
        For y = 0 To UBound(myArray) - 1
            For x = 0 To UBound(myArray) - 1
                If myArray(x) > myArray(x + 1) Then
                    temp = myArray(x + 1)
                    myArray(x + 1) = myArray(x)
                    myArray(x) = temp
                End If
            Next x
        Next y
    End Sub
End Class
