<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActivityLogReport
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActivityLogReport))
        Me.tblactivitylogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clinicsmsdbDataSet = New Clinic.clinicsmsdbDataSet()
        Me.RVActivityLog = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblactivitylogTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tblactivitylogTableAdapter()
        Me.BTNReset = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNFilter = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DTPTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBFilterOpt = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXTUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SBReportActivityLog = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        CType(Me.tblactivitylogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblactivitylogBindingSource
        '
        Me.tblactivitylogBindingSource.DataMember = "tblactivitylog"
        Me.tblactivitylogBindingSource.DataSource = Me.clinicsmsdbDataSet
        '
        'clinicsmsdbDataSet
        '
        Me.clinicsmsdbDataSet.DataSetName = "clinicsmsdbDataSet"
        Me.clinicsmsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RVActivityLog
        '
        ReportDataSource2.Name = "DSActivitylog"
        ReportDataSource2.Value = Me.tblactivitylogBindingSource
        Me.RVActivityLog.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RVActivityLog.LocalReport.ReportEmbeddedResource = "Clinic.REPActivitylog.rdlc"
        Me.RVActivityLog.Location = New System.Drawing.Point(12, 80)
        Me.RVActivityLog.Name = "RVActivityLog"
        Me.RVActivityLog.ServerReport.BearerToken = Nothing
        Me.RVActivityLog.Size = New System.Drawing.Size(605, 330)
        Me.RVActivityLog.TabIndex = 1
        Me.RVActivityLog.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'tblactivitylogTableAdapter
        '
        Me.tblactivitylogTableAdapter.ClearBeforeFill = True
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
        Me.BTNReset.Location = New System.Drawing.Point(542, 42)
        Me.BTNReset.Name = "BTNReset"
        Me.BTNReset.ShadowDecoration.Enabled = True
        Me.BTNReset.ShadowDecoration.Parent = Me.BTNReset
        Me.BTNReset.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNReset.Size = New System.Drawing.Size(75, 30)
        Me.BTNReset.TabIndex = 23
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
        Me.BTNFilter.Location = New System.Drawing.Point(456, 42)
        Me.BTNFilter.Name = "BTNFilter"
        Me.BTNFilter.ShadowDecoration.Enabled = True
        Me.BTNFilter.ShadowDecoration.Parent = Me.BTNFilter
        Me.BTNFilter.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNFilter.Size = New System.Drawing.Size(75, 30)
        Me.BTNFilter.TabIndex = 22
        Me.BTNFilter.Text = "Filter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(240, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(15, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "From"
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
        Me.DTPFrom.Location = New System.Drawing.Point(55, 42)
        Me.DTPFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.ShadowDecoration.Parent = Me.DTPFrom
        Me.DTPFrom.Size = New System.Drawing.Size(178, 30)
        Me.DTPFrom.TabIndex = 19
        Me.DTPFrom.Value = New Date(2021, 5, 3, 17, 45, 24, 0)
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
        Me.DTPTo.Location = New System.Drawing.Point(265, 42)
        Me.DTPTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.ShadowDecoration.Parent = Me.DTPTo
        Me.DTPTo.Size = New System.Drawing.Size(178, 30)
        Me.DTPTo.TabIndex = 18
        Me.DTPTo.Value = New Date(2021, 5, 3, 14, 58, 50, 333)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(368, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Filter Option"
        '
        'CBFilterOpt
        '
        Me.CBFilterOpt.BackColor = System.Drawing.Color.Transparent
        Me.CBFilterOpt.BorderRadius = 1
        Me.CBFilterOpt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBFilterOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFilterOpt.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CBFilterOpt.FocusedColor = System.Drawing.Color.Empty
        Me.CBFilterOpt.FocusedState.Parent = Me.CBFilterOpt
        Me.CBFilterOpt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFilterOpt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CBFilterOpt.FormattingEnabled = True
        Me.CBFilterOpt.HoverState.Parent = Me.CBFilterOpt
        Me.CBFilterOpt.ItemHeight = 25
        Me.CBFilterOpt.Items.AddRange(New Object() {"Username", "Date", "Username and Date"})
        Me.CBFilterOpt.ItemsAppearance.Parent = Me.CBFilterOpt
        Me.CBFilterOpt.Location = New System.Drawing.Point(456, 10)
        Me.CBFilterOpt.Name = "CBFilterOpt"
        Me.CBFilterOpt.ShadowDecoration.Parent = Me.CBFilterOpt
        Me.CBFilterOpt.Size = New System.Drawing.Size(161, 31)
        Me.CBFilterOpt.StartIndex = 0
        Me.CBFilterOpt.TabIndex = 15
        '
        'TXTUsername
        '
        Me.TXTUsername.Animated = True
        Me.TXTUsername.BackColor = System.Drawing.Color.Transparent
        Me.TXTUsername.BorderColor = System.Drawing.Color.White
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
        Me.TXTUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUsername.ForeColor = System.Drawing.Color.White
        Me.TXTUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTUsername.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTUsername.HoverState.Parent = Me.TXTUsername
        Me.TXTUsername.Location = New System.Drawing.Point(18, 9)
        Me.TXTUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTUsername.Name = "TXTUsername"
        Me.TXTUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTUsername.PlaceholderForeColor = System.Drawing.Color.White
        Me.TXTUsername.PlaceholderText = "Username"
        Me.TXTUsername.SelectedText = ""
        Me.TXTUsername.ShadowDecoration.Enabled = True
        Me.TXTUsername.ShadowDecoration.Parent = Me.TXTUsername
        Me.TXTUsername.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTUsername.Size = New System.Drawing.Size(332, 25)
        Me.TXTUsername.TabIndex = 25
        '
        'SBReportActivityLog
        '
        Me.SBReportActivityLog.AllowDragging = False
        Me.SBReportActivityLog.AllowMultipleViews = True
        Me.SBReportActivityLog.ClickToClose = True
        Me.SBReportActivityLog.DoubleClickToClose = True
        Me.SBReportActivityLog.DurationAfterIdle = 3000
        Me.SBReportActivityLog.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBReportActivityLog.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBReportActivityLog.ErrorOptions.ActionBorderRadius = 1
        Me.SBReportActivityLog.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBReportActivityLog.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBReportActivityLog.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.SBReportActivityLog.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.SBReportActivityLog.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.SBReportActivityLog.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBReportActivityLog.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.SBReportActivityLog.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.SBReportActivityLog.ErrorOptions.IconLeftMargin = 12
        Me.SBReportActivityLog.FadeCloseIcon = False
        Me.SBReportActivityLog.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.SBReportActivityLog.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBReportActivityLog.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBReportActivityLog.InformationOptions.ActionBorderRadius = 1
        Me.SBReportActivityLog.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBReportActivityLog.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBReportActivityLog.InformationOptions.BackColor = System.Drawing.Color.White
        Me.SBReportActivityLog.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.SBReportActivityLog.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBReportActivityLog.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBReportActivityLog.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.SBReportActivityLog.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.SBReportActivityLog.InformationOptions.IconLeftMargin = 12
        Me.SBReportActivityLog.Margin = 10
        Me.SBReportActivityLog.MaximumSize = New System.Drawing.Size(0, 0)
        Me.SBReportActivityLog.MaximumViews = 7
        Me.SBReportActivityLog.MessageRightMargin = 15
        Me.SBReportActivityLog.MinimumSize = New System.Drawing.Size(0, 0)
        Me.SBReportActivityLog.ShowBorders = False
        Me.SBReportActivityLog.ShowCloseIcon = False
        Me.SBReportActivityLog.ShowIcon = True
        Me.SBReportActivityLog.ShowShadows = True
        Me.SBReportActivityLog.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBReportActivityLog.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBReportActivityLog.SuccessOptions.ActionBorderRadius = 1
        Me.SBReportActivityLog.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBReportActivityLog.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBReportActivityLog.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.SBReportActivityLog.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.SBReportActivityLog.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SBReportActivityLog.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBReportActivityLog.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.SBReportActivityLog.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.SBReportActivityLog.SuccessOptions.IconLeftMargin = 12
        Me.SBReportActivityLog.ViewsMargin = 7
        Me.SBReportActivityLog.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBReportActivityLog.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBReportActivityLog.WarningOptions.ActionBorderRadius = 1
        Me.SBReportActivityLog.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBReportActivityLog.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBReportActivityLog.WarningOptions.BackColor = System.Drawing.Color.White
        Me.SBReportActivityLog.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.SBReportActivityLog.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.SBReportActivityLog.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBReportActivityLog.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.SBReportActivityLog.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.SBReportActivityLog.WarningOptions.IconLeftMargin = 12
        Me.SBReportActivityLog.ZoomCloseIcon = True
        '
        'ActivityLogReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Controls.Add(Me.TXTUsername)
        Me.Controls.Add(Me.CBFilterOpt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTNReset)
        Me.Controls.Add(Me.BTNFilter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPFrom)
        Me.Controls.Add(Me.DTPTo)
        Me.Controls.Add(Me.RVActivityLog)
        Me.Name = "ActivityLogReport"
        Me.Size = New System.Drawing.Size(630, 422)
        CType(Me.tblactivitylogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RVActivityLog As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblactivitylogBindingSource As BindingSource
    Friend WithEvents clinicsmsdbDataSet As clinicsmsdbDataSet
    Friend WithEvents tblactivitylogTableAdapter As clinicsmsdbDataSetTableAdapters.tblactivitylogTableAdapter
    Friend WithEvents BTNReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNFilter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DTPTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents CBFilterOpt As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SBReportActivityLog As Bunifu.UI.WinForms.BunifuSnackbar
End Class
