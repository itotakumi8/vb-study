Option Explicit

Dim ans,a,b,c

a = InputBox("aの値を入力して下さい","入力")
b = InputBox("bの値を入力して下さい","入力")
c = InputBox("小数点何位まで求めますか","入力")

ans = Round(a/b,c)

MsgBox ans, ,"答え"