<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMStocks
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMStocks))
        Me.PNLDatagridview = New Guna.UI2.WinForms.Guna2Panel()
        Me.DGVStocks = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.MedicinecodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicinenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenericnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaterestockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MilligramsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblmedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicsmsdbDataSet = New Clinic.clinicsmsdbDataSet()
        Me.TXTSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PNLDisplayselected = New Guna.UI2.WinForms.Guna2Panel()
        Me.TXTML = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTDesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTGenericname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTMedicinename = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TIPNormalcolor = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.BTNTrash = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.BSStocks = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.TblmedicineTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tblmedicineTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PNLDatagridview.SuspendLayout()
        CType(Me.DGVStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblmedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNLDisplayselected.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNLDatagridview
        '
        Me.PNLDatagridview.Controls.Add(Me.DGVStocks)
        Me.PNLDatagridview.Location = New System.Drawing.Point(38, 107)
        Me.PNLDatagridview.Name = "PNLDatagridview"
        Me.PNLDatagridview.ShadowDecoration.Enabled = True
        Me.PNLDatagridview.ShadowDecoration.Parent = Me.PNLDatagridview
        Me.PNLDatagridview.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.PNLDatagridview.Size = New System.Drawing.Size(720, 275)
        Me.PNLDatagridview.TabIndex = 9
        '
        'DGVStocks
        '
        Me.DGVStocks.AllowUserToAddRows = False
        Me.DGVStocks.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVStocks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVStocks.AutoGenerateColumns = False
        Me.DGVStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVStocks.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVStocks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVStocks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVStocks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGVStocks.ColumnHeadersHeight = 40
        Me.DGVStocks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedicinecodeDataGridViewTextBoxColumn, Me.MedicinenameDataGridViewTextBoxColumn, Me.GenericnameDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.DaterestockDataGridViewTextBoxColumn, Me.MilligramsDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn})
        Me.DGVStocks.DataSource = Me.TblmedicineBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVStocks.DefaultCellStyle = DataGridViewCellStyle9
        Me.DGVStocks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVStocks.EnableHeadersVisualStyles = False
        Me.DGVStocks.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVStocks.Location = New System.Drawing.Point(0, 0)
        Me.DGVStocks.Name = "DGVStocks"
        Me.DGVStocks.ReadOnly = True
        Me.DGVStocks.RowHeadersVisible = False
        Me.DGVStocks.RowTemplate.Height = 30
        Me.DGVStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVStocks.Size = New System.Drawing.Size(720, 275)
        Me.DGVStocks.TabIndex = 3
        Me.DGVStocks.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        Me.DGVStocks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DGVStocks.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVStocks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVStocks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVStocks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVStocks.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVStocks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVStocks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.DGVStocks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVStocks.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVStocks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVStocks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVStocks.ThemeStyle.HeaderStyle.Height = 40
        Me.DGVStocks.ThemeStyle.ReadOnly = True
        Me.DGVStocks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVStocks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVStocks.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVStocks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVStocks.ThemeStyle.RowsStyle.Height = 30
        Me.DGVStocks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGVStocks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'MedicinecodeDataGridViewTextBoxColumn
        '
        Me.MedicinecodeDataGridViewTextBoxColumn.DataPropertyName = "medicine_code"
        Me.MedicinecodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.MedicinecodeDataGridViewTextBoxColumn.Name = "MedicinecodeDataGridViewTextBoxColumn"
        Me.MedicinecodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedicinenameDataGridViewTextBoxColumn
        '
        Me.MedicinenameDataGridViewTextBoxColumn.DataPropertyName = "medicine_name"
        Me.MedicinenameDataGridViewTextBoxColumn.HeaderText = "Medicine Name"
        Me.MedicinenameDataGridViewTextBoxColumn.Name = "MedicinenameDataGridViewTextBoxColumn"
        Me.MedicinenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenericnameDataGridViewTextBoxColumn
        '
        Me.GenericnameDataGridViewTextBoxColumn.DataPropertyName = "generic_name"
        Me.GenericnameDataGridViewTextBoxColumn.HeaderText = "Generic Name"
        Me.GenericnameDataGridViewTextBoxColumn.Name = "GenericnameDataGridViewTextBoxColumn"
        Me.GenericnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DaterestockDataGridViewTextBoxColumn
        '
        Me.DaterestockDataGridViewTextBoxColumn.DataPropertyName = "date_restock"
        Me.DaterestockDataGridViewTextBoxColumn.HeaderText = "Date Restock"
        Me.DaterestockDataGridViewTextBoxColumn.Name = "DaterestockDataGridViewTextBoxColumn"
        Me.DaterestockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MilligramsDataGridViewTextBoxColumn
        '
        Me.MilligramsDataGridViewTextBoxColumn.DataPropertyName = "milligrams"
        Me.MilligramsDataGridViewTextBoxColumn.HeaderText = "ML"
        Me.MilligramsDataGridViewTextBoxColumn.Name = "MilligramsDataGridViewTextBoxColumn"
        Me.MilligramsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stocks"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.TXTSearch.TabIndex = 7
        Me.TIPNormalcolor.SetToolTip(Me.TXTSearch, "Are you looking for something?")
        '
        'PNLDisplayselected
        '
        Me.PNLDisplayselected.Controls.Add(Me.TXTML)
        Me.PNLDisplayselected.Controls.Add(Me.TXTDesc)
        Me.PNLDisplayselected.Controls.Add(Me.TXTGenericname)
        Me.PNLDisplayselected.Controls.Add(Me.TXTMedicinename)
        Me.PNLDisplayselected.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PNLDisplayselected.Location = New System.Drawing.Point(38, 412)
        Me.PNLDisplayselected.Name = "PNLDisplayselected"
        Me.PNLDisplayselected.ShadowDecoration.Enabled = True
        Me.PNLDisplayselected.ShadowDecoration.Parent = Me.PNLDisplayselected
        Me.PNLDisplayselected.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.PNLDisplayselected.Size = New System.Drawing.Size(720, 147)
        Me.PNLDisplayselected.TabIndex = 10
        '
        'TXTML
        '
        Me.TXTML.Animated = True
        Me.TXTML.BackColor = System.Drawing.Color.Transparent
        Me.TXTML.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTML.BorderRadius = 1
        Me.TXTML.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTML.DefaultText = ""
        Me.TXTML.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTML.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTML.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTML.DisabledState.Parent = Me.TXTML
        Me.TXTML.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTML.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTML.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTML.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTML.FocusedState.Parent = Me.TXTML
        Me.TXTML.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTML.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTML.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTML.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTML.HoverState.Parent = Me.TXTML
        Me.TXTML.Location = New System.Drawing.Point(362, 79)
        Me.TXTML.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTML.Name = "TXTML"
        Me.TXTML.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTML.PlaceholderText = "Milligrams"
        Me.TXTML.SelectedText = ""
        Me.TXTML.ShadowDecoration.Enabled = True
        Me.TXTML.ShadowDecoration.Parent = Me.TXTML
        Me.TXTML.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTML.Size = New System.Drawing.Size(323, 41)
        Me.TXTML.TabIndex = 3
        Me.TIPNormalcolor.SetToolTip(Me.TXTML, "Description")
        '
        'TXTDesc
        '
        Me.TXTDesc.Animated = True
        Me.TXTDesc.BackColor = System.Drawing.Color.Transparent
        Me.TXTDesc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTDesc.BorderRadius = 1
        Me.TXTDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTDesc.DefaultText = ""
        Me.TXTDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTDesc.DisabledState.Parent = Me.TXTDesc
        Me.TXTDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTDesc.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTDesc.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTDesc.FocusedState.Parent = Me.TXTDesc
        Me.TXTDesc.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTDesc.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTDesc.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTDesc.HoverState.Parent = Me.TXTDesc
        Me.TXTDesc.Location = New System.Drawing.Point(33, 79)
        Me.TXTDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTDesc.Name = "TXTDesc"
        Me.TXTDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTDesc.PlaceholderText = "Description"
        Me.TXTDesc.SelectedText = ""
        Me.TXTDesc.ShadowDecoration.Enabled = True
        Me.TXTDesc.ShadowDecoration.Parent = Me.TXTDesc
        Me.TXTDesc.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTDesc.Size = New System.Drawing.Size(323, 41)
        Me.TXTDesc.TabIndex = 2
        Me.TIPNormalcolor.SetToolTip(Me.TXTDesc, "Description")
        '
        'TXTGenericname
        '
        Me.TXTGenericname.Animated = True
        Me.TXTGenericname.BackColor = System.Drawing.Color.Transparent
        Me.TXTGenericname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTGenericname.BorderRadius = 1
        Me.TXTGenericname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTGenericname.DefaultText = ""
        Me.TXTGenericname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTGenericname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTGenericname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTGenericname.DisabledState.Parent = Me.TXTGenericname
        Me.TXTGenericname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTGenericname.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTGenericname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTGenericname.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTGenericname.FocusedState.Parent = Me.TXTGenericname
        Me.TXTGenericname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTGenericname.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTGenericname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTGenericname.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTGenericname.HoverState.Parent = Me.TXTGenericname
        Me.TXTGenericname.Location = New System.Drawing.Point(363, 30)
        Me.TXTGenericname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTGenericname.Name = "TXTGenericname"
        Me.TXTGenericname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTGenericname.PlaceholderText = "Generic name"
        Me.TXTGenericname.SelectedText = ""
        Me.TXTGenericname.ShadowDecoration.Enabled = True
        Me.TXTGenericname.ShadowDecoration.Parent = Me.TXTGenericname
        Me.TXTGenericname.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTGenericname.Size = New System.Drawing.Size(323, 41)
        Me.TXTGenericname.TabIndex = 2
        Me.TIPNormalcolor.SetToolTip(Me.TXTGenericname, "Generic name")
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
        Me.TXTMedicinename.Location = New System.Drawing.Point(33, 30)
        Me.TXTMedicinename.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTMedicinename.Name = "TXTMedicinename"
        Me.TXTMedicinename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTMedicinename.PlaceholderText = "Medicine name"
        Me.TXTMedicinename.SelectedText = ""
        Me.TXTMedicinename.ShadowDecoration.Enabled = True
        Me.TXTMedicinename.ShadowDecoration.Parent = Me.TXTMedicinename
        Me.TXTMedicinename.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTMedicinename.Size = New System.Drawing.Size(323, 41)
        Me.TXTMedicinename.TabIndex = 2
        Me.TIPNormalcolor.SetToolTip(Me.TXTMedicinename, "Medicine name")
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
        Me.BTNTrash.Location = New System.Drawing.Point(584, 581)
        Me.BTNTrash.Name = "BTNTrash"
        Me.BTNTrash.ShadowDecoration.Enabled = True
        Me.BTNTrash.ShadowDecoration.Parent = Me.BTNTrash
        Me.BTNTrash.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNTrash.Size = New System.Drawing.Size(174, 45)
        Me.BTNTrash.TabIndex = 11
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
        Me.BTNDelete.Location = New System.Drawing.Point(402, 581)
        Me.BTNDelete.Name = "BTNDelete"
        Me.BTNDelete.ShadowDecoration.Enabled = True
        Me.BTNDelete.ShadowDecoration.Parent = Me.BTNDelete
        Me.BTNDelete.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNDelete.Size = New System.Drawing.Size(174, 45)
        Me.BTNDelete.TabIndex = 12
        Me.BTNDelete.Text = "Delete"
        Me.TIPNormalcolor.SetToolTip(Me.BTNDelete, "Click to delete medicine")
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
        Me.BTNUpdate.Location = New System.Drawing.Point(220, 581)
        Me.BTNUpdate.Name = "BTNUpdate"
        Me.BTNUpdate.ShadowDecoration.Enabled = True
        Me.BTNUpdate.ShadowDecoration.Parent = Me.BTNUpdate
        Me.BTNUpdate.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNUpdate.Size = New System.Drawing.Size(174, 45)
        Me.BTNUpdate.TabIndex = 13
        Me.BTNUpdate.Text = "Update"
        Me.TIPNormalcolor.SetToolTip(Me.BTNUpdate, "Click to update medicine")
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
        Me.BTNAdd.Location = New System.Drawing.Point(38, 581)
        Me.BTNAdd.Name = "BTNAdd"
        Me.BTNAdd.ShadowDecoration.Enabled = True
        Me.BTNAdd.ShadowDecoration.Parent = Me.BTNAdd
        Me.BTNAdd.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNAdd.Size = New System.Drawing.Size(174, 45)
        Me.BTNAdd.TabIndex = 14
        Me.BTNAdd.Text = "Add"
        Me.TIPNormalcolor.SetToolTip(Me.BTNAdd, "Click to add medicine")
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
        'BSStocks
        '
        Me.BSStocks.AllowDragging = False
        Me.BSStocks.AllowMultipleViews = True
        Me.BSStocks.ClickToClose = True
        Me.BSStocks.DoubleClickToClose = True
        Me.BSStocks.DurationAfterIdle = 3000
        Me.BSStocks.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStocks.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStocks.ErrorOptions.ActionBorderRadius = 1
        Me.BSStocks.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BSStocks.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BSStocks.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.BSStocks.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.BSStocks.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BSStocks.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BSStocks.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.BSStocks.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.BSStocks.ErrorOptions.IconLeftMargin = 12
        Me.BSStocks.FadeCloseIcon = False
        Me.BSStocks.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.BSStocks.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStocks.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStocks.InformationOptions.ActionBorderRadius = 1
        Me.BSStocks.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BSStocks.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BSStocks.InformationOptions.BackColor = System.Drawing.Color.White
        Me.BSStocks.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.BSStocks.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStocks.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BSStocks.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.BSStocks.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.BSStocks.InformationOptions.IconLeftMargin = 12
        Me.BSStocks.Margin = 10
        Me.BSStocks.MaximumSize = New System.Drawing.Size(0, 0)
        Me.BSStocks.MaximumViews = 7
        Me.BSStocks.MessageRightMargin = 15
        Me.BSStocks.MinimumSize = New System.Drawing.Size(0, 0)
        Me.BSStocks.ShowBorders = False
        Me.BSStocks.ShowCloseIcon = False
        Me.BSStocks.ShowIcon = True
        Me.BSStocks.ShowShadows = True
        Me.BSStocks.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStocks.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStocks.SuccessOptions.ActionBorderRadius = 1
        Me.BSStocks.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BSStocks.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BSStocks.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.BSStocks.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.BSStocks.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.BSStocks.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BSStocks.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.BSStocks.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.BSStocks.SuccessOptions.IconLeftMargin = 12
        Me.BSStocks.ViewsMargin = 7
        Me.BSStocks.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStocks.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSStocks.WarningOptions.ActionBorderRadius = 1
        Me.BSStocks.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BSStocks.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.BSStocks.WarningOptions.BackColor = System.Drawing.Color.White
        Me.BSStocks.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.BSStocks.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BSStocks.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BSStocks.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.BSStocks.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.BSStocks.WarningOptions.IconLeftMargin = 12
        Me.BSStocks.ZoomCloseIcon = True
        '
        'TblmedicineTableAdapter
        '
        Me.TblmedicineTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(163, 638)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Note : Double click row to update data. Select row then right click to add stock"
        '
        'FRMStocks
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
        Me.Name = "FRMStocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PNLDatagridview.ResumeLayout(False)
        CType(Me.DGVStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblmedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNLDisplayselected.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PNLDatagridview As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXTSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNTrash As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PNLDisplayselected As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TXTGenericname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TIPNormalcolor As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents TXTDesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTMedicinename As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DGVStocks As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DateaddedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddedstockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TXTML As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ClinicsmsdbDataSet As clinicsmsdbDataSet
    Friend WithEvents TblmedicineBindingSource As BindingSource
    Friend WithEvents TblmedicineTableAdapter As clinicsmsdbDataSetTableAdapters.tblmedicineTableAdapter
    Friend WithEvents MedicinecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicinenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenericnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DaterestockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MilligramsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BSStocks As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents Label1 As Label
End Class
