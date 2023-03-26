Module Module1
    Structure Employee
        Dim EmpName As String
        Dim EmpJob As String
        Dim EmpCity As String
        Dim EmpSal As Double
        Dim EmpID As Integer
    End Structure
    Public emps(10) As Employee
    Sub Main()
        emps(0).EmpName = "Sandeep"
        emps(0).EmpJob = "Software Developer"
        emps(0).EmpCity = "Sydney"
        emps(0).EmpSal = 60000
        emps(0).EmpID = 2707

        emps(1).EmpName = "Sara"
        emps(1).EmpJob = "Database Developer"
        emps(1).EmpCity = "Sydney"
        emps(1).EmpSal = 50000
        emps(1).EmpID = 2708

        emps(2).EmpName = "Andee"
        emps(2).EmpJob = "Software Tester"
        emps(2).EmpCity = "Sydney"
        emps(2).EmpSal = 40000
        emps(2).EmpID = 2709
    End Sub
End Module
