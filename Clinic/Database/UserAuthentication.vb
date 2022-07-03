Imports MySql.Data.MySqlClient

Public Class UserAuthentication

    Private cmd As MySqlCommand

    Public Function AuthenticateUser(ByVal username As String, ByVal password As String)

        Dim msg As String = ""

        Using con As MySqlConnection = Conn()
            Dim stmt As String = "SELECT * FROM TBLUSER WHERE username = @username"
            cmd = New MySqlCommand(stmt, con)
            cmd.Parameters.AddWithValue("@username", username)
            con.Open()

            Dim drr As MySqlDataReader = cmd.ExecuteReader

            drr.Read()
            ' Kapag may nakuhang data nag eexist ung user

            If (drr.HasRows) Then
                If drr.GetValue(drr.GetOrdinal("is_archive")) = 0 Then
                    Dim pass As String = drr.GetValue(drr.GetOrdinal("password"))
                    ' check if password is right
                    If (pass = password) Then
                        LoggedUser = New User()
                        With LoggedUser
                            .LoginName = drr.GetValue(drr.GetOrdinal("login_name"))
                            .UserName = drr.GetValue(drr.GetOrdinal("username"))
                            .UserType = drr.GetValue(drr.GetOrdinal("usertype"))
                        End With

                    Else
                        msg = "Password is incorrect"
                    End If
                Else
                    msg = "Your account has been disabled contact administrator"
                End If


            Else
                msg = "User unregistered"
            End If

            con.Close()
        End Using


        Return msg
    End Function

    Public Function CheckUserIfExist(ByVal username As String)
        Dim exists As Boolean
        Using connection As MySqlConnection = Conn()
            connection.Open()
            Dim stmt As String = "SELECT * FROM TBLUSER WHERE username = @username"

            cmd = New MySqlCommand(stmt, connection)
            cmd.Parameters.AddWithValue("@username", username)

            Dim rdr As MySqlDataReader = cmd.ExecuteReader()

            rdr.Read()
            If (rdr.HasRows) Then
                exists = True
            Else
                exists = False
            End If

            connection.Close()
        End Using

        Return exists

    End Function

End Class

Module UserModule
    Public LoggedUser As User = Nothing
End Module

Class User

    Private _login_name As String

    Public Property LoginName() As String
        Get
            Return _login_name
        End Get
        Set(ByVal value As String)
            _login_name = value
        End Set
    End Property

    Private _userType As String

    Public Property UserType() As String
        Get
            Return _userType
        End Get
        Set(ByVal value As String)
            _userType = value
        End Set
    End Property

    Private _username As String

    Public Property UserName() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property


End Class