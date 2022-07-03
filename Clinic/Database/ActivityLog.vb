Imports MySql.Data.MySqlClient

Module ActivityLog

    Public Function AddActivity(ByVal Activity As String, ByVal Username As String)

        Dim res As Integer = 0

        Using con As MySqlConnection = Conn()
            Dim stmt = "INSERT INTO TBLACTIVITYLOG SET username = @username, activity = @activity, created_at = @date"

            Dim cmd = Command(stmt, con)

            With cmd.Parameters
                .AddWithValue("@username", Username)
                .AddWithValue("@activity", Activity)
                .AddWithValue("@date", Date.Now)
            End With

            con.Open()
            res = cmd.ExecuteNonQuery
        End Using
        Return Res
    End Function


End Module
