<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.BtnTransaksi = New System.Windows.Forms.Button()
        Me.BtnDataObat = New System.Windows.Forms.Button()
        Me.BtnHistory = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCek = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnTransaksi
        '
        Me.BtnTransaksi.Location = New System.Drawing.Point(121, 345)
        Me.BtnTransaksi.Name = "BtnTransaksi"
        Me.BtnTransaksi.Size = New System.Drawing.Size(225, 50)
        Me.BtnTransaksi.TabIndex = 0
        Me.BtnTransaksi.Text = "Transaksi Obat"
        Me.BtnTransaksi.UseVisualStyleBackColor = True
        '
        'BtnDataObat
        '
        Me.BtnDataObat.Location = New System.Drawing.Point(420, 345)
        Me.BtnDataObat.Name = "BtnDataObat"
        Me.BtnDataObat.Size = New System.Drawing.Size(225, 50)
        Me.BtnDataObat.TabIndex = 1
        Me.BtnDataObat.Text = "Data Obat"
        Me.BtnDataObat.UseVisualStyleBackColor = True
        '
        'BtnHistory
        '
        Me.BtnHistory.Location = New System.Drawing.Point(723, 345)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(225, 50)
        Me.BtnHistory.TabIndex = 2
        Me.BtnHistory.Text = "History Transaksi"
        Me.BtnHistory.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(195, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(694, 46)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sistem Informasi Management Apotek"
        '
        'BtnCek
        '
        Me.BtnCek.Location = New System.Drawing.Point(420, 446)
        Me.BtnCek.Name = "BtnCek"
        Me.BtnCek.Size = New System.Drawing.Size(225, 50)
        Me.BtnCek.TabIndex = 4
        Me.BtnCek.Text = "Cek Import Transaksi"
        Me.BtnCek.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1031, 550)
        Me.Controls.Add(Me.BtnCek)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHistory)
        Me.Controls.Add(Me.BtnDataObat)
        Me.Controls.Add(Me.BtnTransaksi)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Informasi Manajemen Apotek"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTransaksi As Button
    Friend WithEvents BtnDataObat As Button
    Friend WithEvents BtnHistory As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCek As Button
End Class
