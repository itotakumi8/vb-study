Module Module1

    Sub Main()
        Do
            Dim day, zone As Integer
            Dim bopen As Boolean = True

            Console.WriteLine("曜日を選択してください")
            Console.Write("0=日曜、1=月曜、2=火曜、3=水曜、4=木曜、5=金曜、6=土曜")
            day = Integer.Parse(Console.ReadLine())

            Console.WriteLine("時間帯を選択してください")
            Console.Write("0=午前、1=午後、2=夜間")
            zone = Integer.Parse(Console.ReadLine())

            If day = 0 Then
                bopen = False
            ElseIf zone = 0 And (day = 2 Or day = 5) Then
                bopen = False
            ElseIf zone = 1 And day = 6 Then
                bopen = False
            ElseIf zone = 2 And (day = 3 Or day = 6) Then
                bopen = False
            End If

            If bopen Then
                Console.WriteLine("診療しています。")
            Else
                Console.WriteLine("休診です。")
            End If
            Console.ReadLine()
        Loop
    End Sub

End Module
