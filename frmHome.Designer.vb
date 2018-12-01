<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.DonorDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRecipientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPurchasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSalesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecipientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PranaliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonorDetailsToolStripMenuItem, Me.RecToolStripMenuItem, Me.ToolStripMenuItem1, Me.PurchasesToolStripMenuItem, Me.SalesToolStripMenuItem, Me.ToolStripMenuItem2, Me.ReportsToolStripMenuItem, Me.ReportsToolStripMenuItem1, Me.LogoutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(899, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'DonorDetailsToolStripMenuItem
        '
        Me.DonorDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDonorToolStripMenuItem, Me.PranaliToolStripMenuItem})
        Me.DonorDetailsToolStripMenuItem.Name = "DonorDetailsToolStripMenuItem"
        Me.DonorDetailsToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.DonorDetailsToolStripMenuItem.Text = "Donor Details"
        '
        'AddDonorToolStripMenuItem
        '
        Me.AddDonorToolStripMenuItem.Name = "AddDonorToolStripMenuItem"
        Me.AddDonorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddDonorToolStripMenuItem.Text = "Add Donor"
        '
        'RecToolStripMenuItem
        '
        Me.RecToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRecipientToolStripMenuItem})
        Me.RecToolStripMenuItem.Name = "RecToolStripMenuItem"
        Me.RecToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.RecToolStripMenuItem.Text = "Recipient Details"
        '
        'AddRecipientToolStripMenuItem
        '
        Me.AddRecipientToolStripMenuItem.Name = "AddRecipientToolStripMenuItem"
        Me.AddRecipientToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddRecipientToolStripMenuItem.Text = "Add Recipient"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProductToolStripMenuItem, Me.UpdateProductToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(114, 20)
        Me.ToolStripMenuItem1.Text = "Product Inventory"
        '
        'AddProductToolStripMenuItem
        '
        Me.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem"
        Me.AddProductToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AddProductToolStripMenuItem.Text = "Add Product"
        '
        'UpdateProductToolStripMenuItem
        '
        Me.UpdateProductToolStripMenuItem.Name = "UpdateProductToolStripMenuItem"
        Me.UpdateProductToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.UpdateProductToolStripMenuItem.Text = "Update Product"
        '
        'PurchasesToolStripMenuItem
        '
        Me.PurchasesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPurchasesToolStripMenuItem})
        Me.PurchasesToolStripMenuItem.Name = "PurchasesToolStripMenuItem"
        Me.PurchasesToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.PurchasesToolStripMenuItem.Text = "Blood Donation"
        '
        'AddPurchasesToolStripMenuItem
        '
        Me.AddPurchasesToolStripMenuItem.Name = "AddPurchasesToolStripMenuItem"
        Me.AddPurchasesToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AddPurchasesToolStripMenuItem.Text = "Add Purchases "
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSalesToolStripMenuItem})
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.SalesToolStripMenuItem.Text = "Blood Bag Sales"
        '
        'AddSalesToolStripMenuItem
        '
        Me.AddSalesToolStripMenuItem.Name = "AddSalesToolStripMenuItem"
        Me.AddSalesToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AddSalesToolStripMenuItem.Text = "Blood Sales"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSalesToolStripMenuItem1})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(90, 20)
        Me.ToolStripMenuItem2.Text = "Product Sales"
        '
        'AddSalesToolStripMenuItem1
        '
        Me.AddSalesToolStripMenuItem1.Name = "AddSalesToolStripMenuItem1"
        Me.AddSalesToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.AddSalesToolStripMenuItem1.Text = "Add Sales"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportsToolStripMenuItem.Text = "Search"
        '
        'ReportsToolStripMenuItem1
        '
        Me.ReportsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem1, Me.ToolStripMenuItem3, Me.PurchasesToolStripMenuItem1, Me.DonorsToolStripMenuItem, Me.RecipientsToolStripMenuItem})
        Me.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        Me.ReportsToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem1.Text = "Reports"
        '
        'SalesToolStripMenuItem1
        '
        Me.SalesToolStripMenuItem1.Name = "SalesToolStripMenuItem1"
        Me.SalesToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.SalesToolStripMenuItem1.Text = "Blood Bag Sales"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(157, 22)
        Me.ToolStripMenuItem3.Text = "Product Sales"
        '
        'PurchasesToolStripMenuItem1
        '
        Me.PurchasesToolStripMenuItem1.Name = "PurchasesToolStripMenuItem1"
        Me.PurchasesToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.PurchasesToolStripMenuItem1.Text = "Purchases"
        '
        'DonorsToolStripMenuItem
        '
        Me.DonorsToolStripMenuItem.Name = "DonorsToolStripMenuItem"
        Me.DonorsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DonorsToolStripMenuItem.Text = "Donors"
        '
        'RecipientsToolStripMenuItem
        '
        Me.RecipientsToolStripMenuItem.Name = "RecipientsToolStripMenuItem"
        Me.RecipientsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.RecipientsToolStripMenuItem.Text = "Recipients"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(899, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'PranaliToolStripMenuItem
        '
        Me.PranaliToolStripMenuItem.Name = "PranaliToolStripMenuItem"
        Me.PranaliToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PranaliToolStripMenuItem.Text = "pranali"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Blood_Bank_Management_System.My.Resources.Resources._2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(899, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHome"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents DonorDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddDonorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRecipientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPurchasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchasesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecipientsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSalesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PranaliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
