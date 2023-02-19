Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Transaksi
    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDataComboBox()
        TampilDataGridView()

        ComboBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox2.Hide()
        TextBox3.Enabled = False
        TextBox1.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker1.Hide()

    End Sub

    Sub TampilDataComboBox()
        Call Koneksi()
        Cmd = New OleDbCommand("Select * From TB_DataObat", Conn)
        ComboBox1.Items.Clear()
        Rd = Cmd.ExecuteReader
        Do While Rd.Read = True
            ComboBox1.Items.Add(Rd.Item("Merk_Obat"))
        Loop
    End Sub

    Private Sub BtnBeli_Click(sender As Object, e As EventArgs) Handles BtnBeli.Click
        If TextBox3.Text < TextBox1.Text Then
            MsgBox("Stok barang sisa " & TextBox3.Text & "")
        Else
            Dim Stock As Integer = TextBox3.Text - TextBox1.Text
            Call Koneksi()
            Dim EditData = "Update TB_DataObat set Stok_Obat='" & Stock & "' where ID=@id"
            Cmd = New OleDbCommand(EditData, Conn)
            Cmd.Parameters.Add("id", OleDbType.Integer).Value = TextBox2.Text
            Cmd.ExecuteNonQuery()
            MsgBox("Obat Berhasil Terbeli")
            TampilDataGridView()
            InputTransaksi()
            TextBox1.Text = 0
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        ComboBox1.Text = DataGridView1.Item(3, i).Value
        TextBox2.Text = DataGridView1.Item(0, i).Value
        TextBox3.Text = DataGridView1.Item(4, i).Value

        TextBox1.Enabled = True
    End Sub

    Sub GetData()
        Call Koneksi()
        Cmd = New OleDbCommand("Select * From TB_DataObat", Conn)
        Rd = Cmd.ExecuteReader
    End Sub

    Sub TampilDataGridView()
        GetData()
        DataGridView1.Rows.Clear()
        Do While Rd.Read = True
            DataGridView1.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3), Rd(4))
        Loop
    End Sub

    Sub InputTransaksi()
        Call Koneksi()
        Dim InsertData = "Insert Into TB_Transaksi (Merk_Obat,Jumlah_Obat, Tanggal) VALUES ('" & ComboBox1.Text & "','" & TextBox1.Text & "','" & DateTimePicker1.Value & "');"
        Cmd = New OleDbCommand(InsertData, Conn)
        Cmd.ExecuteNonQuery()
    End Sub
End Class