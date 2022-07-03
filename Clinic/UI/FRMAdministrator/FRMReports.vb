Imports Microsoft.Reporting.WinForms

Public Class FRMReports
    Private currentChildForm As Form

    Private Sub displayForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        FRMAssistant.PNLDisplay.Controls.Add(childForm)
        FRMAssistant.PNLDisplay.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub BTNManageaccount_Click(sender As Object, e As EventArgs)
        displayForm(New FRMManageuseraccount)
    End Sub



    Private Sub FRMReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PNLReportdisplay.Controls.Clear()

        Dim userAccount As New AccountReport With {
            .Dock = DockStyle.Fill
        }
        PNLReportdisplay.Controls.Add(userAccount)
    End Sub

    Private Sub BTNUseraccount_Click(sender As Object, e As EventArgs) Handles BTNUseraccount.Click

        PNLReportdisplay.Controls.Clear()

        Dim userAccount As New AccountReport With {
            .Dock = DockStyle.Fill
        }
        PNLReportdisplay.Controls.Add(userAccount)

    End Sub

    Private Sub BTNActivitylog_Click(sender As Object, e As EventArgs) Handles BTNActivitylog.Click

        PNLReportdisplay.Controls.Clear()

        Dim activityLog As New ActivityLogReport With {
            .Dock = DockStyle.Fill
        }
        PNLReportdisplay.Controls.Add(activityLog)
    End Sub

    Private Sub BTNMedicinestock_Click(sender As Object, e As EventArgs) Handles BTNMedicinestock.Click
        PNLReportdisplay.Controls.Clear()

        Dim medicineStock As New MedicineStockReport With {
            .Dock = DockStyle.Fill
        }
        PNLReportdisplay.Controls.Add(medicineStock)
    End Sub

    Private Sub BTNStudent_Click(sender As Object, e As EventArgs) Handles BTNStudent.Click
        PNLReportdisplay.Controls.Clear()

        Dim student As New StudentReport With {
            .Dock = DockStyle.Fill
        }
        PNLReportdisplay.Controls.Add(student)
    End Sub

    Private Sub BTNTransaction_Click(sender As Object, e As EventArgs) Handles BTNTransaction.Click
        PNLReportdisplay.Controls.Clear()

        Dim transaction As New TransactionReport With {
            .Dock = DockStyle.Fill
        }
        PNLReportdisplay.Controls.Add(transaction)
    End Sub

End Class