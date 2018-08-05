Public Class Form1
    Dim status As Integer
    Dim temp As String = IO.Path.Combine(System.IO.Path.GetTempPath(), "toolkit")
    Dim file As String = IO.Path.Combine(IO.Path.GetTempPath, "status.txt")
    Dim dm As New ProcessStartInfo("bat\tes.bat")
    Dim conduit As New ProcessStartInfo("bat\conduit.bat")
    Dim filet = IO.Path.Combine(temp, "file.txt")
    Dim filo = IO.Path.Combine(temp, "operation.txt")
    Dim operation As String

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        System.IO.File.Delete(file)
        Try
            IO.Directory.Delete(temp)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub sendfilebtn_Click(sender As Object, e As EventArgs) Handles sendfilebtn.Click
        BunifuFlatButton6_Click(sender, e)
        open.Title = "Choose file"
            open.FileName = ""
            open.Filter = "All files (*.*) | *.*"
        open.ShowDialog()
        conduit.UseShellExecute = False
        conduit.WindowStyle = ProcessWindowStyle.Minimized
        Dim process As Process = Process.Start(conduit)
        process.WaitForExit()
        Form2.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IO.Directory.CreateDirectory(temp)
        dm.RedirectStandardError = True
        dm.RedirectStandardOutput = True
        dm.CreateNoWindow = True
        dm.UseShellExecute = False
        dm.WindowStyle = ProcessWindowStyle.Hidden

        Dim process As Process = Process.Start(dm)
        Threading.Thread.Sleep(500)
        If System.IO.File.Exists(file) Then
            status = My.Computer.FileSystem.ReadAllText(file)
            If (status <> 0) Then
                Label1.Text = "Device Detected"
                Label1.BackColor = System.Drawing.Color.DarkCyan
                BunifuImageButton2.Show()
                BunifuImageButton3.Hide()
            Else
                Label1.Text = "Device Not Detected"
                Label1.BackColor = System.Drawing.Color.Red
                BunifuImageButton3.Show()
                BunifuImageButton2.Hide()
                apkbtn.Enabled = False
                sendfilebtn.Enabled = False
                recoverybtn.Enabled = False
                bootloaderbtn.Enabled = False
                rebootbtn.Enabled = False
                Screenie.Enabled = False
                en_hu.Enabled = False
                dis_hu.Enabled = False
            End If
        Else
            Label1.Text = "Device Not Detected"
            Label1.BackColor = System.Drawing.Color.Red
            BunifuImageButton3.Show()
            BunifuImageButton2.Hide()
            apkbtn.Enabled = False
            sendfilebtn.Enabled = False
            recoverybtn.Enabled = False
            bootloaderbtn.Enabled = False
            rebootbtn.Enabled = False
            Screenie.Enabled = False
            en_hu.Enabled = False
            dis_hu.Enabled = False
        End If
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click

        If System.IO.File.Exists(file) Then
            System.IO.File.Delete(file)
        End If
        System.IO.File.Create(file).Dispose()
        Dim writer As New IO.StreamWriter(file, True)
        writer.WriteLine(0)
        writer.Close()
        dm.RedirectStandardError = True
        dm.RedirectStandardOutput = True
        dm.CreateNoWindow = True
        dm.UseShellExecute = False
        dm.WindowStyle = ProcessWindowStyle.Hidden

        Dim process As Process = Process.Start(dm)

        timer.Start()


    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        status = System.IO.File.ReadAllText(file)
        If (status <> 1) Then
            apkbtn.Enabled = False
            sendfilebtn.Enabled = False
            recoverybtn.Enabled = False
            bootloaderbtn.Enabled = False
            rebootbtn.Enabled = False
            Screenie.Enabled = False
            en_hu.Enabled = False
            dis_hu.Enabled = False
            sendfilebtn.Enabled = False
            recoverybtn.Enabled = False
            bootloaderbtn.Enabled = False
            Label1.Text = "Device Not Detected"
            Label1.BackColor = System.Drawing.Color.Red
            BunifuImageButton2.Hide()
            BunifuImageButton3.Show()
        Else
            apkbtn.Enabled = True
            sendfilebtn.Enabled = True
            recoverybtn.Enabled = True
            bootloaderbtn.Enabled = True
            rebootbtn.Enabled = True
            Screenie.Enabled = True
            en_hu.Enabled = True
            dis_hu.Enabled = True
            sendfilebtn.Enabled = True
            recoverybtn.Enabled = True
            bootloaderbtn.Enabled = True
            Label1.Text = "Device Detected"
            Label1.BackColor = System.Drawing.Color.DarkCyan
            BunifuImageButton3.Hide()
            BunifuImageButton2.Show()


        End If
    End Sub

    Private Sub recoverybtn_Click(sender As Object, e As EventArgs) Handles recoverybtn.Click
        BunifuFlatButton6_Click(sender, e)
        System.IO.File.Create(filo).Dispose()
        Dim writ As New IO.StreamWriter(filo, True)
        writ.WriteLine("recovery")
        writ.Close()
        conduit.UseShellExecute = False
        conduit.WindowStyle = ProcessWindowStyle.Minimized
        Dim process As Process = Process.Start(conduit)
        process.WaitForExit()
        Form2.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles open.FileOk
        If (open.Title = "Choose file") Then
            operation = "send"
            Dim fName As String = open.FileName
            System.IO.File.Create(filet).Dispose()
            Dim writer As New IO.StreamWriter(filet, True)
            writer.WriteLine(fName)
            writer.Close()
            System.IO.File.Create(filo).Dispose()
            Dim riter As New IO.StreamWriter(filo, True)
            riter.WriteLine(operation)
            riter.Close()
        End If

        If (open.Title = "Choose Apk") Then
            operation = "install"
            Dim fName As String = open.FileName
            IO.File.Create(filet).Dispose()
            Dim apkw As New IO.StreamWriter(filet, True)
            apkw.WriteLine(fName)
            apkw.Close()
            System.IO.File.Create(filo).Dispose()
            Dim riter As New IO.StreamWriter(filo, True)
            riter.WriteLine(operation)
            riter.Close()
        End If


    End Sub

    Private Sub apkbtn_Click(sender As Object, e As EventArgs) Handles apkbtn.Click
        BunifuFlatButton6_Click(sender, e)
        open.Title = "Choose Apk"
        open.Filter = "Apk (.apk)| *.apk"
        open.FileName = ""
        open.ShowDialog()
        conduit.UseShellExecute = False
        conduit.WindowStyle = ProcessWindowStyle.Minimized
        Dim process As Process = Process.Start(conduit)
        process.WaitForExit()
        Form2.ShowDialog()
    End Sub



    Private Sub bootloaderbtn_Click(sender As Object, e As EventArgs) Handles bootloaderbtn.Click
        BunifuFlatButton6_Click(sender, e)
        System.IO.File.Create(filo).Dispose()
        Dim writ As New IO.StreamWriter(filo, True)
        writ.WriteLine("reb_btldr")
        writ.Close()
        conduit.UseShellExecute = False
        conduit.WindowStyle = ProcessWindowStyle.Minimized
        Dim process As Process = Process.Start(conduit)
        process.WaitForExit()
        Form2.ShowDialog()
    End Sub

    Private Sub rebootbtn_Click(sender As Object, e As EventArgs) Handles rebootbtn.Click
        BunifuFlatButton6_Click(sender, e)
        System.IO.File.Create(filo).Dispose()
        Dim writ As New IO.StreamWriter(filo, True)
        writ.WriteLine("reboot")
        writ.Close()
        conduit.UseShellExecute = False
        conduit.WindowStyle = ProcessWindowStyle.Minimized
        Dim process As Process = Process.Start(conduit)
        process.WaitForExit()
        Form2.ShowDialog()
    End Sub

    Private Sub Screenie_Click(sender As Object, e As EventArgs) Handles Screenie.Click
        BunifuFlatButton6_Click(sender, e)
        System.IO.File.Create(filo).Dispose()
        Dim writ As New IO.StreamWriter(filo, True)
        writ.WriteLine("screencap")
        writ.Close()
        conduit.UseShellExecute = False
        conduit.WindowStyle = ProcessWindowStyle.Minimized
        Dim process As Process = Process.Start(conduit)
        process.WaitForExit()
        Form2.ShowDialog()
    End Sub
End Class
