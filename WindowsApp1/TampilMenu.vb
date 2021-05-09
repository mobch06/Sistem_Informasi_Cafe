﻿Imports System.Data.Odbc
Imports WindowsApp1.mainWindow
Imports WindowsApp1.ConnDB
Imports System.Windows.Forms.DataVisualization.Charting

Module TampilMenu
    Public queryMC, querySD, queryDr, queryDs As String
    Public cmd As OdbcCommand
    Public da As OdbcDataAdapter
    Public dr As OdbcDataReader
    Public kategori As String
    Public Sub Header_Lv()
        If mainWindow.ListMainCourse.Columns.Count <= 0 Then
            mainWindow.ListMainCourse.Columns.Add("Nama Produk", 200, HorizontalAlignment.Center)
            mainWindow.ListMainCourse.Columns.Add("Kategori", 100, HorizontalAlignment.Center)
            mainWindow.ListMainCourse.Columns.Add("Harga", 100, HorizontalAlignment.Center)
        End If

        If mainWindow.ListSideDish.Columns.Count <= 0 Then
            mainWindow.ListSideDish.Columns.Add("Nama Produk", 200, HorizontalAlignment.Center)
            mainWindow.ListSideDish.Columns.Add("Kategori", 100, HorizontalAlignment.Center)
            mainWindow.ListSideDish.Columns.Add("Harga", 100, HorizontalAlignment.Center)
        End If

        If mainWindow.ListDrinks.Columns.Count <= 0 Then
            mainWindow.ListDrinks.Columns.Add("Nama Produk", 200, HorizontalAlignment.Center)
            mainWindow.ListDrinks.Columns.Add("Kategori", 100, HorizontalAlignment.Center)
            mainWindow.ListDrinks.Columns.Add("Harga", 100, HorizontalAlignment.Center)
        End If

        If mainWindow.ListDessert.Columns.Count <= 0 Then
            mainWindow.ListDessert.Columns.Add("Nama Produk", 200, HorizontalAlignment.Center)
            mainWindow.ListDessert.Columns.Add("Kategori", 100, HorizontalAlignment.Center)
            mainWindow.ListDessert.Columns.Add("Harga", 100, HorizontalAlignment.Center)
        End If
    End Sub


    Public Sub tampilMC()
        mainWindow.ListMainCourse.Items.Clear()
        Call openConn()
        cmd = New OdbcCommand("SELECT * FROM menus WHERE kategori='maincourse'", conn)
        da = New OdbcDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim no As Integer = 1

        For i As Integer = 0 To dt.Rows.Count - 1
            With mainWindow.ListMainCourse
                .Items.Add(dt.Rows(i)("nama"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(dt.Rows(i)("kategori").ToString)
                    .Add("Rp. " + dt.Rows(i)("harga").ToString)
                End With
            End With
        Next
    End Sub

    Public Sub tampilDs()
        mainWindow.ListDessert.Items.Clear()
        Call openConn()
        cmd = New OdbcCommand("SELECT * FROM menus WHERE kategori='dessert'", conn)
        da = New OdbcDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        For i As Integer = 0 To dt.Rows.Count - 1
            With mainWindow.ListDessert
                .Items.Add(dt.Rows(i)("nama"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(dt.Rows(i)("kategori").ToString)
                    .Add("Rp. " + dt.Rows(i)("harga").ToString)
                End With
            End With
        Next
    End Sub

    Public Sub tampilSD()
        mainWindow.ListSideDish.Items.Clear()
        Call openConn()
        cmd = New OdbcCommand("SELECT * FROM menus WHERE kategori='sidedish'", conn)
        da = New OdbcDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        For i As Integer = 0 To dt.Rows.Count - 1
            With mainWindow.ListSideDish
                .Items.Add(dt.Rows(i)("nama"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(dt.Rows(i)("kategori").ToString)
                    .Add("Rp. " + dt.Rows(i)("harga").ToString)
                End With
            End With
        Next
    End Sub

    Public Sub tampilDr()
        mainWindow.ListDrinks.Items.Clear()
        Call openConn()
        cmd = New OdbcCommand("SELECT * FROM menus WHERE kategori='drinks'", conn)
        da = New OdbcDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        For i As Integer = 0 To dt.Rows.Count - 1
            With mainWindow.ListDrinks
                .Items.Add(dt.Rows(i)("nama"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(dt.Rows(i)("kategori").ToString)
                    .Add("Rp. " + dt.Rows(i)("harga").ToString)
                End With
            End With
        Next
    End Sub

    Public Sub total()
        Dim total As Double = 0
        Dim totalPesanan As Integer = 0

        For i As Integer = 0 To mainWindow.ListPesanan.Items.Count - 1
            total += Val(mainWindow.ListPesanan.Items(i).SubItems(4).Text)
            totalPesanan += Val(mainWindow.ListPesanan.Items(i).SubItems(2).Text)
        Next
        mainWindow.Label10.Text = Str(total)
        mainWindow.Label8.Text = Str(totalPesanan)
    End Sub

    Public Sub tampilSemuaPesanan()
        Call openConn()

        query = New String("SELECT SUM(jumlah_di_pesan) sumJumlahPesanan From orders")
        cmd = New OdbcCommand(query, conn)
        Dim result = cmd.ExecuteScalar()

        Dim sum As Integer = Convert.ToInt32(result.ToString())
        WindowsApp1.DashboardWindows.Label4.Text = sum
    End Sub

    Public Sub tampilBelumSelesai()
        Call openConn()

        query = New String("SELECT SUM(jumlah_di_pesan) sumJumlahPesanan From orders WHERE status = 'Belum Selesai' ")
        cmd = New OdbcCommand(query, conn)
        Dim result = cmd.ExecuteScalar()

        Dim sum As Integer = Convert.ToInt32(result.ToString())
        WindowsApp1.DashboardWindows.Label6.Text = sum
    End Sub

    Public Sub tampilSelesai()
        Call openConn()

        query = New String("SELECT SUM(jumlah_di_pesan) sumJumlahPesanan From orders WHERE status = 'Selesai' ")
        cmd = New OdbcCommand(query, conn)
        Dim result = cmd.ExecuteScalar()

        Dim sum As Integer = Convert.ToInt32(result.ToString())
        WindowsApp1.DashboardWindows.Label5.Text = sum
    End Sub

    Public Sub graph(kategori)
        Call openConn()
        With DashboardWindows.Chart1
            Dim sKategori As String = kategori
            Dim query As String = "SELECT * FROM menus WHERE kategori = '" & kategori & "'"
            cmd = New OdbcCommand(query, conn)
            da = New OdbcDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dr = cmd.ExecuteReader()
            dr.Read()

            .Series.Clear()
            .Series.Add(sKategori)

            .Series(0).ChartType = SeriesChartType.Column

            For I As Integer = 0 To dt.Rows.Count - 1
                .Series(0).Points.AddXY(dt.Rows(I)("nama"), dt.Rows(I)("dipesan"))
            Next
        End With
        Call closeConn()
    End Sub

End Module