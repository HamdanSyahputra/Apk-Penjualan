Imports MySql.Data.MySqlClient
Public Class Faktur
    Private Sub PosisiList()
        With ListView1.Columns
            .Add("Nomor Faktur", 150)
            .Add("Kode Pelanggan", 200)
            .Add("Tanggal Jual", 150)
            .Add("Deskripsi", 150)
        End With
    End Sub

    'MEMBUAT PENCARIAN DATA
    Private Sub caridatafaktur()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbl_faktur WHERE nomorFaktur like '%" & Trim(txtCari.Text) & "%' OR kodePelanggan like '%" & Trim(txtCari.Text) & "%' "
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



    'menampilkan data pada listview
    Private Sub IsiList()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbl_faktur ORDER BY nomorFaktur"
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
                txtNoFaktur.Text = .Item(0).SubItems(0).Text
                txtKodePelanggan.Text = .Item(0).SubItems(1).Text
                dtpTglJual.Text = .Item(0).SubItems(2).Text
                txtDeskripsi.Text = .Item(0).SubItems(3).Text
            Catch ex As Exception

            End Try
        End With
    End Sub

    Private Sub bersih()
        txtNoFaktur.Text = ""
        txtKodePelanggan.Text = ""
        txtDeskripsi.Text = ""
    End Sub

    Private Sub Faktur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksikeDatabase()
        PosisiList()
        IsiList()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDatadariListview()
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        caridatafaktur()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        caridatafaktur()
    End Sub

    Private Sub btnBersih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBersih.Click
        bersih()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            Query = "INSERT INTO tbl_faktur VALUES('" & txtNoFaktur.Text & "','" & txtKodePelanggan.Text & "', '" & Format(dtpTglJual.Value, "yyyy/MM/dd") & "','" & txtDeskripsi.Text & "')"
            dData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            dData.Fill(dsData)
            txtNoFaktur.Focus()
            IsiList()
            bersih()
        Catch ex As Exception
            MsgBox("Nomor Faktur ini sudah tersedia!", MsgBoxStyle.Exclamation, "Error")
            txtNoFaktur.Focus()
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
                    txtNoFaktur.Focus()
                    Exit Sub
                Case vbOK
                    If txtNoFaktur.Text = "" Then
                        MsgBox("Input Nomor Faktur yang akan di hapus", MsgBoxStyle.Critical, "Data Kosong")
                        txtNoFaktur.Focus()
                    Else
                        Query = "DELETE FROM tbl_faktur WHERE nomorFaktur='" & txtNoFaktur.Text & "'"
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
            Query = "UPDATE tbl_faktur SET kodePelanggan='" & txtKodePelanggan.Text & "',tanggalJual='" & Format(dtpTglJual.Value, "yyyy/MM/dd") & "' , Deskripsi='" & txtDeskripsi.Text & "' WHERE nomorFaktur='" & txtNoFaktur.Text & "'"
            dData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            dData.Fill(dsData)
            IsiList()
            bersih()
            txtNoFaktur.Focus()
            MsgBox("Data berhasil Di edit!", MsgBoxStyle.Critical, "Edit Data")
        Catch ex As Exception
            MsgBox("Data Gagal Di koreksi", MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub txtNoFaktur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoFaktur.TextChanged

    End Sub
End Class