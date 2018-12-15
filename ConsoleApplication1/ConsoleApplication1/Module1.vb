Module Module1

    Sub Main()
        Dim firstDayOfMonth As Date = New Date(2018, 4, 1)
        RenderCalender(firstDayOfMonth.DayOfWeek, Date.DaysInMonth(firstDayOfMonth.Year, firstDayOfMonth.Month))
    End Sub

    Sub RenderCalender(firstDay As Integer, dayLength As Integer)

        Console.WriteLine("日 月 火 水 木 金 土")
        For i = 1 To firstDay
            Console.Write("   ")
        Next

        For i = 1 To dayLength
            If i < 10 Then
                Console.Write(" ")
            End If
            Console.Write(i & " ")

            If (i + firstDay) Mod 7 = 0 Then
                Console.WriteLine()
            End If
        Next
        Console.WriteLine()
    End Sub
End Module
