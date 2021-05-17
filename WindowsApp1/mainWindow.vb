Imports WindowsApp1.loginForm
Imports System.Data.Odbc
Imports WindowsApp1.ConnDB
Imports WindowsApp1.TampilMenu

Public Class mainWindow
    Dim cmd As OdbcCommand
    Dim da As OdbcDataAdapter
    Dim dr As OdbcDataReader

    Private Sub mainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call openConn()

        ''Memanggil Nama Customer
        'Dim query As String = "SELECT * FROM user WHERE username='" + loginForm.usernameTextBox.Text + "'"
        'cmd = New OdbcCommand(query, conn)
        'da = New OdbcDataAdapter
        'da.SelectCommand = cmd
        'dr = cmd.ExecuteReader()
        'dr.Read()

        'If loginForm.login = True Then
        '    namaCst_Lbl.Text = dr("fullname")
        '    LinkLabel1.Text = "Logout"
        'Else
        '    namaCst_Lbl.Text = ""
        'End If

        jmlBox.Text = 0
        totalHargaBox.Text = "Rp. 0"
        loginForm.Hide()
        Call Header_Lv()
        Call tampilMC()
        Call tampilSD()
        Call tampilDr()
        Call tampilDs()

    End Sub

    Private Sub ListMainCourse_MouseClick(sender As Object, e As MouseEventArgs) Handles ListMainCourse.MouseClick
        namaMenuBox.Text = ListMainCourse.Items(ListMainCourse.SelectedIndices(0)).SubItems(0).Text
        kategoriLbl.Text = ListMainCourse.Items(ListMainCourse.SelectedIndices(0)).SubItems(1).Text
        hargaMenuBox.Text = ListMainCourse.Items(ListMainCourse.SelectedIndices(0)).SubItems(2).Text
        jmlBox.Text = 0
    End Sub

    Private Sub ListSideDish_MouseClick(sender As Object, e As MouseEventArgs) Handles ListSideDish.MouseClick
        namaMenuBox.Text = ListSideDish.Items(ListSideDish.SelectedIndices(0)).SubItems(0).Text
        kategoriLbl.Text = ListSideDish.Items(ListSideDish.SelectedIndices(0)).SubItems(1).Text
        hargaMenuBox.Text = ListSideDish.Items(ListSideDish.SelectedIndices(0)).SubItems(2).Text
        jmlBox.Text = 0
    End Sub
    Private Sub ListDrinks_MouseClick(sender As Object, e As MouseEventArgs) Handles ListDrinks.MouseClick
        namaMenuBox.Text = ListDrinks.Items(ListDrinks.SelectedIndices(0)).SubItems(0).Text
        kategoriLbl.Text = ListDrinks.Items(ListDrinks.SelectedIndices(0)).SubItems(1).Text
        hargaMenuBox.Text = ListDrinks.Items(ListDrinks.SelectedIndices(0)).SubItems(2).Text
        jmlBox.Text = 0
    End Sub
    Private Sub ListDessert_MouseClick(sender As Object, e As MouseEventArgs) Handles ListDessert.MouseClick
        namaMenuBox.Text = ListDessert.Items(ListDessert.SelectedIndices(0)).SubItems(0).Text
        kategoriLbl.Text = ListDessert.Items(ListDessert.SelectedIndices(0)).SubItems(1).Text
        hargaMenuBox.Text = ListDessert.Items(ListDessert.SelectedIndices(0)).SubItems(2).Text
        jmlBox.Text = 0
    End Sub
    Private Sub jmlBox_ValueChanged(sender As Object, e As EventArgs) Handles jmlBox.ValueChanged
        Dim seperator As String = ". "
        Dim seperatorIndex = hargaMenuBox.Text.IndexOf(seperator)
        If seperatorIndex >= 0 Then
            Dim value As Double = hargaMenuBox.Text.Substring(seperatorIndex + seperator.Length)
            totalHargaBox.Text = value * jmlBox.Value
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles tambahBtn.Click
        If Not ListPesanan.FindItemWithText(namaMenuBox.Text) Is Nothing Then
            For i As Integer = 0 To ListPesanan.Items.Count - 1

                If ListPesanan.Items(i).SubItems(0).Text = namaMenuBox.Text Then
                    ListPesanan.Items(i).SubItems(2).Text = Val(ListPesanan.Items(i).SubItems(2).Text) + jmlBox.Value
                    ListPesanan.Items(i).SubItems(4).Text = Val(ListPesanan.Items(i).SubItems(4).Text) + totalHargaBox.Text
                End If
            Next
        Else
            Dim Item As New ListViewItem(namaMenuBox.Text)

            Item.SubItems.Add(kategoriLbl.Text)
            Item.SubItems.Add(jmlBox.Text)
            Item.SubItems.Add(hargaMenuBox.Text)
            Item.SubItems.Add(totalHargaBox.Text)

            ListPesanan.Items.Add(Item)
        End If

        Call total()
    End Sub

    Private Sub ListPesanan_MouseClick(sender As Object, e As MouseEventArgs) Handles ListPesanan.MouseClick
        namaPesananBox.Text = ListPesanan.Items(ListPesanan.SelectedIndices(0)).SubItems(0).Text
        jmlPesanan.Value = ListPesanan.Items(ListPesanan.SelectedIndices(0)).SubItems(2).Text
        hargaPesananBox.Text = ListPesanan.Items(ListPesanan.SelectedIndices(0)).SubItems(3).Text
        totalHargaPesanan.Text = ListPesanan.Items(ListPesanan.SelectedIndices(0)).SubItems(4).Text
    End Sub

    Private Sub jmlPesanan_ValueChanged(sender As Object, e As EventArgs) Handles jmlPesanan.ValueChanged
        Dim seperator As String = ". "
        Dim seperatorIndex = hargaPesananBox.Text.IndexOf(seperator)
        If seperatorIndex >= 0 Then
            Dim value As Double = hargaPesananBox.Text.Substring(seperatorIndex + seperator.Length)
            totalHargaPesanan.Text = value * jmlPesanan.Value
        End If
    End Sub

    Private Sub ubahBtn_Click(sender As Object, e As EventArgs) Handles ubahBtn.Click
        ListPesanan.Items(ListPesanan.SelectedIndices(0)).SubItems(0).Text = namaPesananBox.Text
        ListPesanan.Items(ListPesanan.SelectedIndices(0)).SubItems(2).Text = jmlPesanan.Value
        ListPesanan.Items(ListPesanan.SelectedIndices(0)).SubItems(3).Text = hargaPesananBox.Text
        ListPesanan.Items(ListPesanan.SelectedIndices(0)).SubItems(4).Text = totalHargaPesanan.Text

        Call total()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Try
            ListPesanan.Items.RemoveAt(ListPesanan.SelectedIndices(0))
        Catch ex As Exception
            MsgBox("Gagal Menghapus, " & ex.ToString)
        End Try

        Call total()
    End Sub

    Private Sub checkoutBtn_Click(sender As Object, e As EventArgs) Handles checkoutBtn.Click
        If loginForm.login = True Then
            Call openConn()
            Dim orderID As String = GenerateOrderID()

            For i As Integer = 0 To ListPesanan.Items.Count - 1
                Dim seperator As String = ". "
                Dim seperatorIndex = ListPesanan.Items(i).SubItems(2).Text.IndexOf(seperator)
                Dim harga As Double
                Dim status As Boolean = 0

                If seperatorIndex >= 0 Then
                    Dim value As Double = ListPesanan.Items(i).SubItems(2).Text.Substring(seperatorIndex + seperator.Length)
                    harga = value
                End If
                query = "INSERT INTO `orders`(`id`, `order_id` `username`, `kategori`, `nama`, `harga`, `pesan` , `total`, `status`, `tanggal`)
                            VALUES
                        (
                        'NULL',
                        '" & orderID & "',
                        '" & loginForm.usernameTextBox.Text & "',
                        '" & ListPesanan.Items(i).SubItems(1).Text & "',
                        '" & ListPesanan.Items(i).SubItems(0).Text & "',
                        '" & harga & "',
                        '" & ListPesanan.Items(i).SubItems(1).Text & "',
                        '" & Val(ListPesanan.Items(i).SubItems(3).Text) & "',
                        '" & status & "',
                        CURRENT_TIMESTAMP
                )"
                cmd = New OdbcCommand(query, conn)
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Pesanan Telah di Buat, Silahkan Menunggu Pesanan Anda")
            ListPesanan.Items.Clear()

            closeConn()
        Else
            Checkout.Show()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        loginForm.Show()
        Me.Hide()
    End Sub
End Class