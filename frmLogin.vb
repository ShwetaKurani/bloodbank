Imports System.Data.SqlClient


Public Class frmLogin
    Dim con As New SqlConnection("Data Source=(local)\sqlexpress;AttachDbFilename=D:\MAAZ\maaz.mdf;Integrated Security=True")

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    
    Private Sub txtPassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If (e.KeyCode = Keys.Enter) Then

            btnLogin_Click(sender, e)


        End If



    End Sub

    

    Private Sub label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
    Private Sub btnLogin_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        Dim a, b As String
        a = txtUsername.Text
        b = txtPassword.Text
        Dim flag As Integer = 0
        con.Open()
        Dim cmd As New SqlCommand("select * from tbl_Login", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        While (rd.Read())
            If (a = rd(0).ToString.Trim() And b = rd(1).ToString.Trim()) Then
                flag = 1
                Exit While
            Else
                flag = 0
            End If
        End While

        If (flag = 1) Then
            'MsgBox("Login Successfull", MsgBoxStyle.OkOnly, "Done")
            Me.Hide()


            frmHome.Show()


        Else
            MsgBox("User Name or Password may be wrong.", MsgBoxStyle.Critical, "Error")
        End If
        con.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
End Class