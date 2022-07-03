Public Class FRMStudenttrash
    Private currentChildForm As Form

    Private Sub displayForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        FRMAdmin.PNLDisplay.Controls.Add(childForm)
        FRMAdmin.PNLDisplay.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub BTNBack_Click(sender As Object, e As EventArgs) Handles BTNBack.Click
        displayForm(New FRMStudent)
    End Sub

    Private Sub FRMStudenttrash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClinicsmsdbDataSet.tblstudentprofile' table. You can move, or remove it, as needed.
        Me.TblstudentprofileTableAdapter.Fill(Me.ClinicsmsdbDataSet.tblstudentprofile, 1)
    End Sub

    Private Sub BTNSearch_Click(sender As Object, e As EventArgs) Handles BTNSearch.Click
        TblstudentprofileBindingSource.Filter = "lname LIKE '%" & TXTSearch.Text & "%'" & " OR student_number LIKE '%" & TXTSearch.Text & "%'"
    End Sub

    Private Sub BTNRestore_Click(sender As Object, e As EventArgs) Handles BTNRestore.Click
        If DGVStudentsTrash.Rows.Count > 0 Then
            If DGVStudentsTrash.CurrentRow.Index >= 0 Then
                TblstudentprofileTableAdapter.UpdateToArchive(0, DGVStudentsTrash.Rows(DGVStudentsTrash.CurrentRow.Index).Cells(0).Value)
                AddActivity("Student Restored : " & DGVStudentsTrash.Rows(DGVStudentsTrash.CurrentRow.Index).Cells(0).Value, LoggedUser.UserName)
                BSStudTrash.Show(FRMHome, "Student Succesfully Restored",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
             2000, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
                Me.TblstudentprofileTableAdapter.Fill(Me.ClinicsmsdbDataSet.tblstudentprofile, 1)
            End If
        End If

    End Sub

End Class