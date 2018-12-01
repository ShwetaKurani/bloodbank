<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDonor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDonor))
        Me.pnlSearch = New System.Windows.Forms.Panel
        Me.dgvSearch = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDonorID = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.cboBloodGroup = New System.Windows.Forms.ComboBox
        Me.rtbAddress = New System.Windows.Forms.RichTextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboGender = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDonorType = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtHIV = New System.Windows.Forms.TextBox
        Me.txtHemoglobin = New System.Windows.Forms.TextBox
        Me.txtPhysicalTest = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnSaveUpdate = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.pnlSearch.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.dgvSearch)
        Me.pnlSearch.Location = New System.Drawing.Point(116, 66)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(366, 329)
        Me.pnlSearch.TabIndex = 1
        '
        'dgvSearch
        '
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Location = New System.Drawing.Point(27, 21)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(290, 252)
        Me.dgvSearch.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Donor ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Blood Group"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contact No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Age"
        '
        'txtDonorID
        '
        Me.txtDonorID.Location = New System.Drawing.Point(137, 46)
        Me.txtDonorID.Name = "txtDonorID"
        Me.txtDonorID.ReadOnly = True
        Me.txtDonorID.Size = New System.Drawing.Size(180, 20)
        Me.txtDonorID.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(137, 84)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 20)
        Me.txtName.TabIndex = 1
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(447, 235)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(180, 20)
        Me.txtContact.TabIndex = 10
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(137, 120)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(180, 20)
        Me.txtAge.TabIndex = 2
        '
        'cboBloodGroup
        '
        Me.cboBloodGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboBloodGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBloodGroup.FormattingEnabled = True
        Me.cboBloodGroup.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.cboBloodGroup.Location = New System.Drawing.Point(137, 201)
        Me.cboBloodGroup.Name = "cboBloodGroup"
        Me.cboBloodGroup.Size = New System.Drawing.Size(180, 21)
        Me.cboBloodGroup.TabIndex = 4
        '
        'rtbAddress
        '
        Me.rtbAddress.Location = New System.Drawing.Point(444, 156)
        Me.rtbAddress.Name = "rtbAddress"
        Me.rtbAddress.Size = New System.Drawing.Size(180, 50)
        Me.rtbAddress.TabIndex = 9
        Me.rtbAddress.Text = ""
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(297, 301)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 33)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(388, 301)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 33)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(388, 350)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Gender"
        '
        'cboGender
        '
        Me.cboGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(137, 156)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(180, 21)
        Me.cboGender.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Donor Type"
        '
        'txtDonorType
        '
        Me.txtDonorType.Location = New System.Drawing.Point(137, 254)
        Me.txtDonorType.Name = "txtDonorType"
        Me.txtDonorType.Size = New System.Drawing.Size(180, 20)
        Me.txtDonorType.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(137, 25)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(180, 20)
        Me.dtpDate.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(340, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "HIV Status"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(340, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Hemoglobin EST"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(340, 110)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Physical Exam"
        '
        'txtHIV
        '
        Me.txtHIV.Location = New System.Drawing.Point(447, 29)
        Me.txtHIV.Name = "txtHIV"
        Me.txtHIV.Size = New System.Drawing.Size(180, 20)
        Me.txtHIV.TabIndex = 6
        '
        'txtHemoglobin
        '
        Me.txtHemoglobin.Location = New System.Drawing.Point(444, 72)
        Me.txtHemoglobin.Name = "txtHemoglobin"
        Me.txtHemoglobin.Size = New System.Drawing.Size(180, 20)
        Me.txtHemoglobin.TabIndex = 7
        '
        'txtPhysicalTest
        '
        Me.txtPhysicalTest.Location = New System.Drawing.Point(444, 110)
        Me.txtPhysicalTest.Name = "txtPhysicalTest"
        Me.txtPhysicalTest.Size = New System.Drawing.Size(180, 20)
        Me.txtPhysicalTest.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Blood_Bank_Management_System.My.Resources.Resources._16469251
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnSaveUpdate)
        Me.Panel1.Controls.Add(Me.txtPhysicalTest)
        Me.Panel1.Controls.Add(Me.txtHemoglobin)
        Me.Panel1.Controls.Add(Me.txtHIV)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.dtpDate)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtDonorType)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cboGender)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.rtbAddress)
        Me.Panel1.Controls.Add(Me.cboBloodGroup)
        Me.Panel1.Controls.Add(Me.txtAge)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.txtDonorID)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 486)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(642, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 135)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(388, 301)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 33)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(489, 301)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 33)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSaveUpdate
        '
        Me.btnSaveUpdate.Location = New System.Drawing.Point(297, 301)
        Me.btnSaveUpdate.Name = "btnSaveUpdate"
        Me.btnSaveUpdate.Size = New System.Drawing.Size(75, 33)
        Me.btnSaveUpdate.TabIndex = 11
        Me.btnSaveUpdate.Text = "Update"
        Me.btnSaveUpdate.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(316, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Donor"
        '
        'frmDonor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 538)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmDonor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donor"
        Me.pnlSearch.ResumeLayout(False)
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDonorID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents cboBloodGroup As System.Windows.Forms.ComboBox
    Friend WithEvents rtbAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDonorType As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtHIV As System.Windows.Forms.TextBox
    Friend WithEvents txtHemoglobin As System.Windows.Forms.TextBox
    Friend WithEvents txtPhysicalTest As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSaveUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
