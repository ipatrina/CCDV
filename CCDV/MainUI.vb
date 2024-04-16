Imports System.ComponentModel
Imports System.IO

Public Class MainUI
    Public FormHidden As Boolean = False
    Public InitDir As String = Environment.GetEnvironmentVariable("SYSTEMDRIVE") & "\"

    Private Sub MainUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FswEvents.Path = InitDir
            NtiTray.ContextMenu = CtmTray
            LoadOptions()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub InitWindowStyle()
        WindowState = FormWindowState.Normal

        Try
            Width = CreateObject("WScript.Shell").RegRead("HKCU\Software\CCDV\WindowWidth")
            Height = CreateObject("WScript.Shell").RegRead("HKCU\Software\CCDV\WindowHeight")
        Catch ex As Exception

        End Try

        Try
            Left = Int((My.Computer.Screen.Bounds.Width - Width) / 2)
            Top = Int((My.Computer.Screen.Bounds.Height - Height) / 2)
        Catch ex As Exception

        End Try

        Try
            If CreateObject("WScript.Shell").RegRead("HKCU\Software\CCDV\WindowState") = "Maximized" Then
                WindowState = FormWindowState.Maximized
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadOptions()
        Try
            Dim MonitoredPath As String = CreateObject("WScript.Shell").RegRead("HKCU\Software\CCDV\MonitoredPath")
            If My.Computer.FileSystem.DirectoryExists(MonitoredPath) Then
                FswEvents.Path = MonitoredPath
            End If
        Catch ex As Exception

        End Try

        Try
            If CreateObject("WScript.Shell").RegRead("HKCU\Software\CCDV\MonitorAutoStart") = False Then
                StopMonitor()
            End If
        Catch ex As Exception

        End Try

        Try
            If CreateObject("WScript.Shell").RegRead("HKCU\Software\CCDV\SubdirectorySurveillance") = False Then
                DisableSubdir()
            End If
        Catch ex As Exception

        End Try

        Dim FormAutoHide As Boolean = False
        Try
            FormAutoHide = CreateObject("WScript.Shell").RegRead("HKCU\Software\CCDV\FormAutoHide")
        Catch ex As Exception

        Finally
            If FormAutoHide = True Or Command().Trim = "-h" Then
                HideForm()
            Else
                InitWindowStyle()
            End If
        End Try

        Try
            LsvEvents.Columns.Item(0).Width = CreateObject("WScript.Shell").RegRead("HKCU\Software\CCDV\EventColumnLength")
            LsvEvents.Columns.Item(1).Width = CreateObject("WScript.Shell").RegRead("HKCU\Software\CCDV\MomentColumnLength")
            LsvEvents.Columns.Item(2).Width = CreateObject("WScript.Shell").RegRead("HKCU\Software\CCDV\LocationColumnLength")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddEvent(Activity As String, Location As String)
        Try
            Dim i As Integer = LsvEvents.Items.Count
            If i < 1 Then GoTo add
            If LsvEvents.Items(i - 1).SubItems(0).Text = Activity And LsvEvents.Items(i - 1).SubItems(2).Text = Location Then Exit Sub

