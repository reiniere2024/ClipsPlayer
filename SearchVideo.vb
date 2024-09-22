Imports System.Data.SqlClient

Public Class SearchVideo

    Private s_drive As String

    Private Sub CurDrive()
        Dim ds1 As DataSet
        Dim drive As String

        ds1 = New DataSet
        ds1.ReadXml(CurDir() + "\files.xml")
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, dirid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String
        Dim ds As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet
        Dim artist As String

        'load movies
        cb3.Items.Clear()
        cb3.Text = ""
        ds = New DataSet
        ds.ReadXml(CurDir() + "\server.xml")
        srv = ds.Tables(0).Rows(0).Item(1)
        user = ds.Tables(0).Rows(0).Item(2)
        pwd = ds.Tables(0).Rows(0).Item(3)
        db = ds.Tables(0).Rows(0).Item(4)
        mystring = "Data source=" + srv + ";user id=" + user + ";password=" + pwd + ";initial catalog=" + db + ";"
        Dim myconnection1 As New SqlConnection(mystring)
        myconnection1.Open()

        artist = TextBox6.Text
        'get videos
        mysql = "select movie_name from movie where artists like '%" + artist + "%' or artists2 like '%" + artist + "%' order by movie_name"
        datemp.SelectCommand = New SqlCommand(mysql, myconnection1)
        datemp.Fill(dstemp, "movie")
        For i = 0 To dstemp.Tables(0).Rows.Count - 1
            s1 = dstemp.Tables(0).Rows(i).Item(0)
            cb3.Items.Add(s1)
        Next
        myconnection1.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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

        'get filename + extension
        filname1 = Me.GetFileName(myconnection1, cb3.Text)

        'Test Existence
        If Not System.IO.File.Exists(filname1) Then
            ext = Mid(filname1, Len(filname1) - 2, 3)
            Select Case ext
                Case "avi"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_avi.Text
                Case "mpg"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_mpg.Text
                Case "wmv"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_wmv.Text
            End Select
            If System.IO.File.Exists(filname2) Then
                Dim fso
                fso = CreateObject("Scripting.FileSystemObject")
                fso.MoveFile(filname2, filname1)
            End If
        End If

        filname1 = ChangeDrive(filname1)
        If Not System.IO.File.Exists(filname1) Then
            MsgBox("file not exists")
            Return
        End If
        str = "mplay32 /play " + filname1
        If ckb1.Checked = True Then
            returnid = Shell(str, vbNormalFocus)
        Else
            returnid = Shell(str, vbMaximizedFocus)
        End If

    End Sub

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

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
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

        'filname = Me.GetFileName(myconnection1, cb2.Text) + ".avi"
        filname1 = Me.GetFileName(myconnection1, cb3.Text)
        'Test Existence
        If Not System.IO.File.Exists(filname1) Then
            ext = Mid(filname1, Len(filname1) - 2, 3)
            Select Case ext
                Case "avi"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_avi.Text
                Case "mpg"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_mpg.Text
                Case "wmv"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_wmv.Text
            End Select
            If System.IO.File.Exists(filname2) Then
                Dim fso
                fso = CreateObject("Scripting.FileSystemObject")
                fso.MoveFile(filname2, filname1)
            End If
        End If

        filname1 = ChangeDrive(filname1)
        If Not System.IO.File.Exists(filname1) Then
            MsgBox("file not exists")
            Return
        End If
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

        ds = New DataSet
        ds.ReadXml(CurDir() + "\server.xml")
        srv = ds.Tables(0).Rows(0).Item(1)
        user = ds.Tables(0).Rows(0).Item(2)
        pwd = ds.Tables(0).Rows(0).Item(3)
        db = ds.Tables(0).Rows(0).Item(4)
        mystring = "Data source=" + srv + ";user id=" + user + ";password=" + pwd + ";initial catalog=" + db + ";"
        Dim myconnection1 As New SqlConnection(mystring)
        myconnection1.Open()

        filname1 = Me.GetFileName(myconnection1, cb3.Text)
        'Test Existence
        If Not System.IO.File.Exists(filname1) Then
            ext = Mid(filname1, Len(filname1) - 2, 3)
            Select Case ext
                Case "avi"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_avi.Text
                Case "mpg"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_mpg.Text
                Case "wmv"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_wmv.Text
            End Select
            If System.IO.File.Exists(filname2) Then
                Dim fso
                fso = CreateObject("Scripting.FileSystemObject")
                fso.MoveFile(filname2, filname1)
            End If
        End If

        Dim myprocess As System.Diagnostics.Process = New System.Diagnostics.Process()
        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.StartInfo.UseShellExecute = False

        filname1 = ChangeDrive(filname1)
        If Not System.IO.File.Exists(filname1) Then
            MsgBox("file not exists")
            Return
        End If
        If ckb1.Checked = True Then
            myprocess.Start("wmplayer.exe", filname1)
        Else
            myprocess.Start("wmplayer.exe", filname1)
        End If

    End Sub

    Private Sub cb3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb3.SelectedIndexChanged
        Dim str, er, hc, qu As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1 As String
        Dim ds As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ds = New DataSet
        ds.ReadXml(CurDir() + "\server.xml")
        srv = ds.Tables(0).Rows(0).Item(1)
        user = ds.Tables(0).Rows(0).Item(2)
        pwd = ds.Tables(0).Rows(0).Item(3)
        db = ds.Tables(0).Rows(0).Item(4)
        mystring = "Data source=" + srv + ";user id=" + user + ";password=" + pwd + ";initial catalog=" + db + ";"
        Dim myconnection1 As New SqlConnection(mystring)
        myconnection1.Open()

        er = Me.GetER(myconnection1, cb3.Text)
        TextBox1.Text = er
        hc = Me.GetHC(myconnection1, cb3.Text)
        TextBox2.Text = hc
        qu = Me.GetQU(myconnection1, cb3.Text)
        TextBox3.Text = qu
        myconnection1.Close()

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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
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

        filname1 = Me.GetPicName(myconnection1, cb3.Text)

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


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim str, filname1, filname2, ext As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1, progname As String
        Dim ds As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet

        Dim dsP As DataSet

        dsP = New DataSet
        dsP.ReadXml(CurDir() + "\program.xml")
        progname = dsP.Tables(0).Rows(0).Item(0)

        ds = New DataSet
        ds.ReadXml(CurDir() + "\server.xml")
        srv = ds.Tables(0).Rows(0).Item(1)
        user = ds.Tables(0).Rows(0).Item(2)
        pwd = ds.Tables(0).Rows(0).Item(3)
        db = ds.Tables(0).Rows(0).Item(4)
        mystring = "Data source=" + srv + ";user id=" + user + ";password=" + pwd + ";initial catalog=" + db + ";"
        Dim myconnection1 As New SqlConnection(mystring)
        myconnection1.Open()

        'filname = Me.GetFileName(myconnection1, cb2.Text) + ".avi"
        filname1 = Me.GetFileName(myconnection1, cb3.Text)
        'Test Existence
        If Not System.IO.File.Exists(filname1) Then
            ext = Mid(filname1, Len(filname1) - 2, 3)
            Select Case ext
                Case "avi"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_avi.Text
                Case "mpg"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_mpg.Text
                Case "wmv"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_wmv.Text
            End Select
            If System.IO.File.Exists(filname2) Then
                Dim fso
                fso = CreateObject("Scripting.FileSystemObject")
                fso.MoveFile(filname2, filname1)
            End If
        End If

        'test
        'str = "C:\Tools\DivX\DivX Player\DivX Player.exe " + filname1
        'str = "C:\Program Files\DivX\DivX Player\DivX Player.exe " + filname1
        filname1 = ChangeDrive(filname1)
        If Not System.IO.File.Exists(filname1) Then
            MsgBox("file not exists")
            Return
        End If
        str = progname + " " + filname1

        If ckb1.Checked = True Then
            returnid = Shell(str, vbNormalFocus)
        Else
            returnid = Shell(str, vbMaximizedFocus)
        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim str, filname1, filname2, ext As String
        Dim i, dirid, returnid As Integer
        Dim srv, user, pwd, db, mystring, mysql, s1, progname As String
        Dim ds As DataSet
        Dim datemp As New SqlDataAdapter
        Dim dstemp As New DataSet

        Dim dsP As DataSet

        dsP = New DataSet
        dsP.ReadXml(CurDir() + "\program.xml")
        progname = dsP.Tables(0).Rows(0).Item(0)

        ds = New DataSet
        ds.ReadXml(CurDir() + "\server.xml")
        srv = ds.Tables(0).Rows(0).Item(1)
        user = ds.Tables(0).Rows(0).Item(2)
        pwd = ds.Tables(0).Rows(0).Item(3)
        db = ds.Tables(0).Rows(0).Item(4)
        mystring = "Data source=" + srv + ";user id=" + user + ";password=" + pwd + ";initial catalog=" + db + ";"
        Dim myconnection1 As New SqlConnection(mystring)
        myconnection1.Open()

        filname1 = Me.GetFileName(myconnection1, cb3.Text)
        'Test Existence
        If Not System.IO.File.Exists(filname1) Then
            ext = Mid(filname1, Len(filname1) - 2, 3)
            Select Case ext
                Case "avi"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_avi.Text
                Case "mpg"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_mpg.Text
                Case "wmv"
                    filname2 = Mid(filname1, 1, Len(filname1) - 3) + t_wmv.Text
            End Select
            If System.IO.File.Exists(filname2) Then
                Dim fso
                fso = CreateObject("Scripting.FileSystemObject")
                fso.MoveFile(filname2, filname1)
            End If
        End If

        Dim myprocess As System.Diagnostics.Process = New System.Diagnostics.Process()
        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.StartInfo.UseShellExecute = False

        filname1 = ChangeDrive(filname1)
        If Not System.IO.File.Exists(filname1) Then
            MsgBox("file not exists")
            Return
        End If
        If ckb1.Checked = True Then
            'test
            'myprocess.Start("C:\Tools\DivX\DivX Player\DivX Player.exe", filname1)
            'myprocess.Start("C:\Program Files\DivX\DivX Player\DivX Player.exe", filname1)
            myprocess.Start(progname, filname1)
        Else
            'test
            'myprocess.Start("C:\Tools\DivX\DivX Player\DivX Player.exe", filname1)
            'myprocess.Start("C:\Program Files\DivX\DivX Player\DivX Player.exe", filname1)
            myprocess.Start(progname, filname1)
        End If

    End Sub

    Private Sub SearchVideo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CurDrive()

    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.setdrive()

    End Sub

    Private Sub SetDrive()
        Dim ds1 As DataSet
        Dim curdrive, drive As String

        ds1 = New DataSet
        ds1.ReadXml(CurDir() + "\files.xml")
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
        ds1.WriteXml(CurDir() + "\files.xml")

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


End Class