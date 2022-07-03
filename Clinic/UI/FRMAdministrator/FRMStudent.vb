Public Class FRMStudent
    Private Sub FRMStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClinicsmsdbDataSet.tblstudentprofile' table. You can move, or remove it, as needed.
        Me.TblstudentprofileTableAdapter.Fill(Me.ClinicsmsdbDataSet.tblstudentprofile, 0)

        TblcourseTableAdapter1.Fill(ClinicsmsdbDataSet.tblcourse)


        BTNUpdate.Enabled = False
        CMBCourse.DataSource = ClinicsmsdbDataSet.tblcourse
        CMBCourse.ValueMember = "course_code"
        CMBCourse.DisplayMember = "course_name"

        ClearFields()
    End Sub

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
    Private Sub BTNAdd_Click(sender As Object, e As EventArgs) Handles BTNAdd.Click
        Dim msg As String = Validator()

        '(student_number, fname, mname, lname, course_code, address, contact_no, created_at, sex)
        'VALUES(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)

        If msg = "" Then

            If TblstudentprofileTableAdapter.CheckStudentId(TXTStudentnumber.Text) <= 0 Then
                TblstudentprofileTableAdapter.InsertStudent(TXTStudentnumber.Text, TXTFirstname.Text, TXTMiddlename.Text, TXTLastname.Text, CMBCourse.SelectedValue, TXTAddress.Text, TXTContact.Text, Date.Now, CMBSex.Text)

                BSStudent.Show(FRMHome, "Student Successfully Added",
          Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
           2000, "",
          Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
                AddActivity("Student Added : " & TXTStudentnumber.Text, LoggedUser.UserName)
                Me.TblstudentprofileTableAdapter.Fill(Me.ClinicsmsdbDataSet.tblstudentprofile, 0)
            Else
                BSStudent.Show(FRMHome, "Student Already Registered",
          Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
           2000, "",
          Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
            End If
        Else
            BSStudent.Show(FRMHome, msg,
          Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning,
           2000, "",
          Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
        End If

    End Sub

    Private Function Validator()
        Dim msg As String = ""


        If TXTStudentnumber.Text.Trim = "" Then
            msg = "Student number is required"
        ElseIf TXTFirstname.Text.Trim = "" Then
            msg = "First name is required"
        ElseIf TXTLastname.Text.Trim = "" Then
            msg = "Lastname name is required"
        ElseIf TXTAddress.Text.Trim = "" Then
            msg = "First name is required"
        ElseIf CMBCourse.Text = "" Then
            msg = "Course is required"
        End If

        Return msg


    End Function

    Public Sub ClearFields()
        BTNUpdate.Enabled = False
        BTNAdd.Enabled = True
        TXTStudentnumber.Enabled = True
        BTNDelete.Text = "Delete"


        TXTStudentnumber.Text = ""
        TXTFirstname.Text = ""
        TXTMiddlename.Text = ""
        TXTLastname.Text = ""
        TXTContact.Text = ""
        TXTAddress.Text = ""

        CMBSex.SelectedIndex = -1
        CMBCourse.SelectedIndex = -1
    End Sub

    Private Sub BTNDelete_Click(sender As Object, e As EventArgs) Handles BTNDelete.Click
        If BTNDelete.Text = "Cancel" Then
            ClearFields()
        Else
            If DGVStudents.Rows.Count > 0 Then
                Dim i As Integer = DGVStudents.CurrentRow.Index
                If i >= 0 Then
                    TblstudentprofileTableAdapter.UpdateToArchive(1, DGVStudents.Rows(i).Cells(0).Value)

                    BSStudent.Show(FRMHome, "Student Added to Trash",
              Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information,
               2000, "",
              Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
                    AddActivity("Student Added to Trash : " & DGVStudents.Rows(i).Cells(0).Value, LoggedUser.UserName)
                    Me.TblstudentprofileTableAdapter.Fill(Me.ClinicsmsdbDataSet.tblstudentprofile, 0)
                End If
            End If

        End If


    End Sub

    Private Sub BTNUpdate_Click(sender As Object, e As EventArgs) Handles BTNUpdate.Click


        Dim msg As String = Validator()
        If Validator() = "" Then
            TblstudentprofileTableAdapter.UpdateStudent(TXTFirstname.Text, TXTMiddlename.Text, TXTLastname.Text, CMBCourse.SelectedValue, TXTAddress.Text, TXTContact.Text, CMBSex.Text, TXTStudentnumber.Text)

            BSStudent.Show(FRMHome, "Student Updated",
      Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
       2000, "",
      Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
            AddActivity("Student Updated : " & TXTStudentnumber.Text, LoggedUser.UserName)
            Me.TblstudentprofileTableAdapter.Fill(Me.ClinicsmsdbDataSet.tblstudentprofile, 0)
            ClearFields()
        Else
            BSStudent.Show(FRMHome, msg,
         Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning,
          2000, "",
         Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
        End If
    End Sub

    Private Sub BTNTrash_Click(sender As Object, e As EventArgs) Handles BTNTrash.Click
        displayForm(New FRMStudenttrash)
    End Sub

    Private Sub BTNSearch_Click(sender As Object, e As EventArgs) Handles BTNSearch.Click
        TblstudentprofileBindingSource.Filter = "lname LIKE '%" & TXTSearch.Text & "%'" & " OR student_number LIKE '%" & TXTSearch.Text & "%'"
    End Sub

    Private Sub DGVStudents_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVStudents.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If DGVStudents.Rows.Count > 0 Then
                BTNUpdate.Enabled = True
                BTNAdd.Enabled = False
                TXTStudentnumber.Enabled = False
                BTNDelete.Text = "Cancel"
                Dim i As Integer = DGVStudents.CurrentRow.Index
                If i >= 0 Then
                    Dim row As DataGridViewRow = DGVStudents.Rows(i)
                    TXTStudentnumber.Text = row.Cells(0).Value
                    TXTFirstname.Text = row.Cells(1).Value
                    TXTMiddlename.Text = row.Cells(2).Value
                    TXTLastname.Text = row.Cells(3).Value
                    TXTAddress.Text = row.Cells(4).Value
                    TXTContact.Text = row.Cells(5).Value
                    CMBSex.Text = row.Cells(7).Value
                    CMBCourse.Text = row.Cells(8).Value
                End If
            End If
        End If
    End Sub
End Class