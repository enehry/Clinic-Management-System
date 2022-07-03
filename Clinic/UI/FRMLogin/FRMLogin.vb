Public Class FRMLogin
    Private Sub TXTUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXTPassword.Focus()
        End If
    End Sub

    Private Sub TXTPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BTNLogin.PerformClick()
        End If
    End Sub

    Private Sub CHKShowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles CHKShowpassword.CheckedChanged
        If CHKShowpassword.Checked = True Then
            TXTPassword.UseSystemPasswordChar = False
        Else
            TXTPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BTNLogin_Click(sender As Object, e As EventArgs) Handles BTNLogin.Click
        LBLUsername.ForeColor = Color.FromKnownColor(KnownColor.Control)
        LBLPassword.ForeColor = Color.FromKnownColor(KnownColor.Control)

        Dim userAuth As New UserAuthentication()

        Dim msg As String = userAuth.AuthenticateUser(TXTUsername.Text, EncryptData(TXTPassword.Text))

        If msg = "" Then
            If LoggedUser.UserType = "nurse" Then
                FRMAdmin.Show()
                Me.Close()
            ElseIf LoggedUser.UserType = "assistant" Then
                FRMAssistant.Show()
                Me.Close()
            End If

        Else
            SBLogin.Show(Me, msg, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 3000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomCenter)
        End If




    End Sub

    Private Sub CTRLClose_Click(sender As Object, e As EventArgs) Handles CTRLClose.Click
        End
    End Sub

    Private Sub TXTUsername_Enter(sender As Object, e As EventArgs) Handles TXTUsername.Enter
        LBLUsername.ForeColor = Color.FromArgb(67, 181, 129)
        LBLPassword.ForeColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub TXTPassword_Enter(sender As Object, e As EventArgs) Handles TXTPassword.Enter
        LBLPassword.ForeColor = Color.FromArgb(67, 181, 129)
        LBLUsername.ForeColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub CHKShowpassword_Click(sender As Object, e As EventArgs) Handles CHKShowpassword.Click
        LBLUsername.ForeColor = Color.FromKnownColor(KnownColor.Control)
        LBLPassword.ForeColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub FRMLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FRMSplashscreen.BarLong(100)
        Dim i As Integer = 0
        While i <= 100
            FRMSplashscreen.ShowBar(i)
            i += 5
            Threading.Thread.Sleep(50)
        End While
    End Sub
End Class
