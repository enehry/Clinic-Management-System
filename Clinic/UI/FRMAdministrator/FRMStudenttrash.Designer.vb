<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMStudenttrash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMStudenttrash))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TIPNormalcolor = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.BTNSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.TXTSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNRestore = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNBack = New Guna.UI2.WinForms.Guna2Button()
        Me.PNLDatagridview = New Guna.UI2.WinForms.Guna2Panel()
        Me.DGVStudentsTrash = New Guna.UI2.WinForms.Guna2DataGridView()
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
        Me.TblstudentprofileTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tblstudentprofileTableAdapter()
        Me.BSStudTrash = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.PNLDatagridview.SuspendLayout()
        CType(Me.DGVStudentsTrash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstudentprofileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TIPNormalcolor
        '
        Me.TIPNormalcolor.AllowLinksHandling = True
        Me.TIPNormalcolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TIPNormalcolor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TIPNormalcolor.ForeColor = System.Drawing.SystemColors.Control
        Me.TIPNormalcolor.MaximumSize = New System.Drawing.Size(0, 0)
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
        Me.BTNSearch.TabIndex = 20
        Me.BTNSearch.Text = "Search"
        Me.TIPNormalcolor.SetToolTip(Me.BTNSearch, "Click to search")
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
        Me.TXTSearch.TabIndex = 19
        Me.TIPNormalcolor.SetToolTip(Me.TXTSearch, "Are you looking for something?")
        '
        'BTNRestore
        '
        Me.BTNRestore.Animated = True
        Me.BTNRestore.BackColor = System.Drawing.Color.Transparent
        Me.BTNRestore.BorderRadius = 1
        Me.BTNRestore.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNRestore.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNRestore.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNRestore.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNRestore.CheckedState.Parent = Me.BTNRestore
        Me.BTNRestore.CustomImages.Parent = Me.BTNRestore
        Me.BTNRestore.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNRestore.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNRestore.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNRestore.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNRestore.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNRestore.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNRestore.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNRestore.HoverState.Parent = Me.BTNRestore
        Me.BTNRestore.Location = New System.Drawing.Point(404, 582)
        Me.BTNRestore.Name = "BTNRestore"
        Me.BTNRestore.ShadowDecoration.Enabled = True
        Me.BTNRestore.ShadowDecoration.Parent = Me.BTNRestore
        Me.BTNRestore.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNRestore.Size = New System.Drawing.Size(174, 45)
        Me.BTNRestore.TabIndex = 17
        Me.BTNRestore.TabStop = False
        Me.BTNRestore.Text = "Restore"
        Me.TIPNormalcolor.SetToolTip(Me.BTNRestore, "Restore selected row")
        '
        'BTNBack
        '
        Me.BTNBack.Animated = True
        Me.BTNBack.BackColor = System.Drawing.Color.Transparent
        Me.BTNBack.BorderRadius = 1
        Me.BTNBack.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNBack.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNBack.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNBack.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNBack.CheckedState.Parent = Me.BTNBack
        Me.BTNBack.CustomImages.Parent = Me.BTNBack
        Me.BTNBack.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNBack.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNBack.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNBack.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNBack.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNBack.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNBack.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNBack.HoverState.Parent = Me.BTNBack
        Me.BTNBack.Location = New System.Drawing.Point(584, 582)
        Me.BTNBack.Name = "BTNBack"
        Me.BTNBack.ShadowDecoration.Enabled = True
        Me.BTNBack.ShadowDecoration.Parent = Me.BTNBack
        Me.BTNBack.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNBack.Size = New System.Drawing.Size(174, 45)
        Me.BTNBack.TabIndex = 18
        Me.BTNBack.TabStop = False
        Me.BTNBack.Text = "Back"
        Me.TIPNormalcolor.SetToolTip(Me.BTNBack, "Back")
        '
        'PNLDatagridview
        '
        Me.PNLDatagridview.Controls.Add(Me.DGVStudentsTrash)
        Me.PNLDatagridview.Location = New System.Drawing.Point(38, 109)
        Me.PNLDatagridview.Name = "PNLDatagridview"
        Me.PNLDatagridview.ShadowDecoration.Enabled = True
        Me.PNLDatagridview.ShadowDecoration.Parent = Me.PNLDatagridview
        Me.PNLDatagridview.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.PNLDatagridview.Size = New System.Drawing.Size(720, 446)
        Me.PNLDatagridview.TabIndex = 16
        '
        'DGVStudentsTrash
        '
        Me.DGVStudentsTrash.AllowUserToAddRows = False
        Me.DGVStudentsTrash.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVStudentsTrash.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVStudentsTrash.AutoGenerateColumns = False
        Me.DGVStudentsTrash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVStudentsTrash.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVStudentsTrash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVStudentsTrash.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVStudentsTrash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVStudentsTrash.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVStudentsTrash.ColumnHeadersHeight = 40
        Me.DGVStudentsTrash.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentnumberDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.MnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactnoDataGridViewTextBoxColumn, Me.CreatedatDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.CoursenameDataGridViewTextBoxColumn})
        Me.DGVStudentsTrash.DataSource = Me.TblstudentprofileBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVStudentsTrash.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVStudentsTrash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVStudentsTrash.EnableHeadersVisualStyles = False
        Me.DGVStudentsTrash.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVStudentsTrash.Location = New System.Drawing.Point(0, 0)
        Me.DGVStudentsTrash.Name = "DGVStudentsTrash"
        Me.DGVStudentsTrash.ReadOnly = True
        Me.DGVStudentsTrash.RowHeadersVisible = False
        Me.DGVStudentsTrash.RowTemplate.Height = 30
        Me.DGVStudentsTrash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVStudentsTrash.Size = New System.Drawing.Size(720, 446)
        Me.DGVStudentsTrash.TabIndex = 2
        Me.DGVStudentsTrash.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        Me.DGVStudentsTrash.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DGVStudentsTrash.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVStudentsTrash.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVStudentsTrash.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVStudentsTrash.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVStudentsTrash.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVStudentsTrash.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVStudentsTrash.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.DGVStudentsTrash.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVStudentsTrash.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVStudentsTrash.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVStudentsTrash.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVStudentsTrash.ThemeStyle.HeaderStyle.Height = 40
        Me.DGVStudentsTrash.ThemeStyle.ReadOnly = True
        Me.DGVStudentsTrash.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVStudentsTrash.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVStudentsTrash.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVStudentsTrash.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVStudentsTrash.ThemeStyle.RowsStyle.Height = 30
        Me.DGVStudentsTrash.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGVStudentsTrash.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'StudentnumberDataGridViewTextBoxColumn
        '
        Me.StudentnumberDataGridViewTextBoxColumn.DataPropertyName = "student_number"
        Me.StudentnumberDataGridViewTextBoxColumn.HeaderText = "student_number"
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
        Me.ContactnoDataGridViewTextBoxColumn.HeaderText = "contact_no"
        Me.ContactnoDataGridViewTextBoxColumn.Name = "ContactnoDataGridViewTextBoxColumn"
        Me.ContactnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreatedatDataGridViewTextBoxColumn
        '
        Me.CreatedatDataGridViewTextBoxColumn.DataPropertyName = "created_at"
        Me.CreatedatDataGridViewTextBoxColumn.HeaderText = "created_at"
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
        Me.CoursenameDataGridViewTextBoxColumn.HeaderText = "course_name"
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
        'TblstudentprofileTableAdapter
        '
        Me.TblstudentprofileTableAdapter.ClearBeforeFill = True
        '
        'BSStudTrash
        '
        Me.BSStudTrash.AllowDragging = False
        Me.BSStudTrash.AllowMultipleViews = True
        Me.BSStudTrash.ClickToClose = True
        Me.BSStudTrash.DoubleClickToClose = True
        Me.BSStudTrash.DurationAfterIdle = 3000
        Me.BSStudTrash.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudTrash.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudTrash.ErrorOptions.ActionBorderRadius = 1
        Me.BSStudTrash.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BSStudTrash.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BSStudTrash.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.BSStudTrash.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.BSStudTrash.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BSStudTrash.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BSStudTrash.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.BSStudTrash.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.BSStudTrash.ErrorOptions.IconLeftMargin = 12
        Me.BSStudTrash.FadeCloseIcon = False
        Me.BSStudTrash.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.BSStudTrash.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudTrash.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudTrash.InformationOptions.ActionBorderRadius = 1
        Me.BSStudTrash.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BSStudTrash.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BSStudTrash.InformationOptions.BackColor = System.Drawing.Color.White
        Me.BSStudTrash.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.BSStudTrash.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudTrash.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BSStudTrash.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.BSStudTrash.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.BSStudTrash.InformationOptions.IconLeftMargin = 12
        Me.BSStudTrash.Margin = 10
        Me.BSStudTrash.MaximumSize = New System.Drawing.Size(0, 0)
        Me.BSStudTrash.MaximumViews = 7
        Me.BSStudTrash.MessageRightMargin = 15
        Me.BSStudTrash.MinimumSize = New System.Drawing.Size(0, 0)
        Me.BSStudTrash.ShowBorders = False
        Me.BSStudTrash.ShowCloseIcon = False
        Me.BSStudTrash.ShowIcon = True
        Me.BSStudTrash.ShowShadows = True
        Me.BSStudTrash.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudTrash.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudTrash.SuccessOptions.ActionBorderRadius = 1
        Me.BSStudTrash.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BSStudTrash.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BSStudTrash.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.BSStudTrash.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.BSStudTrash.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.BSStudTrash.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BSStudTrash.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.BSStudTrash.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.BSStudTrash.SuccessOptions.IconLeftMargin = 12
        Me.BSStudTrash.ViewsMargin = 7
        Me.BSStudTrash.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudTrash.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStudTrash.WarningOptions.ActionBorderRadius = 1
        Me.BSStudTrash.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BSStudTrash.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BSStudTrash.WarningOptions.BackColor = System.Drawing.Color.White
        Me.BSStudTrash.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.BSStudTrash.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BSStudTrash.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BSStudTrash.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.BSStudTrash.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.BSStudTrash.WarningOptions.IconLeftMargin = 12
        Me.BSStudTrash.ZoomCloseIcon = True
        '
        'FRMStudenttrash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 666)
        Me.Controls.Add(Me.BTNSearch)
        Me.Controls.Add(Me.TXTSearch)
        Me.Controls.Add(Me.BTNRestore)
        Me.Controls.Add(Me.BTNBack)
        Me.Controls.Add(Me.PNLDatagridview)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMStudenttrash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PNLDatagridview.ResumeLayout(False)
        CType(Me.DGVStudentsTrash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstudentprofileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TIPNormalcolor As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents BTNSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXTSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNRestore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PNLDatagridview As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DGVStudentsTrash As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ClinicsmsdbDataSet As clinicsmsdbDataSet
    Friend WithEvents TblstudentprofileBindingSource As BindingSource
    Friend WithEvents TblstudentprofileTableAdapter As clinicsmsdbDataSetTableAdapters.tblstudentprofileTableAdapter
    Friend WithEvents StudentnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoursenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BSStudTrash As Bunifu.UI.WinForms.BunifuSnackbar
End Class
