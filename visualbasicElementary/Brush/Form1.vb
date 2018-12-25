Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim paintCircle As Graphics = PictureBox1.CreateGraphics
        paintCircle.FillEllipse(Brushes.Yellow, 22, 0, 210, 210)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim paintCircle As Graphics = PictureBox1.CreateGraphics
        Dim sumidagawa As New TextureBrush(Image.FromFile("E:\隅田川.jpg"))
        paintCircle.FillEllipse(sumidagawa, 22, 0, 210, 210)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim paintCircle As Graphics = PictureBox1.CreateGraphics
        Dim guradation As New Drawing2D.LinearGradientBrush(New Point(105, 0), New Point(105, 220), Color.DarkBlue, Color.OrangeRed)
        paintCircle.FillEllipse(guradation, 22, 0, 210, 210)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim paintCircle As Graphics = PictureBox1.CreateGraphics
        Dim specialpaint As New Drawing2D.HatchBrush(Drawing.Drawing2D.HatchStyle.HorizontalBrick, Color.Yellow, Color.LightSkyBlue)
        paintCircle.FillEllipse(specialpaint, 22, 0, 210, 210)
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class
