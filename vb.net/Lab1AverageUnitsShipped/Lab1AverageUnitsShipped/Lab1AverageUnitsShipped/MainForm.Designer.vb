<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtEnteredUnits = New System.Windows.Forms.TextBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.AverageUnitsShippedToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(22, 44)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(67, 17)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lblUnits, "Enter Units")
        '
        'lblDays
        '
        Me.lblDays.Location = New System.Drawing.Point(235, 44)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(53, 17)
        Me.lblDays.TabIndex = 2
        Me.lblDays.Text = "&Day 1"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lblDays, "Day Units was Shipped")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(25, 353)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(85, 43)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnEnter, "Submit Value")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(128, 353)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(85, 43)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnReset, "Reset Application")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(228, 353)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 43)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnExit, "Exit Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(25, 298)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(288, 32)
        Me.lblResult.TabIndex = 4
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lblResult, "Display Average Units Shipped")
        '
        'txtEnteredUnits
        '
        Me.txtEnteredUnits.Location = New System.Drawing.Point(25, 98)
        Me.txtEnteredUnits.Multiline = True
        Me.txtEnteredUnits.Name = "txtEnteredUnits"
        Me.txtEnteredUnits.Size = New System.Drawing.Size(288, 177)
        Me.txtEnteredUnits.TabIndex = 3
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.txtEnteredUnits, "Entered Units Shipped")
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(95, 44)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(58, 22)
        Me.txtUnits.TabIndex = 1
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.txtUnits, "Enter Units Shipped")
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(342, 412)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.txtEnteredUnits)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblUnits)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(360, 459)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(360, 459)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnits As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents txtEnteredUnits As TextBox
    Friend WithEvents AverageUnitsShippedToolTip As ToolTip
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents lblDays As Label
End Class
