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
        Me.lblCourseOne = New System.Windows.Forms.Label()
        Me.lblGPACourseOne = New System.Windows.Forms.Label()
        Me.txtCourseOne = New System.Windows.Forms.TextBox()
        Me.txtCourseTwo = New System.Windows.Forms.TextBox()
        Me.lblGPACourseTwo = New System.Windows.Forms.Label()
        Me.lblCourseTwo = New System.Windows.Forms.Label()
        Me.txtCourseFour = New System.Windows.Forms.TextBox()
        Me.lblGPACourseFour = New System.Windows.Forms.Label()
        Me.lblCourseFour = New System.Windows.Forms.Label()
        Me.txtCourseThree = New System.Windows.Forms.TextBox()
        Me.lblGPACourseThree = New System.Windows.Forms.Label()
        Me.lblCourseThree = New System.Windows.Forms.Label()
        Me.txtCourseSix = New System.Windows.Forms.TextBox()
        Me.lblGPACourseSix = New System.Windows.Forms.Label()
        Me.lblCourseSix = New System.Windows.Forms.Label()
        Me.txtCourseFive = New System.Windows.Forms.TextBox()
        Me.lblGPACourseFive = New System.Windows.Forms.Label()
        Me.lblCourseFive = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFinalGPA = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.SemesterAverageToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblCourseOne
        '
        Me.lblCourseOne.Location = New System.Drawing.Point(12, 55)
        Me.lblCourseOne.Name = "lblCourseOne"
        Me.lblCourseOne.Size = New System.Drawing.Size(73, 23)
        Me.lblCourseOne.TabIndex = 0
        Me.lblCourseOne.Text = "Course &1:"
        Me.lblCourseOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SemesterAverageToolTip.SetToolTip(Me.lblCourseOne, "Course 1")
        '
        'lblGPACourseOne
        '
        Me.lblGPACourseOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGPACourseOne.Location = New System.Drawing.Point(202, 56)
        Me.lblGPACourseOne.Name = "lblGPACourseOne"
        Me.lblGPACourseOne.Size = New System.Drawing.Size(100, 23)
        Me.lblGPACourseOne.TabIndex = 2
        Me.lblGPACourseOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lblGPACourseOne, "GPA for Course 1")
        '
        'txtCourseOne
        '
        Me.txtCourseOne.Location = New System.Drawing.Point(91, 56)
        Me.txtCourseOne.Name = "txtCourseOne"
        Me.txtCourseOne.Size = New System.Drawing.Size(100, 22)
        Me.txtCourseOne.TabIndex = 1
        Me.txtCourseOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageToolTip.SetToolTip(Me.txtCourseOne, "Enter Course 1 Marks")
        '
        'txtCourseTwo
        '
        Me.txtCourseTwo.Location = New System.Drawing.Point(91, 88)
        Me.txtCourseTwo.Name = "txtCourseTwo"
        Me.txtCourseTwo.Size = New System.Drawing.Size(100, 22)
        Me.txtCourseTwo.TabIndex = 4
        Me.txtCourseTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageToolTip.SetToolTip(Me.txtCourseTwo, "Enter Course 2 Marks")
        '
        'lblGPACourseTwo
        '
        Me.lblGPACourseTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGPACourseTwo.Location = New System.Drawing.Point(202, 88)
        Me.lblGPACourseTwo.Name = "lblGPACourseTwo"
        Me.lblGPACourseTwo.Size = New System.Drawing.Size(100, 23)
        Me.lblGPACourseTwo.TabIndex = 5
        Me.lblGPACourseTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lblGPACourseTwo, "GPA for Course 2")
        '
        'lblCourseTwo
        '
        Me.lblCourseTwo.Location = New System.Drawing.Point(12, 87)
        Me.lblCourseTwo.Name = "lblCourseTwo"
        Me.lblCourseTwo.Size = New System.Drawing.Size(73, 23)
        Me.lblCourseTwo.TabIndex = 3
        Me.lblCourseTwo.Text = "Course &2:"
        Me.lblCourseTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SemesterAverageToolTip.SetToolTip(Me.lblCourseTwo, "Course 2")
        '
        'txtCourseFour
        '
        Me.txtCourseFour.Location = New System.Drawing.Point(91, 152)
        Me.txtCourseFour.Name = "txtCourseFour"
        Me.txtCourseFour.Size = New System.Drawing.Size(100, 22)
        Me.txtCourseFour.TabIndex = 10
        Me.txtCourseFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageToolTip.SetToolTip(Me.txtCourseFour, "Enter Course 4 Marks")
        '
        'lblGPACourseFour
        '
        Me.lblGPACourseFour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGPACourseFour.Location = New System.Drawing.Point(202, 152)
        Me.lblGPACourseFour.Name = "lblGPACourseFour"
        Me.lblGPACourseFour.Size = New System.Drawing.Size(100, 23)
        Me.lblGPACourseFour.TabIndex = 11
        Me.lblGPACourseFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lblGPACourseFour, "GPA for Course 4")
        '
        'lblCourseFour
        '
        Me.lblCourseFour.Location = New System.Drawing.Point(12, 151)
        Me.lblCourseFour.Name = "lblCourseFour"
        Me.lblCourseFour.Size = New System.Drawing.Size(73, 23)
        Me.lblCourseFour.TabIndex = 9
        Me.lblCourseFour.Text = "Course &4:"
        Me.lblCourseFour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SemesterAverageToolTip.SetToolTip(Me.lblCourseFour, "Course 4")
        '
        'txtCourseThree
        '
        Me.txtCourseThree.Location = New System.Drawing.Point(91, 120)
        Me.txtCourseThree.Name = "txtCourseThree"
        Me.txtCourseThree.Size = New System.Drawing.Size(100, 22)
        Me.txtCourseThree.TabIndex = 7
        Me.txtCourseThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageToolTip.SetToolTip(Me.txtCourseThree, "Enter Course 3 Marks")
        '
        'lblGPACourseThree
        '
        Me.lblGPACourseThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGPACourseThree.Location = New System.Drawing.Point(202, 120)
        Me.lblGPACourseThree.Name = "lblGPACourseThree"
        Me.lblGPACourseThree.Size = New System.Drawing.Size(100, 23)
        Me.lblGPACourseThree.TabIndex = 8
        Me.lblGPACourseThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lblGPACourseThree, "GPA for Course 3")
        '
        'lblCourseThree
        '
        Me.lblCourseThree.Location = New System.Drawing.Point(12, 119)
        Me.lblCourseThree.Name = "lblCourseThree"
        Me.lblCourseThree.Size = New System.Drawing.Size(73, 23)
        Me.lblCourseThree.TabIndex = 6
        Me.lblCourseThree.Text = "Course &3:"
        Me.lblCourseThree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SemesterAverageToolTip.SetToolTip(Me.lblCourseThree, "Course 3")
        '
        'txtCourseSix
        '
        Me.txtCourseSix.Location = New System.Drawing.Point(91, 216)
        Me.txtCourseSix.Name = "txtCourseSix"
        Me.txtCourseSix.Size = New System.Drawing.Size(100, 22)
        Me.txtCourseSix.TabIndex = 16
        Me.txtCourseSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageToolTip.SetToolTip(Me.txtCourseSix, "Enter Course 5 Marks")
        '
        'lblGPACourseSix
        '
        Me.lblGPACourseSix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGPACourseSix.Location = New System.Drawing.Point(202, 216)
        Me.lblGPACourseSix.Name = "lblGPACourseSix"
        Me.lblGPACourseSix.Size = New System.Drawing.Size(100, 23)
        Me.lblGPACourseSix.TabIndex = 17
        Me.lblGPACourseSix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lblGPACourseSix, "GPA for Course 6")
        '
        'lblCourseSix
        '
        Me.lblCourseSix.Location = New System.Drawing.Point(12, 215)
        Me.lblCourseSix.Name = "lblCourseSix"
        Me.lblCourseSix.Size = New System.Drawing.Size(73, 23)
        Me.lblCourseSix.TabIndex = 15
        Me.lblCourseSix.Text = "Course &6:"
        Me.lblCourseSix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SemesterAverageToolTip.SetToolTip(Me.lblCourseSix, "Course 6")
        '
        'txtCourseFive
        '
        Me.txtCourseFive.Location = New System.Drawing.Point(91, 184)
        Me.txtCourseFive.Name = "txtCourseFive"
        Me.txtCourseFive.Size = New System.Drawing.Size(100, 22)
        Me.txtCourseFive.TabIndex = 13
        Me.txtCourseFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageToolTip.SetToolTip(Me.txtCourseFive, "Enter Course 5 Marks")
        '
        'lblGPACourseFive
        '
        Me.lblGPACourseFive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGPACourseFive.Location = New System.Drawing.Point(202, 184)
        Me.lblGPACourseFive.Name = "lblGPACourseFive"
        Me.lblGPACourseFive.Size = New System.Drawing.Size(100, 23)
        Me.lblGPACourseFive.TabIndex = 14
        Me.lblGPACourseFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lblGPACourseFive, "GPA for Course 5")
        '
        'lblCourseFive
        '
        Me.lblCourseFive.Location = New System.Drawing.Point(12, 183)
        Me.lblCourseFive.Name = "lblCourseFive"
        Me.lblCourseFive.Size = New System.Drawing.Size(73, 23)
        Me.lblCourseFive.TabIndex = 12
        Me.lblCourseFive.Text = "Course &5:"
        Me.lblCourseFive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SemesterAverageToolTip.SetToolTip(Me.lblCourseFive, "Course 5")
        '
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Location = New System.Drawing.Point(15, 311)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(287, 196)
        Me.lblDisplay.TabIndex = 21
        Me.SemesterAverageToolTip.SetToolTip(Me.lblDisplay, "Display Message")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(15, 528)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(91, 35)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.SemesterAverageToolTip.SetToolTip(Me.btnCalculate, "Calculate Results")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(114, 528)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 35)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.SemesterAverageToolTip.SetToolTip(Me.btnReset, "Reset Application")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(212, 528)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 35)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "&Exit"
        Me.SemesterAverageToolTip.SetToolTip(Me.btnExit, "Exit Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFinalGPA
        '
        Me.lblFinalGPA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalGPA.Location = New System.Drawing.Point(202, 262)
        Me.lblFinalGPA.Name = "lblFinalGPA"
        Me.lblFinalGPA.Size = New System.Drawing.Size(100, 23)
        Me.lblFinalGPA.TabIndex = 20
        Me.lblFinalGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lblFinalGPA, "Overall GPA")
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(91, 262)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(100, 23)
        Me.lblAverage.TabIndex = 19
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageToolTip.SetToolTip(Me.lblAverage, "Average Marks for Course")
        '
        'lblSemester
        '
        Me.lblSemester.Location = New System.Drawing.Point(12, 263)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(73, 23)
        Me.lblSemester.TabIndex = 18
        Me.lblSemester.Text = "Semester:"
        Me.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SemesterAverageToolTip.SetToolTip(Me.lblSemester, "Semester")
        Me.lblSemester.UseMnemonic = False
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(320, 578)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblFinalGPA)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtCourseSix)
        Me.Controls.Add(Me.lblGPACourseSix)
        Me.Controls.Add(Me.lblCourseSix)
        Me.Controls.Add(Me.txtCourseFive)
        Me.Controls.Add(Me.lblGPACourseFive)
        Me.Controls.Add(Me.lblCourseFive)
        Me.Controls.Add(Me.txtCourseFour)
        Me.Controls.Add(Me.lblGPACourseFour)
        Me.Controls.Add(Me.lblCourseFour)
        Me.Controls.Add(Me.txtCourseThree)
        Me.Controls.Add(Me.lblGPACourseThree)
        Me.Controls.Add(Me.lblCourseThree)
        Me.Controls.Add(Me.txtCourseTwo)
        Me.Controls.Add(Me.lblGPACourseTwo)
        Me.Controls.Add(Me.lblCourseTwo)
        Me.Controls.Add(Me.txtCourseOne)
        Me.Controls.Add(Me.lblGPACourseOne)
        Me.Controls.Add(Me.lblCourseOne)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(338, 625)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(338, 625)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourseOne As Label
    Friend WithEvents lblGPACourseOne As Label
    Friend WithEvents txtCourseOne As TextBox
    Friend WithEvents txtCourseTwo As TextBox
    Friend WithEvents lblGPACourseTwo As Label
    Friend WithEvents lblCourseTwo As Label
    Friend WithEvents txtCourseFour As TextBox
    Friend WithEvents lblGPACourseFour As Label
    Friend WithEvents lblCourseFour As Label
    Friend WithEvents txtCourseThree As TextBox
    Friend WithEvents lblGPACourseThree As Label
    Friend WithEvents lblCourseThree As Label
    Friend WithEvents txtCourseSix As TextBox
    Friend WithEvents lblGPACourseSix As Label
    Friend WithEvents lblCourseSix As Label
    Friend WithEvents txtCourseFive As TextBox
    Friend WithEvents lblGPACourseFive As Label
    Friend WithEvents lblCourseFive As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFinalGPA As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents SemesterAverageToolTip As ToolTip
End Class
