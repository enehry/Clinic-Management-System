<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbluserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clinicsmsdbDataSet = New Clinic.clinicsmsdbDataSet()
        Me.RVAccount = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbluserTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tbluserTableAdapter()
        Me.DTPTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DTPFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNFilter = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNReset = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.tbluserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbluserBindingSource
        '
        Me.tbluserBindingSource.DataMember = "tbluser"
        Me.tbluserBindingSource.DataSource = Me.clinicsmsdbDataSet
        '
        'clinicsmsdbDataSet
        '
        Me.clinicsmsdbDataSet.DataSetName = "clinicsmsdbDataSet"
        Me.clinicsmsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RVAccount
        '
        ReportDataSource1.Name = "DSUseraccount"
        ReportDataSource1.Value = Me.tbluserBindingSource
        Me.RVAccount.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVAccount.LocalReport.ReportEmbeddedResource = "Clinic.REPUseraccount.rdlc"
        Me.RVAccount.Location = New System.Drawing.Point(14, 75)
        Me.RVAccount.Name = "RVAccount"
        Me.RVAccount.ServerReport.BearerToken = Nothing
        Me.RVAccount.Size = New System.Drawing.Size(601, 330)
        Me.RVAccount.TabIndex = 2
        Me.RVAccount.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'tbluserTableAdapter
        '
        Me.tbluserTableAdapter.ClearBeforeFill = True
        '
        'DTPTo
        '
        Me.DTPTo.BorderColor = System.Drawing.Color.White
        Me.DTPTo.BorderRadius = 1
        Me.DTPTo.BorderThickness = 1
        Me.DTPTo.CheckedState.Parent = Me.DTPTo
        Me.DTPTo.CustomFormat = ""
        Me.DTPTo.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DTPTo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTPTo.HoverState.Parent = Me.DTPTo
        Me.DTPTo.Location = New System.Drawing.Point(263, 34)
        Me.DTPTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.ShadowDecoration.Parent = Me.DTPTo
        Me.DTPTo.Size = New System.Drawing.Size(178, 30)
        Me.DTPTo.TabIndex = 3
        Me.DTPTo.Value = New Date(2021, 5, 3, 14, 58, 50, 333)
        '
        'DTPFrom
        '
        Me.DTPFrom.BorderColor = System.Drawing.Color.White
        Me.DTPFrom.BorderRadius = 1
        Me.DTPFrom.BorderThickness = 1
        Me.DTPFrom.CheckedState.Parent = Me.DTPFrom
        Me.DTPFrom.CustomFormat = ""
        Me.DTPFrom.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DTPFrom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFrom.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTPFrom.HoverState.Parent = Me.DTPFrom
        Me.DTPFrom.Location = New System.Drawing.Point(53, 34)
        Me.DTPFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.ShadowDecoration.Parent = Me.DTPFrom
        Me.DTPFrom.Size = New System.Drawing.Size(178, 30)
        Me.DTPFrom.TabIndex = 4
        Me.DTPFrom.Value = New Date(2021, 5, 3, 14, 58, 50, 333)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(13, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(238, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "To"
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
        Me.BTNFilter.Location = New System.Drawing.Point(454, 34)
        Me.BTNFilter.Name = "BTNFilter"
        Me.BTNFilter.ShadowDecoration.Enabled = True
        Me.BTNFilter.ShadowDecoration.Parent = Me.BTNFilter
        Me.BTNFilter.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNFilter.Size = New System.Drawing.Size(75, 30)
        Me.BTNFilter.TabIndex = 16
        Me.BTNFilter.Text = "Filter"
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
        Me.BTNReset.Location = New System.Drawing.Point(540, 34)
        Me.BTNReset.Name = "BTNReset"
        Me.BTNReset.ShadowDecoration.Enabled = True
        Me.BTNReset.ShadowDecoration.Parent = Me.BTNReset
        Me.BTNReset.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNReset.Size = New System.Drawing.Size(75, 30)
        Me.BTNReset.TabIndex = 17
        Me.BTNReset.Text = "Reset"
        '
        'AccountReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Controls.Add(Me.BTNReset)
        Me.Controls.Add(Me.BTNFilter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPFrom)
        Me.Controls.Add(Me.DTPTo)
        Me.Controls.Add(Me.RVAccount)
        Me.Name = "AccountReport"
        Me.Size = New System.Drawing.Size(630, 422)
        CType(Me.tbluserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RVAccount As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbluserBindingSource As BindingSource
    Friend WithEvents clinicsmsdbDataSet As clinicsmsdbDataSet
    Friend WithEvents tbluserTableAdapter As clinicsmsdbDataSetTableAdapters.tbluserTableAdapter
    Friend WithEvents DTPTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DTPFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNFilter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNReset As Guna.UI2.WinForms.Guna2Button
End Class
