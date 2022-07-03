<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentReport
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tblstudentprofileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clinicsmsdbDataSet = New Clinic.clinicsmsdbDataSet()
        Me.RVStudent = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblstudentprofileTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tblstudentprofileTableAdapter()
        Me.CMBCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TblcourseTableAdapter1 = New Clinic.clinicsmsdbDataSetTableAdapters.tblcourseTableAdapter()
        Me.BTNReset = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNFilter = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.tblstudentprofileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblstudentprofileBindingSource
        '
        Me.tblstudentprofileBindingSource.DataMember = "tblstudentprofile"
        Me.tblstudentprofileBindingSource.DataSource = Me.clinicsmsdbDataSet
        '
        'clinicsmsdbDataSet
        '
        Me.clinicsmsdbDataSet.DataSetName = "clinicsmsdbDataSet"
        Me.clinicsmsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RVStudent
        '
        ReportDataSource5.Name = "DSStudentprofile"
        ReportDataSource5.Value = Me.tblstudentprofileBindingSource
        Me.RVStudent.LocalReport.DataSources.Add(ReportDataSource5)
        Me.RVStudent.LocalReport.ReportEmbeddedResource = "Clinic.REPStudentprofile.rdlc"
        Me.RVStudent.Location = New System.Drawing.Point(12, 73)
        Me.RVStudent.Name = "RVStudent"
        Me.RVStudent.ServerReport.BearerToken = Nothing
        Me.RVStudent.Size = New System.Drawing.Size(605, 330)
        Me.RVStudent.TabIndex = 3
        Me.RVStudent.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'tblstudentprofileTableAdapter
        '
        Me.tblstudentprofileTableAdapter.ClearBeforeFill = True
        '
        'CMBCourse
        '
        Me.CMBCourse.BackColor = System.Drawing.Color.Transparent
        Me.CMBCourse.BorderRadius = 1
        Me.CMBCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBCourse.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CMBCourse.FocusedColor = System.Drawing.Color.Empty
        Me.CMBCourse.FocusedState.Parent = Me.CMBCourse
        Me.CMBCourse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CMBCourse.FormattingEnabled = True
        Me.CMBCourse.HoverState.Parent = Me.CMBCourse
        Me.CMBCourse.ItemHeight = 30
        Me.CMBCourse.ItemsAppearance.Parent = Me.CMBCourse
        Me.CMBCourse.Location = New System.Drawing.Point(283, 34)
        Me.CMBCourse.Name = "CMBCourse"
        Me.CMBCourse.ShadowDecoration.Parent = Me.CMBCourse
        Me.CMBCourse.Size = New System.Drawing.Size(161, 36)
        Me.CMBCourse.TabIndex = 16
        '
        'TblcourseTableAdapter1
        '
        Me.TblcourseTableAdapter1.ClearBeforeFill = True
        '
        'BTNReset
        '
        Me.BTNReset.Animated = True
        Me.BTNReset.BackColor = System.Drawing.Color.Transparent
        Me.BTNReset.BorderColor = System.Drawing.Color.White
        Me.BTNReset.BorderRadius = 1
        Me.BTNReset.BorderThickness = 1
        Me.BTNReset.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNReset.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNReset.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNReset.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNReset.CheckedState.Parent = Me.BTNReset
        Me.BTNReset.CustomImages.Parent = Me.BTNReset
        Me.BTNReset.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNReset.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNReset.ForeColor = System.Drawing.Color.White
        Me.BTNReset.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNReset.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNReset.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNReset.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNReset.HoverState.Parent = Me.BTNReset
        Me.BTNReset.Location = New System.Drawing.Point(540, 32)
        Me.BTNReset.Name = "BTNReset"
        Me.BTNReset.ShadowDecoration.Enabled = True
        Me.BTNReset.ShadowDecoration.Parent = Me.BTNReset
        Me.BTNReset.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNReset.Size = New System.Drawing.Size(75, 30)
        Me.BTNReset.TabIndex = 25
        Me.BTNReset.Text = "Reset"
        '
        'BTNFilter
        '
        Me.BTNFilter.Animated = True
        Me.BTNFilter.BackColor = System.Drawing.Color.Transparent
        Me.BTNFilter.BorderColor = System.Drawing.Color.White
        Me.BTNFilter.BorderRadius = 1
        Me.BTNFilter.BorderThickness = 1
        Me.BTNFilter.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNFilter.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNFilter.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNFilter.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNFilter.CheckedState.Parent = Me.BTNFilter
        Me.BTNFilter.CustomImages.Parent = Me.BTNFilter
        Me.BTNFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNFilter.ForeColor = System.Drawing.Color.White
        Me.BTNFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNFilter.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNFilter.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNFilter.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNFilter.HoverState.Parent = Me.BTNFilter
        Me.BTNFilter.Location = New System.Drawing.Point(454, 32)
        Me.BTNFilter.Name = "BTNFilter"
        Me.BTNFilter.ShadowDecoration.Enabled = True
        Me.BTNFilter.ShadowDecoration.Parent = Me.BTNFilter
        Me.BTNFilter.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNFilter.Size = New System.Drawing.Size(75, 30)
        Me.BTNFilter.TabIndex = 24
        Me.BTNFilter.Text = "Filter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(185, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Filter by Course"
        '
        'StudentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTNReset)
        Me.Controls.Add(Me.BTNFilter)
        Me.Controls.Add(Me.CMBCourse)
        Me.Controls.Add(Me.RVStudent)
        Me.Name = "StudentReport"
        Me.Size = New System.Drawing.Size(630, 422)
        CType(Me.tblstudentprofileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RVStudent As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblstudentprofileBindingSource As BindingSource
    Friend WithEvents clinicsmsdbDataSet As clinicsmsdbDataSet
    Friend WithEvents tblstudentprofileTableAdapter As clinicsmsdbDataSetTableAdapters.tblstudentprofileTableAdapter
    Friend WithEvents CMBCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TblcourseTableAdapter1 As clinicsmsdbDataSetTableAdapters.tblcourseTableAdapter
    Friend WithEvents BTNReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNFilter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
End Class
