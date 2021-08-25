Imports MySql.Data.MySqlClient
Public Class FormPenjualan
    Dim idjual As String

    Private Sub proseshasil()
        txttotal.Text = txtHargaJual.Text * txtQtyjual.Text
        txtkembalian.Text = txtbayar.Text - txttotal.Text
    End Sub

    Private Sub AmbilDatadariListView()
        With ListView1.SelectedItems
            Try
                txtnofaktur.Text = .Item(0).SubItems(1).Text
                dtgtglfaktur.Text = .Item(0).SubItems(2).Text
                txtKodeProduk.Text = .Item(0).SubItems(3).Text
                txtnamaproduk.Text = .Item(0).SubItems(4).Text
                txtKodePelanggan.Text = .Item(0).SubItems(5).Text
                txtNamaPelanggan.Text = .Item(0).SubItems(6).Text
                txtHargaJual.Text = .Item(0).SubItems(8).Text
                txtQtyjual.Text = .Item(0).SubItems(7).Text
                txttotal.Text = .Item(0).SubItems(9).Text
                txtbayar.Text = .Item(0).SubItems(10).Text
                txtkembalian.Text = .Item(0).SubItems(11).Text

            Catch ex As Exception

            End Try
        End With
    End Sub

    Private Sub posisilist()
        With ListView1.Columns
            .Add("id jual", 100)
            .Add("No Faktur", 100)
            .Add("tanggal jual", 100)
            .Add("Kode Produk", 100)
            .Add("Nama Produk", 100)
            .Add("Kode Pelanggan", 100)
            .Add("Nama Pelanggan", 100)
            .Add("Jumlah Jual", 100)
            .Add("harga Jual", 100)
            .Add("Bayar", 100)
            .Add("Total", 100)
            .Add("Kembalian", 100)
        End With
    End Sub

    Private Sub bersih()
        txtnofaktur.Text = ""
        dtgtglfaktur.Text = ""
        txtKodePelanggan.Text = ""
        txtNamaPelanggan.Text = ""
        txtKodeProduk.Text = ""
        txtnamaproduk.Text = ""
        txtHargaJual.Text = ""
        txtQtyjual.Text = ""
        txttotal.Text = ""
        txtbayar.Text = ""
        txtkembalian.Text = ""
    End Sub

    Private Sub isilist()
        Dim a As Integer
        Try
            Query = "SELECT * FROM relasipenjualan ORDER BY nomorFaktur"
            dData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            dData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(10))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(11))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(14))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(15))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(16))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(18))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(17))
                End With
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        CariDataFaktur.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        caripelanggan.Show()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CariDataProduk.Show()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        proseshasil()

    End Sub

    Private Sub FormPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksikeDatabase()
        posisilist()
        isilist()

    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            If txtnofaktur.Text = "" Or dtgtglfaktur.Text = "" Or txtKodePelanggan.Text = "" Or txtKodeProduk.Text = "" Or txtnamaproduk.Text = "" Then
                MsgBox("Silahkan lengkapi data terlebih dahulu !", MsgBoxStyle.Critical, "Pesan Data kosong")
            Else

                Call KoneksikeDatabase()
                cmd = New MySqlCommand("SELECT * FROM tbl_jual WHERE nomorFaktur='" & txtnofaktur.Text & "' and kodePelanggan='" & txtKodePelanggan.Text & "'", Conn)
                RD = cmd.ExecuteReader
                RD.Read()
                If RD.HasRows = True Then
                    MsgBox("nomor faktur dan Kode pelanggan ini sudah ada!", MsgBoxStyle.Critical, "pesan ganda")
                Else
                    Call KoneksikeDatabase()
                    Query = "INSERT INTO tbl_jual(nomorFaktur,kodeProduk,kodePelanggan,jumlahJual,hargaJual,bayar,kembalian,total) VALUES ('" & txtnofaktur.Text & "','" & txtKodeProduk.Text & "','" & txtKodePelanggan.Text & "','" & txtQtyjual.Text & "','" & txtHargaJual.Text & "','" & txtbayar.Text & "','" & txtkembalian.Text & "','" & txttotal.Text & "')"
                    dData = New MySqlDataAdapter(Query, Conn)
                    dsData = New DataSet
                    dData.Fill(dsData)
                    MsgBox("Data berhasil disimpan", MsgBoxStyle.Critical, "data di simpan")
                    txtnofaktur.Focus()
                    posisilist()
                    isilist()
                    txtKodeProduk.Text = ""
                    txtnamaproduk.Text = ""
                    txtKodePelanggan.Text = ""
                    txtNamaPelanggan.Text = ""
                    txtQtyjual.Text = ""
                    txtHargaJual.Text = ""
                    txttotal.Text = ""
                    txtbayar.Text = ""
                    txtkembalian.Text = ""
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BersihkanData()
        txtnofaktur.Text = ""
        dtgtglfaktur.Text = ""
        txtKodePelanggan.Text = ""
        txtNamaPelanggan.Text = ""
        txtKodeProduk.Text = ""
        txtnamaproduk.Text = ""
        txtHargaJual.Text = ""
        txtQtyjual.Text = ""
        txtbayar.Text = ""
        txttotal.Text = ""
        txtkembalian.Text = ""
    End Sub

    Private Sub btnBersih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBersih.Click
        BersihkanData()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDatadariListView()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If txtnofaktur.Text = "" Or txtKodePelanggan.Text = "" Or txtKodeProduk.Text = "" Or txtHargaJual.Text = "" Or txtQtyjual.Text = "" Or txtbayar.Text = "" Or txttotal.Text = "" Or txtkembalian.Text = "" Then
                MsgBox("Lengkapi Data yang Akan di EDIT", MsgBoxStyle.Critical, "Pesan Kosong")
            Else
                Query = "UPDATE tbl_jual SET nomorFaktur='" & txtnofaktur.Text & "', kodePelanggan='" & txtKodePelanggan.Text & "', kodeProduk='" & txtKodeProduk.Text & "', hargaJual='" & txtHargaJual.Text & "', jumlahJual='" & txtQtyjual.Text & "', bayar='" & txtbayar.Text & "',total='" & txttotal.Text & "',kembalian='" & txtkembalian.Text & "' WHERE nomorFaktur='" & txtnofaktur.Text & "'"
                dData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                dData.Fill(dsData)
                MsgBox("Data berhasil di EDIT!", MsgBoxStyle.Critical, "EDIT")
                isilist()
                BersihkanData()
                txtnofaktur.Focus()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim A As String
            A = MsgBox("Benar Data Akan di Hapus..??", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, " DELETE DATA")
            Select Case A
                Case vbCancel
                    txtnofaktur.Focus()
                    Exit Sub
                Case vbOK
                    Query = "DELETE FROM tbl_jual WHERE nomorFaktur='" & txtnofaktur.Text & "'"
                    dData = New MySqlDataAdapter(Query, Conn)
                    dsData = New DataSet
                    dData.Fill(dsData)
                    isilist()
                    BersihkanData()
                    MsgBox("Data Berhasil di DELETE", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub


    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
End Class