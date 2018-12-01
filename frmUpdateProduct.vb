Imports System.Data.SqlClient

Public Class frmUpdateProduct
    Dim con As New SqlConnection("Data Source=(local)\sqlexpress;AttachDbFilename=D:\MAAZ\maaz.mdf;Integrated Security=True")
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

    End Sub
    Private Sub frmUpdateProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub txtRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
        Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        con.Open()
        Dim s As String = "Update tbl_Product set Product_Rate='" & txtRate.Text & "' where Product_Name='" & cboProduct.Text & "'"
        Dim cmd1 As New SqlCommand(s, con)
        cmd1.ExecuteNonQuery()
        MsgBox("Record Inserted")
       
        clear()

        Product()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class