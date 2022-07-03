<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMSplashscreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMSplashscreen))
        Me.LBL01 = New Guna.UI.WinForms.GunaLabel()
        Me.LBL02 = New Guna.UI.WinForms.GunaLabel()
        Me.PICUrsgiantslogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PICUrslogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PBSplashScreen = New Bunifu.UI.WinForms.BunifuProgressBar()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PICUrsgiantslogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICUrslogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL01
        '
        Me.LBL01.Font = New System.Drawing.Font("Segoe UI Semilight", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL01.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBL01.Location = New System.Drawing.Point(0, 169)
        Me.LBL01.Name = "LBL01"
        Me.LBL01.Size = New System.Drawing.Size(518, 36)
        Me.LBL01.TabIndex = 0
        Me.LBL01.Text = "Stock Management System"
        Me.LBL01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL02
        '
        Me.LBL02.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL02.ForeColor = System.Drawing.Color.DarkGray
        Me.LBL02.Location = New System.Drawing.Point(0, 204)
        Me.LBL02.Name = "LBL02"
        Me.LBL02.Size = New System.Drawing.Size(518, 29)
        Me.LBL02.TabIndex = 1
        Me.LBL02.Text = "University Of Rizal System"
        Me.LBL02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PICUrsgiantslogo
        '
        Me.PICUrsgiantslogo.Image = Global.Clinic.My.Resources.Resources.ursgiantslogo
        Me.PICUrsgiantslogo.Location = New System.Drawing.Point(262, 33)
        Me.PICUrsgiantslogo.Name = "PICUrsgiantslogo"
        Me.PICUrsgiantslogo.ShadowDecoration.Parent = Me.PICUrsgiantslogo
        Me.PICUrsgiantslogo.Size = New System.Drawing.Size(115, 101)
        Me.PICUrsgiantslogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PICUrsgiantslogo.TabIndex = 2
        Me.PICUrsgiantslogo.TabStop = False
        '
        'PICUrslogo
        '
        Me.PICUrslogo.Image = Global.Clinic.My.Resources.Resources.urslogo
        Me.PICUrslogo.Location = New System.Drawing.Point(141, 33)
        Me.PICUrslogo.Name = "PICUrslogo"
        Me.PICUrslogo.ShadowDecoration.Parent = Me.PICUrslogo
        Me.PICUrslogo.Size = New System.Drawing.Size(115, 101)
        Me.PICUrslogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PICUrslogo.TabIndex = 2
        Me.PICUrslogo.TabStop = False
        '
        'PBSplashScreen
        '
        Me.PBSplashScreen.AllowAnimations = False
        Me.PBSplashScreen.Animation = 0
        Me.PBSplashScreen.AnimationSpeed = 220
        Me.PBSplashScreen.AnimationStep = 10
        Me.PBSplashScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.PBSplashScreen.BackgroundImage = CType(resources.GetObject("PBSplashScreen.BackgroundImage"), System.Drawing.Image)
        Me.PBSplashScreen.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.PBSplashScreen.BorderRadius = 9
        Me.PBSplashScreen.BorderThickness = 1
        Me.PBSplashScreen.Location = New System.Drawing.Point(6, 280)
        Me.PBSplashScreen.Maximum = 100
        Me.PBSplashScreen.MaximumValue = 100
        Me.PBSplashScreen.Minimum = 0
        Me.PBSplashScreen.MinimumValue = 0
        Me.PBSplashScreen.Name = "PBSplashScreen"
        Me.PBSplashScreen.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.PBSplashScreen.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.PBSplashScreen.ProgressColorLeft = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.PBSplashScreen.ProgressColorRight = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.PBSplashScreen.Size = New System.Drawing.Size(498, 13)
        Me.PBSplashScreen.TabIndex = 3
        Me.PBSplashScreen.Value = 0
        Me.PBSplashScreen.ValueByTransition = 0
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(2, 137)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(516, 36)
        Me.GunaLabel1.TabIndex = 4
        Me.GunaLabel1.Text = "CLINIC"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Starting..."
        '
        'FRMSplashscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(515, 301)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.PBSplashScreen)
        Me.Controls.Add(Me.PICUrsgiantslogo)
        Me.Controls.Add(Me.PICUrslogo)
        Me.Controls.Add(Me.LBL02)
        Me.Controls.Add(Me.LBL01)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMSplashscreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PICUrsgiantslogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICUrslogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL02 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PICUrslogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PICUrsgiantslogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LBL01 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PBSplashScreen As Bunifu.UI.WinForms.BunifuProgressBar
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As Label
End Class
