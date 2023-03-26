Public Class Form1
    Dim arraysize As Integer
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call initialise()
        arraysize = list.GetUpperBound(0)
        'initialise employee number
        i = 0
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim count As Integer
        MyFileName = "file.txt"
        'open file
        MyCSVWriter = My.Computer.FileSystem.OpenTextFileWriter(MyFileName, False)

        For count = 0 To arraysize
            MyNewLine = list(count).ID & "," & list(count).fname & "," & list(count).sname
            MyCSVWriter.WriteLine(MyNewLine)
        Next
        'close file
        MyCSVWriter.Close()
    End Sub

    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
        Dim myfilename As String
        MyFileName = "file.txt"
        MyCSVReader = My.Computer.FileSystem.OpenTextFileReader(MyFileName)
        Line_Count = -1 'start at -1 so 1st record is 0

        Do While Not MyCSVReader.EndOfStream
            Line_Count = Line_Count + 1
            Dim MyFieldInput() As String = Split(MyCSVReader.ReadLine, ",")

            list(Line_Count).ID = MyFieldInput(0)
            list(Line_Count).fname = MyFieldInput(1)
            list(Line_Count).sname = MyFieldInput(2)
        Loop
        MyCSVReader.Close()

        TxtId.Text = list(0).ID
        TxtFname.Text = list(0).fname
        TxtSname.Text = list(0).sname
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If i > 9 Then
            i = 10
        Else
            i = i + 1
        End If
        TxtId.Text = list(i).ID
        TxtFname.Text = list(i).fname
        TxtSname.Text = list(i).sname
    End Sub

    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles BtnPrev.Click
        If i < 1 Then
            i = 0
        Else
            i = i - 1
        End If
        TxtId.Text = list(i).ID
        TxtFname.Text = list(i).fname
        TxtSname.Text = list(i).sname
    End Sub

    Private Sub TxtFname_TextChanged(sender As Object, e As EventArgs) Handles TxtFname.TextChanged
        list(i).fname = TxtFname.Text
    End Sub

    Private Sub TxtSname_TextChanged(sender As Object, e As EventArgs) Handles TxtSname.TextChanged
        list(i).sname = TxtSname.Text
    End Sub
End Class
