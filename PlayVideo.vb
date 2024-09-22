Imports System.Data.SqlClient

Public Class PlayVideo
    Private d_quote As String = Chr(34)
    Private ds_playlist As New DataSet
    Private s_drive As String
    Private ds1 As New DataSet

    Private VLCPath As String
    Private MPCPath As String
    Private MPLPath As String
    Private SMPath As String


    Private Sub PlayMusic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String
        Dim ds As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet

        ds = New DataSet
        ds.ReadXml(CurDir() + "\xml\server2.xml")
        ds_playlist.ReadXml(CurDir() + "\xml\playlist.xml")

        'Me.DataGrid1.DataSource = Me.ds_playlist.Tables(0)
        Me.FormatColumnHeaders()
        ds_playlist.Tables(0).Rows.RemoveAt(0)
        Me.CurDrive()

        ds1.ReadXml(CurDir() + "\xml\filesmusic.xml")
        If ds1.Tables(0).Rows(0).Item(1) = "" Then
            ds1.Tables(0).Rows(0).Item(0) = CurDir() + "\Clips"
            ds1.Tables(0).Rows(0).Item(1) = CurDir() + "\Clips"
            ds1.WriteXml(CurDir() + "\xml\filesmusic.xml")
        End If
        tb2.Text = ds1.Tables(0).Rows(0).Item(1)

        tb2.Text = ds1.Tables(0).Rows(0).Item(1)
        VLCPath = ds1.Tables(0).Rows(0).Item(3)
        MPCPath = ds1.Tables(0).Rows(0).Item(4)
        MPLPath = ds1.Tables(0).Rows(0).Item(5)
        SMPath = ds1.Tables(0).Rows(0).Item(6)

        FBD1.SelectedPath = tb2.Text
        cb3.Items.Clear()
        Me.listfiles("*.*")


    End Sub

    Private Sub CurDrive()
        Dim ds1 As DataSet
        Dim drive As String

        ds1 = New DataSet
        ds1.ReadXml(CurDir() + "\xml\filesmusic.xml")
        drive = ds1.Tables(0).Rows(0).Item(2)
        If drive = "C:" Then
            cbC.Checked = True
        ElseIf drive = "D:" Then
            cbD.Checked = True
        ElseIf drive = "E:" Then
            cbE.Checked = True
        ElseIf drive = "F:" Then
            cbF.Checked = True
        ElseIf drive = "G:" Then
            cbG.Checked = True
        End If

    End Sub
    Private Sub GetDrive()
        If cbC.Checked = True Then
            s_drive = "C:"
        ElseIf cbD.Checked = True Then
            s_drive = "D:"
        ElseIf cbE.Checked = True Then
            s_drive = "E:"
        ElseIf cbF.Checked = True Then
            s_drive = "F:"
        ElseIf cbG.Checked = True Then
            s_drive = "G:"
        End If
    End Sub
    Private Function ChangeDrive(ByVal fnam As String) As String
        Dim newfnam As String

        Me.GetDrive()
        'MsgBox(fnam)
        newfnam = s_drive + Mid(fnam, 3, Len(fnam) - 2)
        'MsgBox(newfnam)

        Return newfnam

    End Function

    Private Sub FormatColumnHeaders()

        Dim ts As New DataGridTableStyle
        Dim cs1, cs2 As DataGridTextBoxColumn
        ts.MappingName = "PLAYLIST"
        cs1 = New DataGridTextBoxColumn
        cs1.MappingName = "NAME"
        cs1.HeaderText = "Song Title:"
        cs1.Width = 400
        ts.GridColumnStyles.Add(cs1)

        cs2 = New DataGridTextBoxColumn
        cs2.MappingName = "DIR"
        cs2.HeaderText = "DIRECTORY:"
        cs2.Width = 0
        ts.GridColumnStyles.Add(cs2)

        'DataGrid1.TableStyles.Add(ts)

    End Sub

    Private Function GetAuthor(ByVal mycon As SqlConnection, ByVal soortnaam As String) As Integer

        Dim my_sql As String
        Dim soortid As Integer
        Dim mycommand As New SqlCommand

        my_sql = "select authorid from author where authorname = '" + soortnaam + "'"
        mycommand.CommandText = my_sql
        mycommand.Connection = mycon
        soortid = mycommand.ExecuteScalar()
        Return soortid

    End Function

    Private Function GetAlbum(ByVal mycon As SqlConnection, ByVal soortnaam As String) As Integer

        Dim my_sql As String
        Dim soortid As Integer
        Dim mycommand As New SqlCommand

        my_sql = "select album_id from album where album_name = '" + soortnaam + "'"
        mycommand.CommandText = my_sql
        mycommand.Connection = mycon
        soortid = mycommand.ExecuteScalar()
        Return soortid

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Function GetFileName(ByVal mycon As SqlConnection, ByVal soortnaam As String) As String

        Dim my_sql As String
        Dim soortid As String
        Dim mycommand As New SqlCommand

        my_sql = "select directory from album where album_name = '" + soortnaam + "'"
        mycommand.CommandText = my_sql
        mycommand.Connection = mycon
        soortid = mycommand.ExecuteScalar()
        Return soortid

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cb3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim str, filname, dirname As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String
        Dim ds As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet

        dirname = tb2.Text
        filname = dirname + "\" + cb3.Text
        filname = ChangeDrive(filname)

        If MPCPath = "/MPC" Then
            str = CurDir() + MPCPath + "\mpc-hc64.exe /play " + filname
        Else
            str = MPCPath + "\mpc-hc64.exe /play " + filname
        End If

        Try
            returnid = Shell(str, vbNormalFocus)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str, dirname, filname, songname As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String


        dirname = tb2.Text
        filname = dirname + "\" + cb3.Text
        filname = ChangeDrive(filname)


        dirname = tb2.Text
        filname = dirname + "\" + cb3.Text
        filname = ChangeDrive(filname)


        If MPLPath = "wmplayer.exe" Then
            dirname = "wmplayer.exe"
        Else
            dirname = MPLPath + "\wmplayer.exe"
        End If
        str = dirname + filname

        Dim myprocess As System.Diagnostics.Process = New System.Diagnostics.Process()
        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.StartInfo.UseShellExecute = False
        myprocess.Start(dirname, filname)


        'Try
        '    returnid = Shell(str, vbNormalFocus)

        'Catch ex As Exception

        '    MsgBox(ex.Message)

        'End Try


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str, filname, myplaylist, playitem As String
        Dim i As Integer

        filname = ds_playlist.Tables(0).Rows(0).Item(1) + "\" + ds_playlist.Tables(0).Rows(0).Item(0)
        filname = ChangeDrive(filname)
        'playitem = ds_playlist.Tables(0).Rows(0).Item(1) + "\" + ds_playlist.Tables(0).Rows(0).Item(0)
        myplaylist = filname
        For i = 1 To ds_playlist.Tables(0).Rows.Count - 1
            'playitem = ds_playlist.Tables(0).Rows(i).Item(1) + "\" + ds_playlist.Tables(0).Rows(i).Item(0)
            filname = ds_playlist.Tables(0).Rows(i).Item(1) + "\" + ds_playlist.Tables(0).Rows(i).Item(0)
            filname = ChangeDrive(filname)
            myplaylist = myplaylist + " " + filname
        Next

        'MsgBox(myplaylist)
        Dim myprocess As System.Diagnostics.Process = New System.Diagnostics.Process()
        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.StartInfo.UseShellExecute = False
        myprocess.Start(MPLPath, myplaylist)


    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim str As String

        FBD1.SelectedPath = tb2.Text

        If FBD1.ShowDialog() = 1 Then
            tb2.Text = FBD1.SelectedPath
            cb3.Items.Clear()
            Me.listfiles("*.*")

            ds1.Tables(0).Rows(0).Item(0) = tb2.Text
            ds1.Tables(0).Rows(0).Item(1) = tb2.Text
            ds1.WriteXml(CurDir() + "\xml\filesmusic.xml")

        End If

    End Sub

    Private Sub listfiles(ByVal pattern As String)
        'Dim pattern As String = "*.*"
        Dim dir_info As New System.IO.DirectoryInfo(tb2.Text)


        Try
            'list files in listbox
            Dim fs_infos() As System.IO.FileInfo = dir_info.GetFiles(pattern)
            For Each fs_info As System.IO.FileInfo In fs_infos
                'lbFiles.Items.Add(fs_info.FullName)
                cb3.Items.Add(fs_info.Name)
            Next fs_info
            fs_infos = Nothing

        Catch ex As Exception

            MsgBox("There are no music files availible yet !")

        End Try

    End Sub


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim str, dirname, filname, songname As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String


        dirname = tb2.Text
        filname = dirname + "\" + cb3.Text
        filname = ChangeDrive(filname)


        If VLCPath = "/VLC" Then
            dirname = CurDir() + VLCPath + "\vlc.exe "
        Else
            dirname = VLCPath + "\vlc.exe "
        End If

        str = dirname + filname

        'Dim myprocess As System.Diagnostics.Process = New System.Diagnostics.Process()
        'myprocess.StartInfo.RedirectStandardOutput = True
        'myprocess.StartInfo.UseShellExecute = False
        'myprocess.Start(CurDir() + "\VLC\vlc.exe ", filname)
        'myprocess.Start("wmplayer.exe", filname + "\" + cb3.Text + ".mp3")
        'myprocess.Start("wmplayer.exe", filname + "\" + cb3.Text + ".mp3")
        'myprocess.Start("vlc.exe", filname)

        Try
            returnid = Shell(str, vbNormalFocus)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try




    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str, dirname, filname As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String


        dirname = tb2.Text

        Dim myprocess As System.Diagnostics.Process = New System.Diagnostics.Process()
        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.StartInfo.UseShellExecute = False
        'myprocess.Start("wmplayer.exe", filname + "\" + cb3.Text + ".mp3")

        filname = dirname + "\" + cb3.Text
        filname = ChangeDrive(filname)

        'myprocess.Start("C:\Program Files\DivX\DivX Plus Player\DivX Plus Player.exe", filname)

        str = "C:\Program Files\DivX\DivX Plus Player\DivX Plus Player.exe " + filname
        returnid = Shell(str, vbNormalFocus)


    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.setdrive()
    End Sub

    Private Sub SetDrive()
        Dim ds1 As DataSet
        Dim curdrive, drive As String

        ds1 = New DataSet
        ds1.ReadXml(CurDir() + "\xml\filesmusic.xml")
        CurDrive = ds1.Tables(0).Rows(0).Item(2)
        If cbC.Checked = True Then
            drive = "C:"
        ElseIf cbD.Checked = True Then
            drive = "D:"
        ElseIf cbE.Checked = True Then
            drive = "E:"
        ElseIf cbF.Checked = True Then
            drive = "F:"
        ElseIf cbG.Checked = True Then
            drive = "G:"
        End If
        ds1.Tables(0).Rows(0).Item(2) = drive
        ds1.WriteXml(CurDir() + "\xml\filesmusic.xml")

    End Sub


    Private Sub cbC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbC.Click

        cbC.Checked = True

        cbD.Checked = False
        cbE.Checked = False
        cbF.Checked = False
        cbG.Checked = False

    End Sub

    Private Sub cbD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbD.Click
        cbC.Checked = False
        cbD.Checked = True
        cbE.Checked = False
        cbF.Checked = False
        cbG.Checked = False
    End Sub

    Private Sub cbE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbE.Click
        cbC.Checked = False
        cbD.Checked = False
        cbE.Checked = True
        cbF.Checked = False
        cbG.Checked = False
    End Sub

    Private Sub cbF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbF.Click
        cbC.Checked = False
        cbD.Checked = False
        cbE.Checked = False
        cbF.Checked = True
        cbG.Checked = False
    End Sub

    Private Sub cbG_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbG.Click
        cbC.Checked = False
        cbD.Checked = False
        cbE.Checked = False
        cbF.Checked = False
        cbG.Checked = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim str, dirname, filname, songname As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String


        dirname = tb2.Text
        filname = dirname + "\" + cb3.Text
        filname = ChangeDrive(filname)


        If SMPath = "/SMPlayer" Then
            dirname = CurDir() + SMPath + "\SMPlayer.exe "
        Else
            dirname = SMPath + "\SMPlayer.exe "
        End If
        'dirname = CurDir() + "\SMPlayer\smplayer.exe "
        str = dirname + filname

        'Dim myprocess As System.Diagnostics.Process = New System.Diagnostics.Process()
        'myprocess.StartInfo.RedirectStandardOutput = True
        'myprocess.StartInfo.UseShellExecute = False
        'myprocess.Start(CurDir() + "\SMPlayer\smplayer.exe ", filname)

        ''myprocess.Start("wmplayer.exe", filname + "\" + cb3.Text + ".mp3")
        'myprocess.Start("wmplayer.exe", filname + "\" + cb3.Text + ".mp3")
        'myprocess.Start("vlc.exe", filname)

        Try
            returnid = Shell(str, vbNormalFocus)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub tb2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb2.TextChanged

        If tb2.Text = "" Then

            ds1.Tables(0).Rows(0).Item(0) = CurDir() + "\Clips"
            ds1.Tables(0).Rows(0).Item(1) = CurDir() + "\Clips"
            ds1.WriteXml(CurDir() + "\xml\filesmusic.xml")

        End If


    End Sub

    Private Sub cbF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbF.CheckedChanged

    End Sub
End Class