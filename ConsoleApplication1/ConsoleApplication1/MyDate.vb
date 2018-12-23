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
        Dim step1 As Integer
        Dim step2 As Integer
        Dim step3 As Integer

        step1 = year Mod 100
        step2 = If(step1 Mod 2 = 0, step1, step1 + 11) / 2
        step3 = If(step2 Mod 2 = 0, step2, step2 + 11) Mod 7

        Dim doomsday As Integer

        Select Case step3
            Case 0
                doomsday = 2
            Case 6
                doomsday = 3
            Case 5
                doomsday = 4
            Case 4
                doomsday = 5
            Case 3
                doomsday = 6
            Case 2
                doomsday = 0
            Case 1
                doomsday = 1
            Case Else
                doomsday = -1

        End Select

        Dim yearIsUruu As Boolean = True

        If year Mod 400 = 0 Then
            yearIsUruu = True

        ElseIf year Mod 100 = 0 Then
            yearIsUruu = False

        ElseIf year Mod 4 = 0 Then
            yearIsUruu = True

        Else
            yearIsUruu = False
        End If

        Select Case month
            Case 1
                If yearIsUruu = True Then
                    Return (doomsday - 4 + day + 7) Mod 7
                Else
                    Return (doomsday - 3 + day + 7) Mod 7
                End If
            Case 2
                If yearIsUruu = True Then
                    Return (doomsday - 29 + day + 35) Mod 7
                Else
                    Return (doomsday - 28 + day + 28) Mod 7
                End If
            Case 3
                Return (doomsday - 7 + day + 7) Mod 7
            Case 4
                Return (doomsday - 4 + day + 7) Mod 7
            Case 5
                Return (doomsday - 9 + day + 14) Mod 7
            Case 6
                Return (doomsday - 6 + day + 7) Mod 7
            Case 7
                Return (doomsday - 11 + day + 14) Mod 7
            Case 8
                Return (doomsday - 8 + day + 14) Mod 7
            Case 9
                Return (doomsday - 5 + day + 7) Mod 7
            Case 10
                Return (doomsday - 10 + day + 14) Mod 7
            Case 11
                Return (doomsday - 7 + day + 7) Mod 7
            Case 12
                Return (doomsday - 12 + day + 14) Mod 7
        End Select

    End Function

End Class
