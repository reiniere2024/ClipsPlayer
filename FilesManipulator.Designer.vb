<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilesManipulator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilesManipulator))
        Me.tb1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tb2 = New System.Windows.Forms.TextBox
        Me.cb1 = New System.Windows.Forms.CheckBox
        Me.cb2 = New System.Windows.Forms.CheckBox
        Me.cb3 = New System.Windows.Forms.CheckBox
        Me.cb_enc = New System.Windows.Forms.Button
        Me.cb_dec = New System.Windows.Forms.Button
        Me.t_avi = New System.Windows.Forms.TextBox
        Me.t_mpg = New System.Windows.Forms.TextBox
        Me.t_wmv = New System.Windows.Forms.TextBox
        Me.lbFiles = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.FBD1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Button2 = New System.Windows.Forms.Button
        Me.cb4 = New System.Windows.Forms.CheckBox
        Me.cb5 = New System.Windows.Forms.CheckBox
        Me.cb6 = New System.Windows.Forms.CheckBox
        Me.cb7 = New System.Windows.Forms.CheckBox
        Me.t_asf = New System.Windows.Forms.TextBox
        Me.t_mp4 = New System.Windows.Forms.TextBox
        Me.t_flv = New System.Windows.Forms.TextBox
        Me.t_divx = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.t_avifile = New System.Windows.Forms.TextBox
        Me.cbxNewName = New System.Windows.Forms.CheckBox
        Me.cbxFolder = New System.Windows.Forms.CheckBox
        Me.t_foldername = New System.Windows.Forms.TextBox
        Me.cbx1000 = New System.Windows.Forms.CheckBox
        Me.cbx100 = New System.Windows.Forms.CheckBox
        Me.cbx10 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(66, 34)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(197, 20)
        Me.tb1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "in:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "out:"
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(66, 60)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(197, 20)
        Me.tb2.TabIndex = 2
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Checked = True
        Me.cb1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb1.Location = New System.Drawing.Point(30, 143)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(40, 17)
        Me.cb1.TabIndex = 4
        Me.cb1.Text = "avi"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Checked = True
        Me.cb2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb2.Location = New System.Drawing.Point(30, 166)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(46, 17)
        Me.cb2.TabIndex = 5
        Me.cb2.Text = "mpg"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Checked = True
        Me.cb3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb3.Location = New System.Drawing.Point(30, 188)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(48, 17)
        Me.cb3.TabIndex = 6
        Me.cb3.Text = "wmv"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb_enc
        '
        Me.cb_enc.Image = CType(resources.GetObject("cb_enc.Image"), System.Drawing.Image)
        Me.cb_enc.Location = New System.Drawing.Point(277, 30)
        Me.cb_enc.Name = "cb_enc"
        Me.cb_enc.Size = New System.Drawing.Size(75, 23)
        Me.cb_enc.TabIndex = 7
        Me.cb_enc.Text = " Lock"
        Me.cb_enc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cb_enc.UseVisualStyleBackColor = True
        '
        'cb_dec
        '
        Me.cb_dec.Image = CType(resources.GetObject("cb_dec.Image"), System.Drawing.Image)
        Me.cb_dec.Location = New System.Drawing.Point(277, 59)
        Me.cb_dec.Name = "cb_dec"
        Me.cb_dec.Size = New System.Drawing.Size(75, 23)
        Me.cb_dec.TabIndex = 8
        Me.cb_dec.Text = "Unlock"
        Me.cb_dec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cb_dec.UseVisualStyleBackColor = True
        '
        't_avi
        '
        Me.t_avi.Location = New System.Drawing.Point(86, 141)
        Me.t_avi.Name = "t_avi"
        Me.t_avi.Size = New System.Drawing.Size(30, 20)
        Me.t_avi.TabIndex = 9
        Me.t_avi.Text = "add"
        '
        't_mpg
        '
        Me.t_mpg.Location = New System.Drawing.Point(86, 163)
        Me.t_mpg.Name = "t_mpg"
        Me.t_mpg.Size = New System.Drawing.Size(30, 20)
        Me.t_mpg.TabIndex = 10
        Me.t_mpg.Text = "mdd"
        '
        't_wmv
        '
        Me.t_wmv.Location = New System.Drawing.Point(86, 186)
        Me.t_wmv.Name = "t_wmv"
        Me.t_wmv.Size = New System.Drawing.Size(30, 20)
        Me.t_wmv.TabIndex = 11
        Me.t_wmv.Text = "wdd"
        '
        'lbFiles
        '
        Me.lbFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFiles.FormattingEnabled = True
        Me.lbFiles.Location = New System.Drawing.Point(372, 12)
        Me.lbFiles.Name = "lbFiles"
        Me.lbFiles.Size = New System.Drawing.Size(264, 550)
        Me.lbFiles.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(27, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 26)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Search"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(291, 535)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Close"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cb4
        '
        Me.cb4.AutoSize = True
        Me.cb4.Checked = True
        Me.cb4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb4.Location = New System.Drawing.Point(30, 212)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(40, 17)
        Me.cb4.TabIndex = 15
        Me.cb4.Text = "asf"
        Me.cb4.UseVisualStyleBackColor = True
        '
        'cb5
        '
        Me.cb5.AutoSize = True
        Me.cb5.Checked = True
        Me.cb5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb5.Location = New System.Drawing.Point(30, 234)
        Me.cb5.Name = "cb5"
        Me.cb5.Size = New System.Drawing.Size(46, 17)
        Me.cb5.TabIndex = 16
        Me.cb5.Text = "mp4"
        Me.cb5.UseVisualStyleBackColor = True
        '
        'cb6
        '
        Me.cb6.AutoSize = True
        Me.cb6.Checked = True
        Me.cb6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb6.Location = New System.Drawing.Point(30, 258)
        Me.cb6.Name = "cb6"
        Me.cb6.Size = New System.Drawing.Size(37, 17)
        Me.cb6.TabIndex = 17
        Me.cb6.Text = "flv"
        Me.cb6.UseVisualStyleBackColor = True
        '
        'cb7
        '
        Me.cb7.AutoSize = True
        Me.cb7.Checked = True
        Me.cb7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb7.Location = New System.Drawing.Point(30, 281)
        Me.cb7.Name = "cb7"
        Me.cb7.Size = New System.Drawing.Size(45, 17)
        Me.cb7.TabIndex = 18
        Me.cb7.Text = "divx"
        Me.cb7.UseVisualStyleBackColor = True
        '
        't_asf
        '
        Me.t_asf.Location = New System.Drawing.Point(86, 209)
        Me.t_asf.Name = "t_asf"
        Me.t_asf.Size = New System.Drawing.Size(33, 20)
        Me.t_asf.TabIndex = 19
        Me.t_asf.Text = "asd"
        '
        't_mp4
        '
        Me.t_mp4.Location = New System.Drawing.Point(86, 232)
        Me.t_mp4.Name = "t_mp4"
        Me.t_mp4.Size = New System.Drawing.Size(34, 20)
        Me.t_mp4.TabIndex = 20
        Me.t_mp4.Text = "m4d"
        '
        't_flv
        '
        Me.t_flv.Location = New System.Drawing.Point(86, 256)
        Me.t_flv.Name = "t_flv"
        Me.t_flv.Size = New System.Drawing.Size(33, 20)
        Me.t_flv.TabIndex = 21
        Me.t_flv.Text = "fld"
        '
        't_divx
        '
        Me.t_divx.Location = New System.Drawing.Point(86, 278)
        Me.t_divx.Name = "t_divx"
        Me.t_divx.Size = New System.Drawing.Size(33, 20)
        Me.t_divx.TabIndex = 22
        Me.t_divx.Text = "ix"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(127, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 27)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Store"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        't_avifile
        '
        Me.t_avifile.Location = New System.Drawing.Point(160, 165)
        Me.t_avifile.Name = "t_avifile"
        Me.t_avifile.Size = New System.Drawing.Size(175, 20)
        Me.t_avifile.TabIndex = 24
        '
        'cbxNewName
        '
        Me.cbxNewName.AutoSize = True
        Me.cbxNewName.Location = New System.Drawing.Point(160, 143)
        Me.cbxNewName.Name = "cbxNewName"
        Me.cbxNewName.Size = New System.Drawing.Size(79, 17)
        Me.cbxNewName.TabIndex = 25
        Me.cbxNewName.Text = "New Name"
        Me.cbxNewName.UseVisualStyleBackColor = True
        '
        'cbxFolder
        '
        Me.cbxFolder.AutoSize = True
        Me.cbxFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cbxFolder.Location = New System.Drawing.Point(161, 199)
        Me.cbxFolder.Name = "cbxFolder"
        Me.cbxFolder.Size = New System.Drawing.Size(108, 17)
        Me.cbxFolder.TabIndex = 26
        Me.cbxFolder.Text = "Use Folder Name"
        Me.cbxFolder.UseVisualStyleBackColor = True
        '
        't_foldername
        '
        Me.t_foldername.Location = New System.Drawing.Point(160, 222)
        Me.t_foldername.Name = "t_foldername"
        Me.t_foldername.Size = New System.Drawing.Size(175, 20)
        Me.t_foldername.TabIndex = 27
        '
        'cbx1000
        '
        Me.cbx1000.AutoSize = True
        Me.cbx1000.Checked = True
        Me.cbx1000.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbx1000.Location = New System.Drawing.Point(161, 256)
        Me.cbx1000.Name = "cbx1000"
        Me.cbx1000.Size = New System.Drawing.Size(50, 17)
        Me.cbx1000.TabIndex = 28
        Me.cbx1000.Text = "1000"
        Me.cbx1000.UseVisualStyleBackColor = True
        '
        'cbx100
        '
        Me.cbx100.AutoSize = True
        Me.cbx100.Location = New System.Drawing.Point(219, 256)
        Me.cbx100.Name = "cbx100"
        Me.cbx100.Size = New System.Drawing.Size(44, 17)
        Me.cbx100.TabIndex = 29
        Me.cbx100.Text = "100"
        Me.cbx100.UseVisualStyleBackColor = True
        '
        'cbx10
        '
        Me.cbx10.AutoSize = True
        Me.cbx10.Location = New System.Drawing.Point(269, 256)
        Me.cbx10.Name = "cbx10"
        Me.cbx10.Size = New System.Drawing.Size(38, 17)
        Me.cbx10.TabIndex = 30
        Me.cbx10.Text = "10"
        Me.cbx10.UseVisualStyleBackColor = True
        '
        'FilesManipulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 570)
        Me.Controls.Add(Me.cbx10)
        Me.Controls.Add(Me.cbx100)
        Me.Controls.Add(Me.cbx1000)
        Me.Controls.Add(Me.t_foldername)
        Me.Controls.Add(Me.cbxFolder)
        Me.Controls.Add(Me.cbxNewName)
        Me.Controls.Add(Me.t_avifile)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.t_divx)
        Me.Controls.Add(Me.t_flv)
        Me.Controls.Add(Me.t_mp4)
        Me.Controls.Add(Me.t_asf)
        Me.Controls.Add(Me.cb7)
        Me.Controls.Add(Me.cb6)
        Me.Controls.Add(Me.cb5)
        Me.Controls.Add(Me.cb4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbFiles)
        Me.Controls.Add(Me.t_wmv)
        Me.Controls.Add(Me.t_mpg)
        Me.Controls.Add(Me.t_avi)
        Me.Controls.Add(Me.cb_dec)
        Me.Controls.Add(Me.cb_enc)
        Me.Controls.Add(Me.cb3)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb1)
        Me.Name = "FilesManipulator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Bestanden hernoemen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb2 As System.Windows.Forms.TextBox
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb3 As System.Windows.Forms.CheckBox
    Friend WithEvents cb_enc As System.Windows.Forms.Button
    Friend WithEvents cb_dec As System.Windows.Forms.Button
    Friend WithEvents t_avi As System.Windows.Forms.TextBox
    Friend WithEvents t_mpg As System.Windows.Forms.TextBox
    Friend WithEvents t_wmv As System.Windows.Forms.TextBox
    Friend WithEvents lbFiles As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FBD1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cb4 As System.Windows.Forms.CheckBox
    Friend WithEvents cb5 As System.Windows.Forms.CheckBox
    Friend WithEvents cb6 As System.Windows.Forms.CheckBox
    Friend WithEvents cb7 As System.Windows.Forms.CheckBox
    Friend WithEvents t_asf As System.Windows.Forms.TextBox
    Friend WithEvents t_mp4 As System.Windows.Forms.TextBox
    Friend WithEvents t_flv As System.Windows.Forms.TextBox
    Friend WithEvents t_divx As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents t_avifile As System.Windows.Forms.TextBox
    Friend WithEvents cbxNewName As System.Windows.Forms.CheckBox
    Friend WithEvents cbxFolder As System.Windows.Forms.CheckBox
    Friend WithEvents t_foldername As System.Windows.Forms.TextBox
    Friend WithEvents cbx1000 As System.Windows.Forms.CheckBox
    Friend WithEvents cbx100 As System.Windows.Forms.CheckBox
    Friend WithEvents cbx10 As System.Windows.Forms.CheckBox

End Class
