Imports System.Data.SqlClient
Public Class frmUpdateSales
    Dim con As New SqlConnection("Data Source=(local)\sqlexpress;AttachDbFilename=D:\MAAZ\maaz.mdf;Integrated Security=True")
    Public Sub loadSR()

        cboSR.Items.Clear()

        'con.Close()
        Call endconnection()

        con.Open()

        Dim cmd As New SqlCommand("select Sales_SR from tbl_ProductSales", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        cboSR.Items.Add("select")
        While rd.Read()


            cboSR.Items.Add(rd(0))


        End While
        'con.Close()
        Call endconnection()



    End Sub
    Public Sub clear()
        txtRate.Clear()
        txtProduct.Clear()
        cboSR.ResetText()

        txtName.Clear()
        txtAmount.Clear()
        txtQuantity.Clear()
        dtpDate.ResetText()

    End Sub
    Private Sub frmUpdateSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSR()

    End Sub

    Private Sub cboSR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSR.SelectedIndexChanged
        con.Open()

        Dim cmd As New SqlCommand("select * from tbl_ProductSales where Serial No.='" & cboSR.Text & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()

        While rd.Read()



            dtpDate.Text = rd("Sales_Date").ToString()

            txtName.Text = rd("Sales_Patient").ToString()
            txtProduct.Text = rd("Sales_Product").ToString()
            txtRate.Text = rd("Sales_Rate").ToString()
            txtQuantity.Text = rd("Sales_Quantity").ToString()
            txtAmount.Text = rd("Sales_Amount").ToString()




        End While
        con.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        con.Open()
        Dim s As String = "Update tbl_ProductSales set Sales_Date='" & dtpDate.Value.ToString() & "',Sales_Patient='" & txtName.Text & "',Sales_Product='" & txtProduct.Text & "',Sales_Rate='" & txtRate.Text & "',Sales_Quantity='" & txtQuantity.Text & "',Sales_Amount='" & txtAmount.Text & "' where Sales_SR='" & cboSR.Text & "'"
        Dim cmd1 As New SqlCommand(s, con)
        cmd1.ExecuteNonQuery()
        MsgBox("Record Inserted")

        clear()

    End Sub




    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmUpdateSales_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'frmUpdateSales
        '
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Name = "frmUpdateSales"
        Me.ResumeLayout(False)

    End Sub
End Class