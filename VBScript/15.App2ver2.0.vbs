Option Explicit

Dim ans,x,y,a,b,c,d

x = InputBox("”Nû‚ğ“ü—Í‚µ‚Ä‰º‚³‚¢","“ü—Í")
y = InputBox("Ü—^‚ğ“ü—Í‚µ‚Ä‰º‚³‚¢","“ü—Í") 

a = (x-y)/12
b = a/20
c = b/8
d = c/60



ans = "‚ ‚È‚½‚Ìû“üŠ·Z" & vbCr _
    & vbCr _
    &"”Nû:"&FormatCurrency(x)& vbCr _
    &"Ü—^:"&FormatCurrency(y)& vbCr _
    &"------------------"& vbCr _
    &"Œû:"&FormatCurrency(a)& vbCr _
    &"“ú‹‹:"&FormatCurrency(b,1)& vbCr _
    &"‹‹:"&FormatCurrency(c,1)& vbCr _
    &"•ª‹‹:"&FormatCurrency(d,1)

if x = null or y = null then
    MsgBox("”š‚ğ“ü—Í‚µ‚Ä‰º‚³‚¢")
Else
    MsgBox ans, ,"û“üŠ·Z"
End if