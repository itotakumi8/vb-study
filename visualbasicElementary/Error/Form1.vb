Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            MsgBox(CDec(TextBox1.Text) / CDec(TextBox2.Text))
        Catch ex As InvalidCastException
            MsgBox("整数を入力してください", MsgBoxStyle.Exclamation) '注意マークを表示する
        Catch ex As DivideByZeroException
            MsgBox("0で割ることはできません", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox("その他のエラーが発生しました", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim Answer As Integer
        Try
            MsgBox(CDec(TextBox1.Text) / CDec(TextBox2.Text))
        Catch ex As Exception
            Answer = ("Error")
        Finally
            Label1.Text = Answer
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        MsgBox(CDec(TextBox1.Text) / CDec(TextBox2.Text))
    End Sub
End Class
