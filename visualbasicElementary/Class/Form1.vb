Imports System.IO
Public Class Form1
    '目に見えるクラス＝コントロール
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim fileInfoUse As New FileInfo("C:\Users\takumi\Documents\古いドキュメント\eula.txt")
        Me.BackColor = System.Drawing.Color.Red
        MsgBox(Math.PI)
        MsgBox(fileInfoUse.Length())
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim G As Graphics = sender.CreateGraphics() 'Fillellipseは非共有メンバーであり、Graphicsのインスタンスである
        G.FillEllipse(Brushes.Red, e.X, e.Y, 10, 10) 'RedはBrushesの共有メンバーである（インスタンスは作成される）
    End Sub
End Class
