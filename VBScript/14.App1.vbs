Option Explicit

Dim ans,m,n
Dim y1,y10,y100�@'�ϐ��͔C�ӂŌ��߂��邪�A���߂̕����ɂ͐����͎g���Ȃ�

m = InputBox("���z����͂��ĉ�����","����")
n = InputBox("�l������͂��ĉ�����","����")

y1 = Round(m/n)
y10 = Round(m/n/10) * 10
y100 = Round(m/n/100) * 100

ans ="1�~�P��:"& y1 &"�~"& vbCr _   '���p�X�y�[�X�ƃA���_�[�o�[���v���O�������ł̉��s
    &"10�~�P��:"& y10 &"�~"& vbCr _
    &"100�~�P��:"& y100 &"�~"

MsgBox ans, ,"���茋��"