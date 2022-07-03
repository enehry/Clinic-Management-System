<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMLogin))
        Me.CTRLClose = New Guna.UI.WinForms.GunaControlBox()
        Me.CTRLMinimize = New Guna.UI.WinForms.GunaControlBox()
        Me.BTNLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.CHKShowpassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.LBLPassword = New Guna.UI.WinForms.GunaLabel()
        Me.LBLUsername = New Guna.UI.WinForms.GunaLabel()
        Me.TIPNormalcolor = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.TIPInvertedcolor = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.TXTUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DRAGForm = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.SBLogin = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.BunifuShapes1 = New Bunifu.UI.WinForms.BunifuShapes()
        Me.BunifuPanel1 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BunifuPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CTRLClose
        '
        Me.CTRLClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CTRLClose.AnimationHoverSpeed = 0.07!
        Me.CTRLClose.AnimationSpeed = 0.03!
        Me.CTRLClose.IconColor = System.Drawing.SystemColors.Control
        Me.CTRLClose.IconSize = 20.0!
        Me.CTRLClose.Location = New System.Drawing.Point(940, 3)
        Me.CTRLClose.Name = "CTRLClose"
        Me.CTRLClose.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.CTRLClose.OnHoverIconColor = System.Drawing.Color.White
        Me.CTRLClose.OnPressedColor = System.Drawing.Color.Black
        Me.CTRLClose.Size = New System.Drawing.Size(35, 29)
        Me.CTRLClose.TabIndex = 1
        Me.CTRLClose.TabStop = False
        Me.TIPNormalcolor.SetToolTip(Me.CTRLClose, "Close")
        '
        'CTRLMinimize
        '
        Me.CTRLMinimize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CTRLMinimize.AnimationHoverSpeed = 0.07!
        Me.CTRLMinimize.AnimationSpeed = 0.03!
        Me.CTRLMinimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.CTRLMinimize.IconColor = System.Drawing.SystemColors.Control
        Me.CTRLMinimize.IconSize = 20.0!
        Me.CTRLMinimize.Location = New System.Drawing.Point(905, 5)
        Me.CTRLMinimize.Name = "CTRLMinimize"
        Me.CTRLMinimize.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.CTRLMinimize.OnHoverIconColor = System.Drawing.Color.White
        Me.CTRLMinimize.OnPressedColor = System.Drawing.Color.Black
        Me.CTRLMinimize.Size = New System.Drawing.Size(35, 29)
        Me.CTRLMinimize.TabIndex = 3
        Me.CTRLMinimize.TabStop = False
        Me.TIPNormalcolor.SetToolTip(Me.CTRLMinimize, "Minimize")
        '
        'BTNLogin
        '
        Me.BTNLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNLogin.BackColor = System.Drawing.Color.Transparent
        Me.BTNLogin.BorderRadius = 1
        Me.BTNLogin.CheckedState.Parent = Me.BTNLogin
        Me.BTNLogin.CustomImages.Parent = Me.BTNLogin
        Me.BTNLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNLogin.ForeColor = System.Drawing.Color.Silver
        Me.BTNLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNLogin.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNLogin.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNLogin.HoverState.Parent = Me.BTNLogin
        Me.BTNLogin.Location = New System.Drawing.Point(829, 396)
        Me.BTNLogin.Name = "BTNLogin"
        Me.BTNLogin.ShadowDecoration.Enabled = True
        Me.BTNLogin.ShadowDecoration.Parent = Me.BTNLogin
        Me.BTNLogin.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNLogin.Size = New System.Drawing.Size(98, 40)
        Me.BTNLogin.TabIndex = 3
        Me.BTNLogin.Text = "Login"
        Me.TIPNormalcolor.SetToolTip(Me.BTNLogin, "Click to login")
        '
        'CHKShowpassword
        '
        Me.CHKShowpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CHKShowpassword.AutoSize = True
        Me.CHKShowpassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.CHKShowpassword.CheckedState.BorderRadius = 2
        Me.CHKShowpassword.CheckedState.BorderThickness = 1
        Me.CHKShowpassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CHKShowpassword.CheckMarkColor = System.Drawing.SystemColors.Control
        Me.CHKShowpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CHKShowpassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKShowpassword.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CHKShowpassword.Location = New System.Drawing.Point(697, 352)
        Me.CHKShowpassword.Name = "CHKShowpassword"
        Me.CHKShowpassword.Size = New System.Drawing.Size(105, 22)
        Me.CHKShowpassword.TabIndex = 2
        Me.CHKShowpassword.Text = "Show password"
        Me.CHKShowpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TIPInvertedcolor.SetToolTip(Me.CHKShowpassword, "Check to see your password")
        Me.CHKShowpassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.CHKShowpassword.UncheckedState.BorderRadius = 2
        Me.CHKShowpassword.UncheckedState.BorderThickness = 1
        Me.CHKShowpassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CHKShowpassword.UseCompatibleTextRendering = True
        Me.CHKShowpassword.UseVisualStyleBackColor = True
        '
        'LBLPassword
        '
        Me.LBLPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LBLPassword.AutoSize = True
        Me.LBLPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.LBLPassword.Location = New System.Drawing.Point(697, 277)
        Me.LBLPassword.Name = "LBLPassword"
        Me.LBLPassword.Size = New System.Drawing.Size(57, 15)
        Me.LBLPassword.TabIndex = 1
        Me.LBLPassword.Text = "Password"
        Me.LBLPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLUsername
        '
        Me.LBLUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LBLUsername.AutoSize = True
        Me.LBLUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUsername.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.LBLUsername.Location = New System.Drawing.Point(697, 203)
        Me.LBLUsername.Name = "LBLUsername"
        Me.LBLUsername.Size = New System.Drawing.Size(60, 15)
        Me.LBLUsername.TabIndex = 1
        Me.LBLUsername.Text = "Username"
        Me.LBLUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TIPNormalcolor
        '
        Me.TIPNormalcolor.AllowLinksHandling = True
        Me.TIPNormalcolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TIPNormalcolor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TIPNormalcolor.ForeColor = System.Drawing.SystemColors.Control
        Me.TIPNormalcolor.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'TIPInvertedcolor
        '
        Me.TIPInvertedcolor.AllowLinksHandling = True
        Me.TIPInvertedcolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TIPInvertedcolor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TIPInvertedcolor.ForeColor = System.Drawing.SystemColors.Control
        Me.TIPInvertedcolor.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'TXTUsername
        '
        Me.TXTUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXTUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TXTUsername.BorderRadius = 1
        Me.TXTUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTUsername.DefaultText = ""
        Me.TXTUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTUsername.DisabledState.Parent = Me.TXTUsername
        Me.TXTUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTUsername.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TXTUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTUsername.FocusedState.Parent = Me.TXTUsername
        Me.TXTUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.TXTUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTUsername.HoverState.Parent = Me.TXTUsername
        Me.TXTUsername.IconLeft = Global.Clinic.My.Resources.Resources.user
        Me.TXTUsername.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.TXTUsername.IconLeftSize = New System.Drawing.Size(13, 13)
        Me.TXTUsername.Location = New System.Drawing.Point(697, 223)
        Me.TXTUsername.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TXTUsername.Name = "TXTUsername"
        Me.TXTUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTUsername.PlaceholderText = ""
        Me.TXTUsername.SelectedText = ""
        Me.TXTUsername.ShadowDecoration.Parent = Me.TXTUsername
        Me.TXTUsername.Size = New System.Drawing.Size(230, 41)
        Me.TXTUsername.TabIndex = 0
        Me.TIPInvertedcolor.SetToolTip(Me.TXTUsername, "Input here your username")
        '
        'TXTPassword
        '
        Me.TXTPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXTPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TXTPassword.BorderRadius = 1
        Me.TXTPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTPassword.DefaultText = ""
        Me.TXTPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTPassword.DisabledState.Parent = Me.TXTPassword
        Me.TXTPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TXTPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTPassword.FocusedState.Parent = Me.TXTPassword
        Me.TXTPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TXTPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.TXTPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTPassword.HoverState.Parent = Me.TXTPassword
        Me.TXTPassword.IconLeft = Global.Clinic.My.Resources.Resources.padlock
        Me.TXTPassword.IconLeftOffset = New System.Drawing.Point(3, 0)
        Me.TXTPassword.IconLeftSize = New System.Drawing.Size(15, 15)
        Me.TXTPassword.Location = New System.Drawing.Point(697, 298)
        Me.TXTPassword.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TXTPassword.Name = "TXTPassword"
        Me.TXTPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPassword.PlaceholderText = ""
        Me.TXTPassword.SelectedText = ""
        Me.TXTPassword.ShadowDecoration.Parent = Me.TXTPassword
        Me.TXTPassword.Size = New System.Drawing.Size(230, 41)
        Me.TXTPassword.TabIndex = 1
        Me.TIPInvertedcolor.SetToolTip(Me.TXTPassword, "Input here your password")
        Me.TXTPassword.UseSystemPasswordChar = True
        '
        'DRAGForm
        '
        Me.DRAGForm.TargetControl = Me
        '
        'SBLogin
        '
        Me.SBLogin.AllowDragging = False
        Me.SBLogin.AllowMultipleViews = True
        Me.SBLogin.ClickToClose = True
        Me.SBLogin.DoubleClickToClose = True
        Me.SBLogin.DurationAfterIdle = 3000
        Me.SBLogin.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBLogin.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBLogin.ErrorOptions.ActionBorderRadius = 1
        Me.SBLogin.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBLogin.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBLogin.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.SBLogin.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.SBLogin.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.SBLogin.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBLogin.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.SBLogin.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.SBLogin.ErrorOptions.IconLeftMargin = 12
        Me.SBLogin.FadeCloseIcon = False
        Me.SBLogin.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.SBLogin.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBLogin.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBLogin.InformationOptions.ActionBorderRadius = 1
        Me.SBLogin.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBLogin.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBLogin.InformationOptions.BackColor = System.Drawing.Color.White
        Me.SBLogin.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.SBLogin.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBLogin.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBLogin.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.SBLogin.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.SBLogin.InformationOptions.IconLeftMargin = 12
        Me.SBLogin.Margin = 10
        Me.SBLogin.MaximumSize = New System.Drawing.Size(0, 0)
        Me.SBLogin.MaximumViews = 7
        Me.SBLogin.MessageRightMargin = 15
        Me.SBLogin.MinimumSize = New System.Drawing.Size(0, 0)
        Me.SBLogin.ShowBorders = False
        Me.SBLogin.ShowCloseIcon = False
        Me.SBLogin.ShowIcon = True
        Me.SBLogin.ShowShadows = True
        Me.SBLogin.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBLogin.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBLogin.SuccessOptions.ActionBorderRadius = 1
        Me.SBLogin.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBLogin.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBLogin.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.SBLogin.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.SBLogin.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SBLogin.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBLogin.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.SBLogin.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.SBLogin.SuccessOptions.IconLeftMargin = 12
        Me.SBLogin.ViewsMargin = 7
        Me.SBLogin.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBLogin.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBLogin.WarningOptions.ActionBorderRadius = 1
        Me.SBLogin.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SBLogin.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.SBLogin.WarningOptions.BackColor = System.Drawing.Color.White
        Me.SBLogin.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.SBLogin.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.SBLogin.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SBLogin.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.SBLogin.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.SBLogin.WarningOptions.IconLeftMargin = 12
        Me.SBLogin.ZoomCloseIcon = True
        '
        'BunifuShapes1
        '
        Me.BunifuShapes1.Angle = 0!
        Me.BunifuShapes1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuShapes1.BackgroundImage = Global.Clinic.My.Resources.Resources.profile_user
        Me.BunifuShapes1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuShapes1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuShapes1.BorderThickness = 2
        Me.BunifuShapes1.FillColor = System.Drawing.Color.Transparent
        Me.BunifuShapes1.FillShape = True
        Me.BunifuShapes1.Location = New System.Drawing.Point(791, 128)
        Me.BunifuShapes1.Name = "BunifuShapes1"
        Me.BunifuShapes1.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle
        Me.BunifuShapes1.Sides = 5
        Me.BunifuShapes1.Size = New System.Drawing.Size(36, 36)
        Me.BunifuShapes1.TabIndex = 5
        Me.BunifuShapes1.Text = "BunifuShapes1"
        '
        'BunifuPanel1
        '
        Me.BunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BunifuPanel1.BackgroundImage = CType(resources.GetObject("BunifuPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.BorderRadius = 3
        Me.BunifuPanel1.BorderThickness = 1
        Me.BunifuPanel1.Controls.Add(Me.BunifuLabel3)
        Me.BunifuPanel1.Controls.Add(Me.BunifuLabel2)
        Me.BunifuPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.BunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuPanel1.Name = "BunifuPanel1"
        Me.BunifuPanel1.ShowBorders = True
        Me.BunifuPanel1.Size = New System.Drawing.Size(638, 572)
        Me.BunifuPanel1.TabIndex = 4
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.AutoSize = False
        Me.BunifuLabel3.AutoSizeHeightOnly = True
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.ForeColor = System.Drawing.Color.Gray
        Me.BunifuLabel3.Location = New System.Drawing.Point(46, 74)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(547, 42)
        Me.BunifuLabel3.TabIndex = 3
        Me.BunifuLabel3.Text = "Where you can easily manage your stocks, Overall control over your medicine and a" &
    "ccurate information of your stock" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuLabel2.Location = New System.Drawing.Point(148, 43)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(342, 25)
        Me.BunifuLabel2.TabIndex = 2
        Me.BunifuLabel2.Text = "Welcome to Clinic Management System"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImage = Global.Clinic.My.Resources.Resources.bg_clinicsms
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(30, 148)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(570, 384)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'FRMLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(977, 572)
        Me.Controls.Add(Me.BunifuShapes1)
        Me.Controls.Add(Me.BunifuPanel1)
        Me.Controls.Add(Me.CTRLMinimize)
        Me.Controls.Add(Me.TXTUsername)
        Me.Controls.Add(Me.BTNLogin)
        Me.Controls.Add(Me.TXTPassword)
        Me.Controls.Add(Me.LBLUsername)
        Me.Controls.Add(Me.CHKShowpassword)
        Me.Controls.Add(Me.LBLPassword)
        Me.Controls.Add(Me.CTRLClose)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BunifuPanel1.ResumeLayout(False)
        Me.BunifuPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CTRLClose As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents CTRLMinimize As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents BTNLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CHKShowpassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents LBLPassword As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LBLUsername As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXTPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TIPNormalcolor As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents TIPInvertedcolor As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents DRAGForm As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents SBLogin As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents BunifuPanel1 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuShapes1 As Bunifu.UI.WinForms.BunifuShapes
End Class
