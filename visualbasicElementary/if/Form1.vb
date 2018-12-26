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
End Class

