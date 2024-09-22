Public Class ShowPictures

    Private MyPict As String
    Private Mynum As Integer = 1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim picname As String

        Mynum = Mynum + 1
        picname = Mid(MyPict, 1, Len(MyPict) - 4) + Mynum.ToString() + Mid(MyPict, Len(MyPict) - 3, 4)
        If System.IO.File.Exists(picname) Then
            PB1.Image = System.Drawing.Image.FromFile(picname)
        End If

    End Sub

    Private Sub ShowPictures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Public Sub New(ByVal picname As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        MyPict = picname
        If System.IO.File.Exists(MyPict) Then
            PB1.Image = System.Drawing.Image.FromFile(MyPict)
        Else
            Button1.Enabled = False
        End If

    End Sub

End Class