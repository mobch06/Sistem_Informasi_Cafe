Imports WindowsApp1.ConnDB
Imports WindowsApp1.TampilMenu
Imports System.Data.Odbc
Imports System.Windows.Forms.DataVisualization.Charting

Public Class DashboardWindows
    Dim cmd As OdbcCommand
    Dim da As OdbcDataAdapter
    Dim dr As OdbcDataReader
    Private Sub DashboardWindows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginForm.Hide()

        Call tampilSemuaPesanan()
        Call tampilBelumSelesai()
        Call tampilSelesai()

        Panel_Home.Show()
        Panel_Dashboard.Hide()
        Panel_Menu.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel_Home.Show()
        Panel_Dashboard.Hide()
        Panel_Menu.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel_Home.Hide()
        Panel_Dashboard.Show()
        Panel_Menu.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call tampil_Menu()
        Panel_Home.Hide()
        Panel_Dashboard.Hide()
        Panel_Menu.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        laporanPenjualan.Show()
    End Sub

    Private Sub mainCourseBtn_Click(sender As Object, e As EventArgs) Handles mainCourseBtn.Click
        Call graph("maincourse")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call graph("sidedish")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call graph("dessert")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Call graph("drinks")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call openConn()

        query = "INSERT INTO `menus` (`kategori`, `nama`, `harga`, `pesan`) 
                    VALUES (
    
                '" & menu_kategoriBox.Text & "',
                '" & menu_namaBox.Text & "',
                '" & Val(menu_hargaBox.Text) & "',
                '0')"
        cmd = New OdbcCommand(query, conn)
        cmd.ExecuteNonQuery()
        Call tampil_Menu()
    End Sub

    Private Sub Menu_DataMenu_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Menu_DataMenu.CellMouseClick
        menu_ubahNamaBox.Text = Menu_DataMenu.Rows(e.RowIndex).Cells(2).Value
        menu_ubahKategoriBox.Text = Menu_DataMenu.Rows(e.RowIndex).Cells(1).Value
        menu_ubahHargaBox.Text = Menu_DataMenu.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call openConn()

        query = "UPDATE `menus` 
                    SET 
                        `kategori`='" & menu_ubahKategoriBox.Text & "',
                        `nama` = '" & menu_ubahNamaBox.Text & "',
                        `harga` = '" & menu_ubahHargaBox.Text & "'
                    WHERE `id` = '" & Val(Menu_DataMenu.SelectedRows(0).Cells(0).Value) & "'
                "
        cmd = New OdbcCommand(query, conn)
        cmd.ExecuteNonQuery()

        Call closeConn()
    End Sub
End Class