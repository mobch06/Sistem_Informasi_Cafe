Imports System.Data.Odbc

Module ConnDB
    Public conn As New OdbcConnection
    Public query As String
    Public cmd As OdbcCommand
    Public strConn As String = "server=localhost; user id=root; password=; database=dbcafeapp; dsn=dbcafe"

    Public Sub openConn()
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = strConn
            Try
                conn.Open()
            Catch ex As OdbcException
                MsgBox("Koneksi Gagal! " & ex.ToString)
            End Try
        End If
    End Sub

    Public Sub closeConn()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("Gagal Menutup Koneksi! " & ex.ToString)
            End Try
        End If
    End Sub

End Module
