<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Parent
    Inherits DarkUI.Forms.DarkForm 'System.Windows.Forms.Form 'DarkUI.Forms.DarkForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parent))
        Me.MenuStrip1 = New DarkUI.Controls.DarkMenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscParamsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashBoardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarrigeSolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryPlaneurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SawLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.WindowsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.MenuToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1898, 33)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.HistoryToolStripMenuItem, Me.MiscParamsToolStripMenuItem, Me.DashBoardToolStripMenuItem, Me.CarrigeSolutionToolStripMenuItem, Me.SimulationToolStripMenuItem, Me.HistoryPlaneurToolStripMenuItem, Me.SawLineToolStripMenuItem})
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(73, 29)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(241, 34)
        Me.HomeToolStripMenuItem.Text = "&Home"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(241, 34)
        Me.HistoryToolStripMenuItem.Text = "&History"
        '
        'MiscParamsToolStripMenuItem
        '
        Me.MiscParamsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.MiscParamsToolStripMenuItem.Name = "MiscParamsToolStripMenuItem"
        Me.MiscParamsToolStripMenuItem.Size = New System.Drawing.Size(241, 34)
        Me.MiscParamsToolStripMenuItem.Text = "&MiscParams"
        '
        'DashBoardToolStripMenuItem
        '
        Me.DashBoardToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DashBoardToolStripMenuItem.Name = "DashBoardToolStripMenuItem"
        Me.DashBoardToolStripMenuItem.Size = New System.Drawing.Size(241, 34)
        Me.DashBoardToolStripMenuItem.Text = "&DashBoard"
        '
        'CarrigeSolutionToolStripMenuItem
        '
        Me.CarrigeSolutionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.CarrigeSolutionToolStripMenuItem.Name = "CarrigeSolutionToolStripMenuItem"
        Me.CarrigeSolutionToolStripMenuItem.Size = New System.Drawing.Size(241, 34)
        Me.CarrigeSolutionToolStripMenuItem.Text = "&Carrige Solution"
        '
        'SimulationToolStripMenuItem
        '
        Me.SimulationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SimulationToolStripMenuItem.Name = "SimulationToolStripMenuItem"
        Me.SimulationToolStripMenuItem.Size = New System.Drawing.Size(241, 34)
        Me.SimulationToolStripMenuItem.Text = "&Simulation"
        '
        'HistoryPlaneurToolStripMenuItem
        '
        Me.HistoryPlaneurToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HistoryPlaneurToolStripMenuItem.Name = "HistoryPlaneurToolStripMenuItem"
        Me.HistoryPlaneurToolStripMenuItem.Size = New System.Drawing.Size(241, 34)
        Me.HistoryPlaneurToolStripMenuItem.Text = "&HistoryPlaneur"
        '
        'SawLineToolStripMenuItem
        '
        Me.SawLineToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.SawLineToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SawLineToolStripMenuItem.Name = "SawLineToolStripMenuItem"
        Me.SawLineToolStripMenuItem.Size = New System.Drawing.Size(241, 34)
        Me.SawLineToolStripMenuItem.Text = "&Saw Line"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseAllToolStripMenuItem, Me.MinimizeAllToolStripMenuItem})
        Me.WindowsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(102, 29)
        Me.WindowsToolStripMenuItem.Text = "&Windows"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(210, 34)
        Me.CloseAllToolStripMenuItem.Text = "&Close All"
        '
        'MinimizeAllToolStripMenuItem
        '
        Me.MinimizeAllToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.MinimizeAllToolStripMenuItem.Name = "MinimizeAllToolStripMenuItem"
        Me.MinimizeAllToolStripMenuItem.Size = New System.Drawing.Size(210, 34)
        Me.MinimizeAllToolStripMenuItem.Text = "&Minimize All"
        '
        'Parent
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.FondEcran
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Parent"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Autolog Controls View"
        Me.TransparencyKey = System.Drawing.SystemColors.Window
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiscParamsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DashBoardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizeAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarrigeSolutionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimulationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryPlaneurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As DarkUI.Controls.DarkMenuStrip
    Friend WithEvents SawLineToolStripMenuItem As ToolStripMenuItem
End Class
