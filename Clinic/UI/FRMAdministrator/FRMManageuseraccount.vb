Imports Bunifu.UI.WinForms

Public Class FRMManageuseraccount

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

    Private Sub BTNTrash_Click(sender As Object, e As EventArgs) Handles BTNTrash.Click
        displayForm(New FRMAccounttrash)
    End Sub

    Private Sub FRMManageuseraccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTNUpdate.Enabled = False
        'TODO: This line of code loads data into the 'ClinicsmsdbDataSet.tbluser' table. You can move, or remove it, as needed.
        Me.TbluserTableAdapter.Fill(Me.ClinicsmsdbDataSet.tbluser)
    End Sub

    Private Sub BTNAdd_Click(sender As Object, e As EventArgs) Handles BTNAdd.Click

        Dim msg As String = Validator(False)

        If msg = "" Then
            TbluserTableAdapter.Insert(TXTUsername.Text, EncryptData(TXTPassword.Text), TXTName.Text, CMBUsertype.Text, Date.Now, Date.Now, Nothing)
            Me.TbluserTableAdapter.Fill(Me.ClinicsmsdbDataSet.tbluser)
            SBCreateUser.Show(FRMHome, "User Succesfully Registered",
        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
         2000, "",
        Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
            AddActivity("Added New User : " & TXTUsername.Text, LoggedUser.UserName)
            ClearFields()

        Else
            SBCreateUser.Show(Me, msg,
        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning,
         2000, "",
        Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
        End If
    End Sub


    Private Function Validator(ByVal isUpdating As Boolean)
        Dim msg As String = ""
        If TXTUsername.Text.Length < 6 Then
            msg = "Username must atleast 6 characters"
        ElseIf TXTName.Text = "" Then
            msg = "Login name is required"
        ElseIf TXTPassword.Text.Length < 6 Then
            msg = "Password must atleast 6 characters"
        ElseIf TXTPassword.Text <> TXTRepass.Text Then
            msg = "Password and retype password do not match"
        ElseIf CMBUsertype.Text = "" Then
            msg = "Please select user type"
        End If

        If Not isUpdating Then
            Dim auth As New UserAuthentication()
            If auth.CheckUserIfExist(TXTUsername.Text) Then
                msg = "Username already exist"
            End If
        End If

        Return msg
    End Function

    Dim selectedUser As String = Nothing

    Private Sub BTNUpdate_Click(sender As Object, e As EventArgs) Handles BTNUpdate.Click
        Dim msg As String = Validator(True)

        If msg = "" Then
            TbluserTableAdapter.UpdateUser(EncryptData(TXTPassword.Text), TXTName.Text, CMBUsertype.Text, Date.Now, TXTUsername.Text)
            Me.TbluserTableAdapter.Fill(Me.ClinicsmsdbDataSet.tbluser)
            SBCreateUser.Show(FRMHome, "User Succesfully Updated",
        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
         2000, "",
        Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
            AddActivity("Updated User : " & TXTUsername.Text, LoggedUser.UserName)
            ClearFields()

        Else
            SBCreateUser.Show(FRMHome, msg,
        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning,
         2000, "",
        Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
        End If
    End Sub


    Private Sub ClearFields()
        TXTName.Text = ""
        TXTPassword.Text = ""
        TXTRepass.Text = ""
        TXTUsername.Text = ""
        CMBUsertype.SelectedIndex = -1

        TXTUsername.Enabled = True
        BTNAdd.Enabled = True
        BTNDelete.Text = "Delete"
        BTNUpdate.Enabled = False
    End Sub

    Private Sub BTNDelete_Click(sender As Object, e As EventArgs) Handles BTNDelete.Click
        If BTNDelete.Text = "Delete" Then
            If DGVManageuseraccount.CurrentRow.Index >= 0 Then
                Dim i As Integer = DGVManageuseraccount.CurrentRow.Index
                selectedUser = DGVManageuseraccount.Rows(i).Cells(1).Value
                If TbluserTableAdapter.ToArchive(1, selectedUser) > 0 Then
                    Me.TbluserTableAdapter.Fill(Me.ClinicsmsdbDataSet.tbluser)
                    AddActivity("Added To Trash : " & selectedUser, LoggedUser.UserName)
                    SBCreateUser.Show(FRMHome, "User Added To Trash !", BunifuSnackbar.MessageTypes.Warning, 4000, "Undo",
                     BunifuSnackbar.Positions.BottomRight).Then(Sub(result)
                                                                    If result = BunifuSnackbar.SnackbarResult.ActionClicked Then
                                                                        TbluserTableAdapter.ToArchive(0, selectedUser)
                                                                        Me.TbluserTableAdapter.Fill(Me.ClinicsmsdbDataSet.tbluser)
                                                                        AddActivity("Undo Trash : " & selectedUser, LoggedUser.UserName)
                                                                    End If
                                                                End Sub)


                End If
                ClearFields()
            End If
        Else
            ClearFields()
        End If




    End Sub

    Private Sub BTNSearch_Click(sender As Object, e As EventArgs) Handles BTNSearch.Click
        TbluserBindingSource.Filter = "username LIKE '%" & TXTSearch.Text & "%'" & "OR login_name LIKE '%" & TXTSearch.Text & "%'"
    End Sub

    Private Sub DGVManageuseraccount_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVManageuseraccount.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If DGVManageuseraccount.Rows.Count > 0 Then
                BTNAdd.Enabled = False
                Dim i As Integer = DGVManageuseraccount.CurrentRow.Index
                Dim row As DataGridViewRow = DGVManageuseraccount.Rows(i)

                TXTUsername.Text = row.Cells(1).Value
                TXTPassword.Text = DecryptData(row.Cells(2).Value)
                TXTName.Text = row.Cells(3).Value
                CMBUsertype.Text = row.Cells(4).Value

                TXTUsername.Enabled = False

                BTNDelete.Text = "Cancel"
                BTNUpdate.Enabled = True
            End If

        End If
    End Sub
End Class