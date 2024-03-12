<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addDDItem5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addDDItem5))
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties13 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties14 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties15 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties16 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties17 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties18 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Me.dd_addBtn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.dd_item = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.SuspendLayout()
        '
        'dd_addBtn
        '
        Me.dd_addBtn.AllowToggling = False
        Me.dd_addBtn.AnimationSpeed = 200
        Me.dd_addBtn.AutoGenerateColors = False
        Me.dd_addBtn.BackColor = System.Drawing.Color.Transparent
        Me.dd_addBtn.BackColor1 = System.Drawing.Color.SteelBlue
        Me.dd_addBtn.BackgroundImage = CType(resources.GetObject("dd_addBtn.BackgroundImage"), System.Drawing.Image)
        Me.dd_addBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.dd_addBtn.ButtonText = "ADD"
        Me.dd_addBtn.ButtonTextMarginLeft = 0
        Me.dd_addBtn.ColorContrastOnClick = 45
        Me.dd_addBtn.ColorContrastOnHover = 45
        Me.dd_addBtn.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.dd_addBtn.CustomizableEdges = BorderEdges3
        Me.dd_addBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.dd_addBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.dd_addBtn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dd_addBtn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dd_addBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.dd_addBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.dd_addBtn.ForeColor = System.Drawing.Color.White
        Me.dd_addBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.dd_addBtn.IconMarginLeft = 11
        Me.dd_addBtn.IconPadding = 10
        Me.dd_addBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.dd_addBtn.IdleBorderColor = System.Drawing.Color.MidnightBlue
        Me.dd_addBtn.IdleBorderRadius = 25
        Me.dd_addBtn.IdleBorderThickness = 1
        Me.dd_addBtn.IdleFillColor = System.Drawing.Color.SteelBlue
        Me.dd_addBtn.IdleIconLeftImage = Nothing
        Me.dd_addBtn.IdleIconRightImage = Nothing
        Me.dd_addBtn.IndicateFocus = False
        Me.dd_addBtn.Location = New System.Drawing.Point(219, 28)
        Me.dd_addBtn.Name = "dd_addBtn"
        StateProperties13.BorderColor = System.Drawing.Color.SteelBlue
        StateProperties13.BorderRadius = 25
        StateProperties13.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties13.BorderThickness = 1
        StateProperties13.FillColor = System.Drawing.Color.SteelBlue
        StateProperties13.ForeColor = System.Drawing.Color.White
        StateProperties13.IconLeftImage = Nothing
        StateProperties13.IconRightImage = Nothing
        Me.dd_addBtn.onHoverState = StateProperties13
        StateProperties14.BorderColor = System.Drawing.Color.SteelBlue
        StateProperties14.BorderRadius = 25
        StateProperties14.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties14.BorderThickness = 1
        StateProperties14.FillColor = System.Drawing.Color.SteelBlue
        StateProperties14.ForeColor = System.Drawing.Color.White
        StateProperties14.IconLeftImage = Nothing
        StateProperties14.IconRightImage = Nothing
        Me.dd_addBtn.OnPressedState = StateProperties14
        Me.dd_addBtn.Size = New System.Drawing.Size(112, 35)
        Me.dd_addBtn.TabIndex = 44
        Me.dd_addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dd_addBtn.TextMarginLeft = 0
        Me.dd_addBtn.UseDefaultRadiusAndThickness = True
        '
        'dd_item
        '
        Me.dd_item.AcceptsReturn = False
        Me.dd_item.AcceptsTab = False
        Me.dd_item.AnimationSpeed = 200
        Me.dd_item.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.dd_item.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.dd_item.BackColor = System.Drawing.Color.Transparent
        Me.dd_item.BackgroundImage = CType(resources.GetObject("dd_item.BackgroundImage"), System.Drawing.Image)
        Me.dd_item.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.dd_item.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.dd_item.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dd_item.BorderColorIdle = System.Drawing.Color.Silver
        Me.dd_item.BorderRadius = 25
        Me.dd_item.BorderThickness = 1
        Me.dd_item.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dd_item.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dd_item.DefaultFont = New System.Drawing.Font("Arial", 14.25!)
        Me.dd_item.DefaultText = ""
        Me.dd_item.FillColor = System.Drawing.Color.White
        Me.dd_item.HideSelection = True
        Me.dd_item.IconLeft = Nothing
        Me.dd_item.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.dd_item.IconPadding = 10
        Me.dd_item.IconRight = Nothing
        Me.dd_item.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.dd_item.Lines = New String(-1) {}
        Me.dd_item.Location = New System.Drawing.Point(37, 28)
        Me.dd_item.MaxLength = 32767
        Me.dd_item.MinimumSize = New System.Drawing.Size(100, 35)
        Me.dd_item.Modified = False
        Me.dd_item.Multiline = False
        Me.dd_item.Name = "dd_item"
        StateProperties15.BorderColor = System.Drawing.Color.SteelBlue
        StateProperties15.FillColor = System.Drawing.Color.Empty
        StateProperties15.ForeColor = System.Drawing.Color.Empty
        StateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.dd_item.OnActiveState = StateProperties15
        StateProperties16.BorderColor = System.Drawing.Color.Empty
        StateProperties16.FillColor = System.Drawing.Color.White
        StateProperties16.ForeColor = System.Drawing.Color.Empty
        StateProperties16.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.dd_item.OnDisabledState = StateProperties16
        StateProperties17.BorderColor = System.Drawing.Color.SteelBlue
        StateProperties17.FillColor = System.Drawing.Color.Empty
        StateProperties17.ForeColor = System.Drawing.Color.Empty
        StateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.dd_item.OnHoverState = StateProperties17
        StateProperties18.BorderColor = System.Drawing.Color.Silver
        StateProperties18.FillColor = System.Drawing.Color.White
        StateProperties18.ForeColor = System.Drawing.Color.Empty
        StateProperties18.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.dd_item.OnIdleState = StateProperties18
        Me.dd_item.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dd_item.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.dd_item.PlaceholderText = ""
        Me.dd_item.ReadOnly = False
        Me.dd_item.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dd_item.SelectedText = ""
        Me.dd_item.SelectionLength = 0
        Me.dd_item.SelectionStart = 0
        Me.dd_item.ShortcutsEnabled = True
        Me.dd_item.Size = New System.Drawing.Size(176, 35)
        Me.dd_item.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.dd_item.TabIndex = 43
        Me.dd_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.dd_item.TextMarginBottom = 0
        Me.dd_item.TextMarginLeft = 5
        Me.dd_item.TextMarginTop = 0
        Me.dd_item.TextPlaceholder = ""
        Me.dd_item.UseSystemPasswordChar = False
        Me.dd_item.WordWrap = True
        '
        'addDDItem5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(369, 91)
        Me.Controls.Add(Me.dd_addBtn)
        Me.Controls.Add(Me.dd_item)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "addDDItem5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PC INVENTORY | ADD OS VERSION"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dd_addBtn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents dd_item As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
End Class
