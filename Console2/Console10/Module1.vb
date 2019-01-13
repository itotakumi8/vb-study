Module Module1
    'コンソールから文字列(正の整数)を読み取って、数値に変換する。ただしParse,TryParse関数を使用しないこと！
    Sub Main()
        Console.WriteLine("正の整数を入力してください")
        Dim inputText As String = Console.ReadLine()
        Console.WriteLine("入力値:" + inputText)

        Dim inputBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(inputText) 'inputTextを8桁の2進数に変換する
        Dim inputNumber As Byte = 0.0

        For i = 0 To inputBytes.Length - 1
            If inputBytes(i) <= 47 Or inputBytes(i) > 57 Then
                Console.WriteLine("変換できません")
            Else
                inputNumber += (inputBytes(i) - 48) * Math.Pow(10, inputBytes.Length - 1 - i)
            End If
        Next
        Console.WriteLine("変換値:" & inputNumber)
        Console.ReadLine()
    End Sub
End Module
