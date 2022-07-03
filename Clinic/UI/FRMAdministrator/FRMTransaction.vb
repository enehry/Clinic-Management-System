Public Class FRMTransaction
    Private Sub FRMTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClinicsmsdbDataSet.tbltransaction' table. You can move, or remove it, as needed.
        Me.TbltransactionTableAdapter.Fill(Me.ClinicsmsdbDataSet.tbltransaction, 0)
    End Sub

    Private Sub BTNSearch_Click(sender As Object, e As EventArgs) Handles BTNSearch.Click
        TbltransactionBindingSource.Filter = "medicine_name LIKE '%" & TXTSearch.Text & "%'" & "OR lname LIKE '%" & TXTSearch.Text & "%'"
    End Sub

    Private Sub BTNVoid_Click(sender As Object, e As EventArgs) Handles BTNVoid.Click
        If DGVTransaction.Rows.Count > 0 Then
            Dim Msg, Style, Title, Response
            Msg = "This transaction will be voided are you sure you want to continue?"
            Style = vbYesNo + vbExclamation + vbDefaultButton2
            Title = "MESSAGE"

            Response = MsgBox(Msg, Style, Title)
            If Response = vbYes Then    ' User chose Yes.
                If DGVTransaction.CurrentRow.Index >= 0 Then

                    Dim row = DGVTransaction.Rows(DGVTransaction.CurrentRow.Index)
                    Dim currentStock As Integer = TblmedicineTableAdapter1.GetStockCount(0, row.Cells(2).Value)

                    Debug.Print(currentStock + CInt(row.Cells(3).Value))



                    TblmedicineTableAdapter1.ReturnStock(currentStock + CInt(row.Cells(3).Value), row.Cells(2).Value)

                    TbltransactionTableAdapter.ToArchive(1, row.Cells(0).Value)

                    Me.TbltransactionTableAdapter.Fill(Me.ClinicsmsdbDataSet.tbltransaction, 0)

                    SBTransaction.Show(Me, "Student Successfully Admitted",
               Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
                4000, "",
               Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
                End If
            End If
        End If

    End Sub
End Class