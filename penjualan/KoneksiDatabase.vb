Imports MySql.Data.MySqlClient
Module koneksi
    Public Conn As New MySql.Data.MySqlClient.MySqlConnection
    Public dData As New MySqlDataAdapter
    Public dsData As New DataSet
    Public Query As String
    Public baca As MySqlDataReader
    Public RD As MySqlDataReader
    Public cmd As New MySqlCommand

    Public Sub KoneksikeDatabase()
        Try
            Dim str As String = "Server=localhost;user id=root;database=db_sistem_penjualan"
            Conn = New MySqlConnection(str)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MsgBox("Koneksi Ke server gagal")
        End Try
    End Sub
End Module
