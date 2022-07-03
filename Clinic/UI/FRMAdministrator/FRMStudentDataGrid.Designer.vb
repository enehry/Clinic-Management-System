<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMStudentDataGrid
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGVStudentsSearch = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.StudentnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoursenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblstudentprofileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicsmsdbDataSet = New Clinic.clinicsmsdbDataSet()
        Me.TblstudentprofileTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tblstudentprofileTableAdapter()
        Me.TXTSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVStudentsSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstudentprofileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DGVStudentsSearch)
        Me.Panel1.Location = New System.Drawing.Point(13, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 384)
        Me.Panel1.TabIndex = 0
        '
        'DGVStudentsSearch
        '
        Me.DGVStudentsSearch.AllowUserToAddRows = False
        Me.DGVStudentsSearch.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVStudentsSearch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVStudentsSearch.AutoGenerateColumns = False
        Me.DGVStudentsSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVStudentsSearch.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVStudentsSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVStudentsSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVStudentsSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVStudentsSearch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVStudentsSearch.ColumnHeadersHeight = 40
        Me.DGVStudentsSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentnumberDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.MnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.CoursenameDataGridViewTextBoxColumn})
        Me.DGVStudentsSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVStudentsSearch.DataSource = Me.TblstudentprofileBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVStudentsSearch.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVStudentsSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVStudentsSearch.EnableHeadersVisualStyles = False
        Me.DGVStudentsSearch.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVStudentsSearch.Location = New System.Drawing.Point(0, 0)
        Me.DGVStudentsSearch.Name = "DGVStudentsSearch"
        Me.DGVStudentsSearch.ReadOnly = True
        Me.DGVStudentsSearch.RowHeadersVisible = False
        Me.DGVStudentsSearch.RowTemplate.Height = 30
        Me.DGVStudentsSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVStudentsSearch.Size = New System.Drawing.Size(336, 384)
        Me.DGVStudentsSearch.TabIndex = 2
        Me.DGVStudentsSearch.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        Me.DGVStudentsSearch.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DGVStudentsSearch.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVStudentsSearch.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVStudentsSearch.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVStudentsSearch.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVStudentsSearch.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DGVStudentsSearch.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVStudentsSearch.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.DGVStudentsSearch.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVStudentsSearch.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVStudentsSearch.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVStudentsSearch.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVStudentsSearch.ThemeStyle.HeaderStyle.Height = 40
        Me.DGVStudentsSearch.ThemeStyle.ReadOnly = True
        Me.DGVStudentsSearch.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DGVStudentsSearch.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVStudentsSearch.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVStudentsSearch.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVStudentsSearch.ThemeStyle.RowsStyle.Height = 30
        Me.DGVStudentsSearch.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.DGVStudentsSearch.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
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
        Me.TXTSearch.Location = New System.Drawing.Point(13, 31)
        Me.TXTSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTSearch.Name = "TXTSearch"
        Me.TXTSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSearch.PlaceholderText = "Search..."
        Me.TXTSearch.SelectedText = ""
        Me.TXTSearch.ShadowDecoration.Enabled = True
        Me.TXTSearch.ShadowDecoration.Parent = Me.TXTSearch
        Me.TXTSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTSearch.Size = New System.Drawing.Size(336, 34)
        Me.TXTSearch.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(89, 485)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "NOTE : Double click the row to add"
        '
        'FRMStudentDataGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(364, 509)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTSearch)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FRMStudentDataGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SEARCH STUDENT"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGVStudentsSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstudentprofileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGVStudentsSearch As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TblstudentprofileBindingSource As BindingSource
    Friend WithEvents ClinicsmsdbDataSet As clinicsmsdbDataSet
    Friend WithEvents TblstudentprofileTableAdapter As clinicsmsdbDataSetTableAdapters.tblstudentprofileTableAdapter
    Friend WithEvents TXTSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StudentnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoursenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
