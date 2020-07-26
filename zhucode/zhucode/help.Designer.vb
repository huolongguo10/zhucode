<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class help
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.note = New System.Windows.Forms.Button()
        Me.Calc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(375, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(59, 27)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "朗读"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(285, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 28)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "me手机"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(172, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 30)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "小猪记事本"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'note
        '
        Me.note.Location = New System.Drawing.Point(87, 12)
        Me.note.Name = "note"
        Me.note.Size = New System.Drawing.Size(58, 31)
        Me.note.TabIndex = 13
        Me.note.Text = "note"
        Me.note.UseVisualStyleBackColor = True
        '
        'Calc
        '
        Me.Calc.Location = New System.Drawing.Point(12, 12)
        Me.Calc.Name = "Calc"
        Me.Calc.Size = New System.Drawing.Size(58, 31)
        Me.Calc.TabIndex = 12
        Me.Calc.Text = "calc"
        Me.Calc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Label1"
        '
        'help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 157)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.note)
        Me.Controls.Add(Me.Calc)
        Me.Name = "help"
        Me.Text = "help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents note As Button
    Friend WithEvents Calc As Button
    Friend WithEvents Label1 As Label
End Class
