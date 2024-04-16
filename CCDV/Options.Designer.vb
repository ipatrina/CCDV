<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.LblStartup = New System.Windows.Forms.Label()
        Me.ChkHideToTrayAtClose = New System.Windows.Forms.CheckBox()
        Me.ChkHideToTrayAtInit = New System.Windows.Forms.CheckBox()
        Me.ChkStartMAtInit = New System.Windows.Forms.CheckBox()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.LblBasic = New System.Windows.Forms.Label()
        Me.LblPath = New System.Windows.Forms.Label()
        Me.ChkHideToTrayAtStartup = New System.Windows.Forms.CheckBox()
        Me.ChkRunAutoAtStartup = New System.Windows.Forms.CheckBox()
        Me.BtnPathBrowse = New System.Windows.Forms.Button()
        Me.FbdPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(10, 309)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(365, 38)
        Me.BtnSave.TabIndex = 101
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'LblStartup
        '
        Me.LblStartup.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblStartup.Location = New System.Drawing.Point(12, 191)
        Me.LblStartup.Name = "LblStartup"
        Me.LblStartup.Size = New System.Drawing.Size(360, 30)
        Me.LblStartup.TabIndex = 61
        Me.LblStartup.Text = "Startup"
        Me.LblStartup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkHideToTrayAtClose
        '
        Me.ChkHideToTrayAtClose.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ChkHideToTrayAtClose.Location = New System.Drawing.Point(10, 145)
        Me.ChkHideToTrayAtClose.Name = "ChkHideToTrayAtClose"
        Me.ChkHideToTrayAtClose.Size = New System.Drawing.Size(365, 30)
        Me.ChkHideToTrayAtClose.TabIndex = 51
        Me.ChkHideToTrayAtClose.Text = "Hide to tray when close"
        Me.ChkHideToTrayAtClose.UseVisualStyleBackColor = True
        '
        'ChkHideToTrayAtInit
        '
        Me.ChkHideToTrayAtInit.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ChkHideToTrayAtInit.Location = New System.Drawing.Point(10, 113)
        Me.ChkHideToTrayAtInit.Name = "ChkHideToTrayAtInit"
        Me.ChkHideToTrayAtInit.Size = New System.Drawing.Size(365, 30)
        Me.ChkHideToTrayAtInit.TabIndex = 41
        Me.ChkHideToTrayAtInit.Text = "Hide to tray at initialization"
        Me.ChkHideToTrayAtInit.UseVisualStyleBackColor = True
        '
        'ChkStartMAtInit
        '
        Me.ChkStartMAtInit.Checked = True
        Me.ChkStartMAtInit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkStartMAtInit.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ChkStartMAtInit.Location = New System.Drawing.Point(10, 81)
        Me.ChkStartMAtInit.Name = "ChkStartMAtInit"
        Me.ChkStartMAtInit.Size = New System.Drawing.Size(365, 30)
        Me.ChkStartMAtInit.TabIndex = 31
        Me.ChkStartMAtInit.Text = "Start monitoring at initialization"
        Me.ChkStartMAtInit.UseVisualStyleBackColor = True
        '
        'TxtPath
        '
        Me.TxtPath.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtPath.Location = New System.Drawing.Point(132, 50)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.ReadOnly = True
        Me.TxtPath.Size = New System.Drawing.Size(208, 26)
        Me.TxtPath.TabIndex = 23
        '
        'LblBasic
        '
        Me.LblBasic.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblBasic.Location = New System.Drawing.Point(12, 10)
        Me.LblBasic.Name = "LblBasic"
        Me.LblBasic.Size = New System.Drawing.Size(360, 30)
        Me.LblBasic.TabIndex = 11
        Me.LblBasic.Text = "Basic"
        Me.LblBasic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPath
        '
        Me.LblPath.AutoSize = True
        Me.LblPath.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblPath.Location = New System.Drawing.Point(6, 53)
        Me.LblPath.Name = "LblPath"
        Me.LblPath.Size = New System.Drawing.Size(119, 20)
        Me.LblPath.TabIndex = 21
        Me.LblPath.Text = "Monitored path:"
        '
        'ChkHideToTrayAtStartup
        '
        Me.ChkHideToTrayAtStartup.Enabled = False
        Me.ChkHideToTrayAtStartup.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ChkHideToTrayAtStartup.Location = New System.Drawing.Point(10, 258)
        Me.ChkHideToTrayAtStartup.Name = "ChkHideToTrayAtStartup"
        Me.ChkHideToTrayAtStartup.Size = New System.Drawing.Size(365, 30)
        Me.ChkHideToTrayAtStartup.TabIndex = 81
        Me.ChkHideToTrayAtStartup.Text = "Hide to tray when run at startup"
        Me.ChkHideToTrayAtStartup.UseVisualStyleBackColor = True
        '
        'ChkRunAutoAtStartup
        '
        Me.ChkRunAutoAtStartup.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ChkRunAutoAtStartup.Location = New System.Drawing.Point(10, 226)
        Me.ChkRunAutoAtStartup.Name = "ChkRunAutoAtStartup"
        Me.ChkRunAutoAtStartup.Size = New System.Drawing.Size(365, 30)
        Me.ChkRunAutoAtStartup.TabIndex = 71
        Me.ChkRunAutoAtStartup.Text = "Run automatically at startup"
        Me.ChkRunAutoAtStartup.UseVisualStyleBackColor = True
        '
        'BtnPathBrowse
        '
        Me.BtnPathBrowse.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPathBrowse.Location = New System.Drawing.Point(346, 49)
        Me.BtnPathBrowse.Name = "BtnPathBrowse"
        Me.BtnPathBrowse.Size = New System.Drawing.Size(28, 28)
        Me.BtnPathBrowse.TabIndex = 25
        Me.BtnPathBrowse.Text = "..."
        Me.BtnPathBrowse.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.BtnPathBrowse)
        Me.Controls.Add(Me.ChkHideToTrayAtStartup)
        Me.Controls.Add(Me.ChkRunAutoAtStartup)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.LblStartup)
        Me.Controls.Add(Me.ChkHideToTrayAtClose)
        Me.Controls.Add(Me.ChkHideToTrayAtInit)
        Me.Controls.Add(Me.ChkStartMAtInit)
        Me.Controls.Add(Me.TxtPath)
        Me.Controls.Add(Me.LblBasic)
        Me.Controls.Add(Me.LblPath)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As Button
    Friend WithEvents LblStartup As Label
    Friend WithEvents ChkHideToTrayAtClose As CheckBox
    Friend WithEvents ChkHideToTrayAtInit As CheckBox
    Friend WithEvents ChkStartMAtInit As CheckBox
    Friend WithEvents TxtPath As TextBox
    Friend WithEvents LblBasic As Label
    Friend WithEvents LblPath As Label
    Friend WithEvents ChkHideToTrayAtStartup As CheckBox
    Friend WithEvents ChkRunAutoAtStartup As CheckBox
    Friend WithEvents BtnPathBrowse As Button
    Friend WithEvents FbdPath As FolderBrowserDialog
End Class
