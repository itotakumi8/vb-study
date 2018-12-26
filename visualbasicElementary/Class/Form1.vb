Imports System.IO
Public Class Form1
    '目に見えるクラス＝コントロール
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim fileInfoUse As New FileInfo("C:\Users\takumi\Documents\古いドキュメント\eula.txt")
        Me.BackColor = System.Drawing.Color.Red
        MsgBox(Math.PI)
        MsgBox(fileInfoUse.Length())
    End Sub
End Class
