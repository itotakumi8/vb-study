Public Class Form1
    Private Sub ButtonPlus_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPlus.Click
        On Error Resume Next
        Dim X As Decimal
        Dim Y As Decimal

        X = TextValue1.Text
        Y = TextValue2.Text

        LabelAns.Text = X + Y
    End Sub

    Private Sub ButtonMinus_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMinus.Click
        On Error Resume Next
        Dim X As Decimal
        Dim Y As Decimal

        X = TextValue1.Text
        Y = TextValue2.Text

        LabelAns.Text = X - Y
    End Sub

    Private Sub ButtonMulti_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMulti.Click
        On Error Resume Next
        Dim X As Decimal
        Dim Y As Decimal

        X = TextValue1.Text
        Y = TextValue2.Text

        LabelAns.Text = X * Y
    End Sub

    Private Sub ButtonDivide_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDivide.Click
        On Error Resume Next
        Dim X As Decimal
        Dim Y As Decimal

        X = TextValue1.Text
        Y = TextValue2.Text

        LabelAns.Text = X / Y
    End Sub
    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim paintCircle As Graphics = Me.CreateGraphics
        Dim gradation As New Drawing2D.LinearGradientBrush(New Point(0, 0), New Point(381, 336), Color.Red, Color.Blue)
        paintCircle.FillRectangle(gradation, 0, 0, 381, 336)
    End Sub
End Class
