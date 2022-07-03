Imports MySql.Data.MySqlClient
Module DatabaseConnection

    Public Function Conn() As MySqlConnection
        Return New MySqlConnection(My.Settings.clinicsmsdbConnectionString)
    End Function

    Public Function Command(ByVal stmt As String, ByVal conn As MySqlConnection) As MySqlCommand
        Return New MySqlCommand(stmt, conn)
    End Function


End Module
