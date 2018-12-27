Public Class Form1
    Private Const COMPANY_NAME As String = "by Visual Basic中学校" '定数の宣言
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '使用期間の警告
        MsgBox("このソフトは試用期間中です", , COMPANY_NAME)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'バージョン情報
        MsgBox("バージョンXXX.XX", , COMPANY_NAME)
        Me.Close()
    End Sub
End Class
