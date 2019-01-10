'MsgBoxが値を返すため()を外す
'MsgBox "hello,world!", ,"Message"


'()を省略しない書き方
Option Explicit

Dim Str,Act

Str = "あいうえお"

Act = MsgBox(Str, ,"ひらがな")

'文字コード、UTF-8だとエラー発生してしまうため Shift JIS に設定する