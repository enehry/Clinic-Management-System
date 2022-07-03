Public Class FRMSystemsettings
    Private Sub FRMSystemsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateData()
    End Sub

    Private Sub BTNAdd_Click(sender As Object, e As EventArgs) Handles BTNAdd.Click

        If BTNAdd.Text = "Add" Then
            TblcollegeTableAdapter.Insert(Nothing, TXTCollegeName.Text)
        Else
            If id >= 0 Then
                TblcollegeTableAdapter.UpdateCollege(TXTCollegeName.Text, id)
                SBSystemSet.Show(Me, "College Successfully Updated",
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
                 4000, "",
                Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)

                TXTCollegeName.Text = ""

                BTNAdd.Text = "Add"
                BTNDeleteCollege.Text = "Delete"
            End If

        End If

        PopulateData()

    End Sub

    Private Sub PopulateData()
        Me.TblcollegeTableAdapter.Fill(Me.ClinicsmsdbDataSet.tblcollege)
        'TODO: This line of code loads data into the 'ClinicsmsdbDataSet.tblcourse' table. You can move, or remove it, as needed.
        Me.TblcourseTableAdapter.Fill(Me.ClinicsmsdbDataSet.tblcourse)

        CBCollegeName.DataSource = ClinicsmsdbDataSet.tblcollege
        CBCollegeName.ValueMember = "college_code"
        CBCollegeName.DisplayMember = "college_name"
    End Sub

    Private Sub BTNDelete_Click(sender As Object, e As EventArgs) Handles BTNDeleteCollege.Click
        If BTNDeleteCollege.Text = "Delete" Then
            If DGVCollege.CurrentRow.Index >= 0 Then
                Try
                    TblcollegeTableAdapter.DeleteCollege(DGVCollege.CurrentRow.Cells(0).Value)
                    PopulateData()
                Catch ex As MySql.Data.MySqlClient.MySqlException
                    If ex.Number = 1451 Then
                        SBSystemSet.Show(Me, "You cannot delete this data because this data was used by the other course table",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
             4000, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
                        ex.Message.ToString()
                    End If

                End Try


            End If
        Else
            TXTCollegeName.Text = ""
            BTNDeleteCollege.Text = "Delete"
            BTNAdd.Text = "Add"
        End If



    End Sub


    Private Sub BTNAddCourse_Click(sender As Object, e As EventArgs) Handles BTNAddCourse.Click

        If BTNAddCourse.Text = "Add" Then
            TblcourseTableAdapter.Insert(TXTCourseName.Text, CBCollegeName.SelectedValue)
        Else
            If courseID >= 0 Then
                If Not String.IsNullOrWhiteSpace(TXTCourseName.Text) Then
                    TblcourseTableAdapter.UpdateCourse(TXTCourseName.Text, CBCollegeName.SelectedValue, courseID)

                    ClearCourse()


                    SBSystemSet.Show(Me, "College Successfully Updated",
                   Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
                    4000, "",
                   Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
                Else
                    SBSystemSet.Show(Me, "Course name is Required",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
                     4000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
                End If
            End If
        End If

        PopulateData()
    End Sub


    Private Sub BTNDeleteCourse_Click(sender As Object, e As EventArgs) Handles BTNDeleteCourse.Click

        If BTNDeleteCourse.Text = "Delete" Then
            Try
                If DGVCourse.Rows.Count > 0 Then
                    If DGVCourse.CurrentRow.Index >= 0 Then
                        TblcourseTableAdapter.DeleteCourse(DGVCourse.CurrentRow.Cells(0).Value)
                        ClearCourse()
                        PopulateData()
                    End If
                End If
            Catch ex As MySql.Data.MySqlClient.MySqlException
                If ex.Number = 1451 Then
                    SBSystemSet.Show(FRMHome, "You cannot delete this data because this data was used by the student table",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
             4000, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
                    ex.Message.ToString()
                End If

            End Try
        Else
            ClearCourse()
        End If




    End Sub


    Private Sub ClearCourse()
        TXTCourseName.Text = ""
        CBCollegeName.SelectedIndex = -1
        BTNAddCourse.Text = "Add"
        BTNDeleteCourse.Text = "Delete"
    End Sub

    Private id As Integer = -1
    Private Sub DGVCollege_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVCollege.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then

            If DGVCollege.Rows.Count >= 0 Then
                BTNAdd.Text = "Update"
                BTNDeleteCollege.Text = "Cancel"

                Dim i As Integer = DGVCollege.CurrentRow.Index
                TXTCollegeName.Text = DGVCollege.Rows(i).Cells(1).Value
                id = DGVCollege.Rows(i).Cells(0).Value

            End If

        End If
    End Sub

    Dim courseID As Integer = -1

    Private Sub DGVCourse_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVCourse.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then

            If DGVCourse.Rows.Count >= 0 Then
                BTNAddCourse.Text = "Update"
                BTNDeleteCourse.Text = "Cancel"

                Dim i As Integer = DGVCourse.CurrentRow.Index
                TXTCourseName.Text = DGVCourse.Rows(i).Cells(1).Value
                CBCollegeName.SelectedValue = DGVCourse.Rows(i).Cells(2).Value
                courseID = DGVCourse.Rows(i).Cells(0).Value

            End If

        End If
    End Sub
End Class