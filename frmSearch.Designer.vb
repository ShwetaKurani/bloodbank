<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.cboSearchBy = New System.Windows.Forms.ComboBox
        Me.cboValue = New System.Windows.Forms.ComboBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.lblSales = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.lblFlag = New System.Windows.Forms.Label
        Me.btnViewReport = New System.Windows.Forms.Button
        Me.label3 = New System.Windows.Forms.Label
        Me.lblTo = New System.Windows.Forms.Label
        Me.lblFrom = New System.Windows.Forms.Label
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.dgvSearch = New System.Windows.Forms.DataGridView
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboSearchBy
        '
        Me.cboSearchBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboSearchBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"Donor Details", "Recipient Details", "Purchases", "Sales", "Stock"})
        Me.cboSearchBy.Location = New System.Drawing.Point(385, 28)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(210, 21)
        Me.cboSearchBy.TabIndex = 36
        '
        'cboValue
        '
        Me.cboValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboValue.FormattingEnabled = True
        Me.cboValue.Location = New System.Drawing.Point(385, 80)
        Me.cboValue.Name = "cboValue"
        Me.cboValue.Size = New System.Drawing.Size(210, 21)
        Me.cboValue.TabIndex = 38
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(533, 452)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 47)
        Me.btnClose.TabIndex = 44
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label1.Location = New System.Drawing.Point(286, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(56, 13)
        Me.label1.TabIndex = 35
        Me.label1.Text = "Search By"
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Location = New System.Drawing.Point(577, 436)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(0, 13)
        Me.lblSales.TabIndex = 49
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label2.Location = New System.Drawing.Point(286, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(37, 13)
        Me.label2.TabIndex = 37
        Me.label2.Text = "Select"
        '
        'lblFlag
        '
        Me.lblFlag.AutoSize = True
        Me.lblFlag.Location = New System.Drawing.Point(304, 63)
        Me.lblFlag.Name = "lblFlag"
        Me.lblFlag.Size = New System.Drawing.Size(0, 13)
        Me.lblFlag.TabIndex = 48
        Me.lblFlag.Visible = False
        '
        'btnViewReport
        '
        Me.btnViewReport.Location = New System.Drawing.Point(559, 115)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.Size = New System.Drawing.Size(101, 27)
        Me.btnViewReport.TabIndex = 41
        Me.btnViewReport.Text = "View Report"
        Me.btnViewReport.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label3.Location = New System.Drawing.Point(229, 125)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(63, 13)
        Me.label3.TabIndex = 47
        Me.label3.Text = "Select Date"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTo.Location = New System.Drawing.Point(431, 125)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 46
        Me.lblTo.Text = "To"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFrom.Location = New System.Drawing.Point(301, 126)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 45
        Me.lblFrom.Text = "From "
        '
        'dtpToDate
        '
        Me.dtpToDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToDate.Location = New System.Drawing.Point(454, 122)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.ShowCheckBox = True
        Me.dtpToDate.Size = New System.Drawing.Size(88, 20)
        Me.dtpToDate.TabIndex = 40
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromDate.Location = New System.Drawing.Point(338, 122)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.ShowCheckBox = True
        Me.dtpFromDate.Size = New System.Drawing.Size(88, 20)
        Me.dtpFromDate.TabIndex = 39
        '
        'dgvSearch
        '
        Me.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSearch.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Location = New System.Drawing.Point(72, 159)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.ReadOnly = True
        Me.dgvSearch.Size = New System.Drawing.Size(781, 274)
        Me.dgvSearch.TabIndex = 42
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 511)
        Me.Controls.Add(Me.cboSearchBy)
        Me.Controls.Add(Me.cboValue)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.lblFlag)
        Me.Controls.Add(Me.btnViewReport)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.dtpToDate)
        Me.Controls.Add(Me.dtpFromDate)
        Me.Controls.Add(Me.dgvSearch)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cboSearchBy As System.Windows.Forms.ComboBox
    Private WithEvents cboValue As System.Windows.Forms.ComboBox
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents lblSales As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents lblFlag As System.Windows.Forms.Label
    Private WithEvents btnViewReport As System.Windows.Forms.Button
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents lblTo As System.Windows.Forms.Label
    Private WithEvents lblFrom As System.Windows.Forms.Label
    Private WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Private WithEvents dgvSearch As System.Windows.Forms.DataGridView
End Class
