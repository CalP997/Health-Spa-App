Module Module1
    Structure Employee
        Dim EmpName As String
        Dim EmpJob As String
        Dim EmpCity As String
        Dim EmpSal As Double
        Dim EmpID As Integer
    End Structure
    Public san As Employee
    Sub Main()
        san.EmpName = "Sandeep"
        san.EmpJob = "Software Developer"
        san.EmpCity = "Sydney"
        san.EmpSal = "60000"
        san.EmpID = "2707"
    End Sub
End Module
