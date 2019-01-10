Option Explicit

Dim ans,x,y,a,b,c,d,e

x = InputBox("”Nû‚ğ“ü—Í‚µ‚Ä‰º‚³‚¢","“ü—Í")
y = InputBox("Ü—^‚ğ“ü—Í‚µ‚Ä‰º‚³‚¢","“ü—Í") 

a = Round((x-y)/12,1)
b = Round(a/20,1)
c = Round(b/8,1)
d = Round(c/60,1)
e = 1


ans = "”Nû:"&x&"‰~"& vbCr _
    &"Ü—^:"&y&"‰~"& vbCr _
    &"------------------"& vbCr _
    &"Œû:"&a&"‰~"& vbCr _
    &"“ú‹‹:"&b&"‰~"& vbCr _
    &"‹‹:"&c&"‰~"& vbCr _
    &"•ª‹‹:"&d&"‰~"

MsgBox ans, ,"û“üŠ·Z"