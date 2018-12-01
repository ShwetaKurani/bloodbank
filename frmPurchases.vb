Imports System.Data.SqlClient


Public Class frmPurchases
    Dim con As New SqlConnection("Data Source=(local)\sqlexpress;AttachDbFilename=D:\MAAZ\maaz.mdf;Integrated Security=True")

    Private Sub frmPurchases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlSearch.Visible = False

        btnSaveUpdate.Visible = False
        btnDelete.Visible = False


        Dim adapter As New SqlDataAdapter("select [Serial No]=Serial_No,[Purchase Date]=Purchase_Date from tbl_Purchases", con)
        Dim ds As New DataSet
        adapter.Fill(ds)
        dgvSearch.DataSource = ds.Tables(0)


        increment()


        con.Open()
        Dim cmd As New SqlCommand("select Donor_Name from tbl_DonorDetails", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            cboDonorName.Items.Add(rd(0))

        End While
        con.Close()



    End Sub
    Public Sub increment()
        Dim id1 As Integer
        con.Close()

        con.Open()

        Dim cmd As New SqlCommand("select Serial_No from tbl_Purchases", con)
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
    Public Sub clear()
        dtpExpiryDate.ResetText()
        dtpDate.ResetText()
        cboBloodGroup.ResetText()
        txtBagNo.Clear()
        txtName.Clear()
        txtQuantity.Clear()
        cboDonorName.ResetText()


    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If ((cboDonorName.Text = "") Or (txtBagNo.Text = "") Or (cboBloodGroup.Text = "")) Then
            MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation)
        Else

            con.Close()

            con.Open()



            Dim s As String = "Insert into tbl_Purchases(Serial_No,Purchase_Date,Blood_Group,Donor_Name,Purchase_Quantity,Blood_BagNo,Blood_ExpiryDate) values('" & txtSR.Text & "','" & dtpDate.Value.ToString() & "','" & cboBloodGroup.Text & "','" & cboDonorName.Text & "','" & txtQuantity.Text & "','" & txtBagNo.Text & "','" & dtpExpiryDate.Value.ToString() & "')"
            Dim cmd1 As New SqlCommand(s, con)
            cmd1.ExecuteNonQuery()


            Dim str As String
            str = ""
            con.Close()

            con.Open()

            Dim cmd As New SqlCommand("select * from tbl_Stock where Blood_Group='" & cboBloodGroup.Text & "'", con)
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
                Dim cmd2 As New SqlCommand("update tbl_Stock set Blood_Quantity=Blood_Quantity+'" & txtQuantity.Text & "' where Blood_Group='" & cboBloodGroup.Text & "'", con)
                cmd2.ExecuteNonQuery()


            Else
                Dim stock As String = "Insert into tbl_Stock(Blood_Group,Blood_Quantity)values('" & cboBloodGroup.Text & "','" & txtQuantity.Text & "')"
                Dim cmdStock As New SqlCommand(stock, con)
                cmdStock.ExecuteNonQuery()

            End If







            MsgBox("Record Inserted")

            clear()

            increment()






            con.Close()




        End If


    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

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

        Dim cmd As New SqlCommand("select * from tbl_Purchases where Serial_No='" & str & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()


            txtSR.Text = rd("Serial_No").ToString
            dtpDate.Text = rd("Purchase_Date").ToString
            cboBloodGroup.SelectedText = rd("Blood_Group").ToString
            cboDonorName.SelectedText = rd("Donor_Name").ToString
            txtBagNo.Text = rd("Blood_BagNo").ToString
            txtQuantity.Text = rd("Purchase_Quantity").ToString
            dtpExpiryDate.Text = rd("Blood_ExpiryDate").ToString




        End While
        rd.Close()
        con.Close()


        pnlSearch.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub btnSaveUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveUpdate.Click


        con.Close()
        con.Open()

        Dim s As String = "update tbl_Purchases set Purchase_Date='" + dtpDate.Value.ToString + "',Blood_Group='" + cboBloodGroup.Text + "',Donor_Name='" + cboDonorName.Text + "',Blood_BagNo='" + txtBagNo.Text + "',Purchase_Quantity='" + txtQuantity.Text + "',Blood_ExpiryDate='" + dtpExpiryDate.Value.ToString + "' where Serial_No='" & txtSR.Text & "'"
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

        Dim s As String = "delete from tbl_Purchases where serial_no='" & txtSR.Text & "'"
        Dim cmd2 As New SqlCommand(s, con)
        cmd2.ExecuteNonQuery()
        'Else
        con.Close()


        Me.Dispose()

        Me.Close()


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class