<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class note
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
        Me.note1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'note1
        '
        Me.note1.Location = New System.Drawing.Point(2, -6)
        Me.note1.Name = "note1"
        Me.note1.Size = New System.Drawing.Size(685, 455)
        Me.note1.TabIndex = 0
        Me.note1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(693, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(693, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 41)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(693, 99)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 41)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(693, 146)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 41)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(693, 334)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 41)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Button8"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(693, 287)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(101, 41)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Button7"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(693, 240)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(101, 41)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Button6"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(693, 193)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(101, 41)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Button5"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(693, 381)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(101, 41)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "save"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'note
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.note1)
        Me.DoubleBuffered = True
        Me.Name = "note"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents note1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
