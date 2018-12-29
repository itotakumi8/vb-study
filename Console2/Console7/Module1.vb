Module Module1

    Sub Main()

        Dim inputValue As String
        Dim isNotSosuu As Boolean

        inputValue = Console.ReadLine()

        For count = 2 To inputValue - 1
            If inputValue Mod count <> 0 Then 'この式だと一つでも割り切れないとFalse=素数となる
                isNotSosuu = True
            End If
        Next

        '最後にTrueのためFalseを抜けてTrueへ行く

        If isNotSosuu = False Then
            Console.WriteLine("素数ではない")
        Else
            Console.WriteLine("素数")
        End If
    End Sub

End Module
