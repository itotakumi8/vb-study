Public Class Form1

    Private Sub Button1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button1.MouseEnter
        sender.backcolor = Color.LightPink
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As System.EventArgs) Handles Button1.MouseLeave
        sender.backcolor = Color.FromKnownColor(KnownColor.Control)
    End Sub
    Private Sub PictureBox1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Dim G As Graphics = sender.CreateGraphics()
        If e.Button = Windows.Forms.MouseButtons.Left Then
            G.FillEllipse(Brushes.Red, e.X, e.Y, 5, 5)
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            G.FillEllipse(Brushes.Blue, e.X, e.Y, 5, 5)
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.PictureBox1.Image = Nothing
    End Sub
    Private Sub TextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress
        If IsNumeric(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox("はじめ")
        RemoveHandler Button2.Click, AddressOf Button2_Click 'button2のイベントを無効化
        AddHandler Button3.Click, AddressOf MyClick
    End Sub

    Private Sub MyClick(sender As System.Object, e As System.EventArgs)
        MsgBox("2回目以降") 'button2イベントが発生した後のみで発生する
    End Sub
End Class
