'ファイルを開く

Option Explicit

Dim objWSH

Set objWSH = CreateObject("Wscript.shell")

objWSH.Run("C:\Users\itpuser\Documents\vb-study\VBScript\test.txt")