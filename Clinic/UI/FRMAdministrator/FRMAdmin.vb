Public Class FRMAdmin
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

    Private Sub BTNAdmit_Click(sender As Object, e As EventArgs) Handles BTNAdmit.Click
        displayForm(FRMAdmit)
    End Sub

    Private Sub BTNManageuseraccount_Click(sender As Object, e As EventArgs) Handles BTNManageuseraccount.Click
        displayForm(New FRMManageuseraccount)
    End Sub

    Private Sub BTNStocks_Click(sender As Object, e As EventArgs) Handles BTNStocks.Click
        displayForm(FRMStocks)
    End Sub

    Private Sub BTNSystemsettings_Click(sender As Object, e As EventArgs) Handles BTNSystemsettings.Click
        displayForm(New FRMSystemsettings)
    End Sub

    Private Sub BTNReports_Click(sender As Object, e As EventArgs) Handles BTNReports.Click
        displayForm(New FRMReports)
    End Sub

    Private Sub FRMAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBLUserType.Text = "Welcome " & LoggedUser.UserType.ToUpper()
        LBLName.Text = LoggedUser.LoginName
        displayForm(New FRMHome)
    End Sub

    Private Sub CTRLClose_Click(sender As Object, e As EventArgs) Handles CTRLClose.Click
        End
    End Sub

    Private Sub BTNLogout_Click(sender As Object, e As EventArgs) Handles BTNLogout.Click
        Dim logout As DialogResult

        logout = MessageBox.Show("Do you really want to log out?", "Log out account", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If logout = DialogResult.Yes Then
            FRMLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BTNTransaction_Click(sender As Object, e As EventArgs) Handles BTNTransaction.Click
        displayForm(New FRMTransaction)
    End Sub

    Private Sub BTNStudents_Click(sender As Object, e As EventArgs) Handles BTNStudents.Click
        displayForm(New FRMStudent)
    End Sub


End Class