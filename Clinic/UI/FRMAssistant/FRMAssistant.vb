Public Class FRMAssistant
    Private currentChildForm As Form

    Private Sub displayForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PNLDisplay.Controls.Add(childForm)
        PNLDisplay.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub BTNHome_Click(sender As Object, e As EventArgs) Handles BTNHome.Click
        displayForm(New FRMHome)
    End Sub

    Private Sub FRMAssistant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBLUserType.Text = "Welcome " & LoggedUser.UserType.ToUpper()
        LBLName.Text = LoggedUser.LoginName
        displayForm(New FRMHome)
    End Sub

    Private Sub CTRLClose_Click(sender As Object, e As EventArgs) Handles CTRLClose.Click
        End
    End Sub

    Private Sub BTNAdmin_Click(sender As Object, e As EventArgs) Handles BTNAdmin.Click
        displayForm(FRMAdmit)
    End Sub
    Private Sub BTNStudents_Click(sender As Object, e As EventArgs) Handles BTNStudents.Click
        displayForm(New FRMStudentassistant)
    End Sub

    Private Sub BTNReports_Click(sender As Object, e As EventArgs) Handles BTNReports.Click
        displayForm(New FRMReportsassistant)
    End Sub

    Private Sub BTNLogout_Click(sender As Object, e As EventArgs) Handles BTNLogout.Click
        Dim logout As DialogResult

        logout = MessageBox.Show("Do you really want to log out?", "Log out account", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If logout = DialogResult.Yes Then
            FRMLogin.Show()
            Me.Close()
        End If
    End Sub


End Class