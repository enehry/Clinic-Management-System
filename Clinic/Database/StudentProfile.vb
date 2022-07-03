Imports MySql.Data.MySqlClient

Module StudentProfile

    Public Function GetStudentProfile(ByVal StudentNumber As String)

        Dim res As New List(Of String)

        Using con As MySqlConnection = Conn()
            Dim stmt =
            "SELECT tblstudentprofile.student_number, CONCAT(tblstudentprofile.fname, ' ', tblstudentprofile.mname, ' ', tblstudentprofile.lname) AS FULLNAME, tblcourse.course_name " _
            & "FROM tblstudentprofile INNER JOIN " _
            & "tblcourse ON tblstudentprofile.course_code = tblcourse.course_code " _
            & "WHERE (tblstudentprofile.student_number = @p1)"

            Dim cmd = Command(stmt, con)

            With cmd.Parameters
                .AddWithValue("@p1", StudentNumber)

            End With

            con.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            rd.Read()
            If rd.HasRows Then
                res.Add(rd.GetValue(rd.GetOrdinal("student_number")))
                res.Add(rd.GetValue(rd.GetOrdinal("FULLNAME")))
                res.Add(rd.GetValue(rd.GetOrdinal("course_name")))
            End If

        End Using


        Return res

    End Function


End Module
