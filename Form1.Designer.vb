<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tsBrowse = New System.Windows.Forms.ToolStrip()
        Me.bBack = New System.Windows.Forms.ToolStripButton()
        Me.bForward = New System.Windows.Forms.ToolStripButton()
        Me.bRefresh = New System.Windows.Forms.ToolStripButton()
        Me.tbAddress = New System.Windows.Forms.ToolStripTextBox()
        Me.bJump = New System.Windows.Forms.ToolStripButton()
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ddbMenu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.bDarkTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.bLMT = New System.Windows.Forms.ToolStripButton()
        Me.ssStatus = New System.Windows.Forms.StatusStrip()
        Me.lStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.wbMain = New Gecko.GeckoWebBrowser()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsBrowse.SuspendLayout()
        Me.ssStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsBrowse
        '
        Me.tsBrowse.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bBack, Me.bForward, Me.bRefresh, Me.tbAddress, Me.bJump, Me.Separator1, Me.ddbMenu, Me.bLMT})
        Me.tsBrowse.Location = New System.Drawing.Point(0, 0)
        Me.tsBrowse.Name = "tsBrowse"
        Me.tsBrowse.Size = New System.Drawing.Size(401, 25)
        Me.tsBrowse.TabIndex = 1
        Me.tsBrowse.Text = "ToolStrip1"
        '
        'bBack
        '
        Me.bBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bBack.Enabled = False
        Me.bBack.Image = CType(resources.GetObject("bBack.Image"), System.Drawing.Image)
        Me.bBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bBack.Name = "bBack"
        Me.bBack.Size = New System.Drawing.Size(23, 22)
        Me.bBack.Text = "Back"
        Me.bBack.ToolTipText = "Go back one page."
        '
        'bForward
        '
        Me.bForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bForward.Enabled = False
        Me.bForward.Image = CType(resources.GetObject("bForward.Image"), System.Drawing.Image)
        Me.bForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bForward.Name = "bForward"
        Me.bForward.Size = New System.Drawing.Size(23, 22)
        Me.bForward.Text = "Forward"
        Me.bForward.ToolTipText = "Go forward one page."
        '
        'bRefresh
        '
        Me.bRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bRefresh.Image = CType(resources.GetObject("bRefresh.Image"), System.Drawing.Image)
        Me.bRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bRefresh.Name = "bRefresh"
        Me.bRefresh.Size = New System.Drawing.Size(23, 22)
        Me.bRefresh.Text = "Refresh"
        Me.bRefresh.ToolTipText = "Refresh the current webpage"
        '
        'tbAddress
        '
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(225, 25)
        '
        'bJump
        '
        Me.bJump.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bJump.Image = CType(resources.GetObject("bJump.Image"), System.Drawing.Image)
        Me.bJump.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bJump.Name = "bJump"
        Me.bJump.Size = New System.Drawing.Size(23, 22)
        Me.bJump.Text = "Jump"
        Me.bJump.ToolTipText = "Jumps to the page entered."
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(6, 25)
        '
        'ddbMenu
        '
        Me.ddbMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ddbMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bDarkTheme, Me.ToolStripSeparator1, Me.bExit})
        Me.ddbMenu.Image = CType(resources.GetObject("ddbMenu.Image"), System.Drawing.Image)
        Me.ddbMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddbMenu.Name = "ddbMenu"
        Me.ddbMenu.Size = New System.Drawing.Size(29, 22)
        Me.ddbMenu.Text = "Menu"
        '
        'bDarkTheme
        '
        Me.bDarkTheme.Name = "bDarkTheme"
        Me.bDarkTheme.Size = New System.Drawing.Size(176, 22)
        Me.bDarkTheme.Text = "Enable Dark Theme"
        '
        'bLMT
        '
        Me.bLMT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bLMT.Image = CType(resources.GetObject("bLMT.Image"), System.Drawing.Image)
        Me.bLMT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bLMT.Name = "bLMT"
        Me.bLMT.Size = New System.Drawing.Size(23, 22)
        Me.bLMT.Text = "LMT"
        Me.bLMT.ToolTipText = "Visit the LMT website"
        '
        'ssStatus
        '
        Me.ssStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lStatus, Me.pbProgress})
        Me.ssStatus.Location = New System.Drawing.Point(0, 278)
        Me.ssStatus.Name = "ssStatus"
        Me.ssStatus.Size = New System.Drawing.Size(401, 22)
        Me.ssStatus.TabIndex = 3
        Me.ssStatus.Text = "StatusStrip1"
        '
        'lStatus
        '
        Me.lStatus.Name = "lStatus"
        Me.lStatus.Size = New System.Drawing.Size(61, 17)
        Me.lStatus.Text = "Navigated"
        '
        'pbProgress
        '
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.Size = New System.Drawing.Size(100, 16)
        Me.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbProgress.Visible = False
        '
        'wbMain
        '
        Me.wbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbMain.Location = New System.Drawing.Point(0, 25)
        Me.wbMain.Name = "wbMain"
        Me.wbMain.Size = New System.Drawing.Size(401, 253)
        Me.wbMain.TabIndex = 4
        Me.wbMain.UseHttpActivityObserver = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(173, 6)
        '
        'bExit
        '
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(176, 22)
        Me.bExit.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 300)
        Me.Controls.Add(Me.wbMain)
        Me.Controls.Add(Me.ssStatus)
        Me.Controls.Add(Me.tsBrowse)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(417, 200)
        Me.Name = "Form1"
        Me.Text = "WebJump Web Browser - WebJump Startpage"
        Me.tsBrowse.ResumeLayout(False)
        Me.tsBrowse.PerformLayout()
        Me.ssStatus.ResumeLayout(False)
        Me.ssStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsBrowse As ToolStrip
    Friend WithEvents bBack As ToolStripButton
    Friend WithEvents bForward As ToolStripButton
    Friend WithEvents tbAddress As ToolStripTextBox
    Friend WithEvents Separator1 As ToolStripSeparator
    Friend WithEvents ddbMenu As ToolStripDropDownButton
    Friend WithEvents bJump As ToolStripButton
    Friend WithEvents bLMT As ToolStripButton
    Friend WithEvents bRefresh As ToolStripButton
    Friend WithEvents ssStatus As StatusStrip
    Friend WithEvents lStatus As ToolStripStatusLabel
    Friend WithEvents pbProgress As ToolStripProgressBar
    Friend WithEvents wbMain As Gecko.GeckoWebBrowser
    Friend WithEvents bDarkTheme As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents bExit As ToolStripMenuItem
End Class
