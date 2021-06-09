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

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Call openConn()

        query = "DELETE FROM `menus` WHERE `menus`.`nama`= '" & menu_ubahNamaBox.Text & "'"

        cmd = New OdbcCommand(query, conn)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Call closeConn()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Call tampilOrder(TextBox7.Text)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        Dim query As String = "UPDATE orders SET status = 1 WHERE order_id = '" & TextBox7.Text & "'"
        cmd = New OdbcCommand(query, conn)
        Try
            cmd.ExecuteNonQuery()

            Call tampilSemuaPesanan()
            Call tampilBelumSelesai()
            Call tampilSelesai()
        Catch ex As Exception

        End Try

    End Sub

End Class