Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Histori
    Private Sub Histori_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TampilDataGridView()

    End Sub
    Sub GetData()
        Call Koneksi()
        Cmd = New OleDbCommand("Select * From TB_Transaksi", Conn)
        Rd = Cmd.ExecuteReader
    End Sub

    Sub TampilDataGridView()
        GetData()
        DataGridView1.Rows.Clear()
        Do While Rd.Read = True
            DataGridView1.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3))
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.Filter = "Excel File (*.xlsx)|*.xlsx"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim ExcelApp As Microsoft.Office.Interop.Excel.Application
            Dim ExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim ExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim a As Integer
            Dim b As Integer
            ExcelApp = New Microsoft.Office.Interop.Excel.Application
            ExcelWorkBook = ExcelApp.Workbooks.Add(misValue)
            ExcelWorkSheet = ExcelWorkBook.Sheets("sheet1")
            For a = 0 To DataGridView1.RowCount - 1
                For b = 0 To DataGridView1.ColumnCount - 1
                    For c As Integer = 1 To DataGridView1.Columns.Count
                        ExcelWorkSheet.Cells(1, c) = DataGridView1.Columns(c - 1).HeaderText
                        ExcelWorkSheet.Cells(a + 2, b + 1) = DataGridView1(b, a).Value.ToString()
                    Next
                Next
            Next
            ExcelWorkSheet.SaveAs(SaveFileDialog1.FileName)
            ExcelWorkBook.Close()
            ExcelApp.Quit()

            releaseObject(ExcelApp)
            releaseObject(ExcelWorkBook)
            releaseObject(ExcelWorkSheet)

            MsgBox("Hasil export tersimpan!")

        End If
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
End Class