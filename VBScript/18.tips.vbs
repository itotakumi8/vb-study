Option Explicit

WScript.Echo "hello,world"

Dim lngLoop
WScript.Echo "������" & WScript.Arguments.Count & "����܂��B"
For lngLoop = 0 To WScript.Arguments.Count -1
    WScript.Echo lngLoop + 1 &":"& WScript.Arguments.Item(lngLoop)
Next

WScript.Echo ScriptEngineMajorVersion & "." & ScriptEngineMinorVersion