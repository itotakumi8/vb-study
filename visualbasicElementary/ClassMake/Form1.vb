Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim useBell As telephone
        useBell = New telephone
        useBell.Bell()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim commender As New DownloadCommander
        Dim URL As String = "http://www.kantei.go.jp/jp/rekidai/souri/images/souri01.jpg"
        Dim Folder As String = "C:"
        Dim LogFileName As String = "C:\DLL.txt"
        commender.Download(URL, Folder, LogFileName)
    End Sub
End Class
