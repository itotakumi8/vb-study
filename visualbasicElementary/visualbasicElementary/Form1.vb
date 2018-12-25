Public Class Form1
    Private x As Integer = -10

    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim pen1 As New Pen(Color.Black, 4)
        Dim pen2 As New Pen(Color.White, 4)
        Dim y As New Drawing2D.LinearGradientBrush(New Point(-1, 85), New Point(0, 170), Color.Black, Color.Red)
        pen1.DashStyle = Drawing2D.DashStyle.Dot
        e.Graphics.DrawLine(Pens.Red, 0, 0, 282, 260)
        e.Graphics.DrawLine(Pens.Blue, 0, 260, 280, 0)
        e.Graphics.DrawRectangle(pen1, 95, 85, 95, 85)          '四角形の線を描画する
        e.Graphics.FillRectangle(y, 95, 85, 95, 85)             '四角形に色を塗る
        e.Graphics.DrawEllipse(pen2, 95, 85, 95, 85)            '円形を描画
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        PictureBox1.Invalidate()

        If x >= 61 Then
            x = -10
        Else
            x += 2
        End If
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.Clear(Color.Black)
        e.Graphics.FillEllipse(Brushes.White, x, 10, 10, 10)
    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Me.Close()
    End Sub
End Class
