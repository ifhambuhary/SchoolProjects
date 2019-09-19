<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAverageUnits = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem, Me.mnuCut, Me.WindowsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1062, 28)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FIleToolStripMenuItem
        '
        Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuSave, Me.mnuSaveAs, Me.mnuClose, Me.mnuExit})
        Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FIleToolStripMenuItem.Text = "&FIle"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNew.Size = New System.Drawing.Size(225, 26)
        Me.mnuNew.Text = "&New"
        Me.mnuNew.ToolTipText = "New File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(225, 26)
        Me.mnuOpen.Text = "&Open"
        Me.mnuOpen.ToolTipText = "Open File"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(225, 26)
        Me.mnuSave.Text = "&Save"
        Me.mnuSave.ToolTipText = "Save File"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSaveAs.Size = New System.Drawing.Size(225, 26)
        Me.mnuSaveAs.Text = "Save &As"
        Me.mnuSaveAs.ToolTipText = "Save File As"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(225, 26)
        Me.mnuClose.Text = "&Close"
        Me.mnuClose.ToolTipText = "Close "
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(225, 26)
        Me.mnuExit.Text = "&Exit"
        Me.mnuExit.ToolTipText = "Exit Application"
        '
        'mnuCut
        '
        Me.mnuCut.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.mnuCopy, Me.mnuPaste})
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(47, 24)
        Me.mnuCut.Text = "&Edit"
        Me.mnuCut.ToolTipText = "Cut"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(169, 26)
        Me.mnuCopy.Text = "&Copy"
        Me.mnuCopy.ToolTipText = "Copy"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(169, 26)
        Me.mnuPaste.Text = "&Paste"
        Me.mnuPaste.ToolTipText = "Paste"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCascade, Me.mnuVertical, Me.mnuHorizontal, Me.mnuAverageUnits})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.WindowsToolStripMenuItem.Text = "&Windows"
        '
        'mnuCascade
        '
        Me.mnuCascade.Name = "mnuCascade"
        Me.mnuCascade.Size = New System.Drawing.Size(216, 26)
        Me.mnuCascade.Text = "&Cascade"
        Me.mnuCascade.ToolTipText = "Cascade"
        '
        'mnuVertical
        '
        Me.mnuVertical.Name = "mnuVertical"
        Me.mnuVertical.Size = New System.Drawing.Size(216, 26)
        Me.mnuVertical.Text = "Tile &Vertical"
        Me.mnuVertical.ToolTipText = "Tile Vertical"
        '
        'mnuHorizontal
        '
        Me.mnuHorizontal.Name = "mnuHorizontal"
        Me.mnuHorizontal.Size = New System.Drawing.Size(216, 26)
        Me.mnuHorizontal.Text = "Tile &Horzontal"
        '
        'mnuAverageUnits
        '
        Me.mnuAverageUnits.Name = "mnuAverageUnits"
        Me.mnuAverageUnits.Size = New System.Drawing.Size(216, 26)
        Me.mnuAverageUnits.Text = "&Average Units"
        Me.mnuAverageUnits.ToolTipText = "Average Units"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(216, 26)
        Me.mnuAbout.Text = "&About"
        Me.mnuAbout.ToolTipText = "About Program"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 673)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDI Text Editor - Ifham"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuSaveAs As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuCut As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuCascade As ToolStripMenuItem
    Friend WithEvents mnuVertical As ToolStripMenuItem
    Friend WithEvents mnuHorizontal As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAverageUnits As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
End Class
