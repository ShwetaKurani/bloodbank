Imports System.Data.SqlClient


Public Class frmPatient
    Dim con As New SqlConnection("Data Source=(local)\sqlexpress;AttachDbFilename=D:\MAAZ\maaz.mdf;Integrated Security=True")
    Public Sub clear()


        txtName.Clear()
        txtAge.Clear()
        txtContact.Clear()
        cboBloodGroup.ResetText()
        cboGender.ResetText()
        rtbAddress.Clear()




    End Sub
    Public Sub increment()
        Dim id1 As Integer
        con.Close()

        con.Open()

        Dim cmd As New SqlCommand("select Recipient_ID from tbl_RecipientDetails", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()
            id1 = rd(0)
        End While
        con.Close()
        id1 = id1 + 1
        txtPatientID.Text = id1
        con.Close()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (txtPatientID.Text = "" Or txtName.Text = "" Or cboBloodGroup.Text = "") Then

            MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation)

        Else

            con.Open()
            Dim s As String = "Insert into tbl_RecipientDetails values('" & txtPatientID.Text & "','" & txtName.Text & "','" & cboGender.Text & "','" & txtAge.Text & "','" & rtbAddress.Text & "','" & txtContact.Text & "','" & cboBloodGroup.Text & "')"
            Dim cmd1 As New SqlCommand(s, con)
            cmd1.ExecuteNonQuery()
            MsgBox("Record Inserted")
            'clear()
            clear()
            increment()



        End If
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub frmPatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlSearch.Visible = False

        btnSaveUpdate.Visible = False
        btnDelete.Visible = False


        Dim adapter As New SqlDataAdapter("select [Recipient ID]=Recipient_ID,[Recipient Name]=Recipient_Name from tbl_RecipientDetails", con)
        Dim ds As New DataSet
        adapter.Fill(ds)
        dgvSearch.DataSource = ds.Tables(0)



        increment()

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

        Dim str As String = dgvSearch.CurrentRow.Cells("Recipient ID").Value.ToString

        Dim cmd As New SqlCommand("select * from tbl_RecipientDetails where Recipient_ID='" & str & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While rd.Read()


            txtPatientID.Text = rd("Recipient_ID").ToString
            txtName.Text = rd("Recipient_Name").ToString
            txtAge.Text = rd("Recipient_Age").ToString
            txtContact.Text = rd("Recipient_Contact").ToString
            cboBloodGroup.SelectedText = rd("Recipient_BloodGroup").ToString
            cboGender.SelectedText = rd("Recipient_Gender").ToString
            rtbAddress.Text = rd("Recipient_Address").ToString


        End While
        rd.Close()
        con.Close()


        pnlSearch.Visible = False
        Panel1.Visible = True



    End Sub

    Private Sub btnSaveUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveUpdate.Click

        con.Close()
        con.Open()

        Dim s As String = "update tbl_RecipientDetails set Recipient_Name='" & txtName.Text & "',Recipient_Gender='" & cboGender.Text & "',Recipient_Age='" & txtAge.Text & "',Recipient_Address='" & rtbAddress.Text & "',Recipient_Contact='" & txtContact.Text & "',Recipient_BloodGroup='" & cboBloodGroup.Text & "' where Recipient_ID='" & txtPatientID.Text & "'"
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

        Dim s As String = "delete from tbl_RecipientDetails where Recipient_ID='" & txtPatientID.Text & "'"
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

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub pnlSearch_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlSearch.Paint

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class