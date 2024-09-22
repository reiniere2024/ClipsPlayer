Public Class FilesManipulator
    Private ds As DataSet

    Private s_avi As String
    Private s_mpg As String
    Private s_wmv As String

    Private Sub cb_enc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_enc.Click
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

    Private Sub listfiles(ByVal pattern As String)
        'Dim pattern As String = "*.*"
        Dim dir_info As New System.IO.DirectoryInfo(tb1.Text)

        'list files in listbox
        Dim fs_infos() As System.IO.FileInfo = dir_info.GetFiles(pattern)
        For Each fs_info As System.IO.FileInfo In fs_infos
            'lbFiles.Items.Add(fs_info.FullName)
            lbFiles.Items.Add(fs_info.Name)
        Next fs_info
        fs_infos = Nothing

    End Sub
    Private Function ConvertIndex(ByVal thedivisor As Integer, ByVal theindex As Integer) As String
        Dim thestring As String

        If thedivisor = 1000 Then
            If theindex < 10 Then
                thestring = "000" + theindex.ToString
            ElseIf theindex < 100 Then
                thestring = "00" + theindex.ToString
            ElseIf theindex < 1000 Then
                thestring = "0" + theindex.ToString
            Else
                thestring = theindex.ToString
            End If
        ElseIf thedivisor = 100 Then
            If theindex < 10 Then
                thestring = "00" + theindex.ToString
            ElseIf theindex < 100 Then
                thestring = "0" + theindex.ToString
            Else
                thestring = theindex.ToString
            End If
        ElseIf thedivisor = 10 Then
            If theindex < 10 Then
                thestring = "0" + theindex.ToString
            Else
                thestring = theindex.ToString
            End If

        End If
        Return thestring

    End Function
    Private Sub renamefiles(ByVal pattern As String)
        Dim index, divisor As Integer
        Dim fn1, fn2, fn_s, ext, fname As String
        Dim dir_info As New System.IO.DirectoryInfo(tb1.Text)
        Dim fso
        fso = CreateObject("Scripting.FileSystemObject")

        index = 1
        'list files in listbox
        If cbxNewName.Checked = True Then
            If cbxFolder.Checked = False Then
                If t_avifile.Text = "" Then
                    MsgBox("Specify file-name or check use Folder-name !")
                    Return
                End If
                fname = t_avifile.Text
            Else
                fname = t_foldername.Text
            End If
            If cbx1000.Checked = True Then
                divisor = 1000
            ElseIf cbx100.Checked = True Then
                divisor = 100
            ElseIf cbx10.Checked = True Then
                divisor = 10
            Else
                divisor = 1000
            End If
        End If
        Dim fs_infos() As System.IO.FileInfo = dir_info.GetFiles(pattern)
        For Each fs_info As System.IO.FileInfo In fs_infos
            fn1 = fs_info.FullName
            fn_s = Mid(fs_info.Name, 1, Len(fs_info.Name) - 3)
            ext = Mid(fn1, Len(fn1) - 2, 3).ToLower()
            If cbxNewName.Checked = True Then
                If ext = "ivx" Then
                    fn_s = fname + Me.ConvertIndex(divisor, index) + ".d"
                Else
                    fn_s = fname + Me.ConvertIndex(divisor, index) + "."
                End If
            End If
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
                Case "ivx"
                    fn2 = tb2.Text + "\" + fn_s + t_divx.Text
                    fso.MoveFile(fn1, fn2)
            End Select
            index = index + 1
        Next fs_info
        fs_infos = Nothing

    End Sub

    Private Sub renamefiles2(ByVal pattern As String)

        Dim fn1, fn2, fn_s, ext As String
        Dim dir_info As New System.IO.DirectoryInfo(tb1.Text)
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
                Case "dix"
                    fn2 = tb2.Text + "\" + fn_s + "divx"
                    fso.MoveFile(fn1, fn2)

            End Select
        Next fs_info
        fs_infos = Nothing

    End Sub



    Private Sub FilesManipulator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myfolder As String

        Me.ds = New DataSet
        ds.ReadXml(CurDir() + "\files.xml")

        tb1.Text = ds.Tables(0).Rows(0).Item(0)
        tb2.Text = ds.Tables(0).Rows(0).Item(1)
        s_avi = t_avi.Text
        s_mpg = t_mpg.Text
        s_wmv = t_wmv.Text

        myfolder = tb1.Text

        ' get the directory representing this node  
        Dim mDirectory As IO.DirectoryInfo
        mDirectory = New IO.DirectoryInfo(myfolder)
        If mDirectory.Exists() Then
            Me.listfiles("*.*")
        Else
            Return
        End If


    End Sub

    Private Sub cb_dec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_dec.Click
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

    Private Sub t_avi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_avi.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String

        FBD1.SelectedPath = tb1.Text

        If FBD1.ShowDialog() = 1 Then
            tb1.Text = FBD1.SelectedPath
            tb2.Text = FBD1.SelectedPath
            lbFiles.Items.Clear()
            Me.listfiles("*.*")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        ds.Tables(0).Rows(0).Item(0) = tb1.Text
        ds.Tables(0).Rows(0).Item(1) = tb2.Text
        ds.WriteXml(CurDir() + "\files.xml")

    End Sub

    Private Sub cbxFolder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFolder.CheckedChanged

    End Sub

    Private Sub cbxFolder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxFolder.Click

        If cbxFolder.Checked = True Then
            Dim dir_info As New System.IO.DirectoryInfo(tb1.Text)
            t_foldername.Text = dir_info.Name

        End If
    End Sub



    Private Sub cbx100_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx100.Click
        If cbx100.Checked = True Then
            cbx1000.Checked = False
            cbx10.Checked = False
        End If
    End Sub

    Private Sub cbx10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx10.Click

        If cbx10.Checked = True Then
            cbx1000.Checked = False
            cbx100.Checked = False
        End If

    End Sub

    Private Sub cbx1000_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx1000.Click
        If cbx1000.Checked = True Then
            cbx100.Checked = False
            cbx10.Checked = False
        End If

    End Sub
End Class
