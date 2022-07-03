<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMAdmit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMAdmit))
        Me.PNLLayout = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNClear = New Guna.UI2.WinForms.Guna2Button()
        Me.TXTCourse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNAddMedCode = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNAddStudNum = New Guna.UI2.WinForms.Guna2Button()
        Me.LBLBinangonan = New Guna.UI.WinForms.GunaLabel()
        Me.LBLUrs = New Guna.UI.WinForms.GunaLabel()
        Me.PICUrslogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LBLQuantity = New Guna.UI.WinForms.GunaLabel()
        Me.LBLMedicinename = New Guna.UI.WinForms.GunaLabel()
        Me.LBLMedicinecode = New Guna.UI.WinForms.GunaLabel()
        Me.LBLCourse = New Guna.UI.WinForms.GunaLabel()
        Me.LBLFullname = New Guna.UI.WinForms.GunaLabel()
        Me.LBLStudentnumber = New Guna.UI.WinForms.GunaLabel()
        Me.TXTQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTMedicinename = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTFullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTMedicinecode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTStudentnumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PNLBarcode = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTNAdmit = New Guna.UI2.WinForms.Guna2Button()
        Me.TIPNormalcolor = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.SBAdmit = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.TbltransactionTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tbltransactionTableAdapter()
        Me.TblmedicineTableAdapter1 = New Clinic.clinicsmsdbDataSetTableAdapters.tblmedicineTableAdapter()
        Me.PNLLayout.SuspendLayout()
        CType(Me.PICUrslogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNLBarcode.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNLLayout
        '
        Me.PNLLayout.Controls.Add(Me.BTNClear)
        Me.PNLLayout.Controls.Add(Me.TXTCourse)
        Me.PNLLayout.Controls.Add(Me.BTNAddMedCode)
        Me.PNLLayout.Controls.Add(Me.BTNAddStudNum)
        Me.PNLLayout.Controls.Add(Me.LBLBinangonan)
        Me.PNLLayout.Controls.Add(Me.LBLUrs)
        Me.PNLLayout.Controls.Add(Me.PICUrslogo)
        Me.PNLLayout.Controls.Add(Me.LBLQuantity)
        Me.PNLLayout.Controls.Add(Me.LBLMedicinename)
        Me.PNLLayout.Controls.Add(Me.LBLMedicinecode)
        Me.PNLLayout.Controls.Add(Me.LBLCourse)
        Me.PNLLayout.Controls.Add(Me.LBLFullname)
        Me.PNLLayout.Controls.Add(Me.LBLStudentnumber)
        Me.PNLLayout.Controls.Add(Me.TXTQuantity)
        Me.PNLLayout.Controls.Add(Me.TXTMedicinename)
        Me.PNLLayout.Controls.Add(Me.TXTFullname)
        Me.PNLLayout.Controls.Add(Me.TXTMedicinecode)
        Me.PNLLayout.Controls.Add(Me.TXTStudentnumber)
        Me.PNLLayout.Controls.Add(Me.PNLBarcode)
        Me.PNLLayout.Controls.Add(Me.BTNAdmit)
        Me.PNLLayout.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PNLLayout.Location = New System.Drawing.Point(42, 26)
        Me.PNLLayout.Name = "PNLLayout"
        Me.PNLLayout.ShadowDecoration.Enabled = True
        Me.PNLLayout.ShadowDecoration.Parent = Me.PNLLayout
        Me.PNLLayout.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.PNLLayout.Size = New System.Drawing.Size(711, 599)
        Me.PNLLayout.TabIndex = 0
        '
        'BTNClear
        '
        Me.BTNClear.Animated = True
        Me.BTNClear.BackColor = System.Drawing.Color.Transparent
        Me.BTNClear.BorderRadius = 1
        Me.BTNClear.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNClear.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNClear.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNClear.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNClear.CheckedState.Parent = Me.BTNClear
        Me.BTNClear.CustomImages.Parent = Me.BTNClear
        Me.BTNClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNClear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNClear.ForeColor = System.Drawing.Color.White
        Me.BTNClear.HoverState.Parent = Me.BTNClear
        Me.BTNClear.Location = New System.Drawing.Point(49, 527)
        Me.BTNClear.Name = "BTNClear"
        Me.BTNClear.ShadowDecoration.Enabled = True
        Me.BTNClear.ShadowDecoration.Parent = Me.BTNClear
        Me.BTNClear.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNClear.Size = New System.Drawing.Size(197, 45)
        Me.BTNClear.TabIndex = 17
        Me.BTNClear.TabStop = False
        Me.BTNClear.Text = "CLEAR"
        Me.TIPNormalcolor.SetToolTip(Me.BTNClear, "Click to admit")
        '
        'TXTCourse
        '
        Me.TXTCourse.Animated = True
        Me.TXTCourse.BackColor = System.Drawing.Color.Transparent
        Me.TXTCourse.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTCourse.BorderRadius = 1
        Me.TXTCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTCourse.DefaultText = ""
        Me.TXTCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCourse.DisabledState.Parent = Me.TXTCourse
        Me.TXTCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCourse.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTCourse.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTCourse.FocusedState.Parent = Me.TXTCourse
        Me.TXTCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTCourse.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTCourse.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTCourse.HoverState.Parent = Me.TXTCourse
        Me.TXTCourse.Location = New System.Drawing.Point(175, 293)
        Me.TXTCourse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCourse.Name = "TXTCourse"
        Me.TXTCourse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTCourse.PlaceholderText = ""
        Me.TXTCourse.ReadOnly = True
        Me.TXTCourse.SelectedText = ""
        Me.TXTCourse.ShadowDecoration.Enabled = True
        Me.TXTCourse.ShadowDecoration.Parent = Me.TXTCourse
        Me.TXTCourse.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTCourse.Size = New System.Drawing.Size(495, 41)
        Me.TXTCourse.TabIndex = 16
        Me.TIPNormalcolor.SetToolTip(Me.TXTCourse, "Student full name")
        '
        'BTNAddMedCode
        '
        Me.BTNAddMedCode.Animated = True
        Me.BTNAddMedCode.BackColor = System.Drawing.Color.Transparent
        Me.BTNAddMedCode.BorderColor = System.Drawing.Color.White
        Me.BTNAddMedCode.BorderRadius = 1
        Me.BTNAddMedCode.BorderThickness = 1
        Me.BTNAddMedCode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddMedCode.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddMedCode.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddMedCode.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAddMedCode.CheckedState.Parent = Me.BTNAddMedCode
        Me.BTNAddMedCode.CustomImages.Parent = Me.BTNAddMedCode
        Me.BTNAddMedCode.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNAddMedCode.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAddMedCode.ForeColor = System.Drawing.Color.White
        Me.BTNAddMedCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddMedCode.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddMedCode.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddMedCode.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAddMedCode.HoverState.Parent = Me.BTNAddMedCode
        Me.BTNAddMedCode.Image = Global.Clinic.My.Resources.Resources.add_filled
        Me.BTNAddMedCode.Location = New System.Drawing.Point(570, 349)
        Me.BTNAddMedCode.Name = "BTNAddMedCode"
        Me.BTNAddMedCode.ShadowDecoration.Enabled = True
        Me.BTNAddMedCode.ShadowDecoration.Parent = Me.BTNAddMedCode
        Me.BTNAddMedCode.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNAddMedCode.Size = New System.Drawing.Size(100, 41)
        Me.BTNAddMedCode.TabIndex = 15
        Me.BTNAddMedCode.Text = "Add"
        Me.TIPNormalcolor.SetToolTip(Me.BTNAddMedCode, "Click to add account")
        '
        'BTNAddStudNum
        '
        Me.BTNAddStudNum.Animated = True
        Me.BTNAddStudNum.BackColor = System.Drawing.Color.Transparent
        Me.BTNAddStudNum.BorderColor = System.Drawing.Color.White
        Me.BTNAddStudNum.BorderRadius = 1
        Me.BTNAddStudNum.BorderThickness = 1
        Me.BTNAddStudNum.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddStudNum.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddStudNum.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddStudNum.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAddStudNum.CheckedState.Parent = Me.BTNAddStudNum
        Me.BTNAddStudNum.CustomImages.Parent = Me.BTNAddStudNum
        Me.BTNAddStudNum.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNAddStudNum.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAddStudNum.ForeColor = System.Drawing.Color.White
        Me.BTNAddStudNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddStudNum.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddStudNum.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddStudNum.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAddStudNum.HoverState.Parent = Me.BTNAddStudNum
        Me.BTNAddStudNum.Image = Global.Clinic.My.Resources.Resources.addaccount_filled
        Me.BTNAddStudNum.Location = New System.Drawing.Point(570, 181)
        Me.BTNAddStudNum.Name = "BTNAddStudNum"
        Me.BTNAddStudNum.ShadowDecoration.Enabled = True
        Me.BTNAddStudNum.ShadowDecoration.Parent = Me.BTNAddStudNum
        Me.BTNAddStudNum.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNAddStudNum.Size = New System.Drawing.Size(100, 41)
        Me.BTNAddStudNum.TabIndex = 14
        Me.BTNAddStudNum.Text = "Add"
        Me.TIPNormalcolor.SetToolTip(Me.BTNAddStudNum, "Click to add account")
        '
        'LBLBinangonan
        '
        Me.LBLBinangonan.BackColor = System.Drawing.Color.Transparent
        Me.LBLBinangonan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LBLBinangonan.Location = New System.Drawing.Point(190, 77)
        Me.LBLBinangonan.Name = "LBLBinangonan"
        Me.LBLBinangonan.Size = New System.Drawing.Size(339, 28)
        Me.LBLBinangonan.TabIndex = 13
        Me.LBLBinangonan.Text = "Binangonan, Rizal"
        Me.LBLBinangonan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLUrs
        '
        Me.LBLUrs.BackColor = System.Drawing.Color.Transparent
        Me.LBLUrs.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LBLUrs.Location = New System.Drawing.Point(186, 18)
        Me.LBLUrs.Name = "LBLUrs"
        Me.LBLUrs.Size = New System.Drawing.Size(339, 87)
        Me.LBLUrs.TabIndex = 13
        Me.LBLUrs.Text = "University of Rizal System"
        Me.LBLUrs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PICUrslogo
        '
        Me.PICUrslogo.BackColor = System.Drawing.Color.Transparent
        Me.PICUrslogo.Image = Global.Clinic.My.Resources.Resources.urslogo
        Me.PICUrslogo.Location = New System.Drawing.Point(45, 28)
        Me.PICUrslogo.Name = "PICUrslogo"
        Me.PICUrslogo.ShadowDecoration.Parent = Me.PICUrslogo
        Me.PICUrslogo.Size = New System.Drawing.Size(136, 134)
        Me.PICUrslogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PICUrslogo.TabIndex = 12
        Me.PICUrslogo.TabStop = False
        '
        'LBLQuantity
        '
        Me.LBLQuantity.BackColor = System.Drawing.Color.Transparent
        Me.LBLQuantity.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLQuantity.Location = New System.Drawing.Point(45, 461)
        Me.LBLQuantity.Name = "LBLQuantity"
        Me.LBLQuantity.Size = New System.Drawing.Size(123, 41)
        Me.LBLQuantity.TabIndex = 11
        Me.LBLQuantity.Text = "Quantity released"
        Me.LBLQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLMedicinename
        '
        Me.LBLMedicinename.BackColor = System.Drawing.Color.Transparent
        Me.LBLMedicinename.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMedicinename.Location = New System.Drawing.Point(45, 405)
        Me.LBLMedicinename.Name = "LBLMedicinename"
        Me.LBLMedicinename.Size = New System.Drawing.Size(107, 41)
        Me.LBLMedicinename.TabIndex = 11
        Me.LBLMedicinename.Text = "Medicine name"
        Me.LBLMedicinename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLMedicinecode
        '
        Me.LBLMedicinecode.BackColor = System.Drawing.Color.Transparent
        Me.LBLMedicinecode.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMedicinecode.Location = New System.Drawing.Point(45, 349)
        Me.LBLMedicinecode.Name = "LBLMedicinecode"
        Me.LBLMedicinecode.Size = New System.Drawing.Size(107, 41)
        Me.LBLMedicinecode.TabIndex = 11
        Me.LBLMedicinecode.Text = "Medicine code"
        Me.LBLMedicinecode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLCourse
        '
        Me.LBLCourse.BackColor = System.Drawing.Color.Transparent
        Me.LBLCourse.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCourse.Location = New System.Drawing.Point(45, 293)
        Me.LBLCourse.Name = "LBLCourse"
        Me.LBLCourse.Size = New System.Drawing.Size(55, 41)
        Me.LBLCourse.TabIndex = 11
        Me.LBLCourse.Text = "Course"
        Me.LBLCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLFullname
        '
        Me.LBLFullname.BackColor = System.Drawing.Color.Transparent
        Me.LBLFullname.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFullname.Location = New System.Drawing.Point(45, 237)
        Me.LBLFullname.Name = "LBLFullname"
        Me.LBLFullname.Size = New System.Drawing.Size(68, 41)
        Me.LBLFullname.TabIndex = 11
        Me.LBLFullname.Text = "Full name"
        Me.LBLFullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLStudentnumber
        '
        Me.LBLStudentnumber.BackColor = System.Drawing.Color.Transparent
        Me.LBLStudentnumber.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLStudentnumber.Location = New System.Drawing.Point(45, 181)
        Me.LBLStudentnumber.Name = "LBLStudentnumber"
        Me.LBLStudentnumber.Size = New System.Drawing.Size(116, 41)
        Me.LBLStudentnumber.TabIndex = 11
        Me.LBLStudentnumber.Text = "Student number"
        Me.LBLStudentnumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXTQuantity
        '
        Me.TXTQuantity.Animated = True
        Me.TXTQuantity.BackColor = System.Drawing.Color.Transparent
        Me.TXTQuantity.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTQuantity.BorderRadius = 1
        Me.TXTQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTQuantity.DefaultText = ""
        Me.TXTQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTQuantity.DisabledState.Parent = Me.TXTQuantity
        Me.TXTQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTQuantity.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTQuantity.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTQuantity.FocusedState.Parent = Me.TXTQuantity
        Me.TXTQuantity.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTQuantity.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTQuantity.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTQuantity.HoverState.Parent = Me.TXTQuantity
        Me.TXTQuantity.Location = New System.Drawing.Point(174, 461)
        Me.TXTQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTQuantity.Name = "TXTQuantity"
        Me.TXTQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTQuantity.PlaceholderText = ""
        Me.TXTQuantity.SelectedText = ""
        Me.TXTQuantity.ShadowDecoration.Enabled = True
        Me.TXTQuantity.ShadowDecoration.Parent = Me.TXTQuantity
        Me.TXTQuantity.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTQuantity.Size = New System.Drawing.Size(496, 41)
        Me.TXTQuantity.TabIndex = 7
        Me.TIPNormalcolor.SetToolTip(Me.TXTQuantity, "Medicine quantity")
        '
        'TXTMedicinename
        '
        Me.TXTMedicinename.Animated = True
        Me.TXTMedicinename.BackColor = System.Drawing.Color.Transparent
        Me.TXTMedicinename.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTMedicinename.BorderRadius = 1
        Me.TXTMedicinename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTMedicinename.DefaultText = ""
        Me.TXTMedicinename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTMedicinename.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTMedicinename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTMedicinename.DisabledState.Parent = Me.TXTMedicinename
        Me.TXTMedicinename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTMedicinename.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTMedicinename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTMedicinename.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTMedicinename.FocusedState.Parent = Me.TXTMedicinename
        Me.TXTMedicinename.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTMedicinename.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTMedicinename.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTMedicinename.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTMedicinename.HoverState.Parent = Me.TXTMedicinename
        Me.TXTMedicinename.Location = New System.Drawing.Point(175, 405)
        Me.TXTMedicinename.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTMedicinename.Name = "TXTMedicinename"
        Me.TXTMedicinename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTMedicinename.PlaceholderText = ""
        Me.TXTMedicinename.ReadOnly = True
        Me.TXTMedicinename.SelectedText = ""
        Me.TXTMedicinename.ShadowDecoration.Enabled = True
        Me.TXTMedicinename.ShadowDecoration.Parent = Me.TXTMedicinename
        Me.TXTMedicinename.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTMedicinename.Size = New System.Drawing.Size(495, 41)
        Me.TXTMedicinename.TabIndex = 6
        Me.TIPNormalcolor.SetToolTip(Me.TXTMedicinename, "Medicine name")
        '
        'TXTFullname
        '
        Me.TXTFullname.Animated = True
        Me.TXTFullname.BackColor = System.Drawing.Color.Transparent
        Me.TXTFullname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTFullname.BorderRadius = 1
        Me.TXTFullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTFullname.DefaultText = ""
        Me.TXTFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTFullname.DisabledState.Parent = Me.TXTFullname
        Me.TXTFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTFullname.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTFullname.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTFullname.FocusedState.Parent = Me.TXTFullname
        Me.TXTFullname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTFullname.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTFullname.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTFullname.HoverState.Parent = Me.TXTFullname
        Me.TXTFullname.Location = New System.Drawing.Point(174, 237)
        Me.TXTFullname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTFullname.Name = "TXTFullname"
        Me.TXTFullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTFullname.PlaceholderText = ""
        Me.TXTFullname.ReadOnly = True
        Me.TXTFullname.SelectedText = ""
        Me.TXTFullname.ShadowDecoration.Enabled = True
        Me.TXTFullname.ShadowDecoration.Parent = Me.TXTFullname
        Me.TXTFullname.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTFullname.Size = New System.Drawing.Size(495, 41)
        Me.TXTFullname.TabIndex = 2
        Me.TIPNormalcolor.SetToolTip(Me.TXTFullname, "Student full name")
        '
        'TXTMedicinecode
        '
        Me.TXTMedicinecode.Animated = True
        Me.TXTMedicinecode.BackColor = System.Drawing.Color.Transparent
        Me.TXTMedicinecode.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTMedicinecode.BorderRadius = 1
        Me.TXTMedicinecode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTMedicinecode.DefaultText = ""
        Me.TXTMedicinecode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTMedicinecode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTMedicinecode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTMedicinecode.DisabledState.Parent = Me.TXTMedicinecode
        Me.TXTMedicinecode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTMedicinecode.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTMedicinecode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTMedicinecode.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTMedicinecode.FocusedState.Parent = Me.TXTMedicinecode
        Me.TXTMedicinecode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTMedicinecode.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTMedicinecode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTMedicinecode.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTMedicinecode.HoverState.Parent = Me.TXTMedicinecode
        Me.TXTMedicinecode.Location = New System.Drawing.Point(175, 349)
        Me.TXTMedicinecode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTMedicinecode.Name = "TXTMedicinecode"
        Me.TXTMedicinecode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTMedicinecode.PlaceholderText = ""
        Me.TXTMedicinecode.ReadOnly = True
        Me.TXTMedicinecode.SelectedText = ""
        Me.TXTMedicinecode.ShadowDecoration.Enabled = True
        Me.TXTMedicinecode.ShadowDecoration.Parent = Me.TXTMedicinecode
        Me.TXTMedicinecode.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTMedicinecode.Size = New System.Drawing.Size(389, 41)
        Me.TXTMedicinecode.TabIndex = 5
        Me.TIPNormalcolor.SetToolTip(Me.TXTMedicinecode, "Medicine code")
        '
        'TXTStudentnumber
        '
        Me.TXTStudentnumber.Animated = True
        Me.TXTStudentnumber.BackColor = System.Drawing.Color.Transparent
        Me.TXTStudentnumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTStudentnumber.BorderRadius = 1
        Me.TXTStudentnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTStudentnumber.DefaultText = ""
        Me.TXTStudentnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTStudentnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTStudentnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTStudentnumber.DisabledState.Parent = Me.TXTStudentnumber
        Me.TXTStudentnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTStudentnumber.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTStudentnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTStudentnumber.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTStudentnumber.FocusedState.Parent = Me.TXTStudentnumber
        Me.TXTStudentnumber.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTStudentnumber.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTStudentnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTStudentnumber.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTStudentnumber.HoverState.Parent = Me.TXTStudentnumber
        Me.TXTStudentnumber.Location = New System.Drawing.Point(174, 181)
        Me.TXTStudentnumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTStudentnumber.Name = "TXTStudentnumber"
        Me.TXTStudentnumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTStudentnumber.PlaceholderText = ""
        Me.TXTStudentnumber.ReadOnly = True
        Me.TXTStudentnumber.SelectedText = ""
        Me.TXTStudentnumber.ShadowDecoration.Enabled = True
        Me.TXTStudentnumber.ShadowDecoration.Parent = Me.TXTStudentnumber
        Me.TXTStudentnumber.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTStudentnumber.Size = New System.Drawing.Size(390, 41)
        Me.TXTStudentnumber.TabIndex = 1
        Me.TIPNormalcolor.SetToolTip(Me.TXTStudentnumber, "Student number")
        '
        'PNLBarcode
        '
        Me.PNLBarcode.Controls.Add(Me.Label1)
        Me.PNLBarcode.Controls.Add(Me.Guna2PictureBox1)
        Me.PNLBarcode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PNLBarcode.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.PNLBarcode.Location = New System.Drawing.Point(531, 28)
        Me.PNLBarcode.Name = "PNLBarcode"
        Me.PNLBarcode.ShadowDecoration.Parent = Me.PNLBarcode
        Me.PNLBarcode.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.PNLBarcode.Size = New System.Drawing.Size(137, 134)
        Me.PNLBarcode.TabIndex = 7
        Me.TIPNormalcolor.SetToolTip(Me.PNLBarcode, "Click to scan")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(25, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Scan Barcode"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImage = Global.Clinic.My.Resources.Resources.bar_code
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.InitialImage = Nothing
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(26, 21)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(85, 62)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'BTNAdmit
        '
        Me.BTNAdmit.Animated = True
        Me.BTNAdmit.BackColor = System.Drawing.Color.Transparent
        Me.BTNAdmit.BorderRadius = 1
        Me.BTNAdmit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNAdmit.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNAdmit.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNAdmit.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAdmit.CheckedState.Parent = Me.BTNAdmit
        Me.BTNAdmit.CustomImages.Parent = Me.BTNAdmit
        Me.BTNAdmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNAdmit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNAdmit.ForeColor = System.Drawing.Color.White
        Me.BTNAdmit.HoverState.Parent = Me.BTNAdmit
        Me.BTNAdmit.Location = New System.Drawing.Point(472, 527)
        Me.BTNAdmit.Name = "BTNAdmit"
        Me.BTNAdmit.ShadowDecoration.Enabled = True
        Me.BTNAdmit.ShadowDecoration.Parent = Me.BTNAdmit
        Me.BTNAdmit.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNAdmit.Size = New System.Drawing.Size(197, 45)
        Me.BTNAdmit.TabIndex = 6
        Me.BTNAdmit.TabStop = False
        Me.BTNAdmit.Text = "ADMIT"
        Me.TIPNormalcolor.SetToolTip(Me.BTNAdmit, "Click to admit")
        '
        'TIPNormalcolor
        '
        Me.TIPNormalcolor.AllowLinksHandling = True
        Me.TIPNormalcolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TIPNormalcolor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TIPNormalcolor.ForeColor = System.Drawing.SystemColors.Control
        Me.TIPNormalcolor.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'SBAdmit
        '
        Me.SBAdmit.AllowDragging = False
        Me.SBAdmit.AllowMultipleViews = True
        Me.SBAdmit.ClickToClose = True
        Me.SBAdmit.DoubleClickToClose = True
        Me.SBAdmit.DurationAfterIdle = 3000
        Me.SBAdmit.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBAdmit.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBAdmit.ErrorOptions.ActionBorderRadius = 1
        Me.SBAdmit.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBAdmit.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBAdmit.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.SBAdmit.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.SBAdmit.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.SBAdmit.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBAdmit.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.SBAdmit.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.SBAdmit.ErrorOptions.IconLeftMargin = 12
        Me.SBAdmit.FadeCloseIcon = False
        Me.SBAdmit.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.SBAdmit.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBAdmit.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBAdmit.InformationOptions.ActionBorderRadius = 1
        Me.SBAdmit.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBAdmit.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBAdmit.InformationOptions.BackColor = System.Drawing.Color.White
        Me.SBAdmit.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.SBAdmit.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBAdmit.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBAdmit.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.SBAdmit.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.SBAdmit.InformationOptions.IconLeftMargin = 12
        Me.SBAdmit.Margin = 10
        Me.SBAdmit.MaximumSize = New System.Drawing.Size(0, 0)
        Me.SBAdmit.MaximumViews = 7
        Me.SBAdmit.MessageRightMargin = 15
        Me.SBAdmit.MinimumSize = New System.Drawing.Size(0, 0)
        Me.SBAdmit.ShowBorders = False
        Me.SBAdmit.ShowCloseIcon = False
        Me.SBAdmit.ShowIcon = True
        Me.SBAdmit.ShowShadows = True
        Me.SBAdmit.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBAdmit.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBAdmit.SuccessOptions.ActionBorderRadius = 1
        Me.SBAdmit.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBAdmit.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBAdmit.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.SBAdmit.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.SBAdmit.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SBAdmit.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBAdmit.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.SBAdmit.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.SBAdmit.SuccessOptions.IconLeftMargin = 12
        Me.SBAdmit.ViewsMargin = 7
        Me.SBAdmit.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBAdmit.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBAdmit.WarningOptions.ActionBorderRadius = 1
        Me.SBAdmit.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBAdmit.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBAdmit.WarningOptions.BackColor = System.Drawing.Color.White
        Me.SBAdmit.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.SBAdmit.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.SBAdmit.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBAdmit.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.SBAdmit.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.SBAdmit.WarningOptions.IconLeftMargin = 12
        Me.SBAdmit.ZoomCloseIcon = True
        '
        'TbltransactionTableAdapter
        '
        Me.TbltransactionTableAdapter.ClearBeforeFill = True
        '
        'TblmedicineTableAdapter1
        '
        Me.TblmedicineTableAdapter1.ClearBeforeFill = True
        '
        'FRMAdmit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 666)
        Me.Controls.Add(Me.PNLLayout)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMAdmit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PNLLayout.ResumeLayout(False)
        CType(Me.PICUrslogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNLBarcode.ResumeLayout(False)
        Me.PNLBarcode.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNLLayout As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNAdmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PNLBarcode As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TXTFullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTStudentnumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LBLQuantity As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LBLMedicinename As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LBLMedicinecode As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LBLCourse As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LBLFullname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LBLStudentnumber As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXTQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTMedicinename As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTMedicinecode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TIPNormalcolor As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents PICUrslogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LBLUrs As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LBLBinangonan As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXTCourse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNAddMedCode As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNAddStudNum As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TbltransactionTableAdapter As clinicsmsdbDataSetTableAdapters.tbltransactionTableAdapter
    Friend WithEvents SBAdmit As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents BTNClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TblmedicineTableAdapter1 As clinicsmsdbDataSetTableAdapters.tblmedicineTableAdapter
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
End Class
