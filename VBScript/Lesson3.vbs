'��b��

option Explicit

Dim intMsg
intMsg = Msgbox("�u�͂��v���u�������v���u�L�����Z���v���N���b�N���Ă�������",vbYesNoCancel,"lesson3") '��������vbYesNoCancel�͒萔�i����̒l�����j
If intMsg = vbyes then
    Msgbox "�u�͂��v���N���b�N���܂���",vbinformation,"lesson3"
Else if intMsg = vbno then
    Msgbox "�u�������v���N���b�N���܂���",vbinformation,"lesson3"
Else  
    Msgbox "�u�L�����Z���v���N���b�N���܂���",vbinformation,"lesson3"
End if

Msgbox "�I���܂�", ,"lesson3"