Option Explicit

Dim ans,x,y,a,b,c,d,e

x = InputBox("�N������͂��ĉ�����","����")
y = InputBox("�ܗ^����͂��ĉ�����","����") 

a = Round((x-y)/12,1)
b = Round(a/20,1)
c = Round(b/8,1)
d = Round(c/60,1)
e = 1


ans = "�N��:"&x&"�~"& vbCr _
    &"�ܗ^:"&y&"�~"& vbCr _
    &"------------------"& vbCr _
    &"����:"&a&"�~"& vbCr _
    &"����:"&b&"�~"& vbCr _
    &"����:"&c&"�~"& vbCr _
    &"����:"&d&"�~"

MsgBox ans, ,"�������Z"