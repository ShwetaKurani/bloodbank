Imports System.Data.SqlClient


Public Class frmSales

    Dim con As New SqlConnection("Data Source=(local)\sqlexpress;AttachDbFilename=D:\MAAZ\maaz.mdf;Integrated Security=True")

    Public Sub clear()
        dtpExpiryDate.ResetText()
        dtpDate.ResetText()
        cboBloodGroup.ResetText()
        txtName.Clear()
        txtQuantity.Clear()

    End Sub
    Public Sub increment()

        Dim id1 As Integer
        con.Close()

        con.Open()

        Dim cmd As New SqlCommand("select Serial_No from tbl_Sales", con)
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
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        If ((txtName.Text = "") Or (txtAmount.Text = "") Or (cboBloodGroup.Text = "")) Then

            MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation)
        Else

            con.Close()

            con.Open()



            Dim s As String = "Insert into tbl_Sales(Serial_No,Sales_Date,Patient_Name,Blood_Group,Sales_Quantity,Blood_ExpiryDate,Sales_Amount) values('" & txtSR.Text & "','" & dtpDate.Value.ToString() & "','" & txtName.Text & "','" & cboBloodGroup.Text & "','" & txtQuantity.Text & "','" & dtpExpiryDate.Value.ToString() & "','" & txtAmount.Text & "')"
            Dim cmd1 As New SqlCommand(s, con)
            cmd1.ExecuteNonQuery()


            con.Close()

            con.Open()

            Dim str As String = "update tbl_Stock set Blood_Quantity=Blood_Quantity-'" & txtQuantity.Text & "' where Blood_Group='" & cboBloodGroup.Text & "'"
            Dim cmd2 As New SqlCommand(str, con)
            cmd2.ExecuteNonQuery()

            con.Close()

            MsgBox("Record Inserted")




        End If



    End Sub

    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        pnlSearch.Visible = False

        btnSaveUpdate.Visible = False
        btnDelete.Visible = False


        Dim adapter As New SqlDataAdapter("select [Serial No]=Serial_No,[Purchase Date]=Sales_Date from tbl_Sales", con)
        Dim ds As New DataSet
        adapter.Fill(ds)
        dgvSearch.DataSource = ds.Tables(0)






        increment()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        clear()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        btnSave.Visible = False
        btnClear.Visible = False
        btnSaveUpdate.Visible = True
        btnDelete.Visible = True

        pnlSearch.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub dgvSearch_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvSearch.CellMouseDoubleClick
        con.Open()

        Dim str As String = dgvSearch.CurrentRow.Cells("Serial No").Value.ToString

        Dim cmd As New SqlCommand("select * from tbl_Sales where Serial_No='" & str & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()


            txtSR.Text = rd("Serial_No").ToString
            dtpDate.Text = rd("Sales_Date").ToString
            cboBloodGroup.SelectedText = rd("Blood_Group").ToString
            txtName.Text = rd("Patient_Name").ToString
            txtQuantity.Text = rd("Sales_Quantity").ToString
            dtpExpiryDate.Text = rd("Blood_ExpiryDate").ToString
            txtAmount.Text = rd("Sales_Amount").ToString




        End While
        rd.Close()
        con.Close()


        pnlSearch.Visible = False
        Panel1.Visible = True


    End Sub

    Private Sub btnSaveUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveUpdate.Click

        con.Close()
        con.Open()

        Dim s As String = "update tbl_Sales set Sales_Date='" + dtpDate.Value.ToString + "',Blood_Group='" + cboBloodGroup.Text + "',Patient_Name='" + txtName.Text + "',Sales_Quantity='" + txtQuantity.Text + "',Sales_Amount='" + txtAmount.Text + "',Blood_ExpiryDate='" + dtpExpiryDate.Value.ToString + "' where Serial_No='" & txtSR.Text & "'"
        Dim cmd1 As New SqlCommand(s, con)
        cmd1.ExecuteNonQuery()
        MsgBox("Record Updated")
        con.Close()
        clear()

        Close()
        Me.Dispose()

        Me.Close()



    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        con.Open()

        Dim s As String = "delete from tbl_sales where serial_no='" & txtSR.Text & "'"
        Dim cmd2 As New SqlCommand(s, con)
        cmd2.ExecuteNonQuery()
        'Else
        con.Close()


        Me.Dispose()

        Me.Close()






    End Sub
End Class