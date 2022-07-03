Public Class AccountReport
    Private Sub AccountReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbluserTableAdapter.Fill(clinicsmsdbDataSet.tbluser)
        RVAccount.RefreshReport()
    End Sub

    Private Sub DTPAccount_ValueChanged(sender As Object, e As EventArgs) Handles DTPTo.ValueChanged
        Debug.Print(CDate(DTPFrom.Value).ToString("yyyy-MM-dd"))
    End Sub

    Private Sub BTNFilter_Click(sender As Object, e As EventArgs) Handles BTNFilter.Click
        tbluserTableAdapter.FillByFilterDate(clinicsmsdbDataSet.tbluser, CDate(DTPFrom.Value).ToString("yyyy-MM-dd"), CDate(DTPTo.Value).ToString("yyyy-MM-dd"))
        RVAccount.RefreshReport()
    End Sub

    Private Sub BTNReset_Click(sender As Object, e As EventArgs) Handles BTNReset.Click
        tbluserTableAdapter.Fill(clinicsmsdbDataSet.tbluser)
        RVAccount.RefreshReport()
    End Sub
End Class
