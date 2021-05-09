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

        Panel7.Hide()
        Panel8.Hide()
        mPanel.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel4.Show()
        Panel5.Show()
        Panel6.Show()
        DataGridView1.Show()
        ListView1.Show()
        Panel7.Hide()
        Panel8.Hide()
        mPanel.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel7.Show()
        Panel8.Show()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        DataGridView1.Hide()
        ListView1.Hide()
        mPanel.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mPanel.Show()
        Panel7.Hide()
        Panel8.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        DataGridView1.Hide()
        ListView1.Hide()
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
End Class