Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Module connection
    Public con As New SqlConnection
    Public Sub startconnection()
        con = New SqlConnection("Data Source=(local)\sqlexpress;AttachDbFilename=D:\MAAZ\maaz.mdf;Integrated Security=True")
        con.Open()
    End Sub
    Public Sub endconnection()
        con.Close()
    End Sub
End Module






































































































