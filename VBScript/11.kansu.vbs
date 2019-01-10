'Round(_,_)  - 小数点以下を四捨五入する関数 (一つ目のパラメータで数字,二つ目のパラメータで切り捨てる小数点以下の桁数)

Option Explicit

Dim ans,a,b,c

a = 10
b = 6
c = 5

ans = Round(a/b,c)

MsgBox(ans)