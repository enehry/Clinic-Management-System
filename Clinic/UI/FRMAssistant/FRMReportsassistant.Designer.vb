<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMReportsassistant
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
        Me.tblstudentprofileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clinicsmsdbDataSet = New Clinic.clinicsmsdbDataSet()
        Me.tbltransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTNTransaction = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNStudent = New Guna.UI2.WinForms.Guna2Button()
        Me.PNLReportdisplay = New Guna.UI2.WinForms.Guna2Panel()
        Me.PNLReportbuttons = New Guna.UI2.WinForms.Guna2Panel()
        Me.tblstudentprofileTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tblstudentprofileTableAdapter()
        Me.tbltransactionTableAdapter = New Clinic.clinicsmsdbDataSetTableAdapters.tbltransactionTableAdapter()
        CType(Me.tblstudentprofileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbltransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNLReportbuttons.SuspendLayout()
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
        'tbltransactionBindingSource
        '
        Me.tbltransactionBindingSource.DataMember = "tbltransaction"
        Me.tbltransactionBindingSource.DataSource = Me.clinicsmsdbDataSet
        '
        'BTNTransaction
        '
        Me.BTNTransaction.Animated = True
        Me.BTNTransaction.BackColor = System.Drawing.Color.Transparent
        Me.BTNTransaction.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNTransaction.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNTransaction.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNTransaction.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNTransaction.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNTransaction.CheckedState.Parent = Me.BTNTransaction
        Me.BTNTransaction.CustomImages.Parent = Me.BTNTransaction
        Me.BTNTransaction.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNTransaction.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNTransaction.ForeColor = System.Drawing.Color.White
        Me.BTNTransaction.HoverState.Parent = Me.BTNTransaction
        Me.BTNTransaction.Location = New System.Drawing.Point(132, 0)
        Me.BTNTransaction.Name = "BTNTransaction"
        Me.BTNTransaction.ShadowDecoration.Parent = Me.BTNTransaction
        Me.BTNTransaction.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNTransaction.Size = New System.Drawing.Size(132, 40)
        Me.BTNTransaction.TabIndex = 18
        Me.BTNTransaction.TabStop = False
        Me.BTNTransaction.Text = "Transaction"
        '
        'BTNStudent
        '
        Me.BTNStudent.Animated = True
        Me.BTNStudent.BackColor = System.Drawing.Color.Transparent
        Me.BTNStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BTNStudent.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNStudent.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNStudent.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BTNStudent.CheckedState.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNStudent.CheckedState.Parent = Me.BTNStudent
        Me.BTNStudent.CustomImages.Parent = Me.BTNStudent
        Me.BTNStudent.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNStudent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BTNStudent.ForeColor = System.Drawing.Color.White
        Me.BTNStudent.HoverState.Parent = Me.BTNStudent
        Me.BTNStudent.Location = New System.Drawing.Point(0, 0)
        Me.BTNStudent.Name = "BTNStudent"
        Me.BTNStudent.ShadowDecoration.Parent = Me.BTNStudent
        Me.BTNStudent.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.BTNStudent.Size = New System.Drawing.Size(132, 40)
        Me.BTNStudent.TabIndex = 17
        Me.BTNStudent.TabStop = False
        Me.BTNStudent.Text = "Student Account"
        '
        'PNLReportdisplay
        '
        Me.PNLReportdisplay.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PNLReportdisplay.Location = New System.Drawing.Point(32, 107)
        Me.PNLReportdisplay.Name = "PNLReportdisplay"
        Me.PNLReportdisplay.ShadowDecoration.Enabled = True
        Me.PNLReportdisplay.ShadowDecoration.Parent = Me.PNLReportdisplay
        Me.PNLReportdisplay.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.PNLReportdisplay.Size = New System.Drawing.Size(729, 530)
        Me.PNLReportdisplay.TabIndex = 10
        '
        'PNLReportbuttons
        '
        Me.PNLReportbuttons.Controls.Add(Me.BTNTransaction)
        Me.PNLReportbuttons.Controls.Add(Me.BTNStudent)
        Me.PNLReportbuttons.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNLReportbuttons.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PNLReportbuttons.Location = New System.Drawing.Point(0, 0)
        Me.PNLReportbuttons.Name = "PNLReportbuttons"
        Me.PNLReportbuttons.ShadowDecoration.Depth = 50
        Me.PNLReportbuttons.ShadowDecoration.Enabled = True
        Me.PNLReportbuttons.ShadowDecoration.Parent = Me.PNLReportbuttons
        Me.PNLReportbuttons.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.PNLReportbuttons.Size = New System.Drawing.Size(796, 41)
        Me.PNLReportbuttons.TabIndex = 9
        '
        'tblstudentprofileTableAdapter
        '
        Me.tblstudentprofileTableAdapter.ClearBeforeFill = True
        '
        'tbltransactionTableAdapter
        '
        Me.tbltransactionTableAdapter.ClearBeforeFill = True
        '
        'FRMReportsassistant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 666)
        Me.Controls.Add(Me.PNLReportdisplay)
        Me.Controls.Add(Me.PNLReportbuttons)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMReportsassistant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.tblstudentprofileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clinicsmsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbltransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNLReportbuttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNTransaction As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNStudent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PNLReportdisplay As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PNLReportbuttons As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tblstudentprofileBindingSource As BindingSource
    Friend WithEvents clinicsmsdbDataSet As clinicsmsdbDataSet
    Friend WithEvents tblstudentprofileTableAdapter As clinicsmsdbDataSetTableAdapters.tblstudentprofileTableAdapter
    Friend WithEvents tbltransactionBindingSource As BindingSource
    Friend WithEvents tbltransactionTableAdapter As clinicsmsdbDataSetTableAdapters.tbltransactionTableAdapter
End Class
