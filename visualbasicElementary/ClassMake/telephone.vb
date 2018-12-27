Public Class telephone
    Private Declare Ansi Function PlaySound Lib "winmm.dll" Alias "PlaySoundA" (IpszName As String, hModule As Integer, dwFlags As Integer)
    Private Const SAD_ASYNC = &H1
    Public Sub Bell()
        Dim WaveFile As Integer
        WaveFile = Environment.GetEnvironmentVariable("WINDIR") & "\media\ringin.wav"
        PlaySound(WaveFile, 0, SAD_ASYNC)
    End Sub
End Class
