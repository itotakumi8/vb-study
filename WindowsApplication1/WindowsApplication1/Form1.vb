Public Class Form1

    Private opt As String = Nothing     '今回押されたボタンの数字以外の値を保存(+,-,x,÷,=,C)
    Private beforeIn As String = "C"    '今回押されたボタンの値を保存(1,2,3,4,5,6,7,8,9,0,+,-,x,÷,=,C)
    Private ans As Long = 0             '答え(演算結果)を保存
    Private num As Long = 0             '今回入力された数値を保存する変数

    '1ボタンクリック処理
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            ' 直前に押されたのが数字ボタンのとき、かつ9桁未満の数値が入力されているとき（&を付けて）直前の数字の桁数に加算
            If TextBox.Text.Length < 9 Then
                TextBox.Text &= "1"
            End If
        Else
            ' 直前に押されたのが数字以外のボタンのとき、演算記号で区切られるため（&を付けず）1の位へリセット
            TextBox.Text = "1"
        End If
        beforeIn = "1"
    End Sub
    '2ボタンクリック処理
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            If TextBox.Text.Length < 9 Then
                TextBox.Text &= "2"
            End If
        Else
            TextBox.Text = "2"
        End If
        beforeIn = "2"
    End Sub
    '3ボタンクリック処理
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            If TextBox.Text.Length < 9 Then
                TextBox.Text &= "3"
            End If
        Else
            TextBox.Text = "3"
        End If
        beforeIn = "3"
    End Sub
    '4ボタンクリック処理
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            If TextBox.Text.Length < 9 Then
                TextBox.Text &= "4"
            End If
        Else
            TextBox.Text = "4"
        End If
        beforeIn = "4"
    End Sub
    '5ボタンクリック処理
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            If TextBox.Text.Length < 9 Then
                TextBox.Text &= "5"
            End If
        Else
            TextBox.Text = "5"
        End If
        beforeIn = "5"
    End Sub
    '6ボタンクリック処理
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            If TextBox.Text.Length < 9 Then
                TextBox.Text &= "6"
            End If
        Else
            TextBox.Text = "6"
        End If
        beforeIn = "6"
    End Sub
    '7ボタンクリック処理
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            If TextBox.Text.Length < 9 Then
                TextBox.Text &= "7"
            End If
        Else
            TextBox.Text = "7"
        End If
        beforeIn = "7"
    End Sub
    '8ボタンクリック処理
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            If TextBox.Text.Length < 9 Then
                TextBox.Text &= "8"
            End If
        Else
            TextBox.Text = "8"
        End If
        beforeIn = "8"
    End Sub
    '9ボタンクリック処理
    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            If TextBox.Text.Length < 9 Then
                TextBox.Text &= "9"
            End If
        Else
            TextBox.Text = "9"
        End If
        beforeIn = "9"
    End Sub
    '0ボタンクリック処理
    Private Sub Button0_Click(sender As System.Object, e As System.EventArgs) Handles Button0.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            If TextBox.Text.Length < 9 Then
                TextBox.Text &= "0"
            End If
        Else
            TextBox.Text = "0"
        End If
        beforeIn = "0"
    End Sub
    '00ボタンクリック処理
    'Private Sub Button00_Click(sender As System.Object, e As System.EventArgs) Handles Button00.Click
    '    If beforeIn >= "0" And beforeIn <= "9" Then
    '        If TextBox.Text.Length < 9 Then
    '            TextBox.Text &= "00"
    '        End If
    '    Else
    '        TextBox.Text = "00"
    '    End If
    '    beforeIn = "0"
    'End Sub

    '＋ボタンクリック処理
    Private Sub ButtonPlus_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPlus.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            If opt = "" Then
                ans = CInt(TextBox.Text)
            ElseIf opt = "C" Then
                ans = CInt(TextBox.Text)
            Else
                num = CInt(TextBox.Text)
                ans = ans + num
                TextBox.Text = ans
            End If
        End If
        beforeIn = "+"
        opt = "+"
    End Sub
    '-ボタンクリック処理
    Private Sub ButtonMinus_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMinus.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            If opt = "" Then
                ans = CInt(TextBox.Text)
            ElseIf opt = "C" Then
                ans = CInt(TextBox.Text)
            Else
                num = CInt(TextBox.Text)
                ans = ans - num
                TextBox.Text = ans
            End If
        End If
        beforeIn = "-"
        opt = "-"
    End Sub
    'xボタンクリック処理
    Private Sub ButtonX_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            If opt = "" Then
                ans = CInt(TextBox.Text)
            ElseIf opt = "C" Then
                ans = CInt(TextBox.Text)
            Else
                num = CInt(TextBox.Text)
                ans = ans * num
                TextBox.Text = ans
            End If
        End If
        beforeIn = "x"
        opt = "x"
    End Sub
    '÷ボタンクリック処理
    Private Sub ButtonDivide_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDivide.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            If opt = "" Then
                ans = CInt(TextBox.Text)
            ElseIf opt = "C" Then
                ans = CInt(TextBox.Text)
            Else
                num = CInt(TextBox.Text)
                ans = ans / num
                TextBox.Text = ans
            End If
        End If
        beforeIn = "÷"
        opt = "÷"
    End Sub
    '=ボタンクリック処理
    Private Sub ButtonEqual_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEqual.Click
        If beforeIn >= "1" And beforeIn <= "9" Then
            num = CInt(TextBox.Text)
        End If
        ' 演算子を判定して処理を振分
        Select Case opt
            Case "+"
                ans = ans + num
            Case "-"
                ans = ans - num
            Case "x"
                ans = ans * num
            Case "÷"
                ans = ans / num
        End Select
        TextBox.Text = ans '答え(計算結果)
        beforeIn = "="
        opt = "="
    End Sub
    'クリアボタンクリック処理
    Private Sub ButtonClear_Click(sender As System.Object, e As System.EventArgs) Handles ButtonClear.Click
        ans = 0
        num = 0
        beforeIn = "C"
        opt = "C"
        TextBox.Text = "0"
    End Sub
End Class


