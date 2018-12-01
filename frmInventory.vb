Imports System.Data.SqlClient



Public Class frmInventory
    Dim con As New SqlConnection("Data Source=(local)\sqlexpress;AttachDbFilename=D:\MAAZ\maaz.mdf;Integrated Security=True")
    Dim id As Integer



    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim adapte1 = New SqlDataAdapter("select [Serial No]=Purchase_Srno,[Supplier]=Supplier_Name,[Purchase Date]=Purchase_Date,[Product]=Purchase_Product from tbl_Purchases", con)
        Dim ds As New DataSet
        adapte1.Fill(ds)
        dgvSearch.DataSource = ds.Tables(0)

        pnlSearch.Visible = False




        ProductSrno()
        purchaseIncre()
        loadPurchaseBrand()
        loadProductBrand()
        loadProductDepartment()
        updateDepartmentLoad()
        supplierLoad()

        btnPurchaseUpdateSave.Visible = False
        btnDeletePurchases.Visible = False


    End Sub
    Public Sub supplierLoad()


        con.Open()
        Dim cmd As New SqlCommand("select Supplier_Name from tbl_SupplierDetails", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            cboSupplier.Items.Add(rd(0))

        End While
        con.Close()

        'Dim adp = New SqlDataAdapter("select Supplier_Name, Supplier_ID from tbl_SupplierDetails", con)
        'Dim ds As New DataSet
        'adp.Fill(ds)
        'Dim dRow As New DataRow


        'DataSet ds = new DataSet();
        'adp.Fill(ds);

        'DataRow dr2 = ds.Tables[0].NewRow();	// create a new row into the dataset
        'dr2[0] = "Select";				// supply values
        'ds.Tables[0].Rows.InsertAt(dr2, 0);	// Insert the row at index 0

        'this.cboName.DataSource = ds.Tables[0];
        'this.cboName.DisplayMember = "Client_Name";
        'this.cboName.ValueMember = "Client_ID";

    End Sub

    Public Sub ProductSrno()
        con.Close()

        con.Open()

        Dim cmd As New SqlCommand("select Product_Srno from tbl_ProductDetails", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            id = rd(0)
        End While
        con.Close()
        id = id + 1
        txtProductSrno.Text = id
        con.Close()

    End Sub
    Public Sub purchaseIncre()
        Dim id1 As Integer
        con.Close()

        con.Open()

        Dim cmd As New SqlCommand("select Purchase_Srno from tbl_Purchases", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            id1 = rd(0)
        End While
        con.Close()
        id1 = id1 + 1
        txtPurchaseSrno.Text = id1
        con.Close()
    End Sub
    Public Sub loadProductDepartment()
        con.Open()
        Dim cmd As New SqlCommand("select Department_Name from tbl_Department", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            cboDepartment.Items.Add(rd(0))

        End While
        con.Close()

    End Sub
    Public Sub updateDepartmentLoad()
        con.Open()
        Dim cmd As New SqlCommand("select Department_Name from tbl_Department", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            cboUpdateDepartment.Items.Add(rd(0))

        End While
        con.Close()
    End Sub
    Public Sub loadProductBrand()
        con.Open()
        Dim cmd As New SqlCommand("select Brand_Name from tbl_Brand", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            cboBrand.Items.Add(rd(0))

        End While
        con.Close()

    End Sub
    Public Sub loadPurchaseBrand()
        con.Open()
        Dim cmd As New SqlCommand("select Brand_Name from tbl_Brand", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            cboPurchaseBrand.Items.Add(rd(0))

        End While
        con.Close()

    End Sub

    

    Private Sub btnCloseDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    

    Private Sub btnCloseBrand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    

    Private Sub btnCloseProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseProduct.Click
        Me.Close()

    End Sub

    Private Sub btnSaveProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveProduct.Click


        If ((txtProductName.Text = "") Or (cboDepartment.Text = "") Or (txtProductRate.Text = "") Or (cboBrand.Text = "")) Then
            MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation)
        Else
            con.Close()

            con.Open()
            Dim cmd As New SqlCommand("select Product_Name from tbl_ProductDetails where Product_Name='" & txtProductName.Text & "' ", con)

            Dim rd As SqlDataReader
            rd = cmd.ExecuteReader()

            If (rd.HasRows) Then
                MsgBox("Product Name Exist")
                con.Close()


            Else
                con.Close()

                con.Open()



                Dim s As String = "Insert into tbl_ProductDetails(Product_Srno,Product_Department,Product_Brand,Product_Name,Product_Rate) values('" & txtProductSrno.Text & "','" & cboDepartment.Text & "','" & cboBrand.Text & "','" & txtProductName.Text & "','" & txtProductRate.Text & "')"
                Dim cmd1 As New SqlCommand(s, con)
                cmd1.ExecuteNonQuery()
                MsgBox("Record Inserted")

                Product_Clear()


                ProductSrno()


                con.Close()

            End If


        End If


    End Sub
    Public Sub Product_Clear()
        txtProductName.Clear()
        txtProductRate.Clear()
        cboBrand.ResetText()
        cboDepartment.ResetText()

    End Sub

    Private Sub btnClearProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearProduct.Click
        Product_Clear()

    End Sub

    Private Sub cboUpdateDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUpdateDepartment.SelectedIndexChanged


        con.Open()
        Dim cmd As New SqlCommand("select distinct Product_Brand from tbl_ProductDetails where Product_Department='" & cboUpdateDepartment.Text & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            cboUpdateBrand.Items.Add(rd(0))

        End While
        con.Close()

    End Sub

    Private Sub cboUpdateBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUpdateBrand.SelectedIndexChanged

        con.Open()
        Dim cmd As New SqlCommand("select distinct Product_Name from tbl_ProductDetails where Product_Brand='" & cboUpdateBrand.Text & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            cboUpdateProduct.Items.Add(rd(0))

        End While
        con.Close()



    End Sub

    Private Sub cboUpdateProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUpdateProduct.SelectedIndexChanged

        con.Open()
        Dim cmd As New SqlCommand("select  Product_Rate from tbl_ProductDetails where Product_Name='" & cboUpdateProduct.Text & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            txtUpdateRate.Text = rd(0).ToString

        End While
        con.Close()


    End Sub

    Private Sub btnCloseUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseUpdate.Click
        Me.Close()

    End Sub

    Private Sub btnProductClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductClear.Click
        cboUpdateDepartment.ResetText()
        cboUpdateBrand.ResetText()
        cboUpdateProduct.ResetText()
        txtUpdateRate.Clear()

    End Sub

    Private Sub btnUpdateProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateProduct.Click
        If (cboUpdateProduct.Text = "") Then
            MsgBox("Please Select Product")
        Else

            con.Close()
            con.Open()

            Dim s As String = "update tbl_ProductDetails set Product_Rate='" & txtUpdateRate.Text & "' where Product_Name='" & cboUpdateProduct.Text & "'"
            Dim cmd1 As New SqlCommand(s, con)
            cmd1.ExecuteNonQuery()
            MsgBox("Record Updated")
            con.Close()
            cboUpdateDepartment.ResetText()
            cboUpdateBrand.ResetText()
            cboUpdateProduct.ResetText()
            txtUpdateRate.Clear()


        End If
        




    End Sub

    Private Sub cboPurchaseBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPurchaseBrand.SelectedIndexChanged
        con.Close()

        con.Open()
        Dim cmd As New SqlCommand("select distinct Product_Name from tbl_ProductDetails where Product_Brand='" & cboPurchaseBrand.Text & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            cboPurchaseProduct.Items.Add(rd(0))

        End While
        con.Close()
    End Sub

    Private Sub cboPurchaseProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPurchaseProduct.SelectedIndexChanged


        con.Open()
        Dim cmd As New SqlCommand("select  Product_Rate from tbl_ProductDetails where Product_Name='" & cboPurchaseProduct.Text & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            txtPurchaseRate.Text = rd(0).ToString

        End While
        con.Close()


    End Sub

    Private Sub txtPurchaseQuantity_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPurchaseQuantity.Leave

        Dim rate As Decimal
        Dim quantity As Decimal
        Dim amount As Decimal

        rate = txtPurchaseRate.Text
        quantity = txtPurchaseQuantity.Text
        amount = rate * quantity
        txtPurchaseAmount.Text = amount.ToString


    End Sub

    Private Sub btnClosePurchases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClosePurchases.Click
        Me.Close()

    End Sub

    Private Sub btnClearPurchases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearPurchases.Click
        purchaseClear()


    End Sub
    Public Sub purchaseClear()
        dtpPurchaseDate.ResetText()
        cboSupplier.ResetText()
        cboPurchaseBrand.ResetText()
        cboPurchaseProduct.ResetText()
        txtPurchaseRate.Clear()
        txtPurchaseQuantity.Clear()
        txtPurchaseAmount.Clear()
    End Sub

    Private Sub btnSavePurchases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePurchases.Click


        If ((cboSupplier.Text = "") Or (cboPurchaseBrand.Text = "") Or (cboPurchaseProduct.Text = "") Or (txtPurchaseQuantity.Text = "")) Then
            MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation)
        Else
            



            con.Close()

            con.Open()



            Dim s As String = "Insert into tbl_Purchases(Purchase_Srno,Purchase_Product,Purchase_Rate,Purchase_Quantity,Purchase_Amount,Supplier_Name,Purchase_Date) values('" & txtPurchaseSrno.Text & "','" & cboPurchaseProduct.Text & "','" & txtPurchaseRate.Text & "','" & txtPurchaseQuantity.Text & "','" & txtPurchaseAmount.Text & "','" & cboSupplier.Text & "','" & dtpPurchaseDate.Value.ToString & "')"
            Dim cmd1 As New SqlCommand(s, con)
            cmd1.ExecuteNonQuery()


            Dim str As String
            str = ""
            con.Close()

            con.Open()

            Dim cmd As New SqlCommand("select * from tbl_Stock where Stock_Product='" & cboPurchaseProduct.Text & "'", con)
            Dim rd As SqlDataReader
            rd = cmd.ExecuteReader()
            If (rd.HasRows) Then

                str = "true"
            Else
                str = "false"
            End If
            rd.Close()



            If (str = "true") Then

                'OleDbCommand(cmd2 = New OleDbCommand("update tbl_Stock set Product_Quantity=Product_Quantity+'" + txtQuantity.Text + "' where Product_Name='" + cboProductName.Text + "' and Product_Rate='" + txtRate.Text + "'", clsCon.con))
                'cmd2.ExecuteNonQuery()
                Dim cmd2 As New SqlCommand("update tbl_Stock set Stock_Quantity='" & txtPurchaseQuantity.Text & "' where Stock_Product='" & cboPurchaseProduct.Text & "'", con)
                cmd2.ExecuteNonQuery()


            Else
                Dim stock As String = "Insert into tbl_Stock(Stock_Product,Stock_Rate,Stock_Quantity)values('" & cboPurchaseProduct.Text & "','" & txtPurchaseRate.Text & "','" & txtPurchaseQuantity.Text & "')"
                Dim cmdStock As New SqlCommand(stock, con)
                cmdStock.ExecuteNonQuery()

            End If







            MsgBox("Record Inserted")

            purchaseClear()
            purchaseIncre()






            con.Close()




        End If





    End Sub

    Private Sub btnPurchaseUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchaseUpdate.Click

        pnlSearch.Visible = True
        TabControl1.Visible = False

        btnPurchaseUpdateSave.Visible = True
        btnSavePurchases.Visible = False
        btnClearPurchases.Visible = False
        btnDeletePurchases.Visible = True
        btnPurchaseUpdate.Visible = False


    End Sub

    Private Sub dgvSearch_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvSearch.CellMouseDoubleClick
        con.Close()

        con.Open()

        Dim str As String = dgvSearch.CurrentRow.Cells("Serial No").Value.ToString

        Dim cmd As New SqlCommand("select * from tbl_Purchases where Purchase_Srno='" & str & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            txtPurchaseSrno.Text = rd("Purchase_Srno").ToString
            dtpPurchaseDate.Text = rd("Purchase_Date").ToString
            cboPurchaseBrand.SelectedText = rd("Purchase_Brand").ToString
            cboSupplier.SelectedText = rd("Supplier_Name").ToString
            cboPurchaseProduct.SelectedText = rd("Purchase_Product").ToString
            txtPurchaseRate.Text = rd("Purchase_Rate").ToString
            txtPurchaseQuantity.Text = rd("Purchase_Quantity").ToString
            txtPurchaseAmount.Text = rd("Purchase_Amount").ToString


        End While
        pnlSearch.Visible = False
        TabControl1.Visible = True
        'btnPurchaseUpdate.Visible = True



    End Sub

    Private Sub btnPurchaseUpdateSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchaseUpdateSave.Click

        con.Close()
        con.Open()

        Dim s As String = "update tbl_Purchases set Purchase_Product='" & cboPurchaseProduct.Text & "', Purchase_Rate='" & txtPurchaseRate.Text & "',Purchase_Quantity='" & txtPurchaseQuantity.Text & "',Purchase_Amount='" & txtPurchaseAmount.Text & "',Purchase_Brand='" & cboPurchaseBrand.Text & "',Supplier_Name='" & cboSupplier.Text & "',Purchase_Date='" & dtpPurchaseDate.Value.ToString & "' where Purchase_Srno='" & txtPurchaseSrno.Text & "'"
        Dim cmd1 As New SqlCommand(s, con)
        cmd1.ExecuteNonQuery()
        MsgBox("Record Updated")
        con.Close()

        Me.Close()




    End Sub

    Private Sub btnDeletePurchases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletePurchases.Click


        con.Close()
        con.Open()

        Dim s As String = "delete from tbl_Purchases where Purchase_Srno='" & txtPurchaseSrno.Text & "'"
        Dim cmd1 As New SqlCommand(s, con)
        cmd1.ExecuteNonQuery()
        MsgBox("Record Deleted")
        con.Close()

        Me.Close()

    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub txtProductRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProductRate.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
           Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtUpdateRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUpdateRate.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
           Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtPurchaseRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPurchaseRate.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
           Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtPurchaseQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPurchaseQuantity.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
           Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class