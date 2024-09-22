<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tab1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ckb2 = New System.Windows.Forms.CheckBox
        Me.ckb3 = New System.Windows.Forms.CheckBox
        Me.ckb4 = New System.Windows.Forms.CheckBox
        Me.ckb1 = New System.Windows.Forms.CheckBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.cb3 = New System.Windows.Forms.ComboBox
        Me.cb2 = New System.Windows.Forms.ComboBox
        Me.cb1 = New System.Windows.Forms.ComboBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.tab1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab1
        '
        Me.tab1.Controls.Add(Me.TabPage1)
        Me.tab1.Controls.Add(Me.TabPage2)
        Me.tab1.Location = New System.Drawing.Point(27, 26)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedIndex = 0
        Me.tab1.Size = New System.Drawing.Size(332, 300)
        Me.tab1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.ckb2)
        Me.TabPage1.Controls.Add(Me.ckb3)
        Me.TabPage1.Controls.Add(Me.ckb4)
        Me.TabPage1.Controls.Add(Me.ckb1)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.cb3)
        Me.TabPage1.Controls.Add(Me.cb2)
        Me.TabPage1.Controls.Add(Me.cb1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(324, 274)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "WMPlayer1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "MPlay32"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ckb2
        '
        Me.ckb2.AutoSize = True
        Me.ckb2.Location = New System.Drawing.Point(32, 193)
        Me.ckb2.Name = "ckb2"
        Me.ckb2.Size = New System.Drawing.Size(48, 17)
        Me.ckb2.TabIndex = 25
        Me.ckb2.Text = "Hide"
        Me.ckb2.UseVisualStyleBackColor = True
        '
        'ckb3
        '
        Me.ckb3.AutoSize = True
        Me.ckb3.Location = New System.Drawing.Point(32, 209)
        Me.ckb3.Name = "ckb3"
        Me.ckb3.Size = New System.Drawing.Size(72, 17)
        Me.ckb3.TabIndex = 24
        Me.ckb3.Text = "Minimized"
        Me.ckb3.UseVisualStyleBackColor = True
        '
        'ckb4
        '
        Me.ckb4.AutoSize = True
        Me.ckb4.Location = New System.Drawing.Point(32, 226)
        Me.ckb4.Name = "ckb4"
        Me.ckb4.Size = New System.Drawing.Size(75, 17)
        Me.ckb4.TabIndex = 23
        Me.ckb4.Text = "Maximized"
        Me.ckb4.UseVisualStyleBackColor = True
        '
        'ckb1
        '
        Me.ckb1.AutoSize = True
        Me.ckb1.Checked = True
        Me.ckb1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckb1.Location = New System.Drawing.Point(33, 178)
        Me.ckb1.Name = "ckb1"
        Me.ckb1.Size = New System.Drawing.Size(59, 17)
        Me.ckb1.TabIndex = 22
        Me.ckb1.Text = "Normal"
        Me.ckb1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(259, 48)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(36, 23)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "<<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(259, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 23)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.FormattingEnabled = True
        Me.cb3.Location = New System.Drawing.Point(24, 75)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(208, 21)
        Me.cb3.TabIndex = 18
        '
        'cb2
        '
        Me.cb2.FormattingEnabled = True
        Me.cb2.Location = New System.Drawing.Point(24, 48)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(208, 21)
        Me.cb2.TabIndex = 17
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(23, 21)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(209, 21)
        Me.cb1.TabIndex = 16
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(324, 274)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 458)
        Me.Controls.Add(Me.tab1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tab1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ckb2 As System.Windows.Forms.CheckBox
    Friend WithEvents ckb3 As System.Windows.Forms.CheckBox
    Friend WithEvents ckb4 As System.Windows.Forms.CheckBox
    Friend WithEvents ckb1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cb3 As System.Windows.Forms.ComboBox
    Friend WithEvents cb2 As System.Windows.Forms.ComboBox
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
