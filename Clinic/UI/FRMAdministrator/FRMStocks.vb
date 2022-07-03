Public Class FRMStocks
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
        displayForm(New FRMStockstrash)
    End Sub

    Private Sub FRMStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateStock()
        ClearFields()
    End Sub

    Public Sub PopulateStock()
        'TODO: This line of code loads data into the 'ClinicsmsdbDataSet.tblmedicine' table. You can move, or remove it, as needed.
        Me.TblmedicineTableAdapter.Fill(Me.ClinicsmsdbDataSet.tblmedicine, 0)
    End Sub

    Private Sub BTNAdd_Click(sender As Object, e As EventArgs) Handles BTNAdd.Click
        Dim msg As String = Validator()
        If msg = "" Then
            TblmedicineTableAdapter.InsertMedicine(TXTMedicinename.Text, TXTGenericname.Text, TXTDesc.Text, Date.Now, TXTML.Text, 0)
            BSStocks.Show(FRMHome, "Medicine Succesfully Added",
        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
         4000, "",
        Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
            AddActivity("Medicine Added : " & TXTMedicinename.Text, LoggedUser.UserName)
            Me.TblmedicineTableAdapter.Fill(Me.ClinicsmsdbDataSet.tblmedicine, 0)
            ClearFields()
        End If
    End Sub

    Private Function Validator()
        Dim msg As String = ""

        If TXTMedicinename.Text.Trim = "" Then
            msg = "Medicine Name is Required"
        ElseIf TXTGenericname.Text.Trim = "" Then
            msg = "Generic Name is Required"
        ElseIf TXTML.Text.Trim = "" Then
            msg = "Milligrams is Required"
        End If

        Return msg

    End Function

    Private Sub ClearFields()
        BTNUpdate.Enabled = False
        BTNAdd.Enabled = True

        BTNDelete.Text = "DELETE"
        TXTMedicinename.Text = ""
        TXTGenericname.Text = ""
        TXTDesc.Text = ""
        TXTML.Text = ""
    End Sub

    Private Sub DGVStocks_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVStocks.CellContentDoubleClick
        BTNDelete.Text = "CANCEL"
        BTNUpdate.Enabled = True
        BTNAdd.Enabled = False

        Dim i As Integer = e.RowIndex

        TXTMedicinename.Text = DGVStocks.Rows(i).Cells(1).Value
        TXTGenericname.Text = DGVStocks.Rows(i).Cells(2).Value
        TXTDesc.Text = DGVStocks.Rows(i).Cells(3).Value
        TXTML.Text = DGVStocks.Rows(i).Cells(5).Value
        selectedUpdate = DGVStocks.Rows(i).Cells(0).Value


    End Sub

    Private selectedUpdate As Integer

    Private Sub BTNDelete_Click(sender As Object, e As EventArgs) Handles BTNDelete.Click
        If BTNDelete.Text = "CANCEL" Then
            ClearFields()
        Else
            If DGVStocks.Rows.Count > 0 Then
                Dim i As Integer = DGVStocks.CurrentRow.Index

                If i >= 0 Then
                    TblmedicineTableAdapter.ToArchive(1, DGVStocks.Rows(i).Cells(0).Value)
                    BSStocks.Show(FRMHome, "Medicine Added To Trash",
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information,
                 4000, "",
                Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
                    AddActivity("Medicine Added to Trash : " & DGVStocks.Rows(i).Cells(1).Value, LoggedUser.UserName)
                    Me.TblmedicineTableAdapter.Fill(Me.ClinicsmsdbDataSet.tblmedicine, 0)
                    ClearFields()
                End If
            End If

        End If
    End Sub

    Private Sub BTNUpdate_Click(sender As Object, e As EventArgs) Handles BTNUpdate.Click
        Dim msg As String = Validator()
        If msg = "" Then
            TblmedicineTableAdapter.UpdateMedicine(TXTMedicinename.Text, TXTGenericname.Text, TXTDesc.Text, TXTML.Text, selectedUpdate)
            BSStocks.Show(FRMHome, "Medicine Succesfully Updated",
        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
         4000, "",
        Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
            AddActivity("Medicine Updated : " & TXTMedicinename.Text, LoggedUser.UserName)
            Me.TblmedicineTableAdapter.Fill(Me.ClinicsmsdbDataSet.tblmedicine, 0)
            ClearFields()
        End If
    End Sub

    Private Sub BTNSearch_Click(sender As Object, e As EventArgs) Handles BTNSearch.Click
        TblmedicineBindingSource.Filter = "medicine_name LIKE '%" & TXTSearch.Text & "%'" & "OR generic_name LIKE '%" & TXTSearch.Text & "%'"
    End Sub

    Private Sub DGVStocks_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVStocks.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then

            If DGVStocks.Rows.Count >= 0 Then
                Dim i As Integer = DGVStocks.CurrentRow.Index
                FRMAddStock.TXTStock.Text = TblmedicineTableAdapter.GetStockCount(0, DGVStocks.Rows(i).Cells(0).Value)
                FRMAddStock.LBLMedCode.Text = DGVStocks.Rows(i).Cells(0).Value
                FRMAddStock.LBLMEDname.Text = DGVStocks.Rows(i).Cells(1).Value
                FRMAddStock.ShowDialog()
            End If



        End If
    End Sub

    Public Sub AddedStockSnackbar()
        BSStocks.Show(FRMHome, "Stock successfully added",
        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
         4000, "",
        Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
    End Sub

End Class