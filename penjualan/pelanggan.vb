Imports MySql.Data.MySqlClient
Public Class Pelanggan

    'membuat kolom pada listview
    Private Sub PosisiList()
        With ListView1.Columns
            .Add("Kode Pelanggan", 150)
            .Add("Nama Pelanggan", 200)
            .Add("Alamat", 250)
            .Add("Telepon", 150)
        End With
    End Sub

    'MEMBUAT PENCARIAN DATA
    Private Sub caridatapelanggan()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbl_pelanggan WHERE kodePelanggan like '%" & Trim(txtCari.Text) & "%' OR nama like '%" & Trim(txtCari.Text) & "%' "
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
                txtKodePelanggan.Text = .Item(0).SubItems(0).Text
                txtNamaPelanggan.Text = .Item(0).SubItems(1).Text
                txtalamat.Text = .Item(0).SubItems(2).Text
                txtTelepon.Text = .Item(0).SubItems(3).Text
            Catch ex As Exception

            End Try
        End With
    End Sub



    Private Sub bersih()
        txtKodePelanggan.Text = ""
        txtNamaPelanggan.Text = ""
        txtalamat.Text = ""
        txtTelepon.Text = ""
    End Sub



    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBersih.Click
        bersih()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            Query = "INSERT INTO tbl_pelanggan VALUES('" & txtKodePelanggan.Text & "','" & txtNamaPelanggan.Text & "', '" & txtalamat.Text & "','" & txtTelepon.Text & "')"
            dData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            dData.Fill(dsData)
            txtKodePelanggan.Focus()
            IsiList()
            bersih()
        Catch ex As Exception
            MsgBox("Kode Pelanggan ini sudah Ada!", MsgBoxStyle.Exclamation, "Error")
            txtKodePelanggan.Focus()
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
                    txtKodePelanggan.Focus()
                    Exit Sub
                Case vbOK
                    If txtKodePelanggan.Text = "" Then
                        MsgBox("Input Kode Pelanggan yang akan di hapus", MsgBoxStyle.Critical, "Data Kosong")
                        txtKodePelanggan.Focus()
                    Else
                        Query = "DELETE FROM tbl_pelanggan WHERE kodePelanggan='" & txtKodePelanggan.Text & "'"
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
            Query = "UPDATE tbl_pelanggan SET nama='" & txtNamaPelanggan.Text & "',alamat='" & txtalamat.Text & "',telepon='" & txtTelepon.Text & "' WHERE kodePelanggan='" & txtKodePelanggan.Text & "'"
            dData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            dData.Fill(dsData)
            IsiList()
            bersih()
            txtKodePelanggan.Focus()
            MsgBox("Data berhasil Di edit!", MsgBoxStyle.Critical, "Edit Data")
        Catch ex As Exception
            MsgBox("Data Gagal Di koreksi", MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDatadariListview()

    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        caridatapelanggan()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        caridatapelanggan()
    End Sub

    Private Sub Pelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksikeDatabase()
        IsiList()
        PosisiList()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class