<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMManageuseraccount
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMManageuseraccount))
        Me.DGVManageuseraccount = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsertypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreateatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdatedatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbluserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicsmsdbDataSet = New Clinic.clinicsmsdbDataSet()
        Me.TXTSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PNLDatagridview = New Guna.UI2.WinForms.Guna2Panel()
        Me.PNLDisplayselected = New Guna.UI2.WinForms.Guna2Panel()
        Me.TXTRepass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CMBUsertype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXTUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TIPNormalcolor = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.BTNTrash = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.SBCreateUser = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.TbluserTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tbluserTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGVManageuseraccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNLDatagridview.SuspendLayout()
        Me.PNLDisplayselected.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVManageuseraccount
        '
        Me.DGVManageuseraccount.AllowUserToAddRows = False
        Me.DGVManageuseraccount.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVManageuseraccount.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVManageuseraccount.AutoGenerateColumns = False
        Me.DGVManageuseraccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVManageuseraccount.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVManageuseraccount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVManageuseraccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVManageuseraccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVManageuseraccount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVManageuseraccount.ColumnHeadersHeight = 40
        Me.DGVManageuseraccount.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.LoginnameDataGridViewTextBoxColumn, Me.UsertypeDataGridViewTextBoxColumn, Me.CreateatDataGridViewTextBoxColumn, Me.UpdatedatDataGridViewTextBoxColumn})
        Me.DGVManageuseraccount.DataSource = Me.TbluserBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVManageuseraccount.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGVManageuseraccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVManageuseraccount.EnableHeadersVisualStyles = False
        Me.DGVManageuseraccount.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVManageuseraccount.Location = New System.Drawing.Point(0, 0)
        Me.DGVManageuseraccount.Name = "DGVManageuseraccount"
        Me.DGVManageuseraccount.ReadOnly = True
        Me.DGVManageuseraccount.RowHeadersVisible = False
        Me.DGVManageuseraccount.RowTemplate.Height = 30
        Me.DGVManageuseraccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVManageuseraccount.Size = New System.Drawing.Size(720, 248)
        Me.DGVManageuseraccount.TabIndex = 0
        Me.DGVManageuseraccount.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        Me.DGVManageuseraccount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DGVManageuseraccount.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVManageuseraccount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVManageuseraccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVManageuseraccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVManageuseraccount.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVManageuseraccount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVManageuseraccount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.DGVManageuseraccount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVManageuseraccount.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVManageuseraccount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVManageuseraccount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVManageuseraccount.ThemeStyle.HeaderStyle.Height = 40
        Me.DGVManageuseraccount.ThemeStyle.ReadOnly = True
        Me.DGVManageuseraccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVManageuseraccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVManageuseraccount.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVManageuseraccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVManageuseraccount.ThemeStyle.RowsStyle.Height = 30
        Me.DGVManageuseraccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGVManageuseraccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.FillWeight = 30.0!
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
        Me.CreateatDataGridViewTextBoxColumn.HeaderText = "created at"
        Me.CreateatDataGridViewTextBoxColumn.Name = "CreateatDataGridViewTextBoxColumn"
        Me.CreateatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UpdatedatDataGridViewTextBoxColumn
        '
        Me.UpdatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at"
        Me.UpdatedatDataGridViewTextBoxColumn.HeaderText = "updated at"
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
        Me.TXTSearch.TabIndex = 1
        Me.TIPNormalcolor.SetToolTip(Me.TXTSearch, "Are you looking for something?")
        '
        'PNLDatagridview
        '
        Me.PNLDatagridview.Controls.Add(Me.DGVManageuseraccount)
        Me.PNLDatagridview.Location = New System.Drawing.Point(38, 107)
        Me.PNLDatagridview.Name = "PNLDatagridview"
        Me.PNLDatagridview.ShadowDecoration.Enabled = True
        Me.PNLDatagridview.ShadowDecoration.Parent = Me.PNLDatagridview
        Me.PNLDatagridview.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.PNLDatagridview.Size = New System.Drawing.Size(720, 248)
        Me.PNLDatagridview.TabIndex = 6
        '
        'PNLDisplayselected
        '
        Me.PNLDisplayselected.Controls.Add(Me.TXTRepass)
        Me.PNLDisplayselected.Controls.Add(Me.TXTPassword)
        Me.PNLDisplayselected.Controls.Add(Me.CMBUsertype)
        Me.PNLDisplayselected.Controls.Add(Me.TXTUsername)
        Me.PNLDisplayselected.Controls.Add(Me.TXTName)
        Me.PNLDisplayselected.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PNLDisplayselected.Location = New System.Drawing.Point(38, 377)
        Me.PNLDisplayselected.Name = "PNLDisplayselected"
        Me.PNLDisplayselected.ShadowDecoration.Enabled = True
        Me.PNLDisplayselected.ShadowDecoration.Parent = Me.PNLDisplayselected
        Me.PNLDisplayselected.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.PNLDisplayselected.Size = New System.Drawing.Size(500, 277)
        Me.PNLDisplayselected.TabIndex = 7
        '
        'TXTRepass
        '
        Me.TXTRepass.Animated = True
        Me.TXTRepass.BackColor = System.Drawing.Color.Transparent
        Me.TXTRepass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTRepass.BorderRadius = 1
        Me.TXTRepass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTRepass.DefaultText = ""
        Me.TXTRepass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTRepass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTRepass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTRepass.DisabledState.Parent = Me.TXTRepass
        Me.TXTRepass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTRepass.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTRepass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTRepass.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTRepass.FocusedState.Parent = Me.TXTRepass
        Me.TXTRepass.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTRepass.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTRepass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTRepass.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTRepass.HoverState.Parent = Me.TXTRepass
        Me.TXTRepass.Location = New System.Drawing.Point(32, 167)
        Me.TXTRepass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTRepass.Name = "TXTRepass"
        Me.TXTRepass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTRepass.PlaceholderText = "Retype Password"
        Me.TXTRepass.SelectedText = ""
        Me.TXTRepass.ShadowDecoration.Enabled = True
        Me.TXTRepass.ShadowDecoration.Parent = Me.TXTRepass
        Me.TXTRepass.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTRepass.Size = New System.Drawing.Size(435, 41)
        Me.TXTRepass.TabIndex = 3
        Me.TIPNormalcolor.SetToolTip(Me.TXTRepass, "Password")
        '
        'TXTPassword
        '
        Me.TXTPassword.Animated = True
        Me.TXTPassword.BackColor = System.Drawing.Color.Transparent
        Me.TXTPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTPassword.BorderRadius = 1
        Me.TXTPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTPassword.DefaultText = ""
        Me.TXTPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTPassword.DisabledState.Parent = Me.TXTPassword
        Me.TXTPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTPassword.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTPassword.FocusedState.Parent = Me.TXTPassword
        Me.TXTPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTPassword.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTPassword.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTPassword.HoverState.Parent = Me.TXTPassword
        Me.TXTPassword.Location = New System.Drawing.Point(32, 117)
        Me.TXTPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTPassword.Name = "TXTPassword"
        Me.TXTPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPassword.PlaceholderText = "Password"
        Me.TXTPassword.SelectedText = ""
        Me.TXTPassword.ShadowDecoration.Enabled = True
        Me.TXTPassword.ShadowDecoration.Parent = Me.TXTPassword
        Me.TXTPassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTPassword.Size = New System.Drawing.Size(435, 41)
        Me.TXTPassword.TabIndex = 2
        Me.TIPNormalcolor.SetToolTip(Me.TXTPassword, "Password")
        '
        'CMBUsertype
        '
        Me.CMBUsertype.BackColor = System.Drawing.Color.Transparent
        Me.CMBUsertype.BorderRadius = 1
        Me.CMBUsertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBUsertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBUsertype.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CMBUsertype.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CMBUsertype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CMBUsertype.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.CMBUsertype.FocusedState.Parent = Me.CMBUsertype
        Me.CMBUsertype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CMBUsertype.ForeColor = System.Drawing.SystemColors.Control
        Me.CMBUsertype.FormattingEnabled = True
        Me.CMBUsertype.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CMBUsertype.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.CMBUsertype.HoverState.Parent = Me.CMBUsertype
        Me.CMBUsertype.ItemHeight = 30
        Me.CMBUsertype.Items.AddRange(New Object() {"nurse", "assistant"})
        Me.CMBUsertype.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CMBUsertype.ItemsAppearance.ForeColor = System.Drawing.SystemColors.Control
        Me.CMBUsertype.ItemsAppearance.Parent = Me.CMBUsertype
        Me.CMBUsertype.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CMBUsertype.ItemsAppearance.SelectedForeColor = System.Drawing.SystemColors.Control
        Me.CMBUsertype.Location = New System.Drawing.Point(32, 217)
        Me.CMBUsertype.Name = "CMBUsertype"
        Me.CMBUsertype.ShadowDecoration.Enabled = True
        Me.CMBUsertype.ShadowDecoration.Parent = Me.CMBUsertype
        Me.CMBUsertype.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.CMBUsertype.Size = New System.Drawing.Size(435, 36)
        Me.CMBUsertype.TabIndex = 1
        Me.TIPNormalcolor.SetToolTip(Me.CMBUsertype, "Usertype")
        '
        'TXTUsername
        '
        Me.TXTUsername.Animated = True
        Me.TXTUsername.BackColor = System.Drawing.Color.Transparent
        Me.TXTUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTUsername.BorderRadius = 1
        Me.TXTUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTUsername.DefaultText = ""
        Me.TXTUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTUsername.DisabledState.Parent = Me.TXTUsername
        Me.TXTUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTUsername.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTUsername.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTUsername.FocusedState.Parent = Me.TXTUsername
        Me.TXTUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTUsername.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTUsername.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTUsername.HoverState.Parent = Me.TXTUsername
        Me.TXTUsername.Location = New System.Drawing.Point(32, 67)
        Me.TXTUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTUsername.Name = "TXTUsername"
        Me.TXTUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTUsername.PlaceholderText = "Username"
        Me.TXTUsername.SelectedText = ""
        Me.TXTUsername.ShadowDecoration.Enabled = True
        Me.TXTUsername.ShadowDecoration.Parent = Me.TXTUsername
        Me.TXTUsername.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTUsername.Size = New System.Drawing.Size(435, 41)
        Me.TXTUsername.TabIndex = 2
        Me.TIPNormalcolor.SetToolTip(Me.TXTUsername, "Username")
        '
        'TXTName
        '
        Me.TXTName.Animated = True
        Me.TXTName.BackColor = System.Drawing.Color.Transparent
        Me.TXTName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTName.BorderRadius = 1
        Me.TXTName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTName.DefaultText = ""
        Me.TXTName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTName.DisabledState.Parent = Me.TXTName
        Me.TXTName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTName.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTName.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTName.FocusedState.Parent = Me.TXTName
        Me.TXTName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTName.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTName.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTName.HoverState.Parent = Me.TXTName
        Me.TXTName.Location = New System.Drawing.Point(32, 17)
        Me.TXTName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTName.Name = "TXTName"
        Me.TXTName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTName.PlaceholderText = "Name"
        Me.TXTName.SelectedText = ""
        Me.TXTName.ShadowDecoration.Enabled = True
        Me.TXTName.ShadowDecoration.Parent = Me.TXTName
        Me.TXTName.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTName.Size = New System.Drawing.Size(435, 41)
        Me.TXTName.TabIndex = 2
        Me.TIPNormalcolor.SetToolTip(Me.TXTName, "Name")
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
        Me.BTNTrash.ForeColor = System.Drawing.Color.White
        Me.BTNTrash.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNTrash.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNTrash.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNTrash.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNTrash.HoverState.Parent = Me.BTNTrash
        Me.BTNTrash.Image = Global.Clinic.My.Resources.Resources.trash_filled
        Me.BTNTrash.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNTrash.Location = New System.Drawing.Point(561, 539)
        Me.BTNTrash.Name = "BTNTrash"
        Me.BTNTrash.ShadowDecoration.Enabled = True
        Me.BTNTrash.ShadowDecoration.Parent = Me.BTNTrash
        Me.BTNTrash.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNTrash.Size = New System.Drawing.Size(197, 45)
        Me.BTNTrash.TabIndex = 8
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
        Me.BTNDelete.ForeColor = System.Drawing.Color.White
        Me.BTNDelete.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDelete.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNDelete.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNDelete.HoverState.Parent = Me.BTNDelete
        Me.BTNDelete.Image = Global.Clinic.My.Resources.Resources.deleteaccount_filled
        Me.BTNDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNDelete.Location = New System.Drawing.Point(561, 486)
        Me.BTNDelete.Name = "BTNDelete"
        Me.BTNDelete.ShadowDecoration.Enabled = True
        Me.BTNDelete.ShadowDecoration.Parent = Me.BTNDelete
        Me.BTNDelete.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNDelete.Size = New System.Drawing.Size(197, 45)
        Me.BTNDelete.TabIndex = 8
        Me.BTNDelete.Text = "Delete"
        Me.TIPNormalcolor.SetToolTip(Me.BTNDelete, "Click to delete account")
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
        Me.BTNUpdate.ForeColor = System.Drawing.Color.White
        Me.BTNUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNUpdate.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNUpdate.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNUpdate.HoverState.Parent = Me.BTNUpdate
        Me.BTNUpdate.Image = Global.Clinic.My.Resources.Resources.editaccount_filled
        Me.BTNUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNUpdate.Location = New System.Drawing.Point(561, 433)
        Me.BTNUpdate.Name = "BTNUpdate"
        Me.BTNUpdate.ShadowDecoration.Enabled = True
        Me.BTNUpdate.ShadowDecoration.Parent = Me.BTNUpdate
        Me.BTNUpdate.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNUpdate.Size = New System.Drawing.Size(197, 45)
        Me.BTNUpdate.TabIndex = 8
        Me.BTNUpdate.Text = "Update"
        Me.TIPNormalcolor.SetToolTip(Me.BTNUpdate, "Click to edit account")
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
        Me.BTNAdd.ForeColor = System.Drawing.Color.White
        Me.BTNAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdd.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdd.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAdd.HoverState.Parent = Me.BTNAdd
        Me.BTNAdd.Image = Global.Clinic.My.Resources.Resources.addaccount_filled
        Me.BTNAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNAdd.Location = New System.Drawing.Point(561, 380)
        Me.BTNAdd.Name = "BTNAdd"
        Me.BTNAdd.ShadowDecoration.Enabled = True
        Me.BTNAdd.ShadowDecoration.Parent = Me.BTNAdd
        Me.BTNAdd.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNAdd.Size = New System.Drawing.Size(197, 45)
        Me.BTNAdd.TabIndex = 8
        Me.BTNAdd.Text = "Add"
        Me.TIPNormalcolor.SetToolTip(Me.BTNAdd, "Click to add account")
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
        Me.BTNSearch.Image = Global.Clinic.My.Resources.Resources.search_hover
        Me.BTNSearch.Location = New System.Drawing.Point(561, 38)
        Me.BTNSearch.Name = "BTNSearch"
        Me.BTNSearch.ShadowDecoration.Enabled = True
        Me.BTNSearch.ShadowDecoration.Parent = Me.BTNSearch
        Me.BTNSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNSearch.Size = New System.Drawing.Size(197, 45)
        Me.BTNSearch.TabIndex = 5
        Me.BTNSearch.Text = "Search"
        Me.TIPNormalcolor.SetToolTip(Me.BTNSearch, "Click to search")
        '
        'SBCreateUser
        '
        Me.SBCreateUser.AllowDragging = False
        Me.SBCreateUser.AllowMultipleViews = True
        Me.SBCreateUser.ClickToClose = True
        Me.SBCreateUser.DoubleClickToClose = True
        Me.SBCreateUser.DurationAfterIdle = 3000
        Me.SBCreateUser.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBCreateUser.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBCreateUser.ErrorOptions.ActionBorderRadius = 1
        Me.SBCreateUser.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBCreateUser.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBCreateUser.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.SBCreateUser.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.SBCreateUser.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.SBCreateUser.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBCreateUser.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.SBCreateUser.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.SBCreateUser.ErrorOptions.IconLeftMargin = 12
        Me.SBCreateUser.FadeCloseIcon = False
        Me.SBCreateUser.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.SBCreateUser.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBCreateUser.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBCreateUser.InformationOptions.ActionBorderRadius = 1
        Me.SBCreateUser.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBCreateUser.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBCreateUser.InformationOptions.BackColor = System.Drawing.Color.White
        Me.SBCreateUser.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.SBCreateUser.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBCreateUser.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBCreateUser.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.SBCreateUser.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.SBCreateUser.InformationOptions.IconLeftMargin = 12
        Me.SBCreateUser.Margin = 10
        Me.SBCreateUser.MaximumSize = New System.Drawing.Size(0, 0)
        Me.SBCreateUser.MaximumViews = 7
        Me.SBCreateUser.MessageRightMargin = 15
        Me.SBCreateUser.MinimumSize = New System.Drawing.Size(0, 0)
        Me.SBCreateUser.ShowBorders = False
        Me.SBCreateUser.ShowCloseIcon = False
        Me.SBCreateUser.ShowIcon = True
        Me.SBCreateUser.ShowShadows = True
        Me.SBCreateUser.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBCreateUser.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBCreateUser.SuccessOptions.ActionBorderRadius = 1
        Me.SBCreateUser.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBCreateUser.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBCreateUser.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.SBCreateUser.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.SBCreateUser.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SBCreateUser.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBCreateUser.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.SBCreateUser.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.SBCreateUser.SuccessOptions.IconLeftMargin = 12
        Me.SBCreateUser.ViewsMargin = 7
        Me.SBCreateUser.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBCreateUser.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBCreateUser.WarningOptions.ActionBorderRadius = 1
        Me.SBCreateUser.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBCreateUser.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBCreateUser.WarningOptions.BackColor = System.Drawing.Color.White
        Me.SBCreateUser.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.SBCreateUser.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.SBCreateUser.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBCreateUser.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.SBCreateUser.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.SBCreateUser.WarningOptions.IconLeftMargin = 12
        Me.SBCreateUser.ZoomCloseIcon = True
        '
        'TbluserTableAdapter
        '
        Me.TbluserTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(563, 602)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 42)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Note : Select row then right click to edit data"
        '
        'FRMManageuseraccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 666)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNTrash)
        Me.Controls.Add(Me.BTNDelete)
        Me.Controls.Add(Me.BTNUpdate)
        Me.Controls.Add(Me.BTNAdd)
        Me.Controls.Add(Me.PNLDisplayselected)
        Me.Controls.Add(Me.PNLDatagridview)
        Me.Controls.Add(Me.BTNSearch)
        Me.Controls.Add(Me.TXTSearch)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMManageuseraccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGVManageuseraccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNLDatagridview.ResumeLayout(False)
        Me.PNLDisplayselected.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVManageuseraccount As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TXTSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PNLDatagridview As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PNLDisplayselected As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TXTPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNTrash As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CMBUsertype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TIPNormalcolor As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents ClinicsmsdbDataSet As clinicsmsdbDataSet
    Friend WithEvents TbluserBindingSource As BindingSource
    Friend WithEvents TbluserTableAdapter As clinicsmsdbDataSetTableAdapters.tbluserTableAdapter
    Friend WithEvents TXTRepass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SBCreateUser As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsertypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreateatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UpdatedatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
