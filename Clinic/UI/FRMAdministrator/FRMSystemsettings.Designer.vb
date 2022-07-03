<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMSystemsettings
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMSystemsettings))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.DGVCollege = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.CollegecodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblcollegeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicsmsdbDataSet = New Clinic.clinicsmsdbDataSet()
        Me.BTNDeleteCollege = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.LBLStudentname = New Guna.UI.WinForms.GunaLabel()
        Me.TXTCollegeName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.DGVCourse = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TblcourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTNDeleteCourse = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNAddCourse = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.TXTCourseName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CBCollegeName = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.TIPNormalcolor = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SBSystemSet = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.TblcollegeTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tblcollegeTableAdapter()
        Me.TblcourseTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tblcourseTableAdapter()
        Me.CoursecodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoursenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegecodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.DGVCollege, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcollegeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.DGVCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.DGVCollege)
        Me.Guna2GroupBox1.Controls.Add(Me.BTNDeleteCollege)
        Me.Guna2GroupBox1.Controls.Add(Me.BTNAdd)
        Me.Guna2GroupBox1.Controls.Add(Me.LBLStudentname)
        Me.Guna2GroupBox1.Controls.Add(Me.TXTCollegeName)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(71, 12)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(654, 277)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "   "
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGVCollege
        '
        Me.DGVCollege.AllowUserToAddRows = False
        Me.DGVCollege.AllowUserToDeleteRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DGVCollege.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.DGVCollege.AutoGenerateColumns = False
        Me.DGVCollege.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCollege.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DGVCollege.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVCollege.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVCollege.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCollege.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.DGVCollege.ColumnHeadersHeight = 40
        Me.DGVCollege.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CollegecodeDataGridViewTextBoxColumn, Me.CollegenameDataGridViewTextBoxColumn})
        Me.DGVCollege.DataSource = Me.TblcollegeBindingSource
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCollege.DefaultCellStyle = DataGridViewCellStyle19
        Me.DGVCollege.EnableHeadersVisualStyles = False
        Me.DGVCollege.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVCollege.Location = New System.Drawing.Point(29, 111)
        Me.DGVCollege.Name = "DGVCollege"
        Me.DGVCollege.ReadOnly = True
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCollege.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.DGVCollege.RowHeadersVisible = False
        Me.DGVCollege.RowTemplate.Height = 30
        Me.DGVCollege.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCollege.Size = New System.Drawing.Size(589, 145)
        Me.DGVCollege.TabIndex = 14
        Me.DGVCollege.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        Me.DGVCollege.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DGVCollege.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVCollege.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVCollege.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVCollege.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVCollege.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DGVCollege.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVCollege.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.DGVCollege.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVCollege.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVCollege.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVCollege.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVCollege.ThemeStyle.HeaderStyle.Height = 40
        Me.DGVCollege.ThemeStyle.ReadOnly = True
        Me.DGVCollege.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVCollege.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVCollege.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVCollege.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVCollege.ThemeStyle.RowsStyle.Height = 30
        Me.DGVCollege.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGVCollege.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'CollegecodeDataGridViewTextBoxColumn
        '
        Me.CollegecodeDataGridViewTextBoxColumn.DataPropertyName = "college_code"
        Me.CollegecodeDataGridViewTextBoxColumn.FillWeight = 40.0!
        Me.CollegecodeDataGridViewTextBoxColumn.HeaderText = "College Code"
        Me.CollegecodeDataGridViewTextBoxColumn.Name = "CollegecodeDataGridViewTextBoxColumn"
        Me.CollegecodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CollegenameDataGridViewTextBoxColumn
        '
        Me.CollegenameDataGridViewTextBoxColumn.DataPropertyName = "college_name"
        Me.CollegenameDataGridViewTextBoxColumn.HeaderText = "College Name"
        Me.CollegenameDataGridViewTextBoxColumn.Name = "CollegenameDataGridViewTextBoxColumn"
        Me.CollegenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblcollegeBindingSource
        '
        Me.TblcollegeBindingSource.DataMember = "tblcollege"
        Me.TblcollegeBindingSource.DataSource = Me.ClinicsmsdbDataSet
        '
        'ClinicsmsdbDataSet
        '
        Me.ClinicsmsdbDataSet.DataSetName = "clinicsmsdbDataSet"
        Me.ClinicsmsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTNDeleteCollege
        '
        Me.BTNDeleteCollege.Animated = True
        Me.BTNDeleteCollege.BackColor = System.Drawing.Color.Transparent
        Me.BTNDeleteCollege.BorderRadius = 1
        Me.BTNDeleteCollege.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDeleteCollege.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDeleteCollege.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDeleteCollege.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNDeleteCollege.CheckedState.Parent = Me.BTNDeleteCollege
        Me.BTNDeleteCollege.CustomImages.Parent = Me.BTNDeleteCollege
        Me.BTNDeleteCollege.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BTNDeleteCollege.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNDeleteCollege.ForeColor = System.Drawing.Color.White
        Me.BTNDeleteCollege.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDeleteCollege.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDeleteCollege.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDeleteCollege.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNDeleteCollege.HoverState.Parent = Me.BTNDeleteCollege
        Me.BTNDeleteCollege.Image = Global.Clinic.My.Resources.Resources.delete_filled
        Me.BTNDeleteCollege.Location = New System.Drawing.Point(535, 53)
        Me.BTNDeleteCollege.Name = "BTNDeleteCollege"
        Me.BTNDeleteCollege.ShadowDecoration.Enabled = True
        Me.BTNDeleteCollege.ShadowDecoration.Parent = Me.BTNDeleteCollege
        Me.BTNDeleteCollege.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNDeleteCollege.Size = New System.Drawing.Size(83, 36)
        Me.BTNDeleteCollege.TabIndex = 13
        Me.BTNDeleteCollege.Text = "Delete"
        Me.TIPNormalcolor.SetToolTip(Me.BTNDeleteCollege, "Click to add account")
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
        Me.BTNAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BTNAdd.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNAdd.ForeColor = System.Drawing.Color.White
        Me.BTNAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdd.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdd.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAdd.HoverState.Parent = Me.BTNAdd
        Me.BTNAdd.Image = Global.Clinic.My.Resources.Resources.add_filled
        Me.BTNAdd.Location = New System.Drawing.Point(431, 53)
        Me.BTNAdd.Name = "BTNAdd"
        Me.BTNAdd.ShadowDecoration.Enabled = True
        Me.BTNAdd.ShadowDecoration.Parent = Me.BTNAdd
        Me.BTNAdd.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNAdd.Size = New System.Drawing.Size(83, 36)
        Me.BTNAdd.TabIndex = 12
        Me.BTNAdd.Text = "Add"
        Me.TIPNormalcolor.SetToolTip(Me.BTNAdd, "Click to add account")
        '
        'LBLStudentname
        '
        Me.LBLStudentname.AutoSize = True
        Me.LBLStudentname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LBLStudentname.Location = New System.Drawing.Point(32, 61)
        Me.LBLStudentname.Name = "LBLStudentname"
        Me.LBLStudentname.Size = New System.Drawing.Size(92, 19)
        Me.LBLStudentname.TabIndex = 11
        Me.LBLStudentname.Text = "College name"
        Me.LBLStudentname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTCollegeName
        '
        Me.TXTCollegeName.Animated = True
        Me.TXTCollegeName.BorderRadius = 1
        Me.TXTCollegeName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTCollegeName.DefaultText = ""
        Me.TXTCollegeName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTCollegeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTCollegeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCollegeName.DisabledState.Parent = Me.TXTCollegeName
        Me.TXTCollegeName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCollegeName.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TXTCollegeName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTCollegeName.FocusedState.Parent = Me.TXTCollegeName
        Me.TXTCollegeName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTCollegeName.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTCollegeName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTCollegeName.HoverState.Parent = Me.TXTCollegeName
        Me.TXTCollegeName.Location = New System.Drawing.Point(140, 53)
        Me.TXTCollegeName.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TXTCollegeName.Name = "TXTCollegeName"
        Me.TXTCollegeName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTCollegeName.PlaceholderText = ""
        Me.TXTCollegeName.SelectedText = ""
        Me.TXTCollegeName.ShadowDecoration.Parent = Me.TXTCollegeName
        Me.TXTCollegeName.Size = New System.Drawing.Size(273, 36)
        Me.TXTCollegeName.TabIndex = 2
        Me.TIPNormalcolor.SetToolTip(Me.TXTCollegeName, "College name")
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2GroupBox2.Controls.Add(Me.DGVCourse)
        Me.Guna2GroupBox2.Controls.Add(Me.BTNDeleteCourse)
        Me.Guna2GroupBox2.Controls.Add(Me.BTNAddCourse)
        Me.Guna2GroupBox2.Controls.Add(Me.GunaLabel3)
        Me.Guna2GroupBox2.Controls.Add(Me.TXTCourseName)
        Me.Guna2GroupBox2.Controls.Add(Me.CBCollegeName)
        Me.Guna2GroupBox2.Controls.Add(Me.GunaLabel2)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(71, 309)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(654, 310)
        Me.Guna2GroupBox2.TabIndex = 3
        Me.Guna2GroupBox2.Text = "Course"
        Me.Guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGVCourse
        '
        Me.DGVCourse.AllowUserToAddRows = False
        Me.DGVCourse.AllowUserToDeleteRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DGVCourse.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.DGVCourse.AutoGenerateColumns = False
        Me.DGVCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCourse.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DGVCourse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVCourse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVCourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCourse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.DGVCourse.ColumnHeadersHeight = 40
        Me.DGVCourse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CoursecodeDataGridViewTextBoxColumn, Me.CoursenameDataGridViewTextBoxColumn, Me.CollegecodeDataGridViewTextBoxColumn1})
        Me.DGVCourse.DataSource = Me.TblcourseBindingSource
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCourse.DefaultCellStyle = DataGridViewCellStyle23
        Me.DGVCourse.EnableHeadersVisualStyles = False
        Me.DGVCourse.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVCourse.Location = New System.Drawing.Point(27, 148)
        Me.DGVCourse.Name = "DGVCourse"
        Me.DGVCourse.ReadOnly = True
        Me.DGVCourse.RowHeadersVisible = False
        Me.DGVCourse.RowTemplate.Height = 30
        Me.DGVCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCourse.Size = New System.Drawing.Size(591, 141)
        Me.DGVCourse.TabIndex = 16
        Me.DGVCourse.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        Me.DGVCourse.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DGVCourse.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVCourse.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVCourse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVCourse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVCourse.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DGVCourse.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVCourse.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.DGVCourse.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVCourse.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVCourse.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVCourse.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVCourse.ThemeStyle.HeaderStyle.Height = 40
        Me.DGVCourse.ThemeStyle.ReadOnly = True
        Me.DGVCourse.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVCourse.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVCourse.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVCourse.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVCourse.ThemeStyle.RowsStyle.Height = 30
        Me.DGVCourse.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGVCourse.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'TblcourseBindingSource
        '
        Me.TblcourseBindingSource.DataMember = "tblcourse"
        Me.TblcourseBindingSource.DataSource = Me.ClinicsmsdbDataSet
        '
        'BTNDeleteCourse
        '
        Me.BTNDeleteCourse.Animated = True
        Me.BTNDeleteCourse.BackColor = System.Drawing.Color.Transparent
        Me.BTNDeleteCourse.BorderRadius = 1
        Me.BTNDeleteCourse.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDeleteCourse.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDeleteCourse.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDeleteCourse.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNDeleteCourse.CheckedState.Parent = Me.BTNDeleteCourse
        Me.BTNDeleteCourse.CustomImages.Parent = Me.BTNDeleteCourse
        Me.BTNDeleteCourse.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BTNDeleteCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNDeleteCourse.ForeColor = System.Drawing.Color.White
        Me.BTNDeleteCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDeleteCourse.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDeleteCourse.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDeleteCourse.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNDeleteCourse.HoverState.Parent = Me.BTNDeleteCourse
        Me.BTNDeleteCourse.Image = Global.Clinic.My.Resources.Resources.delete_filled
        Me.BTNDeleteCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNDeleteCourse.Location = New System.Drawing.Point(431, 94)
        Me.BTNDeleteCourse.Name = "BTNDeleteCourse"
        Me.BTNDeleteCourse.ShadowDecoration.Enabled = True
        Me.BTNDeleteCourse.ShadowDecoration.Parent = Me.BTNDeleteCourse
        Me.BTNDeleteCourse.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNDeleteCourse.Size = New System.Drawing.Size(187, 36)
        Me.BTNDeleteCourse.TabIndex = 15
        Me.BTNDeleteCourse.Text = "Delete"
        Me.TIPNormalcolor.SetToolTip(Me.BTNDeleteCourse, "Click to add account")
        '
        'BTNAddCourse
        '
        Me.BTNAddCourse.Animated = True
        Me.BTNAddCourse.BackColor = System.Drawing.Color.Transparent
        Me.BTNAddCourse.BorderRadius = 1
        Me.BTNAddCourse.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddCourse.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddCourse.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddCourse.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAddCourse.CheckedState.Parent = Me.BTNAddCourse
        Me.BTNAddCourse.CustomImages.Parent = Me.BTNAddCourse
        Me.BTNAddCourse.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BTNAddCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNAddCourse.ForeColor = System.Drawing.Color.White
        Me.BTNAddCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddCourse.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddCourse.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAddCourse.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAddCourse.HoverState.Parent = Me.BTNAddCourse
        Me.BTNAddCourse.Image = Global.Clinic.My.Resources.Resources.add_filled
        Me.BTNAddCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNAddCourse.Location = New System.Drawing.Point(431, 49)
        Me.BTNAddCourse.Name = "BTNAddCourse"
        Me.BTNAddCourse.ShadowDecoration.Enabled = True
        Me.BTNAddCourse.ShadowDecoration.Parent = Me.BTNAddCourse
        Me.BTNAddCourse.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNAddCourse.Size = New System.Drawing.Size(187, 36)
        Me.BTNAddCourse.TabIndex = 14
        Me.BTNAddCourse.Text = "Add"
        Me.TIPNormalcolor.SetToolTip(Me.BTNAddCourse, "Click to add account")
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(31, 102)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(90, 19)
        Me.GunaLabel3.TabIndex = 13
        Me.GunaLabel3.Text = "Course name"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTCourseName
        '
        Me.TXTCourseName.Animated = True
        Me.TXTCourseName.BorderRadius = 1
        Me.TXTCourseName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTCourseName.DefaultText = ""
        Me.TXTCourseName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTCourseName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTCourseName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCourseName.DisabledState.Parent = Me.TXTCourseName
        Me.TXTCourseName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCourseName.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TXTCourseName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTCourseName.FocusedState.Parent = Me.TXTCourseName
        Me.TXTCourseName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTCourseName.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTCourseName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTCourseName.HoverState.Parent = Me.TXTCourseName
        Me.TXTCourseName.Location = New System.Drawing.Point(140, 94)
        Me.TXTCourseName.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TXTCourseName.Name = "TXTCourseName"
        Me.TXTCourseName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTCourseName.PlaceholderText = ""
        Me.TXTCourseName.SelectedText = ""
        Me.TXTCourseName.ShadowDecoration.Parent = Me.TXTCourseName
        Me.TXTCourseName.Size = New System.Drawing.Size(259, 36)
        Me.TXTCourseName.TabIndex = 6
        Me.TIPNormalcolor.SetToolTip(Me.TXTCourseName, "Course name")
        '
        'CBCollegeName
        '
        Me.CBCollegeName.Animated = True
        Me.CBCollegeName.BackColor = System.Drawing.Color.Transparent
        Me.CBCollegeName.BorderRadius = 1
        Me.CBCollegeName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBCollegeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCollegeName.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.CBCollegeName.FocusedColor = System.Drawing.Color.Empty
        Me.CBCollegeName.FocusedState.Parent = Me.CBCollegeName
        Me.CBCollegeName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBCollegeName.ForeColor = System.Drawing.SystemColors.Control
        Me.CBCollegeName.FormattingEnabled = True
        Me.CBCollegeName.HoverState.Parent = Me.CBCollegeName
        Me.CBCollegeName.ItemHeight = 30
        Me.CBCollegeName.ItemsAppearance.Parent = Me.CBCollegeName
        Me.CBCollegeName.Location = New System.Drawing.Point(140, 49)
        Me.CBCollegeName.Name = "CBCollegeName"
        Me.CBCollegeName.ShadowDecoration.Parent = Me.CBCollegeName
        Me.CBCollegeName.Size = New System.Drawing.Size(259, 36)
        Me.CBCollegeName.TabIndex = 5
        Me.TIPNormalcolor.SetToolTip(Me.CBCollegeName, "College code")
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(31, 57)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(94, 19)
        Me.GunaLabel2.TabIndex = 9
        Me.GunaLabel2.Text = "College Name"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TIPNormalcolor
        '
        Me.TIPNormalcolor.AllowLinksHandling = True
        Me.TIPNormalcolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TIPNormalcolor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TIPNormalcolor.ForeColor = System.Drawing.SystemColors.Control
        Me.TIPNormalcolor.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 20.0!
        Me.DataGridViewImageColumn1.HeaderText = "Update"
        Me.DataGridViewImageColumn1.Image = Global.Clinic.My.Resources.Resources.trash
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 66
        '
        'DataGridViewImageColumn2
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.NullValue = CType(resources.GetObject("DataGridViewCellStyle24.NullValue"), Object)
        DataGridViewCellStyle24.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewImageColumn2.FillWeight = 20.0!
        Me.DataGridViewImageColumn2.HeaderText = "Update"
        Me.DataGridViewImageColumn2.Image = Global.Clinic.My.Resources.Resources.pencil
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 45
        '
        'SBSystemSet
        '
        Me.SBSystemSet.AllowDragging = False
        Me.SBSystemSet.AllowMultipleViews = True
        Me.SBSystemSet.ClickToClose = True
        Me.SBSystemSet.DoubleClickToClose = True
        Me.SBSystemSet.DurationAfterIdle = 3000
        Me.SBSystemSet.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBSystemSet.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBSystemSet.ErrorOptions.ActionBorderRadius = 1
        Me.SBSystemSet.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBSystemSet.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBSystemSet.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.SBSystemSet.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.SBSystemSet.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.SBSystemSet.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBSystemSet.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.SBSystemSet.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.SBSystemSet.ErrorOptions.IconLeftMargin = 12
        Me.SBSystemSet.FadeCloseIcon = False
        Me.SBSystemSet.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.SBSystemSet.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBSystemSet.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBSystemSet.InformationOptions.ActionBorderRadius = 1
        Me.SBSystemSet.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBSystemSet.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBSystemSet.InformationOptions.BackColor = System.Drawing.Color.White
        Me.SBSystemSet.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.SBSystemSet.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBSystemSet.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBSystemSet.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.SBSystemSet.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.SBSystemSet.InformationOptions.IconLeftMargin = 12
        Me.SBSystemSet.Margin = 10
        Me.SBSystemSet.MaximumSize = New System.Drawing.Size(0, 0)
        Me.SBSystemSet.MaximumViews = 7
        Me.SBSystemSet.MessageRightMargin = 15
        Me.SBSystemSet.MinimumSize = New System.Drawing.Size(0, 0)
        Me.SBSystemSet.ShowBorders = False
        Me.SBSystemSet.ShowCloseIcon = False
        Me.SBSystemSet.ShowIcon = True
        Me.SBSystemSet.ShowShadows = True
        Me.SBSystemSet.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBSystemSet.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBSystemSet.SuccessOptions.ActionBorderRadius = 1
        Me.SBSystemSet.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBSystemSet.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBSystemSet.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.SBSystemSet.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.SBSystemSet.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SBSystemSet.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBSystemSet.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.SBSystemSet.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.SBSystemSet.SuccessOptions.IconLeftMargin = 12
        Me.SBSystemSet.ViewsMargin = 7
        Me.SBSystemSet.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBSystemSet.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBSystemSet.WarningOptions.ActionBorderRadius = 1
        Me.SBSystemSet.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBSystemSet.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBSystemSet.WarningOptions.BackColor = System.Drawing.Color.White
        Me.SBSystemSet.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.SBSystemSet.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.SBSystemSet.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBSystemSet.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.SBSystemSet.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.SBSystemSet.WarningOptions.IconLeftMargin = 12
        Me.SBSystemSet.ZoomCloseIcon = True
        '
        'TblcollegeTableAdapter
        '
        Me.TblcollegeTableAdapter.ClearBeforeFill = True
        '
        'TblcourseTableAdapter
        '
        Me.TblcourseTableAdapter.ClearBeforeFill = True
        '
        'CoursecodeDataGridViewTextBoxColumn
        '
        Me.CoursecodeDataGridViewTextBoxColumn.DataPropertyName = "course_code"
        Me.CoursecodeDataGridViewTextBoxColumn.HeaderText = "course_code"
        Me.CoursecodeDataGridViewTextBoxColumn.Name = "CoursecodeDataGridViewTextBoxColumn"
        Me.CoursecodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CoursenameDataGridViewTextBoxColumn
        '
        Me.CoursenameDataGridViewTextBoxColumn.DataPropertyName = "course_name"
        Me.CoursenameDataGridViewTextBoxColumn.HeaderText = "course name"
        Me.CoursenameDataGridViewTextBoxColumn.Name = "CoursenameDataGridViewTextBoxColumn"
        Me.CoursenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CollegecodeDataGridViewTextBoxColumn1
        '
        Me.CollegecodeDataGridViewTextBoxColumn1.DataPropertyName = "college_code"
        Me.CollegecodeDataGridViewTextBoxColumn1.HeaderText = "college code"
        Me.CollegecodeDataGridViewTextBoxColumn1.Name = "CollegecodeDataGridViewTextBoxColumn1"
        Me.CollegecodeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(285, 636)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "NOTE : Select row the right click to edit data"
        '
        'FRMSystemsettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 666)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMSystemsettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.DGVCollege, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcollegeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        CType(Me.DGVCourse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents LBLStudentname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXTCollegeName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXTCourseName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CBCollegeName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TIPNormalcolor As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents BTNDeleteCollege As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNDeleteCourse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNAddCourse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGVCollege As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DGVCourse As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ClinicsmsdbDataSet As clinicsmsdbDataSet
    Friend WithEvents TblcollegeBindingSource As BindingSource
    Friend WithEvents TblcollegeTableAdapter As clinicsmsdbDataSetTableAdapters.tblcollegeTableAdapter
    Friend WithEvents TblcourseBindingSource As BindingSource
    Friend WithEvents TblcourseTableAdapter As clinicsmsdbDataSetTableAdapters.tblcourseTableAdapter
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents CollegecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CollegenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SBSystemSet As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents CoursecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoursenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CollegecodeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
