<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtProductRate = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboBrand = New System.Windows.Forms.ComboBox()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtProductSrno = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCloseProduct = New System.Windows.Forms.Button()
        Me.btnClearProduct = New System.Windows.Forms.Button()
        Me.btnSaveProduct = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cboUpdateProduct = New System.Windows.Forms.ComboBox()
        Me.txtUpdateRate = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboUpdateBrand = New System.Windows.Forms.ComboBox()
        Me.cboUpdateDepartment = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnCloseUpdate = New System.Windows.Forms.Button()
        Me.btnProductClear = New System.Windows.Forms.Button()
        Me.btnUpdateProduct = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnDeletePurchases = New System.Windows.Forms.Button()
        Me.btnPurchaseUpdateSave = New System.Windows.Forms.Button()
        Me.btnPurchaseUpdate = New System.Windows.Forms.Button()
        Me.txtPurchaseAmount = New System.Windows.Forms.TextBox()
        Me.txtPurchaseQuantity = New System.Windows.Forms.TextBox()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.dtpPurchaseDate = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboPurchaseProduct = New System.Windows.Forms.ComboBox()
        Me.txtPurchaseRate = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboPurchaseBrand = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtPurchaseSrno = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnClosePurchases = New System.Windows.Forms.Button()
        Me.btnClearPurchases = New System.Windows.Forms.Button()
        Me.btnSavePurchases = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(10, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(381, 386)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(373, 360)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Add Product"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(129, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Add Product"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtProductRate)
        Me.Panel3.Controls.Add(Me.txtProductName)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.cboBrand)
        Me.Panel3.Controls.Add(Me.cboDepartment)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtProductSrno)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.btnCloseProduct)
        Me.Panel3.Controls.Add(Me.btnClearProduct)
        Me.Panel3.Controls.Add(Me.btnSaveProduct)
        Me.Panel3.Location = New System.Drawing.Point(6, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(364, 295)
        Me.Panel3.TabIndex = 1
        '
        'txtProductRate
        '
        Me.txtProductRate.Location = New System.Drawing.Point(131, 201)
        Me.txtProductRate.Name = "txtProductRate"
        Me.txtProductRate.Size = New System.Drawing.Size(195, 20)
        Me.txtProductRate.TabIndex = 3
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(131, 157)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(195, 20)
        Me.txtProductName.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(30, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Product Rate"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(30, 157)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Product Name"
        '
        'cboBrand
        '
        Me.cboBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBrand.FormattingEnabled = True
        Me.cboBrand.Location = New System.Drawing.Point(131, 114)
        Me.cboBrand.Name = "cboBrand"
        Me.cboBrand.Size = New System.Drawing.Size(195, 21)
        Me.cboBrand.TabIndex = 1
        '
        'cboDepartment
        '
        Me.cboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(131, 69)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(195, 21)
        Me.cboDepartment.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Brand"
        '
        'txtProductSrno
        '
        Me.txtProductSrno.Location = New System.Drawing.Point(131, 26)
        Me.txtProductSrno.Name = "txtProductSrno"
        Me.txtProductSrno.ReadOnly = True
        Me.txtProductSrno.Size = New System.Drawing.Size(195, 20)
        Me.txtProductSrno.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Department"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(30, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Serial No."
        '
        'btnCloseProduct
        '
        Me.btnCloseProduct.Image = CType(resources.GetObject("btnCloseProduct.Image"), System.Drawing.Image)
        Me.btnCloseProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCloseProduct.Location = New System.Drawing.Point(252, 248)
        Me.btnCloseProduct.Name = "btnCloseProduct"
        Me.btnCloseProduct.Size = New System.Drawing.Size(75, 40)
        Me.btnCloseProduct.TabIndex = 6
        Me.btnCloseProduct.Text = "Close"
        Me.btnCloseProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCloseProduct.UseVisualStyleBackColor = True
        '
        'btnClearProduct
        '
        Me.btnClearProduct.Image = CType(resources.GetObject("btnClearProduct.Image"), System.Drawing.Image)
        Me.btnClearProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearProduct.Location = New System.Drawing.Point(144, 248)
        Me.btnClearProduct.Name = "btnClearProduct"
        Me.btnClearProduct.Size = New System.Drawing.Size(75, 40)
        Me.btnClearProduct.TabIndex = 5
        Me.btnClearProduct.Text = "Clear"
        Me.btnClearProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClearProduct.UseVisualStyleBackColor = True
        '
        'btnSaveProduct
        '
        Me.btnSaveProduct.Image = CType(resources.GetObject("btnSaveProduct.Image"), System.Drawing.Image)
        Me.btnSaveProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveProduct.Location = New System.Drawing.Point(33, 248)
        Me.btnSaveProduct.Name = "btnSaveProduct"
        Me.btnSaveProduct.Size = New System.Drawing.Size(75, 40)
        Me.btnSaveProduct.TabIndex = 4
        Me.btnSaveProduct.Text = "Save"
        Me.btnSaveProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveProduct.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.Panel4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(373, 360)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Update Product"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(114, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Update Product"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.cboUpdateProduct)
        Me.Panel4.Controls.Add(Me.txtUpdateRate)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.cboUpdateBrand)
        Me.Panel4.Controls.Add(Me.cboUpdateDepartment)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.btnCloseUpdate)
        Me.Panel4.Controls.Add(Me.btnProductClear)
        Me.Panel4.Controls.Add(Me.btnUpdateProduct)
        Me.Panel4.Location = New System.Drawing.Point(6, 32)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(364, 294)
        Me.Panel4.TabIndex = 0
        '
        'cboUpdateProduct
        '
        Me.cboUpdateProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboUpdateProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUpdateProduct.FormattingEnabled = True
        Me.cboUpdateProduct.Location = New System.Drawing.Point(135, 141)
        Me.cboUpdateProduct.Name = "cboUpdateProduct"
        Me.cboUpdateProduct.Size = New System.Drawing.Size(195, 21)
        Me.cboUpdateProduct.TabIndex = 2
        '
        'txtUpdateRate
        '
        Me.txtUpdateRate.Location = New System.Drawing.Point(135, 188)
        Me.txtUpdateRate.Name = "txtUpdateRate"
        Me.txtUpdateRate.Size = New System.Drawing.Size(195, 20)
        Me.txtUpdateRate.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(34, 188)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Product Rate"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(34, 141)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Product Name"
        '
        'cboUpdateBrand
        '
        Me.cboUpdateBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboUpdateBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUpdateBrand.FormattingEnabled = True
        Me.cboUpdateBrand.Location = New System.Drawing.Point(135, 89)
        Me.cboUpdateBrand.Name = "cboUpdateBrand"
        Me.cboUpdateBrand.Size = New System.Drawing.Size(195, 21)
        Me.cboUpdateBrand.TabIndex = 1
        '
        'cboUpdateDepartment
        '
        Me.cboUpdateDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboUpdateDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUpdateDepartment.FormattingEnabled = True
        Me.cboUpdateDepartment.Location = New System.Drawing.Point(135, 38)
        Me.cboUpdateDepartment.Name = "cboUpdateDepartment"
        Me.cboUpdateDepartment.Size = New System.Drawing.Size(195, 21)
        Me.cboUpdateDepartment.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(34, 89)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Brand"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(34, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Department"
        '
        'btnCloseUpdate
        '
        Me.btnCloseUpdate.Image = CType(resources.GetObject("btnCloseUpdate.Image"), System.Drawing.Image)
        Me.btnCloseUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCloseUpdate.Location = New System.Drawing.Point(252, 247)
        Me.btnCloseUpdate.Name = "btnCloseUpdate"
        Me.btnCloseUpdate.Size = New System.Drawing.Size(75, 40)
        Me.btnCloseUpdate.TabIndex = 6
        Me.btnCloseUpdate.Text = "Close"
        Me.btnCloseUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCloseUpdate.UseVisualStyleBackColor = True
        '
        'btnProductClear
        '
        Me.btnProductClear.Image = CType(resources.GetObject("btnProductClear.Image"), System.Drawing.Image)
        Me.btnProductClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductClear.Location = New System.Drawing.Point(144, 247)
        Me.btnProductClear.Name = "btnProductClear"
        Me.btnProductClear.Size = New System.Drawing.Size(75, 40)
        Me.btnProductClear.TabIndex = 5
        Me.btnProductClear.Text = "Clear"
        Me.btnProductClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProductClear.UseVisualStyleBackColor = True
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.Image = CType(resources.GetObject("btnUpdateProduct.Image"), System.Drawing.Image)
        Me.btnUpdateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateProduct.Location = New System.Drawing.Point(33, 247)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.Size = New System.Drawing.Size(75, 40)
        Me.btnUpdateProduct.TabIndex = 4
        Me.btnUpdateProduct.Text = "Update"
        Me.btnUpdateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateProduct.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label6)
        Me.TabPage5.Controls.Add(Me.Panel5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(373, 360)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Purchases"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(137, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 18)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Purchases"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.btnDeletePurchases)
        Me.Panel5.Controls.Add(Me.btnPurchaseUpdateSave)
        Me.Panel5.Controls.Add(Me.btnPurchaseUpdate)
        Me.Panel5.Controls.Add(Me.txtPurchaseAmount)
        Me.Panel5.Controls.Add(Me.txtPurchaseQuantity)
        Me.Panel5.Controls.Add(Me.cboSupplier)
        Me.Panel5.Controls.Add(Me.dtpPurchaseDate)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Controls.Add(Me.Label26)
        Me.Panel5.Controls.Add(Me.Label25)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.cboPurchaseProduct)
        Me.Panel5.Controls.Add(Me.txtPurchaseRate)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.cboPurchaseBrand)
        Me.Panel5.Controls.Add(Me.Label23)
        Me.Panel5.Controls.Add(Me.txtPurchaseSrno)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.btnClosePurchases)
        Me.Panel5.Controls.Add(Me.btnClearPurchases)
        Me.Panel5.Controls.Add(Me.btnSavePurchases)
        Me.Panel5.Location = New System.Drawing.Point(11, 26)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(351, 328)
        Me.Panel5.TabIndex = 0
        '
        'btnDeletePurchases
        '
        Me.btnDeletePurchases.Image = CType(resources.GetObject("btnDeletePurchases.Image"), System.Drawing.Image)
        Me.btnDeletePurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeletePurchases.Location = New System.Drawing.Point(178, 277)
        Me.btnDeletePurchases.Name = "btnDeletePurchases"
        Me.btnDeletePurchases.Size = New System.Drawing.Size(75, 40)
        Me.btnDeletePurchases.TabIndex = 47
        Me.btnDeletePurchases.Text = "Delete"
        Me.btnDeletePurchases.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeletePurchases.UseVisualStyleBackColor = True
        '
        'btnPurchaseUpdateSave
        '
        Me.btnPurchaseUpdateSave.Image = CType(resources.GetObject("btnPurchaseUpdateSave.Image"), System.Drawing.Image)
        Me.btnPurchaseUpdateSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPurchaseUpdateSave.Location = New System.Drawing.Point(90, 277)
        Me.btnPurchaseUpdateSave.Name = "btnPurchaseUpdateSave"
        Me.btnPurchaseUpdateSave.Size = New System.Drawing.Size(75, 40)
        Me.btnPurchaseUpdateSave.TabIndex = 46
        Me.btnPurchaseUpdateSave.Text = "Update"
        Me.btnPurchaseUpdateSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPurchaseUpdateSave.UseVisualStyleBackColor = True
        '
        'btnPurchaseUpdate
        '
        Me.btnPurchaseUpdate.Image = CType(resources.GetObject("btnPurchaseUpdate.Image"), System.Drawing.Image)
        Me.btnPurchaseUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPurchaseUpdate.Location = New System.Drawing.Point(7, 277)
        Me.btnPurchaseUpdate.Name = "btnPurchaseUpdate"
        Me.btnPurchaseUpdate.Size = New System.Drawing.Size(75, 40)
        Me.btnPurchaseUpdate.TabIndex = 45
        Me.btnPurchaseUpdate.Text = "Update"
        Me.btnPurchaseUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPurchaseUpdate.UseVisualStyleBackColor = True
        '
        'txtPurchaseAmount
        '
        Me.txtPurchaseAmount.Location = New System.Drawing.Point(127, 240)
        Me.txtPurchaseAmount.Name = "txtPurchaseAmount"
        Me.txtPurchaseAmount.ReadOnly = True
        Me.txtPurchaseAmount.Size = New System.Drawing.Size(195, 20)
        Me.txtPurchaseAmount.TabIndex = 6
        '
        'txtPurchaseQuantity
        '
        Me.txtPurchaseQuantity.Location = New System.Drawing.Point(127, 212)
        Me.txtPurchaseQuantity.Name = "txtPurchaseQuantity"
        Me.txtPurchaseQuantity.Size = New System.Drawing.Size(195, 20)
        Me.txtPurchaseQuantity.TabIndex = 5
        '
        'cboSupplier
        '
        Me.cboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(127, 76)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(195, 21)
        Me.cboSupplier.TabIndex = 1
        '
        'dtpPurchaseDate
        '
        Me.dtpPurchaseDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPurchaseDate.Location = New System.Drawing.Point(127, 41)
        Me.dtpPurchaseDate.Name = "dtpPurchaseDate"
        Me.dtpPurchaseDate.Size = New System.Drawing.Size(195, 20)
        Me.dtpPurchaseDate.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(26, 41)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(30, 13)
        Me.Label27.TabIndex = 44
        Me.Label27.Text = "Date"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(26, 76)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 13)
        Me.Label26.TabIndex = 43
        Me.Label26.Text = "Supplier"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(26, 240)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 13)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Amount"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(26, 212)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 13)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "Quantity"
        '
        'cboPurchaseProduct
        '
        Me.cboPurchaseProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPurchaseProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPurchaseProduct.FormattingEnabled = True
        Me.cboPurchaseProduct.Location = New System.Drawing.Point(127, 145)
        Me.cboPurchaseProduct.Name = "cboPurchaseProduct"
        Me.cboPurchaseProduct.Size = New System.Drawing.Size(195, 21)
        Me.cboPurchaseProduct.TabIndex = 3
        '
        'txtPurchaseRate
        '
        Me.txtPurchaseRate.Location = New System.Drawing.Point(127, 177)
        Me.txtPurchaseRate.Name = "txtPurchaseRate"
        Me.txtPurchaseRate.Size = New System.Drawing.Size(195, 20)
        Me.txtPurchaseRate.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(26, 177)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 13)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Product Rate"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(26, 145)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 13)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Product Name"
        '
        'cboPurchaseBrand
        '
        Me.cboPurchaseBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPurchaseBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPurchaseBrand.FormattingEnabled = True
        Me.cboPurchaseBrand.Location = New System.Drawing.Point(127, 113)
        Me.cboPurchaseBrand.Name = "cboPurchaseBrand"
        Me.cboPurchaseBrand.Size = New System.Drawing.Size(195, 21)
        Me.cboPurchaseBrand.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(26, 113)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 13)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "Brand"
        '
        'txtPurchaseSrno
        '
        Me.txtPurchaseSrno.Location = New System.Drawing.Point(127, 13)
        Me.txtPurchaseSrno.Name = "txtPurchaseSrno"
        Me.txtPurchaseSrno.ReadOnly = True
        Me.txtPurchaseSrno.Size = New System.Drawing.Size(195, 20)
        Me.txtPurchaseSrno.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(26, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 13)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Serial No."
        '
        'btnClosePurchases
        '
        Me.btnClosePurchases.Image = CType(resources.GetObject("btnClosePurchases.Image"), System.Drawing.Image)
        Me.btnClosePurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClosePurchases.Location = New System.Drawing.Point(267, 277)
        Me.btnClosePurchases.Name = "btnClosePurchases"
        Me.btnClosePurchases.Size = New System.Drawing.Size(75, 40)
        Me.btnClosePurchases.TabIndex = 11
        Me.btnClosePurchases.Text = "Close"
        Me.btnClosePurchases.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClosePurchases.UseVisualStyleBackColor = True
        '
        'btnClearPurchases
        '
        Me.btnClearPurchases.Image = CType(resources.GetObject("btnClearPurchases.Image"), System.Drawing.Image)
        Me.btnClearPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearPurchases.Location = New System.Drawing.Point(178, 277)
        Me.btnClearPurchases.Name = "btnClearPurchases"
        Me.btnClearPurchases.Size = New System.Drawing.Size(75, 40)
        Me.btnClearPurchases.TabIndex = 10
        Me.btnClearPurchases.Text = "Clear"
        Me.btnClearPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClearPurchases.UseVisualStyleBackColor = True
        '
        'btnSavePurchases
        '
        Me.btnSavePurchases.Image = CType(resources.GetObject("btnSavePurchases.Image"), System.Drawing.Image)
        Me.btnSavePurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSavePurchases.Location = New System.Drawing.Point(90, 277)
        Me.btnSavePurchases.Name = "btnSavePurchases"
        Me.btnSavePurchases.Size = New System.Drawing.Size(75, 40)
        Me.btnSavePurchases.TabIndex = 9
        Me.btnSavePurchases.Text = "Save"
        Me.btnSavePurchases.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSavePurchases.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(136, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Inventory"
        '
        'pnlSearch
        '
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSearch.Controls.Add(Me.dgvSearch)
        Me.pnlSearch.Location = New System.Drawing.Point(10, 44)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(389, 303)
        Me.pnlSearch.TabIndex = 48
        '
        'dgvSearch
        '
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Location = New System.Drawing.Point(12, 11)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(361, 287)
        Me.dgvSearch.TabIndex = 0
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 425)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInventory"
        Me.Text = "frmInventory"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents btnCloseProduct As System.Windows.Forms.Button
    Private WithEvents btnClearProduct As System.Windows.Forms.Button
    Private WithEvents btnSaveProduct As System.Windows.Forms.Button
    Private WithEvents btnCloseUpdate As System.Windows.Forms.Button
    Private WithEvents btnProductClear As System.Windows.Forms.Button
    Private WithEvents btnUpdateProduct As System.Windows.Forms.Button
    Private WithEvents btnClosePurchases As System.Windows.Forms.Button
    Private WithEvents btnClearPurchases As System.Windows.Forms.Button
    Private WithEvents btnSavePurchases As System.Windows.Forms.Button
    Friend WithEvents txtProductSrno As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboBrand As System.Windows.Forms.ComboBox
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtProductRate As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdateRate As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboUpdateBrand As System.Windows.Forms.ComboBox
    Friend WithEvents cboUpdateDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboUpdateProduct As System.Windows.Forms.ComboBox
    Friend WithEvents cboPurchaseProduct As System.Windows.Forms.ComboBox
    Friend WithEvents txtPurchaseRate As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboPurchaseBrand As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtPurchaseSrno As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents dtpPurchaseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents txtPurchaseQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtPurchaseAmount As System.Windows.Forms.TextBox
    Private WithEvents btnPurchaseUpdate As System.Windows.Forms.Button
    Private WithEvents btnPurchaseUpdateSave As System.Windows.Forms.Button
    Private WithEvents btnDeletePurchases As System.Windows.Forms.Button
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
End Class
