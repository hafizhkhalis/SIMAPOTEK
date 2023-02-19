
Public Class Dashboard
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnDataObat.Click
        DataObat.Show()
    End Sub

    Private Sub BtnTransaksi_Click(sender As Object, e As EventArgs) Handles BtnTransaksi.Click
        Transaksi.Show()
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        Histori.Show()
    End Sub

    Private Sub BtnCek_Click(sender As Object, e As EventArgs) Handles BtnCek.Click
        Cek.Show()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Dashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
End Class