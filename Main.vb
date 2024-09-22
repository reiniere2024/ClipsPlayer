Public Class Main
    Inherits System.Windows.Forms.Form


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Protected WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents butHoofdgroep As System.Windows.Forms.ToolBarButton
    Friend WithEvents butSubgroep As System.Windows.Forms.ToolBarButton
    Friend WithEvents butVragen As System.Windows.Forms.ToolBarButton
    Friend WithEvents butExit As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents butSearch As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.butHoofdgroep = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.butSubgroep = New System.Windows.Forms.ToolBarButton
        Me.butVragen = New System.Windows.Forms.ToolBarButton
        Me.butSearch = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.butExit = New System.Windows.Forms.ToolBarButton
        Me.SuspendLayout()
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = -1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem14, Me.MenuItem5})
        Me.MenuItem1.Text = "DB Transfer"
        '
        'MenuItem4
        '
        Me.MenuItem4.Checked = True
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "Settings"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "Comparison Tables"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.Text = "Transfer Tables"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = -1
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem12})
        Me.MenuItem6.Text = "DB Browser"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 0
        Me.MenuItem12.Text = "Browse Database"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = -1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem9, Me.MenuItem10, Me.MenuItem7, Me.MenuItem8})
        Me.MenuItem2.Text = "Vensters"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 0
        Me.MenuItem9.Text = "&Cascade"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 1
        Me.MenuItem10.Text = "&Layered"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.Text = "Vertical"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 3
        Me.MenuItem8.Text = "&Horizontal"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = -1
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem11})
        Me.MenuItem3.Text = "Help"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 0
        Me.MenuItem11.Text = "About"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "music.gif")
        Me.ImageList1.Images.SetKeyName(1, "tv.GIF")
        Me.ImageList1.Images.SetKeyName(2, "DataQuery2.gif")
        Me.ImageList1.Images.SetKeyName(3, "DocumentDelete.gif")
        Me.ImageList1.Images.SetKeyName(4, "Door.gif")
        Me.ImageList1.Images.SetKeyName(5, "Print.gif")
        Me.ImageList1.Images.SetKeyName(6, "SearchRow.gif")
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.butHoofdgroep, Me.ToolBarButton1, Me.ToolBarButton2, Me.butSubgroep, Me.butVragen, Me.butSearch, Me.ToolBarButton4, Me.butExit})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(682, 28)
        Me.ToolBar1.TabIndex = 1
        '
        'butHoofdgroep
        '
        Me.butHoofdgroep.ImageIndex = 2
        Me.butHoofdgroep.Name = "butHoofdgroep"
        Me.butHoofdgroep.ToolTipText = "Change Files"
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'butSubgroep
        '
        Me.butSubgroep.ImageIndex = 1
        Me.butSubgroep.Name = "butSubgroep"
        Me.butSubgroep.ToolTipText = "Play Video"
        '
        'butVragen
        '
        Me.butVragen.ImageIndex = 0
        Me.butVragen.Name = "butVragen"
        Me.butVragen.ToolTipText = "Play Music"
        '
        'butSearch
        '
        Me.butSearch.ImageIndex = 6
        Me.butSearch.Name = "butSearch"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.Name = "ToolBarButton4"
        Me.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'butExit
        '
        Me.butExit.ImageIndex = 4
        Me.butExit.Name = "butExit"
        Me.butExit.ToolTipText = "Exit"
        '
        'Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(682, 504)
        Me.Controls.Add(Me.ToolBar1)
        Me.IsMdiContainer = True
        Me.Name = "Main"
        Me.Text = "Universal Media Software"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        'Dim myform As New frmDatabases
        Dim myform As New FilesManipulator

        myform.MdiParent = Me
        myform.Show()

    End Sub



    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)

    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)

    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)

    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)

    End Sub




    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        'Dim myform As New frmExplorer
        Dim myform As New FilesManipulator
        myform.MdiParent = Me
        myform.Show()

    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click

        'Dim myform As New frmExplorer
        Dim myform As New FilesManipulator
        myform.MdiParent = Me
        myform.Show()

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button.ImageIndex = 0 Then
            Dim myform As New PlayVideo

            myform.MdiParent = Me
            myform.Show()
        ElseIf e.Button.ImageIndex = 1 Then
            Dim myform As New PlayVideoOld

            myform.MdiParent = Me
            myform.Show()
        ElseIf e.Button.ImageIndex = 2 Then
            Dim myform As New FilesManipulator
            myform.MdiParent = Me
            myform.Show()
        ElseIf e.Button.ImageIndex = 3 Then
            Dim myform As New FilesManipulator
            myform.MdiParent = Me
            myform.Show()
        ElseIf e.Button.ImageIndex = 6 Then
            Dim myform As New SearchVideo
            myform.MdiParent = Me
            myform.Show()
        ElseIf e.Button.ImageIndex = 4 Then
            Me.Close()
        ElseIf e.Button.ImageIndex = 5 Then
            Dim myform As New PlayMedia
            myform.MdiParent = Me
            myform.Show()

        End If



    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        'Dim myform As New frmTransferTables
        Dim myform As New FilesManipulator

        myform.MdiParent = Me
        myform.Show()

    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click

        'Dim myform As New frmBrowseDatabase
        Dim myform As New FilesManipulator


        myform.MdiParent = Me
        myform.Show()


    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
