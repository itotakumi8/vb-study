Option Explicit

Dim ans,x,y,a,b,c,d

x = InputBox("年収を入力して下さい","入力")
y = InputBox("賞与を入力して下さい","入力") 

a = (x-y)/12
b = a/20
c = b/8
d = c/60



ans = "あなたの収入換算" & vbCr _
    & vbCr _
    &"年収:"&FormatCurrency(x)& vbCr _
    &"賞与:"&FormatCurrency(y)& vbCr _
    &"------------------"& vbCr _
    &"月収:"&FormatCurrency(a)& vbCr _
    &"日給:"&FormatCurrency(b,1)& vbCr _
    &"時給:"&FormatCurrency(c,1)& vbCr _
    &"分給:"&FormatCurrency(d,1)

if x = null or y = null then
    MsgBox("数字を入力して下さい")
Else
    MsgBox ans, ,"収入換算"
End if