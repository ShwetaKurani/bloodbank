Imports System.Data.SqlClient


Public Class frmAddProduct
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\MAAZ\maaz.mdf;Integrated Security=True;User Instance=True")


    Public Sub loadSR()

        Dim id1 As Integer
        con.Close()

        con.Open()

        Dim cmd As New SqlCommand("select Product_SR from tbl_Product", con)
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
        txtName.Clear()
        txtRate.Clear()

    End Sub

    Private Sub frmAddProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        loadSR()



    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        If (txtSR.Text = "" Or txtName.Text = "" Or txtRate.Text = "") Then

            MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation)

        Else

            con.Open()
            Dim s As String = "Insert into tbl_Product(Product_SR,Product_Name,Product_Rate) values('" & txtSR.Text & "','" & txtName.Text & "','" & txtRate.Text & "')"
            Dim cmd1 As New SqlCommand(s, con)
            cmd1.ExecuteNonQuery()
            MsgBox("Record Inserted")
            clear()

            loadSR()


        End If


    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRate.TextChanged

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

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class