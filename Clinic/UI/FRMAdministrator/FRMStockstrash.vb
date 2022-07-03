Public Class FRMStockstrash

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
        displayForm(New FRMStocks)
    End Sub

    Private Sub FRMStockstrash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblmedicineTableAdapter.Fill(ClinicsmsdbDataSet.tblmedicine, 1)
    End Sub

    Private Sub BTNRestore_Click(sender As Object, e As EventArgs) Handles BTNRestore.Click
        If DGVStocksTrash.Rows.Count > 0 Then
            If DGVStocksTrash.CurrentRow.Index >= 0 Then
                TblmedicineTableAdapter.ToArchive(0, DGVStocksTrash.Rows(DGVStocksTrash.CurrentRow.Index).Cells(0).Value)
                SBStockTrash.Show(FRMHome, "Medicine Restored from Trash",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information,
             2000, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
                AddActivity("Restored From Trash : " & DGVStocksTrash.Rows(DGVStocksTrash.CurrentRow.Index).Cells(1).Value, LoggedUser.UserName)
                Me.TblmedicineTableAdapter.Fill(Me.ClinicsmsdbDataSet.tblmedicine, 1)
            End If
        End If
    End Sub

    Private Sub BTNSearch_Click(sender As Object, e As EventArgs) Handles BTNSearch.Click
        TblmedicineBindingSource.Filter = "medicine_name LIKE '%" & TXTSearch.Text & "%'" & "OR generic_name LIKE '%" & TXTSearch.Text & "%'"
    End Sub
End Class