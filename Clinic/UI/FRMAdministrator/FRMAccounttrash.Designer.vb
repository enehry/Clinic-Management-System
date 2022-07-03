<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMAccounttrash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMAccounttrash))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TIPNormalcolor = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.BTNBack = New Guna.UI2.WinForms.Guna2Button()
        Me.TXTSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNRestore = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.PNLDatagridview = New Guna.UI2.WinForms.Guna2Panel()
        Me.DGVUserAccountTrash = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsertypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreateatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdatedatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbluserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicsmsdbDataSet = New Clinic.clinicsmsdbDataSet()
        Me.TbluserTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tbluserTableAdapter()
        Me.SBUserTrash = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.PNLDatagridview.SuspendLayout()
        CType(Me.DGVUserAccountTrash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BTNBack.Location = New System.Drawing.Point(584, 581)
        Me.BTNBack.Name = "BTNBack"
        Me.BTNBack.ShadowDecoration.Enabled = True
        Me.BTNBack.ShadowDecoration.Parent = Me.BTNBack
        Me.BTNBack.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNBack.Size = New System.Drawing.Size(174, 45)
        Me.BTNBack.TabIndex = 13
        Me.BTNBack.TabStop = False
        Me.BTNBack.Text = "Back"
        Me.TIPNormalcolor.SetToolTip(Me.BTNBack, "Back")
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
        Me.TXTSearch.Location = New System.Drawing.Point(38, 38)
        Me.TXTSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTSearch.Name = "TXTSearch"
        Me.TXTSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSearch.PlaceholderText = "Search..."
        Me.TXTSearch.SelectedText = ""
        Me.TXTSearch.ShadowDecoration.Enabled = True
        Me.TXTSearch.ShadowDecoration.Parent = Me.TXTSearch
        Me.TXTSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTSearch.Size = New System.Drawing.Size(500, 45)
        Me.TXTSearch.TabIndex = 14
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
        Me.BTNRestore.Location = New System.Drawing.Point(404, 581)
        Me.BTNRestore.Name = "BTNRestore"
        Me.BTNRestore.ShadowDecoration.Enabled = True
        Me.BTNRestore.ShadowDecoration.Parent = Me.BTNRestore
        Me.BTNRestore.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNRestore.Size = New System.Drawing.Size(174, 45)
        Me.BTNRestore.TabIndex = 13
        Me.BTNRestore.TabStop = False
        Me.BTNRestore.Text = "Restore"
        Me.TIPNormalcolor.SetToolTip(Me.BTNRestore, "Restore selected row")
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
        Me.BTNSearch.Location = New System.Drawing.Point(561, 38)
        Me.BTNSearch.Name = "BTNSearch"
        Me.BTNSearch.ShadowDecoration.Enabled = True
        Me.BTNSearch.ShadowDecoration.Parent = Me.BTNSearch
        Me.BTNSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNSearch.Size = New System.Drawing.Size(197, 45)
        Me.BTNSearch.TabIndex = 15
        Me.BTNSearch.Text = "Search"
        Me.TIPNormalcolor.SetToolTip(Me.BTNSearch, "Click to search")
        '
        'PNLDatagridview
        '
        Me.PNLDatagridview.Controls.Add(Me.DGVUserAccountTrash)
        Me.PNLDatagridview.Location = New System.Drawing.Point(38, 108)
        Me.PNLDatagridview.Name = "PNLDatagridview"
        Me.PNLDatagridview.ShadowDecoration.Enabled = True
        Me.PNLDatagridview.ShadowDecoration.Parent = Me.PNLDatagridview
        Me.PNLDatagridview.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.PNLDatagridview.Size = New System.Drawing.Size(720, 446)
        Me.PNLDatagridview.TabIndex = 11
        '
        'DGVUserAccountTrash
        '
        Me.DGVUserAccountTrash.AllowUserToAddRows = False
        Me.DGVUserAccountTrash.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVUserAccountTrash.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVUserAccountTrash.AutoGenerateColumns = False
        Me.DGVUserAccountTrash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVUserAccountTrash.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVUserAccountTrash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVUserAccountTrash.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVUserAccountTrash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVUserAccountTrash.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVUserAccountTrash.ColumnHeadersHeight = 40
        Me.DGVUserAccountTrash.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.LoginnameDataGridViewTextBoxColumn, Me.UsertypeDataGridViewTextBoxColumn, Me.CreateatDataGridViewTextBoxColumn, Me.UpdatedatDataGridViewTextBoxColumn})
        Me.DGVUserAccountTrash.DataSource = Me.TbluserBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVUserAccountTrash.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVUserAccountTrash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVUserAccountTrash.EnableHeadersVisualStyles = False
        Me.DGVUserAccountTrash.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVUserAccountTrash.Location = New System.Drawing.Point(0, 0)
        Me.DGVUserAccountTrash.Name = "DGVUserAccountTrash"
        Me.DGVUserAccountTrash.ReadOnly = True
        Me.DGVUserAccountTrash.RowHeadersVisible = False
        Me.DGVUserAccountTrash.RowTemplate.Height = 30
        Me.DGVUserAccountTrash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVUserAccountTrash.Size = New System.Drawing.Size(720, 446)
        Me.DGVUserAccountTrash.TabIndex = 1
        Me.DGVUserAccountTrash.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        Me.DGVUserAccountTrash.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DGVUserAccountTrash.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVUserAccountTrash.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVUserAccountTrash.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVUserAccountTrash.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVUserAccountTrash.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVUserAccountTrash.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVUserAccountTrash.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.DGVUserAccountTrash.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVUserAccountTrash.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVUserAccountTrash.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVUserAccountTrash.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVUserAccountTrash.ThemeStyle.HeaderStyle.Height = 40
        Me.DGVUserAccountTrash.ThemeStyle.ReadOnly = True
        Me.DGVUserAccountTrash.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVUserAccountTrash.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVUserAccountTrash.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVUserAccountTrash.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVUserAccountTrash.ThemeStyle.RowsStyle.Height = 30
        Me.DGVUserAccountTrash.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGVUserAccountTrash.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoginnameDataGridViewTextBoxColumn
        '
        Me.LoginnameDataGridViewTextBoxColumn.DataPropertyName = "login_name"
        Me.LoginnameDataGridViewTextBoxColumn.HeaderText = "login_name"
        Me.LoginnameDataGridViewTextBoxColumn.Name = "LoginnameDataGridViewTextBoxColumn"
        Me.LoginnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsertypeDataGridViewTextBoxColumn
        '
        Me.UsertypeDataGridViewTextBoxColumn.DataPropertyName = "usertype"
        Me.UsertypeDataGridViewTextBoxColumn.HeaderText = "usertype"
        Me.UsertypeDataGridViewTextBoxColumn.Name = "UsertypeDataGridViewTextBoxColumn"
        Me.UsertypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreateatDataGridViewTextBoxColumn
        '
        Me.CreateatDataGridViewTextBoxColumn.DataPropertyName = "create_at"
        Me.CreateatDataGridViewTextBoxColumn.HeaderText = "create_at"
        Me.CreateatDataGridViewTextBoxColumn.Name = "CreateatDataGridViewTextBoxColumn"
        Me.CreateatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UpdatedatDataGridViewTextBoxColumn
        '
        Me.UpdatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at"
        Me.UpdatedatDataGridViewTextBoxColumn.HeaderText = "updated_at"
        Me.UpdatedatDataGridViewTextBoxColumn.Name = "UpdatedatDataGridViewTextBoxColumn"
        Me.UpdatedatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbluserBindingSource
        '
        Me.TbluserBindingSource.DataMember = "tbluser"
        Me.TbluserBindingSource.DataSource = Me.ClinicsmsdbDataSet
        '
        'ClinicsmsdbDataSet
        '
        Me.ClinicsmsdbDataSet.DataSetName = "clinicsmsdbDataSet"
        Me.ClinicsmsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbluserTableAdapter
        '
        Me.TbluserTableAdapter.ClearBeforeFill = True
        '
        'SBUserTrash
        '
        Me.SBUserTrash.AllowDragging = False
        Me.SBUserTrash.AllowMultipleViews = True
        Me.SBUserTrash.ClickToClose = True
        Me.SBUserTrash.DoubleClickToClose = True
        Me.SBUserTrash.DurationAfterIdle = 3000
        Me.SBUserTrash.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBUserTrash.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBUserTrash.ErrorOptions.ActionBorderRadius = 1
        Me.SBUserTrash.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBUserTrash.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBUserTrash.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.SBUserTrash.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.SBUserTrash.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.SBUserTrash.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBUserTrash.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.SBUserTrash.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.SBUserTrash.ErrorOptions.IconLeftMargin = 12
        Me.SBUserTrash.FadeCloseIcon = False
        Me.SBUserTrash.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.SBUserTrash.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBUserTrash.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBUserTrash.InformationOptions.ActionBorderRadius = 1
        Me.SBUserTrash.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBUserTrash.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBUserTrash.InformationOptions.BackColor = System.Drawing.Color.White
        Me.SBUserTrash.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.SBUserTrash.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBUserTrash.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBUserTrash.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.SBUserTrash.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.SBUserTrash.InformationOptions.IconLeftMargin = 12
        Me.SBUserTrash.Margin = 10
        Me.SBUserTrash.MaximumSize = New System.Drawing.Size(0, 0)
        Me.SBUserTrash.MaximumViews = 7
        Me.SBUserTrash.MessageRightMargin = 15
        Me.SBUserTrash.MinimumSize = New System.Drawing.Size(0, 0)
        Me.SBUserTrash.ShowBorders = False
        Me.SBUserTrash.ShowCloseIcon = False
        Me.SBUserTrash.ShowIcon = True
        Me.SBUserTrash.ShowShadows = True
        Me.SBUserTrash.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBUserTrash.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBUserTrash.SuccessOptions.ActionBorderRadius = 1
        Me.SBUserTrash.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBUserTrash.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBUserTrash.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.SBUserTrash.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.SBUserTrash.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SBUserTrash.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBUserTrash.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.SBUserTrash.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.SBUserTrash.SuccessOptions.IconLeftMargin = 12
        Me.SBUserTrash.ViewsMargin = 7
        Me.SBUserTrash.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBUserTrash.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBUserTrash.WarningOptions.ActionBorderRadius = 1
        Me.SBUserTrash.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBUserTrash.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBUserTrash.WarningOptions.BackColor = System.Drawing.Color.White
        Me.SBUserTrash.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.SBUserTrash.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.SBUserTrash.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBUserTrash.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.SBUserTrash.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.SBUserTrash.WarningOptions.IconLeftMargin = 12
        Me.SBUserTrash.ZoomCloseIcon = True
        '
        'FRMAccounttrash
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
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMAccounttrash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PNLDatagridview.ResumeLayout(False)
        CType(Me.DGVUserAccountTrash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TIPNormalcolor As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents PNLDatagridview As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNRestore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXTSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DGVUserAccountTrash As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ClinicsmsdbDataSet As clinicsmsdbDataSet
    Friend WithEvents TbluserBindingSource As BindingSource
    Friend WithEvents TbluserTableAdapter As clinicsmsdbDataSetTableAdapters.tbluserTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsertypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreateatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UpdatedatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SBUserTrash As Bunifu.UI.WinForms.BunifuSnackbar
End Class
