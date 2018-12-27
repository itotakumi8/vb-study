Public Class Form1
    'メソッドを呼び出すためのイベント
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'WriteLog("E:\Test.text", "自作メソッドのテスト")
        ShowTime()
        GetJapanYear()
        IsEven(5)
    End Sub
    '作成したメソッド本文
    Private Sub WriteLog(Filename As String, Description As String) 'ファイルに書き込みを行う自作メソッド
        Dim Write As New IO.StreamWriter(Filename, False)           'インスタンスを作成
        Write.WriteLine(Now.ToString("yy/MM/dd hh:mm:ss") & " " & Description) '非共有メンバのメソッド・WriteLine を用いて書き込みを行う
        Write.Close()                                               '終了する
    End Sub
    'テスト時刻表示
    Private Sub ShowTime()
        MsgBox(Now)
    End Sub
    '西暦を和暦で返す値を返すメソッド
    Private Function GetJapanYear() As Integer
        Dim Japan As New Globalization.JapaneseCalendar
        Dim JapaneseYear As Integer
        JapaneseYear = Japan.GetYear("2005/1/1")
        MsgBox("平成" & JapaneseYear & "年")
        Return JapaneseYear
    End Function
    '偶数奇数を返すメソッド（値を返す引数ありメソッド）
    Private Function IsEven(number As Integer) As Boolean
        If number Mod 2 = 0 Then
            Return MsgBox("偶数")
        Else
            Return MsgBox("奇数")
        End If
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Black
    End Sub
    'まとめ
    Dim XPoint As Integer = 120 '初期位置
    Dim YPoint As Integer = 100
    Private Sub BtnLeft_Click(sender As System.Object, e As System.EventArgs) Handles BtnLeft.Click
        XPoint -= 10
        'YPoint += 10
        DrawCircle(XPoint, YPoint)
    End Sub

    Private Sub BtnRight_Click(sender As System.Object, e As System.EventArgs) Handles BtnRight.Click
        XPoint += 10
        'YPoint -= 10
        DrawCircle(XPoint, YPoint)
    End Sub
    Private Sub DrawCircle(X As Integer, Y As Integer)
        Dim Drawing As Graphics = Me.CreateGraphics
        Dim Pattern As New Drawing2D.LinearGradientBrush(New Point(X, Y), New Point(X + 50, Y + 50), Color.Blue, Color.Yellow)
        Drawing.Clear(Color.Black)
        Drawing.FillEllipse(Pattern, X, Y, 50, 50)
    End Sub
End Class
