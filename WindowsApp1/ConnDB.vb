Imports System.Data.Odbc

Module ConnDB
    Public conn As New OdbcConnection
    Public query As String
    Public cmd As OdbcCommand
    Public strConn As String = "server=localhost; user id=root; password=; database=dbcafeapp; dsn=dbcafe"
    Public strcon As String = "server=mysql5045.site4now.net; user id=a74197_dbcafe password=killerbee; database=db_a74197_dbcafe; Dsn=dbcafeonline"
    Public strcon2 As String = "server=sgx02.dewaweb.com; user id=tuhfahst_admin_cafe password=Killerbee12!; database=tuhfahst_db_cafe; Dsn=dbcafeonline2"

    Public Sub openConn()
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = strcon2
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
