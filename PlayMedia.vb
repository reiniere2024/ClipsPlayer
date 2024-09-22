Public Class PlayMedia
    Private myprocess As System.Diagnostics.Process = New System.Diagnostics.Process()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim returnid As Integer

        returnid = Shell("mplay32 /play c:\temp\highway.avi", vbNormalFocus)
        'returnid = Shell("mplay32 /play c:\temp\band.mp3", vbMinimizedFocus)

        'returnid = Shell("c:\Program Files\Windows Media Player\wmplayer.exe c:\temp\band.mp3", vbHide)
        'returnid = Shell("c:\Program Files\Windows Media Player\wmplayer.exe c:\temp\band.mp3", vbMinimizedFocus)
        'returnid = Shell("c:\Program Files\Windows Media Player\wmplayer.exe c:\temp\band.mp3", vbMaximizedFocus)
        'returnid = Shell("c:\Program Files\Windows Media Player\wmplayer.exe c:\temp\band.mp3", vbNormalNoFocus)
        'returnid = Shell("c:\Program Files\Windows Media Player\wmplayer.exe c:\temp\band.mp3", vbMinimizedNoFocus)




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'System.Diagnostics.Process.Start("mplay32.exe", "c:\temp\highway.avi")
        'System.Diagnostics.Process.Start("mplay32.exe", "c:\temp\band.mp3")

        Dim myprocess As System.Diagnostics.Process = New System.Diagnostics.Process()
        'myprocess.StartInfo.FileName = "mplay32.exe"
        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.StartInfo.UseShellExecute = False
        myprocess.StartInfo.Arguments = "/open /play"
        myprocess.Start("mplay32.exe", "c:\temp\band.mp3")

        ' c:\temp\highway.avi

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim returnid As Integer
        Dim start As String
        Dim d_quote As String = Chr(34)

        'returnid = Shell("c:\Program Files\Windows Media Player\wmplayer.exe c:\temp\highway.avi", vbNormalFocus)
        'returnid = Shell("c:\Program Files\Windows Media Player\wmplayer.exe c:\temp\band.mp3", vbNormalFocus)
        'returnid = Shell("c:\Program Files\Windows Media Player\wmplayer.exe c:\temp\band.mp3", vbHide)
        'returnid = Shell("c:\Program Files\Windows Media Player\wmplayer.exe c:\temp\band.mp3", vbMinimizedFocus)
        'returnid = Shell("c:\Program Files\Windows Media Player\wmplayer.exe c:\temp\band.mp3", vbMaximizedFocus)
        'returnid = Shell("c:\Program Files\Windows Media Player\wmplayer.exe c:\temp\band.mp3", vbNormalNoFocus)
        returnid = Shell("c:\Program Files\Windows Media Player\wmplayer.exe c:\temp\band.mp3", vbMinimizedNoFocus)


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.StartInfo.UseShellExecute = False

        myprocess.Start("wmplayer.exe", "c:\temp\band.mp3")

        'myprocess.Start("wmplayer.exe", "c:\temp\highway.avi")


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click



    End Sub
End Class