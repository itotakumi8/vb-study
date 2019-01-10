'基礎編

option Explicit

Dim intMsg
intMsg = Msgbox("「はい」か「いいえ」か「キャンセル」をクリックしてください",vbYesNoCancel,"lesson3") '第二引数のvbYesNoCancelは定数（特定の値を持つ）
If intMsg = vbyes then
    Msgbox "「はい」をクリックしました",vbinformation,"lesson3"
Else if intMsg = vbno then
    Msgbox "「いいえ」をクリックしました",vbinformation,"lesson3"
Else  
    Msgbox "「キャンセル」をクリックしました",vbinformation,"lesson3"
End if

Msgbox "終わります", ,"lesson3"