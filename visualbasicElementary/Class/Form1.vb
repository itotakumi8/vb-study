Imports System.IO
Public Class Form1
    '目に見えるクラス＝コントロール

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.BackColor = System.Drawing.Color.Red
        MsgBox(Math.PI)
        MsgBox(FileInfo.Length)
    End Sub
End Class
