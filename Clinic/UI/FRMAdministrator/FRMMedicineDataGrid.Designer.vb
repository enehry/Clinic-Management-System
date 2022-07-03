<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMMedicineDataGrid
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TXTSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGVMedsSearch = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.MedicinecodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicinenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MilligramsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblmedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicsmsdbDataSet = New Clinic.clinicsmsdbDataSet()
        Me.TblmedicineTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tblmedicineTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVMedsSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblmedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TXTSearch.Location = New System.Drawing.Point(16, 26)
        Me.TXTSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTSearch.Name = "TXTSearch"
        Me.TXTSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSearch.PlaceholderText = "Search..."
        Me.TXTSearch.SelectedText = ""
        Me.TXTSearch.ShadowDecoration.Enabled = True
        Me.TXTSearch.ShadowDecoration.Parent = Me.TXTSearch
        Me.TXTSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTSearch.Size = New System.Drawing.Size(336, 34)
        Me.TXTSearch.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DGVMedsSearch)
        Me.Panel1.Location = New System.Drawing.Point(16, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 384)
        Me.Panel1.TabIndex = 12
        '
        'DGVMedsSearch
        '
        Me.DGVMedsSearch.AllowUserToAddRows = False
        Me.DGVMedsSearch.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVMedsSearch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVMedsSearch.AutoGenerateColumns = False
        Me.DGVMedsSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVMedsSearch.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVMedsSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVMedsSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVMedsSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVMedsSearch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVMedsSearch.ColumnHeadersHeight = 40
        Me.DGVMedsSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedicinecodeDataGridViewTextBoxColumn, Me.MedicinenameDataGridViewTextBoxColumn, Me.MilligramsDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn})
        Me.DGVMedsSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVMedsSearch.DataSource = Me.TblmedicineBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVMedsSearch.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVMedsSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVMedsSearch.EnableHeadersVisualStyles = False
        Me.DGVMedsSearch.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVMedsSearch.Location = New System.Drawing.Point(0, 0)
        Me.DGVMedsSearch.Name = "DGVMedsSearch"
        Me.DGVMedsSearch.ReadOnly = True
        Me.DGVMedsSearch.RowHeadersVisible = False
        Me.DGVMedsSearch.RowTemplate.Height = 30
        Me.DGVMedsSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVMedsSearch.Size = New System.Drawing.Size(336, 384)
        Me.DGVMedsSearch.TabIndex = 3
        Me.DGVMedsSearch.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        Me.DGVMedsSearch.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DGVMedsSearch.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVMedsSearch.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVMedsSearch.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVMedsSearch.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVMedsSearch.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVMedsSearch.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVMedsSearch.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.DGVMedsSearch.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVMedsSearch.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVMedsSearch.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVMedsSearch.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVMedsSearch.ThemeStyle.HeaderStyle.Height = 40
        Me.DGVMedsSearch.ThemeStyle.ReadOnly = True
        Me.DGVMedsSearch.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVMedsSearch.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVMedsSearch.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVMedsSearch.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVMedsSearch.ThemeStyle.RowsStyle.Height = 30
        Me.DGVMedsSearch.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGVMedsSearch.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
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
        Me.MedicinenameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.MedicinenameDataGridViewTextBoxColumn.Name = "MedicinenameDataGridViewTextBoxColumn"
        Me.MedicinenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MilligramsDataGridViewTextBoxColumn
        '
        Me.MilligramsDataGridViewTextBoxColumn.DataPropertyName = "milligrams"
        Me.MilligramsDataGridViewTextBoxColumn.HeaderText = "Milligrams"
        Me.MilligramsDataGridViewTextBoxColumn.Name = "MilligramsDataGridViewTextBoxColumn"
        Me.MilligramsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
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
        'TblmedicineTableAdapter
        '
        Me.TblmedicineTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(83, 485)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "NOTE : Double click the row to add"
        '
        'FRMMedicineDataGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(364, 509)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TXTSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FRMMedicineDataGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SEARCH MEDICINE"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGVMedsSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblmedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGVMedsSearch As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents MedicinecodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicinenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MilligramsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblmedicineBindingSource As BindingSource
    Friend WithEvents ClinicsmsdbDataSet As clinicsmsdbDataSet
    Friend WithEvents TblmedicineTableAdapter As clinicsmsdbDataSetTableAdapters.tblmedicineTableAdapter
    Friend WithEvents Label1 As Label
End Class
