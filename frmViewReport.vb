Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO



Public Class frmViewReport
    'Dim con As New SqlConnection("Data Source=.\sqlexpress;Integrated Security=True;database=db_BloodBank")
    'Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\my project\Blood Bank Management System\Blood Bank Management System\db_BloodBank.mdf;Integrated Security=True;User Instance=True")

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load



    End Sub
    Public Sub View_Report(ByVal Query As String, ByVal CRReportName As String)

        'Dim myFile As StreamReader = New System.IO.StreamReader("c:\cont")
        'Dim str1 As String = myFile.ReadToEnd()
        'Dim str As String() = str1.Split(New Char() {";"c})




        Dim reppath As String
        reppath = ""

        Call startconnection()
        Dim cmd As New SqlCommand(Query, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        Dim dt As New DataTable
        dt.Load(dr)
        dr.Close()
        Dim rd As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Dim path As String = Application.StartupPath.ToString

        'Dim substring As String = path.Substring(path.IndexOf("\\") - 2, path.IndexOf("bin") - 1)
        Dim substring As String = path

        If (CRReportName = "Bill") Then

            reppath = substring + "\\Report\\" + CRReportName + ".rpt"




        ElseIf (CRReportName = "ProductBill") Then

            reppath = substring + "\\Report\\" + CRReportName + ".rpt"



        ElseIf (CRReportName = "ProductSales") Then

            reppath = substring + "\\Report\\" + CRReportName + ".rpt"



        ElseIf (CRReportName = "BloodSales") Then

            reppath = substring + "\\Report\\" + CRReportName + ".rpt"


        ElseIf (CRReportName = "Purchase") Then

            reppath = substring + "\\Report\\" + CRReportName + ".rpt"



        ElseIf (CRReportName = "Donor") Then

            reppath = substring + "\\Report\\" + CRReportName + ".rpt"



        ElseIf (CRReportName = "Recipient") Then

            reppath = substring + "\\Report\\" + CRReportName + ".rpt"



        ElseIf Not System.IO.File.Exists(reppath) Then


            MsgBox("File Does not exist")





        End If




        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo


        Dim CrTables As Tables

        rd.Load(reppath)
        crConnectionInfo.ServerName = "./sqlexpress"
        crConnectionInfo.DatabaseName = "db_BloodBank"
        crConnectionInfo.IntegratedSecurity = True

        'crConnectionInfo.Password = str(2)
        rd.SetDataSource(dt)
        CrTables = rd.Database.Tables

        Dim CrTable As CrystalDecisions.CrystalReports.Engine.Table



        For Each CrTable In CrTables

            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)


        Next




        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.ReportSource = rd











    End Sub
End Class