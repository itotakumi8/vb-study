'計算に使える関数一覧

a = 10
b = 3
c = 3
d = 25

ans = Round(a/b,c)
ans2 = Int(a/b) '小数点以下を切り捨てる
ans3 = Sqr(d)   '平方根を求める
ans4 = Oct(a+b) '8進数に変換
ans5 = Hex(a)   '16進数に変換

MsgBox(ans)
MsgBox(ans2)
MsgBox(ans3)
MsgBox(ans4)
MsgBox(ans5)