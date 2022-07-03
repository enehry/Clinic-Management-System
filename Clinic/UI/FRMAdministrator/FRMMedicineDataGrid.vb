Public Class FRMMedicineDataGrid
    Private Sub TXTSearch_TextChanged(sender As Object, e As EventArgs) Handles TXTSearch.TextChanged
        TblmedicineBindingSource.Filter = "medicine_name LIKE '%" & TXTSearch.Text & "%'"
    End Sub

    Private Sub FRMMedicineDataGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblmedicineTableAdapter.Fill(ClinicsmsdbDataSet.tblmedicine, 0)
    End Sub

    Private Sub DGVMedsSearch_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMedsSearch.CellContentClick

    End Sub

    Private Sub DGVMedsSearch_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMedsSearch.CellContentDoubleClick
        Dim i As Integer = e.RowIndex
        FRMAdmit.TXTMedicinecode.Text = DGVMedsSearch.Rows(i).Cells(0).Value()
        FRMAdmit.TXTMedicinename.Text = DGVMedsSearch.Rows(i).Cells(1).Value()
        Me.Close()
    End Sub
End Class