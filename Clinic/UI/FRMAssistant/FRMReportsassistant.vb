Public Class FRMReportsassistant
    Private Sub FRMReportsassistant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PNLReportdisplay.Controls.Clear()

        Dim student As New StudentReport With {
            .Dock = DockStyle.Fill
        }
        PNLReportdisplay.Controls.Add(student)
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