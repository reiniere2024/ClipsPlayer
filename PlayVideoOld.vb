Imports System.Data.SqlClient

Public Class PlayVideoOld
    Private started As Boolean = True
    Private s_avi As String
    Private s_mpg As String
    Private s_wmv As String
    Private s_drive As String

    Private Sub PlayVideo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String
        Dim ds, ds1 As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet

        ds = New DataSet
        ds.ReadXml(CurDir() + "\server.xml")

        srv = ds.Tables(0).Rows(0).Item(1)
        user = ds.Tables(0).Rows(0).Item(2)
        pwd = ds.Tables(0).Rows(0).Item(3)
        db = ds.Tables(0).Rows(0).Item(4)

        ds1 = New DataSet
        ds1.ReadXml(CurDir() + "\files.xml")

        tb1.Text = ds1.Tables(0).Rows(0).Item(0)
        tb2.Text = ds1.Tables(0).Rows(0).Item(1)
        tbVideo.Text = tb1.Text
        FBD1.SelectedPath = tbVideo.Text
        tbVideo.Text = FBD1.SelectedPath
        lbFiles.Items.Clear()
        'Me.listfiles("*.*")


        s_avi = t_avi.Text
        s_mpg = t_mpg.Text
        s_wmv = t_wmv.Text


    End Sub



    Private Function ChangeDrive(ByVal fnam As String) As String
        Dim newfnam As String


        'MsgBox(fnam)
        newfnam = s_drive + Mid(fnam, 3, Len(fnam) - 2)
        'MsgBox(newfnam)

        Return newfnam

    End Function


    Private Function GetDirector(ByVal mycon As SqlConnection, ByVal soortnaam As String) As Integer

        Dim my_sql As String
        Dim soortid As Integer
        Dim mycommand As New SqlCommand

        my_sql = "select director from director where dir_name = '" + soortnaam + "'"
        mycommand.CommandText = my_sql
        mycommand.Connection = mycon
        soortid = mycommand.ExecuteScalar()
        Return soortid

    End Function

    Private Function GetFileName(ByVal mycon As SqlConnection, ByVal soortnaam As String) As String

        Dim my_sql As String
        Dim soortid As String
        Dim mycommand As New SqlCommand

        my_sql = "select dirname+'\'+filename from movie where movie_name = '" + soortnaam + "'"
        mycommand.CommandText = my_sql
        mycommand.Connection = mycon
        soortid = mycommand.ExecuteScalar()
        Return soortid

    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim str, filname1, filname2, ext As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String
        Dim ds As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet


        filname1 = tbVideo.Text + "\" + lbFiles.Text
        str = "mplay32 /play " + filname1
        If ckb1.Checked = True Then
            returnid = Shell(str, vbNormalFocus)
        Else
            returnid = Shell(str, vbMaximizedFocus)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str, filname1, filname2, ext As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String
        Dim ds As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet


        filname1 = tbVideo.Text + "\" + lbFiles.Text

        str = "c:\Program Files\Windows Media Player\wmplayer.exe " + filname1
        If ckb1.Checked = True Then
            returnid = Shell(str, vbNormalFocus)
        Else
            returnid = Shell(str, vbMaximizedFocus)
        End If



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim str, filname1, filname2, ext As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String
        Dim ds As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet


        filname1 = tbVideo.Text + "\" + lbFiles.Text

        Dim myprocess As System.Diagnostics.Process = New System.Diagnostics.Process()
        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.StartInfo.UseShellExecute = False

        If ckb1.Checked = True Then
            myprocess.Start("wmplayer.exe", filname1)
        Else
            myprocess.Start("wmplayer.exe", filname1)
        End If


    End Sub



    Private Function GetER(ByVal mycon As SqlConnection, ByVal soortnaam As String) As String

        Dim my_sql As String
        Dim soortid As String
        Dim mycommand As New SqlCommand

        my_sql = "select isnull(er,'') from movie where movie_name = '" + soortnaam + "'"
        mycommand.CommandText = my_sql
        mycommand.Connection = mycon
        soortid = mycommand.ExecuteScalar()
        If soortid = "XX" Then
            soortid = "X X"
        End If
        If soortid = "XXX" Then
            soortid = "X X X"
        End If
        Return soortid

    End Function

    Private Function GetHC(ByVal mycon As SqlConnection, ByVal soortnaam As String) As String

        Dim my_sql As String
        Dim soortid As String
        Dim mycommand As New SqlCommand

        my_sql = "select isnull(ha,'') from movie where movie_name = '" + soortnaam + "'"
        mycommand.CommandText = my_sql
        mycommand.Connection = mycon
        soortid = mycommand.ExecuteScalar()
        If soortid = "XX" Then
            soortid = "X X"
        End If
        If soortid = "XXX" Then
            soortid = "X X X"
        End If
        Return soortid

    End Function
    Private Function GetQU(ByVal mycon As SqlConnection, ByVal soortnaam As String) As String

        Dim my_sql As String
        Dim soortid As String
        Dim mycommand As New SqlCommand

        my_sql = "select isnull(qu,'') from movie where movie_name = '" + soortnaam + "'"
        mycommand.CommandText = my_sql
        mycommand.Connection = mycon
        soortid = mycommand.ExecuteScalar()
        If soortid = "XX" Then
            soortid = "X X"
        End If
        If soortid = "XXX" Then
            soortid = "X X X"
        End If
        Return soortid

    End Function

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myform As ShowPictures
        Dim str, filname1, filname2, ext As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String
        Dim ds As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet

        ds = New DataSet
        ds.ReadXml(CurDir() + "\server.xml")
        srv = ds.Tables(0).Rows(0).Item(1)
        user = ds.Tables(0).Rows(0).Item(2)
        pwd = ds.Tables(0).Rows(0).Item(3)
        db = ds.Tables(0).Rows(0).Item(4)
        mystring = "Data source=" + srv + ";user id=" + user + ";password=" + pwd + ";initial catalog=" + db + ";"
        Dim myconnection1 As New SqlConnection(mystring)
        myconnection1.Open()

        'filname1 = Me.GetPicName(myconnection1, combo2.Text)

        myconnection1.Close()

        myform = New ShowPictures(filname1)
        myform.Show()

    End Sub

    Private Function GetPicName(ByVal mycon As SqlConnection, ByVal soortnaam As String) As String

        Dim my_sql As String
        Dim soortid As String
        Dim mycommand As New SqlCommand

        my_sql = "select isnull(picdirname+'\'+picname,'') from movie where movie_name = '" + soortnaam + "'"
        mycommand.CommandText = my_sql
        mycommand.Connection = mycon
        soortid = mycommand.ExecuteScalar()
        Return soortid

    End Function


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim str, filname1, filname2, ext As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1, progname As String
        Dim ds As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet

        filname1 = tbVideo.Text + "\" + lbFiles.Text

        str = "C:\Program Files\DivX\DivX Plus Player\DivX Plus Player.exe " + filname1
        If ckb1.Checked = True Then
            returnid = Shell(str, vbNormalFocus)
        Else
            returnid = Shell(str, vbMaximizedFocus)
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim str, filname1, filname2, ext As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1, progname As String
        Dim ds As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet

        filname1 = tbVideo.Text + "\" + lbFiles.Text

        Dim myprocess As System.Diagnostics.Process = New System.Diagnostics.Process()
        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.StartInfo.UseShellExecute = False

        If ckb1.Checked = True Then
            myprocess.Start("C:\Program Files\DivX\DivX Plus Player\DivX Plus Player.exe", filname1)
        Else
            myprocess.Start("C:\Program Files\DivX\DivX Plus Player\DivX Plus Player.exe", filname1)
        End If


    End Sub





    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click


        FBD1.SelectedPath = tbVideo.Text
        If FBD1.ShowDialog() = 1 Then
            tbVideo.Text = FBD1.SelectedPath
            tb1.Text = tbVideo.Text
            tb2.Text = tbVideo.Text

            lbFiles.Items.Clear()
            Me.listfiles("*.*")
        End If


        ' OpenFileDialog1.ShowDialog()
        ' tbVideo.Text = OpenFileDialog1.FileName


    End Sub

    Private Sub listfiles(ByVal pattern As String)
        'Dim pattern As String = "*.*"
        Dim dir_info As New System.IO.DirectoryInfo(tbVideo.Text)

        'list files in listbox
        Dim fs_infos() As System.IO.FileInfo = dir_info.GetFiles(pattern)
        For Each fs_info As System.IO.FileInfo In fs_infos
            'lbFiles.Items.Add(fs_info.FullName)
            lbFiles.Items.Add(fs_info.Name)
        Next fs_info
        fs_infos = Nothing

    End Sub

    Private Sub lbFiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbFiles.SelectedIndexChanged


    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str, str1, filname1 As String
        Dim i, returnid As Integer

        i = lbFiles.SelectedIndex
        str1 = lbFiles.Items(i + 1)
        lbFiles.SelectedIndex = i + 1

        filname1 = tbVideo.Text + "\" + lbFiles.Text
        str = "mplay32 /play " + filname1
        If ckb1.Checked = True Then
            returnid = Shell(str, vbNormalFocus)
        Else
            returnid = Shell(str, vbMaximizedFocus)
        End If



    End Sub
    Private Sub renamefiles(ByVal pattern As String)

        Dim fn1, fn2, fn_s, ext As String
        Dim dir_info As New System.IO.DirectoryInfo(tb1.Text)
        Dim fso
        fso = CreateObject("Scripting.FileSystemObject")

        'list files in listbox
        Dim fs_infos() As System.IO.FileInfo = dir_info.GetFiles(pattern)
        For Each fs_info As System.IO.FileInfo In fs_infos
            fn1 = fs_info.FullName
            fn_s = Mid(fs_info.Name, 1, Len(fs_info.Name) - 3)
            ext = Mid(fn1, Len(fn1) - 2, 3)
            Select Case ext
                Case "avi"
                    fn2 = tb2.Text + "\" + fn_s + t_avi.Text
                    fso.MoveFile(fn1, fn2)
                Case "mpg"
                    fn2 = tb2.Text + "\" + fn_s + t_mpg.Text
                    fso.MoveFile(fn1, fn2)
                Case "wmv"
                    fn2 = tb2.Text + "\" + fn_s + t_wmv.Text
                    fso.MoveFile(fn1, fn2)
                Case "asf"
                    fn2 = tb2.Text + "\" + fn_s + t_asf.Text
                    fso.MoveFile(fn1, fn2)
                Case "mp4"
                    fn2 = tb2.Text + "\" + fn_s + t_mp4.Text
                    fso.MoveFile(fn1, fn2)
                Case "flv"
                    fn2 = tb2.Text + "\" + fn_s + t_flv.Text
                    fso.MoveFile(fn1, fn2)
                Case "divx"
                    fn2 = tb2.Text + "\" + fn_s + t_divx.Text
                    fso.MoveFile(fn1, fn2)
            End Select
        Next fs_info
        fs_infos = Nothing

    End Sub

    Private Sub cb_enc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pattern As String

        If cb1.Checked = True And cb2.Checked = True And cb3.Checked = True Then
            pattern = "*.*"
        Else
            If cb1.Checked = True Then
                pattern = "*.avi"
            End If
            If cb2.Checked = True Then
                pattern = "*.mpg"
            End If
            If cb3.Checked = True Then
                pattern = "*.wmv"
            End If
        End If

        Me.renamefiles(pattern)
        lbFiles.Items.Clear()
        Me.listfiles("*.*")

    End Sub
    Private Sub renamefiles2(ByVal pattern As String)

        Dim fn1, fn2, fn_s, ext As String
        Dim dir_info As New System.IO.DirectoryInfo(tbVideo.Text)
        Dim extlen As Integer
        Dim fso
        fso = CreateObject("Scripting.FileSystemObject")

        extlen = Len(t_avi.Text)

        'list files in listbox
        Dim fs_infos() As System.IO.FileInfo = dir_info.GetFiles(pattern)
        For Each fs_info As System.IO.FileInfo In fs_infos
            fn1 = fs_info.FullName
            fn_s = Mid(fs_info.Name, 1, Len(fs_info.Name) - extlen)
            ext = Mid(fn1, Len(fn1) - extlen + 1, extlen)
            Select Case ext
                Case t_avi.Text
                    fn2 = tb2.Text + "\" + fn_s + "avi"
                    fso.MoveFile(fn1, fn2)
                Case t_mpg.Text
                    fn2 = tb2.Text + "\" + fn_s + "mpg"
                    fso.MoveFile(fn1, fn2)
                Case t_wmv.Text
                    fn2 = tb2.Text + "\" + fn_s + "wmv"
                    fso.MoveFile(fn1, fn2)
                Case t_asf.Text
                    fn2 = tb2.Text + "\" + fn_s + "asf"
                    fso.MoveFile(fn1, fn2)
                Case t_mp4.Text
                    fn2 = tb2.Text + "\" + fn_s + "mp4"
                    fso.MoveFile(fn1, fn2)
                Case t_flv.Text
                    fn2 = tb2.Text + "\" + fn_s + "flv"
                    fso.MoveFile(fn1, fn2)
                Case t_divx.Text
                    fn2 = tb2.Text + "\" + fn_s + "divx"
                    fso.MoveFile(fn1, fn2)

            End Select
        Next fs_info
        fs_infos = Nothing

    End Sub


    Private Sub cb_dec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pattern As String

        If cb1.Checked = True And cb2.Checked = True And cb3.Checked = True Then
            pattern = "*.*"
        Else
            If cb1.Checked = True Then
                pattern = "*." + t_avi.Text
            End If
            If cb2.Checked = True Then
                pattern = "*." + t_mpg.Text
            End If
            If cb3.Checked = True Then
                pattern = "*." + t_wmv.Text
            End If
        End If
        Me.renamefiles2(pattern)
        lbFiles.Items.Clear()
        Me.listfiles("*.*")

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim str, filname1, filname2, ext As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String
        Dim ds As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet


        filname1 = tbVideo.Text + "\" + lbFiles.Text

        str = "C:\Program Files\VideoLAN\VLC\vlc.exe " + filname1
        If ckb1.Checked = True Then
            returnid = Shell(str, vbNormalFocus)
        Else
            returnid = Shell(str, vbMaximizedFocus)
        End If

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim str, filname1, filname2, ext As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String
        Dim ds As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet


        filname1 = tbVideo.Text + "\" + lbFiles.Text

        Dim myprocess As System.Diagnostics.Process = New System.Diagnostics.Process()
        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.StartInfo.UseShellExecute = False

        If ckb1.Checked = True Then
            myprocess.Start("C:\Program Files\VideoLAN\VLC\vlc.exe", filname1)
        Else
            myprocess.Start("C:\Program Files\VideoLAN\VLC\vlc.exe", filname1)
        End If

    End Sub
End Class