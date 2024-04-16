<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.PicBadge = New System.Windows.Forms.PictureBox()
        Me.LblAppName = New System.Windows.Forms.Label()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.LblCopyright = New System.Windows.Forms.Label()
        CType(Me.PicBadge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicBadge
        '
        Me.PicBadge.Image = CType(resources.GetObject("PicBadge.Image"), System.Drawing.Image)
        Me.PicBadge.Location = New System.Drawing.Point(97, 12)
        Me.PicBadge.Name = "PicBadge"
        Me.PicBadge.Size = New System.Drawing.Size(150, 150)
        Me.PicBadge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBadge.TabIndex = 1
        Me.PicBadge.TabStop = False
        '
        'LblAppName
        '
        Me.LblAppName.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblAppName.Location = New System.Drawing.Point(9, 182)
        Me.LblAppName.Name = "LblAppName"
        Me.LblAppName.Size = New System.Drawing.Size(327, 27)
        Me.LblAppName.TabIndex = 2
        Me.LblAppName.Text = "Closed Circuit Disk Vision"
        Me.LblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVersion
        '
        Me.LblVersion.Location = New System.Drawing.Point(9, 210)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(327, 27)
        Me.LblVersion.TabIndex = 3
        Me.LblVersion.Text = "Version: 0.0.0"
        Me.LblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCopyright
        '
        Me.LblCopyright.Location = New System.Drawing.Point(9, 274)
        Me.LblCopyright.Name = "LblCopyright"
        Me.LblCopyright.Size = New System.Drawing.Size(327, 27)
        Me.LblCopyright.TabIndex = 4
        Me.LblCopyright.Text = "Copyright © 2019. All rights reserved."
        Me.LblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'About
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(344, 321)
        Me.Controls.Add(Me.LblCopyright)
        Me.Controls.Add(Me.LblVersion)
        Me.Controls.Add(Me.LblAppName)
        Me.Controls.Add(Me.PicBadge)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.PicBadge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicBadge As PictureBox
    Friend WithEvents LblAppName As Label
    Friend WithEvents LblVersion As Label
    Friend WithEvents LblCopyright As Label
End Class