add:        LsvEvents.Items.Add(Activity)
            LsvEvents.Items(i).SubItems.Add(Now)
            LsvEvents.Items(i).SubItems.Add(Location)
            If LsvEvents.SelectedItems.Count <= 0 Then
                LsvEvents.Items(LsvEvents.Items.Count - 1).EnsureVisible()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FswEvents_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles FswEvents.Changed
        Try
            AddEvent("CHANGE", e.FullPath)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FswEvents_Created(sender As Object, e As FileSystemEventArgs) Handles FswEvents.Created
        Try
            AddEvent("CREATE", e.FullPath)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FswEvents_Deleted(sender As Object, e As FileSystemEventArgs) Handles FswEvents.Deleted
        Try
            AddEvent("DELETE", e.FullPath)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FswEvents_Renamed(sender As Object, e As RenamedEventArgs) Handles FswEvents.Renamed
        Try
            AddEvent("RENAME", e.FullPath & " <-- " & IO.Path.GetFileName(e.OldFullPath))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TsmStartMonitor_Click(sender As Object, e As EventArgs) Handles TsmStartMonitor.Click
        StartMonitor()
    End Sub

    Private Sub TsmStopMonitor_Click(sender As Object, e As EventArgs) Handles TsmStopMonitor.Click
        StopMonitor()
    End Sub

    Private Sub TsmEnableSubdir_Click(sender As Object, e As EventArgs) Handles TsmEnableSubdir.Click
        EnableSubdir()
    End Sub

    Private Sub TsmDisableSubdir_Click(sender As Object, e As EventArgs) Handles TsmDisableSubdir.Click
        DisableSubdir()
    End Sub

    Private Sub StartMonitor()
        Try
            FswEvents.EnableRaisingEvents = True
            TsmStartMonitor.Enabled = False
            TsmStopMonitor.Enabled = True
            MniStopStart.Text = TsmStopMonitor.Text.Split("(")(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StopMonitor()
        Try
            FswEvents.EnableRaisingEvents = False
            TsmStartMonitor.Enabled = True
            TsmStopMonitor.Enabled = False
            MniStopStart.Text = TsmStartMonitor.Text.Split("(")(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EnableSubdir()
        Try
            FswEvents.IncludeSubdirectories = True
            TsmEnableSubdir.Enabled = False
            TsmDisableSubdir.Enabled = True
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\CCDV\SubdirectorySurveillance", "True", "REG_SZ")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DisableSubdir()
        Try
            FswEvents.IncludeSubdirectories = False
            TsmEnableSubdir.Enabled = True
            TsmDisableSubdir.Enabled = False
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\CCDV\SubdirectorySurveillance", "False", "REG_SZ")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TsmQuit_Click(sender As Object, e As EventArgs) Handles TsmQuit.Click
        Quit()
    End Sub

    Private Sub TsmClearEvents_Click(sender As Object, e As EventArgs) Handles TsmClearEvents.Click
        Try
            LsvEvents.Items.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HideForm()
        Try
            If FormHidden Then
                Show()
                FormHidden = False
                MniHideShow.Text = "Hide"
                InitWindowStyle()
            Else
                SaveWindowStyle()
                Hide()
                FormHidden = True
                MniHideShow.Text = "Show"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Quit()
        Try
            SaveWindowStyle()
        Catch ex As Exception

        Finally
            NtiTray.Visible = False
            Dispose()
            End
        End Try
    End Sub

    Private Sub SaveWindowStyle()
        Try
            If WindowState = FormWindowState.Maximized Then
                CreateObject("WScript.Shell").RegWrite("HKCU\Software\CCDV\WindowState", "Maximized", "REG_SZ")
            Else
                CreateObject("WScript.Shell").RegWrite("HKCU\Software\CCDV\WindowState", "Normal", "REG_SZ")
                CreateObject("WScript.Shell").RegWrite("HKCU\Software\CCDV\WindowWidth", "" & Width & "", "REG_SZ")
                CreateObject("WScript.Shell").RegWrite("HKCU\Software\CCDV\WindowHeight", "" & Height & "", "REG_SZ")
            End If

            CreateObject("WScript.Shell").RegWrite("HKCU\Software\CCDV\EventColumnLength", "" & LsvEvents.Columns.Item(0).Width & "", "REG_SZ")
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\CCDV\MomentColumnLength", "" & LsvEvents.Columns.Item(1).Width & "", "REG_SZ")
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\CCDV\LocationColumnLength", "" & LsvEvents.Columns.Item(2).Width & "", "REG_SZ")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TsmSaveEvents_Click(sender As Object, e As EventArgs) Handles TsmSaveEvents.Click
        Try
            SfdEvents.Filter = "Text document|*.txt|All files|*.*"
            SfdEvents.InitialDirectory = InitDir
            SfdEvents.FileName = "Events"
            If SfdEvents.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim SWriter As System.IO.StreamWriter = New System.IO.StreamWriter(SfdEvents.FileName, False, System.Text.Encoding.UTF8)
                For i = 0 To LsvEvents.Items.Count - 1
                    SWriter.WriteLine("[" & LsvEvents.Items(i).SubItems(1).Text & "] " & LsvEvents.Items(i).SubItems(0).Text & " " & LsvEvents.Items(i).SubItems(2).Text)
                Next
                SWriter.Close()
                SWriter.Dispose()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TsmHide_Click(sender As Object, e As EventArgs) Handles TsmHide.Click
        HideForm()
    End Sub

    Private Sub MniHideShow_Click(sender As Object, e As EventArgs) Handles MniHideShow.Click
        HideForm()
    End Sub

    Private Sub MniQuit_Click(sender As Object, e As EventArgs) Handles MniQuit.Click
        Quit()
    End Sub

    Private Sub MniStopStart_Click(sender As Object, e As EventArgs) Handles MniStopStart.Click
        Try
            If FswEvents.EnableRaisingEvents = True Then
                StopMonitor()
            Else
                StartMonitor()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MainUI_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            e.Cancel = True
            If CreateObject("WScript.Shell").RegRead("HKCU\Software\CCDV\HideWhenClose") = True Then
                HideForm()
            Else
                Quit()
            End If
        Catch ex As Exception
            Quit()
        End Try
    End Sub

    Private Sub NtiTray_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NtiTray.MouseDoubleClick
        Try
            HideForm()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LsvEvents_MouseDown(sender As Object, e As MouseEventArgs) Handles LsvEvents.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Clipboard.SetText(System.IO.Path.GetDirectoryName(LsvEvents.FocusedItem.SubItems(2).Text.Split("<")(0)))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LsvEvents_DoubleClick(sender As Object, e As EventArgs) Handles LsvEvents.DoubleClick
        Try
            Clipboard.SetText(LsvEvents.FocusedItem.SubItems(2).Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TsmAbout.Click
        Try
            About.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TsmAutoscroll_Click(sender As Object, e As EventArgs) Handles TsmAutoscroll.Click
        Try
            LsvEvents.SelectedItems.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TsmOptions_Click(sender As Object, e As EventArgs) Handles TsmOptions.Click
        Try
            Options.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MniOptions_Click(sender As Object, e As EventArgs) Handles MniOptions.Click
        Try
            If FormHidden = True Then
                HideForm()
            End If
            Options.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class
