Option Explicit

WScript.Echo "hello,world"

Dim lngLoop
WScript.Echo "引数は" & WScript.Arguments.Count & "個あります。"
For lngLoop = 0 To WScript.Arguments.Count -1
    WScript.Echo lngLoop + 1 &":"& WScript.Arguments.Item(lngLoop)
Next

WScript.Echo ScriptEngineMajorVersion & "." & ScriptEngineMinorVersion