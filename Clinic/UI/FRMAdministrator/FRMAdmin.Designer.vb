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
        Me.components = New System.ComponentModel.Container()
        Me.CTRLMinimize = New Guna.UI.WinForms.GunaControlBox()
        Me.CTRLClose = New Guna.UI.WinForms.GunaControlBox()
        Me.PNLMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.LBLName = New Guna.UI.WinForms.GunaLabel()
        Me.LBLUserType = New Guna.UI.WinForms.GunaLabel()
        Me.PNLDisplay = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNManageuseraccount = New Guna.UI2.WinForms.Guna2Button()
        Me.SEPMenu = New Guna.UI2.WinForms.Guna2Separator()
        Me.BTNHome = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNAdmit = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNStocks = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNTransaction = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNStudents = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNSystemsettings = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNReports = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.TIPNormalcolor = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.DRAGForm = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.BunifuShapes1 = New Bunifu.UI.WinForms.BunifuShapes()
        Me.PNLMain.SuspendLayout()
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
        Me.CTRLMinimize.Location = New System.Drawing.Point(929, 0)
        Me.CTRLMinimize.Name = "CTRLMinimize"
        Me.CTRLMinimize.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.CTRLMinimize.OnHoverIconColor = System.Drawing.Color.White
        Me.CTRLMinimize.OnPressedColor = System.Drawing.Color.Black
        Me.CTRLMinimize.Size = New System.Drawing.Size(45, 35)
        Me.CTRLMinimize.TabIndex = 6
        Me.CTRLMinimize.TabStop = False
        Me.TIPNormalcolor.SetToolTip(Me.CTRLMinimize, "Click to minimize program")
        '
        'CTRLClose
        '
        Me.CTRLClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTRLClose.AnimationHoverSpeed = 0.07!
        Me.CTRLClose.AnimationSpeed = 0.03!
        Me.CTRLClose.IconColor = System.Drawing.SystemColors.Control
        Me.CTRLClose.IconSize = 20.0!
        Me.CTRLClose.Location = New System.Drawing.Point(974, 0)
        Me.CTRLClose.Name = "CTRLClose"
        Me.CTRLClose.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.CTRLClose.OnHoverIconColor = System.Drawing.Color.White
        Me.CTRLClose.OnPressedColor = System.Drawing.Color.Black
        Me.CTRLClose.Size = New System.Drawing.Size(45, 35)
        Me.CTRLClose.TabIndex = 4
        Me.CTRLClose.TabStop = False
        Me.TIPNormalcolor.SetToolTip(Me.CTRLClose, "Click to exit program")
        '
        'PNLMain
        '
        Me.PNLMain.BackColor = System.Drawing.Color.Transparent
        Me.PNLMain.Controls.Add(Me.BunifuShapes1)
        Me.PNLMain.Controls.Add(Me.LBLName)
        Me.PNLMain.Controls.Add(Me.LBLUserType)
        Me.PNLMain.Controls.Add(Me.PNLDisplay)
        Me.PNLMain.Controls.Add(Me.BTNManageuseraccount)
        Me.PNLMain.Controls.Add(Me.SEPMenu)
        Me.PNLMain.Controls.Add(Me.BTNHome)
        Me.PNLMain.Controls.Add(Me.BTNAdmit)
        Me.PNLMain.Controls.Add(Me.BTNStocks)
        Me.PNLMain.Controls.Add(Me.BTNTransaction)
        Me.PNLMain.Controls.Add(Me.BTNStudents)
        Me.PNLMain.Controls.Add(Me.BTNSystemsettings)
        Me.PNLMain.Controls.Add(Me.BTNLogout)
        Me.PNLMain.Controls.Add(Me.BTNReports)
        Me.PNLMain.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PNLMain.Location = New System.Drawing.Point(0, 34)
        Me.PNLMain.Name = "PNLMain"
        Me.PNLMain.ShadowDecoration.Parent = Me.PNLMain
        Me.PNLMain.Size = New System.Drawing.Size(1019, 666)
        Me.PNLMain.TabIndex = 7
        '
        'LBLName
        '
        Me.LBLName.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLName.Location = New System.Drawing.Point(0, 58)
        Me.LBLName.Name = "LBLName"
        Me.LBLName.Size = New System.Drawing.Size(223, 23)
        Me.LBLName.TabIndex = 8
        Me.LBLName.Text = "Pangalan Dito"
        Me.LBLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TIPNormalcolor.SetToolTip(Me.LBLName, "Admin name")
        '
        'LBLUserType
        '
        Me.LBLUserType.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUserType.Location = New System.Drawing.Point(0, 34)
        Me.LBLUserType.Name = "LBLUserType"
        Me.LBLUserType.Size = New System.Drawing.Size(223, 28)
        Me.LBLUserType.TabIndex = 0
        Me.LBLUserType.Text = "Hello, Admin"
        Me.LBLUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TIPNormalcolor.SetToolTip(Me.LBLUserType, "Hello Admin!")
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
        'BTNManageuseraccount
        '
        Me.BTNManageuseraccount.Animated = True
        Me.BTNManageuseraccount.BackColor = System.Drawing.Color.Transparent
        Me.BTNManageuseraccount.BorderColor = System.Drawing.Color.Transparent
        Me.BTNManageuseraccount.BorderRadius = 1
        Me.BTNManageuseraccount.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNManageuseraccount.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNManageuseraccount.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNManageuseraccount.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNManageuseraccount.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNManageuseraccount.CheckedState.Parent = Me.BTNManageuseraccount
        Me.BTNManageuseraccount.CustomImages.CheckedImage = Global.Clinic.My.Resources.Resources.user_account_active
        Me.BTNManageuseraccount.CustomImages.Image = Global.Clinic.My.Resources.Resources.user_account
        Me.BTNManageuseraccount.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNManageuseraccount.CustomImages.ImageSize = New System.Drawing.Size(18, 18)
        Me.BTNManageuseraccount.CustomImages.Parent = Me.BTNManageuseraccount
        Me.BTNManageuseraccount.FillColor = System.Drawing.Color.Transparent
        Me.BTNManageuseraccount.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNManageuseraccount.ForeColor = System.Drawing.Color.White
        Me.BTNManageuseraccount.HoverState.Parent = Me.BTNManageuseraccount
        Me.BTNManageuseraccount.Location = New System.Drawing.Point(24, 217)
        Me.BTNManageuseraccount.Name = "BTNManageuseraccount"
        Me.BTNManageuseraccount.ShadowDecoration.BorderRadius = 0
        Me.BTNManageuseraccount.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.BTNManageuseraccount.ShadowDecoration.Depth = 0
        Me.BTNManageuseraccount.ShadowDecoration.Parent = Me.BTNManageuseraccount
        Me.BTNManageuseraccount.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNManageuseraccount.Size = New System.Drawing.Size(175, 45)
        Me.BTNManageuseraccount.TabIndex = 7
        Me.BTNManageuseraccount.Text = "Manage User Account"
        Me.BTNManageuseraccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNManageuseraccount.TextOffset = New System.Drawing.Point(30, 0)
        Me.TIPNormalcolor.SetToolTip(Me.BTNManageuseraccount, "Click to dispalay account panel")
        '
        'SEPMenu
        '
        Me.SEPMenu.Location = New System.Drawing.Point(0, 84)
        Me.SEPMenu.Name = "SEPMenu"
        Me.SEPMenu.Size = New System.Drawing.Size(223, 5)
        Me.SEPMenu.TabIndex = 3
        '
        'BTNHome
        '
        Me.BTNHome.Animated = True
        Me.BTNHome.BackColor = System.Drawing.Color.Transparent
        Me.BTNHome.BorderColor = System.Drawing.Color.Transparent
        Me.BTNHome.BorderRadius = 1
        Me.BTNHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNHome.Checked = True
        Me.BTNHome.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNHome.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNHome.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNHome.CheckedState.Parent = Me.BTNHome
        Me.BTNHome.CustomImages.CheckedImage = Global.Clinic.My.Resources.Resources.dashboard_active
        Me.BTNHome.CustomImages.Image = Global.Clinic.My.Resources.Resources.dashboard
        Me.BTNHome.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNHome.CustomImages.ImageSize = New System.Drawing.Size(18, 18)
        Me.BTNHome.CustomImages.Parent = Me.BTNHome
        Me.BTNHome.FillColor = System.Drawing.Color.Transparent
        Me.BTNHome.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHome.ForeColor = System.Drawing.Color.White
        Me.BTNHome.HoverState.Parent = Me.BTNHome
        Me.BTNHome.Location = New System.Drawing.Point(24, 115)
        Me.BTNHome.Name = "BTNHome"
        Me.BTNHome.ShadowDecoration.BorderRadius = 0
        Me.BTNHome.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.BTNHome.ShadowDecoration.Depth = 0
        Me.BTNHome.ShadowDecoration.Parent = Me.BTNHome
        Me.BTNHome.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNHome.Size = New System.Drawing.Size(175, 45)
        Me.BTNHome.TabIndex = 4
        Me.BTNHome.Text = "Home"
        Me.BTNHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNHome.TextOffset = New System.Drawing.Point(30, 0)
        Me.TIPNormalcolor.SetToolTip(Me.BTNHome, "Click to display home panel")
        '
        'BTNAdmit
        '
        Me.BTNAdmit.Animated = True
        Me.BTNAdmit.BackColor = System.Drawing.Color.Transparent
        Me.BTNAdmit.BorderColor = System.Drawing.Color.Transparent
        Me.BTNAdmit.BorderRadius = 1
        Me.BTNAdmit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNAdmit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNAdmit.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNAdmit.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNAdmit.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNAdmit.CheckedState.Parent = Me.BTNAdmit
        Me.BTNAdmit.CustomImages.CheckedImage = Global.Clinic.My.Resources.Resources.admit_active
        Me.BTNAdmit.CustomImages.Image = Global.Clinic.My.Resources.Resources.admit
        Me.BTNAdmit.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNAdmit.CustomImages.ImageSize = New System.Drawing.Size(18, 18)
        Me.BTNAdmit.CustomImages.Parent = Me.BTNAdmit
        Me.BTNAdmit.FillColor = System.Drawing.Color.Transparent
        Me.BTNAdmit.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAdmit.ForeColor = System.Drawing.Color.White
        Me.BTNAdmit.HoverState.Parent = Me.BTNAdmit
        Me.BTNAdmit.Location = New System.Drawing.Point(24, 166)
        Me.BTNAdmit.Name = "BTNAdmit"
        Me.BTNAdmit.ShadowDecoration.BorderRadius = 0
        Me.BTNAdmit.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.BTNAdmit.ShadowDecoration.Depth = 0
        Me.BTNAdmit.ShadowDecoration.Parent = Me.BTNAdmit
        Me.BTNAdmit.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNAdmit.Size = New System.Drawing.Size(175, 45)
        Me.BTNAdmit.TabIndex = 4
        Me.BTNAdmit.Text = "Admit"
        Me.BTNAdmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNAdmit.TextOffset = New System.Drawing.Point(30, 0)
        Me.TIPNormalcolor.SetToolTip(Me.BTNAdmit, "Click to display admit panel")
        '
        'BTNStocks
        '
        Me.BTNStocks.Animated = True
        Me.BTNStocks.BackColor = System.Drawing.Color.Transparent
        Me.BTNStocks.BorderColor = System.Drawing.Color.Transparent
        Me.BTNStocks.BorderRadius = 1
        Me.BTNStocks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNStocks.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNStocks.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNStocks.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNStocks.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNStocks.CheckedState.Parent = Me.BTNStocks
        Me.BTNStocks.CustomImages.CheckedImage = Global.Clinic.My.Resources.Resources.stock_active
        Me.BTNStocks.CustomImages.Image = Global.Clinic.My.Resources.Resources.stock
        Me.BTNStocks.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNStocks.CustomImages.ImageSize = New System.Drawing.Size(18, 18)
        Me.BTNStocks.CustomImages.Parent = Me.BTNStocks
        Me.BTNStocks.FillColor = System.Drawing.Color.Transparent
        Me.BTNStocks.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNStocks.ForeColor = System.Drawing.Color.White
        Me.BTNStocks.HoverState.Parent = Me.BTNStocks
        Me.BTNStocks.Location = New System.Drawing.Point(24, 319)
        Me.BTNStocks.Name = "BTNStocks"
        Me.BTNStocks.ShadowDecoration.BorderRadius = 0
        Me.BTNStocks.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.BTNStocks.ShadowDecoration.Depth = 0
        Me.BTNStocks.ShadowDecoration.Parent = Me.BTNStocks
        Me.BTNStocks.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNStocks.Size = New System.Drawing.Size(175, 45)
        Me.BTNStocks.TabIndex = 4
        Me.BTNStocks.Text = "Stocks"
        Me.BTNStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNStocks.TextOffset = New System.Drawing.Point(30, 0)
        Me.TIPNormalcolor.SetToolTip(Me.BTNStocks, "Click to display stocks panel")
        '
        'BTNTransaction
        '
        Me.BTNTransaction.Animated = True
        Me.BTNTransaction.BackColor = System.Drawing.Color.Transparent
        Me.BTNTransaction.BorderColor = System.Drawing.Color.Transparent
        Me.BTNTransaction.BorderRadius = 1
        Me.BTNTransaction.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNTransaction.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNTransaction.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNTransaction.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNTransaction.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNTransaction.CheckedState.Parent = Me.BTNTransaction
        Me.BTNTransaction.CustomImages.CheckedImage = Global.Clinic.My.Resources.Resources.trans_active
        Me.BTNTransaction.CustomImages.Image = Global.Clinic.My.Resources.Resources.trans
        Me.BTNTransaction.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNTransaction.CustomImages.ImageSize = New System.Drawing.Size(18, 18)
        Me.BTNTransaction.CustomImages.Parent = Me.BTNTransaction
        Me.BTNTransaction.FillColor = System.Drawing.Color.Transparent
        Me.BTNTransaction.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTransaction.ForeColor = System.Drawing.Color.White
        Me.BTNTransaction.HoverState.Parent = Me.BTNTransaction
        Me.BTNTransaction.Location = New System.Drawing.Point(24, 370)
        Me.BTNTransaction.Name = "BTNTransaction"
        Me.BTNTransaction.ShadowDecoration.BorderRadius = 0
        Me.BTNTransaction.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.BTNTransaction.ShadowDecoration.Depth = 0
        Me.BTNTransaction.ShadowDecoration.Parent = Me.BTNTransaction
        Me.BTNTransaction.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNTransaction.Size = New System.Drawing.Size(175, 45)
        Me.BTNTransaction.TabIndex = 5
        Me.BTNTransaction.Text = "Transaction"
        Me.BTNTransaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNTransaction.TextOffset = New System.Drawing.Point(30, 0)
        Me.TIPNormalcolor.SetToolTip(Me.BTNTransaction, "Click to display transaction panel")
        '
        'BTNStudents
        '
        Me.BTNStudents.Animated = True
        Me.BTNStudents.BackColor = System.Drawing.Color.Transparent
        Me.BTNStudents.BorderColor = System.Drawing.Color.Transparent
        Me.BTNStudents.BorderRadius = 1
        Me.BTNStudents.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNStudents.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNStudents.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNStudents.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNStudents.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNStudents.CheckedState.Parent = Me.BTNStudents
        Me.BTNStudents.CustomImages.CheckedImage = Global.Clinic.My.Resources.Resources.students
        Me.BTNStudents.CustomImages.Image = Global.Clinic.My.Resources.Resources.students_active1
        Me.BTNStudents.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNStudents.CustomImages.ImageSize = New System.Drawing.Size(18, 18)
        Me.BTNStudents.CustomImages.Parent = Me.BTNStudents
        Me.BTNStudents.FillColor = System.Drawing.Color.Transparent
        Me.BTNStudents.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNStudents.ForeColor = System.Drawing.Color.White
        Me.BTNStudents.HoverState.Parent = Me.BTNStudents
        Me.BTNStudents.Location = New System.Drawing.Point(24, 268)
        Me.BTNStudents.Name = "BTNStudents"
        Me.BTNStudents.ShadowDecoration.BorderRadius = 0
        Me.BTNStudents.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.BTNStudents.ShadowDecoration.Depth = 0
        Me.BTNStudents.ShadowDecoration.Parent = Me.BTNStudents
        Me.BTNStudents.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNStudents.Size = New System.Drawing.Size(175, 45)
        Me.BTNStudents.TabIndex = 5
        Me.BTNStudents.Text = "Students"
        Me.BTNStudents.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNStudents.TextOffset = New System.Drawing.Point(30, 0)
        Me.TIPNormalcolor.SetToolTip(Me.BTNStudents, "Click to display student panel")
        '
        'BTNSystemsettings
        '
        Me.BTNSystemsettings.Animated = True
        Me.BTNSystemsettings.BackColor = System.Drawing.Color.Transparent
        Me.BTNSystemsettings.BorderColor = System.Drawing.Color.Transparent
        Me.BTNSystemsettings.BorderRadius = 1
        Me.BTNSystemsettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNSystemsettings.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNSystemsettings.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNSystemsettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNSystemsettings.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNSystemsettings.CheckedState.Parent = Me.BTNSystemsettings
        Me.BTNSystemsettings.CustomImages.CheckedImage = Global.Clinic.My.Resources.Resources.settings_active
        Me.BTNSystemsettings.CustomImages.Image = Global.Clinic.My.Resources.Resources.settings
        Me.BTNSystemsettings.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNSystemsettings.CustomImages.ImageSize = New System.Drawing.Size(18, 18)
        Me.BTNSystemsettings.CustomImages.Parent = Me.BTNSystemsettings
        Me.BTNSystemsettings.FillColor = System.Drawing.Color.Transparent
        Me.BTNSystemsettings.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSystemsettings.ForeColor = System.Drawing.Color.White
        Me.BTNSystemsettings.HoverState.Parent = Me.BTNSystemsettings
        Me.BTNSystemsettings.Location = New System.Drawing.Point(24, 421)
        Me.BTNSystemsettings.Name = "BTNSystemsettings"
        Me.BTNSystemsettings.ShadowDecoration.BorderRadius = 0
        Me.BTNSystemsettings.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.BTNSystemsettings.ShadowDecoration.Depth = 0
        Me.BTNSystemsettings.ShadowDecoration.Parent = Me.BTNSystemsettings
        Me.BTNSystemsettings.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNSystemsettings.Size = New System.Drawing.Size(175, 45)
        Me.BTNSystemsettings.TabIndex = 5
        Me.BTNSystemsettings.Text = "System Setting"
        Me.BTNSystemsettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNSystemsettings.TextOffset = New System.Drawing.Point(30, 0)
        Me.TIPNormalcolor.SetToolTip(Me.BTNSystemsettings, "Click to display settings")
        '
        'BTNLogout
        '
        Me.BTNLogout.Animated = True
        Me.BTNLogout.BackColor = System.Drawing.Color.Transparent
        Me.BTNLogout.BorderRadius = 1
        Me.BTNLogout.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNLogout.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNLogout.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNLogout.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNLogout.CheckedState.Parent = Me.BTNLogout
        Me.BTNLogout.CustomImages.Parent = Me.BTNLogout
        Me.BTNLogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BTNLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNLogout.ForeColor = System.Drawing.Color.White
        Me.BTNLogout.HoverState.Parent = Me.BTNLogout
        Me.BTNLogout.Location = New System.Drawing.Point(24, 612)
        Me.BTNLogout.Name = "BTNLogout"
        Me.BTNLogout.ShadowDecoration.Enabled = True
        Me.BTNLogout.ShadowDecoration.Parent = Me.BTNLogout
        Me.BTNLogout.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNLogout.Size = New System.Drawing.Size(175, 45)
        Me.BTNLogout.TabIndex = 5
        Me.BTNLogout.Text = "Log out"
        Me.TIPNormalcolor.SetToolTip(Me.BTNLogout, "Click to log out account")
        '
        'BTNReports
        '
        Me.BTNReports.Animated = True
        Me.BTNReports.BackColor = System.Drawing.Color.Transparent
        Me.BTNReports.BorderColor = System.Drawing.Color.Transparent
        Me.BTNReports.BorderRadius = 1
        Me.BTNReports.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNReports.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNReports.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNReports.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNReports.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNReports.CheckedState.Parent = Me.BTNReports
        Me.BTNReports.CustomImages.CheckedImage = Global.Clinic.My.Resources.Resources.reports_active
        Me.BTNReports.CustomImages.Image = Global.Clinic.My.Resources.Resources.reports
        Me.BTNReports.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNReports.CustomImages.ImageSize = New System.Drawing.Size(18, 18)
        Me.BTNReports.CustomImages.Parent = Me.BTNReports
        Me.BTNReports.FillColor = System.Drawing.Color.Transparent
        Me.BTNReports.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNReports.ForeColor = System.Drawing.Color.White
        Me.BTNReports.HoverState.Parent = Me.BTNReports
        Me.BTNReports.Location = New System.Drawing.Point(24, 472)
        Me.BTNReports.Name = "BTNReports"
        Me.BTNReports.ShadowDecoration.BorderRadius = 0
        Me.BTNReports.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.BTNReports.ShadowDecoration.Depth = 0
        Me.BTNReports.ShadowDecoration.Parent = Me.BTNReports
        Me.BTNReports.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNReports.Size = New System.Drawing.Size(175, 45)
        Me.BTNReports.TabIndex = 5
        Me.BTNReports.Text = "Reports"
        Me.BTNReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNReports.TextOffset = New System.Drawing.Point(30, 0)
        Me.TIPNormalcolor.SetToolTip(Me.BTNReports, "Click to display reports")
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(3, 5)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(134, 19)
        Me.GunaLabel3.TabIndex = 8
        Me.GunaLabel3.Text = "Administrator/Nurse"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TIPNormalcolor
        '
        Me.TIPNormalcolor.AllowLinksHandling = True
        Me.TIPNormalcolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TIPNormalcolor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TIPNormalcolor.ForeColor = System.Drawing.SystemColors.Control
        Me.TIPNormalcolor.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'DRAGForm
        '
        Me.DRAGForm.TargetControl = Me
        '
        'BunifuShapes1
        '
        Me.BunifuShapes1.Angle = 0!
        Me.BunifuShapes1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuShapes1.BackgroundImage = Global.Clinic.My.Resources.Resources.nurse
        Me.BunifuShapes1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuShapes1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuShapes1.BorderThickness = 0
        Me.BunifuShapes1.FillColor = System.Drawing.Color.Transparent
        Me.BunifuShapes1.FillShape = True
        Me.BunifuShapes1.Location = New System.Drawing.Point(96, 11)
        Me.BunifuShapes1.Name = "BunifuShapes1"
        Me.BunifuShapes1.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle
        Me.BunifuShapes1.Sides = 5
        Me.BunifuShapes1.Size = New System.Drawing.Size(25, 25)
        Me.BunifuShapes1.TabIndex = 21
        Me.BunifuShapes1.Text = "BunifuShapes1"
        '
        'FRMAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1019, 700)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.PNLMain)
        Me.Controls.Add(Me.CTRLMinimize)
        Me.Controls.Add(Me.CTRLClose)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PNLMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CTRLMinimize As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents CTRLClose As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents PNLMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SEPMenu As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents BTNAdmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNStocks As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PNLDisplay As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BTNManageuseraccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNTransaction As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNStudents As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNSystemsettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TIPNormalcolor As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents LBLUserType As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LBLName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DRAGForm As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents BunifuShapes1 As Bunifu.UI.WinForms.BunifuShapes
End Class
