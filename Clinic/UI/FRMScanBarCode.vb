Imports AForge.Video
Imports AForge.Video.DirectShow
Imports Bunifu.UI.WinForms
Imports ZXing
Public Class FRMScanBarCode

    Private filterInfoCollection As FilterInfoCollection
    Private WithEvents captureDevice As VideoCaptureDevice

    Private Sub FRMScanBarCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterInfoCollection = New FilterInfoCollection(FilterCategory.VideoInputDevice)

        If filterInfoCollection.Count > 0 Then
            captureDevice = New VideoCaptureDevice(filterInfoCollection(0).MonikerString)
            captureDevice.Start()
        Else
            FRMAdmit.SBAdmit.Show(Me, "No Camera Detected !", BunifuSnackbar.MessageTypes.Error, 4000, "Close",
                 BunifuSnackbar.Positions.BottomRight).Then(Sub(result)
                                                                If result = BunifuSnackbar.SnackbarResult.ActionClicked Then
                                                                    Me.Close()
                                                                End If
                                                            End Sub)
        End If

    End Sub

    Dim reader As IBarcodeReader
    Dim res As Result

    Private Sub TimerScanBarcode_Tick(sender As Object, e As EventArgs) Handles TimerScanBarcode.Tick
        If Not PBScan.BackgroundImage Is Nothing Then
            reader = New BarcodeReader

            Dim bitMap As New Bitmap(PBScan.BackgroundImage)

            res = reader.Decode(bitMap)

            If res IsNot Nothing Then
                captureDevice.Stop()
                captureDevice.WaitForStop()
                TimerScanBarcode.Stop()
                Dim student As List(Of String) = GetStudentProfile(res.ToString)

                If student.Count > 0 Then
                    FRMAdmit.TXTStudentnumber.Text = student(0)
                    FRMAdmit.TXTFullname.Text = student(1)
                    FRMAdmit.TXTCourse.Text = student(2)
                    Me.Close()
                Else

                    FRMAdmit.SBAdmit.Show(Me, "Student not registered !", BunifuSnackbar.MessageTypes.Warning, 4000, "Scan again",
                 BunifuSnackbar.Positions.BottomRight).Then(Sub(result)
                                                                PBScan.BackgroundImage = Nothing
                                                                If result = BunifuSnackbar.SnackbarResult.ActionClicked Then
                                                                    TimerScanBarcode.Start()
                                                                    captureDevice.Start()
                                                                Else
                                                                    TimerScanBarcode.Start()
                                                                    captureDevice.Start()
                                                                End If
                                                            End Sub)
                End If

            End If
        End If
    End Sub

    Private Sub CaptureDevice_NewFrame(sender As Object, e As NewFrameEventArgs) Handles captureDevice.NewFrame
        PBScan.BackgroundImage = e.Frame.Clone
    End Sub

    Private Sub FRMScanBarCode_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        captureDevice.Stop()
        TimerScanBarcode.Stop()
    End Sub
End Class