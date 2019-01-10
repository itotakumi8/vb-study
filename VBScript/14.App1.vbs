Option Explicit

Dim ans,m,n
Dim y1,y10,y100

m = InputBox("‹àŠz‚ğ“ü—Í‚µ‚Ä‰º‚³‚¢","“ü—Í")
n = InputBox("l”‚ğ“ü—Í‚µ‚Ä‰º‚³‚¢","“ü—Í")

y1 = Round(m/n)
y10 = Round(m/n/10) * 10
y100 = Round(m/n/100) * 100

ans ="1‰~’PˆÊ:"& y1 &"‰~"& vbCr _
    &"10‰~’PˆÊ:"& y10 &"‰~"& vbCr _
    &"100‰~’PˆÊ:"& y100 &"‰~"

MsgBox ans, ,"Š¨’èŒ‹‰Ê"