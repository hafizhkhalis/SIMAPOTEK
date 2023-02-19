Imports System.Data.OleDb
Public Class DataObat
    Private Sub DataObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TampilDataGridView()
        TampilDataComboBox()
        Disable()
        BtnUpdateData.Hide()

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

    Sub TampilDataComboBox()
        Call Koneksi()
        Cmd = New OleDbCommand("Select * From TB_JenisObat", Conn)
        CBJenisObat.Items.Clear()
        Rd = Cmd.ExecuteReader
        Do While Rd.Read = True
            CBJenisObat.Items.Add(Rd.Item("Jenis_Obat"))
        Loop
    End Sub

    Sub Disable()
        TextBox1.Enabled = False
        TextBoxID.Enabled = False
        TextBox2.Enabled = False
        CBJenisObat.Enabled = False
        TextBox3.Enabled = False
        BtnUpdateData.Enabled = False
        BtnEditObat.Enabled = False
        BtnSimpanData.Enabled = False
        BtnHapusObat.Enabled = False
    End Sub

    Sub Enable()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
    End Sub

    Sub EnableAll()
        CBJenisObat.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        TextBoxID.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        CBJenisObat.Text = DataGridView1.Item(2, i).Value
        TextBox3.Text = DataGridView1.Item(3, i).Value
        TextBox1.Text = DataGridView1.Item(4, i).Value

        BtnEditObat.Enabled = True
        BtnHapusObat.Enabled = True

    End Sub

    Private Sub BtnEditObat_Click(sender As Object, e As EventArgs) Handles BtnEditObat.Click
        Enable()
        DataGridView1.Enabled = False
        BtnTambahObat.Enabled = False
        BtnEditObat.Enabled = False
        BtnUpdateData.Enabled = True
        BtnUpdateData.Show()
        BtnSimpanData.Hide()
        BtnHapusObat.Enabled = False
    End Sub

    Private Sub BtnUpdateData_Click(sender As Object, e As EventArgs) Handles BtnUpdateData.Click
        DataGridView1.Enabled = True
        BtnUpdateData.Enabled = False
        EditDataObat()
        Disable()
        BtnSimpanData.Show()
        BtnUpdateData.Hide()
        BtnTambahObat.Enabled = True
        BtnHapusObat.Enabled = False
    End Sub

    Sub EditDataObat()
        Call Koneksi()
        Dim EditData = "Update TB_DataObat set Nama_Obat='" & TextBox2.Text & "',Jenis_Obat='" & CBJenisObat.Text & "',Merk_Obat='" & TextBox3.Text & "',Stok_Obat='" & TextBox1.Text & "' where ID=@id"
        Cmd = New OleDbCommand(EditData, Conn)
        Cmd.Parameters.Add("id", OleDbType.Integer).Value = TextBoxID.Text
        Cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Diedit")
        TampilDataGridView()
    End Sub

    Private Sub BtnTambahObat_Click(sender As Object, e As EventArgs) Handles BtnTambahObat.Click
        DataGridView1.Enabled = False
        TextBoxID.Text = 0
        TextBox1.Text = 0
        TextBox2.Text = ""
        CBJenisObat.Text = ""
        TextBox3.Text = ""
        EnableAll()
        BtnSimpanData.Enabled = True
        BtnTambahObat.Enabled = False
        BtnEditObat.Enabled = False
        BtnHapusObat.Enabled = False
    End Sub

    Private Sub BtnSimpanData_Click(sender As Object, e As EventArgs) Handles BtnSimpanData.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or CBJenisObat.Text = "" Then
            MsgBox("Pastikan semua data telah diisi!")
        Else
            Call Koneksi()
            Dim InsertData = "Insert Into TB_DataObat (Nama_Obat,Jenis_Obat, Merk_Obat, Stok_Obat) VALUES ('" & TextBox2.Text & "','" & CBJenisObat.Text & "','" & TextBox3.Text & "','" & TextBox1.Text & "');"
            Cmd = New OleDbCommand(InsertData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Ditambah")
            TampilDataGridView()

            DataGridView1.Enabled = True
            BtnSimpanData.Enabled = False
            Disable()
            BtnTambahObat.Enabled = True
        End If

    End Sub

    Private Sub BtnHapusObat_Click(sender As Object, e As EventArgs) Handles BtnHapusObat.Click
        Call Koneksi()
        Dim DeleteData = "Delete from TB_DataObat where ID=@id"
        Cmd = New OleDbCommand(DeleteData, Conn)
        Cmd.Parameters.Add("id", OleDbType.Integer).Value = TextBoxID.Text
        Cmd.ExecuteNonQuery()
        MsgBox("Data berhasil dihapus")
        TextBoxID.Text = 0
        TextBox1.Text = 0
        TextBox2.Text = ""
        CBJenisObat.Text = ""
        TextBox3.Text = ""
        BtnHapusObat.Enabled = False
        BtnEditObat.Enabled = False
        TampilDataGridView()
    End Sub
End Class