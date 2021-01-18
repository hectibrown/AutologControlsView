<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MiscParams
    Inherits DarkUI.Forms.DarkForm 'System.Windows.Forms.Form

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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node5")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node6")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node4", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7})
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MiscParams))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LugId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OptiId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Destination = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BinNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDims = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SquareIlluminatedButton18 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.SquareIlluminatedButton19 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton20 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton21 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton22 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton23 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton24 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton25 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton26 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton27 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton28 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.BasicLabel8 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel9 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel7 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel6 = New AdvancedHMIControls.BasicLabel()
        Me.SquareIlluminatedButton17 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton16 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton15 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton14 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton13 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton12 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton11 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton10 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton9 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton8 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton7 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton6 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton5 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton4 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton3 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton2 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton1 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.BasicLabel10 = New AdvancedHMIControls.BasicLabel()
        Me.TwinCATCom1 = New AdvancedHMIDrivers.TwinCATCom(Me.components)
        Me.SelectorSwitch1 = New AdvancedHMIControls.SelectorSwitch()
        Me.ModbusTCPCom1 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.KeyboardInput1 = New AdvancedHMIControls.KeyboardInput()
        Me.BasicLabel5 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel4 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel3 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel2 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel89 = New AdvancedHMIControls.BasicLabel()
        Me.ProductionDisplay = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel70 = New AdvancedHMIControls.BasicLabel()
        Me.CheckBox1 = New AdvancedHMIControls.CheckBox()
        Me.DataSubscriber21 = New AdvancedHMIControls.DataSubscriber2(Me.components)
        Me.BasicLabel11 = New AdvancedHMIControls.BasicLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TwinCATCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriber21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Desactivé", "Activé"})
        Me.ComboBox1.Location = New System.Drawing.Point(227, 106)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox1.TabIndex = 251
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(59, 150)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(2)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "Node1"
        TreeNode2.Name = "Node2"
        TreeNode2.Text = "Node2"
        TreeNode3.Name = "Node3"
        TreeNode3.Text = "Node3"
        TreeNode4.Name = "Node0"
        TreeNode4.Text = "Node0"
        TreeNode5.Name = "Node5"
        TreeNode5.Text = "Node5"
        TreeNode6.Name = "Node6"
        TreeNode6.Text = "Node6"
        TreeNode7.Name = "Node7"
        TreeNode7.Text = "Node7"
        TreeNode8.Name = "Node4"
        TreeNode8.Text = "Node4"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode8})
        Me.TreeView1.Size = New System.Drawing.Size(99, 145)
        Me.TreeView1.TabIndex = 253
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Time, Me.LugId, Me.OptiId, Me.Destination, Me.Sort, Me.BinNumber, Me.NomDims})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.DataGridView1.Location = New System.Drawing.Point(36, 361)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 10
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(723, 249)
        Me.DataGridView1.TabIndex = 281
        Me.DataGridView1.TabStop = False
        '
        'Time
        '
        Me.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Time.HeaderText = "Time"
        Me.Time.MinimumWidth = 6
        Me.Time.Name = "Time"
        Me.Time.Width = 150
        '
        'LugId
        '
        Me.LugId.HeaderText = "LugId"
        Me.LugId.MinimumWidth = 6
        Me.LugId.Name = "LugId"
        Me.LugId.Width = 60
        '
        'OptiId
        '
        Me.OptiId.HeaderText = "OptiId"
        Me.OptiId.MinimumWidth = 6
        Me.OptiId.Name = "OptiId"
        Me.OptiId.Width = 60
        '
        'Destination
        '
        Me.Destination.HeaderText = "Destination"
        Me.Destination.MinimumWidth = 6
        Me.Destination.Name = "Destination"
        Me.Destination.Width = 125
        '
        'Sort
        '
        Me.Sort.HeaderText = "Sort"
        Me.Sort.MinimumWidth = 6
        Me.Sort.Name = "Sort"
        Me.Sort.Width = 50
        '
        'BinNumber
        '
        Me.BinNumber.HeaderText = "Bin #"
        Me.BinNumber.MinimumWidth = 6
        Me.BinNumber.Name = "BinNumber"
        Me.BinNumber.Width = 50
        '
        'NomDims
        '
        Me.NomDims.HeaderText = "Nom Dimensions"
        Me.NomDims.MinimumWidth = 6
        Me.NomDims.Name = "NomDims"
        Me.NomDims.Width = 200
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton18)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton19)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton20)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton21)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton22)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton23)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton24)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton25)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton26)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton27)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton28)
        Me.Panel1.Controls.Add(Me.BasicLabel8)
        Me.Panel1.Controls.Add(Me.BasicLabel9)
        Me.Panel1.Controls.Add(Me.BasicLabel7)
        Me.Panel1.Controls.Add(Me.BasicLabel6)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton17)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton16)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton15)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton14)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton13)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton12)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton11)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton10)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton9)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton8)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton7)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton6)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton5)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton4)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton3)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton2)
        Me.Panel1.Controls.Add(Me.SquareIlluminatedButton1)
        Me.Panel1.Location = New System.Drawing.Point(657, 527)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 271)
        Me.Panel1.TabIndex = 291
        '
        'SquareIlluminatedButton18
        '
        Me.SquareIlluminatedButton18.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton18.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton18.Location = New System.Drawing.Point(234, 238)
        Me.SquareIlluminatedButton18.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton18.Name = "SquareIlluminatedButton18"
        Me.SquareIlluminatedButton18.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton18.PLCAddressClick = ""
        Me.SquareIlluminatedButton18.PLCAddressText = ""
        Me.SquareIlluminatedButton18.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dSaws.10"
        Me.SquareIlluminatedButton18.PLCAddressVisible = ""
        Me.SquareIlluminatedButton18.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton18.TabIndex = 31
        Me.SquareIlluminatedButton18.Text = "Saw 16'"
        Me.SquareIlluminatedButton18.Value = False
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "150.150.10.151"
        Me.EthernetIPforCLXCom1.PollRateOverride = 200
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'SquareIlluminatedButton19
        '
        Me.SquareIlluminatedButton19.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton19.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton19.Location = New System.Drawing.Point(234, 214)
        Me.SquareIlluminatedButton19.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton19.Name = "SquareIlluminatedButton19"
        Me.SquareIlluminatedButton19.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton19.PLCAddressClick = ""
        Me.SquareIlluminatedButton19.PLCAddressText = ""
        Me.SquareIlluminatedButton19.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dSaws.9"
        Me.SquareIlluminatedButton19.PLCAddressVisible = ""
        Me.SquareIlluminatedButton19.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton19.TabIndex = 30
        Me.SquareIlluminatedButton19.Text = "Saw 14'"
        Me.SquareIlluminatedButton19.Value = False
        '
        'SquareIlluminatedButton20
        '
        Me.SquareIlluminatedButton20.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton20.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton20.Location = New System.Drawing.Point(234, 191)
        Me.SquareIlluminatedButton20.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton20.Name = "SquareIlluminatedButton20"
        Me.SquareIlluminatedButton20.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton20.PLCAddressClick = ""
        Me.SquareIlluminatedButton20.PLCAddressText = ""
        Me.SquareIlluminatedButton20.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dSaws.8"
        Me.SquareIlluminatedButton20.PLCAddressVisible = ""
        Me.SquareIlluminatedButton20.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton20.TabIndex = 29
        Me.SquareIlluminatedButton20.Text = "Saw 12'"
        Me.SquareIlluminatedButton20.Value = False
        '
        'SquareIlluminatedButton21
        '
        Me.SquareIlluminatedButton21.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton21.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton21.Location = New System.Drawing.Point(234, 167)
        Me.SquareIlluminatedButton21.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton21.Name = "SquareIlluminatedButton21"
        Me.SquareIlluminatedButton21.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton21.PLCAddressClick = ""
        Me.SquareIlluminatedButton21.PLCAddressText = ""
        Me.SquareIlluminatedButton21.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dSaws.7"
        Me.SquareIlluminatedButton21.PLCAddressVisible = ""
        Me.SquareIlluminatedButton21.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton21.TabIndex = 28
        Me.SquareIlluminatedButton21.Text = "Saw 10'"
        Me.SquareIlluminatedButton21.Value = False
        '
        'SquareIlluminatedButton22
        '
        Me.SquareIlluminatedButton22.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton22.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton22.Location = New System.Drawing.Point(234, 144)
        Me.SquareIlluminatedButton22.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton22.Name = "SquareIlluminatedButton22"
        Me.SquareIlluminatedButton22.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton22.PLCAddressClick = ""
        Me.SquareIlluminatedButton22.PLCAddressText = ""
        Me.SquareIlluminatedButton22.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dSaws.6"
        Me.SquareIlluminatedButton22.PLCAddressVisible = ""
        Me.SquareIlluminatedButton22.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton22.TabIndex = 27
        Me.SquareIlluminatedButton22.Text = "Saw 9'"
        Me.SquareIlluminatedButton22.Value = False
        '
        'SquareIlluminatedButton23
        '
        Me.SquareIlluminatedButton23.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton23.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton23.Location = New System.Drawing.Point(234, 120)
        Me.SquareIlluminatedButton23.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton23.Name = "SquareIlluminatedButton23"
        Me.SquareIlluminatedButton23.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton23.PLCAddressClick = ""
        Me.SquareIlluminatedButton23.PLCAddressText = ""
        Me.SquareIlluminatedButton23.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dSaws.5"
        Me.SquareIlluminatedButton23.PLCAddressVisible = ""
        Me.SquareIlluminatedButton23.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton23.TabIndex = 26
        Me.SquareIlluminatedButton23.Text = "Saw 8'"
        Me.SquareIlluminatedButton23.Value = False
        '
        'SquareIlluminatedButton24
        '
        Me.SquareIlluminatedButton24.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton24.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton24.Location = New System.Drawing.Point(234, 97)
        Me.SquareIlluminatedButton24.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton24.Name = "SquareIlluminatedButton24"
        Me.SquareIlluminatedButton24.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton24.PLCAddressClick = ""
        Me.SquareIlluminatedButton24.PLCAddressText = ""
        Me.SquareIlluminatedButton24.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dSaws.4"
        Me.SquareIlluminatedButton24.PLCAddressVisible = ""
        Me.SquareIlluminatedButton24.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton24.TabIndex = 25
        Me.SquareIlluminatedButton24.Text = "Saw 7'"
        Me.SquareIlluminatedButton24.Value = False
        '
        'SquareIlluminatedButton25
        '
        Me.SquareIlluminatedButton25.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton25.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton25.Location = New System.Drawing.Point(234, 73)
        Me.SquareIlluminatedButton25.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton25.Name = "SquareIlluminatedButton25"
        Me.SquareIlluminatedButton25.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton25.PLCAddressClick = ""
        Me.SquareIlluminatedButton25.PLCAddressText = ""
        Me.SquareIlluminatedButton25.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dSaws.3"
        Me.SquareIlluminatedButton25.PLCAddressVisible = ""
        Me.SquareIlluminatedButton25.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton25.TabIndex = 24
        Me.SquareIlluminatedButton25.Text = "Saw 6'"
        Me.SquareIlluminatedButton25.Value = False
        '
        'SquareIlluminatedButton26
        '
        Me.SquareIlluminatedButton26.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton26.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton26.Location = New System.Drawing.Point(234, 50)
        Me.SquareIlluminatedButton26.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton26.Name = "SquareIlluminatedButton26"
        Me.SquareIlluminatedButton26.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton26.PLCAddressClick = ""
        Me.SquareIlluminatedButton26.PLCAddressText = ""
        Me.SquareIlluminatedButton26.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dSaws.2"
        Me.SquareIlluminatedButton26.PLCAddressVisible = ""
        Me.SquareIlluminatedButton26.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton26.TabIndex = 23
        Me.SquareIlluminatedButton26.Text = "Saw 4'"
        Me.SquareIlluminatedButton26.Value = False
        '
        'SquareIlluminatedButton27
        '
        Me.SquareIlluminatedButton27.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton27.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton27.Location = New System.Drawing.Point(234, 26)
        Me.SquareIlluminatedButton27.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton27.Name = "SquareIlluminatedButton27"
        Me.SquareIlluminatedButton27.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton27.PLCAddressClick = ""
        Me.SquareIlluminatedButton27.PLCAddressText = ""
        Me.SquareIlluminatedButton27.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dSaws.1"
        Me.SquareIlluminatedButton27.PLCAddressVisible = ""
        Me.SquareIlluminatedButton27.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton27.TabIndex = 22
        Me.SquareIlluminatedButton27.Text = "Saw 2'"
        Me.SquareIlluminatedButton27.Value = False
        '
        'SquareIlluminatedButton28
        '
        Me.SquareIlluminatedButton28.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton28.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton28.Location = New System.Drawing.Point(234, 2)
        Me.SquareIlluminatedButton28.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton28.Name = "SquareIlluminatedButton28"
        Me.SquareIlluminatedButton28.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton28.PLCAddressClick = ""
        Me.SquareIlluminatedButton28.PLCAddressText = ""
        Me.SquareIlluminatedButton28.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dSaws.0"
        Me.SquareIlluminatedButton28.PLCAddressVisible = ""
        Me.SquareIlluminatedButton28.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton28.TabIndex = 21
        Me.SquareIlluminatedButton28.Text = "Saw 0'"
        Me.SquareIlluminatedButton28.Value = False
        '
        'BasicLabel8
        '
        Me.BasicLabel8.AutoSize = True
        Me.BasicLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel8.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel8.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel8.DisplayAsTime = False
        Me.BasicLabel8.ForeColor = System.Drawing.Color.White
        Me.BasicLabel8.Highlight = False
        Me.BasicLabel8.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel8.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel8.HighlightKeyCharacter = "!"
        Me.BasicLabel8.InterpretValueAsBCD = False
        Me.BasicLabel8.KeypadAlphanumeric = False
        Me.BasicLabel8.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel8.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel8.KeypadMaxValue = 0R
        Me.BasicLabel8.KeypadMinValue = 0R
        Me.BasicLabel8.KeypadScaleFactor = 1.0R
        Me.BasicLabel8.KeypadShowCurrentValue = False
        Me.BasicLabel8.KeypadText = Nothing
        Me.BasicLabel8.KeypadWidth = 300
        Me.BasicLabel8.Location = New System.Drawing.Point(434, 167)
        Me.BasicLabel8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BasicLabel8.Name = "BasicLabel8"
        Me.BasicLabel8.NumericFormat = Nothing
        Me.BasicLabel8.PLCAddressKeypad = ""
        Me.BasicLabel8.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dDebugDest[1]"
        Me.BasicLabel8.Size = New System.Drawing.Size(103, 13)
        Me.BasicLabel8.TabIndex = 20
        Me.BasicLabel8.Text = "Dest Idx 1: DestIdx1"
        Me.BasicLabel8.Value = "DestIdx1"
        Me.BasicLabel8.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel8.ValueLeftPadLength = 0
        Me.BasicLabel8.ValuePrefix = "Dest Idx 1: "
        Me.BasicLabel8.ValueScaleFactor = 1.0R
        Me.BasicLabel8.ValueSuffix = Nothing
        Me.BasicLabel8.ValueToSubtractFrom = 0!
        '
        'BasicLabel9
        '
        Me.BasicLabel9.AutoSize = True
        Me.BasicLabel9.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel9.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel9.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel9.DisplayAsTime = False
        Me.BasicLabel9.ForeColor = System.Drawing.Color.White
        Me.BasicLabel9.Highlight = False
        Me.BasicLabel9.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel9.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel9.HighlightKeyCharacter = "!"
        Me.BasicLabel9.InterpretValueAsBCD = False
        Me.BasicLabel9.KeypadAlphanumeric = False
        Me.BasicLabel9.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel9.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel9.KeypadMaxValue = 0R
        Me.BasicLabel9.KeypadMinValue = 0R
        Me.BasicLabel9.KeypadScaleFactor = 1.0R
        Me.BasicLabel9.KeypadShowCurrentValue = False
        Me.BasicLabel9.KeypadText = Nothing
        Me.BasicLabel9.KeypadWidth = 300
        Me.BasicLabel9.Location = New System.Drawing.Point(434, 148)
        Me.BasicLabel9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BasicLabel9.Name = "BasicLabel9"
        Me.BasicLabel9.NumericFormat = Nothing
        Me.BasicLabel9.PLCAddressKeypad = ""
        Me.BasicLabel9.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dDebugDest[0]"
        Me.BasicLabel9.Size = New System.Drawing.Size(103, 13)
        Me.BasicLabel9.TabIndex = 19
        Me.BasicLabel9.Text = "Dest Idx 0: DestIdx0"
        Me.BasicLabel9.Value = "DestIdx0"
        Me.BasicLabel9.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel9.ValueLeftPadLength = 0
        Me.BasicLabel9.ValuePrefix = "Dest Idx 0: "
        Me.BasicLabel9.ValueScaleFactor = 1.0R
        Me.BasicLabel9.ValueSuffix = Nothing
        Me.BasicLabel9.ValueToSubtractFrom = 0!
        '
        'BasicLabel7
        '
        Me.BasicLabel7.AutoSize = True
        Me.BasicLabel7.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel7.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel7.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel7.DisplayAsTime = False
        Me.BasicLabel7.ForeColor = System.Drawing.Color.White
        Me.BasicLabel7.Highlight = False
        Me.BasicLabel7.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel7.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel7.HighlightKeyCharacter = "!"
        Me.BasicLabel7.InterpretValueAsBCD = False
        Me.BasicLabel7.KeypadAlphanumeric = False
        Me.BasicLabel7.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel7.KeypadMaxValue = 0R
        Me.BasicLabel7.KeypadMinValue = 0R
        Me.BasicLabel7.KeypadScaleFactor = 1.0R
        Me.BasicLabel7.KeypadShowCurrentValue = False
        Me.BasicLabel7.KeypadText = Nothing
        Me.BasicLabel7.KeypadWidth = 300
        Me.BasicLabel7.Location = New System.Drawing.Point(308, 167)
        Me.BasicLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BasicLabel7.Name = "BasicLabel7"
        Me.BasicLabel7.NumericFormat = Nothing
        Me.BasicLabel7.PLCAddressKeypad = ""
        Me.BasicLabel7.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dDebugLength[1]"
        Me.BasicLabel7.Size = New System.Drawing.Size(125, 13)
        Me.BasicLabel7.TabIndex = 18
        Me.BasicLabel7.Text = "Length Idx 1: LengthIdx1"
        Me.BasicLabel7.Value = "LengthIdx1"
        Me.BasicLabel7.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel7.ValueLeftPadLength = 0
        Me.BasicLabel7.ValuePrefix = "Length Idx 1: "
        Me.BasicLabel7.ValueScaleFactor = 1.0R
        Me.BasicLabel7.ValueSuffix = Nothing
        Me.BasicLabel7.ValueToSubtractFrom = 0!
        '
        'BasicLabel6
        '
        Me.BasicLabel6.AutoSize = True
        Me.BasicLabel6.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel6.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel6.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel6.DisplayAsTime = False
        Me.BasicLabel6.ForeColor = System.Drawing.Color.White
        Me.BasicLabel6.Highlight = False
        Me.BasicLabel6.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel6.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel6.HighlightKeyCharacter = "!"
        Me.BasicLabel6.InterpretValueAsBCD = False
        Me.BasicLabel6.KeypadAlphanumeric = False
        Me.BasicLabel6.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel6.KeypadMaxValue = 0R
        Me.BasicLabel6.KeypadMinValue = 0R
        Me.BasicLabel6.KeypadScaleFactor = 1.0R
        Me.BasicLabel6.KeypadShowCurrentValue = False
        Me.BasicLabel6.KeypadText = Nothing
        Me.BasicLabel6.KeypadWidth = 300
        Me.BasicLabel6.Location = New System.Drawing.Point(308, 148)
        Me.BasicLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BasicLabel6.Name = "BasicLabel6"
        Me.BasicLabel6.NumericFormat = Nothing
        Me.BasicLabel6.PLCAddressKeypad = ""
        Me.BasicLabel6.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dDebugLength[0]"
        Me.BasicLabel6.Size = New System.Drawing.Size(125, 13)
        Me.BasicLabel6.TabIndex = 17
        Me.BasicLabel6.Text = "Length Idx 0: LengthIdx0"
        Me.BasicLabel6.Value = "LengthIdx0"
        Me.BasicLabel6.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel6.ValueLeftPadLength = 0
        Me.BasicLabel6.ValuePrefix = "Length Idx 0: "
        Me.BasicLabel6.ValueScaleFactor = 1.0R
        Me.BasicLabel6.ValueSuffix = Nothing
        Me.BasicLabel6.ValueToSubtractFrom = 0!
        '
        'SquareIlluminatedButton17
        '
        Me.SquareIlluminatedButton17.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton17.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton17.Location = New System.Drawing.Point(310, 119)
        Me.SquareIlluminatedButton17.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton17.Name = "SquareIlluminatedButton17"
        Me.SquareIlluminatedButton17.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton17.PLCAddressClick = ""
        Me.SquareIlluminatedButton17.PLCAddressText = ""
        Me.SquareIlluminatedButton17.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dGates.5"
        Me.SquareIlluminatedButton17.PLCAddressVisible = ""
        Me.SquareIlluminatedButton17.Size = New System.Drawing.Size(110, 19)
        Me.SquareIlluminatedButton17.TabIndex = 16
        Me.SquareIlluminatedButton17.Text = "Gate 6 179.5-185.25"
        Me.SquareIlluminatedButton17.Value = False
        '
        'SquareIlluminatedButton16
        '
        Me.SquareIlluminatedButton16.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton16.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton16.Location = New System.Drawing.Point(310, 97)
        Me.SquareIlluminatedButton16.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton16.Name = "SquareIlluminatedButton16"
        Me.SquareIlluminatedButton16.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton16.PLCAddressClick = ""
        Me.SquareIlluminatedButton16.PLCAddressText = ""
        Me.SquareIlluminatedButton16.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dGates.4"
        Me.SquareIlluminatedButton16.PLCAddressVisible = ""
        Me.SquareIlluminatedButton16.Size = New System.Drawing.Size(110, 19)
        Me.SquareIlluminatedButton16.TabIndex = 15
        Me.SquareIlluminatedButton16.Text = "Gate 5 155.5-161.25"
        Me.SquareIlluminatedButton16.Value = False
        '
        'SquareIlluminatedButton15
        '
        Me.SquareIlluminatedButton15.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton15.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton15.Location = New System.Drawing.Point(310, 73)
        Me.SquareIlluminatedButton15.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton15.Name = "SquareIlluminatedButton15"
        Me.SquareIlluminatedButton15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton15.PLCAddressClick = ""
        Me.SquareIlluminatedButton15.PLCAddressText = ""
        Me.SquareIlluminatedButton15.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dGates.3"
        Me.SquareIlluminatedButton15.PLCAddressVisible = ""
        Me.SquareIlluminatedButton15.Size = New System.Drawing.Size(110, 19)
        Me.SquareIlluminatedButton15.TabIndex = 14
        Me.SquareIlluminatedButton15.Text = "Gate 4 131.5-137.25"
        Me.SquareIlluminatedButton15.Value = False
        '
        'SquareIlluminatedButton14
        '
        Me.SquareIlluminatedButton14.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton14.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton14.Location = New System.Drawing.Point(310, 50)
        Me.SquareIlluminatedButton14.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton14.Name = "SquareIlluminatedButton14"
        Me.SquareIlluminatedButton14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton14.PLCAddressClick = ""
        Me.SquareIlluminatedButton14.PLCAddressText = ""
        Me.SquareIlluminatedButton14.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dGates.2"
        Me.SquareIlluminatedButton14.PLCAddressVisible = ""
        Me.SquareIlluminatedButton14.Size = New System.Drawing.Size(110, 19)
        Me.SquareIlluminatedButton14.TabIndex = 13
        Me.SquareIlluminatedButton14.Text = "Gate 3 102-107"
        Me.SquareIlluminatedButton14.Value = False
        '
        'SquareIlluminatedButton13
        '
        Me.SquareIlluminatedButton13.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton13.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton13.Location = New System.Drawing.Point(310, 26)
        Me.SquareIlluminatedButton13.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton13.Name = "SquareIlluminatedButton13"
        Me.SquareIlluminatedButton13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton13.PLCAddressClick = ""
        Me.SquareIlluminatedButton13.PLCAddressText = ""
        Me.SquareIlluminatedButton13.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dGates.1"
        Me.SquareIlluminatedButton13.PLCAddressVisible = ""
        Me.SquareIlluminatedButton13.Size = New System.Drawing.Size(110, 19)
        Me.SquareIlluminatedButton13.TabIndex = 12
        Me.SquareIlluminatedButton13.Text = "Gate 2 77.5-83.5"
        Me.SquareIlluminatedButton13.Value = False
        '
        'SquareIlluminatedButton12
        '
        Me.SquareIlluminatedButton12.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton12.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton12.Location = New System.Drawing.Point(310, 2)
        Me.SquareIlluminatedButton12.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton12.Name = "SquareIlluminatedButton12"
        Me.SquareIlluminatedButton12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton12.PLCAddressClick = ""
        Me.SquareIlluminatedButton12.PLCAddressText = ""
        Me.SquareIlluminatedButton12.PLCAddressValue = "PROGRAM:ACT_REMAN_GATE.dGates.0"
        Me.SquareIlluminatedButton12.PLCAddressVisible = ""
        Me.SquareIlluminatedButton12.Size = New System.Drawing.Size(110, 19)
        Me.SquareIlluminatedButton12.TabIndex = 11
        Me.SquareIlluminatedButton12.Text = "Gate 1 0-61"""
        Me.SquareIlluminatedButton12.Value = False
        '
        'SquareIlluminatedButton11
        '
        Me.SquareIlluminatedButton11.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton11.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton11.Location = New System.Drawing.Point(31, 237)
        Me.SquareIlluminatedButton11.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton11.Name = "SquareIlluminatedButton11"
        Me.SquareIlluminatedButton11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton11.PLCAddressClick = ""
        Me.SquareIlluminatedButton11.PLCAddressText = ""
        Me.SquareIlluminatedButton11.PLCAddressValue = "PROGRAM:ACT_SAWS_B1.dSaws.10"
        Me.SquareIlluminatedButton11.PLCAddressVisible = ""
        Me.SquareIlluminatedButton11.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton11.TabIndex = 10
        Me.SquareIlluminatedButton11.Text = "Saw 16'"
        Me.SquareIlluminatedButton11.Value = False
        '
        'SquareIlluminatedButton10
        '
        Me.SquareIlluminatedButton10.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton10.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton10.Location = New System.Drawing.Point(31, 214)
        Me.SquareIlluminatedButton10.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton10.Name = "SquareIlluminatedButton10"
        Me.SquareIlluminatedButton10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton10.PLCAddressClick = ""
        Me.SquareIlluminatedButton10.PLCAddressText = ""
        Me.SquareIlluminatedButton10.PLCAddressValue = "PROGRAM:ACT_SAWS_B1.dSaws.9"
        Me.SquareIlluminatedButton10.PLCAddressVisible = ""
        Me.SquareIlluminatedButton10.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton10.TabIndex = 9
        Me.SquareIlluminatedButton10.Text = "Saw 14'"
        Me.SquareIlluminatedButton10.Value = False
        '
        'SquareIlluminatedButton9
        '
        Me.SquareIlluminatedButton9.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton9.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton9.Location = New System.Drawing.Point(31, 190)
        Me.SquareIlluminatedButton9.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton9.Name = "SquareIlluminatedButton9"
        Me.SquareIlluminatedButton9.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton9.PLCAddressClick = ""
        Me.SquareIlluminatedButton9.PLCAddressText = ""
        Me.SquareIlluminatedButton9.PLCAddressValue = "PROGRAM:ACT_SAWS_B1.dSaws.8"
        Me.SquareIlluminatedButton9.PLCAddressVisible = ""
        Me.SquareIlluminatedButton9.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton9.TabIndex = 8
        Me.SquareIlluminatedButton9.Text = "Saw 12'"
        Me.SquareIlluminatedButton9.Value = False
        '
        'SquareIlluminatedButton8
        '
        Me.SquareIlluminatedButton8.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton8.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton8.Location = New System.Drawing.Point(31, 167)
        Me.SquareIlluminatedButton8.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton8.Name = "SquareIlluminatedButton8"
        Me.SquareIlluminatedButton8.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton8.PLCAddressClick = ""
        Me.SquareIlluminatedButton8.PLCAddressText = ""
        Me.SquareIlluminatedButton8.PLCAddressValue = "PROGRAM:ACT_SAWS_B1.dSaws.7"
        Me.SquareIlluminatedButton8.PLCAddressVisible = ""
        Me.SquareIlluminatedButton8.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton8.TabIndex = 7
        Me.SquareIlluminatedButton8.Text = "Saw 10'"
        Me.SquareIlluminatedButton8.Value = False
        '
        'SquareIlluminatedButton7
        '
        Me.SquareIlluminatedButton7.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton7.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton7.Location = New System.Drawing.Point(31, 143)
        Me.SquareIlluminatedButton7.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton7.Name = "SquareIlluminatedButton7"
        Me.SquareIlluminatedButton7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton7.PLCAddressClick = ""
        Me.SquareIlluminatedButton7.PLCAddressText = ""
        Me.SquareIlluminatedButton7.PLCAddressValue = "PROGRAM:ACT_SAWS_B1.dSaws.6"
        Me.SquareIlluminatedButton7.PLCAddressVisible = ""
        Me.SquareIlluminatedButton7.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton7.TabIndex = 6
        Me.SquareIlluminatedButton7.Text = "Saw 9'"
        Me.SquareIlluminatedButton7.Value = False
        '
        'SquareIlluminatedButton6
        '
        Me.SquareIlluminatedButton6.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton6.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton6.Location = New System.Drawing.Point(31, 119)
        Me.SquareIlluminatedButton6.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton6.Name = "SquareIlluminatedButton6"
        Me.SquareIlluminatedButton6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton6.PLCAddressClick = ""
        Me.SquareIlluminatedButton6.PLCAddressText = ""
        Me.SquareIlluminatedButton6.PLCAddressValue = "PROGRAM:ACT_SAWS_B1.dSaws.5"
        Me.SquareIlluminatedButton6.PLCAddressVisible = ""
        Me.SquareIlluminatedButton6.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton6.TabIndex = 5
        Me.SquareIlluminatedButton6.Text = "Saw 8'"
        Me.SquareIlluminatedButton6.Value = False
        '
        'SquareIlluminatedButton5
        '
        Me.SquareIlluminatedButton5.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton5.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton5.Location = New System.Drawing.Point(31, 96)
        Me.SquareIlluminatedButton5.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton5.Name = "SquareIlluminatedButton5"
        Me.SquareIlluminatedButton5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton5.PLCAddressClick = ""
        Me.SquareIlluminatedButton5.PLCAddressText = ""
        Me.SquareIlluminatedButton5.PLCAddressValue = "PROGRAM:ACT_SAWS_B1.dSaws.4"
        Me.SquareIlluminatedButton5.PLCAddressVisible = ""
        Me.SquareIlluminatedButton5.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton5.TabIndex = 4
        Me.SquareIlluminatedButton5.Text = "Saw 7'"
        Me.SquareIlluminatedButton5.Value = False
        '
        'SquareIlluminatedButton4
        '
        Me.SquareIlluminatedButton4.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton4.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton4.Location = New System.Drawing.Point(31, 72)
        Me.SquareIlluminatedButton4.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton4.Name = "SquareIlluminatedButton4"
        Me.SquareIlluminatedButton4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton4.PLCAddressClick = ""
        Me.SquareIlluminatedButton4.PLCAddressText = ""
        Me.SquareIlluminatedButton4.PLCAddressValue = "PROGRAM:ACT_SAWS_B1.dSaws.3"
        Me.SquareIlluminatedButton4.PLCAddressVisible = ""
        Me.SquareIlluminatedButton4.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton4.TabIndex = 3
        Me.SquareIlluminatedButton4.Text = "Saw 6'"
        Me.SquareIlluminatedButton4.Value = False
        '
        'SquareIlluminatedButton3
        '
        Me.SquareIlluminatedButton3.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton3.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton3.Location = New System.Drawing.Point(31, 49)
        Me.SquareIlluminatedButton3.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton3.Name = "SquareIlluminatedButton3"
        Me.SquareIlluminatedButton3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton3.PLCAddressClick = ""
        Me.SquareIlluminatedButton3.PLCAddressText = ""
        Me.SquareIlluminatedButton3.PLCAddressValue = "PROGRAM:ACT_SAWS_B1.dSaws.2"
        Me.SquareIlluminatedButton3.PLCAddressVisible = ""
        Me.SquareIlluminatedButton3.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton3.TabIndex = 2
        Me.SquareIlluminatedButton3.Text = "Saw 4'"
        Me.SquareIlluminatedButton3.Value = False
        '
        'SquareIlluminatedButton2
        '
        Me.SquareIlluminatedButton2.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton2.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton2.Location = New System.Drawing.Point(31, 25)
        Me.SquareIlluminatedButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton2.Name = "SquareIlluminatedButton2"
        Me.SquareIlluminatedButton2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton2.PLCAddressClick = ""
        Me.SquareIlluminatedButton2.PLCAddressText = ""
        Me.SquareIlluminatedButton2.PLCAddressValue = "PROGRAM:ACT_SAWS_B1.dSaws.1"
        Me.SquareIlluminatedButton2.PLCAddressVisible = ""
        Me.SquareIlluminatedButton2.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton2.TabIndex = 1
        Me.SquareIlluminatedButton2.Text = "Saw 2'"
        Me.SquareIlluminatedButton2.Value = False
        '
        'SquareIlluminatedButton1
        '
        Me.SquareIlluminatedButton1.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton1.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton1.Location = New System.Drawing.Point(31, 2)
        Me.SquareIlluminatedButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.SquareIlluminatedButton1.Name = "SquareIlluminatedButton1"
        Me.SquareIlluminatedButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton1.PLCAddressClick = ""
        Me.SquareIlluminatedButton1.PLCAddressText = ""
        Me.SquareIlluminatedButton1.PLCAddressValue = "PROGRAM:ACT_SAWS_B1.dSaws.0"
        Me.SquareIlluminatedButton1.PLCAddressVisible = ""
        Me.SquareIlluminatedButton1.Size = New System.Drawing.Size(71, 19)
        Me.SquareIlluminatedButton1.TabIndex = 0
        Me.SquareIlluminatedButton1.Text = "Saw 0'"
        Me.SquareIlluminatedButton1.Value = False
        '
        'BasicLabel10
        '
        Me.BasicLabel10.AutoSize = True
        Me.BasicLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel10.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel10.ComComponent = Me.TwinCATCom1
        Me.BasicLabel10.DisplayAsTime = False
        Me.BasicLabel10.ForeColor = System.Drawing.Color.White
        Me.BasicLabel10.Highlight = False
        Me.BasicLabel10.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel10.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel10.HighlightKeyCharacter = "!"
        Me.BasicLabel10.InterpretValueAsBCD = False
        Me.BasicLabel10.KeypadAlphanumeric = False
        Me.BasicLabel10.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel10.KeypadMaxValue = 0R
        Me.BasicLabel10.KeypadMinValue = 0R
        Me.BasicLabel10.KeypadScaleFactor = 1.0R
        Me.BasicLabel10.KeypadShowCurrentValue = False
        Me.BasicLabel10.KeypadText = Nothing
        Me.BasicLabel10.KeypadWidth = 300
        Me.BasicLabel10.Location = New System.Drawing.Point(224, 150)
        Me.BasicLabel10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BasicLabel10.Name = "BasicLabel10"
        Me.BasicLabel10.NumericFormat = Nothing
        Me.BasicLabel10.PLCAddressKeypad = ""
        Me.BasicLabel10.PLCAddressValue = "MAIN.dTemp"
        Me.BasicLabel10.Size = New System.Drawing.Size(81, 13)
        Me.BasicLabel10.TabIndex = 292
        Me.BasicLabel10.Text = "dTemp-Twincat"
        Me.BasicLabel10.Value = "dTemp-Twincat"
        Me.BasicLabel10.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel10.ValueLeftPadLength = 0
        Me.BasicLabel10.ValuePrefix = Nothing
        Me.BasicLabel10.ValueScaleFactor = 0R
        Me.BasicLabel10.ValueSuffix = Nothing
        Me.BasicLabel10.ValueToSubtractFrom = 0!
        '
        'TwinCATCom1
        '
        Me.TwinCATCom1.DisableSubScriptions = False
        Me.TwinCATCom1.IniFileName = ""
        Me.TwinCATCom1.IniFileSection = Nothing
        Me.TwinCATCom1.Password = "autolog"
        Me.TwinCATCom1.PollRateOverride = 50
        Me.TwinCATCom1.SynchronizingObject = Me
        Me.TwinCATCom1.TargetAMSNetID = "192.168.93.1.1.1"
        Me.TwinCATCom1.TargetAMSPort = CType(851US, UShort)
        Me.TwinCATCom1.TargetIPAddress = "192.168.0.115"
        Me.TwinCATCom1.UserName = "autolog"
        Me.TwinCATCom1.UseStaticRoute = True
        '
        'SelectorSwitch1
        '
        Me.SelectorSwitch1.BackColor = System.Drawing.Color.Transparent
        Me.SelectorSwitch1.BackgroundImage = CType(resources.GetObject("SelectorSwitch1.BackgroundImage"), System.Drawing.Image)
        Me.SelectorSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SelectorSwitch1.ComComponent = Me.ModbusTCPCom1
        Me.SelectorSwitch1.LegendPlate = MfgControl.AdvancedHMI.Controls.SelectorSwitch.LegendPlates.Large
        Me.SelectorSwitch1.Location = New System.Drawing.Point(412, 206)
        Me.SelectorSwitch1.Margin = New System.Windows.Forms.Padding(2)
        Me.SelectorSwitch1.Name = "SelectorSwitch1"
        Me.SelectorSwitch1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.SelectorSwitch1.PLCAddressClick = "40003"
        Me.SelectorSwitch1.PLCAddressText = ""
        Me.SelectorSwitch1.PLCAddressValue = "40003"
        Me.SelectorSwitch1.PLCAddressVisible = ""
        Me.SelectorSwitch1.Size = New System.Drawing.Size(62, 91)
        Me.SelectorSwitch1.TabIndex = 290
        Me.SelectorSwitch1.Text = "SelectorSwitch1"
        Me.SelectorSwitch1.Value = False
        '
        'ModbusTCPCom1
        '
        Me.ModbusTCPCom1.DisableSubscriptions = False
        Me.ModbusTCPCom1.IniFileName = ""
        Me.ModbusTCPCom1.IniFileSection = Nothing
        Me.ModbusTCPCom1.IPAddress = "150.150.10.69"
        Me.ModbusTCPCom1.MaxReadGroupSize = 20
        Me.ModbusTCPCom1.PollRateOverride = 50
        Me.ModbusTCPCom1.SwapBytes = True
        Me.ModbusTCPCom1.SwapWords = False
        Me.ModbusTCPCom1.TagAliasFile = ".\TagAlias.txt"
        Me.ModbusTCPCom1.TcpipPort = CType(502US, UShort)
        Me.ModbusTCPCom1.TimeOut = 3000
        Me.ModbusTCPCom1.UnitId = CType(4, Byte)
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.Color.LightGray
        Me.BasicButton1.ComComponent = Me.ModbusTCPCom1
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAlternate = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(412, 182)
        Me.BasicButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BasicButton1.PLCAddressClick = "40003"
        Me.BasicButton1.PLCAddressHighlightX = "40003.00"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(197, 19)
        Me.BasicButton1.TabIndex = 289
        Me.BasicButton1.Text = "BasicButton1"
        Me.BasicButton1.TextAlternate = Nothing
        Me.BasicButton1.UseVisualStyleBackColor = True
        Me.BasicButton1.ValueToWrite = 1
        '
        'KeyboardInput1
        '
        Me.KeyboardInput1.ClearAfterEnterKey = True
        Me.KeyboardInput1.ComComponent = Me.ModbusTCPCom1
        Me.KeyboardInput1.GetFocusMatchValue = 1
        Me.KeyboardInput1.GetFocusValue = 0
        Me.KeyboardInput1.Location = New System.Drawing.Point(412, 159)
        Me.KeyboardInput1.Margin = New System.Windows.Forms.Padding(2)
        Me.KeyboardInput1.Name = "KeyboardInput1"
        Me.KeyboardInput1.PLCAddressGetFocusValue = Nothing
        Me.KeyboardInput1.PLCAddressWriteValue = New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("40002", 1)
        Me.KeyboardInput1.Size = New System.Drawing.Size(119, 20)
        Me.KeyboardInput1.TabIndex = 288
        '
        'BasicLabel5
        '
        Me.BasicLabel5.AutoSize = True
        Me.BasicLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel5.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel5.ComComponent = Me.ModbusTCPCom1
        Me.BasicLabel5.DisplayAsTime = False
        Me.BasicLabel5.ForeColor = System.Drawing.Color.White
        Me.BasicLabel5.Highlight = False
        Me.BasicLabel5.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel5.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel5.HighlightKeyCharacter = "!"
        Me.BasicLabel5.InterpretValueAsBCD = False
        Me.BasicLabel5.KeypadAlphanumeric = False
        Me.BasicLabel5.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel5.KeypadMaxValue = 0R
        Me.BasicLabel5.KeypadMinValue = 0R
        Me.BasicLabel5.KeypadScaleFactor = 1.0R
        Me.BasicLabel5.KeypadShowCurrentValue = False
        Me.BasicLabel5.KeypadText = Nothing
        Me.BasicLabel5.KeypadWidth = 300
        Me.BasicLabel5.Location = New System.Drawing.Point(410, 135)
        Me.BasicLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BasicLabel5.Name = "BasicLabel5"
        Me.BasicLabel5.NumericFormat = Nothing
        Me.BasicLabel5.PLCAddressKeypad = ""
        Me.BasicLabel5.PLCAddressValue = "30002"
        Me.BasicLabel5.Size = New System.Drawing.Size(53, 13)
        Me.BasicLabel5.TabIndex = 285
        Me.BasicLabel5.Text = "Codesys3"
        Me.BasicLabel5.Value = "Codesys3"
        Me.BasicLabel5.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel5.ValueLeftPadLength = 0
        Me.BasicLabel5.ValuePrefix = Nothing
        Me.BasicLabel5.ValueScaleFactor = 0.01R
        Me.BasicLabel5.ValueSuffix = Nothing
        Me.BasicLabel5.ValueToSubtractFrom = 0!
        '
        'BasicLabel4
        '
        Me.BasicLabel4.AutoSize = True
        Me.BasicLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel4.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel4.ComComponent = Me.ModbusTCPCom1
        Me.BasicLabel4.DisplayAsTime = False
        Me.BasicLabel4.ForeColor = System.Drawing.Color.White
        Me.BasicLabel4.Highlight = False
        Me.BasicLabel4.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel4.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel4.HighlightKeyCharacter = "!"
        Me.BasicLabel4.InterpretValueAsBCD = False
        Me.BasicLabel4.KeypadAlphanumeric = False
        Me.BasicLabel4.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel4.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel4.KeypadMaxValue = 0R
        Me.BasicLabel4.KeypadMinValue = 0R
        Me.BasicLabel4.KeypadScaleFactor = 1.0R
        Me.BasicLabel4.KeypadShowCurrentValue = False
        Me.BasicLabel4.KeypadText = Nothing
        Me.BasicLabel4.KeypadWidth = 300
        Me.BasicLabel4.Location = New System.Drawing.Point(410, 45)
        Me.BasicLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BasicLabel4.Name = "BasicLabel4"
        Me.BasicLabel4.NumericFormat = Nothing
        Me.BasicLabel4.PLCAddressKeypad = ""
        Me.BasicLabel4.PLCAddressValue = "1"
        Me.BasicLabel4.Size = New System.Drawing.Size(53, 13)
        Me.BasicLabel4.TabIndex = 284
        Me.BasicLabel4.Text = "Codesys0"
        Me.BasicLabel4.Value = "Codesys0"
        Me.BasicLabel4.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel4.ValueLeftPadLength = 0
        Me.BasicLabel4.ValuePrefix = Nothing
        Me.BasicLabel4.ValueScaleFactor = 1.0R
        Me.BasicLabel4.ValueSuffix = Nothing
        Me.BasicLabel4.ValueToSubtractFrom = 0!
        '
        'BasicLabel3
        '
        Me.BasicLabel3.AutoSize = True
        Me.BasicLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel3.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel3.ComComponent = Me.ModbusTCPCom1
        Me.BasicLabel3.DisplayAsTime = False
        Me.BasicLabel3.ForeColor = System.Drawing.Color.White
        Me.BasicLabel3.Highlight = False
        Me.BasicLabel3.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel3.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel3.HighlightKeyCharacter = "!"
        Me.BasicLabel3.InterpretValueAsBCD = False
        Me.BasicLabel3.KeypadAlphanumeric = False
        Me.BasicLabel3.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel3.KeypadMaxValue = 0R
        Me.BasicLabel3.KeypadMinValue = 0R
        Me.BasicLabel3.KeypadScaleFactor = 1.0R
        Me.BasicLabel3.KeypadShowCurrentValue = False
        Me.BasicLabel3.KeypadText = Nothing
        Me.BasicLabel3.KeypadWidth = 300
        Me.BasicLabel3.Location = New System.Drawing.Point(410, 106)
        Me.BasicLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BasicLabel3.Name = "BasicLabel3"
        Me.BasicLabel3.NumericFormat = Nothing
        Me.BasicLabel3.PLCAddressKeypad = ""
        Me.BasicLabel3.PLCAddressValue = "30001"
        Me.BasicLabel3.Size = New System.Drawing.Size(53, 13)
        Me.BasicLabel3.TabIndex = 283
        Me.BasicLabel3.Text = "Codesys2"
        Me.BasicLabel3.Value = "Codesys2"
        Me.BasicLabel3.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel3.ValueLeftPadLength = 0
        Me.BasicLabel3.ValuePrefix = Nothing
        Me.BasicLabel3.ValueScaleFactor = 1.0R
        Me.BasicLabel3.ValueSuffix = Nothing
        Me.BasicLabel3.ValueToSubtractFrom = 0!
        '
        'BasicLabel2
        '
        Me.BasicLabel2.AutoSize = True
        Me.BasicLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel2.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel2.ComComponent = Me.ModbusTCPCom1
        Me.BasicLabel2.DisplayAsTime = False
        Me.BasicLabel2.ForeColor = System.Drawing.Color.White
        Me.BasicLabel2.Highlight = False
        Me.BasicLabel2.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel2.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel2.HighlightKeyCharacter = "!"
        Me.BasicLabel2.InterpretValueAsBCD = False
        Me.BasicLabel2.KeypadAlphanumeric = False
        Me.BasicLabel2.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel2.KeypadMaxValue = 0R
        Me.BasicLabel2.KeypadMinValue = 0R
        Me.BasicLabel2.KeypadScaleFactor = 1.0R
        Me.BasicLabel2.KeypadShowCurrentValue = False
        Me.BasicLabel2.KeypadText = Nothing
        Me.BasicLabel2.KeypadWidth = 300
        Me.BasicLabel2.Location = New System.Drawing.Point(410, 76)
        Me.BasicLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BasicLabel2.Name = "BasicLabel2"
        Me.BasicLabel2.NumericFormat = Nothing
        Me.BasicLabel2.PLCAddressKeypad = ""
        Me.BasicLabel2.PLCAddressValue = "10001"
        Me.BasicLabel2.Size = New System.Drawing.Size(53, 13)
        Me.BasicLabel2.TabIndex = 282
        Me.BasicLabel2.Text = "Codesys1"
        Me.BasicLabel2.Value = "Codesys1"
        Me.BasicLabel2.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel2.ValueLeftPadLength = 0
        Me.BasicLabel2.ValuePrefix = Nothing
        Me.BasicLabel2.ValueScaleFactor = 1.0R
        Me.BasicLabel2.ValueSuffix = Nothing
        Me.BasicLabel2.ValueToSubtractFrom = 0!
        '
        'BasicLabel89
        '
        Me.BasicLabel89.AllowDrop = True
        Me.BasicLabel89.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel89.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel89.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel89.DisplayAsTime = False
        Me.BasicLabel89.ForeColor = System.Drawing.Color.White
        Me.BasicLabel89.Highlight = False
        Me.BasicLabel89.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel89.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel89.HighlightKeyCharacter = "!"
        Me.BasicLabel89.InterpretValueAsBCD = False
        Me.BasicLabel89.KeypadAlphanumeric = False
        Me.BasicLabel89.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel89.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel89.KeypadMaxValue = 0R
        Me.BasicLabel89.KeypadMinValue = 0R
        Me.BasicLabel89.KeypadScaleFactor = 1.0R
        Me.BasicLabel89.KeypadShowCurrentValue = False
        Me.BasicLabel89.KeypadText = Nothing
        Me.BasicLabel89.KeypadWidth = 300
        Me.BasicLabel89.Location = New System.Drawing.Point(203, 32)
        Me.BasicLabel89.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BasicLabel89.Name = "BasicLabel89"
        Me.BasicLabel89.NumericFormat = Nothing
        Me.BasicLabel89.PLCAddressKeypad = ""
        Me.BasicLabel89.PLCAddressValue = "PROGRAM:PRODUCTION_DISPLAY.szDisplayString"
        Me.BasicLabel89.Size = New System.Drawing.Size(135, 19)
        Me.BasicLabel89.TabIndex = 280
        Me.BasicLabel89.Text = "Production Display String"
        Me.BasicLabel89.Value = "Production Display String"
        Me.BasicLabel89.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel89.ValueLeftPadLength = 0
        Me.BasicLabel89.ValuePrefix = Nothing
        Me.BasicLabel89.ValueScaleFactor = 1.0R
        Me.BasicLabel89.ValueSuffix = Nothing
        Me.BasicLabel89.ValueToSubtractFrom = 0!
        '
        'ProductionDisplay
        '
        Me.ProductionDisplay.AutoSize = True
        Me.ProductionDisplay.BackColor = System.Drawing.Color.Transparent
        Me.ProductionDisplay.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.ProductionDisplay.ComComponent = Me.EthernetIPforCLXCom1
        Me.ProductionDisplay.DisplayAsTime = False
        Me.ProductionDisplay.ForeColor = System.Drawing.Color.White
        Me.ProductionDisplay.Highlight = False
        Me.ProductionDisplay.HighlightColor = System.Drawing.Color.Red
        Me.ProductionDisplay.HighlightForeColor = System.Drawing.Color.White
        Me.ProductionDisplay.HighlightKeyCharacter = "!"
        Me.ProductionDisplay.InterpretValueAsBCD = False
        Me.ProductionDisplay.KeypadAlphanumeric = False
        Me.ProductionDisplay.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.ProductionDisplay.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.ProductionDisplay.KeypadMaxValue = 0R
        Me.ProductionDisplay.KeypadMinValue = 0R
        Me.ProductionDisplay.KeypadScaleFactor = 1.0R
        Me.ProductionDisplay.KeypadShowCurrentValue = False
        Me.ProductionDisplay.KeypadText = Nothing
        Me.ProductionDisplay.KeypadWidth = 300
        Me.ProductionDisplay.Location = New System.Drawing.Point(34, 32)
        Me.ProductionDisplay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ProductionDisplay.Name = "ProductionDisplay"
        Me.ProductionDisplay.NumericFormat = Nothing
        Me.ProductionDisplay.PLCAddressKeypad = ""
        Me.ProductionDisplay.Size = New System.Drawing.Size(124, 13)
        Me.ProductionDisplay.TabIndex = 279
        Me.ProductionDisplay.Text = "Afficheur du Production: "
        Me.ProductionDisplay.Value = ""
        Me.ProductionDisplay.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.ProductionDisplay.ValueLeftPadLength = 0
        Me.ProductionDisplay.ValuePrefix = "Afficheur du Production: "
        Me.ProductionDisplay.ValueScaleFactor = 1.0R
        Me.ProductionDisplay.ValueSuffix = Nothing
        Me.ProductionDisplay.ValueToSubtractFrom = 0!
        '
        'BasicLabel1
        '
        Me.BasicLabel1.AutoSize = True
        Me.BasicLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel1.DisplayAsTime = False
        Me.BasicLabel1.ForeColor = System.Drawing.Color.White
        Me.BasicLabel1.Highlight = False
        Me.BasicLabel1.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel1.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel1.HighlightKeyCharacter = "!"
        Me.BasicLabel1.InterpretValueAsBCD = False
        Me.BasicLabel1.KeypadAlphanumeric = False
        Me.BasicLabel1.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.KeypadMaxValue = 0R
        Me.BasicLabel1.KeypadMinValue = 0R
        Me.BasicLabel1.KeypadScaleFactor = 1.0R
        Me.BasicLabel1.KeypadShowCurrentValue = False
        Me.BasicLabel1.KeypadText = Nothing
        Me.BasicLabel1.KeypadWidth = 300
        Me.BasicLabel1.Location = New System.Drawing.Point(57, 108)
        Me.BasicLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = Nothing
        Me.BasicLabel1.PLCAddressKeypad = ""
        Me.BasicLabel1.Size = New System.Drawing.Size(149, 13)
        Me.BasicLabel1.TabIndex = 252
        Me.BasicLabel1.Text = "Activer les erreurs d'operation:"
        Me.BasicLabel1.Value = ""
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel1.ValueLeftPadLength = 0
        Me.BasicLabel1.ValuePrefix = "Activer les erreurs d'operation:"
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = Nothing
        Me.BasicLabel1.ValueToSubtractFrom = 0!
        '
        'BasicLabel70
        '
        Me.BasicLabel70.AutoSize = True
        Me.BasicLabel70.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel70.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel70.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel70.DisplayAsTime = False
        Me.BasicLabel70.ForeColor = System.Drawing.Color.White
        Me.BasicLabel70.Highlight = False
        Me.BasicLabel70.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel70.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel70.HighlightKeyCharacter = "!"
        Me.BasicLabel70.InterpretValueAsBCD = False
        Me.BasicLabel70.KeypadAlphanumeric = False
        Me.BasicLabel70.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel70.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel70.KeypadMaxValue = 0R
        Me.BasicLabel70.KeypadMinValue = 0R
        Me.BasicLabel70.KeypadScaleFactor = 1.0R
        Me.BasicLabel70.KeypadShowCurrentValue = False
        Me.BasicLabel70.KeypadText = Nothing
        Me.BasicLabel70.KeypadWidth = 300
        Me.BasicLabel70.Location = New System.Drawing.Point(57, 77)
        Me.BasicLabel70.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BasicLabel70.Name = "BasicLabel70"
        Me.BasicLabel70.NumericFormat = Nothing
        Me.BasicLabel70.PLCAddressKeypad = ""
        Me.BasicLabel70.Size = New System.Drawing.Size(149, 13)
        Me.BasicLabel70.TabIndex = 250
        Me.BasicLabel70.Text = "Activer les erreurs d'operation:"
        Me.BasicLabel70.Value = ""
        Me.BasicLabel70.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel70.ValueLeftPadLength = 0
        Me.BasicLabel70.ValuePrefix = "Activer les erreurs d'operation:"
        Me.BasicLabel70.ValueScaleFactor = 1.0R
        Me.BasicLabel70.ValueSuffix = Nothing
        Me.BasicLabel70.ValueToSubtractFrom = 0!
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox1.Location = New System.Drawing.Point(227, 78)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.PLCAddressCheckChanged = ""
        Me.CheckBox1.PLCAddressChecked = ""
        Me.CheckBox1.PLCAddressText = ""
        Me.CheckBox1.PLCAddressVisible = ""
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DataSubscriber21
        '
        Me.DataSubscriber21.ComComponent = Me.EthernetIPforCLXCom1
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("g_dAdvHmiLugIdxTrig", 1, "LugId"))
        '
        'BasicLabel11
        '
        Me.BasicLabel11.AutoSize = True
        Me.BasicLabel11.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel11.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel11.ComComponent = Me.TwinCATCom1
        Me.BasicLabel11.DisplayAsTime = False
        Me.BasicLabel11.ForeColor = System.Drawing.Color.White
        Me.BasicLabel11.Highlight = False
        Me.BasicLabel11.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel11.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel11.HighlightKeyCharacter = "!"
        Me.BasicLabel11.InterpretValueAsBCD = False
        Me.BasicLabel11.KeypadAlphanumeric = False
        Me.BasicLabel11.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel11.KeypadMaxValue = 0R
        Me.BasicLabel11.KeypadMinValue = 0R
        Me.BasicLabel11.KeypadScaleFactor = 1.0R
        Me.BasicLabel11.KeypadShowCurrentValue = False
        Me.BasicLabel11.KeypadText = Nothing
        Me.BasicLabel11.KeypadWidth = 300
        Me.BasicLabel11.Location = New System.Drawing.Point(224, 166)
        Me.BasicLabel11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BasicLabel11.Name = "BasicLabel11"
        Me.BasicLabel11.NumericFormat = Nothing
        Me.BasicLabel11.PLCAddressKeypad = ""
        Me.BasicLabel11.PLCAddressValue = "g_dTemp"
        Me.BasicLabel11.Size = New System.Drawing.Size(93, 13)
        Me.BasicLabel11.TabIndex = 293
        Me.BasicLabel11.Text = "g_dTemp-Twincat"
        Me.BasicLabel11.Value = "g_dTemp-Twincat"
        Me.BasicLabel11.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel11.ValueLeftPadLength = 0
        Me.BasicLabel11.ValuePrefix = Nothing
        Me.BasicLabel11.ValueScaleFactor = 0R
        Me.BasicLabel11.ValueSuffix = Nothing
        Me.BasicLabel11.ValueToSubtractFrom = 0!
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(56, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 294
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(57, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 295
        Me.Label2.Text = "Label2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'MiscParams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1426, 808)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BasicLabel11)
        Me.Controls.Add(Me.BasicLabel10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SelectorSwitch1)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.KeyboardInput1)
        Me.Controls.Add(Me.BasicLabel5)
        Me.Controls.Add(Me.BasicLabel4)
        Me.Controls.Add(Me.BasicLabel3)
        Me.Controls.Add(Me.BasicLabel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BasicLabel89)
        Me.Controls.Add(Me.ProductionDisplay)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BasicLabel70)
        Me.Controls.Add(Me.CheckBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MiscParams"
        Me.Text = "ZeroitAppBar1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TwinCATCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriber21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox1 As AdvancedHMIControls.CheckBox
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BasicLabel70 As AdvancedHMIControls.BasicLabel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents BasicLabel89 As AdvancedHMIControls.BasicLabel
    Friend WithEvents ProductionDisplay As AdvancedHMIControls.BasicLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSubscriber21 As AdvancedHMIControls.DataSubscriber2
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents LugId As DataGridViewTextBoxColumn
    Friend WithEvents OptiId As DataGridViewTextBoxColumn
    Friend WithEvents Destination As DataGridViewTextBoxColumn
    Friend WithEvents Sort As DataGridViewTextBoxColumn
    Friend WithEvents BinNumber As DataGridViewTextBoxColumn
    Friend WithEvents NomDims As DataGridViewTextBoxColumn
    Friend WithEvents ModbusTCPCom1 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents BasicLabel2 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel3 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel4 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel5 As AdvancedHMIControls.BasicLabel
    Friend WithEvents KeyboardInput1 As AdvancedHMIControls.KeyboardInput
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents SelectorSwitch1 As AdvancedHMIControls.SelectorSwitch
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BasicLabel8 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel9 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel7 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel6 As AdvancedHMIControls.BasicLabel
    Friend WithEvents SquareIlluminatedButton17 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton16 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton15 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton14 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton13 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton12 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton11 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton10 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton9 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton8 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton7 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton6 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton5 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton4 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton3 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton2 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton1 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton18 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton19 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton20 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton21 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton22 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton23 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton24 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton25 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton26 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton27 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton28 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents TwinCATCom1 As AdvancedHMIDrivers.TwinCATCom
    Friend WithEvents BasicLabel10 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel11 As AdvancedHMIControls.BasicLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class
