Public Class FRMAdmin
    Private currentChildForm As Form

    Public Sub unshowPNLAccount()
        PNLAccount.Visible = False
        BTNAccount.Tag = "close"
    End Sub

    Private Sub BTNAccount_Click(sender As Object, e As EventArgs) Handles BTNAccount.Click
        If BTNAccount.Tag = "close" Then
            PNLAccount.Visible = True
            BTNAccount.Tag = "open"
        Else
            unshowPNLAccount()
        End If
    End Sub

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
        unshowPNLAccount()
    End Sub

    Private Sub BTNStocks_Click(sender As Object, e As EventArgs) Handles BTNStocks.Click
        displayForm(New FRMStocks)
        unshowPNLAccount()
    End Sub

    Private Sub BTNAdmit_Click(sender As Object, e As EventArgs) Handles BTNAdmit.Click
        displayForm(New FRMAdmit)
        unshowPNLAccount()
    End Sub
    Private Sub BTNSystemsettings_Click(sender As Object, e As EventArgs) Handles BTNSystemsettings.Click
        displayForm(New FRMSystemsettings)
        unshowPNLAccount()
    End Sub

    Private Sub BTNReports_Click(sender As Object, e As EventArgs) Handles BTNReports.Click
        displayForm(New FRMReports)
        unshowPNLAccount()
    End Sub

    Private Sub FRMAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayForm(New FRMHome)
        unshowPNLAccount()
    End Sub

    Private Sub CTRLClose_Click(sender As Object, e As EventArgs) Handles CTRLClose.Click
        End
    End Sub

    Private Sub PNLMain_Click(sender As Object, e As EventArgs) Handles PNLMain.Click
        unshowPNLAccount()
    End Sub

    Private Sub FRMAdmin_Click(sender As Object, e As EventArgs) Handles Me.Click
        unshowPNLAccount()
    End Sub

    Private Sub BTNMyaccount_Click(sender As Object, e As EventArgs) Handles BTNMyaccount.Click

    End Sub

    Private Sub BTNEditaccount_Click(sender As Object, e As EventArgs) Handles BTNEditaccount.Click

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