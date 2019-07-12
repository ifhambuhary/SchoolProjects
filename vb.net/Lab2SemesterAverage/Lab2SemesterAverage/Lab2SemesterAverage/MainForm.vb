Option Strict On
Public Class MainForm

    Const MAXGRADE As Integer = 100
    Const MINGRADE As Integer = 0

    Private Function validateInput(ByVal userInput As String) As Boolean
        If IsNumeric(userInput) Then
            Dim marks As Double = CDbl(userInput)
            If marks >= MINGRADE And marks <= MAXGRADE Then
                Return True
            End If
        Else
            Return False
        End If
    End Function
    Private Function validateGrade(ByVal gradeInput As Double) As String

        If gradeInput >= 90 Then
            Return "A+"
        ElseIf gradeInput >= 85 Then
            Return "A"
        ElseIf gradeInput >= 80 Then
            Return "A-"
        ElseIf gradeInput >= 77 Then
            Return "B+"
        ElseIf gradeInput >= 73 Then
            Return "B"
        ElseIf gradeInput >= 70 Then
            Return "B-"
        ElseIf gradeInput >= 67 Then
            Return "C+"
        ElseIf gradeInput >= 63 Then
            Return "C"
        ElseIf gradeInput >= 60 Then
            Return "C-"
        ElseIf gradeInput >= 57 Then
            Return "D+"
        ElseIf gradeInput >= 53 Then
            Return "D"
        ElseIf gradeInput >= 50 Then
            Return "D-"
        Else
            Return "F"
        End If

    End Function
    Private Sub CourseOneFocus() Handles txtCourseOne.LostFocus
        If txtCourseOne.Text = "" Then
            Return
        End If

        If validateInput(txtCourseOne.Text) Then
            Dim CourseOneMark As Double = CDbl(txtCourseOne.Text)
            lblGPACourseOne.Text = validateGrade(CourseOneMark)
            lblDisplay.Text = ""
        Else
            lblDisplay.Text = "Please ensure that you enter a valid marks for Course 1. Marks should be between 0 and 100."
            txtCourseOne.Select()
            txtCourseOne.SelectAll()
            lblGPACourseOne.Text = ""
        End If
    End Sub
    Private Sub CourseTwoFocus() Handles txtCourseTwo.LostFocus
        If txtCourseTwo.Text = "" Then
            Return
        End If

        If validateInput(txtCourseTwo.Text) Then
            Dim CourseTwoMark As Double = CDbl(txtCourseTwo.Text)
            lblGPACourseTwo.Text = validateGrade(CourseTwoMark)
            lblDisplay.Text = ""
        Else
            lblDisplay.Text = "Please ensure that you enter a valid marks for Course 2. Marks should be between 0 and 100."
            txtCourseTwo.Select()
            txtCourseTwo.SelectAll()
            lblGPACourseTwo.Text = ""
        End If
    End Sub
    Private Sub CourseThreeFocus() Handles txtCourseThree.LostFocus
        If txtCourseThree.Text = "" Then
            Return
        End If

        If validateInput(txtCourseThree.Text) Then
            Dim CourseThreeMark As Double = CDbl(txtCourseThree.Text)
            lblGPACourseThree.Text = validateGrade(CourseThreeMark)
            lblDisplay.Text = ""
        Else
            lblDisplay.Text = "Please ensure that you enter a valid marks for Course 3. Marks should be between 0 and 100."
            txtCourseThree.Select()
            txtCourseThree.SelectAll()
            lblGPACourseThree.Text = ""
        End If
    End Sub
    Private Sub CourseFourFocus() Handles txtCourseFour.LostFocus
        If txtCourseFour.Text = "" Then
            Return
        End If

        If validateInput(txtCourseFour.Text) Then
            Dim CourseFourMark As Double = CDbl(txtCourseFour.Text)
            lblGPACourseFour.Text = validateGrade(CourseFourMark)
            lblDisplay.Text = ""
        Else
            lblDisplay.Text = "Please ensure that you enter a valid marks for Course 4. Marks should be between 0 and 100."
            txtCourseFour.Select()
            txtCourseFour.SelectAll()
            lblGPACourseFour.Text = ""
        End If
    End Sub

    Private Sub CourseFiveFocus() Handles txtCourseFive.LostFocus
        If txtCourseFive.Text = "" Then
            Return
        End If

        If validateInput(txtCourseFive.Text) Then
            Dim CourseFiveMark As Double = CDbl(txtCourseFive.Text)
            lblGPACourseFive.Text = validateGrade(CourseFiveMark)
            lblDisplay.Text = ""
        Else
            lblDisplay.Text = "Please ensure that you enter a valid marks for Course 5. Marks should be between 0 and 100."
            txtCourseFive.Select()
            txtCourseFive.SelectAll()
            lblGPACourseFive.Text = ""
        End If
    End Sub
    Private Sub CourseSixFocus() Handles txtCourseSix.LostFocus
        If txtCourseSix.Text = "" Then
            Return
        End If

        If validateInput(txtCourseSix.Text) Then
            Dim CourseSixMark As Double = CDbl(txtCourseSix.Text)
            lblGPACourseSix.Text = validateGrade(CourseSixMark)
            lblDisplay.Text = ""
        Else
            lblDisplay.Text = "Please ensure that you enter a valid marks for Course 6. Marks should be between 0 and 100."
            txtCourseSix.Select()
            txtCourseSix.SelectAll()
            lblGPACourseSix.Text = ""
        End If
    End Sub
    Private Function AverageMark(ByVal providedData() As Double) As Double
        Dim average As Double = 0
        Dim runningTotal As Double = 0

        For counter As Integer = 0 To providedData.Length - 1 Step 1
            Dim currentValue = providedData(counter)
            runningTotal += currentValue
        Next

        average = runningTotal / providedData.Length

        Return average
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCourseOne.Text = ""
        txtCourseTwo.Text = ""
        txtCourseThree.Text = ""
        txtCourseFour.Text = ""
        txtCourseFive.Text = ""
        txtCourseSix.Text = ""
        lblGPACourseOne.Text = ""
        lblGPACourseTwo.Text = ""
        lblGPACourseThree.Text = ""
        lblGPACourseFour.Text = ""
        lblGPACourseFive.Text = ""
        lblGPACourseSix.Text = ""
        lblAverage.Text = ""
        lblDisplay.Text = ""
        lblFinalGPA.Text = ""

        txtCourseOne.Enabled = True
        txtCourseTwo.Enabled = True
        txtCourseThree.Enabled = True
        txtCourseFour.Enabled = True
        txtCourseFive.Enabled = True
        txtCourseSix.Enabled = True
        btnCalculate.Enabled = True

        txtCourseOne.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If txtCourseOne.Text = "" Then
            lblDisplay.Text = "Please enter your marks for Course One"
            txtCourseOne.Focus()
        ElseIf txtCourseTwo.Text = "" Then
            lblDisplay.Text = "Please enter your marks for Course Two"
            txtCourseTwo.Focus()
        ElseIf txtCourseThree.Text = "" Then
            lblDisplay.Text = "Please enter your marks for Course Three"
            txtCourseThree.Focus()
        ElseIf txtCourseFour.Text = "" Then
            lblDisplay.Text = "Please enter your marks for Course Four"
            txtCourseFour.Focus()
        ElseIf txtCourseFive.Text = "" Then
            lblDisplay.Text = "Please enter your marks for Course Five"
            txtCourseFive.Focus()
        ElseIf txtCourseSix.Text = "" Then
            lblDisplay.Text = "Please enter your marks for Course Six"
            txtCourseSix.Focus()
        Else
            Dim arrayCoursMark(5) As Double

            arrayCoursMark(0) = CDbl(txtCourseOne.Text)
            arrayCoursMark(1) = CDbl(txtCourseTwo.Text)
            arrayCoursMark(2) = CDbl(txtCourseThree.Text)
            arrayCoursMark(3) = CDbl(txtCourseFour.Text)
            arrayCoursMark(4) = CDbl(txtCourseFive.Text)
            arrayCoursMark(5) = CDbl(txtCourseSix.Text)

            lblAverage.Text = Math.Round(AverageMark(arrayCoursMark), 2).ToString("0.00")
            lblFinalGPA.Text = validateGrade(CDbl(lblAverage.Text))

            txtCourseOne.Enabled = False
            txtCourseTwo.Enabled = False
            txtCourseThree.Enabled = False
            txtCourseFour.Enabled = False
            txtCourseFive.Enabled = False
            txtCourseSix.Enabled = False
            btnCalculate.Enabled = False
        End If
    End Sub
End Class
