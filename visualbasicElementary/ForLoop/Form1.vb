Public Class Form1
    'フォームぴったりの円を描く
    Private Sub Form1_Click(sender As Object, e As System.EventArgs) Handles Me.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim tate As Integer
        Dim yoko As Integer
        tate = Me.ClientSize.Height - 1
        yoko = Me.ClientSize.Width - 1
        For i = 0 To 9900 Step 10
            g.DrawEllipse(New Pen(Color.FromArgb(i Mod 200, i Mod 160, i Mod 123)), 0 + i, 0 + i, yoko - (i * 2), tate - (i * 2))
        Next i
    End Sub

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.BackColor = Color.Black
    End Sub

    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'Dim circleGreen As Graphics = Me.CreateGraphics
        'circleGreen.DrawEllipse(Pens.Green, 0, 0, 100, 100)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Do
        '    MsgBox("hello!") '無限ループ
        'Loop
        For i = 1 To 5
            MsgBox("今" & i & "回目")
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim B As Integer
        B = 1
        'Do Until B > 100
        '    B = B + B
        '    Debug.WriteLine(B)
        Do While B <= 100
            B = B + B
            Debug.WriteLine(B)
        Loop
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Do
            If TextBox1.Text.Length > 15 Then
                Exit Do
            End If
            TextBox1.AppendText("ぺ")
        Loop
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Do
            MsgBox("hello!") '無限ループ
        Loop
    End Sub
End Class
