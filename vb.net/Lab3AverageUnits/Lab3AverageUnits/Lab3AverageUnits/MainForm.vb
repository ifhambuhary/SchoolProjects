Option Strict On
Public Class MainForm
    'Declaring the Minimum and Maximum Grades   
    Private Const MAX_UNITS As Integer = 1000
    Private Const MIN_UNITS As Integer = 0
    Private Const MAX_DAYS As Integer = 7
    Private Const MAX_EMPLOYEES As Integer = 3

    Dim unitsShippedByEmployee(2, 6) As Integer
    Dim employeeNumber As Integer = 1
    Dim shippedDay As Integer = 1
    Dim unitShipped As String = ""
    Dim validatedInput As Integer = 0
    Dim currentDay As Integer = 1
    Dim averageUnitsShipped As Double = 0.0
    Dim totalAverageUnitsShipped As Double = 0.0

    Dim empOne As Double = 0.0
    Dim empTwo As Double = 0.0
    Dim empThree As Double = 0.0

    Dim fontBold As New Font(Font, FontStyle.Bold)
    Dim fontNormal As New Font(Font, FontStyle.Regular)
    ''' <summary>
    ''' Function to validate user input
    ''' </summary>
    ''' <param name="userInput"></param>
    ''' <returns></returns>
    Private Function validatation(ByVal userInput As String, ByRef validatedInput As Integer) As Boolean
        Dim validUnitInput As Integer

        If (Integer.TryParse(userInput, validUnitInput)) Then
            If validUnitInput >= MIN_UNITS And validUnitInput <= MAX_UNITS Then
                validatedInput = validUnitInput
                Return True
            End If
        Else
            Return False
        End If
    End Function

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
      
        If txtInput.Text = "" Then
        Return
        End If

        unitShipped = txtInput.Text
        If validatation(unitShipped, validatedInput) Then

            unitsShippedByEmployee(employeeNumber - 1, shippedDay - 1) = validatedInput

            If employeeNumber = 1 Then
                lblEmpOne.Font = fontBold
                txtEmpOne.Text += unitsShippedByEmployee(0, shippedDay - 1).ToString + vbCrLf
                empOne += CInt(txtInput.Text)
                txtInput.Select()
                txtInput.SelectAll()
                txtInput.Text = ""
            ElseIf employeeNumber = 2 Then
                lblEmpTwo.Font = fontBold
                lblEmpOne.Font = fontNormal
                txtEmpTwo.Text += unitsShippedByEmployee(1, shippedDay - 1).ToString + vbCrLf
                empTwo += CInt(txtInput.Text)
                txtInput.Select()
                txtInput.SelectAll()
                txtInput.Text = ""
            Else
                lblEmpThree.Font = fontBold
                lblEmpTwo.Font = fontNormal
                lblEmpThree.Font = New Font(lblEmpThree.Font, FontStyle.Bold)
                txtEmpThree.Text += unitsShippedByEmployee(2, shippedDay - 1).ToString + vbCrLf
                empThree += CInt(txtInput.Text)
                txtInput.Select()
                txtInput.SelectAll()
                txtInput.Text = ""
                lblDay.Text = "Done"
            End If

            If shippedDay = MAX_DAYS Then
                shippedDay = 1

                If employeeNumber = 1 Then
                    averageUnitsShipped = empOne / MAX_DAYS
                    lblAvgOne.Text = "Average: " & Math.Round(averageUnitsShipped, 2)
                    empOne = averageUnitsShipped
                    averageUnitsShipped = 0
                ElseIf employeeNumber = 2 Then
                    averageUnitsShipped = empTwo / MAX_DAYS
                    lblAvgTwo.Text = "Average: " & Math.Round(averageUnitsShipped, 2)
                    empTwo = averageUnitsShipped
                    averageUnitsShipped = 0
                Else
                    averageUnitsShipped = empThree / MAX_DAYS
                    lblAvgThree.Text = "Average: " & Math.Round(averageUnitsShipped, 2)
                    empThree = averageUnitsShipped
                    averageUnitsShipped = 0
                End If
                employeeNumber += 1
            Else
                shippedDay += 1
            End If

            If employeeNumber > 3 Then
                btnEnter.Enabled = False
                totalAverageUnitsShipped = ((empOne + empTwo + empThree) / MAX_EMPLOYEES)
                lblAvgTotal.Text = "Total Average: " & Math.Round(totalAverageUnitsShipped, 2)
                txtInput.Enabled = False
                txtEmpOne.ReadOnly = True
                txtEmpTwo.ReadOnly = True
                txtEmpThree.ReadOnly = True


            Else
                lblDay.Text = "Day " + shippedDay.ToString
            End If
        Else
            MessageBox.Show("Please ensure that you enter a valid units shipped. Units should be between " & MIN_UNITS & " and " & MAX_UNITS & ".")
            txtInput.Select()
            txtInput.SelectAll()
            txtInput.Text = ""
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Reset Array
        ReDim unitsShippedByEmployee(2, 6)
        btnEnter.Enabled = True
        txtInput.Enabled = True

        lblAvgOne.Text = ""
        lblAvgTwo.Text = ""
        lblAvgThree.Text = ""
        lblEmpOne.Font = fontNormal
        lblEmpTwo.Font = fontNormal
        lblEmpThree.Font = fontNormal
        empOne = 0
        empTwo = 0
        empThree = 0
        txtEmpOne.Text = ""
        txtEmpTwo.Text = ""
        txtEmpThree.Text = ""
        txtEmpOne.ReadOnly = False
        txtEmpTwo.ReadOnly = False
        txtEmpThree.ReadOnly = False

        totalAverageUnitsShipped = 0
        txtInput.Text = ""
        lblAvgTotal.Text = ""
        txtInput.Select()
        txtInput.SelectAll()
        lblDay.Text = "Day 1"
        employeeNumber = 1
        shippedDay = 1

    End Sub
End Class
