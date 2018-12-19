Module Module1

    Sub Main()
        Dim firstDayOfMonth As MyDate = New MyDate(2019, 1, 1)
        RenderCalender(firstDayOfMonth.DayOfWeek, Date.DaysInMonth(firstDayOfMonth.Year, firstDayOfMonth.Month))
    End Sub

    Public Sub RenderCalender(firstDay As Integer, dayLength As Integer)

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

        Console.ReadLine()
    End Sub
End Module
