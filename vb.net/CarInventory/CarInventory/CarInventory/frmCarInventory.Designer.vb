<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lvwVehicles = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblResult = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.CarInventoryToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(12, 15)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(74, 23)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarInventoryToolTip.SetToolTip(Me.lblMake, "Make of the Car")
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(12, 57)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(74, 23)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarInventoryToolTip.SetToolTip(Me.lblModel, "Model of the Car")
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(12, 99)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(74, 23)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarInventoryToolTip.SetToolTip(Me.lblYear, "Year of the Car")
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(12, 141)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(74, 23)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarInventoryToolTip.SetToolTip(Me.lblPrice, "Price of the Car")
        '
        'lvwVehicles
        '
        Me.lvwVehicles.CheckBoxes = True
        Me.lvwVehicles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colId, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwVehicles.FullRowSelect = True
        Me.lvwVehicles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwVehicles.Location = New System.Drawing.Point(12, 218)
        Me.lvwVehicles.MultiSelect = False
        Me.lvwVehicles.Name = "lvwVehicles"
        Me.lvwVehicles.Size = New System.Drawing.Size(519, 194)
        Me.lvwVehicles.TabIndex = 9
        Me.CarInventoryToolTip.SetToolTip(Me.lvwVehicles, "List of Vehilces Entered")
        Me.lvwVehicles.UseCompatibleStateImageBehavior = False
        Me.lvwVehicles.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 70
        '
        'colId
        '
        Me.colId.Text = "ID"
        Me.colId.Width = 42
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 122
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(12, 425)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(519, 139)
        Me.lblResult.TabIndex = 10
        Me.CarInventoryToolTip.SetToolTip(Me.lblResult, "Result Displayed")
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Porsche", "Ferrari", "Hyundai", "Maserati"})
        Me.cmbMake.Location = New System.Drawing.Point(126, 15)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 24)
        Me.cmbMake.TabIndex = 1
        Me.CarInventoryToolTip.SetToolTip(Me.cmbMake, "Choose Make of the Car")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(126, 57)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 22)
        Me.txtModel.TabIndex = 3
        Me.CarInventoryToolTip.SetToolTip(Me.txtModel, "Enter Model of the Car")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(126, 141)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 22)
        Me.txtPrice.TabIndex = 7
        Me.CarInventoryToolTip.SetToolTip(Me.txtPrice, "Enter Price of the Car")
        '
        'cmbYear
        '
        Me.cmbYear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2019", "2018", "2017", "2016", "2015"})
        Me.cmbYear.Location = New System.Drawing.Point(126, 98)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 24)
        Me.cmbYear.TabIndex = 5
        Me.CarInventoryToolTip.SetToolTip(Me.cmbYear, "Choose Year of the Car")
        '
        'chkNew
        '
        Me.chkNew.AutoEllipsis = True
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(49, 179)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(95, 24)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "&New:"
        Me.CarInventoryToolTip.SetToolTip(Me.chkNew, "Check if the vehicle is new")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(201, 567)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(76, 38)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.CarInventoryToolTip.SetToolTip(Me.btnEnter, "Enter the Vehicle")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(330, 567)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(76, 38)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.CarInventoryToolTip.SetToolTip(Me.btnReset, "Reset the Application")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(455, 567)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 38)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.CarInventoryToolTip.SetToolTip(Me.btnExit, "Exit the Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(544, 617)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lvwVehicles)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(562, 664)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(562, 664)
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lvwVehicles As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colId As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents lblResult As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents CarInventoryToolTip As ToolTip
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
