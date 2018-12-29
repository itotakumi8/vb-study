Module Module1

    Sub Main()

        Dim i As Integer '数字型
        Dim j As String  '文字型

        i = Console.ReadLine()

        j = Integer.Parse(i)

        For i = 1 To j  '「For （入力文字(数字型)）、1 To （入力文字(文字型)）まで繰り返し」

            Console.WriteLine("Hello,World")

        Next

    End Sub

End Module
