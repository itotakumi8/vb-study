<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextValue1 = New System.Windows.Forms.TextBox()
        Me.TextValue2 = New System.Windows.Forms.TextBox()
        Me.ButtonPlus = New System.Windows.Forms.Button()
        Me.ButtonMinus = New System.Windows.Forms.Button()
        Me.ButtonMulti = New System.Windows.Forms.Button()
        Me.ButtonDivide = New System.Windows.Forms.Button()
        Me.LabelAns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextValue1
        '
        Me.TextValue1.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.TextValue1.Location = New System.Drawing.Point(26, 27)
        Me.TextValue1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextValue1.Multiline = True
        Me.TextValue1.Name = "TextValue1"
        Me.TextValue1.Size = New System.Drawing.Size(308, 57)
        Me.TextValue1.TabIndex = 0
        '
        'TextValue2
        '
        Me.TextValue2.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.TextValue2.Location = New System.Drawing.Point(26, 98)
        Me.TextValue2.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextValue2.Multiline = True
        Me.TextValue2.Name = "TextValue2"
        Me.TextValue2.Size = New System.Drawing.Size(308, 60)
        Me.TextValue2.TabIndex = 1
        '
        'ButtonPlus
        '
        Me.ButtonPlus.Location = New System.Drawing.Point(26, 172)
        Me.ButtonPlus.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.ButtonPlus.Name = "ButtonPlus"
        Me.ButtonPlus.Size = New System.Drawing.Size(68, 58)
        Me.ButtonPlus.TabIndex = 2
        Me.ButtonPlus.Text = "+"
        Me.ButtonPlus.UseVisualStyleBackColor = True
        '
        'ButtonMinus
        '
        Me.ButtonMinus.Location = New System.Drawing.Point(106, 172)
        Me.ButtonMinus.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.ButtonMinus.Name = "ButtonMinus"
        Me.ButtonMinus.Size = New System.Drawing.Size(68, 58)
        Me.ButtonMinus.TabIndex = 3
        Me.ButtonMinus.Text = "-"
        Me.ButtonMinus.UseVisualStyleBackColor = True
        '
        'ButtonMulti
        '
        Me.ButtonMulti.Location = New System.Drawing.Point(186, 172)
        Me.ButtonMulti.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.ButtonMulti.Name = "ButtonMulti"
        Me.ButtonMulti.Size = New System.Drawing.Size(68, 58)
        Me.ButtonMulti.TabIndex = 4
        Me.ButtonMulti.Text = "*"
        Me.ButtonMulti.UseVisualStyleBackColor = True
        '
        'ButtonDivide
        '
        Me.ButtonDivide.Location = New System.Drawing.Point(266, 172)
        Me.ButtonDivide.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.ButtonDivide.Name = "ButtonDivide"
        Me.ButtonDivide.Size = New System.Drawing.Size(68, 58)
        Me.ButtonDivide.TabIndex = 5
        Me.ButtonDivide.Text = "/"
        Me.ButtonDivide.UseVisualStyleBackColor = True
        '
        'LabelAns
        '
        Me.LabelAns.AutoSize = True
        Me.LabelAns.Location = New System.Drawing.Point(21, 251)
        Me.LabelAns.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LabelAns.Name = "LabelAns"
        Me.LabelAns.Size = New System.Drawing.Size(34, 27)
        Me.LabelAns.TabIndex = 6
        Me.LabelAns.Text = "A."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 297)
        Me.Controls.Add(Me.LabelAns)
        Me.Controls.Add(Me.ButtonDivide)
        Me.Controls.Add(Me.ButtonMulti)
        Me.Controls.Add(Me.ButtonMinus)
        Me.Controls.Add(Me.ButtonPlus)
        Me.Controls.Add(Me.TextValue2)
        Me.Controls.Add(Me.TextValue1)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextValue1 As System.Windows.Forms.TextBox
    Friend WithEvents TextValue2 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPlus As System.Windows.Forms.Button
    Friend WithEvents ButtonMinus As System.Windows.Forms.Button
    Friend WithEvents ButtonMulti As System.Windows.Forms.Button
    Friend WithEvents ButtonDivide As System.Windows.Forms.Button
    Friend WithEvents LabelAns As System.Windows.Forms.Label

End Class
