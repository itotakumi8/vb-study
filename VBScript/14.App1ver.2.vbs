Option Explicit

Dim ans,m,n
Dim y1,y10,y100

m = InputBox("���z����͂��ĉ�����","����")
n = InputBox("�l������͂��ĉ�����","����")

y1 = Round(m/n)
y10 = Round(m/n/10) * 10
y100 = Round(m/n/100) * 100

ans = "���z:"&m&"�~"&" �l��:"&n&"�l"& vbCr _
    & vbCr _
    &"    1�~�P��:"& y1 &"�~�@���@1�l "& y1 * n &"�~"& vbCr _
    &"  10�~�P��:"& y10 &"�~�@���@1�l "& y10 * n &"�~"& vbCr _
    &"100�~�P��:"& y100 &"�~�@���@1�l "& y100 * n &"�~"

MsgBox ans, ,"���芨����"