Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim VersionStrings As String() = Application.ProductVersion.ToString.Split(".")
            LblVersion.Text = "Version: " & VersionStrings(0) & "." & VersionStrings(1) & "." & VersionStrings(2)
        Catch ex As Exception

        End Try
    End Sub
End Class