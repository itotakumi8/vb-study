Public Class Form1

    Private ope As String = Nothing     '今回押されたボタンの数字以外の値を保存(+,-,x,÷,=,C)
    Private beforeIn As String = "C"    '今回押されたボタンの値を保存(1,2,3,4,5,6,7,8,9,0,+,-,x,÷,=,C)
    Private ans As Long = 0             '演算結果を保存
    Private num As Long = 0             '今回入力された数値を保存する変数

    '1ボタンクリック処理
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            ' 直前に押されたのが数字ボタンのとき
            ' かつ、8桁未満の数値が入力されているとき
            If TextBox.Text.Length < 9 Then
                TextBox.Text &= "1"
            End If
        Else
            ' 直前に押されたのが数字以外のボタンのとき
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
    '＋ボタンクリック処理
    Private Sub ButtonPlus_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPlus.Click
        If beforeIn >= "0" And beforeIn <= "9" Then
            If ope = "C" Then
                ' 最初の入力数値をansに保管
                ans = CInt(TextBox.Text)
            Else
                ' ansに保管されている
                ' ＋ボタンクリック前の数値と加算
                num = CInt(TextBox.Text)
                ans = ans + num
                TextBox.Text = ans
            End If
        Else
            ' 前回クリックが数字以外の時
            Select Case ope
                Case "C"
                    ' 前回がクリアボタン
                    ans = CInt(TextBox.Text)
                Case "="
                    ' 前回がイコールボタン
                    ans = ans + num
                Case "+"
                    num = ans
            End Select
        End If
        beforeIn = "+"
        ope = "+"
    End Sub
End Class


