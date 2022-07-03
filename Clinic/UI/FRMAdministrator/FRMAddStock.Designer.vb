<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMAddStock
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
        Me.TXTStock = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLMedCode = New System.Windows.Forms.Label()
        Me.LBLMEDname = New System.Windows.Forms.Label()
        Me.BTNDecrement = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNIncrement = New Guna.UI2.WinForms.Guna2Button()
        Me.TblmedicineTableAdapter1 = New Clinic.clinicsmsdbDataSetTableAdapters.tblmedicineTableAdapter()
        Me.SuspendLayout()
        '
        'TXTStock
        '
        Me.TXTStock.Animated = True
        Me.TXTStock.BackColor = System.Drawing.Color.Transparent
        Me.TXTStock.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.TXTStock.BorderRadius = 1
        Me.TXTStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTStock.DefaultText = ""
        Me.TXTStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTStock.DisabledState.Parent = Me.TXTStock
        Me.TXTStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTStock.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TXTStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTStock.FocusedState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTStock.FocusedState.Parent = Me.TXTStock
        Me.TXTStock.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTStock.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TXTStock.HoverState.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTStock.HoverState.Parent = Me.TXTStock
        Me.TXTStock.Location = New System.Drawing.Point(83, 79)
        Me.TXTStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTStock.Name = "TXTStock"
        Me.TXTStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTStock.PlaceholderText = ""
        Me.TXTStock.SelectedText = ""
        Me.TXTStock.ShadowDecoration.Enabled = True
        Me.TXTStock.ShadowDecoration.Parent = Me.TXTStock
        Me.TXTStock.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TXTStock.Size = New System.Drawing.Size(93, 41)
        Me.TXTStock.TabIndex = 8
        Me.TXTStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTNCancel
        '
        Me.BTNCancel.Animated = True
        Me.BTNCancel.BackColor = System.Drawing.Color.Transparent
        Me.BTNCancel.BorderRadius = 1
        Me.BTNCancel.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNCancel.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNCancel.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNCancel.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNCancel.CheckedState.Parent = Me.BTNCancel
        Me.BTNCancel.CustomImages.Parent = Me.BTNCancel
        Me.BTNCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNCancel.ForeColor = System.Drawing.Color.White
        Me.BTNCancel.HoverState.Parent = Me.BTNCancel
        Me.BTNCancel.Location = New System.Drawing.Point(48, 184)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.ShadowDecoration.Enabled = True
        Me.BTNCancel.ShadowDecoration.Parent = Me.BTNCancel
        Me.BTNCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNCancel.Size = New System.Drawing.Size(70, 45)
        Me.BTNCancel.TabIndex = 9
        Me.BTNCancel.TabStop = False
        Me.BTNCancel.Text = "CANCEL"
        '
        'BTNSave
        '
        Me.BTNSave.Animated = True
        Me.BTNSave.BackColor = System.Drawing.Color.Transparent
        Me.BTNSave.BorderRadius = 1
        Me.BTNSave.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSave.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSave.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNSave.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNSave.CheckedState.Parent = Me.BTNSave
        Me.BTNSave.CustomImages.Parent = Me.BTNSave
        Me.BTNSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.BTNSave.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNSave.ForeColor = System.Drawing.Color.White
        Me.BTNSave.HoverState.Parent = Me.BTNSave
        Me.BTNSave.Location = New System.Drawing.Point(142, 184)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.ShadowDecoration.Enabled = True
        Me.BTNSave.ShadowDecoration.Parent = Me.BTNSave
        Me.BTNSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNSave.Size = New System.Drawing.Size(70, 45)
        Me.BTNSave.TabIndex = 10
        Me.BTNSave.TabStop = False
        Me.BTNSave.Text = "SAVE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(81, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "CURRENT STOCK"
        '
        'LBLMedCode
        '
        Me.LBLMedCode.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMedCode.ForeColor = System.Drawing.SystemColors.Control
        Me.LBLMedCode.Location = New System.Drawing.Point(81, 14)
        Me.LBLMedCode.Name = "LBLMedCode"
        Me.LBLMedCode.Size = New System.Drawing.Size(96, 18)
        Me.LBLMedCode.TabIndex = 12
        Me.LBLMedCode.Text = "MEDICINE CODE"
        Me.LBLMedCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLMEDname
        '
        Me.LBLMEDname.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMEDname.ForeColor = System.Drawing.SystemColors.Control
        Me.LBLMEDname.Location = New System.Drawing.Point(82, 41)
        Me.LBLMEDname.Name = "LBLMEDname"
        Me.LBLMEDname.Size = New System.Drawing.Size(95, 20)
        Me.LBLMEDname.TabIndex = 13
        Me.LBLMEDname.Text = "MEDICINE NAME"
        Me.LBLMEDname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTNDecrement
        '
        Me.BTNDecrement.BackColor = System.Drawing.Color.Transparent
        Me.BTNDecrement.CheckedState.Parent = Me.BTNDecrement
        Me.BTNDecrement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNDecrement.CustomImages.Parent = Me.BTNDecrement
        Me.BTNDecrement.FillColor = System.Drawing.Color.Transparent
        Me.BTNDecrement.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNDecrement.ForeColor = System.Drawing.Color.White
        Me.BTNDecrement.HoverState.Parent = Me.BTNDecrement
        Me.BTNDecrement.Location = New System.Drawing.Point(48, 84)
        Me.BTNDecrement.Name = "BTNDecrement"
        Me.BTNDecrement.PressedColor = System.Drawing.Color.Gray
        Me.BTNDecrement.ShadowDecoration.Parent = Me.BTNDecrement
        Me.BTNDecrement.Size = New System.Drawing.Size(31, 31)
        Me.BTNDecrement.TabIndex = 14
        Me.BTNDecrement.Text = "-"
        '
        'BTNIncrement
        '
        Me.BTNIncrement.BackColor = System.Drawing.Color.Transparent
        Me.BTNIncrement.BorderColor = System.Drawing.Color.Transparent
        Me.BTNIncrement.CheckedState.Parent = Me.BTNIncrement
        Me.BTNIncrement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNIncrement.CustomImages.Parent = Me.BTNIncrement
        Me.BTNIncrement.FillColor = System.Drawing.Color.Transparent
        Me.BTNIncrement.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIncrement.ForeColor = System.Drawing.Color.White
        Me.BTNIncrement.HoverState.Parent = Me.BTNIncrement
        Me.BTNIncrement.Location = New System.Drawing.Point(180, 84)
        Me.BTNIncrement.Name = "BTNIncrement"
        Me.BTNIncrement.ShadowDecoration.Parent = Me.BTNIncrement
        Me.BTNIncrement.Size = New System.Drawing.Size(31, 31)
        Me.BTNIncrement.TabIndex = 15
        Me.BTNIncrement.Text = "+"
        '
        'TblmedicineTableAdapter1
        '
        Me.TblmedicineTableAdapter1.ClearBeforeFill = True
        '
        'FRMAddStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(260, 241)
        Me.Controls.Add(Me.BTNIncrement)
        Me.Controls.Add(Me.BTNDecrement)
        Me.Controls.Add(Me.LBLMEDname)
        Me.Controls.Add(Me.LBLMedCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.TXTStock)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FRMAddStock"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD STOCK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTStock As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLMedCode As Label
    Friend WithEvents LBLMEDname As Label
    Friend WithEvents BTNDecrement As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNIncrement As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TblmedicineTableAdapter1 As clinicsmsdbDataSetTableAdapters.tblmedicineTableAdapter
End Class
