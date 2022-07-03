<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PICRecords = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LBLRecords = New Guna.UI.WinForms.GunaLabel()
        Me.PICAccount = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LBLAccount = New Guna.UI.WinForms.GunaLabel()
        Me.PICStocks = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LBLStocks = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.PICRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PICRecords
        '
        Me.PICRecords.Image = Global.Clinic.My.Resources.Resources.report
        Me.PICRecords.Location = New System.Drawing.Point(510, 328)
        Me.PICRecords.Name = "PICRecords"
        Me.PICRecords.ShadowDecoration.Parent = Me.PICRecords
        Me.PICRecords.Size = New System.Drawing.Size(122, 151)
        Me.PICRecords.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PICRecords.TabIndex = 11
        Me.PICRecords.TabStop = False
        '
        'LBLRecords
        '
        Me.LBLRecords.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LBLRecords.Location = New System.Drawing.Point(490, 465)
        Me.LBLRecords.Name = "LBLRecords"
        Me.LBLRecords.Size = New System.Drawing.Size(165, 140)
        Me.LBLRecords.TabIndex = 8
        Me.LBLRecords.Text = "Records are well stored and secured"
        Me.LBLRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PICAccount
        '
        Me.PICAccount.Image = Global.Clinic.My.Resources.Resources.accountupdtae
        Me.PICAccount.Location = New System.Drawing.Point(339, 328)
        Me.PICAccount.Name = "PICAccount"
        Me.PICAccount.ShadowDecoration.Parent = Me.PICAccount
        Me.PICAccount.Size = New System.Drawing.Size(122, 151)
        Me.PICAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PICAccount.TabIndex = 12
        Me.PICAccount.TabStop = False
        '
        'LBLAccount
        '
        Me.LBLAccount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LBLAccount.Location = New System.Drawing.Point(319, 465)
        Me.LBLAccount.Name = "LBLAccount"
        Me.LBLAccount.Size = New System.Drawing.Size(165, 140)
        Me.LBLAccount.TabIndex = 9
        Me.LBLAccount.Text = "Creating an account is not a problem as well as updating and deleting"
        Me.LBLAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PICStocks
        '
        Me.PICStocks.Image = Global.Clinic.My.Resources.Resources.stockrecord
        Me.PICStocks.Location = New System.Drawing.Point(164, 328)
        Me.PICStocks.Name = "PICStocks"
        Me.PICStocks.ShadowDecoration.Parent = Me.PICStocks
        Me.PICStocks.Size = New System.Drawing.Size(122, 151)
        Me.PICStocks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PICStocks.TabIndex = 13
        Me.PICStocks.TabStop = False
        '
        'LBLStocks
        '
        Me.LBLStocks.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LBLStocks.Location = New System.Drawing.Point(145, 465)
        Me.LBLStocks.Name = "LBLStocks"
        Me.LBLStocks.Size = New System.Drawing.Size(165, 140)
        Me.LBLStocks.TabIndex = 10
        Me.LBLStocks.Text = "You can add, delete, and update the stocks of the medicines"
        Me.LBLStocks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(0, 112)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(796, 112)
        Me.GunaLabel2.TabIndex = 6
        Me.GunaLabel2.Text = "This is the official stock management system of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "URS Binangonan Clinic"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.Location = New System.Drawing.Point(3, 61)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(793, 70)
        Me.GunaLabel1.TabIndex = 7
        Me.GunaLabel1.Text = "Welcome!"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FRMHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 666)
        Me.Controls.Add(Me.PICRecords)
        Me.Controls.Add(Me.LBLRecords)
        Me.Controls.Add(Me.PICAccount)
        Me.Controls.Add(Me.LBLAccount)
        Me.Controls.Add(Me.PICStocks)
        Me.Controls.Add(Me.LBLStocks)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PICRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PICRecords As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LBLRecords As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PICAccount As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LBLAccount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PICStocks As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LBLStocks As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
