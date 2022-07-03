Public Class FRMAccounttrash

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
        displayForm(New FRMManageuseraccount)
    End Sub

    Private Sub FRMAccounttrash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClinicsmsdbDataSet.tbluser' table. You can move, or remove it, as needed.
        Me.TbluserTableAdapter.FillByArchive(Me.ClinicsmsdbDataSet.tbluser)

    End Sub

    Private Sub BTNRestore_Click(sender As Object, e As EventArgs) Handles BTNRestore.Click
        If selectedUser IsNot Nothing Then
            If TbluserTableAdapter.ToArchive(0, selectedUser) > 0 Then
                SBUserTrash.Show(FRMHome, "User Restored",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information,
             2000, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
                AddActivity("Restored User : " & selectedUser, LoggedUser.UserName)
                Me.TbluserTableAdapter.FillByArchive(Me.ClinicsmsdbDataSet.tbluser)
            End If

        End If
    End Sub
    Dim selectedUser As String = Nothing
    Private Sub DGVUserAccountTrash_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUserAccountTrash.CellContentClick
        Dim i As Integer = e.RowIndex
        Dim row As DataGridViewRow = DGVUserAccountTrash.Rows(i)
        selectedUser = row.Cells(1).Value
    End Sub

    Private Sub BTNSearch_Click(sender As Object, e As EventArgs) Handles BTNSearch.Click
        TbluserBindingSource.Filter = "username LIKE '%" & TXTSearch.Text & "%'" & "OR login_name LIKE '%" & TXTSearch.Text & "%'"
    End Sub
End Class