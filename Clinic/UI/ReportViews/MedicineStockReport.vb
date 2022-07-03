Public Class MedicineStockReport
    Private Sub MedicineStockReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblmedicineTableAdapter.Fill(clinicsmsdbDataSet.tblmedicine, 0)
        RVMedicineStock.RefreshReport()
    End Sub

    Private Sub BTNFilter_Click(sender As Object, e As EventArgs) Handles BTNFilter.Click
        tblmedicineTableAdapter.FillByDateRestock(clinicsmsdbDataSet.tblmedicine, 0, CDate(DTPFrom.Value).ToString("yyyy-MM-dd"), CDate(DTPTo.Value).ToString("yyyy-MM-dd"))
        RVMedicineStock.RefreshReport()
    End Sub
End Class
