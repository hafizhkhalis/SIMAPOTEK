<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataObat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblNamaObat = New System.Windows.Forms.Label()
        Me.LblJenisObat = New System.Windows.Forms.Label()
        Me.LblMerkObat = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.CBJenisObat = New System.Windows.Forms.ComboBox()
        Me.TBJenisObatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseApotekDataSet = New SIMAPOTEK.DatabaseApotekDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnEditObat = New System.Windows.Forms.Button()
        Me.TB_JenisObatTableAdapter = New SIMAPOTEK.DatabaseApotekDataSetTableAdapters.TB_JenisObatTableAdapter()
        Me.BtnTambahObat = New System.Windows.Forms.Button()
        Me.BtnHapusObat = New System.Windows.Forms.Button()
        Me.BtnUpdateData = New System.Windows.Forms.Button()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.BtnSimpanData = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama_Obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jenis_Obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Merk_Obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stok_Obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TBJenisObatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseApotekDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNamaObat
        '
        Me.LblNamaObat.AutoSize = True
        Me.LblNamaObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaObat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNamaObat.Location = New System.Drawing.Point(96, 169)
        Me.LblNamaObat.Name = "LblNamaObat"
        Me.LblNamaObat.Size = New System.Drawing.Size(141, 29)
        Me.LblNamaObat.TabIndex = 0
        Me.LblNamaObat.Text = "Nama Obat:"
        '
        'LblJenisObat
        '
        Me.LblJenisObat.AutoSize = True
        Me.LblJenisObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisObat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblJenisObat.Location = New System.Drawing.Point(96, 212)
        Me.LblJenisObat.Name = "LblJenisObat"
        Me.LblJenisObat.Size = New System.Drawing.Size(134, 29)
        Me.LblJenisObat.TabIndex = 0
        Me.LblJenisObat.Text = "Jenis Obat:"
        '
        'LblMerkObat
        '
        Me.LblMerkObat.AutoSize = True
        Me.LblMerkObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMerkObat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblMerkObat.Location = New System.Drawing.Point(96, 256)
        Me.LblMerkObat.Name = "LblMerkObat"
        Me.LblMerkObat.Size = New System.Drawing.Size(131, 29)
        Me.LblMerkObat.TabIndex = 0
        Me.LblMerkObat.Text = "Merk Obat:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox2.Location = New System.Drawing.Point(237, 173)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(137, 22)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox3.Location = New System.Drawing.Point(237, 260)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(137, 22)
        Me.TextBox3.TabIndex = 3
        '
        'CBJenisObat
        '
        Me.CBJenisObat.BackColor = System.Drawing.SystemColors.HighlightText
        Me.CBJenisObat.FormattingEnabled = True
        Me.CBJenisObat.Location = New System.Drawing.Point(237, 219)
        Me.CBJenisObat.Name = "CBJenisObat"
        Me.CBJenisObat.Size = New System.Drawing.Size(137, 24)
        Me.CBJenisObat.TabIndex = 4
        '
        'TBJenisObatBindingSource
        '
        Me.TBJenisObatBindingSource.DataMember = "TB_JenisObat"
        Me.TBJenisObatBindingSource.DataSource = Me.DatabaseApotekDataSet
        '
        'DatabaseApotekDataSet
        '
        Me.DatabaseApotekDataSet.DataSetName = "DatabaseApotekDataSet"
        Me.DatabaseApotekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nama_Obat, Me.Jenis_Obat, Me.Merk_Obat, Me.Stok_Obat})
        Me.DataGridView1.Location = New System.Drawing.Point(237, 311)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(642, 206)
        Me.DataGridView1.TabIndex = 5
        '
        'BtnEditObat
        '
        Me.BtnEditObat.Location = New System.Drawing.Point(544, 168)
        Me.BtnEditObat.Name = "BtnEditObat"
        Me.BtnEditObat.Size = New System.Drawing.Size(111, 38)
        Me.BtnEditObat.TabIndex = 6
        Me.BtnEditObat.Text = "Edit"
        Me.BtnEditObat.UseVisualStyleBackColor = True
        '
        'TB_JenisObatTableAdapter
        '
        Me.TB_JenisObatTableAdapter.ClearBeforeFill = True
        '
        'BtnTambahObat
        '
        Me.BtnTambahObat.Location = New System.Drawing.Point(544, 126)
        Me.BtnTambahObat.Name = "BtnTambahObat"
        Me.BtnTambahObat.Size = New System.Drawing.Size(111, 38)
        Me.BtnTambahObat.TabIndex = 6
        Me.BtnTambahObat.Text = "Tambah"
        Me.BtnTambahObat.UseVisualStyleBackColor = True
        '
        'BtnHapusObat
        '
        Me.BtnHapusObat.Location = New System.Drawing.Point(544, 211)
        Me.BtnHapusObat.Name = "BtnHapusObat"
        Me.BtnHapusObat.Size = New System.Drawing.Size(111, 38)
        Me.BtnHapusObat.TabIndex = 6
        Me.BtnHapusObat.Text = "Hapus"
        Me.BtnHapusObat.UseVisualStyleBackColor = True
        '
        'BtnUpdateData
        '
        Me.BtnUpdateData.Location = New System.Drawing.Point(544, 256)
        Me.BtnUpdateData.Name = "BtnUpdateData"
        Me.BtnUpdateData.Size = New System.Drawing.Size(111, 38)
        Me.BtnUpdateData.TabIndex = 6
        Me.BtnUpdateData.Text = "Update"
        Me.BtnUpdateData.UseVisualStyleBackColor = True
        '
        'TextBoxID
        '
        Me.TextBoxID.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxID.Location = New System.Drawing.Point(390, 173)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxID.Size = New System.Drawing.Size(25, 22)
        Me.TextBoxID.TabIndex = 7
        '
        'BtnSimpanData
        '
        Me.BtnSimpanData.Location = New System.Drawing.Point(544, 255)
        Me.BtnSimpanData.Name = "BtnSimpanData"
        Me.BtnSimpanData.Size = New System.Drawing.Size(111, 38)
        Me.BtnSimpanData.TabIndex = 8
        Me.BtnSimpanData.Text = "Simpan"
        Me.BtnSimpanData.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox1.Location = New System.Drawing.Point(237, 134)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(34, 22)
        Me.TextBox1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(96, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Stok Obat:"
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 125
        '
        'Nama_Obat
        '
        Me.Nama_Obat.HeaderText = "Nama Obat"
        Me.Nama_Obat.MinimumWidth = 6
        Me.Nama_Obat.Name = "Nama_Obat"
        Me.Nama_Obat.ReadOnly = True
        Me.Nama_Obat.Width = 125
        '
        'Jenis_Obat
        '
        Me.Jenis_Obat.HeaderText = "Jenis Obat"
        Me.Jenis_Obat.MinimumWidth = 6
        Me.Jenis_Obat.Name = "Jenis_Obat"
        Me.Jenis_Obat.ReadOnly = True
        Me.Jenis_Obat.Width = 125
        '
        'Merk_Obat
        '
        Me.Merk_Obat.HeaderText = "Merk Obat"
        Me.Merk_Obat.MinimumWidth = 6
        Me.Merk_Obat.Name = "Merk_Obat"
        Me.Merk_Obat.ReadOnly = True
        Me.Merk_Obat.Width = 125
        '
        'Stok_Obat
        '
        Me.Stok_Obat.HeaderText = "Stok Obat"
        Me.Stok_Obat.MinimumWidth = 6
        Me.Stok_Obat.Name = "Stok_Obat"
        Me.Stok_Obat.ReadOnly = True
        Me.Stok_Obat.Width = 125
        '
        'DataObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1031, 550)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnSimpanData)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.BtnUpdateData)
        Me.Controls.Add(Me.BtnHapusObat)
        Me.Controls.Add(Me.BtnTambahObat)
        Me.Controls.Add(Me.BtnEditObat)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CBJenisObat)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LblMerkObat)
        Me.Controls.Add(Me.LblJenisObat)
        Me.Controls.Add(Me.LblNamaObat)
        Me.Name = "DataObat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataObat"
        CType(Me.TBJenisObatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseApotekDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNamaObat As Label
    Friend WithEvents LblJenisObat As Label
    Friend WithEvents LblMerkObat As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents CBJenisObat As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnEditObat As Button
    Friend WithEvents DatabaseApotekDataSet As DatabaseApotekDataSet
    Friend WithEvents TBJenisObatBindingSource As BindingSource
    Friend WithEvents TB_JenisObatTableAdapter As DatabaseApotekDataSetTableAdapters.TB_JenisObatTableAdapter
    Friend WithEvents BtnTambahObat As Button
    Friend WithEvents BtnHapusObat As Button
    Friend WithEvents BtnUpdateData As Button
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents BtnSimpanData As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nama_Obat As DataGridViewTextBoxColumn
    Friend WithEvents Jenis_Obat As DataGridViewTextBoxColumn
    Friend WithEvents Merk_Obat As DataGridViewTextBoxColumn
    Friend WithEvents Stok_Obat As DataGridViewTextBoxColumn
End Class
