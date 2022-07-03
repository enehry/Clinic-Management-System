Public Class FRMStudentDataGrid
    Private Sub FRMStudentDataGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblstudentprofileTableAdapter.Fill(ClinicsmsdbDataSet.tblstudentprofile, 0)
    End Sub

    Private Sub TXTSearch_TextChanged(sender As Object, e As EventArgs) Handles TXTSearch.TextChanged
        TblstudentprofileBindingSource.Filter = "student_number LIKE '%" & TXTSearch.Text & "%'" & "OR lname LIKE '%" & TXTSearch.Text & "%'"
    End Sub

    Private Sub DGVStudentsSearch_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVStudentsSearch.CellContentDoubleClick
        Dim i As Integer = e.RowIndex
        FRMAdmit.TXTStudentnumber.Text = DGVStudentsSearch.Rows(i).Cells(0).Value()
        FRMAdmit.TXTFullname.Text = DGVStudentsSearch.Rows(i).Cells(1).Value() & " " & DGVStudentsSearch.Rows(i).Cells(2).Value() & " " & DGVStudentsSearch.Rows(i).Cells(3).Value()
        FRMAdmit.TXTCourse.Text = DGVStudentsSearch.Rows(i).Cells(4).Value()
        Debug.Print(DGVStudentsSearch.Rows(i).Cells(0).Value())
        Me.Close()
    End Sub
End Class