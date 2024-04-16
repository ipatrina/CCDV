Public Class Options
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TxtPath.Text = MainUI.FswEvents.Path
            ChkStartMAtInit.Checked = CreateObject("WScript.Shell").RegRead("HKCU\Software\CCDV\MonitorAutoStart")
            ChkHideToTrayAtInit.Checked = CreateObject("WScript.Shell").RegRead("HKCU\Software\CCDV\FormAutoHide")
            ChkHideToTrayAtClose.Checked = CreateObject("WScript.Shell").RegRead("HKCU\Software\CCDV\HideWhenClose")
        Catch ex As Exception

        End Try

        Try
            If Not CreateObject("WScript.Shell").RegRead("HKCU\Software\Microsoft\Windows\CurrentVersion\Run\CCDV") = "" Then
                ChkRunAutoAtStartup.Checked = True
            End If
            If CreateObject("WScript.Shell").RegRead("HKCU\Software\Microsoft\Windows\CurrentVersion\Run\CCDV").EndsWith("-h") Then
                ChkHideToTrayAtStartup.Checked = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            MainUI.FswEvents.Path = TxtPath.Text
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\CCDV\MonitoredPath", TxtPath.Text, "REG_SZ")
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\CCDV\MonitorAutoStart", ChkStartMAtInit.Checked, "REG_SZ")
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\CCDV\FormAutoHide", ChkHideToTrayAtInit.Checked, "REG_SZ")
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\CCDV\HideWhenClose", ChkHideToTrayAtClose.Checked, "REG_SZ")

            Dim HideAtStartup As String = ""
            If ChkHideToTrayAtStartup.Checked Then HideAtStartup = " -h"
            If ChkRunAutoAtStartup.Checked Then
                CreateObject("WScript.Shell").RegWrite("HKCU\Software\Microsoft\Windows\CurrentVersion\Run\CCDV", Chr(34) & Application.ExecutablePath & Chr(34) & HideAtStartup, "REG_SZ")
            Else
                CreateObject("WScript.Shell").RegDelete("HKCU\Software\Microsoft\Windows\CurrentVersion\Run\CCDV")
            End If
        Catch ex As Exception

        Finally
            Dispose()
        End Try
    End Sub

    Private Sub BtnPathBrowse_Click(sender As Object, e As EventArgs) Handles BtnPathBrowse.Click
        Try
            FbdPath.SelectedPath = TxtPath.Text
            FbdPath.ShowDialog()
            If FbdPath.SelectedPath = "" Then Exit Sub
            TxtPath.Text = FbdPath.SelectedPath
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ChkRunAutoAtStartup_CheckedChanged(sender As Object, e As EventArgs) Handles ChkRunAutoAtStartup.CheckedChanged
        Try
            If ChkRunAutoAtStartup.Checked Then
                ChkHideToTrayAtStartup.Enabled = True
            Else
                ChkHideToTrayAtStartup.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class