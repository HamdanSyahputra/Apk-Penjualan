Imports MySql.Data.MySqlClient
Public Class CariDataProduk
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

    Private Sub CariDataProduk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        KoneksikeDatabase()
        IsiList()
        PosisiList()
    End Sub

    'MEMBUAT PENCARIAN DATA
    Private Sub caridataproduk()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbl_produk WHERE kodeProduk like '%" & Trim(txtCariData.Text) & "%' OR namaProduk like '%" & Trim(txtCariData.Text) & "%' "
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


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        caridataproduk()
    End Sub

    Private Sub AmbilDatadariListview()
        With ListView1.SelectedItems
            Try
                FormPenjualan.txtKodeProduk.Text = .Item(0).SubItems(0).Text
                FormPenjualan.txtnamaproduk.Text = .Item(0).SubItems(1).Text
            Catch ex As Exception

            End Try
        End With
    End Sub



    Private Sub CariDataProduk_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksikeDatabase()
        PosisiList()
        IsiList()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDatadariListview()
        Me.Close()
    End Sub

    Private Sub txtCariData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariData.TextChanged
        caridataproduk()
    End Sub
End Class