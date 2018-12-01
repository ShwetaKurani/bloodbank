Imports System.Windows.Forms

Public Class frmHome

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    'Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    'End Sub

    'Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    'End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub FileMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RecToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecToolStripMenuItem.Click


    End Sub

    Private Sub DonorDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonorDetailsToolStripMenuItem.Click





    End Sub

    Private Sub PurchasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchasesToolStripMenuItem.Click



    End Sub

    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click



    End Sub

    Private Sub frmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click
        frmSearch.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click


    End Sub

    Private Sub AddProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddProductToolStripMenuItem.Click
        frmAddProduct.ShowDialog()
    End Sub

    Private Sub AddDonorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDonorToolStripMenuItem.Click
        frmDonor.ShowDialog()
    End Sub

    Private Sub AddRecipientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRecipientToolStripMenuItem.Click
        frmPatient.ShowDialog()
    End Sub

    Private Sub AddPurchasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPurchasesToolStripMenuItem.Click
        frmPurchases.ShowDialog()
    End Sub

    Private Sub AddSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSalesToolStripMenuItem.Click

        frmSales.ShowDialog()

    End Sub

    Private Sub UpdateProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateProductToolStripMenuItem.Click

        frmUpdateProduct.ShowDialog()

    End Sub

    Private Sub AddSalesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSalesToolStripMenuItem1.Click
        frmProductSales.ShowDialog()

    End Sub

    Private Sub SalesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem1.Click


        Dim obj As New frmViewReport
        obj.View_Report("select * from tbl_Sales", "BloodSales")
        obj.ShowDialog()


    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click


        Dim obj As New frmViewReport
        obj.View_Report("select * from tbl_ProductSales", "ProductSales")
        obj.ShowDialog()


    End Sub

    Private Sub PurchasesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchasesToolStripMenuItem1.Click
        Dim obj As New frmViewReport
        obj.View_Report("select * from tbl_Purchases", "Purchase")
        obj.ShowDialog()
    End Sub

    Private Sub DonorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonorsToolStripMenuItem.Click
        Dim obj As New frmViewReport
        obj.View_Report("select * from tbl_DonorDetails", "Donor")
        obj.ShowDialog()
    End Sub

    Private Sub RecipientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecipientsToolStripMenuItem.Click
        Dim obj As New frmViewReport
        obj.View_Report("select * from tbl_RecipientDetails", "Recipient")
        obj.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub UpdateSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmUpdateSales.MdiParent = Me
        frmUpdateSales.Show()
    End Sub
End Class
