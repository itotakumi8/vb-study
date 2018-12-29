Module Module1
    'コンソールから文字列(正の整数)を読み取って、数値に変換する。ただしParse,TryParse関数を使用しないこと！
    Sub Main()
        Console.WriteLine("正の整数を入力してください")
        Dim inputText As String = Console.ReadLine()
        Dim inputByte As Byte() = System.Text.Encoding.UTF8.GetBytes(inputText)
    End Sub
End Module
