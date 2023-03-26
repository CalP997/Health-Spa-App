Module Module1
    Public MyCSVWriter As System.IO.StreamWriter
    Public MyFileName As String
    Public MyNewLine As String

    Public MyCSVReader As System.IO.StreamReader
    Public Line_Count As Integer

    Structure member
        Dim ID As Integer
        Dim fname As String
        Dim sname As String
    End Structure
    Public list(10) As member
    'set up array
    Sub initialise()
        list(0).ID = 0
        list(0).fname = "John"
        list(0).sname = "Smith"
        list(1).ID = 1
        list(1).fname = "Ann"
        list(1).sname = "Jones"
        list(2).ID = 2
        list(2).fname = "Mo"
        list(2).sname = "Farah"
        list(3).ID = 3
        list(3).fname = "Ali"
        list(3).sname = "Brewster"
        list(4).ID = 4
        list(4).fname = "Zara"
        list(4).sname = "Phillips"
    End Sub
End Module
