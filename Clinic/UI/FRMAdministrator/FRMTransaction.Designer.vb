<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMTransaction
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMTransaction))
        Me.PNLDatagridview = New Guna.UI2.WinForms.Guna2Panel()
        Me.DGVTransaction = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TbltransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicsmsdbDataSet = New Clinic.clinicsmsdbDataSet()
        Me.BTNSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.TXTSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TIPNormalcolor = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.BTNVoid = New Guna.UI2.WinForms.Guna2Button()
        Me.TbltransactionTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tbltransactionTableAdapter()
        Me.TblmedicineTableAdapter1 = New Clinic.clinicsmsdbDataSetTableAdapters.tblmedicineTableAdapter()
        Me.SBTransaction = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicinecodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityreleasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenericnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicinenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoursecodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoursenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNLDatagridview.SuspendLayout()
        CType(Me.DGVTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNLDatagridview
        '
        Me.PNLDatagridview.Controls.Add(Me.DGVTransaction)
        Me.PNLDatagridview.Location = New System.Drawing.Point(38, 107)
        Me.PNLDatagridview.Name = "PNLDatagridview"
        Me.PNLDatagridview.ShadowDecoration.Enabled = True
        Me.PNLDatagridview.ShadowDecoration.Parent = Me.PNLDatagridview
        Me.PNLDatagridview.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.PNLDatagridview.Size = New System.Drawing.Size(720, 485)
        Me.PNLDatagridview.TabIndex = 9
        '
        'DGVTransaction
        '
        Me.DGVTransaction.AllowUserToAddRows = False
        Me.DGVTransaction.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVTransaction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVTransaction.AutoGenerateColumns = False
        Me.DGVTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVTransaction.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVTransaction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVTransaction.ColumnHeadersHeight = 40
        Me.DGVTransaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.StudentnumberDataGridViewTextBoxColumn, Me.MedicinecodeDataGridViewTextBoxColumn, Me.QuantityreleasedDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.GenericnameDataGridViewTextBoxColumn, Me.MedicinenameDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.MnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.CoursecodeDataGridViewTextBoxColumn, Me.CoursenameDataGridViewTextBoxColumn, Me.ContactnoDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn})
        Me.DGVTransaction.DataSource = Me.TbltransactionBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVTransaction.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVTransaction.EnableHeadersVisualStyles = False
        Me.DGVTransaction.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVTransaction.Location = New System.Drawing.Point(0, 0)
        Me.DGVTransaction.Name = "DGVTransaction"
        Me.DGVTransaction.ReadOnly = True
        Me.DGVTransaction.RowHeadersVisible = False
        Me.DGVTransaction.RowTemplate.Height = 30
        Me.DGVTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVTransaction.Size = New System.Drawing.Size(720, 485)
        Me.DGVTransaction.TabIndex = 6
        Me.DGVTransaction.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        Me.DGVTransaction.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DGVTransaction.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVTransaction.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVTransaction.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVTransaction.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVTransaction.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVTransaction.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVTransaction.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.DGVTransaction.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVTransaction.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVTransaction.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVTransaction.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVTransaction.ThemeStyle.HeaderStyle.Height = 40
        Me.DGVTransaction.ThemeStyle.ReadOnly = True
        Me.DGVTransaction.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVTransaction.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVTransaction.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVTransaction.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVTransaction.ThemeStyle.RowsStyle.Height = 30
        Me.DGVTransaction.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGVTransaction.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'TbltransactionBindingSource
        '
        Me.TbltransactionBindingSource.DataMember = "tbltransaction"
        Me.TbltransactionBindingSource.DataSource = Me.ClinicsmsdbDataSet
        '
        'ClinicsmsdbDataSet
        '
        Me.ClinicsmsdbDataSet.DataSetName = "clinicsmsdbDataSet"
        Me.ClinicsmsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BTNSearch.TabIndex = 8
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
        Me.TXTSearch.Location = New System.Drawing.Point(38, 40)
        Me.TXTSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTSearch.Name = "TXTSearch"
        Me.TXTSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSearch.PlaceholderText = "Search..."
        Me.TXTSearch.SelectedText = ""
        Me.TXTSearch.ShadowDecoration.Enabled = True
        Me.TXTSearch.ShadowDecoration.Parent = Me.TXTSearch
        Me.TXTSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTSearch.Size = New System.Drawing.Size(500, 40)
        Me.TXTSearch.TabIndex = 7
        Me.TIPNormalcolor.SetToolTip(Me.TXTSearch, "Are you looking for something?")
        '
        'TIPNormalcolor
        '
        Me.TIPNormalcolor.AllowLinksHandling = True
        Me.TIPNormalcolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TIPNormalcolor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TIPNormalcolor.ForeColor = System.Drawing.SystemColors.Control
        Me.TIPNormalcolor.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'BTNVoid
        '
        Me.BTNVoid.Animated = True
        Me.BTNVoid.BackColor = System.Drawing.Color.Transparent
        Me.BTNVoid.BorderRadius = 1
        Me.BTNVoid.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNVoid.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNVoid.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNVoid.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNVoid.CheckedState.Parent = Me.BTNVoid
        Me.BTNVoid.CustomImages.Parent = Me.BTNVoid
        Me.BTNVoid.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNVoid.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNVoid.ForeColor = System.Drawing.Color.White
        Me.BTNVoid.HoverState.Parent = Me.BTNVoid
        Me.BTNVoid.Location = New System.Drawing.Point(561, 609)
        Me.BTNVoid.Name = "BTNVoid"
        Me.BTNVoid.ShadowDecoration.Enabled = True
        Me.BTNVoid.ShadowDecoration.Parent = Me.BTNVoid
        Me.BTNVoid.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNVoid.Size = New System.Drawing.Size(197, 45)
        Me.BTNVoid.TabIndex = 10
        Me.BTNVoid.TabStop = False
        Me.BTNVoid.Text = "Void"
        Me.TIPNormalcolor.SetToolTip(Me.BTNVoid, "Click to admit")
        '
        'TbltransactionTableAdapter
        '
        Me.TbltransactionTableAdapter.ClearBeforeFill = True
        '
        'TblmedicineTableAdapter1
        '
        Me.TblmedicineTableAdapter1.ClearBeforeFill = True
        '
        'SBTransaction
        '
        Me.SBTransaction.AllowDragging = False
        Me.SBTransaction.AllowMultipleViews = True
        Me.SBTransaction.ClickToClose = True
        Me.SBTransaction.DoubleClickToClose = True
        Me.SBTransaction.DurationAfterIdle = 3000
        Me.SBTransaction.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBTransaction.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBTransaction.ErrorOptions.ActionBorderRadius = 1
        Me.SBTransaction.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBTransaction.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBTransaction.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.SBTransaction.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.SBTransaction.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.SBTransaction.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBTransaction.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.SBTransaction.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.SBTransaction.ErrorOptions.IconLeftMargin = 12
        Me.SBTransaction.FadeCloseIcon = False
        Me.SBTransaction.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.SBTransaction.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBTransaction.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBTransaction.InformationOptions.ActionBorderRadius = 1
        Me.SBTransaction.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBTransaction.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBTransaction.InformationOptions.BackColor = System.Drawing.Color.White
        Me.SBTransaction.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.SBTransaction.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBTransaction.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBTransaction.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.SBTransaction.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.SBTransaction.InformationOptions.IconLeftMargin = 12
        Me.SBTransaction.Margin = 10
        Me.SBTransaction.MaximumSize = New System.Drawing.Size(0, 0)
        Me.SBTransaction.MaximumViews = 7
        Me.SBTransaction.MessageRightMargin = 15
        Me.SBTransaction.MinimumSize = New System.Drawing.Size(0, 0)
        Me.SBTransaction.ShowBorders = False
        Me.SBTransaction.ShowCloseIcon = False
        Me.SBTransaction.ShowIcon = True
        Me.SBTransaction.ShowShadows = True
        Me.SBTransaction.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBTransaction.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBTransaction.SuccessOptions.ActionBorderRadius = 1
        Me.SBTransaction.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBTransaction.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBTransaction.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.SBTransaction.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.SBTransaction.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SBTransaction.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBTransaction.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.SBTransaction.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.SBTransaction.SuccessOptions.IconLeftMargin = 12
        Me.SBTransaction.ViewsMargin = 7
        Me.SBTransaction.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBTransaction.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBTransaction.WarningOptions.ActionBorderRadius = 1
        Me.SBTransaction.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBTransaction.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBTransaction.WarningOptions.BackColor = System.Drawing.Color.White
        Me.SBTransaction.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.SBTransaction.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.SBTransaction.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBTransaction.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.SBTransaction.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.SBTransaction.WarningOptions.IconLeftMargin = 12
        Me.SBTransaction.ZoomCloseIcon = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentnumberDataGridViewTextBoxColumn
        '
        Me.StudentnumberDataGridViewTextBoxColumn.DataPropertyName = "student_number"
        Me.StudentnumberDataGridViewTextBoxColumn.HeaderText = "studentno"
        Me.StudentnumberDataGridViewTextBoxColumn.Name = "StudentnumberDataGridViewTextBoxColumn"
        Me.StudentnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedicinecodeDataGridViewTextBoxColumn
        '
        Me.MedicinecodeDataGridViewTextBoxColumn.DataPropertyName = "medicine_code"
        Me.MedicinecodeDataGridViewTextBoxColumn.HeaderText = "med code"
        Me.MedicinecodeDataGridViewTextBoxColumn.Name = "MedicinecodeDataGridViewTextBoxColumn"
        Me.MedicinecodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityreleasedDataGridViewTextBoxColumn
        '
        Me.QuantityreleasedDataGridViewTextBoxColumn.DataPropertyName = "quantity_released"
        Me.QuantityreleasedDataGridViewTextBoxColumn.HeaderText = "qty released"
        Me.QuantityreleasedDataGridViewTextBoxColumn.Name = "QuantityreleasedDataGridViewTextBoxColumn"
        Me.QuantityreleasedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenericnameDataGridViewTextBoxColumn
        '
        Me.GenericnameDataGridViewTextBoxColumn.DataPropertyName = "generic_name"
        Me.GenericnameDataGridViewTextBoxColumn.HeaderText = "generic name"
        Me.GenericnameDataGridViewTextBoxColumn.Name = "GenericnameDataGridViewTextBoxColumn"
        Me.GenericnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedicinenameDataGridViewTextBoxColumn
        '
        Me.MedicinenameDataGridViewTextBoxColumn.DataPropertyName = "medicine_name"
        Me.MedicinenameDataGridViewTextBoxColumn.HeaderText = "medicine name"
        Me.MedicinenameDataGridViewTextBoxColumn.Name = "MedicinenameDataGridViewTextBoxColumn"
        Me.MedicinenameDataGridViewTextBoxColumn.ReadOnly = True
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
        'CoursecodeDataGridViewTextBoxColumn
        '
        Me.CoursecodeDataGridViewTextBoxColumn.DataPropertyName = "course_code"
        Me.CoursecodeDataGridViewTextBoxColumn.HeaderText = "course code"
        Me.CoursecodeDataGridViewTextBoxColumn.Name = "CoursecodeDataGridViewTextBoxColumn"
        Me.CoursecodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CoursenameDataGridViewTextBoxColumn
        '
        Me.CoursenameDataGridViewTextBoxColumn.DataPropertyName = "course_name"
        Me.CoursenameDataGridViewTextBoxColumn.HeaderText = "course"
        Me.CoursenameDataGridViewTextBoxColumn.Name = "CoursenameDataGridViewTextBoxColumn"
        Me.CoursenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactnoDataGridViewTextBoxColumn
        '
        Me.ContactnoDataGridViewTextBoxColumn.DataPropertyName = "contact_no"
        Me.ContactnoDataGridViewTextBoxColumn.HeaderText = "contact"
        Me.ContactnoDataGridViewTextBoxColumn.Name = "ContactnoDataGridViewTextBoxColumn"
        Me.ContactnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FRMTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 666)
        Me.Controls.Add(Me.BTNVoid)
        Me.Controls.Add(Me.PNLDatagridview)
        Me.Controls.Add(Me.BTNSearch)
        Me.Controls.Add(Me.TXTSearch)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PNLDatagridview.ResumeLayout(False)
        CType(Me.DGVTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNLDatagridview As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXTSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TIPNormalcolor As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents ClinicsmsdbDataSet As clinicsmsdbDataSet
    Friend WithEvents TbltransactionBindingSource As BindingSource
    Friend WithEvents TbltransactionTableAdapter As clinicsmsdbDataSetTableAdapters.tbltransactionTableAdapter
    Friend WithEvents DGVTransaction As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BTNVoid As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TblmedicineTableAdapter1 As clinicsmsdbDataSetTableAdapters.tblmedicineTableAdapter
    Friend WithEvents SBTransaction As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicinecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityreleasedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenericnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicinenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoursecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoursenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
