<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMScanBarCode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PBScan = New System.Windows.Forms.PictureBox()
        Me.TimerScanBarcode = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PBScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBScan
        '
        Me.PBScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBScan.Location = New System.Drawing.Point(13, 12)
        Me.PBScan.Name = "PBScan"
        Me.PBScan.Size = New System.Drawing.Size(372, 387)
        Me.PBScan.TabIndex = 0
        Me.PBScan.TabStop = False
        '
        'TimerScanBarcode
        '
        Me.TimerScanBarcode.Enabled = True
        '
        'FRMScanBarCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(397, 415)
        Me.Controls.Add(Me.PBScan)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMScanBarCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SCAN BARCODE"
        CType(Me.PBScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PBScan As PictureBox
    Friend WithEvents TimerScanBarcode As Timer
End Class
