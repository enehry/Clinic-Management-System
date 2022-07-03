Imports Microsoft.Reporting.WinForms
Public Class ActivityLogReport
    Private Sub ActivityLogReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblactivitylogTableAdapter.Fill(clinicsmsdbDataSet.tblactivitylog)
        RVActivityLog.RefreshReport()
    End Sub

    Private Sub BTNFilter_Click(sender As Object, e As EventArgs) Handles BTNFilter.Click

        Select Case CBFilterOpt.SelectedIndex
            Case 0
                If String.IsNullOrWhiteSpace(TXTUsername.Text) Then
                    SBReportActivityLog.Show(FRMReports, "Username must not be empty",
                   Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
                    4000, "",
                   Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
                    RVActivityLog.RefreshReport()
                Else
                    tblactivitylogTableAdapter.FillByUsername(clinicsmsdbDataSet.tblactivitylog, TXTUsername.Text)
                    RVActivityLog.RefreshReport()
                End If
            Case 1
                tblactivitylogTableAdapter.FillByCreatedAt(clinicsmsdbDataSet.tblactivitylog, CDate(DTPFrom.Value).ToString("yyyy-MM-dd"), CDate(DTPTo.Value).ToString("yyyy-MM-dd"))
                RVActivityLog.RefreshReport()
            Case 2
                If String.IsNullOrWhiteSpace(TXTUsername.Text) Then
                    SBReportActivityLog.Show(FRMReports, "Username must not be empty",
                   Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
                    4000, "",
                   Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
                    RVActivityLog.RefreshReport()
                Else
                    tblactivitylogTableAdapter.FillByUsernameCreatedAt(clinicsmsdbDataSet.tblactivitylog, TXTUsername.Text, CDate(DTPFrom.Value).ToString("yyyy-MM-dd"), CDate(DTPTo.Value).ToString("yyyy-MM-dd"))
                    RVActivityLog.RefreshReport()
                End If
        End Select


    End Sub

    Private Sub BTNReset_Click(sender As Object, e As EventArgs) Handles BTNReset.Click
        tblactivitylogTableAdapter.Fill(clinicsmsdbDataSet.tblactivitylog)
        RVActivityLog.RefreshReport()
    End Sub
End Class
