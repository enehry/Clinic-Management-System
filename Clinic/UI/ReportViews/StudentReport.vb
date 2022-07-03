Public Class StudentReport
    Private Sub StudentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblstudentprofileTableAdapter.Fill(clinicsmsdbDataSet.tblstudentprofile, 0)
        RVStudent.RefreshReport()

        TblcourseTableAdapter1.Fill(clinicsmsdbDataSet.tblcourse)

        CMBCourse.DataSource = clinicsmsdbDataSet.tblcourse
        CMBCourse.ValueMember = "course_code"
        CMBCourse.DisplayMember = "course_name"
    End Sub

    Private Sub BTNFilter_Click(sender As Object, e As EventArgs) Handles BTNFilter.Click
        tblstudentprofileTableAdapter.FillByCourse(clinicsmsdbDataSet.tblstudentprofile, 0, CMBCourse.SelectedValue)
        RVStudent.RefreshReport()
    End Sub

    Private Sub BTNReset_Click(sender As Object, e As EventArgs) Handles BTNReset.Click
        tblstudentprofileTableAdapter.Fill(clinicsmsdbDataSet.tblstudentprofile, 0)
        RVStudent.RefreshReport()
    End Sub
End Class
