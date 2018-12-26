Public Class Form1



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a As Decimal
        a = 123.45
        'MsgBox(a)
        'MsgBox(Math.Ceiling(a))
        MsgBox(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = Now.ToString()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim Saikoro As New Random
        Dim Number As Decimal
        Number = Saikoro.Next(1, 7)
        MsgBox(Number)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim twoWord As String
        twoWord = " あいうえお".Substring(2, 2)
        MsgBox(twoWord)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim scH As String
        Dim scK As String
        scH = StrConv(TextBox2.Text, VbStrConv.Hiragana)
        scK = StrConv(TextBox2.Text, VbStrConv.Katakana)
        MsgBox(scH)
        MsgBox(scK)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        MsgBox(Len(TextBox2.Text))
        'MsgBox(Len(Button4.Text))
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim twoWordCut As String
        Dim cutPoint As New Random
        Dim Number As Decimal
        Number = cutPoint.Next(1, 21)
        twoWordCut = Mid(TextBox2.Text, Number, 2)
        MsgBox(twoWordCut)
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        'MsgBox(Left(TextBox3.Text, 2)) Left関数はプロパティと同じため関数と判断されてしまう
        MsgBox(Strings.Left(TextBox3.Text, 2))
        MsgBox(Strings.Right(TextBox3.Text, 2))
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.BackColor = Color.FromArgb(20, 20, 50)
        Me.BackgroundImage = Image.FromFile("E:\隅田川.jpg")
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim Answer As String
        Answer = InputBox("あなたの名前は何ですか？")
        MsgBox("こんにちは、" & Answer & "さん")
    End Sub
End Class
