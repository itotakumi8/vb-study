Option Explicit

Dim ans,x,y,a,b,c,d

x = InputBox("�N������͂��ĉ�����","����")
y = InputBox("�ܗ^����͂��ĉ�����","����") 

a = (x-y)/12
b = a/20
c = b/8
d = c/60



ans = "���Ȃ��̎������Z" & vbCr _
    & vbCr _
    &"�N��:"&FormatCurrency(x)& vbCr _
    &"�ܗ^:"&FormatCurrency(y)& vbCr _
    &"------------------"& vbCr _
    &"����:"&FormatCurrency(a)& vbCr _
    &"����:"&FormatCurrency(b,1)& vbCr _
    &"����:"&FormatCurrency(c,1)& vbCr _
    &"����:"&FormatCurrency(d,1)

if x = null or y = null then
    MsgBox("��������͂��ĉ�����")
Else
    MsgBox ans, ,"�������Z"
End if