Module Module1
    Structure Member
        <VBFixedString(40)> Dim MemberName As String 'brackets show max length
        <VBFixedString(50)> Dim AdressLine1 As String
        <VBFixedString(40)> Dim AdressLine2 As String
        <VBFixedString(40)> Dim AdressLine3 As String
        <VBFixedString(7)> Dim PostCode As String
        <VBFixedString(11)> Dim Mobile As String
        <VBFixedString(25)> Dim Email As String
        <VBFixedString(75)> Dim Notes As String
        Dim StartDate As Date
        Dim EndDate As Date
        Dim MemberNo As Double
        <VBFixedString(6)> Dim MemberType As String

    End Structure
    Public Filename As String = "BankHealthSpa.txt" 'declaration of file
    Public members As Member
    Public NumberOfRecords As Integer
    Public i As Integer
End Module
