Imports System.Data.SqlClient
Public Class frmProductSales
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\my project\Blood Bank Management System\Blood Bank Management System\db_BloodBank.mdf;Integrated Security=True;User Instance=True")
    Public Sub Product()

        cboProduct.Items.Clear()

        con.Close()


        con.Open()

        Dim cmd As New SqlCommand("select Product_Name from tbl_Product", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        cboProduct.Items.Add("select")
        While rd.Read()


            cboProduct.Items.Add(rd(0))


        End While
        con.Close()




    End Sub
    Public Sub clear()
        txtRate.Clear()
        cboProduct.ResetText()
        txtName.Clear()
        txtAmount.Clear()
        txtQuantity.Clear()
        dtpDate.ResetText()


    End Sub
    Public Sub increment()
        Dim id1 As Integer
        con.Close()

        con.Open()

        Dim cmd As New SqlCommand("select Sales_SR from tbl_ProductSales", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            id1 = rd(0)
        End While
        con.Close()
        id1 = id1 + 1
        txtSR.Text = id1
        con.Close()

    End Sub
    Private Sub frmProductSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        increment()
        Product()

    End Sub

    Private Sub cboProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduct.SelectedIndexChanged
        con.Open()

        Dim cmd As New SqlCommand("select Product_Rate from tbl_Product where Product_Name='" & cboProduct.Text & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()

        While rd.Read()


            txtRate.Text = rd(0).ToString



        End While
        con.Close()
    End Sub

    Private Sub txtQuantity_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.Leave
        Dim rate As Double
        Dim qty As Double
        Dim amt As Double


        rate = Double.Parse(txtRate.Text)
        qty = Double.Parse(txtQuantity.Text)

        amt = qty * rate

        txtAmount.Text = amt.ToString()

    End Sub

    Private Sub txtRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
       Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
       Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
       Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (txtSR.Text = "" Or txtName.Text = "" Or txtRate.Text = "") Then

            MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation)

        Else

            con.Open()
            Dim s As String = "Insert into tbl_ProductSales(Sales_SR,Sales_Date,Sales_Patient,Sales_Product,Sales_Rate,Sales_Quantity,Sales_Amount) values('" & txtSR.Text & "','" & dtpDate.Value.ToString() & "','" & txtName.Text & "','" & cboProduct.Text & "','" & txtRate.Text & "','" & txtQuantity.Text & "','" & txtAmount.Text & "')"
            Dim cmd1 As New SqlCommand(s, con)
            cmd1.ExecuteNonQuery()
            MsgBox("Record Inserted")

            Dim obj As New frmViewReport
            obj.View_Report("select * from tbl_ProductSales where Sales_SR='" & txtSR.Text & "'", "ProductBill")
            obj.ShowDialog()


            clear()

            increment()
            Product()



        End If

    End Sub
End Class