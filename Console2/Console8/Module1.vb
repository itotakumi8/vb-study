Module Module1

    Sub Main()

        Dim inputValue As Integer
        Dim isSosuu As Boolean = True

        inputValue = Console.ReadLine()

        For count = 2 To inputValue - 1
            If inputValue Mod count = 0 Then
                isSosuu = False
            End If
        Next

        '

        If isSosuu = True Then
            Console.WriteLine("素数")
        Else
            Console.WriteLine("素数ではない")
        End If

    End Sub

End Module

