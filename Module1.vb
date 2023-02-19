Imports System.Data.OleDb
Module Module1
    Public Conn As OleDbConnection
    Public Cmd As OleDbCommand
    Public Rd As OleDbDataReader
    Public LokasiDB As String
    Sub Koneksi()
        LokasiDB = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=DatabaseApotek.accdb"
        Conn = New OleDbConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

End Module
