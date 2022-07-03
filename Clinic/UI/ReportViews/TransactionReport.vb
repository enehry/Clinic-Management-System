Public Class TransactionReport
    Private Sub TransactionReportvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbltransactionTableAdapter.Fill(clinicsmsdbDataSet.tbltransaction, 0)
        RVTransaction.RefreshReport()
    End Sub

    Private Sub BTNFilter_Click(sender As Object, e As EventArgs) Handles BTNFilter.Click
        tbltransactionTableAdapter.FillByTransactionDate(clinicsmsdbDataSet.tbltransaction, CDate(DTPFrom.Value).ToString("yyyy-MM-dd"), CDate(DTPTo.Value).ToString("yyyy-MM-dd"))
        RVTransaction.RefreshReport()
    End Sub

    Private Sub BTNReset_Click(sender As Object, e As EventArgs) Handles BTNReset.Click
        tbltransactionTableAdapter.Fill(clinicsmsdbDataSet.tbltransaction, 0)
        RVTransaction.RefreshReport()
    End Sub
End Class
