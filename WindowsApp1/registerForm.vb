Imports WindowsApp1.ConnDB
Imports System.Data.Odbc
Public Class registerForm
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim atype As String = "customer"
        Dim cmd As OdbcCommand
        Call openConn()
        query = "INSERT INTO `user`(`id`, `atype`, `username`, `password`, `fullname`, `email`, `pnumber`) VALUES ('','" & atype & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "', '" & TextBox5.Text & "')"
        cmd = New OdbcCommand(query, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Registrasi Berhasil")

        Call closeConn()

        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub registerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class