Imports WindowsApp1.ConnDB
Imports System.Data.Odbc
Imports WindowsApp1.mainWindow
Public Class Checkout
    Dim cmd As OdbcCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call openConn()
        Dim orderID As String = GenerateOrderID()

        For i As Integer = 0 To mainWindow.ListPesanan.Items.Count - 1
            Dim seperator As String = ". "
            Dim seperatorIndex = mainWindow.ListPesanan.Items(i).SubItems(3).Text.IndexOf(seperator)
            Dim harga As Double



            If seperatorIndex >= 0 Then
                Dim value As Double = mainWindow.ListPesanan.Items(i).SubItems(3).Text.Substring(seperatorIndex + seperator.Length)
                harga = value
            End If
            query = "INSERT INTO `orders`( `id`, `order_id`, `username`, `kategori`, `nama`, `harga`, `pesan`, `total`, `status`, `tanggal`)
                        VALUES
                        (
                         NULL,
                         '" & orderID & "',
                         '" & TextBox1.Text & "',
                         '" & mainWindow.ListPesanan.Items(i).SubItems(1).Text & "',
                         '" & mainWindow.ListPesanan.Items(i).SubItems(0).Text & "',
                         '" & harga & "',
                         '" & mainWindow.ListPesanan.Items(i).SubItems(2).Text & "',
                         '" & Val(mainWindow.ListPesanan.Items(i).SubItems(4).Text) & "',
                         '0',
                         CURRENT_TIMESTAMP
                        )"
            cmd = New OdbcCommand(query, conn)
            cmd.ExecuteNonQuery()
        Next
        MsgBox("Pesanan Telah di Buat, Silahkan Menunggu Pesanan Anda")
        mainWindow.ListPesanan.Items.Clear()
        mainWindow.Label10.Text = 0
        mainWindow.Label8.Text = 0
        Me.Close()

        closeConn()
    End Sub
End Class