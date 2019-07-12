

Public Class MainForm
    ''' <summary>
    ''' Global Variables Declared
    ''' </summary>
    Private Const MIN_UNITS As Integer = 0
    Private Const MAX_UNITS As Integer = 1000
    Dim runningTotal As Integer
    Dim currentDay As Integer = 1
    Private Const MAX_DAYS As Integer = 7

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    ''' <summary>
    ''' Closes the Application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    ''' <summary>
    ''' When Enter button is pressed, following functions will execute
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim unitsShipped As Integer
        Dim userInput As String = txtUnits.Text
        Dim averageUnitsShipped As Double

        If IsNumeric(userInput) Then
            unitsShipped = CInt(userInput)

            If unitsShipped.ToString = userInput Then

                If unitsShipped >= MIN_UNITS AndAlso unitsShipped <= MAX_UNITS Then
                    runningTotal += unitsShipped
                    txtEnteredUnits.Text += userInput & vbCrLf

                    If currentDay = MAX_DAYS Then
                        btnEnter.Enabled = False
                        txtEnteredUnits.ReadOnly = True

                        averageUnitsShipped = runningTotal / MAX_DAYS

                        lblResult.Text = "Average Units in day is " & Math.Round(averageUnitsShipped, 2).ToString

                        txtUnits.Clear()
                        txtUnits.Enabled = False
                    Else
                        currentDay += 1
                        lblDays.Text = "Day " & currentDay.ToString

                        txtUnits.Text = ""
                    End If

                Else
                    MessageBox.Show("Please enter a number within " & MIN_UNITS & " and " & MAX_UNITS & ".")
                    txtUnits.Text = ""
                    txtUnits.Select()
                End If

            Else
                MessageBox.Show("Please enter a whole number.")
                txtUnits.Text = ""
                txtUnits.Select()
            End If

        Else
            MessageBox.Show("Please enter a valid number.")
            txtUnits.Text = ""
            txtUnits.Select()
        End If
    End Sub
    ''' <summary>
    ''' When the Reset button is pressed, following varialble and objects are reset. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        lblResult.Text = ""
        txtEnteredUnits.Clear()
        txtUnits.Text = ""
        lblDays.Text = "Day 1"
        runningTotal = 0
        currentDay = 1
        btnEnter.Enabled = True
        txtEnteredUnits.ReadOnly = False
        txtUnits.Enabled = True
        txtUnits.Select()

    End Sub

    Private Sub lblDays_Click(sender As Object, e As EventArgs) Handles lblDays.Click

    End Sub

End Class
