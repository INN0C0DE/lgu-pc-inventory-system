<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.pc_department = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.printBTN = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.SuspendLayout()
        '
        'pc_department
        '
        Me.pc_department.BackColor = System.Drawing.Color.Azure
        Me.pc_department.BorderRadius = 11
        Me.pc_department.Color = System.Drawing.Color.SteelBlue
        Me.pc_department.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pc_department.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.pc_department.DisabledColor = System.Drawing.Color.Gray
        Me.pc_department.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.pc_department.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.pc_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pc_department.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.pc_department.FillDropDown = False
        Me.pc_department.FillIndicator = False
        Me.pc_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pc_department.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pc_department.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pc_department.FormattingEnabled = True
        Me.pc_department.Icon = Nothing
        Me.pc_department.IndicatorColor = System.Drawing.Color.MidnightBlue
        Me.pc_department.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.pc_department.IntegralHeight = False
        Me.pc_department.ItemBackColor = System.Drawing.Color.White
        Me.pc_department.ItemBorderColor = System.Drawing.Color.White
        Me.pc_department.ItemForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pc_department.ItemHeight = 45
        Me.pc_department.ItemHighLightColor = System.Drawing.Color.LightSkyBlue
        Me.pc_department.Items.AddRange(New Object() {"Accounting Office", "Admin Office", "Agriculture Office", "Animal Welfare Office", "Assessor Office", "Budget Office", "Bureau of Jail Management Penology (BJMP)", "Business Permit and Licensing Office", "Capilpil Office", "Department Of Public and Order Safety", "Educational Assistance Office", "Engineering Office", "Gender and Development Office", "General Services Office", "Human Resource Management Office", "Information and Communications Technology Office", "Legal Office", "Local Civil Registry Office", "Local Youth Development Office", "Market Office", "Mayor's Office", "Motorpool Office", "Municipal Disaster Risk Reduction and Management Office", "Municipal Environment Natural Resources Office", "Municipal Health Office", "Municipal Planning and Development Office", "Municipal Social Welfare and Development Office", "Public Employment Services Office", "Public Information Office", "Rural Health Unit (RHU)", "Sanitary Office", "Solid Waste Management Office", "Special Concern", "Sport Development Office", "Tourism Office", "Treasury Office", "Urban Poor Affairs Office", "N/A"})
        Me.pc_department.Location = New System.Drawing.Point(13, 36)
        Me.pc_department.MaxDropDownItems = 5
        Me.pc_department.Name = "pc_department"
        Me.pc_department.Size = New System.Drawing.Size(358, 51)
        Me.pc_department.TabIndex = 40
        Me.pc_department.Text = Nothing
        '
        'printBTN
        '
        Me.printBTN.AllowToggling = False
        Me.printBTN.AnimationSpeed = 200
        Me.printBTN.AutoGenerateColors = False
        Me.printBTN.BackColor = System.Drawing.Color.Transparent
        Me.printBTN.BackColor1 = System.Drawing.Color.SteelBlue
        Me.printBTN.BackgroundImage = CType(resources.GetObject("printBTN.BackgroundImage"), System.Drawing.Image)
        Me.printBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.printBTN.ButtonText = "PRINT"
        Me.printBTN.ButtonTextMarginLeft = 0
        Me.printBTN.ColorContrastOnClick = 45
        Me.printBTN.ColorContrastOnHover = 45
        Me.printBTN.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.printBTN.CustomizableEdges = BorderEdges2
        Me.printBTN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.printBTN.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.printBTN.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.printBTN.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.printBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.printBTN.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.printBTN.ForeColor = System.Drawing.Color.White
        Me.printBTN.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.printBTN.IconMarginLeft = 11
        Me.printBTN.IconPadding = 10
        Me.printBTN.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.printBTN.IdleBorderColor = System.Drawing.Color.MidnightBlue
        Me.printBTN.IdleBorderRadius = 25
        Me.printBTN.IdleBorderThickness = 1
        Me.printBTN.IdleFillColor = System.Drawing.Color.SteelBlue
        Me.printBTN.IdleIconLeftImage = Nothing
        Me.printBTN.IdleIconRightImage = Nothing
        Me.printBTN.IndicateFocus = False
        Me.printBTN.Location = New System.Drawing.Point(117, 93)
        Me.printBTN.Name = "printBTN"
        StateProperties3.BorderColor = System.Drawing.Color.RoyalBlue
        StateProperties3.BorderRadius = 25
        StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.RoyalBlue
        StateProperties3.ForeColor = System.Drawing.Color.White
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.printBTN.onHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.RoyalBlue
        StateProperties4.BorderRadius = 25
        StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.RoyalBlue
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.printBTN.OnPressedState = StateProperties4
        Me.printBTN.Size = New System.Drawing.Size(163, 45)
        Me.printBTN.TabIndex = 41
        Me.printBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.printBTN.TextMarginLeft = 0
        Me.printBTN.UseDefaultRadiusAndThickness = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(388, 158)
        Me.Controls.Add(Me.printBTN)
        Me.Controls.Add(Me.pc_department)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PC INVENTORY | PRINT"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pc_department As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents printBTN As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
