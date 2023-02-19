Imports System.Configuration
Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Office.Interop

Public Class Cek

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.InitialDirectory = "D:\"
        openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            TextBox1.Text = filePath
        End If
    End Sub

    Private Sub Cek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim excelApp As New Excel.Application
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Open(TextBox1.Text)
        Dim worksheet As Excel.Worksheet = workbook.Worksheets(1)

        Dim dt As New DataTable
        For row As Integer = 1 To worksheet.UsedRange.Rows.Count
            Dim dr As DataRow = dt.NewRow
            For col As Integer = 1 To worksheet.UsedRange.Columns.Count
                If row = 1 Then ' Add column headers
                    dt.Columns.Add(worksheet.Cells(row, col).Value.ToString)
                Else ' Add row data
                    dr(col - 1) = worksheet.Cells(row, col).Value
                End If
            Next
            If row > 1 Then dt.Rows.Add(dr)
        Next

        DataGridView1.DataSource = dt

        workbook.Close()
        excelApp.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    End Sub


End Class