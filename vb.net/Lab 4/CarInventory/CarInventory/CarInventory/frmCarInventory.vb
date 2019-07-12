Option Strict On

''' <summary>
''' Author Name:    Ifham Buhary
''' Project Name:   Car Invetory
''' Date:           11-July-2019
''' Description     Application to keep a track of Car Inventory
''' </summary>
Public Class frmCarInventory

    Private vehicleList As New SortedList                                   ' collection of all the vehicleList in the list
    Private currentVehicleIdentificationNumber As String = String.Empty     ' current selected vehicle identification number
    Private editMode As Boolean = False

    ''' <summary>
    ''' btnEnter_Click - Will validate that the data entered into the controls is appropriate.
    '''                - Once the data is validated a vehicle object will be create using the  
    '''                - parameterized constructor. It will also insert the new vehicle object
    '''                - into the vehicle List collection. It will also check to see if the data in
    '''                - the controls has been selected from the listview by the user. In that case
    '''                - it will need to update the data in the specific vehicle object and the 
    '''                - listview as well.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim vehicle As classVehicle                                                 ' declare a vehicle class
        Dim vehicleItem As ListViewItem                                             ' declare a ListViewItem Class

        ' validate the data in the form
        If IsValidInput() = True Then

            ' set the edit flag to true
            editMode = True

            lblResult.Text = "It worked"

            ' if the current vehicle identification number has a no value
            ' then this is not an existing item from the listview
            If currentVehicleIdentificationNumber.Trim.Length = 0 Then

                ' create a new vehicle object using the parameterized constructor
                vehicle = New classVehicle(cmbMake.Text, txtModel.Text, cmbYear.Text, txtPrice.Text, chkNew.Checked)

                ' add the vehicle to the vehicleList collection
                ' using the identoification number as the key
                ' which will make the vehicle object easier to
                ' find in the vehicleList collection later
                vehicleList.Add(vehicle.IdentificationNumber.ToString(), vehicle)

            Else
                ' if the current vehicle identification number has a value
                ' then the user has selected something from the list view
                ' so the data in the vehicle object in the vehicleList collection
                ' must be updated

                ' so get the vehicle from the vehicle collection
                ' using the selected key
                vehicle = CType(vehicleList.Item(currentVehicleIdentificationNumber), classVehicle)

                ' update the data in the specific object
                ' from the controls
                vehicle.Make = cmbMake.Text
                vehicle.Model = txtModel.Text
                vehicle.Year = cmbYear.Text
                vehicle.Price = txtPrice.Text
                vehicle.newStatus = chkNew.Checked

            End If

            ' clear the items from the listview control
            lvwVehicles.Items.Clear()

            ' loop through the vehicleList collection
            ' and populate the list view
            For Each vehicleEntry As DictionaryEntry In vehicleList

                ' instantiate a new ListViewItem
                vehicleItem = New ListViewItem()

                ' get the vehicle from the list
                vehicle = CType(vehicleEntry.Value, classVehicle)

                ' assign the values to the ckecked control
                ' and the subitems
                vehicleItem.Checked = vehicle.newStatus
                vehicleItem.SubItems.Add(vehicle.IdentificationNumber.ToString())
                vehicleItem.SubItems.Add(vehicle.Make)
                vehicleItem.SubItems.Add(vehicle.Model)
                vehicleItem.SubItems.Add(vehicle.Year)
                vehicleItem.SubItems.Add(FormatCurrency(vehicle.Price.ToString))


                ' add the new instantiated and populated ListViewItem
                ' to the listview control
                lvwVehicles.Items.Add(vehicleItem)

            Next vehicleEntry


            ' clear the controls
            Reset()

            ' set the edit flag to false
            editMode = False

        End If

    End Sub

    ''' <summary>
    ''' Reset - set the controls back to their default state.
    ''' </summary>
    Private Sub Reset()


        txtModel.Text = String.Empty
        txtPrice.Text = String.Empty
        chkNew.Checked = False
        cmbMake.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        lblResult.Text = String.Empty

        currentVehicleIdentificationNumber = String.Empty

    End Sub
    Private Function IsValidInput() As Boolean
        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty

        'Check if Make has been selected
        If cmbMake.SelectedIndex = -1 Then
            outputMessage += "Please select the Vehicle Make." & vbCrLf

            returnValue = False
        End If

        'Check if Model has been entered
        If txtModel.Text.Trim.Length = 0 Then
            outputMessage += "Please enter the Vehicle Model." & vbCrLf

            returnValue = False
        End If

        'Check if Year has been selected
        If cmbYear.SelectedIndex = -1 Then
            outputMessage += "Please select the Year of Vehicle." & vbCrLf

            returnValue = False
        End If

        'Check if Price has been entered
        If txtPrice.Text.Trim.Length = 0 Then
            outputMessage += "Please enter the Price of Vehicle." & vbCrLf

            returnValue = False
        End If

        'Check to see if any value did not validate
        If returnValue = False Then

            lblResult.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        'return  the boolean value
        Return returnValue

    End Function

    ''' <summary>
    ''' The code in the btnReset_Click EventHandler will clear the form and set
    ''' focus back to the input text box. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    ''' <summary>
    ''' The code in the btnExit_Click EventHandler will close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' lvwCustomers_ItemCheck - user to prevent the user from checking the check box in the list view if it is not in edit mode.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwVehicles_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwVehicles.ItemCheck

        If editMode = False Then
            e.NewValue = e.CurrentValue
        End If
    End Sub
    ''' <summary>
    ''' lvwVehicles_SelectedIndexChange - when the user selected a row in the list it will pipulate the fields of editing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwVehicles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwVehicles.SelectedIndexChanged
        'constant that represents the index o the duitem in the list that holds the vehicle identification number
        Const identificationSubItemIndex As Integer = 1

        'Get the vehicle identification number
        currentVehicleIdentificationNumber = lvwVehicles.Items(lvwVehicles.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        'User the vehicle identification number to get the vehicle from the collection object
        Dim vehicle As classVehicle = CType(vehicleList.Item(currentVehicleIdentificationNumber), classVehicle)

        'set the controls on the form
        cmbMake.Text = vehicle.Make
        txtModel.Text = vehicle.Model
        cmbYear.Text = vehicle.Year
        txtPrice.Text = vehicle.Price
        chkNew.Checked = vehicle.newStatus


        lblResult.Text = vehicle.GetSalutation()

    End Sub
End Class
