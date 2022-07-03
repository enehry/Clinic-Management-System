<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMStudentassistant
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMStudentassistant))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TblcourseTableAdapter1 = New Clinic.clinicsmsdbDataSetTableAdapters.tblcourseTableAdapter()
        Me.TblstudentprofileTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tblstudentprofileTableAdapter()
        Me.BSStudent = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PNLDisplayselected = New Guna.UI2.WinForms.Guna2Panel()
        Me.CMBSex = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXTLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTMiddlename = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CMBCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXTContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTStudentnumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PNLDatagridview = New Guna.UI2.WinForms.Guna2Panel()
        Me.DGVStudents = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.StudentnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoursenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblstudentprofileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicsmsdbDataSet = New Clinic.clinicsmsdbDataSet()
        Me.TIPNormalcolor = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.BTNTrash = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PNLDisplayselected.SuspendLayout()
        Me.PNLDatagridview.SuspendLayout()
        CType(Me.DGVStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstudentprofileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblcourseTableAdapter1
        '
        Me.TblcourseTableAdapter1.ClearBeforeFill = True
        '
        'TblstudentprofileTableAdapter
        '
        Me.TblstudentprofileTableAdapter.ClearBeforeFill = True
        '
        'BSStudent
        '
        Me.BSStudent.AllowDragging = False
        Me.BSStudent.AllowMultipleViews = True
        Me.BSStudent.ClickToClose = True
        Me.BSStudent.DoubleClickToClose = True
        Me.BSStudent.DurationAfterIdle = 3000
        Me.BSStudent.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudent.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudent.ErrorOptions.ActionBorderRadius = 1
        Me.BSStudent.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BSStudent.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BSStudent.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.BSStudent.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.BSStudent.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BSStudent.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BSStudent.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.BSStudent.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.BSStudent.ErrorOptions.IconLeftMargin = 12
        Me.BSStudent.FadeCloseIcon = False
        Me.BSStudent.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.BSStudent.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudent.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudent.InformationOptions.ActionBorderRadius = 1
        Me.BSStudent.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BSStudent.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BSStudent.InformationOptions.BackColor = System.Drawing.Color.White
        Me.BSStudent.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.BSStudent.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudent.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BSStudent.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.BSStudent.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.BSStudent.InformationOptions.IconLeftMargin = 12
        Me.BSStudent.Margin = 10
        Me.BSStudent.MaximumSize = New System.Drawing.Size(0, 0)
        Me.BSStudent.MaximumViews = 7
        Me.BSStudent.MessageRightMargin = 15
        Me.BSStudent.MinimumSize = New System.Drawing.Size(0, 0)
        Me.BSStudent.ShowBorders = False
        Me.BSStudent.ShowCloseIcon = False
        Me.BSStudent.ShowIcon = True
        Me.BSStudent.ShowShadows = True
        Me.BSStudent.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudent.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudent.SuccessOptions.ActionBorderRadius = 1
        Me.BSStudent.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BSStudent.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BSStudent.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.BSStudent.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.BSStudent.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.BSStudent.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BSStudent.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.BSStudent.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.BSStudent.SuccessOptions.IconLeftMargin = 12
        Me.BSStudent.ViewsMargin = 7
        Me.BSStudent.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudent.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudent.WarningOptions.ActionBorderRadius = 1
        Me.BSStudent.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BSStudent.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BSStudent.WarningOptions.BackColor = System.Drawing.Color.White
        Me.BSStudent.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.BSStudent.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BSStudent.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BSStudent.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.BSStudent.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.BSStudent.WarningOptions.IconLeftMargin = 12
        Me.BSStudent.ZoomCloseIcon = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(378, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sex"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(378, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Course"
        '
        'PNLDisplayselected
        '
        Me.PNLDisplayselected.Controls.Add(Me.Label2)
        Me.PNLDisplayselected.Controls.Add(Me.Label1)
        Me.PNLDisplayselected.Controls.Add(Me.CMBSex)
        Me.PNLDisplayselected.Controls.Add(Me.TXTLastname)
        Me.PNLDisplayselected.Controls.Add(Me.TXTMiddlename)
        Me.PNLDisplayselected.Controls.Add(Me.CMBCourse)
        Me.PNLDisplayselected.Controls.Add(Me.TXTContact)
        Me.PNLDisplayselected.Controls.Add(Me.TXTAddress)
        Me.PNLDisplayselected.Controls.Add(Me.TXTStudentnumber)
        Me.PNLDisplayselected.Controls.Add(Me.TXTFirstname)
        Me.PNLDisplayselected.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PNLDisplayselected.Location = New System.Drawing.Point(38, 328)
        Me.PNLDisplayselected.Name = "PNLDisplayselected"
        Me.PNLDisplayselected.ShadowDecoration.Enabled = True
        Me.PNLDisplayselected.ShadowDecoration.Parent = Me.PNLDisplayselected
        Me.PNLDisplayselected.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.PNLDisplayselected.Size = New System.Drawing.Size(720, 233)
        Me.PNLDisplayselected.TabIndex = 24
        '
        'CMBSex
        '
        Me.CMBSex.BackColor = System.Drawing.Color.Transparent
        Me.CMBSex.BorderRadius = 1
        Me.CMBSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBSex.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CMBSex.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CMBSex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CMBSex.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.CMBSex.FocusedState.Parent = Me.CMBSex
        Me.CMBSex.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBSex.ForeColor = System.Drawing.SystemColors.Control
        Me.CMBSex.FormattingEnabled = True
        Me.CMBSex.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CMBSex.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.CMBSex.HoverState.Parent = Me.CMBSex
        Me.CMBSex.ItemHeight = 30
        Me.CMBSex.Items.AddRange(New Object() {"m", "f"})
        Me.CMBSex.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CMBSex.ItemsAppearance.ForeColor = System.Drawing.SystemColors.Control
        Me.CMBSex.ItemsAppearance.Parent = Me.CMBSex
        Me.CMBSex.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CMBSex.ItemsAppearance.SelectedForeColor = System.Drawing.SystemColors.Control
        Me.CMBSex.Location = New System.Drawing.Point(444, 171)
        Me.CMBSex.Name = "CMBSex"
        Me.CMBSex.ShadowDecoration.Enabled = True
        Me.CMBSex.ShadowDecoration.Parent = Me.CMBSex
        Me.CMBSex.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.CMBSex.Size = New System.Drawing.Size(243, 36)
        Me.CMBSex.TabIndex = 3
        Me.TIPNormalcolor.SetToolTip(Me.CMBSex, "Course")
        '
        'TXTLastname
        '
        Me.TXTLastname.Animated = True
        Me.TXTLastname.BackColor = System.Drawing.Color.Transparent
        Me.TXTLastname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTLastname.BorderRadius = 1
        Me.TXTLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTLastname.DefaultText = ""
        Me.TXTLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTLastname.DisabledState.Parent = Me.TXTLastname
        Me.TXTLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTLastname.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTLastname.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTLastname.FocusedState.Parent = Me.TXTLastname
        Me.TXTLastname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTLastname.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTLastname.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTLastname.HoverState.Parent = Me.TXTLastname
        Me.TXTLastname.Location = New System.Drawing.Point(33, 166)
        Me.TXTLastname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTLastname.Name = "TXTLastname"
        Me.TXTLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTLastname.PlaceholderText = "Last name"
        Me.TXTLastname.SelectedText = ""
        Me.TXTLastname.ShadowDecoration.Enabled = True
        Me.TXTLastname.ShadowDecoration.Parent = Me.TXTLastname
        Me.TXTLastname.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTLastname.Size = New System.Drawing.Size(323, 41)
        Me.TXTLastname.TabIndex = 2
        Me.TIPNormalcolor.SetToolTip(Me.TXTLastname, "Last name")
        '
        'TXTMiddlename
        '
        Me.TXTMiddlename.Animated = True
        Me.TXTMiddlename.BackColor = System.Drawing.Color.Transparent
        Me.TXTMiddlename.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTMiddlename.BorderRadius = 1
        Me.TXTMiddlename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTMiddlename.DefaultText = ""
        Me.TXTMiddlename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTMiddlename.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTMiddlename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTMiddlename.DisabledState.Parent = Me.TXTMiddlename
        Me.TXTMiddlename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTMiddlename.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTMiddlename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTMiddlename.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTMiddlename.FocusedState.Parent = Me.TXTMiddlename
        Me.TXTMiddlename.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTMiddlename.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTMiddlename.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTMiddlename.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTMiddlename.HoverState.Parent = Me.TXTMiddlename
        Me.TXTMiddlename.Location = New System.Drawing.Point(33, 121)
        Me.TXTMiddlename.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTMiddlename.Name = "TXTMiddlename"
        Me.TXTMiddlename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTMiddlename.PlaceholderText = "Middle name"
        Me.TXTMiddlename.SelectedText = ""
        Me.TXTMiddlename.ShadowDecoration.Enabled = True
        Me.TXTMiddlename.ShadowDecoration.Parent = Me.TXTMiddlename
        Me.TXTMiddlename.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTMiddlename.Size = New System.Drawing.Size(323, 41)
        Me.TXTMiddlename.TabIndex = 2
        Me.TIPNormalcolor.SetToolTip(Me.TXTMiddlename, "Middle name")
        '
        'CMBCourse
        '
        Me.CMBCourse.BackColor = System.Drawing.Color.Transparent
        Me.CMBCourse.BorderRadius = 1
        Me.CMBCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBCourse.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CMBCourse.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CMBCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CMBCourse.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.CMBCourse.FocusedState.Parent = Me.CMBCourse
        Me.CMBCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CMBCourse.ForeColor = System.Drawing.SystemColors.Control
        Me.CMBCourse.FormattingEnabled = True
        Me.CMBCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CMBCourse.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.CMBCourse.HoverState.Parent = Me.CMBCourse
        Me.CMBCourse.ItemHeight = 30
        Me.CMBCourse.Items.AddRange(New Object() {"tes"})
        Me.CMBCourse.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CMBCourse.ItemsAppearance.ForeColor = System.Drawing.SystemColors.Control
        Me.CMBCourse.ItemsAppearance.Parent = Me.CMBCourse
        Me.CMBCourse.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CMBCourse.ItemsAppearance.SelectedForeColor = System.Drawing.SystemColors.Control
        Me.CMBCourse.Location = New System.Drawing.Point(444, 126)
        Me.CMBCourse.Name = "CMBCourse"
        Me.CMBCourse.ShadowDecoration.Enabled = True
        Me.CMBCourse.ShadowDecoration.Parent = Me.CMBCourse
        Me.CMBCourse.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.CMBCourse.Size = New System.Drawing.Size(243, 36)
        Me.CMBCourse.TabIndex = 3
        Me.TIPNormalcolor.SetToolTip(Me.CMBCourse, "Course")
        '
        'TXTContact
        '
        Me.TXTContact.Animated = True
        Me.TXTContact.BackColor = System.Drawing.Color.Transparent
        Me.TXTContact.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTContact.BorderRadius = 1
        Me.TXTContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTContact.DefaultText = ""
        Me.TXTContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTContact.DisabledState.Parent = Me.TXTContact
        Me.TXTContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTContact.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTContact.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTContact.FocusedState.Parent = Me.TXTContact
        Me.TXTContact.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTContact.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTContact.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTContact.HoverState.Parent = Me.TXTContact
        Me.TXTContact.Location = New System.Drawing.Point(364, 75)
        Me.TXTContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTContact.Name = "TXTContact"
        Me.TXTContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTContact.PlaceholderText = "Contact"
        Me.TXTContact.SelectedText = ""
        Me.TXTContact.ShadowDecoration.Enabled = True
        Me.TXTContact.ShadowDecoration.Parent = Me.TXTContact
        Me.TXTContact.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTContact.Size = New System.Drawing.Size(323, 41)
        Me.TXTContact.TabIndex = 2
        Me.TIPNormalcolor.SetToolTip(Me.TXTContact, "Contact number")
        '
        'TXTAddress
        '
        Me.TXTAddress.Animated = True
        Me.TXTAddress.BackColor = System.Drawing.Color.Transparent
        Me.TXTAddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTAddress.BorderRadius = 1
        Me.TXTAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTAddress.DefaultText = ""
        Me.TXTAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTAddress.DisabledState.Parent = Me.TXTAddress
        Me.TXTAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTAddress.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTAddress.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTAddress.FocusedState.Parent = Me.TXTAddress
        Me.TXTAddress.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTAddress.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTAddress.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTAddress.HoverState.Parent = Me.TXTAddress
        Me.TXTAddress.Location = New System.Drawing.Point(364, 30)
        Me.TXTAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTAddress.Name = "TXTAddress"
        Me.TXTAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTAddress.PlaceholderText = "Address"
        Me.TXTAddress.SelectedText = ""
        Me.TXTAddress.ShadowDecoration.Enabled = True
        Me.TXTAddress.ShadowDecoration.Parent = Me.TXTAddress
        Me.TXTAddress.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTAddress.Size = New System.Drawing.Size(323, 41)
        Me.TXTAddress.TabIndex = 2
        Me.TIPNormalcolor.SetToolTip(Me.TXTAddress, "Student address")
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
        Me.TXTStudentnumber.Location = New System.Drawing.Point(33, 31)
        Me.TXTStudentnumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTStudentnumber.Name = "TXTStudentnumber"
        Me.TXTStudentnumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTStudentnumber.PlaceholderText = "Student ID"
        Me.TXTStudentnumber.SelectedText = ""
        Me.TXTStudentnumber.ShadowDecoration.Enabled = True
        Me.TXTStudentnumber.ShadowDecoration.Parent = Me.TXTStudentnumber
        Me.TXTStudentnumber.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTStudentnumber.Size = New System.Drawing.Size(323, 41)
        Me.TXTStudentnumber.TabIndex = 2
        Me.TIPNormalcolor.SetToolTip(Me.TXTStudentnumber, "Student ID")
        '
        'TXTFirstname
        '
        Me.TXTFirstname.Animated = True
        Me.TXTFirstname.BackColor = System.Drawing.Color.Transparent
        Me.TXTFirstname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTFirstname.BorderRadius = 1
        Me.TXTFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTFirstname.DefaultText = ""
        Me.TXTFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTFirstname.DisabledState.Parent = Me.TXTFirstname
        Me.TXTFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTFirstname.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTFirstname.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTFirstname.FocusedState.Parent = Me.TXTFirstname
        Me.TXTFirstname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTFirstname.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTFirstname.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTFirstname.HoverState.Parent = Me.TXTFirstname
        Me.TXTFirstname.Location = New System.Drawing.Point(33, 76)
        Me.TXTFirstname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTFirstname.Name = "TXTFirstname"
        Me.TXTFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTFirstname.PlaceholderText = "First name"
        Me.TXTFirstname.SelectedText = ""
        Me.TXTFirstname.ShadowDecoration.Enabled = True
        Me.TXTFirstname.ShadowDecoration.Parent = Me.TXTFirstname
        Me.TXTFirstname.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTFirstname.Size = New System.Drawing.Size(323, 41)
        Me.TXTFirstname.TabIndex = 2
        Me.TIPNormalcolor.SetToolTip(Me.TXTFirstname, "First name")
        '
        'TXTSearch
        '
        Me.TXTSearch.BackColor = System.Drawing.Color.Transparent
        Me.TXTSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTSearch.BorderRadius = 1
        Me.TXTSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTSearch.DefaultText = ""
        Me.TXTSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSearch.DisabledState.Parent = Me.TXTSearch
        Me.TXTSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTSearch.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTSearch.FocusedState.Parent = Me.TXTSearch
        Me.TXTSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTSearch.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTSearch.HoverState.Parent = Me.TXTSearch
        Me.TXTSearch.Location = New System.Drawing.Point(38, 39)
        Me.TXTSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTSearch.Name = "TXTSearch"
        Me.TXTSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSearch.PlaceholderText = "Search..."
        Me.TXTSearch.SelectedText = ""
        Me.TXTSearch.ShadowDecoration.Enabled = True
        Me.TXTSearch.ShadowDecoration.Parent = Me.TXTSearch
        Me.TXTSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTSearch.Size = New System.Drawing.Size(500, 45)
        Me.TXTSearch.TabIndex = 21
        Me.TIPNormalcolor.SetToolTip(Me.TXTSearch, "Are you looking for something?")
        '
        'PNLDatagridview
        '
        Me.PNLDatagridview.Controls.Add(Me.DGVStudents)
        Me.PNLDatagridview.Location = New System.Drawing.Point(38, 108)
        Me.PNLDatagridview.Name = "PNLDatagridview"
        Me.PNLDatagridview.ShadowDecoration.Enabled = True
        Me.PNLDatagridview.ShadowDecoration.Parent = Me.PNLDatagridview
        Me.PNLDatagridview.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.PNLDatagridview.Size = New System.Drawing.Size(720, 191)
        Me.PNLDatagridview.TabIndex = 23
        '
        'DGVStudents
        '
        Me.DGVStudents.AllowUserToAddRows = False
        Me.DGVStudents.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVStudents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVStudents.AutoGenerateColumns = False
        Me.DGVStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVStudents.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVStudents.ColumnHeadersHeight = 40
        Me.DGVStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentnumberDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.MnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactnoDataGridViewTextBoxColumn, Me.CreatedatDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.CoursenameDataGridViewTextBoxColumn})
        Me.DGVStudents.DataSource = Me.TblstudentprofileBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVStudents.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVStudents.EnableHeadersVisualStyles = False
        Me.DGVStudents.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVStudents.Location = New System.Drawing.Point(0, 0)
        Me.DGVStudents.Name = "DGVStudents"
        Me.DGVStudents.ReadOnly = True
        Me.DGVStudents.RowHeadersVisible = False
        Me.DGVStudents.RowTemplate.Height = 30
        Me.DGVStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVStudents.Size = New System.Drawing.Size(720, 191)
        Me.DGVStudents.TabIndex = 1
        Me.DGVStudents.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        Me.DGVStudents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DGVStudents.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVStudents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVStudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVStudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVStudents.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVStudents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVStudents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.DGVStudents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVStudents.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVStudents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVStudents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVStudents.ThemeStyle.HeaderStyle.Height = 40
        Me.DGVStudents.ThemeStyle.ReadOnly = True
        Me.DGVStudents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVStudents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVStudents.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVStudents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVStudents.ThemeStyle.RowsStyle.Height = 30
        Me.DGVStudents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGVStudents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'StudentnumberDataGridViewTextBoxColumn
        '
        Me.StudentnumberDataGridViewTextBoxColumn.DataPropertyName = "student_number"
        Me.StudentnumberDataGridViewTextBoxColumn.HeaderText = "student no"
        Me.StudentnumberDataGridViewTextBoxColumn.Name = "StudentnumberDataGridViewTextBoxColumn"
        Me.StudentnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "fname"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        Me.FnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MnameDataGridViewTextBoxColumn
        '
        Me.MnameDataGridViewTextBoxColumn.DataPropertyName = "mname"
        Me.MnameDataGridViewTextBoxColumn.HeaderText = "mname"
        Me.MnameDataGridViewTextBoxColumn.Name = "MnameDataGridViewTextBoxColumn"
        Me.MnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "lname"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        Me.LnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactnoDataGridViewTextBoxColumn
        '
        Me.ContactnoDataGridViewTextBoxColumn.DataPropertyName = "contact_no"
        Me.ContactnoDataGridViewTextBoxColumn.HeaderText = "contact no"
        Me.ContactnoDataGridViewTextBoxColumn.Name = "ContactnoDataGridViewTextBoxColumn"
        Me.ContactnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreatedatDataGridViewTextBoxColumn
        '
        Me.CreatedatDataGridViewTextBoxColumn.DataPropertyName = "created_at"
        Me.CreatedatDataGridViewTextBoxColumn.HeaderText = "created at"
        Me.CreatedatDataGridViewTextBoxColumn.Name = "CreatedatDataGridViewTextBoxColumn"
        Me.CreatedatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CoursenameDataGridViewTextBoxColumn
        '
        Me.CoursenameDataGridViewTextBoxColumn.DataPropertyName = "course_name"
        Me.CoursenameDataGridViewTextBoxColumn.HeaderText = "course"
        Me.CoursenameDataGridViewTextBoxColumn.Name = "CoursenameDataGridViewTextBoxColumn"
        Me.CoursenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblstudentprofileBindingSource
        '
        Me.TblstudentprofileBindingSource.DataMember = "tblstudentprofile"
        Me.TblstudentprofileBindingSource.DataSource = Me.ClinicsmsdbDataSet
        '
        'ClinicsmsdbDataSet
        '
        Me.ClinicsmsdbDataSet.DataSetName = "clinicsmsdbDataSet"
        Me.ClinicsmsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TIPNormalcolor
        '
        Me.TIPNormalcolor.AllowLinksHandling = True
        Me.TIPNormalcolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TIPNormalcolor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TIPNormalcolor.ForeColor = System.Drawing.SystemColors.Control
        Me.TIPNormalcolor.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'BTNTrash
        '
        Me.BTNTrash.Animated = True
        Me.BTNTrash.BackColor = System.Drawing.Color.Transparent
        Me.BTNTrash.BorderRadius = 1
        Me.BTNTrash.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNTrash.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNTrash.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNTrash.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNTrash.CheckedState.Parent = Me.BTNTrash
        Me.BTNTrash.CustomImages.Parent = Me.BTNTrash
        Me.BTNTrash.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNTrash.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNTrash.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNTrash.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNTrash.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNTrash.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNTrash.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNTrash.HoverState.Parent = Me.BTNTrash
        Me.BTNTrash.Image = Global.Clinic.My.Resources.Resources.trash_filled
        Me.BTNTrash.Location = New System.Drawing.Point(582, 583)
        Me.BTNTrash.Name = "BTNTrash"
        Me.BTNTrash.ShadowDecoration.Enabled = True
        Me.BTNTrash.ShadowDecoration.Parent = Me.BTNTrash
        Me.BTNTrash.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNTrash.Size = New System.Drawing.Size(174, 45)
        Me.BTNTrash.TabIndex = 25
        Me.BTNTrash.Text = "Trash"
        Me.TIPNormalcolor.SetToolTip(Me.BTNTrash, "Click to show trash")
        '
        'BTNDelete
        '
        Me.BTNDelete.Animated = True
        Me.BTNDelete.BackColor = System.Drawing.Color.Transparent
        Me.BTNDelete.BorderRadius = 1
        Me.BTNDelete.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDelete.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDelete.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDelete.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNDelete.CheckedState.Parent = Me.BTNDelete
        Me.BTNDelete.CustomImages.Parent = Me.BTNDelete
        Me.BTNDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNDelete.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNDelete.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNDelete.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDelete.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDelete.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNDelete.HoverState.Parent = Me.BTNDelete
        Me.BTNDelete.Image = Global.Clinic.My.Resources.Resources.delete_filled
        Me.BTNDelete.Location = New System.Drawing.Point(400, 583)
        Me.BTNDelete.Name = "BTNDelete"
        Me.BTNDelete.ShadowDecoration.Enabled = True
        Me.BTNDelete.ShadowDecoration.Parent = Me.BTNDelete
        Me.BTNDelete.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNDelete.Size = New System.Drawing.Size(174, 45)
        Me.BTNDelete.TabIndex = 26
        Me.BTNDelete.Text = "Delete"
        Me.TIPNormalcolor.SetToolTip(Me.BTNDelete, "Click to delete student")
        '
        'BTNUpdate
        '
        Me.BTNUpdate.Animated = True
        Me.BTNUpdate.BackColor = System.Drawing.Color.Transparent
        Me.BTNUpdate.BorderRadius = 1
        Me.BTNUpdate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNUpdate.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNUpdate.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNUpdate.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNUpdate.CheckedState.Parent = Me.BTNUpdate
        Me.BTNUpdate.CustomImages.Parent = Me.BTNUpdate
        Me.BTNUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNUpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNUpdate.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNUpdate.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNUpdate.HoverState.Parent = Me.BTNUpdate
        Me.BTNUpdate.Image = Global.Clinic.My.Resources.Resources.edit_filled
        Me.BTNUpdate.Location = New System.Drawing.Point(218, 583)
        Me.BTNUpdate.Name = "BTNUpdate"
        Me.BTNUpdate.ShadowDecoration.Enabled = True
        Me.BTNUpdate.ShadowDecoration.Parent = Me.BTNUpdate
        Me.BTNUpdate.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNUpdate.Size = New System.Drawing.Size(174, 45)
        Me.BTNUpdate.TabIndex = 27
        Me.BTNUpdate.Text = "Update"
        Me.TIPNormalcolor.SetToolTip(Me.BTNUpdate, "Click to update student")
        '
        'BTNSearch
        '
        Me.BTNSearch.Animated = True
        Me.BTNSearch.BackColor = System.Drawing.Color.Transparent
        Me.BTNSearch.BorderRadius = 1
        Me.BTNSearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSearch.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSearch.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNSearch.CheckedState.Parent = Me.BTNSearch
        Me.BTNSearch.CustomImages.Parent = Me.BTNSearch
        Me.BTNSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNSearch.ForeColor = System.Drawing.Color.White
        Me.BTNSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSearch.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSearch.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNSearch.HoverState.Parent = Me.BTNSearch
        Me.BTNSearch.Image = CType(resources.GetObject("BTNSearch.Image"), System.Drawing.Image)
        Me.BTNSearch.Location = New System.Drawing.Point(561, 39)
        Me.BTNSearch.Name = "BTNSearch"
        Me.BTNSearch.ShadowDecoration.Enabled = True
        Me.BTNSearch.ShadowDecoration.Parent = Me.BTNSearch
        Me.BTNSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNSearch.Size = New System.Drawing.Size(197, 45)
        Me.BTNSearch.TabIndex = 22
        Me.BTNSearch.Text = "Search"
        Me.TIPNormalcolor.SetToolTip(Me.BTNSearch, "Click to search")
        '
        'BTNAdd
        '
        Me.BTNAdd.Animated = True
        Me.BTNAdd.BackColor = System.Drawing.Color.Transparent
        Me.BTNAdd.BorderRadius = 1
        Me.BTNAdd.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdd.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdd.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdd.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAdd.CheckedState.Parent = Me.BTNAdd
        Me.BTNAdd.CustomImages.Parent = Me.BTNAdd
        Me.BTNAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNAdd.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNAdd.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdd.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdd.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAdd.HoverState.Parent = Me.BTNAdd
        Me.BTNAdd.Image = Global.Clinic.My.Resources.Resources.add_filled
        Me.BTNAdd.Location = New System.Drawing.Point(38, 583)
        Me.BTNAdd.Name = "BTNAdd"
        Me.BTNAdd.ShadowDecoration.Enabled = True
        Me.BTNAdd.ShadowDecoration.Parent = Me.BTNAdd
        Me.BTNAdd.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNAdd.Size = New System.Drawing.Size(174, 45)
        Me.BTNAdd.TabIndex = 28
        Me.BTNAdd.Text = "Add"
        Me.TIPNormalcolor.SetToolTip(Me.BTNAdd, "Click to add student")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Location = New System.Drawing.Point(266, 638)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(281, 19)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Note : Select row then right click to edit data"
        '
        'FRMStudentassistant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 666)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTNTrash)
        Me.Controls.Add(Me.BTNDelete)
        Me.Controls.Add(Me.BTNUpdate)
        Me.Controls.Add(Me.BTNSearch)
        Me.Controls.Add(Me.PNLDisplayselected)
        Me.Controls.Add(Me.BTNAdd)
        Me.Controls.Add(Me.TXTSearch)
        Me.Controls.Add(Me.PNLDatagridview)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMStudentassistant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PNLDisplayselected.ResumeLayout(False)
        Me.PNLDisplayselected.PerformLayout()
        Me.PNLDatagridview.ResumeLayout(False)
        CType(Me.DGVStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstudentprofileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNTrash As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TIPNormalcolor As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents BTNDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TblcourseTableAdapter1 As clinicsmsdbDataSetTableAdapters.tblcourseTableAdapter
    Friend WithEvents TblstudentprofileTableAdapter As clinicsmsdbDataSetTableAdapters.tblstudentprofileTableAdapter
    Friend WithEvents BSStudent As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PNLDisplayselected As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CMBSex As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTMiddlename As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CMBCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTStudentnumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXTSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PNLDatagridview As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DGVStudents As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents StudentnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoursenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblstudentprofileBindingSource As BindingSource
    Friend WithEvents ClinicsmsdbDataSet As clinicsmsdbDataSet
    Friend WithEvents Label3 As Label
End Class
