Public Class Form1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim St As String
        St = Len(TextBox1.Text)
        If St > 0 Then
            MsgBox(St & "文字が入力されています")
        Else
            MsgBox("文字を入力して下さい")
        End If
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox2.Text = "ワシントン" Then
            MsgBox("正解!")
        ElseIf TextBox2.Text = "アダムズ" Then
            MsgBox("惜しい、アダムズは2代目大統領です")
        Else
            MsgBox("残念でした")
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim Saikoro As New Random
        Dim A As Integer
        Dim B As Integer
        Dim C As Integer
        A = Saikoro.Next(1, 32)
        B = Saikoro.Next(1, 32)
        C = Saikoro.Next(1, 32)

        'If (A = 5 OrElse B = 8) AndAlso C = 31 Then
        '    MsgBox("成就されました")
        'End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim day As Integer
        day = TextBox3.Text
        Select Case day
            Case 1
                MsgBox("新しい月の始まりです")
            Case 2 To 15
                MsgBox("まだまだ月の前半です")
            Case 16, 17, 18
                MsgBox("月の半ばです")
            Case Is >= 19
                MsgBox("もうすぐ次の月です")
            Case Else
                MsgBox("正しい数字を入力してください")
        End Select
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
                Select Now.Day
            Case 1
                MsgBox("新しい月の始まりです")
            Case 2 To 15
                MsgBox("まだまだ月の前半です")
            Case 16, 17, 18
                MsgBox("月の半ばです")
            Case Is >= 19
                MsgBox("もうすぐ次の月です")
            Case Else
                MsgBox("正しい数字を入力してください")
        End Select
    End Sub
    '文字が入力されているか？
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim A As String
        A = TextBox4.Text
        If Len(A) = 0 Then
            MsgBox("入力はありません")
        Else
            MsgBox("文字が入力されています")
        End If

    End Sub
    '特定の文字を含んでいるか？
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim B As String
        B = TextBox4.Text
        If B.Contains("、") Then
            MsgBox("カンマを含んでいます")
        Else
            MsgBox("カンマを含んでいません")
        End If
    End Sub
    '特定の数字で割り切れるか？
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim C As Integer
        C = TextBox4.Text
        If C Mod 2 = 0 Then
            MsgBox("偶数です")
        Else
            MsgBox("奇数です")
        End If
    End Sub
End Class


