Imports System.Data.SqlClient


Public Class frmDonor
    Dim con As New SqlConnection("Data Source=(local)\sqlexpress;AttachDbFilename=D:\suhas\my project\Blood Bank Management System\Blood Bank Management System\database\db_BloodBank.mdf;Integrated Security=True")

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmDonor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnSaveUpdate.Visible = False
        btnDelete.Visible = False

        pnlSearch.Visible = False

        increment()

        Dim adapter As New SqlDataAdapter("select [Donor ID]=Donor_ID,[Donor Name]=Donor_Name from tbl_DonorDetails", con)
        Dim ds As New DataSet
        adapter.Fill(ds)
        dgvSearch.DataSource = ds.Tables(0)




    End Sub

    Public Sub increment()
        Dim id1 As Integer
        con.Close()

        con.Open()

        Dim cmd As New SqlCommand("select Donor_ID from tbl_DonorDetails", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            id1 = rd(0)
        End While
        con.Close()
        id1 = id1 + 1
        txtDonorID.Text = id1
        con.Close()

    End Sub
    Public Sub clear()

        txtName.Clear()
        txtAge.Clear()
        txtContact.Clear()
        txtDonorType.Clear()
        txtHemoglobin.Clear()
        txtHIV.Clear()
        txtPhysicalTest.Clear()
        cboGender.ResetText()
        cboBloodGroup.ResetText()
        dtpDate.ResetText()
        rtbAddress.Clear()


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If (txtDonorID.Text = "" Or txtName.Text = "" Or cboBloodGroup.Text = "") Then

            MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation)

        Else

            con.Open()
            Dim s As String = "Insert into tbl_DonorDetails(Donor_ID,Donor_Name,Donor_Gender,Donor_Address,Donor_Contact,Donor_Group,Donor_Type,Donor_HemoglobinEST,Donor_HIVStatus,Donor_PhysicalExam,Donor_Age) values('" & txtDonorID.Text & "','" & txtName.Text & "','" & cboGender.Text & "','" & rtbAddress.Text & "','" & txtContact.Text & "','" & cboBloodGroup.Text & "','" & txtDonorType.Text & "', '" & txtHemoglobin.Text & "','" & txtHIV.Text & "','" & txtPhysicalTest.Text & "','" & txtAge.Text & "')"
            Dim cmd1 As New SqlCommand(s, con)
            cmd1.ExecuteNonQuery()
            MsgBox("Record Inserted")
            clear()

            increment()


        End If







    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        clear()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub dgvSearch_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvSearch.MouseDoubleClick

        con.Open()

        Dim str As String = dgvSearch.CurrentRow.Cells("Donor ID").Value.ToString

        Dim cmd As New SqlCommand("select * from tbl_DonorDetails where Donor_ID='" & str & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            
            cboGender.SelectedText = rd("Donor_Gender").ToString
            rtbAddress.Text = rd("Donor_Address").ToString
            txtContact.Text = rd("Donor_Contact").ToString
            txtDonorID.Text = rd("Donor_ID").ToString
            txtAge.Text = rd("Donor_Age").ToString
            txtDonorType.Text = rd("Donor_Type").ToString
            txtHemoglobin.Text = rd("Donor_HemoglobinEST").ToString
            txtHIV.Text = rd("Donor_HIVStatus").ToString
            txtName.Text = rd("Donor_Name").ToString
            txtPhysicalTest.Text = rd("Donor_PhysicalExam").ToString
            cboBloodGroup.Text = rd("Donor_Group").ToString



        End While
        rd.Close()
        con.Close()


        pnlSearch.Visible = False
        Panel1.Visible = True



    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        pnlSearch.Visible = True
        Panel1.Visible = False
        btnSave.Visible = False
        btnDelete.Visible = False
        btnSaveUpdate.Visible = True
        btnDelete.Visible = True


    End Sub

    Private Sub btnSaveUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveUpdate.Click

        con.Close()
        con.Open()

        Dim s As String = "update tbl_DonorDetails set Donor_Name='" & txtName.Text & "',Donor_Gender='" & cboGender.Text & "',Donor_Address='" & rtbAddress.Text & "',Donor_Contact='" & txtContact.Text & "',Donor_Group='" & cboBloodGroup.Text & "',Donor_Type='" & txtDonorType.Text & "',Donor_HemoglobinEST='" & txtHemoglobin.Text & "',Donor_HIVStatus='" & txtHIV.Text & "',Donor_PhysicalExam='" & txtPhysicalTest.Text & "',Donor_Age='" & txtAge.Text & "' where Donor_ID='" & txtDonorID.Text & "'"
        Dim cmd1 As New SqlCommand(s, con)
        cmd1.ExecuteNonQuery()
        MsgBox("Record Updated")
        con.Close()

        Me.Dispose()

        Me.Close()



    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        con.Open()

        Dim s As String = "delete from tbl_DonorDetails where Donor_ID='" & txtDonorID.Text & "'"
        Dim cmd2 As New SqlCommand(s, con)
        cmd2.ExecuteNonQuery()
        'Else
        con.Close()


        Me.Dispose()

        Me.Close()


    End Sub

    Private Sub txtAge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
           Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
           Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContact.TextChanged

    End Sub

    Private Sub btnClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()

    End Sub

   

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class