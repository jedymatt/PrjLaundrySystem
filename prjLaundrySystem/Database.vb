Imports MySql.Data.MySqlClient
Imports System.Configuration

Module Database
    Private ReadOnly Conn As New MySqlConnection() With {
        .ConnectionString = GetConnectionString()
    }

    Public Function GetConnection() As MySqlConnection
        If Conn.State = ConnectionState.Closed Then
            'Conn = New MySqlConnection(GetConnectionString)
            Conn.Open()
        End If
        Return Conn
    End Function

    Public Function GetConnectionString() As String
        Return ConfigurationManager.
            ConnectionStrings("DatabaseConnectionString").
            ConnectionString
    End Function

    Public Function ExecuteCommand(cmd As MySqlCommand) As DataTable
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New MySqlDataAdapter With {
                .SelectCommand = cmd
            }

            da.Fill(dt)

            Return dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)

            Return Nothing
        End Try
    End Function

End Module
