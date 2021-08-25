Imports MySql.Data.MySqlClient
Public Class produk
    'membuat kolom pada listview
    Private Sub PosisiList()
        With ListView1.Columns
            .Add("Kode Produk", 150)
            .Add("Nama Produk", 200)
            .Add("Kemasan", 120)
            .Add("Ukuran", 90)
            .Add("Harga Beli", 150)
            .Add("Persediaan", 120)
        End With
    End Sub

    'MEMBUAT PENCARIAN DATA
    Private Sub caridataproduk()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbl_produk WHERE kodeProduk like '%" & Trim(txtCari.Text) & "%' OR namaProduk like '%" & Trim(txtCari.Text) & "%' "
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
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub


    'menampilkan data pada listview
    Private Sub IsiList()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbl_produk ORDER BY kodeProduk"
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
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
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
                txtKodeProduk.Text = .Item(0).SubItems(0).Text
                txtNamaProduk.Text = .Item(0).SubItems(1).Text
                txtKemasan.Text = .Item(0).SubItems(2).Text
                txtUkuran.Text = .Item(0).SubItems(3).Text
                txtHargaBeli.Text = .Item(0).SubItems(4).Text
                txtPersediaan.Text = .Item(0).SubItems(5).Text
            Catch ex As Exception

            End Try
        End With
    End Sub



    Private Sub bersih()
        txtKodeProduk.Text = ""
        txtNamaProduk.Text = ""
        txtKemasan.Text = ""
        txtUkuran.Text = ""
        txtHargaBeli.Text = ""
        txtPersediaan.Text = ""
    End Sub


    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBersih.Click
        bersih()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            Query = "INSERT INTO tbl_produk VALUES('" & txtKodeProduk.Text & "','" & txtNamaProduk.Text & "', '" & txtKemasan.Text & "','" & txtUkuran.Text & "','" & txtHargaBeli.Text & "' ,'" & txtPersediaan.Text & "')"
            dData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            dData.Fill(dsData)
            txtKodeProduk.Focus()
            IsiList()
            bersih()
        Catch ex As Exception
            MsgBox("Kode Pelanggan ini sudah Ada!", MsgBoxStyle.Exclamation, "Error")
            txtKodeProduk.Focus()
        End Try
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim A As String
            A = MsgBox("Benar Data Akan di hapus...!", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Hapus Data")
            Select Case A
                Case vbCancel
                    txtKodeProduk.Focus()
                    Exit Sub
                Case vbOK
                    If txtKodeProduk.Text = "" Then
                        MsgBox("Input Kode Pelanggan yang akan di hapus", MsgBoxStyle.Critical, "Data Kosong")
                        txtKodeProduk.Focus()
                    Else
                        Query = "DELETE FROM tbl_produk WHERE kodeProduk='" & txtKodeProduk.Text & "'"
                        dData = New MySqlDataAdapter(Query, Conn)
                        dsData = New DataSet
                        dData.Fill(dsData)
                        IsiList()
                        bersih()
                        MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "hapus Data")
                    End If
            End Select
        Catch ex As Exception
            MsgBox("Data tidak bisa Di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "hapus Data")
        End Try
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            Query = "UPDATE tbl_produk SET namaProduk='" & txtNamaProduk.Text & "',kemasan='" & txtKemasan.Text & "',ukuran='" & txtUkuran.Text & "',hargaBeli='" & txtHargaBeli.Text & "' ,persediaan='" & txtPersediaan.Text & "' WHERE kodeProduk='" & txtKodeProduk.Text & "'"
            dData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            dData.Fill(dsData)
            IsiList()
            bersih()
            txtKodeProduk.Focus()
            MsgBox("Data berhasil Di edit!", MsgBoxStyle.Critical, "Edit Data")
        Catch ex As Exception
            MsgBox("Data Gagal Di koreksi", MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDatadariListview()

    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        caridataproduk()
    End Sub
    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        caridataproduk()
    End Sub

    Private Sub produk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksikeDatabase()
        IsiList()
        PosisiList()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class