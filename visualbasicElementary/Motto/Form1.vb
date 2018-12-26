Public Class Form1
    'Dim count As Integer　'クラスレベルで宣言した変数はクラス終了まで有効
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Dim count As Integer 'プロシージャレベルで宣言した変数はSubが終了した時点で寿命を終える=リセットされる
        Static count As Integer 'staticで宣言された変数はクラス終了まで有効
        Do
            count += 1 '同じ変数名を使う場合適用範囲が狭いほうが優先されるが、変数名にMe.を付けることによりクラスレベルの変数が優先される
            MsgBox(count)
        Loop
    End Sub
End Class
