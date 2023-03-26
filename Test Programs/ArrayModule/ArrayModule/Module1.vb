Module Module1
    Structure Employee
        Dim Ename As String
        Dim Ejob As String
        Dim Ecity As String
        Dim Esal As String
        Dim EID As String
    End Structure
    Public san As Employee
    'creating an instance of employee that can be seen on all forms and modules in project

    Sub Main()
        san.Ename = "Sandeep"
        san.Ejob = "Software Developer"
        san.Ecity = "Sidney"
        san.Esal = 60000
        san.EID = 2707
    End Sub
End Module
