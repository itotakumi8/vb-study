'Webからファイルをダウンロードしてくるクラスを作成する
'既に存在するダウンロードクラスに加えて履歴を追加する新しいクラスを作成する
Public Class DownloadCommander
    Dim wc As Net.WebClient = New Net.WebClient()
    Public Sub Download(URL As String, FolderName As String, LogFileName As String)
        Dim FileName As String
        '▼ファイルのダウンロード
        FileName = FolderName & "\" & IO.Path.GetFileName(URL)
        wc.DownloadFile(URL, FileName)
        '▼履歴をログに書き込む
        Dim Writer As New IO.StreamWriter(LogFileName, True)
        Dim Description As String

        Description = Now.ToString("yyyy/mm/dd/ hh:mm") & ","
        Description &= Environment.UserName & ","
        Description &= URL & ","
        Description &= FileName

        Writer.WriteLine(Description)
        Writer.Close()
    End Sub
End Class
'WebClientクラスの機能をそのまま使用しているため簡単な記述となる