Option Explicit

Dim ans,m,n
Dim y1,y10,y100

m = InputBox("金額を入力して下さい","入力")
n = InputBox("人数を入力して下さい","入力")

y1 = Fix(m/n)
y10 = Fix(m/n/10) * 10
y100 = Fix(m/n/100) * 100

ans = "金額:"&m&"円"&" 人数:"&n&"人"& vbCr _
    & vbCr _
    &"    1円単位:"& y1 &"円　→　合計 "& y1 * n &"円"& vbCr _
    &"  10円単位:"& y10 &"円　→　合計 "& y10 * n &"円"& vbCr _
    &"100円単位:"& y100 &"円　→　合計 "& y100 * n &"円"

MsgBox ans, ,"割り勘結果(Fix)"