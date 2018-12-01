Imports System.Data.SqlClient
Imports excel = Microsoft.Office.Interop.Excel




Public Class frmSearch

    Dim con As New SqlConnection("Data Source=(local)\sqlexpress;AttachDbFilename=D:\MAAZ\maaz.mdf;Integrated Security=True")


    Private Sub cboSearchBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchBy.SelectedIndexChanged

        If (cboSearchBy.SelectedIndex = 0) Then
            cboValue.Items.Clear()
            cboValue.Enabled = True
            dtpFromDate.Enabled = False
            dtpToDate.Enabled = False
            dtpFromDate.Checked = False
            dtpToDate.Checked = False
            con.Close()

            con.Open()
            Dim cmd As New SqlCommand("select Donor_Name from tbl_DonorDetails", con)
            Dim rd As SqlDataReader
            rd = cmd.ExecuteReader()
            cboValue.Items.Add("All")
            While rd.Read()
                cboValue.Items.Add(rd("Donor_Name"))
            End While
            rd.Close()

        End If
        If (cboSearchBy.SelectedIndex = 1) Then
            cboValue.Items.Clear()
            cboValue.Enabled = True
            dtpFromDate.Enabled = False
            dtpToDate.Enabled = False
            dtpFromDate.Checked = False
            dtpToDate.Checked = False
            con.Close()

            con.Open()
            Dim cmd As New SqlCommand("select Recipient_Name from tbl_RecipientDetails", con)
            Dim rd As SqlDataReader
            rd = cmd.ExecuteReader()
            cboValue.Items.Add("All")
            While rd.Read()
                cboValue.Items.Add(rd("Recipient_Name"))
            End While
            rd.Close()

        End If


        If (cboSearchBy.SelectedIndex = 2) Then
            cboValue.Items.Clear()
            cboValue.Enabled = True
            dtpFromDate.Enabled = True
            dtpToDate.Enabled = True
            dtpFromDate.Checked = False
            dtpToDate.Checked = False
            con.Close()

            con.Open()
            Dim cmd As New SqlCommand("select Donor_Name from tbl_Purchases", con)
            Dim rd As SqlDataReader
            rd = cmd.ExecuteReader()
            cboValue.Items.Add("All")
            While rd.Read()
                cboValue.Items.Add(rd("Donor_Name"))
            End While
            rd.Close()

        End If

        If (cboSearchBy.SelectedIndex = 3) Then
            cboValue.Items.Clear()
            cboValue.Enabled = True
            dtpFromDate.Enabled = True
            dtpToDate.Enabled = True
            dtpFromDate.Checked = False
            dtpToDate.Checked = False
            con.Close()

            con.Open()
            Dim cmd As New SqlCommand("select Patient_Name from tbl_Sales", con)
            Dim rd As SqlDataReader
            rd = cmd.ExecuteReader()
            cboValue.Items.Add("All")
            While rd.Read()
                cboValue.Items.Add(rd("Patient_Name"))
            End While
            rd.Close()

        End If

        If (cboSearchBy.SelectedIndex = 4) Then
            cboValue.Items.Clear()
            cboValue.Enabled = False
            dtpFromDate.Enabled = False
            dtpToDate.Enabled = False
            dtpFromDate.Checked = False
            dtpToDate.Checked = False


          

        End If
    End Sub

    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtpFromDate.Enabled = False
        dtpToDate.Enabled = False
        cboValue.Enabled = False

    End Sub

    Private Sub btnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReport.Click

        dgvSearch.Columns.Clear()

        If (cboSearchBy.SelectedIndex = 3) Then
            Dim btnReport As New DataGridViewButtonColumn
            btnReport.Name = "Report"
            btnReport.HeaderText = "Report"
            btnReport.Text = "View"
            btnReport.Width = 50
            btnReport.UseColumnTextForButtonValue = True
            dgvSearch.Columns.Add(btnReport)

        End If


        If (cboSearchBy.SelectedIndex = 0) Then

            If (cboValue.SelectedIndex = 0) Then

                Dim adapter = New SqlDataAdapter("select [Donor ID]=Donor_ID,[Name]=Donor_Name,[Gender]=Donor_Gender,[Address]=Donor_Address,[Contact]=Donor_Contact,[Blood Group]=Donor_Group,[Donor Type]=Donor_Type,[Hemoglobin EST]=Donor_HemoglobinEST,[HIV Status]=Donor_HIVStatus,[Physical Exam]=Donor_PhysicalExam from tbl_DonorDetails", con)
                Dim ds As New DataSet
                adapter.Fill(ds)
                dgvSearch.DataSource = ds.Tables(0)

            Else


                Dim adapter = New SqlDataAdapter("select [Donor ID]=Donor_ID,[Name]=Donor_Name,[Gender]=Donor_Gender,[Address]=Donor_Address,[Contact]=Donor_Contact,[Blood Group]=Donor_Group,[Donor Type]=Donor_Type,[Hemoglobin EST]=Donor_HemoglobinEST,[HIV Status]=Donor_HIVStatus,[Physical Exam]=Donor_PhysicalExam from tbl_DonorDetails where Donor_Name='" + cboValue.Text + "'", con)
                Dim ds As New DataSet
                adapter.Fill(ds)
                dgvSearch.DataSource = ds.Tables(0)

            End If


        End If


        If (cboSearchBy.SelectedIndex = 1) Then

            If (cboValue.SelectedIndex = 0) Then

                Dim adapter = New SqlDataAdapter("select [Recipient ID]=Recipient_ID,[Name]=Recipient_Name,[Gender]=Recipient_Gender,[Age]=Recipient_Age,[Address]=Recipient_Address,[Contact No]=Recipient_Contact,[Blood Group]=Recipient_BloodGroup from tbl_RecipientDetails", con)
                Dim ds As New DataSet
                adapter.Fill(ds)
                dgvSearch.DataSource = ds.Tables(0)

            Else


                Dim adapter = New SqlDataAdapter("select [Recipient ID]=Recipient_ID,[Name]=Recipient_Name,[Gender]=Recipient_Gender,[Age]=Recipient_Age,[Address]=Recipient_Address,[Contact No]=Recipient_Contact,[Blood Group]=Recipient_BloodGroup from tbl_RecipientDetails where Recipient_Name='" + cboValue.Text + "'", con)
                Dim ds As New DataSet
                adapter.Fill(ds)
                dgvSearch.DataSource = ds.Tables(0)

            End If


        End If




        If (cboSearchBy.SelectedIndex = 2) Then

            If (dtpFromDate.Checked = True And dtpToDate.Checked = True) Then

                If (dtpFromDate.Value <= dtpToDate.Value) Then

                    If (cboValue.SelectedIndex = 0) Then

                        Dim adapter = New SqlDataAdapter("select [Serial No]=Serial_No,[Purchase Date]=Purchase_Date,[Blood Group]=Blood_Group,[Donor Name]=Donor_Name,[Quantity]=Purchase_Quantity,[Blood Bag No]=Blood_BagNo,[Expiry Date]=Blood_ExpiryDate from tbl_Purchases where Purchase_Date BETWEEN '" + dtpFromDate.Value + "' AND '" + dtpToDate.Value + "'", con)
                        Dim ds As New DataSet
                        adapter.Fill(ds)
                        dgvSearch.DataSource = ds.Tables(0)

                    Else

                        Dim adapter = New SqlDataAdapter("select [Serial No]=Serial_No,[Purchase Date]=Purchase_Date,[Blood Group]=Blood_Group,[Donor Name]=Donor_Name,[Quantity]=Purchase_Quantity,[Blood Bag No]=Blood_BagNo,[Expiry Date]=Blood_ExpiryDate from tbl_Purchases where Donor_Name='" + cboValue.Text + "' and Purchase_Date BETWEEN '" + dtpFromDate.Value + "' AND '" + dtpToDate.Value + "'", con)
                        Dim ds As New DataSet
                        adapter.Fill(ds)
                        dgvSearch.DataSource = ds.Tables(0)

                    End If


                End If


            Else

                If (cboValue.SelectedIndex = 0) Then

                    Dim adapter = New SqlDataAdapter("select [Serial No]=Serial_No,[Purchase Date]=Purchase_Date,[Blood Group]=Blood_Group,[Donor Name]=Donor_Name,[Quantity]=Purchase_Quantity,[Blood Bag No]=Blood_BagNo,[Expiry Date]=Blood_ExpiryDate from tbl_Purchases", con)
                    Dim ds As New DataSet
                    adapter.Fill(ds)
                    dgvSearch.DataSource = ds.Tables(0)

                Else

                    Dim adapter = New SqlDataAdapter("select [Serial No]=Serial_No,[Purchase Date]=Purchase_Date,[Blood Group]=Blood_Group,[Donor Name]=Donor_Name,[Quantity]=Purchase_Quantity,[Blood Bag No]=Blood_BagNo,[Expiry Date]=Blood_ExpiryDate from tbl_Purchases where Donor_Name='" + cboValue.Text + "'", con)
                    Dim ds As New DataSet
                    adapter.Fill(ds)
                    dgvSearch.DataSource = ds.Tables(0)

                End If



            End If

        End If



        
        If (cboSearchBy.SelectedIndex = 3) Then

            If (dtpFromDate.Checked = True And dtpToDate.Checked = True) Then

                If (dtpFromDate.Value <= dtpToDate.Value) Then

                    If (cboValue.SelectedIndex = 0) Then

                        Dim adapter = New SqlDataAdapter("select [Serial No]=Serial_No,[Sales Date]=Sales_Date,[Recipient Name]=Patient_Name,[Blood Group]=Blood_Group,[Quantity]=Sales_Quantity,[Expiry Date]=Blood_ExpiryDate,[Bag No]=Sales_BagNo from tbl_Sales where Sales_Date BETWEEN '" + dtpFromDate.Value + "' AND '" + dtpToDate.Value + "'", con)
                        Dim ds As New DataSet
                        adapter.Fill(ds)
                        dgvSearch.DataSource = ds.Tables(0)

                    Else

                        Dim adapter = New SqlDataAdapter("select [Serial No]=Serial_No,[Sales Date]=Sales_Date,[Recipient Name]=Patient_Name,[Blood Group]=Blood_Group,[Quantity]=Sales_Quantity,[Expiry Date]=Blood_ExpiryDate,[Bag No]=Sales_BagNo from tbl_Sales where Patient_Name='" + cboValue.Text + "' and Sales_Date BETWEEN '" + dtpFromDate.Value + "' AND '" + dtpToDate.Value + "'", con)
                        Dim ds As New DataSet
                        adapter.Fill(ds)
                        dgvSearch.DataSource = ds.Tables(0)

                    End If


                End If


            Else

                If (cboValue.SelectedIndex = 0) Then

                    Dim adapter = New SqlDataAdapter("select [Serial No]=Serial_No,[Sales Date]=Sales_Date,[Recipient Name]=Patient_Name,[Blood Group]=Blood_Group,[Quantity]=Sales_Quantity,[Expiry Date]=Blood_ExpiryDate,[Bag No]=Sales_BagNo from tbl_Sales", con)
                    Dim ds As New DataSet
                    adapter.Fill(ds)
                    dgvSearch.DataSource = ds.Tables(0)

                Else
                    Dim adapter = New SqlDataAdapter("select [Serial No]=Serial_No,[Sales Date]=Sales_Date,[Recipient Name]=Patient_Name,[Blood Group]=Blood_Group,[Quantity]=Sales_Quantity,[Expiry Date]=Blood_ExpiryDate,[Bag No]=Sales_BagNo from tbl_Sales where Patient_Name='" + cboValue.Text + "'", con)
                    Dim ds As New DataSet
                    adapter.Fill(ds)
                    dgvSearch.DataSource = ds.Tables(0)
                  

                End If



            End If

        End If




        If (cboSearchBy.SelectedIndex = 4) Then


            Dim adpter As New SqlDataAdapter("select [Blood Group]=Blood_Group,[Quantity]=Blood_Quantity from tbl_Stock", con)
            Dim ds1 As New DataSet
            adpter.Fill(ds1)
            dgvSearch.DataSource = ds1.Tables(0)


            Dim i As Integer
            i = 0
            While (i < dgvSearch.Rows.Count - 1)

                If (dgvSearch.Rows(i).Cells(1).Value.ToString < 60) Then

                    dgvSearch.Rows(i).DefaultCellStyle.BackColor = Color.Red

                End If


                i = i + 1

            End While


        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim xlApp As excel.Application
        Dim xlWorkBook As excel.Workbook
        Dim xlWorkSheet As excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        'foreach (DataGridViewColumn column in dgvSearch.Columns)

        '        xlworksheet.Cells[3, ColumnIndex + 1] = column.HeaderText
        '        ColumnIndex++
        'For Each DataGridViewColumn In dgvSearch.Columns


        'Next


        For i = 0 To dgvSearch.RowCount - 2
            For j = 0 To dgvSearch.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) = _
                    dgvSearch(j, i).Value.ToString()
            Next
        Next

        'xlWorkSheet.SaveAs("C:\vbexcel.xlsx")
        'xlWorkBook.Close()
        'xlApp.Quit()

        'xlWorkSheet.get_Range("A3", "EA3").Font.Bold = True
        xlWorkSheet.Cells.EntireColumn.ColumnWidth = 20
        xlWorkSheet.Columns.AutoFit()
        xlWorkSheet.Columns.VerticalAlignment = excel.XlVAlign.xlVAlignCenter
        xlApp.Visible = True
        xlApp.UserControl = True


        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

    End Sub

    Private Sub dgvSearch_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSearch.CellContentClick

        Dim str As String
        str = ""
        str = dgvSearch.Columns(e.ColumnIndex).Name.ToString

        If (str = "Report") Then

            If (cboSearchBy.SelectedIndex = 3) Then

                Dim str2 As String
                str2 = ""
                str2 = dgvSearch.CurrentRow.Cells("Serial No").Value.ToString


                Dim obj As New frmViewReport
                obj.View_Report("select * from tbl_Sales where Serial_No='" & str2 & "'", "Bill")
                obj.ShowDialog()


            End If


        Else

            MsgBox("Please Click on View Button")
        End If


    End Sub
End Class