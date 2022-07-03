<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMAdmin
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
        Me.CTRLMinimize = New Guna.UI.WinForms.GunaControlBox()
        Me.CTRLMaximize = New Guna.UI.WinForms.GunaControlBox()
        Me.CTRLClose = New Guna.UI.WinForms.GunaControlBox()
        Me.PNLMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.PNLAccount = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.BTNLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNEditaccount = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNMyaccount = New Guna.UI2.WinForms.Guna2Button()
        Me.PNLDisplay = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNReports = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNSystemsettings = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNAdmit = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNStocks = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNHome = New Guna.UI2.WinForms.Guna2Button()
        Me.SEPMenu = New Guna.UI2.WinForms.Guna2Separator()
        Me.BTNAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.PNLMain.SuspendLayout()
        Me.PNLAccount.SuspendLayout()
        Me.SuspendLayout()
        '
        'CTRLMinimize
        '
        Me.CTRLMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTRLMinimize.AnimationHoverSpeed = 0.07!
        Me.CTRLMinimize.AnimationSpeed = 0.03!
        Me.CTRLMinimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.CTRLMinimize.IconColor = System.Drawing.SystemColors.Control
        Me.CTRLMinimize.IconSize = 20.0!
        Me.CTRLMinimize.Location = New System.Drawing.Point(965, 0)
        Me.CTRLMinimize.Name = "CTRLMinimize"
        Me.CTRLMinimize.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.CTRLMinimize.OnHoverIconColor = System.Drawing.Color.White
        Me.CTRLMinimize.OnPressedColor = System.Drawing.Color.Black
        Me.CTRLMinimize.Size = New System.Drawing.Size(45, 29)
        Me.CTRLMinimize.TabIndex = 6
        Me.CTRLMinimize.TabStop = False
        '
        'CTRLMaximize
        '
        Me.CTRLMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTRLMaximize.AnimationHoverSpeed = 0.07!
        Me.CTRLMaximize.AnimationSpeed = 0.03!
        Me.CTRLMaximize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox
        Me.CTRLMaximize.Enabled = False
        Me.CTRLMaximize.IconColor = System.Drawing.SystemColors.Control
        Me.CTRLMaximize.IconSize = 20.0!
        Me.CTRLMaximize.Location = New System.Drawing.Point(1010, 0)
        Me.CTRLMaximize.Name = "CTRLMaximize"
        Me.CTRLMaximize.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.CTRLMaximize.OnHoverIconColor = System.Drawing.Color.White
        Me.CTRLMaximize.OnPressedColor = System.Drawing.Color.Black
        Me.CTRLMaximize.Size = New System.Drawing.Size(45, 29)
        Me.CTRLMaximize.TabIndex = 5
        Me.CTRLMaximize.TabStop = False
        '
        'CTRLClose
        '
        Me.CTRLClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTRLClose.AnimationHoverSpeed = 0.07!
        Me.CTRLClose.AnimationSpeed = 0.03!
        Me.CTRLClose.IconColor = System.Drawing.SystemColors.Control
        Me.CTRLClose.IconSize = 20.0!
        Me.CTRLClose.Location = New System.Drawing.Point(1055, 0)
        Me.CTRLClose.Name = "CTRLClose"
        Me.CTRLClose.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.CTRLClose.OnHoverIconColor = System.Drawing.Color.White
        Me.CTRLClose.OnPressedColor = System.Drawing.Color.Black
        Me.CTRLClose.Size = New System.Drawing.Size(45, 29)
        Me.CTRLClose.TabIndex = 4
        Me.CTRLClose.TabStop = False
        '
        'PNLMain
        '
        Me.PNLMain.BackColor = System.Drawing.Color.Transparent
        Me.PNLMain.Controls.Add(Me.PNLAccount)
        Me.PNLMain.Controls.Add(Me.PNLDisplay)
        Me.PNLMain.Controls.Add(Me.BTNReports)
        Me.PNLMain.Controls.Add(Me.BTNSystemsettings)
        Me.PNLMain.Controls.Add(Me.BTNAdmit)
        Me.PNLMain.Controls.Add(Me.BTNStocks)
        Me.PNLMain.Controls.Add(Me.BTNHome)
        Me.PNLMain.Controls.Add(Me.SEPMenu)
        Me.PNLMain.Controls.Add(Me.BTNAccount)
        Me.PNLMain.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PNLMain.Location = New System.Drawing.Point(81, 34)
        Me.PNLMain.Name = "PNLMain"
        Me.PNLMain.ShadowDecoration.Parent = Me.PNLMain
        Me.PNLMain.Size = New System.Drawing.Size(1019, 666)
        Me.PNLMain.TabIndex = 7
        '
        'PNLAccount
        '
        Me.PNLAccount.BackColor = System.Drawing.Color.Transparent
        Me.PNLAccount.Controls.Add(Me.BTNLogout)
        Me.PNLAccount.Controls.Add(Me.BTNEditaccount)
        Me.PNLAccount.Controls.Add(Me.BTNMyaccount)
        Me.PNLAccount.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.PNLAccount.Location = New System.Drawing.Point(9, 62)
        Me.PNLAccount.Name = "PNLAccount"
        Me.PNLAccount.Radius = 7
        Me.PNLAccount.ShadowColor = System.Drawing.Color.Black
        Me.PNLAccount.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.PNLAccount.Size = New System.Drawing.Size(205, 233)
        Me.PNLAccount.TabIndex = 6
        Me.PNLAccount.Visible = False
        '
        'BTNLogout
        '
        Me.BTNLogout.Animated = True
        Me.BTNLogout.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNLogout.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNLogout.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNLogout.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNLogout.CheckedState.Parent = Me.BTNLogout
        Me.BTNLogout.CustomImages.Parent = Me.BTNLogout
        Me.BTNLogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BTNLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNLogout.ForeColor = System.Drawing.Color.White
        Me.BTNLogout.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNLogout.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNLogout.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNLogout.HoverState.Parent = Me.BTNLogout
        Me.BTNLogout.Location = New System.Drawing.Point(1, 139)
        Me.BTNLogout.Name = "BTNLogout"
        Me.BTNLogout.ShadowDecoration.Parent = Me.BTNLogout
        Me.BTNLogout.Size = New System.Drawing.Size(197, 53)
        Me.BTNLogout.TabIndex = 4
        Me.BTNLogout.Text = "Log out "
        '
        'BTNEditaccount
        '
        Me.BTNEditaccount.Animated = True
        Me.BTNEditaccount.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNEditaccount.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNEditaccount.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNEditaccount.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNEditaccount.CheckedState.Parent = Me.BTNEditaccount
        Me.BTNEditaccount.CustomImages.Parent = Me.BTNEditaccount
        Me.BTNEditaccount.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BTNEditaccount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNEditaccount.ForeColor = System.Drawing.Color.White
        Me.BTNEditaccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNEditaccount.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNEditaccount.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNEditaccount.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNEditaccount.HoverState.Parent = Me.BTNEditaccount
        Me.BTNEditaccount.Location = New System.Drawing.Point(1, 86)
        Me.BTNEditaccount.Name = "BTNEditaccount"
        Me.BTNEditaccount.ShadowDecoration.Parent = Me.BTNEditaccount
        Me.BTNEditaccount.Size = New System.Drawing.Size(197, 53)
        Me.BTNEditaccount.TabIndex = 4
        Me.BTNEditaccount.Text = "Edit account"
        '
        'BTNMyaccount
        '
        Me.BTNMyaccount.Animated = True
        Me.BTNMyaccount.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNMyaccount.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNMyaccount.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNMyaccount.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNMyaccount.CheckedState.Parent = Me.BTNMyaccount
        Me.BTNMyaccount.CustomImages.Parent = Me.BTNMyaccount
        Me.BTNMyaccount.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BTNMyaccount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNMyaccount.ForeColor = System.Drawing.Color.White
        Me.BTNMyaccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNMyaccount.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNMyaccount.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNMyaccount.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNMyaccount.HoverState.Parent = Me.BTNMyaccount
        Me.BTNMyaccount.Location = New System.Drawing.Point(1, 34)
        Me.BTNMyaccount.Name = "BTNMyaccount"
        Me.BTNMyaccount.ShadowDecoration.Parent = Me.BTNMyaccount
        Me.BTNMyaccount.Size = New System.Drawing.Size(197, 53)
        Me.BTNMyaccount.TabIndex = 4
        Me.BTNMyaccount.Text = "My account"
        '
        'PNLDisplay
        '
        Me.PNLDisplay.Dock = System.Windows.Forms.DockStyle.Right
        Me.PNLDisplay.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PNLDisplay.Location = New System.Drawing.Point(223, 0)
        Me.PNLDisplay.Name = "PNLDisplay"
        Me.PNLDisplay.ShadowDecoration.Parent = Me.PNLDisplay
        Me.PNLDisplay.Size = New System.Drawing.Size(796, 666)
        Me.PNLDisplay.TabIndex = 5
        '
        'BTNReports
        '
        Me.BTNReports.Animated = True
        Me.BTNReports.BackColor = System.Drawing.Color.Transparent
        Me.BTNReports.BorderRadius = 6
        Me.BTNReports.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNReports.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNReports.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNReports.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNReports.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNReports.CheckedState.Parent = Me.BTNReports
        Me.BTNReports.CustomImages.Parent = Me.BTNReports
        Me.BTNReports.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BTNReports.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNReports.ForeColor = System.Drawing.Color.White
        Me.BTNReports.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNReports.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNReports.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNReports.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNReports.HoverState.Parent = Me.BTNReports
        Me.BTNReports.Location = New System.Drawing.Point(13, 470)
        Me.BTNReports.Name = "BTNReports"
        Me.BTNReports.ShadowDecoration.Enabled = True
        Me.BTNReports.ShadowDecoration.Parent = Me.BTNReports
        Me.BTNReports.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNReports.Size = New System.Drawing.Size(197, 45)
        Me.BTNReports.TabIndex = 5
        Me.BTNReports.Text = "Reports"
        '
        'BTNSystemsettings
        '
        Me.BTNSystemsettings.Animated = True
        Me.BTNSystemsettings.BackColor = System.Drawing.Color.Transparent
        Me.BTNSystemsettings.BorderRadius = 6
        Me.BTNSystemsettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNSystemsettings.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSystemsettings.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSystemsettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSystemsettings.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNSystemsettings.CheckedState.Parent = Me.BTNSystemsettings
        Me.BTNSystemsettings.CustomImages.Parent = Me.BTNSystemsettings
        Me.BTNSystemsettings.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BTNSystemsettings.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNSystemsettings.ForeColor = System.Drawing.Color.White
        Me.BTNSystemsettings.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSystemsettings.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSystemsettings.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSystemsettings.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNSystemsettings.HoverState.Parent = Me.BTNSystemsettings
        Me.BTNSystemsettings.Location = New System.Drawing.Point(13, 409)
        Me.BTNSystemsettings.Name = "BTNSystemsettings"
        Me.BTNSystemsettings.ShadowDecoration.Enabled = True
        Me.BTNSystemsettings.ShadowDecoration.Parent = Me.BTNSystemsettings
        Me.BTNSystemsettings.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNSystemsettings.Size = New System.Drawing.Size(197, 45)
        Me.BTNSystemsettings.TabIndex = 4
        Me.BTNSystemsettings.Text = "College"
        '
        'BTNAdmit
        '
        Me.BTNAdmit.Animated = True
        Me.BTNAdmit.BackColor = System.Drawing.Color.Transparent
        Me.BTNAdmit.BorderRadius = 6
        Me.BTNAdmit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNAdmit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdmit.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdmit.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdmit.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAdmit.CheckedState.Parent = Me.BTNAdmit
        Me.BTNAdmit.CustomImages.Parent = Me.BTNAdmit
        Me.BTNAdmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BTNAdmit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNAdmit.ForeColor = System.Drawing.Color.White
        Me.BTNAdmit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdmit.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdmit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAdmit.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAdmit.HoverState.Parent = Me.BTNAdmit
        Me.BTNAdmit.Location = New System.Drawing.Point(13, 350)
        Me.BTNAdmit.Name = "BTNAdmit"
        Me.BTNAdmit.ShadowDecoration.Enabled = True
        Me.BTNAdmit.ShadowDecoration.Parent = Me.BTNAdmit
        Me.BTNAdmit.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNAdmit.Size = New System.Drawing.Size(197, 45)
        Me.BTNAdmit.TabIndex = 4
        Me.BTNAdmit.Text = "Admit"
        '
        'BTNStocks
        '
        Me.BTNStocks.Animated = True
        Me.BTNStocks.BackColor = System.Drawing.Color.Transparent
        Me.BTNStocks.BorderRadius = 6
        Me.BTNStocks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNStocks.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNStocks.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNStocks.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNStocks.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNStocks.CheckedState.Parent = Me.BTNStocks
        Me.BTNStocks.CustomImages.Parent = Me.BTNStocks
        Me.BTNStocks.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BTNStocks.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNStocks.ForeColor = System.Drawing.Color.White
        Me.BTNStocks.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNStocks.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNStocks.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNStocks.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNStocks.HoverState.Parent = Me.BTNStocks
        Me.BTNStocks.Location = New System.Drawing.Point(13, 291)
        Me.BTNStocks.Name = "BTNStocks"
        Me.BTNStocks.ShadowDecoration.Enabled = True
        Me.BTNStocks.ShadowDecoration.Parent = Me.BTNStocks
        Me.BTNStocks.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNStocks.Size = New System.Drawing.Size(197, 45)
        Me.BTNStocks.TabIndex = 4
        Me.BTNStocks.Text = "Stocks"
        '
        'BTNHome
        '
        Me.BTNHome.Animated = True
        Me.BTNHome.BackColor = System.Drawing.Color.Transparent
        Me.BTNHome.BorderRadius = 6
        Me.BTNHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNHome.Checked = True
        Me.BTNHome.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNHome.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNHome.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNHome.CheckedState.Parent = Me.BTNHome
        Me.BTNHome.CustomImages.Parent = Me.BTNHome
        Me.BTNHome.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BTNHome.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNHome.ForeColor = System.Drawing.Color.White
        Me.BTNHome.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNHome.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNHome.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNHome.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNHome.HoverState.Parent = Me.BTNHome
        Me.BTNHome.Location = New System.Drawing.Point(13, 232)
        Me.BTNHome.Name = "BTNHome"
        Me.BTNHome.ShadowDecoration.Enabled = True
        Me.BTNHome.ShadowDecoration.Parent = Me.BTNHome
        Me.BTNHome.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNHome.Size = New System.Drawing.Size(197, 45)
        Me.BTNHome.TabIndex = 4
        Me.BTNHome.Text = "Home"
        '
        'SEPMenu
        '
        Me.SEPMenu.Location = New System.Drawing.Point(0, 51)
        Me.SEPMenu.Name = "SEPMenu"
        Me.SEPMenu.Size = New System.Drawing.Size(223, 5)
        Me.SEPMenu.TabIndex = 3
        '
        'BTNAccount
        '
        Me.BTNAccount.CheckedState.Parent = Me.BTNAccount
        Me.BTNAccount.CustomImages.Parent = Me.BTNAccount
        Me.BTNAccount.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNAccount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNAccount.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAccount.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNAccount.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAccount.HoverState.Image = Global.Clinic.My.Resources.Resources.dropdown_outlined
        Me.BTNAccount.HoverState.Parent = Me.BTNAccount
        Me.BTNAccount.Image = Global.Clinic.My.Resources.Resources.dropdown_filled
        Me.BTNAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BTNAccount.Location = New System.Drawing.Point(0, 0)
        Me.BTNAccount.Name = "BTNAccount"
        Me.BTNAccount.ShadowDecoration.Parent = Me.BTNAccount
        Me.BTNAccount.Size = New System.Drawing.Size(223, 56)
        Me.BTNAccount.TabIndex = 1
        Me.BTNAccount.Tag = "close"
        Me.BTNAccount.Text = "Hi, Admin"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(3, 5)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(114, 23)
        Me.GunaLabel3.TabIndex = 8
        Me.GunaLabel3.Text = "Administrator"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FRMAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.PNLMain)
        Me.Controls.Add(Me.CTRLMinimize)
        Me.Controls.Add(Me.CTRLMaximize)
        Me.Controls.Add(Me.CTRLClose)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PNLMain.ResumeLayout(False)
        Me.PNLAccount.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CTRLMinimize As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents CTRLMaximize As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents CTRLClose As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents PNLMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SEPMenu As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents BTNAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNAdmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNStocks As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNSystemsettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PNLDisplay As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PNLAccount As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents BTNLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNEditaccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNMyaccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNReports As Guna.UI2.WinForms.Guna2Button
End Class
