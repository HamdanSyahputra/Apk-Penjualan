Imports MySql.Data.MySqlClient
Public Class caripelanggan
    Private Sub PosisiList()
        With ListView1.Columns
            .Add("Kode Pelangan", 150)
            .Add("Nama Pelanggan", 150)
            .Add("Alamat", 150)
            .Add("Telepon", 100)
        End With
    End Sub

    Private Sub IsiList()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbl_pelanggan ORDER BY kodePelanggan"
            dData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            dData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    If (a Mod 2 = 0) Then
                        .Items(a).BackColor = Color.LightBlue
                    Else
                        .Items(a).BackColor = Color.Lavender
                    End If
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AmbilDatadariListview()
        With ListView1.SelectedItems
            Try
                FormPenjualan.txtKodePelanggan.Text = .Item(0).SubItems(0).Text
                FormPenjualan.txtNamaPelanggan.Text = .Item(0).SubItems(1).Text
            Catch ex As Exception

            End Try
        End With
    End Sub

    Private Sub caridatapelanggan()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbl_produk WHERE kodePelanggan like '%" & Trim(txtCariData.Text) & "%' OR namaPelanggan like '%" & Trim(txtCariData.Text) & "%' "
            dData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            dData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDatadariListview()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        caridatapelanggan()

    End Sub

    Private Sub caripelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksikeDatabase()
        PosisiList()
        IsiList()
    End Sub

    Private Sub txtCariData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariData.TextChanged
        caridatapelanggan()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class