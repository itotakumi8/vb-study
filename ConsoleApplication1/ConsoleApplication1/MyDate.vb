Public Class MyDate
    Public Year As Integer
    Public Month As Integer
    Public Day As Integer
    Public DayOfWeek As Integer

    Sub New(year As Integer, month As Integer, day As Integer)
        Me.Year = year
        Me.Month = month
        Me.Day = day
        Me.DayOfWeek = CalculateDayOfWeek(year, month, day)
    End Sub

    Shared Function CalculateDayOfWeek(year As Integer, month As Integer, day As Integer) As Integer
        Dim yearInt As Integer = year Mod 100

        yearInt = If((yearInt Mod 2 <> 0), (yearInt + 11) / 2, yearInt / 2)
        yearInt = If((yearInt Mod 2 <> 0), (yearInt + 11) Mod 7, yearInt Mod 7)

        Select Case yearInt
            Case 0
                Return 2
            Case 6
                Return 3
            Case 5
                Return 4
            Case 4
                Return 5
            Case 3
                Return 6
            Case 2
                Return 0
            Case 1
                Return 1
        End Select
        Return -1

    End Function

End Class
