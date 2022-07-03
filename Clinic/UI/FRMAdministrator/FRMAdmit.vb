Public Class FRMAdmit


    Private Sub BTNAddStudNum_Click(sender As Object, e As EventArgs) Handles BTNAddStudNum.Click
        FRMStudentDataGrid.ShowDialog()
    End Sub

    Private Sub FRMAdmit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTNAddMedCode_Click(sender As Object, e As EventArgs) Handles BTNAddMedCode.Click
        FRMMedicineDataGrid.ShowDialog()
    End Sub

    Private Sub BTNAdmit_Click(sender As Object, e As EventArgs) Handles BTNAdmit.Click
        Dim msg As String = Validator()

        If msg = "" Then
            TbltransactionTableAdapter.InsertTransaction(TXTStudentnumber.Text, TXTMedicinecode.Text, TXTQuantity.Text, Date.Now)
            TblmedicineTableAdapter1.AddStock(Date.Now(), TblmedicineTableAdapter1.GetStockCount(0, TXTMedicinecode.Text) - TXTQuantity.Text, TXTMedicinecode.Text)
            AddActivity(" Admit : " & TXTFullname.Text, LoggedUser.UserName)
            SBAdmit.Show(Me, "Student Successfully Admitted",
           Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
            4000, "",
           Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
            ClearFields()
        Else
            SBAdmit.Show(Me, msg,
           Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning,
            4000, "",
           Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight)
        End If


    End Sub


    Private Function Validator()
        Dim msg As String = ""

        If TXTStudentnumber.Text.Trim = "" Then
            msg = "Student number is important"
        ElseIf TXTFullname.Text.Trim = "" Then
            msg = "Full name is required"
        ElseIf TXTMedicinecode.Text.Trim = "" Then
            msg = "Medicine code is important"
        ElseIf TXTMedicinename.Text.Trim = "" Then
            msg = "Medicine name is required"
        ElseIf TXTQuantity.Text.Trim = "" Then
            msg = "Quantity is required"
        End If

        If Not (TXTQuantity.Text.Trim = "") Then
            If TblmedicineTableAdapter1.GetStockCount(0, TXTMedicinecode.Text) < TXTQuantity.Text Then
                msg = "Insuficient Stock"
            End If
        End If


        Return msg
    End Function

    Private Sub ClearFields()
        TXTStudentnumber.Text = ""
        TXTFullname.Text = ""
        TXTCourse.Text = ""
        TXTMedicinecode.Text = ""
        TXTMedicinename.Text = ""
        TXTQuantity.Text = ""
    End Sub

    Private Sub TXTQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTQuantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        ClearFields()
    End Sub

    Private Sub PNLBarcode_Click(sender As Object, e As EventArgs) Handles PNLBarcode.Click
        Dim newBarCodeScan As New FRMScanBarCode
        Debug.Print("click!")
        newBarCodeScan.ShowDialog()
    End Sub

End Class