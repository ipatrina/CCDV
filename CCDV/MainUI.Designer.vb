<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainUI
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainUI))
        Me.LsvEvents = New System.Windows.Forms.ListView()
        Me.ClhEvent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhMoment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MstMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmSaveEvents = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmClearEvents = New System.Windows.Forms.ToolStripMenuItem()
        Me.TssFile = New System.Windows.Forms.ToolStripSeparator()
        Me.TsmHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmAutoscroll = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmStartMonitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmStopMonitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.TssMonitor = New System.Windows.Forms.ToolStripSeparator()
        Me.TsmEnableSubdir = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmDisableSubdir = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.NtiTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CtmTray = New System.Windows.Forms.ContextMenu()
        Me.MniHideShow = New System.Windows.Forms.MenuItem()
        Me.MniStopStart = New System.Windows.Forms.MenuItem()
        Me.MniOptions = New System.Windows.Forms.MenuItem()
        Me.TssTray = New System.Windows.Forms.MenuItem()
        Me.MniQuit = New System.Windows.Forms.MenuItem()
        Me.SfdEvents = New System.Windows.Forms.SaveFileDialog()
        Me.FswEvents = New System.IO.FileSystemWatcher()
        Me.MstMenu.SuspendLayout()
        CType(Me.FswEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LsvEvents
        '
        Me.LsvEvents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LsvEvents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClhEvent, Me.ClhMoment, Me.ClhLocation})
        Me.LsvEvents.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LsvEvents.FullRowSelect = True
        Me.LsvEvents.Location = New System.Drawing.Point(12, 36)
        Me.LsvEvents.MultiSelect = False
        Me.LsvEvents.Name = "LsvEvents"
        Me.LsvEvents.Size = New System.Drawing.Size(760, 363)
        Me.LsvEvents.TabIndex = 2
        Me.LsvEvents.UseCompatibleStateImageBehavior = False
        Me.LsvEvents.View = System.Windows.Forms.View.Details
        '
        'ClhEvent
        '
        Me.ClhEvent.Text = "EVENT"
        Me.ClhEvent.Width = 80
        '
        'ClhMoment
        '
        Me.ClhMoment.Text = "MOMENT"
        Me.ClhMoment.Width = 160
        '
        'ClhLocation
        '
        Me.ClhLocation.Text = "LOCATION"
        Me.ClhLocation.Width = 480
        '
        'MstMenu
        '
        Me.MstMenu.BackColor = System.Drawing.Color.LightCyan
        Me.MstMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.MonitorToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MstMenu.Location = New System.Drawing.Point(0, 0)
        Me.MstMenu.Name = "MstMenu"
        Me.MstMenu.Size = New System.Drawing.Size(784, 25)
        Me.MstMenu.TabIndex = 3
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmSaveEvents, Me.TsmClearEvents, Me.TssFile, Me.TsmHide, Me.TsmQuit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'TsmSaveEvents
        '
        Me.TsmSaveEvents.Name = "TsmSaveEvents"
        Me.TsmSaveEvents.Size = New System.Drawing.Size(147, 22)
        Me.TsmSaveEvents.Text = "&Save events"
        '
        'TsmClearEvents
        '
        Me.TsmClearEvents.Name = "TsmClearEvents"
        Me.TsmClearEvents.Size = New System.Drawing.Size(147, 22)
        Me.TsmClearEvents.Text = "&Clear events"
        '
        'TssFile
        '
        Me.TssFile.Name = "TssFile"
        Me.TssFile.Size = New System.Drawing.Size(144, 6)
        '
        'TsmHide
        '
        Me.TsmHide.Name = "TsmHide"
        Me.TsmHide.Size = New System.Drawing.Size(147, 22)
        Me.TsmHide.Text = "&Hide"
        '
        'TsmQuit
        '
        Me.TsmQuit.Name = "TsmQuit"
        Me.TsmQuit.Size = New System.Drawing.Size(147, 22)
        Me.TsmQuit.Text = "&Quit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmAutoscroll, Me.TsmOptions})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'TsmAutoscroll
        '
        Me.TsmAutoscroll.Name = "TsmAutoscroll"
        Me.TsmAutoscroll.Size = New System.Drawing.Size(180, 22)
        Me.TsmAutoscroll.Text = "&Autoscroll"
        '
        'TsmOptions
        '
        Me.TsmOptions.Name = "TsmOptions"
        Me.TsmOptions.Size = New System.Drawing.Size(134, 22)
        Me.TsmOptions.Text = "&Options"
        '
        'MonitorToolStripMenuItem
        '
        Me.MonitorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmStartMonitor, Me.TsmStopMonitor, Me.TssMonitor, Me.TsmEnableSubdir, Me.TsmDisableSubdir})
        Me.MonitorToolStripMenuItem.Name = "MonitorToolStripMenuItem"
        Me.MonitorToolStripMenuItem.Size = New System.Drawing.Size(67, 21)
        Me.MonitorToolStripMenuItem.Text = "&Monitor"
        '
        'TsmStartMonitor
        '
        Me.TsmStartMonitor.Enabled = False
        Me.TsmStartMonitor.Name = "TsmStartMonitor"
        Me.TsmStartMonitor.Size = New System.Drawing.Size(282, 22)
        Me.TsmStartMonitor.Text = "Start monitor(&1)"
        '
        'TsmStopMonitor
        '
        Me.TsmStopMonitor.Name = "TsmStopMonitor"
        Me.TsmStopMonitor.Size = New System.Drawing.Size(282, 22)
        Me.TsmStopMonitor.Text = "Stop monitor(&2)"
        '
        'TssMonitor
        '
        Me.TssMonitor.Name = "TssMonitor"
        Me.TssMonitor.Size = New System.Drawing.Size(279, 6)
        '
        'TsmEnableSubdir
        '
        Me.TsmEnableSubdir.Enabled = False
        Me.TsmEnableSubdir.Name = "TsmEnableSubdir"
        Me.TsmEnableSubdir.Size = New System.Drawing.Size(282, 22)
        Me.TsmEnableSubdir.Text = "Enable subdirectory surveillance(&3)"
        '
        'TsmDisableSubdir
        '
        Me.TsmDisableSubdir.Name = "TsmDisableSubdir"
        Me.TsmDisableSubdir.Size = New System.Drawing.Size(282, 22)
        Me.TsmDisableSubdir.Text = "Disable subdirectory surveillance(&4)"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'TsmAbout
        '
        Me.TsmAbout.Name = "TsmAbout"
        Me.TsmAbout.Size = New System.Drawing.Size(111, 22)
        Me.TsmAbout.Text = "&About"
        '
        'NtiTray
        '
        Me.NtiTray.Icon = CType(resources.GetObject("NtiTray.Icon"), System.Drawing.Icon)
        Me.NtiTray.Text = "CCDV"
        Me.NtiTray.Visible = True
        '
        'CtmTray
        '
        Me.CtmTray.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MniHideShow, Me.MniStopStart, Me.MniOptions, Me.TssTray, Me.MniQuit})
        '
        'MniHideShow
        '
        Me.MniHideShow.Index = 0
        Me.MniHideShow.Text = "Hide"
        '
        'MniStopStart
        '
        Me.MniStopStart.Index = 1
        Me.MniStopStart.Text = "Stop monitor"
        '
        'MniOptions
        '
        Me.MniOptions.Index = 2
        Me.MniOptions.Text = "Options"
        '
        'TssTray
        '
        Me.TssTray.Index = 3
        Me.TssTray.Text = "-"
        '
        'MniQuit
        '
        Me.MniQuit.Index = 4
        Me.MniQuit.Text = "Quit"
        '
        'SfdEvents
        '
        Me.SfdEvents.Title = "Save events"
        '
        'FswEvents
        '
        Me.FswEvents.EnableRaisingEvents = True
        Me.FswEvents.IncludeSubdirectories = True
        Me.FswEvents.NotifyFilter = CType((((((((System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.DirectoryName) _
            Or System.IO.NotifyFilters.Attributes) _
            Or System.IO.NotifyFilters.Size) _
            Or System.IO.NotifyFilters.LastWrite) _
            Or System.IO.NotifyFilters.LastAccess) _
            Or System.IO.NotifyFilters.CreationTime) _
            Or System.IO.NotifyFilters.Security), System.IO.NotifyFilters)
        Me.FswEvents.SynchronizingObject = Me
        '
        'MainUI
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.MstMenu)
        Me.Controls.Add(Me.LsvEvents)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 450)
        Me.Name = "MainUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CCDV"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.MstMenu.ResumeLayout(False)
        Me.MstMenu.PerformLayout()
        CType(Me.FswEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LsvEvents As ListView
    Friend WithEvents ClhEvent As ColumnHeader
    Friend WithEvents ClhMoment As ColumnHeader
    Friend WithEvents ClhLocation As ColumnHeader
    Friend WithEvents MstMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TsmSaveEvents As ToolStripMenuItem
    Friend WithEvents TsmClearEvents As ToolStripMenuItem
    Friend WithEvents TssFile As ToolStripSeparator
    Friend WithEvents TsmHide As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TsmOptions As ToolStripMenuItem
    Friend WithEvents MonitorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TsmStartMonitor As ToolStripMenuItem
    Friend WithEvents TsmStopMonitor As ToolStripMenuItem
    Friend WithEvents TssMonitor As ToolStripSeparator
    Friend WithEvents TsmEnableSubdir As ToolStripMenuItem
    Friend WithEvents TsmDisableSubdir As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TsmAbout As ToolStripMenuItem
    Friend WithEvents NtiTray As NotifyIcon
    Friend WithEvents CtmTray As ContextMenu
    Friend WithEvents MniHideShow As MenuItem
    Friend WithEvents MniStopStart As MenuItem
    Friend WithEvents MniOptions As MenuItem
    Friend WithEvents TssTray As MenuItem
    Friend WithEvents MniQuit As MenuItem
    Friend WithEvents SfdEvents As SaveFileDialog
    Friend WithEvents FswEvents As IO.FileSystemWatcher
    Friend WithEvents TsmQuit As ToolStripMenuItem
    Friend WithEvents TsmAutoscroll As ToolStripMenuItem
End Class
