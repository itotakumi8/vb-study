Option Explicit

Dim ans,m,n
Dim y1,y10,y100

m = InputBox("金額を入力して下さい","入力")
n = InputBox("人数を入力して下さい","入力")

y1 = Round(m/n)
y10 = Round(m/n/10) * 10
y100 = Round(m/n/100) * 100

ans ="1円単位:"& y1 &"円"& vbCr _
    &"10円単位:"& y10 &"円"& vbCr _
    &"100円単位:"& y100 &"円"

MsgBox ans, ,"勘定結果"