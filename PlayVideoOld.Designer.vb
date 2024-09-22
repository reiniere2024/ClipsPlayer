<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayVideoOld
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayVideoOld))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.ckb1 = New System.Windows.Forms.CheckBox
        Me.ckb2 = New System.Windows.Forms.CheckBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.t_wmv = New System.Windows.Forms.TextBox
        Me.t_mpg = New System.Windows.Forms.TextBox
        Me.t_avi = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tb2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tb1 = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.tbVideo = New System.Windows.Forms.TextBox
        Me.Button9 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.lbFiles = New System.Windows.Forms.ListBox
        Me.FBD1 = New System.Windows.Forms.FolderBrowserDialog
        Me.cb7 = New System.Windows.Forms.CheckBox
        Me.t_divx = New System.Windows.Forms.TextBox
        Me.t_flv = New System.Windows.Forms.TextBox
        Me.t_mp4 = New System.Windows.Forms.TextBox
        Me.t_asf = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.cb6 = New System.Windows.Forms.CheckBox
        Me.cb5 = New System.Windows.Forms.CheckBox
        Me.cb4 = New System.Windows.Forms.CheckBox
        Me.cb3 = New System.Windows.Forms.CheckBox
        Me.cb2 = New System.Windows.Forms.CheckBox
        Me.cb1 = New System.Windows.Forms.CheckBox
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "WMPlayer1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(17, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "MPlay32"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(293, 490)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Close"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ckb1
        '
        Me.ckb1.AutoSize = True
        Me.ckb1.Checked = True
        Me.ckb1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckb1.Location = New System.Drawing.Point(17, 90)
        Me.ckb1.Name = "ckb1"
        Me.ckb1.Size = New System.Drawing.Size(59, 17)
        Me.ckb1.TabIndex = 5
        Me.ckb1.Text = "Normal"
        Me.ckb1.UseVisualStyleBackColor = True
        '
        'ckb2
        '
        Me.ckb2.AutoSize = True
        Me.ckb2.Location = New System.Drawing.Point(17, 113)
        Me.ckb2.Name = "ckb2"
        Me.ckb2.Size = New System.Drawing.Size(75, 17)
        Me.ckb2.TabIndex = 7
        Me.ckb2.Text = "Maximized"
        Me.ckb2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(98, 86)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "WMPlayer2"
        Me.Button4.UseVisualStyleBackColor = True
        '
        't_wmv
        '
        Me.t_wmv.Location = New System.Drawing.Point(178, 230)
        Me.t_wmv.Name = "t_wmv"
        Me.t_wmv.Size = New System.Drawing.Size(49, 20)
        Me.t_wmv.TabIndex = 14
        Me.t_wmv.Text = "wdd"
        Me.t_wmv.Visible = False
        '
        't_mpg
        '
        Me.t_mpg.Location = New System.Drawing.Point(105, 230)
        Me.t_mpg.Name = "t_mpg"
        Me.t_mpg.Size = New System.Drawing.Size(49, 20)
        Me.t_mpg.TabIndex = 13
        Me.t_mpg.Text = "mdd"
        Me.t_mpg.Visible = False
        '
        't_avi
        '
        Me.t_avi.Location = New System.Drawing.Point(34, 230)
        Me.t_avi.Name = "t_avi"
        Me.t_avi.Size = New System.Drawing.Size(49, 20)
        Me.t_avi.TabIndex = 12
        Me.t_avi.Text = "add"
        Me.t_avi.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 572)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "out:"
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(98, 566)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(197, 20)
        Me.tb2.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 546)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "in:"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(98, 540)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(197, 20)
        Me.tb1.TabIndex = 15
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(271, 60)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(76, 23)
        Me.Button7.TabIndex = 51
        Me.Button7.Text = "DivXPlayer 1"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(271, 86)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(76, 23)
        Me.Button6.TabIndex = 52
        Me.Button6.Text = "DivXPlayer 2"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'tbVideo
        '
        Me.tbVideo.Location = New System.Drawing.Point(23, 15)
        Me.tbVideo.Name = "tbVideo"
        Me.tbVideo.Size = New System.Drawing.Size(226, 20)
        Me.tbVideo.TabIndex = 59
        '
        'Button9
        '
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(258, 13)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(32, 25)
        Me.Button9.TabIndex = 60
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button9.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.InitialDirectory = "D:\Program Files\7-Zip\Lang\new\clips"
        '
        'lbFiles
        '
        Me.lbFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFiles.FormattingEnabled = True
        Me.lbFiles.Location = New System.Drawing.Point(369, 15)
        Me.lbFiles.Name = "lbFiles"
        Me.lbFiles.Size = New System.Drawing.Size(271, 498)
        Me.lbFiles.TabIndex = 61
        '
        'cb7
        '
        Me.cb7.AutoSize = True
        Me.cb7.Location = New System.Drawing.Point(47, 177)
        Me.cb7.Name = "cb7"
        Me.cb7.Size = New System.Drawing.Size(45, 17)
        Me.cb7.TabIndex = 72
        Me.cb7.Text = "divx"
        Me.cb7.UseVisualStyleBackColor = True
        Me.cb7.Visible = False
        '
        't_divx
        '
        Me.t_divx.Location = New System.Drawing.Point(270, 204)
        Me.t_divx.Name = "t_divx"
        Me.t_divx.Size = New System.Drawing.Size(34, 20)
        Me.t_divx.TabIndex = 79
        Me.t_divx.Text = "divxdd"
        Me.t_divx.Visible = False
        '
        't_flv
        '
        Me.t_flv.Location = New System.Drawing.Point(232, 204)
        Me.t_flv.Name = "t_flv"
        Me.t_flv.Size = New System.Drawing.Size(34, 20)
        Me.t_flv.TabIndex = 78
        Me.t_flv.Text = "fld"
        Me.t_flv.Visible = False
        '
        't_mp4
        '
        Me.t_mp4.Location = New System.Drawing.Point(187, 204)
        Me.t_mp4.Name = "t_mp4"
        Me.t_mp4.Size = New System.Drawing.Size(40, 20)
        Me.t_mp4.TabIndex = 77
        Me.t_mp4.Text = "m4d"
        Me.t_mp4.Visible = False
        '
        't_asf
        '
        Me.t_asf.Location = New System.Drawing.Point(146, 204)
        Me.t_asf.Name = "t_asf"
        Me.t_asf.Size = New System.Drawing.Size(34, 20)
        Me.t_asf.TabIndex = 76
        Me.t_asf.Text = "asd"
        Me.t_asf.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(109, 204)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(31, 20)
        Me.TextBox4.TabIndex = 75
        Me.TextBox4.Text = "wdd"
        Me.TextBox4.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(74, 204)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(31, 20)
        Me.TextBox5.TabIndex = 74
        Me.TextBox5.Text = "mdd"
        Me.TextBox5.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(38, 204)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(31, 20)
        Me.TextBox6.TabIndex = 73
        Me.TextBox6.Text = "add"
        Me.TextBox6.Visible = False
        '
        'cb6
        '
        Me.cb6.AutoSize = True
        Me.cb6.Checked = True
        Me.cb6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb6.Location = New System.Drawing.Point(276, 160)
        Me.cb6.Name = "cb6"
        Me.cb6.Size = New System.Drawing.Size(37, 17)
        Me.cb6.TabIndex = 85
        Me.cb6.Text = "flv"
        Me.cb6.UseVisualStyleBackColor = True
        Me.cb6.Visible = False
        '
        'cb5
        '
        Me.cb5.AutoSize = True
        Me.cb5.Checked = True
        Me.cb5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb5.Location = New System.Drawing.Point(228, 159)
        Me.cb5.Name = "cb5"
        Me.cb5.Size = New System.Drawing.Size(46, 17)
        Me.cb5.TabIndex = 84
        Me.cb5.Text = "mp4"
        Me.cb5.UseVisualStyleBackColor = True
        Me.cb5.Visible = False
        '
        'cb4
        '
        Me.cb4.AutoSize = True
        Me.cb4.Checked = True
        Me.cb4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb4.Location = New System.Drawing.Point(186, 160)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(40, 17)
        Me.cb4.TabIndex = 83
        Me.cb4.Text = "asf"
        Me.cb4.UseVisualStyleBackColor = True
        Me.cb4.Visible = False
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Checked = True
        Me.cb3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb3.Location = New System.Drawing.Point(138, 160)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(48, 17)
        Me.cb3.TabIndex = 82
        Me.cb3.Text = "wmv"
        Me.cb3.UseVisualStyleBackColor = True
        Me.cb3.Visible = False
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Checked = True
        Me.cb2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb2.Location = New System.Drawing.Point(89, 160)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(46, 17)
        Me.cb2.TabIndex = 81
        Me.cb2.Text = "mpg"
        Me.cb2.UseVisualStyleBackColor = True
        Me.cb2.Visible = False
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Checked = True
        Me.cb1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb1.Location = New System.Drawing.Point(46, 160)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(40, 17)
        Me.cb1.TabIndex = 80
        Me.cb1.Text = "avi"
        Me.cb1.UseVisualStyleBackColor = True
        Me.cb1.Visible = False
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(187, 60)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 86
        Me.Button12.Text = "VLCPlayer1"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(187, 86)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 87
        Me.Button13.Text = "VLCPlayer2"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'PlayVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 527)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.cb6)
        Me.Controls.Add(Me.cb5)
        Me.Controls.Add(Me.cb4)
        Me.Controls.Add(Me.cb3)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.t_divx)
        Me.Controls.Add(Me.t_flv)
        Me.Controls.Add(Me.t_mp4)
        Me.Controls.Add(Me.t_asf)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.cb7)
        Me.Controls.Add(Me.lbFiles)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.tbVideo)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.t_wmv)
        Me.Controls.Add(Me.t_mpg)
        Me.Controls.Add(Me.t_avi)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ckb2)
        Me.Controls.Add(Me.ckb1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "PlayVideo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Afspelen Video"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ckb1 As System.Windows.Forms.CheckBox
    Friend WithEvents ckb2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents t_wmv As System.Windows.Forms.TextBox
    Friend WithEvents t_mpg As System.Windows.Forms.TextBox
    Friend WithEvents t_avi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents tbVideo As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbFiles As System.Windows.Forms.ListBox
    Friend WithEvents FBD1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cb7 As System.Windows.Forms.CheckBox
    Friend WithEvents t_divx As System.Windows.Forms.TextBox
    Friend WithEvents t_flv As System.Windows.Forms.TextBox
    Friend WithEvents t_mp4 As System.Windows.Forms.TextBox
    Friend WithEvents t_asf As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents cb6 As System.Windows.Forms.CheckBox
    Friend WithEvents cb5 As System.Windows.Forms.CheckBox
    Friend WithEvents cb4 As System.Windows.Forms.CheckBox
    Friend WithEvents cb3 As System.Windows.Forms.CheckBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
End Class
