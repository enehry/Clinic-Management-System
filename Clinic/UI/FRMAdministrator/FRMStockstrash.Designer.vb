<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMStockstrash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMStockstrash))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TIPNormalcolor = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.TXTSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNBack = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNRestore = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.PNLDatagridview = New Guna.UI2.WinForms.Guna2Panel()
        Me.DGVStocksTrash = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TblmedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicsmsdbDataSet = New Clinic.clinicsmsdbDataSet()
        Me.TblmedicineTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tblmedicineTableAdapter()
        Me.SBStockTrash = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.MedicinecodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicinenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenericnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaterestockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MilligramsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNLDatagridview.SuspendLayout()
        CType(Me.DGVStocksTrash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblmedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BTNBack.TabIndex = 17
        Me.BTNBack.TabStop = False
        Me.BTNBack.Text = "Back"
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
        Me.BTNRestore.TabIndex = 18
        Me.BTNRestore.TabStop = False
        Me.BTNRestore.Text = "Restore"
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
        '
        'PNLDatagridview
        '
        Me.PNLDatagridview.Controls.Add(Me.DGVStocksTrash)
        Me.PNLDatagridview.Location = New System.Drawing.Point(38, 108)
        Me.PNLDatagridview.Name = "PNLDatagridview"
        Me.PNLDatagridview.ShadowDecoration.Enabled = True
        Me.PNLDatagridview.ShadowDecoration.Parent = Me.PNLDatagridview
        Me.PNLDatagridview.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.PNLDatagridview.Size = New System.Drawing.Size(720, 446)
        Me.PNLDatagridview.TabIndex = 21
        '
        'DGVStocksTrash
        '
        Me.DGVStocksTrash.AllowUserToAddRows = False
        Me.DGVStocksTrash.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVStocksTrash.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVStocksTrash.AutoGenerateColumns = False
        Me.DGVStocksTrash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVStocksTrash.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVStocksTrash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVStocksTrash.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVStocksTrash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVStocksTrash.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVStocksTrash.ColumnHeadersHeight = 40
        Me.DGVStocksTrash.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedicinecodeDataGridViewTextBoxColumn, Me.MedicinenameDataGridViewTextBoxColumn, Me.GenericnameDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.DaterestockDataGridViewTextBoxColumn, Me.MilligramsDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn})
        Me.DGVStocksTrash.DataSource = Me.TblmedicineBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVStocksTrash.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVStocksTrash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVStocksTrash.EnableHeadersVisualStyles = False
        Me.DGVStocksTrash.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVStocksTrash.Location = New System.Drawing.Point(0, 0)
        Me.DGVStocksTrash.Name = "DGVStocksTrash"
        Me.DGVStocksTrash.ReadOnly = True
        Me.DGVStocksTrash.RowHeadersVisible = False
        Me.DGVStocksTrash.RowTemplate.Height = 30
        Me.DGVStocksTrash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVStocksTrash.Size = New System.Drawing.Size(720, 446)
        Me.DGVStocksTrash.TabIndex = 4
        Me.DGVStocksTrash.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        Me.DGVStocksTrash.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DGVStocksTrash.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVStocksTrash.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVStocksTrash.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVStocksTrash.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVStocksTrash.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVStocksTrash.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVStocksTrash.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.DGVStocksTrash.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVStocksTrash.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVStocksTrash.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVStocksTrash.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVStocksTrash.ThemeStyle.HeaderStyle.Height = 40
        Me.DGVStocksTrash.ThemeStyle.ReadOnly = True
        Me.DGVStocksTrash.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVStocksTrash.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVStocksTrash.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVStocksTrash.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVStocksTrash.ThemeStyle.RowsStyle.Height = 30
        Me.DGVStocksTrash.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGVStocksTrash.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'TblmedicineBindingSource
        '
        Me.TblmedicineBindingSource.DataMember = "tblmedicine"
        Me.TblmedicineBindingSource.DataSource = Me.ClinicsmsdbDataSet
        '
        'ClinicsmsdbDataSet
        '
        Me.ClinicsmsdbDataSet.DataSetName = "clinicsmsdbDataSet"
        Me.ClinicsmsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblmedicineTableAdapter
        '
        Me.TblmedicineTableAdapter.ClearBeforeFill = True
        '
        'SBStockTrash
        '
        Me.SBStockTrash.AllowDragging = False
        Me.SBStockTrash.AllowMultipleViews = True
        Me.SBStockTrash.ClickToClose = True
        Me.SBStockTrash.DoubleClickToClose = True
        Me.SBStockTrash.DurationAfterIdle = 3000
        Me.SBStockTrash.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBStockTrash.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBStockTrash.ErrorOptions.ActionBorderRadius = 1
        Me.SBStockTrash.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBStockTrash.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBStockTrash.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.SBStockTrash.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.SBStockTrash.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.SBStockTrash.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBStockTrash.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.SBStockTrash.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.SBStockTrash.ErrorOptions.IconLeftMargin = 12
        Me.SBStockTrash.FadeCloseIcon = False
        Me.SBStockTrash.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.SBStockTrash.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBStockTrash.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBStockTrash.InformationOptions.ActionBorderRadius = 1
        Me.SBStockTrash.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBStockTrash.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBStockTrash.InformationOptions.BackColor = System.Drawing.Color.White
        Me.SBStockTrash.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.SBStockTrash.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBStockTrash.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBStockTrash.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.SBStockTrash.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.SBStockTrash.InformationOptions.IconLeftMargin = 12
        Me.SBStockTrash.Margin = 10
        Me.SBStockTrash.MaximumSize = New System.Drawing.Size(0, 0)
        Me.SBStockTrash.MaximumViews = 7
        Me.SBStockTrash.MessageRightMargin = 15
        Me.SBStockTrash.MinimumSize = New System.Drawing.Size(0, 0)
        Me.SBStockTrash.ShowBorders = False
        Me.SBStockTrash.ShowCloseIcon = False
        Me.SBStockTrash.ShowIcon = True
        Me.SBStockTrash.ShowShadows = True
        Me.SBStockTrash.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBStockTrash.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBStockTrash.SuccessOptions.ActionBorderRadius = 1
        Me.SBStockTrash.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBStockTrash.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBStockTrash.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.SBStockTrash.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.SBStockTrash.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SBStockTrash.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBStockTrash.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.SBStockTrash.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.SBStockTrash.SuccessOptions.IconLeftMargin = 12
        Me.SBStockTrash.ViewsMargin = 7
        Me.SBStockTrash.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBStockTrash.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBStockTrash.WarningOptions.ActionBorderRadius = 1
        Me.SBStockTrash.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBStockTrash.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBStockTrash.WarningOptions.BackColor = System.Drawing.Color.White
        Me.SBStockTrash.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.SBStockTrash.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.SBStockTrash.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBStockTrash.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.SBStockTrash.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.SBStockTrash.WarningOptions.IconLeftMargin = 12
        Me.SBStockTrash.ZoomCloseIcon = True
        '
        'MedicinecodeDataGridViewTextBoxColumn
        '
        Me.MedicinecodeDataGridViewTextBoxColumn.DataPropertyName = "medicine_code"
        Me.MedicinecodeDataGridViewTextBoxColumn.HeaderText = "medicine code"
        Me.MedicinecodeDataGridViewTextBoxColumn.Name = "MedicinecodeDataGridViewTextBoxColumn"
        Me.MedicinecodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedicinenameDataGridViewTextBoxColumn
        '
        Me.MedicinenameDataGridViewTextBoxColumn.DataPropertyName = "medicine_name"
        Me.MedicinenameDataGridViewTextBoxColumn.HeaderText = "medicine name"
        Me.MedicinenameDataGridViewTextBoxColumn.Name = "MedicinenameDataGridViewTextBoxColumn"
        Me.MedicinenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenericnameDataGridViewTextBoxColumn
        '
        Me.GenericnameDataGridViewTextBoxColumn.DataPropertyName = "generic_name"
        Me.GenericnameDataGridViewTextBoxColumn.HeaderText = "generic name"
        Me.GenericnameDataGridViewTextBoxColumn.Name = "GenericnameDataGridViewTextBoxColumn"
        Me.GenericnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DaterestockDataGridViewTextBoxColumn
        '
        Me.DaterestockDataGridViewTextBoxColumn.DataPropertyName = "date_restock"
        Me.DaterestockDataGridViewTextBoxColumn.HeaderText = "date restock"
        Me.DaterestockDataGridViewTextBoxColumn.Name = "DaterestockDataGridViewTextBoxColumn"
        Me.DaterestockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MilligramsDataGridViewTextBoxColumn
        '
        Me.MilligramsDataGridViewTextBoxColumn.DataPropertyName = "milligrams"
        Me.MilligramsDataGridViewTextBoxColumn.HeaderText = "milligrams"
        Me.MilligramsDataGridViewTextBoxColumn.Name = "MilligramsDataGridViewTextBoxColumn"
        Me.MilligramsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FRMStockstrash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 666)
        Me.Controls.Add(Me.PNLDatagridview)
        Me.Controls.Add(Me.BTNSearch)
        Me.Controls.Add(Me.TXTSearch)
        Me.Controls.Add(Me.BTNBack)
        Me.Controls.Add(Me.BTNRestore)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRMStockstrash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PNLDatagridview.ResumeLayout(False)
        CType(Me.DGVStocksTrash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblmedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TIPNormalcolor As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents BTNSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXTSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNRestore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PNLDatagridview As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DGVStocksTrash As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TblmedicineBindingSource As BindingSource
    Friend WithEvents ClinicsmsdbDataSet As clinicsmsdbDataSet
    Friend WithEvents TblmedicineTableAdapter As clinicsmsdbDataSetTableAdapters.tblmedicineTableAdapter
    Friend WithEvents SBStockTrash As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents MedicinecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicinenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenericnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DaterestockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MilligramsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
