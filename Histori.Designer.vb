<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Histori
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Kode_Transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Merk_Obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah_Obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode_Transaksi, Me.Merk_Obat, Me.Jumlah_Obat, Me.Tanggal})
        Me.DataGridView1.Location = New System.Drawing.Point(28, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(575, 264)
        Me.DataGridView1.TabIndex = 0
        '
        'Kode_Transaksi
        '
        Me.Kode_Transaksi.HeaderText = "Kode_Transaksi"
        Me.Kode_Transaksi.MinimumWidth = 6
        Me.Kode_Transaksi.Name = "Kode_Transaksi"
        Me.Kode_Transaksi.ReadOnly = True
        Me.Kode_Transaksi.Width = 125
        '
        'Merk_Obat
        '
        Me.Merk_Obat.HeaderText = "Merk_Obat"
        Me.Merk_Obat.MinimumWidth = 6
        Me.Merk_Obat.Name = "Merk_Obat"
        Me.Merk_Obat.ReadOnly = True
        Me.Merk_Obat.Width = 125
        '
        'Jumlah_Obat
        '
        Me.Jumlah_Obat.HeaderText = "Jumlah_Obat"
        Me.Jumlah_Obat.MinimumWidth = 6
        Me.Jumlah_Obat.Name = "Jumlah_Obat"
        Me.Jumlah_Obat.ReadOnly = True
        Me.Jumlah_Obat.Width = 125
        '
        'Tanggal
        '
        Me.Tanggal.HeaderText = "Tanggal"
        Me.Tanggal.MinimumWidth = 6
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.ReadOnly = True
        Me.Tanggal.Width = 125
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Location = New System.Drawing.Point(28, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Export"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Histori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(651, 354)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Histori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histori"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Kode_Transaksi As DataGridViewTextBoxColumn
    Friend WithEvents Merk_Obat As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah_Obat As DataGridViewTextBoxColumn
    Friend WithEvents Tanggal As DataGridViewTextBoxColumn
End Class
