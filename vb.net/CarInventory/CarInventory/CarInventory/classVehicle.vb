Option Strict On
Public Class classVehicle

    Private Shared vehicleCount As Integer                  ' static or shared private variable to hold the number of vehicle
    Private vehicleIdentification As Integer = 0            ' private variable to hold the vehicle's identification number
    Private vehicleMake As String = String.Empty            ' private variable to hold the vehicle's make
    Private vehicleModel As String = String.Empty           ' private variable to hold the vehicle's model
    Private vehicleYear As String = String.Empty            ' private variable to hold the vehicle's year
    Private vehiclePrice As String = String.Empty           ' private variable to hold the vehicle's price
    Private vehicleNewStatus As Boolean = False             ' private variable to hold the vehicle status

    ''' <summary>
    ''' Constructor - Default - creates a new vehicle object
    ''' </summary>
    Public Sub New()

        vehicleCount += 1                                   ' increment the shared/static variable counter by 1
        vehicleIdentification = vehicleCount                ' assign the vehicle id

    End Sub

    ''' <summary>
    ''' Constuctor - Parameterized - creates a new vehicle object
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="year"></param>
    ''' <param name="price"></param>
    ''' <param name="newStatus"></param>
    Public Sub New(make As String, model As String, year As String, price As String, newStatus As Boolean)

        Me.New()

        vehicleMake = make
        vehicleModel = model
        vehicleYear = year
        vehiclePrice = price
        vehicleNewStatus = newStatus
    End Sub

    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of vehicles that have been instantiated/created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return vehicleCount
        End Get
    End Property

    ''' <summary>
    ''' IdentificationNumber ReadOnly Property - Gets a specific vehicle identification number
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return vehicleIdentification
        End Get
    End Property

    ''' <summary>
    ''' NewStatus Property - >Gets and Sets the New status of a Vehicle
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property newStatus() As Boolean
        Get
            Return vehicleNewStatus
        End Get
        Set(ByVal value As Boolean)
            vehicleNewStatus = value
        End Set
    End Property

    ''' <summary>
    ''' Make property - Gets and Sets the Make of a Vehicle
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Make() As String
        Get
            Return vehicleMake
        End Get
        Set(ByVal value As String)
            vehicleMake = value
        End Set
    End Property

    ''' <summary>
    ''' Model property - Gets and Sets the Model of a Vehicle
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Model As String
        Get
            Return vehicleModel
        End Get
        Set(ByVal value As String)
            vehicleModel = value
        End Set
    End Property


    ''' <summary>
    ''' Year property - Gets and Sets the Year of a Vehicle
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Year() As String
        Get
            Return vehicleYear
        End Get
        Set(ByVal value As String)
            vehicleYear = value
        End Set
    End Property

    ''' <summary>
    ''' Price property - Gets and Sets the Price of a Vehicle
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Price() As String
        Get
            Return vehiclePrice
        End Get
        Set(ByVal value As String)
            vehiclePrice = value
        End Set
    End Property

    ''' <summary>
    ''' GetSalutation is a function that a salutation based on the private properties within the class scope
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetSalutation() As String

        Return "It worked".ToString()

    End Function

End Class
