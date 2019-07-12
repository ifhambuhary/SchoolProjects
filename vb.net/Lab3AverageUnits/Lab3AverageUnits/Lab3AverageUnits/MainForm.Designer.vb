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
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblEmpOne = New System.Windows.Forms.Label()
        Me.lblEmpTwo = New System.Windows.Forms.Label()
        Me.lblEmpThree = New System.Windows.Forms.Label()
        Me.txtEmpOne = New System.Windows.Forms.TextBox()
        Me.txtEmpTwo = New System.Windows.Forms.TextBox()
        Me.txtEmpThree = New System.Windows.Forms.TextBox()
        Me.lblAvgOne = New System.Windows.Forms.Label()
        Me.lblAvgTwo = New System.Windows.Forms.Label()
        Me.lblAvgThree = New System.Windows.Forms.Label()
        Me.lblAvgTotal = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTipAverageUnitsShippedByEmployee = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(23, 17)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(48, 23)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "&Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(23, 62)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(48, 23)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units: "
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(77, 62)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(69, 22)
        Me.txtInput.TabIndex = 2
        '
        'lblEmpOne
        '
        Me.lblEmpOne.Location = New System.Drawing.Point(30, 115)
        Me.lblEmpOne.Name = "lblEmpOne"
        Me.lblEmpOne.Size = New System.Drawing.Size(103, 23)
        Me.lblEmpOne.TabIndex = 3
        Me.lblEmpOne.Text = "Employee 1"
        Me.lblEmpOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmpTwo
        '
        Me.lblEmpTwo.Location = New System.Drawing.Point(198, 115)
        Me.lblEmpTwo.Name = "lblEmpTwo"
        Me.lblEmpTwo.Size = New System.Drawing.Size(100, 23)
        Me.lblEmpTwo.TabIndex = 4
        Me.lblEmpTwo.Text = "Employee 2"
        Me.lblEmpTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmpThree
        '
        Me.lblEmpThree.Location = New System.Drawing.Point(372, 115)
        Me.lblEmpThree.Name = "lblEmpThree"
        Me.lblEmpThree.Size = New System.Drawing.Size(100, 23)
        Me.lblEmpThree.TabIndex = 5
        Me.lblEmpThree.Text = "Employee 3"
        Me.lblEmpThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmpOne
        '
        Me.txtEmpOne.Location = New System.Drawing.Point(16, 141)
        Me.txtEmpOne.Multiline = True
        Me.txtEmpOne.Name = "txtEmpOne"
        Me.txtEmpOne.Size = New System.Drawing.Size(130, 170)
        Me.txtEmpOne.TabIndex = 6
        '
        'txtEmpTwo
        '
        Me.txtEmpTwo.Location = New System.Drawing.Point(185, 141)
        Me.txtEmpTwo.Multiline = True
        Me.txtEmpTwo.Name = "txtEmpTwo"
        Me.txtEmpTwo.Size = New System.Drawing.Size(130, 170)
        Me.txtEmpTwo.TabIndex = 7
        '
        'txtEmpThree
        '
        Me.txtEmpThree.Location = New System.Drawing.Point(359, 141)
        Me.txtEmpThree.Multiline = True
        Me.txtEmpThree.Name = "txtEmpThree"
        Me.txtEmpThree.Size = New System.Drawing.Size(130, 170)
        Me.txtEmpThree.TabIndex = 8
        '
        'lblAvgOne
        '
        Me.lblAvgOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgOne.Location = New System.Drawing.Point(16, 328)
        Me.lblAvgOne.Name = "lblAvgOne"
        Me.lblAvgOne.Size = New System.Drawing.Size(130, 23)
        Me.lblAvgOne.TabIndex = 9
        Me.lblAvgOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.lblAvgOne, "Average of Employee 1")
        '
        'lblAvgTwo
        '
        Me.lblAvgTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgTwo.Location = New System.Drawing.Point(185, 328)
        Me.lblAvgTwo.Name = "lblAvgTwo"
        Me.lblAvgTwo.Size = New System.Drawing.Size(130, 23)
        Me.lblAvgTwo.TabIndex = 10
        Me.lblAvgTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.lblAvgTwo, "Average of Employee 2")
        '
        'lblAvgThree
        '
        Me.lblAvgThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgThree.Location = New System.Drawing.Point(359, 328)
        Me.lblAvgThree.Name = "lblAvgThree"
        Me.lblAvgThree.Size = New System.Drawing.Size(130, 23)
        Me.lblAvgThree.TabIndex = 11
        Me.lblAvgThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.lblAvgThree, "Average of Employee 3")
        '
        'lblAvgTotal
        '
        Me.lblAvgTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgTotal.Location = New System.Drawing.Point(17, 365)
        Me.lblAvgTotal.Name = "lblAvgTotal"
        Me.lblAvgTotal.Size = New System.Drawing.Size(472, 30)
        Me.lblAvgTotal.TabIndex = 12
        Me.lblAvgTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.lblAvgTotal, "Overall Total Average ")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(33, 418)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 27)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.btnEnter, "Calculate Average")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(202, 418)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 27)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Re&set"
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.btnReset, "Reset Application")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(376, 418)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 27)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ToolTipAverageUnitsShippedByEmployee.SetToolTip(Me.btnExit, "Exit Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(509, 470)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblAvgTotal)
        Me.Controls.Add(Me.lblAvgThree)
        Me.Controls.Add(Me.lblAvgTwo)
        Me.Controls.Add(Me.lblAvgOne)
        Me.Controls.Add(Me.txtEmpThree)
        Me.Controls.Add(Me.txtEmpTwo)
        Me.Controls.Add(Me.txtEmpOne)
        Me.Controls.Add(Me.lblEmpThree)
        Me.Controls.Add(Me.lblEmpTwo)
        Me.Controls.Add(Me.lblEmpOne)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped by Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblEmpOne As Label
    Friend WithEvents lblEmpTwo As Label
    Friend WithEvents lblEmpThree As Label
    Friend WithEvents txtEmpOne As TextBox
    Friend WithEvents txtEmpTwo As TextBox
    Friend WithEvents txtEmpThree As TextBox
    Friend WithEvents lblAvgOne As Label
    Friend WithEvents lblAvgTwo As Label
    Friend WithEvents lblAvgThree As Label
    Friend WithEvents lblAvgTotal As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTipAverageUnitsShippedByEmployee As ToolTip
End Class
