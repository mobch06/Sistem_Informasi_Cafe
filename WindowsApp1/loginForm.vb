Imports System.Data.Odbc
Imports WindowsApp1.ConnDB
Public Class loginForm
    Public dataReader As OdbcDataReader
    Public login As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Call openConn()
        Dim myAdapter As New OdbcDataAdapter
        Dim query = "SELECT * FROM user WHERE username='" + usernameTextBox.Text + "' AND password='" + passwordTextBox.Text + "'"
        Dim cmd As New OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = query

        myAdapter.SelectCommand = cmd
        dataReader = cmd.ExecuteReader()

        login = dataReader.HasRows

        If dataReader.HasRows = 0 Then
            MsgBox("Username atau password salah")
        Else
            MsgBox("Login Berhasil!", MsgBoxStyle.Information, "Login Success")
            login = True
            dataReader.Read()
            Dim atype As String
            atype = "admin"
            If dataReader("atype") = atype Then
                DashboardWindows.Show()
            Else
                mainWindow.LinkLabel1.Text = "Logout"
                query = "SELECT * FROM user WHERE username='" + usernameTextBox.Text + "'"
                cmd = New OdbcCommand(query, conn)
                da = New OdbcDataAdapter
                da.SelectCommand = cmd
                dr = cmd.ExecuteReader()
                dr.Read()

                If login = True Then
                    mainWindow.namaCst_Lbl.Text = dr("fullname")
                    mainWindow.LinkLabel1.Text = "Logout"
                Else
                    mainWindow.namaCst_Lbl.Text = ""
                End If
                mainWindow.Show()
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        registerForm.Show()
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
