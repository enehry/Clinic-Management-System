Public Class FRMAddStock
    Private Sub BTNCancel_Click(sender As Object, e As EventArgs) Handles BTNCancel.Click
        Me.Close()
    End Sub

    Private Sub BTNIncrement_Click(sender As Object, e As EventArgs) Handles BTNIncrement.Click
        TXTStock.Text += 1
    End Sub

    Private Sub BTNDecrement_Click(sender As Object, e As EventArgs) Handles BTNDecrement.Click
        TXTStock.Text -= 1
    End Sub

    Private Sub BTNSave_Click(sender As Object, e As EventArgs) Handles BTNSave.Click
        TblmedicineTableAdapter1.AddStock(Date.Now(), If(TXTStock.Text.Trim = "", 0, TXTStock.Text), LBLMedCode.Text)
        FRMStocks.PopulateStock()
        AddActivity("Added Stock : " & LBLMEDname.Text, LoggedUser.UserName)
        FRMStocks.AddedStockSnackbar()
        Me.Close()

    End Sub

    Private Sub TXTStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTStock.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class