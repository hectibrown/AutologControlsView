<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Simulation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Simulation))
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.DataSubscriber21 = New AdvancedHMIControls.DataSubscriber2(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LugLoaderIdx = New System.Windows.Forms.Label()
        Me.SimulLoaderOnce = New AdvancedHMIControls.BasicButton()
        Me.SimulLugLoader = New AdvancedHMIControls.BasicButton()
        Me.SimulEncoderButton = New AdvancedHMIControls.BasicButton()
        Me.LineSpeedInput = New System.Windows.Forms.NumericUpDown()
        Me.LineSpeedLabel = New System.Windows.Forms.Label()
        Me.LugSlaveIdx = New System.Windows.Forms.Label()
        Me.LugMasterIdx = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RemanCheckBox = New AdvancedHMIControls.CheckBox()
        Me.SlashCheckBox = New AdvancedHMIControls.CheckBox()
        Me.SpeciesInput = New AdvancedHMIControls.KeyboardInput()
        Me.SpeciesLabel = New System.Windows.Forms.Label()
        Me.FeDestInput = New AdvancedHMIControls.KeyboardInput()
        Me.NeDestInput = New AdvancedHMIControls.KeyboardInput()
        Me.NeGradeInput = New AdvancedHMIControls.KeyboardInput()
        Me.FeGradeInout = New AdvancedHMIControls.KeyboardInput()
        Me.FeDestLabel = New System.Windows.Forms.Label()
        Me.NeDestLabel = New System.Windows.Forms.Label()
        Me.FeGradeLabel = New System.Windows.Forms.Label()
        Me.NeGradeLabel = New System.Windows.Forms.Label()
        Me.FenceValInput = New AdvancedHMIControls.KeyboardInput()
        Me.FenceValLabel = New System.Windows.Forms.Label()
        Me.FeCitTrimInput = New AdvancedHMIControls.KeyboardInput()
        Me.NeCitTrimInput = New AdvancedHMIControls.KeyboardInput()
        Me.NeTrimInput = New AdvancedHMIControls.KeyboardInput()
        Me.FeTrimInput = New AdvancedHMIControls.KeyboardInput()
        Me.FeCitTrimLabel = New System.Windows.Forms.Label()
        Me.NeCitTrimLabel = New System.Windows.Forms.Label()
        Me.FeTrimLabel = New System.Windows.Forms.Label()
        Me.NeTrimLabel = New System.Windows.Forms.Label()
        Me.SimulCypress = New AdvancedHMIControls.BasicButton()
        Me.CypressLugIdx = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.LS16fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS15fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS14fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS13fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS12fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS11fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS10fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS9fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS8fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS7fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS6fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS3fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS0fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.CheckBox12 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox11 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox10 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox9 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox8 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox7 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox6 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox5 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox4 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox3 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox2 = New AdvancedHMIControls.CheckBox()
        Me.ReadWidthIdx = New System.Windows.Forms.Label()
        Me.SimulReadWidth = New AdvancedHMIControls.BasicButton()
        Me.CheckBox1 = New AdvancedHMIControls.CheckBox()
        Me.Ls0Check = New AdvancedHMIControls.CheckBox()
        Me.ReadWidthInput = New AdvancedHMIControls.KeyboardInput()
        Me.ReadWidthLabel = New System.Windows.Forms.Label()
        Me.SimulReadLen1 = New AdvancedHMIControls.BasicButton()
        Me.ReadLen1Idx = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.AnalogValueDisplay1 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.FenceCheckLugIdx = New System.Windows.Forms.Label()
        Me.SquareIlluminatedButton61 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton62 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton60 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton59 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton56 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton57 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton58 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton53 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton54 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton55 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton50 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton51 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton52 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton49 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton48 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton47 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.FenceSkidLugIdx = New System.Windows.Forms.Label()
        Me.FenceLugIdx = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.SquareIlluminatedButton63 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.BasicLabel3 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel2 = New AdvancedHMIControls.BasicLabel()
        Me.LS0_2fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS6_2fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS8_2fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS10_2fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS12_2fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS14_2fbk = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.LS16_2fbk = New AdvancedHMIControls.SquareIlluminatedButton()
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
        Me.CheckBox13 = New AdvancedHMIControls.CheckBox()
        Me.SimulReadLen2Button = New AdvancedHMIControls.BasicButton()
        Me.CheckBox17 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox30 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox39 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox41 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox43 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox52 = New AdvancedHMIControls.CheckBox()
        Me.CitSkidLugIdx = New System.Windows.Forms.Label()
        Me.ReadLen2LugIdx = New System.Windows.Forms.Label()
        Me.SawsLugIdx = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.SquareIlluminatedButton21 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton20 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton19 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton18 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton17 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton16 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton15 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton14 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.BasicButton2 = New AdvancedHMIControls.BasicButton()
        Me.CheckBox48 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox49 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox50 = New AdvancedHMIControls.CheckBox()
        Me.CheckBox51 = New AdvancedHMIControls.CheckBox()
        Me.PositionConfLugIdx = New System.Windows.Forms.Label()
        Me.PositionSkidLugIdx = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.SquareIlluminatedButton46 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton45 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton44 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton43 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton42 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton41 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton40 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton39 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton38 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton37 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton36 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton35 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton34 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton33 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton32 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton31 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton30 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton29 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton28 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton27 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton26 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton25 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton24 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton23 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SquareIlluminatedButton22 = New AdvancedHMIControls.SquareIlluminatedButton()
        Me.SimulPresSorterButton = New AdvancedHMIControls.BasicButton()
        Me.HistoryLugIdx = New System.Windows.Forms.Label()
        Me.PresSorterLugIdx = New System.Windows.Forms.Label()
        Me.ReadInputValuesButton = New AdvancedHMIControls.BasicButton()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriber21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LineSpeedInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "150.150.10.155"
        Me.EthernetIPforCLXCom1.PollRateOverride = 200
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'DataSubscriber21
        '
        Me.DataSubscriber21.ComComponent = Me.EthernetIPforCLXCom1
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("PROGRAM:LUG_MASTER._SimulEnCoder", 1, "LugMaster Running"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("PROGRAM:LUG_SLAVE._SimulEnCoder", 1, "LugSlave Running"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("PROGRAM:LUG_MASTER._Lug.Encoder.Data.dLugIdx", 1, "Lug Master Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("PROGRAM:LUG_SLAVE._Lug.Encoder.Data.dLugIdx", 1, "Lug Slave Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_LUG_LOADER.ActManager.dIndexLug", 1, "Lug Loader Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_CYPRESS_ETHERNET.ActManager.dIndexLug", 1, "Cypress Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_READ_LENGTH_1.ActManager.dIndexLug", 1, "Read Len 1 Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_READ_WIDTH.ActManager.dIndexLug", 1, "Read Width Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_FENCES_PNEUMATIC.ActManager.dIndexLug", 1, "Fence Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_SKIDS.ActManager.dIndexLug", 1, "Fence Skid Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_READ_LENGTH_2.ActManager.dIndexLug", 1, "Read Len 2 Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_SAWS.ActManager.dIndexLug", 1, "Saw Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_CIT_SKID.ActManager.dIndexLug", 1, "CIT Skid Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_BUMPERS.ActManager.dIndexLug", 1, "Pos Skid Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_BOARD_CENTERED_CONFIRMATION.ActManager.dIndexLug", 1, "Len Conf Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem(Nothing, 1))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem(Nothing, 1))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_PRES_SORTER.ActManager.dIndexLug", 1, "Pres Sorter Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_HISTORY.ActManager.dIndexLug", 1, "History Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_LOST_PIECE.ActManager.dIndexLug", 1, "Lost Piece Idx"))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_FENCE_CHECKER.ActManager.dIndexLug", 1, "Fence Check Idx"))
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LugLoaderIdx)
        Me.GroupBox1.Controls.Add(Me.SimulLoaderOnce)
        Me.GroupBox1.Controls.Add(Me.SimulLugLoader)
        Me.GroupBox1.Controls.Add(Me.SimulEncoderButton)
        Me.GroupBox1.Controls.Add(Me.LineSpeedInput)
        Me.GroupBox1.Controls.Add(Me.LineSpeedLabel)
        Me.GroupBox1.Controls.Add(Me.LugSlaveIdx)
        Me.GroupBox1.Controls.Add(Me.LugMasterIdx)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 444)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'LugLoaderIdx
        '
        Me.LugLoaderIdx.AutoSize = True
        Me.LugLoaderIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LugLoaderIdx.Location = New System.Drawing.Point(230, 85)
        Me.LugLoaderIdx.Name = "LugLoaderIdx"
        Me.LugLoaderIdx.Size = New System.Drawing.Size(94, 17)
        Me.LugLoaderIdx.TabIndex = 7
        Me.LugLoaderIdx.Text = "LugLoaderIdx"
        '
        'SimulLoaderOnce
        '
        Me.SimulLoaderOnce.BackColor = System.Drawing.Color.LightGray
        Me.SimulLoaderOnce.ComComponent = Me.EthernetIPforCLXCom1
        Me.SimulLoaderOnce.ForeColor = System.Drawing.Color.Black
        Me.SimulLoaderOnce.ForeColorAlternate = System.Drawing.Color.Black
        Me.SimulLoaderOnce.Highlight = False
        Me.SimulLoaderOnce.HighlightColor = System.Drawing.Color.Green
        Me.SimulLoaderOnce.Location = New System.Drawing.Point(230, 45)
        Me.SimulLoaderOnce.MaximumHoldTime = 3000
        Me.SimulLoaderOnce.MinimumHoldTime = 500
        Me.SimulLoaderOnce.Name = "SimulLoaderOnce"
        Me.SimulLoaderOnce.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.SimulLoaderOnce.PLCAddressClick = "PROGRAM:ACT_LUG_LOADER._LugLoader.bAct_SimulOneBoard"
        Me.SimulLoaderOnce.PLCAddressHighlightX = "PROGRAM:ACT_LUG_LOADER._LugLoader.bAct_SimulOneBoard"
        Me.SimulLoaderOnce.SelectTextAlternate = False
        Me.SimulLoaderOnce.Size = New System.Drawing.Size(167, 30)
        Me.SimulLoaderOnce.TabIndex = 6
        Me.SimulLoaderOnce.Text = "Simul Lug Loader Once"
        Me.SimulLoaderOnce.TextAlternate = Nothing
        Me.SimulLoaderOnce.UseVisualStyleBackColor = True
        Me.SimulLoaderOnce.ValueToWrite = 0
        '
        'SimulLugLoader
        '
        Me.SimulLugLoader.BackColor = System.Drawing.Color.LightGray
        Me.SimulLugLoader.ComComponent = Me.EthernetIPforCLXCom1
        Me.SimulLugLoader.ForeColor = System.Drawing.Color.Black
        Me.SimulLugLoader.ForeColorAlternate = System.Drawing.Color.Black
        Me.SimulLugLoader.Highlight = False
        Me.SimulLugLoader.HighlightColor = System.Drawing.Color.Green
        Me.SimulLugLoader.Location = New System.Drawing.Point(230, 15)
        Me.SimulLugLoader.MaximumHoldTime = 3000
        Me.SimulLugLoader.MinimumHoldTime = 500
        Me.SimulLugLoader.Name = "SimulLugLoader"
        Me.SimulLugLoader.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.SimulLugLoader.PLCAddressClick = "PROGRAM:ACT_LUG_LOADER._LugLoader.bAct_Simul"
        Me.SimulLugLoader.PLCAddressHighlightX = "PROGRAM:ACT_LUG_LOADER._LugLoader.bAct_Simul"
        Me.SimulLugLoader.SelectTextAlternate = False
        Me.SimulLugLoader.Size = New System.Drawing.Size(167, 30)
        Me.SimulLugLoader.SuppressErrorDisplay = True
        Me.SimulLugLoader.TabIndex = 5
        Me.SimulLugLoader.Text = "Simul Lug Loader"
        Me.SimulLugLoader.TextAlternate = Nothing
        Me.SimulLugLoader.UseVisualStyleBackColor = True
        Me.SimulLugLoader.ValueToWrite = 0
        '
        'SimulEncoderButton
        '
        Me.SimulEncoderButton.BackColor = System.Drawing.Color.LightGray
        Me.SimulEncoderButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.SimulEncoderButton.ForeColor = System.Drawing.Color.Black
        Me.SimulEncoderButton.ForeColorAlternate = System.Drawing.Color.Black
        Me.SimulEncoderButton.Highlight = False
        Me.SimulEncoderButton.HighlightColor = System.Drawing.Color.Green
        Me.SimulEncoderButton.Location = New System.Drawing.Point(30, 15)
        Me.SimulEncoderButton.MaximumHoldTime = 3000
        Me.SimulEncoderButton.MinimumHoldTime = 500
        Me.SimulEncoderButton.Name = "SimulEncoderButton"
        Me.SimulEncoderButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.SimulEncoderButton.PLCAddressClick = "g_Par.Misc.bSimulEncoder"
        Me.SimulEncoderButton.PLCAddressHighlightX = "g_Par.Misc.bSimulEncoder"
        Me.SimulEncoderButton.SelectTextAlternate = False
        Me.SimulEncoderButton.Size = New System.Drawing.Size(167, 60)
        Me.SimulEncoderButton.TabIndex = 4
        Me.SimulEncoderButton.Text = "Simul Encoders"
        Me.SimulEncoderButton.TextAlternate = Nothing
        Me.SimulEncoderButton.UseVisualStyleBackColor = True
        Me.SimulEncoderButton.ValueToWrite = 0
        '
        'LineSpeedInput
        '
        Me.LineSpeedInput.Location = New System.Drawing.Point(118, 176)
        Me.LineSpeedInput.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.LineSpeedInput.Name = "LineSpeedInput"
        Me.LineSpeedInput.Size = New System.Drawing.Size(80, 22)
        Me.LineSpeedInput.TabIndex = 3
        Me.LineSpeedInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LineSpeedInput.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'LineSpeedLabel
        '
        Me.LineSpeedLabel.AutoSize = True
        Me.LineSpeedLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LineSpeedLabel.Location = New System.Drawing.Point(28, 176)
        Me.LineSpeedLabel.Name = "LineSpeedLabel"
        Me.LineSpeedLabel.Size = New System.Drawing.Size(84, 17)
        Me.LineSpeedLabel.TabIndex = 2
        Me.LineSpeedLabel.Text = "Line Speed:"
        '
        'LugSlaveIdx
        '
        Me.LugSlaveIdx.AutoSize = True
        Me.LugSlaveIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LugSlaveIdx.Location = New System.Drawing.Point(28, 143)
        Me.LugSlaveIdx.Name = "LugSlaveIdx"
        Me.LugSlaveIdx.Size = New System.Drawing.Size(84, 17)
        Me.LugSlaveIdx.TabIndex = 1
        Me.LugSlaveIdx.Text = "LugSlaveIdx"
        '
        'LugMasterIdx
        '
        Me.LugMasterIdx.AutoSize = True
        Me.LugMasterIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LugMasterIdx.Location = New System.Drawing.Point(28, 85)
        Me.LugMasterIdx.Name = "LugMasterIdx"
        Me.LugMasterIdx.Size = New System.Drawing.Size(92, 17)
        Me.LugMasterIdx.TabIndex = 0
        Me.LugMasterIdx.Text = "LugMasterIdx"
        '
        'Timer1
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RemanCheckBox)
        Me.GroupBox2.Controls.Add(Me.SlashCheckBox)
        Me.GroupBox2.Controls.Add(Me.SpeciesInput)
        Me.GroupBox2.Controls.Add(Me.SpeciesLabel)
        Me.GroupBox2.Controls.Add(Me.FeDestInput)
        Me.GroupBox2.Controls.Add(Me.NeDestInput)
        Me.GroupBox2.Controls.Add(Me.NeGradeInput)
        Me.GroupBox2.Controls.Add(Me.FeGradeInout)
        Me.GroupBox2.Controls.Add(Me.FeDestLabel)
        Me.GroupBox2.Controls.Add(Me.NeDestLabel)
        Me.GroupBox2.Controls.Add(Me.FeGradeLabel)
        Me.GroupBox2.Controls.Add(Me.NeGradeLabel)
        Me.GroupBox2.Controls.Add(Me.FenceValInput)
        Me.GroupBox2.Controls.Add(Me.FenceValLabel)
        Me.GroupBox2.Controls.Add(Me.FeCitTrimInput)
        Me.GroupBox2.Controls.Add(Me.NeCitTrimInput)
        Me.GroupBox2.Controls.Add(Me.NeTrimInput)
        Me.GroupBox2.Controls.Add(Me.FeTrimInput)
        Me.GroupBox2.Controls.Add(Me.FeCitTrimLabel)
        Me.GroupBox2.Controls.Add(Me.NeCitTrimLabel)
        Me.GroupBox2.Controls.Add(Me.FeTrimLabel)
        Me.GroupBox2.Controls.Add(Me.NeTrimLabel)
        Me.GroupBox2.Controls.Add(Me.SimulCypress)
        Me.GroupBox2.Controls.Add(Me.CypressLugIdx)
        Me.GroupBox2.Location = New System.Drawing.Point(471, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 444)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'RemanCheckBox
        '
        Me.RemanCheckBox.AutoSize = True
        Me.RemanCheckBox.ComComponent = Me.EthernetIPforCLXCom1
        Me.RemanCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RemanCheckBox.Location = New System.Drawing.Point(168, 293)
        Me.RemanCheckBox.Name = "RemanCheckBox"
        Me.RemanCheckBox.PLCAddressCheckChanged = "Program:ACT_CYPRESS_ETHERNET.SimulGMR.bNeReman"
        Me.RemanCheckBox.PLCAddressChecked = "Program:ACT_CYPRESS_ETHERNET.SimulGMR.bNeReman"
        Me.RemanCheckBox.PLCAddressText = ""
        Me.RemanCheckBox.PLCAddressVisible = ""
        Me.RemanCheckBox.Size = New System.Drawing.Size(75, 21)
        Me.RemanCheckBox.TabIndex = 30
        Me.RemanCheckBox.Text = "Reman"
        Me.RemanCheckBox.UseVisualStyleBackColor = True
        '
        'SlashCheckBox
        '
        Me.SlashCheckBox.AutoSize = True
        Me.SlashCheckBox.ComComponent = Me.EthernetIPforCLXCom1
        Me.SlashCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SlashCheckBox.Location = New System.Drawing.Point(168, 266)
        Me.SlashCheckBox.Name = "SlashCheckBox"
        Me.SlashCheckBox.PLCAddressCheckChanged = "Program:ACT_CYPRESS_ETHERNET.SimulGMR.bSlash"
        Me.SlashCheckBox.PLCAddressChecked = "Program:ACT_CYPRESS_ETHERNET.SimulGMR.bSlash"
        Me.SlashCheckBox.PLCAddressText = ""
        Me.SlashCheckBox.PLCAddressVisible = ""
        Me.SlashCheckBox.Size = New System.Drawing.Size(65, 21)
        Me.SlashCheckBox.TabIndex = 29
        Me.SlashCheckBox.Text = "Slash"
        Me.SlashCheckBox.UseVisualStyleBackColor = True
        '
        'SpeciesInput
        '
        Me.SpeciesInput.ClearAfterEnterKey = False
        Me.SpeciesInput.ComComponent = Me.EthernetIPforCLXCom1
        Me.SpeciesInput.GetFocusMatchValue = 1
        Me.SpeciesInput.GetFocusValue = 0
        Me.SpeciesInput.Location = New System.Drawing.Point(315, 228)
        Me.SpeciesInput.Name = "SpeciesInput"
        Me.SpeciesInput.PLCAddressGetFocusValue = Nothing
        Me.SpeciesInput.PLCAddressWriteValue = New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_CYPRESS_ETHERNET.SimulGMR.dSpecie", 1)
        Me.SpeciesInput.Size = New System.Drawing.Size(59, 22)
        Me.SpeciesInput.TabIndex = 27
        Me.SpeciesInput.Text = "0"
        '
        'SpeciesLabel
        '
        Me.SpeciesLabel.AutoSize = True
        Me.SpeciesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SpeciesLabel.Location = New System.Drawing.Point(223, 231)
        Me.SpeciesLabel.Name = "SpeciesLabel"
        Me.SpeciesLabel.Size = New System.Drawing.Size(66, 17)
        Me.SpeciesLabel.TabIndex = 26
        Me.SpeciesLabel.Text = "Species: "
        '
        'FeDestInput
        '
        Me.FeDestInput.ClearAfterEnterKey = False
        Me.FeDestInput.ComComponent = Me.EthernetIPforCLXCom1
        Me.FeDestInput.GetFocusMatchValue = 1
        Me.FeDestInput.GetFocusValue = 0
        Me.FeDestInput.Location = New System.Drawing.Point(315, 203)
        Me.FeDestInput.Name = "FeDestInput"
        Me.FeDestInput.PLCAddressGetFocusValue = Nothing
        Me.FeDestInput.PLCAddressWriteValue = New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_CYPRESS_ETHERNET.SimulGMR.dDestination[1]", 1)
        Me.FeDestInput.Size = New System.Drawing.Size(59, 22)
        Me.FeDestInput.TabIndex = 25
        Me.FeDestInput.Text = "0"
        '
        'NeDestInput
        '
        Me.NeDestInput.ClearAfterEnterKey = False
        Me.NeDestInput.ComComponent = Me.EthernetIPforCLXCom1
        Me.NeDestInput.GetFocusMatchValue = 1
        Me.NeDestInput.GetFocusValue = 0
        Me.NeDestInput.Location = New System.Drawing.Point(315, 179)
        Me.NeDestInput.Name = "NeDestInput"
        Me.NeDestInput.PLCAddressGetFocusValue = Nothing
        Me.NeDestInput.PLCAddressWriteValue = New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_CYPRESS_ETHERNET.SimulGMR.dDestination[0]", 1)
        Me.NeDestInput.Size = New System.Drawing.Size(59, 22)
        Me.NeDestInput.TabIndex = 24
        Me.NeDestInput.Text = "0"
        '
        'NeGradeInput
        '
        Me.NeGradeInput.ClearAfterEnterKey = False
        Me.NeGradeInput.ComComponent = Me.EthernetIPforCLXCom1
        Me.NeGradeInput.GetFocusMatchValue = 1
        Me.NeGradeInput.GetFocusValue = 0
        Me.NeGradeInput.Location = New System.Drawing.Point(315, 131)
        Me.NeGradeInput.Name = "NeGradeInput"
        Me.NeGradeInput.PLCAddressGetFocusValue = Nothing
        Me.NeGradeInput.PLCAddressWriteValue = New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_CYPRESS_ETHERNET.SimulGMR.dGrade[0]", 1)
        Me.NeGradeInput.Size = New System.Drawing.Size(59, 22)
        Me.NeGradeInput.TabIndex = 23
        Me.NeGradeInput.Text = "1"
        '
        'FeGradeInout
        '
        Me.FeGradeInout.ClearAfterEnterKey = False
        Me.FeGradeInout.ComComponent = Me.EthernetIPforCLXCom1
        Me.FeGradeInout.GetFocusMatchValue = 1
        Me.FeGradeInout.GetFocusValue = 0
        Me.FeGradeInout.Location = New System.Drawing.Point(315, 155)
        Me.FeGradeInout.Name = "FeGradeInout"
        Me.FeGradeInout.PLCAddressGetFocusValue = Nothing
        Me.FeGradeInout.PLCAddressWriteValue = New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_CYPRESS_ETHERNET.SimulGMR.dGrade[1]", 1)
        Me.FeGradeInout.Size = New System.Drawing.Size(59, 22)
        Me.FeGradeInout.TabIndex = 22
        Me.FeGradeInout.Text = "0"
        '
        'FeDestLabel
        '
        Me.FeDestLabel.AutoSize = True
        Me.FeDestLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FeDestLabel.Location = New System.Drawing.Point(223, 206)
        Me.FeDestLabel.Name = "FeDestLabel"
        Me.FeDestLabel.Size = New System.Drawing.Size(65, 17)
        Me.FeDestLabel.TabIndex = 21
        Me.FeDestLabel.Text = "Fe Dest: "
        '
        'NeDestLabel
        '
        Me.NeDestLabel.AutoSize = True
        Me.NeDestLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.NeDestLabel.Location = New System.Drawing.Point(223, 182)
        Me.NeDestLabel.Name = "NeDestLabel"
        Me.NeDestLabel.Size = New System.Drawing.Size(67, 17)
        Me.NeDestLabel.TabIndex = 20
        Me.NeDestLabel.Text = "Ne Dest: "
        '
        'FeGradeLabel
        '
        Me.FeGradeLabel.AutoSize = True
        Me.FeGradeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FeGradeLabel.Location = New System.Drawing.Point(223, 158)
        Me.FeGradeLabel.Name = "FeGradeLabel"
        Me.FeGradeLabel.Size = New System.Drawing.Size(76, 17)
        Me.FeGradeLabel.TabIndex = 19
        Me.FeGradeLabel.Text = "Fe Grade: "
        '
        'NeGradeLabel
        '
        Me.NeGradeLabel.AutoSize = True
        Me.NeGradeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.NeGradeLabel.Location = New System.Drawing.Point(223, 134)
        Me.NeGradeLabel.Name = "NeGradeLabel"
        Me.NeGradeLabel.Size = New System.Drawing.Size(78, 17)
        Me.NeGradeLabel.TabIndex = 18
        Me.NeGradeLabel.Text = "Ne Grade: "
        '
        'FenceValInput
        '
        Me.FenceValInput.ClearAfterEnterKey = False
        Me.FenceValInput.ComComponent = Me.EthernetIPforCLXCom1
        Me.FenceValInput.GetFocusMatchValue = 1
        Me.FenceValInput.GetFocusValue = 0
        Me.FenceValInput.Location = New System.Drawing.Point(120, 228)
        Me.FenceValInput.Name = "FenceValInput"
        Me.FenceValInput.PLCAddressGetFocusValue = Nothing
        Me.FenceValInput.PLCAddressWriteValue = New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_CYPRESS_ETHERNET.SimulGMR.dFenceVal", 1)
        Me.FenceValInput.Size = New System.Drawing.Size(59, 22)
        Me.FenceValInput.TabIndex = 17
        Me.FenceValInput.Text = "0"
        '
        'FenceValLabel
        '
        Me.FenceValLabel.AutoSize = True
        Me.FenceValLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FenceValLabel.Location = New System.Drawing.Point(28, 231)
        Me.FenceValLabel.Name = "FenceValLabel"
        Me.FenceValLabel.Size = New System.Drawing.Size(95, 17)
        Me.FenceValLabel.TabIndex = 16
        Me.FenceValLabel.Text = "Fence Value: "
        '
        'FeCitTrimInput
        '
        Me.FeCitTrimInput.ClearAfterEnterKey = False
        Me.FeCitTrimInput.ComComponent = Me.EthernetIPforCLXCom1
        Me.FeCitTrimInput.GetFocusMatchValue = 1
        Me.FeCitTrimInput.GetFocusValue = 0
        Me.FeCitTrimInput.Location = New System.Drawing.Point(120, 203)
        Me.FeCitTrimInput.Name = "FeCitTrimInput"
        Me.FeCitTrimInput.PLCAddressGetFocusValue = Nothing
        Me.FeCitTrimInput.PLCAddressWriteValue = New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_CYPRESS_ETHERNET.SimulGMR.dFeCITVal", 1)
        Me.FeCitTrimInput.Size = New System.Drawing.Size(59, 22)
        Me.FeCitTrimInput.TabIndex = 15
        Me.FeCitTrimInput.Text = "0"
        '
        'NeCitTrimInput
        '
        Me.NeCitTrimInput.ClearAfterEnterKey = False
        Me.NeCitTrimInput.ComComponent = Me.EthernetIPforCLXCom1
        Me.NeCitTrimInput.GetFocusMatchValue = 1
        Me.NeCitTrimInput.GetFocusValue = 0
        Me.NeCitTrimInput.Location = New System.Drawing.Point(120, 179)
        Me.NeCitTrimInput.Name = "NeCitTrimInput"
        Me.NeCitTrimInput.PLCAddressGetFocusValue = Nothing
        Me.NeCitTrimInput.PLCAddressWriteValue = New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_CYPRESS_ETHERNET.SimulGMR.dNeCITVal", 1)
        Me.NeCitTrimInput.Size = New System.Drawing.Size(59, 22)
        Me.NeCitTrimInput.TabIndex = 14
        Me.NeCitTrimInput.Text = "0"
        '
        'NeTrimInput
        '
        Me.NeTrimInput.ClearAfterEnterKey = False
        Me.NeTrimInput.ComComponent = Me.EthernetIPforCLXCom1
        Me.NeTrimInput.GetFocusMatchValue = 1
        Me.NeTrimInput.GetFocusValue = 0
        Me.NeTrimInput.Location = New System.Drawing.Point(120, 131)
        Me.NeTrimInput.Name = "NeTrimInput"
        Me.NeTrimInput.PLCAddressGetFocusValue = Nothing
        Me.NeTrimInput.PLCAddressWriteValue = New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_CYPRESS_ETHERNET.SimulGMR.dNETrimVal", 1)
        Me.NeTrimInput.Size = New System.Drawing.Size(59, 22)
        Me.NeTrimInput.TabIndex = 13
        Me.NeTrimInput.Text = "0"
        '
        'FeTrimInput
        '
        Me.FeTrimInput.ClearAfterEnterKey = False
        Me.FeTrimInput.ComComponent = Me.EthernetIPforCLXCom1
        Me.FeTrimInput.GetFocusMatchValue = 1
        Me.FeTrimInput.GetFocusValue = 0
        Me.FeTrimInput.Location = New System.Drawing.Point(120, 155)
        Me.FeTrimInput.Name = "FeTrimInput"
        Me.FeTrimInput.PLCAddressGetFocusValue = Nothing
        Me.FeTrimInput.PLCAddressWriteValue = New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_CYPRESS_ETHERNET.SimulGMR.dFeTrimVal", 1)
        Me.FeTrimInput.Size = New System.Drawing.Size(59, 22)
        Me.FeTrimInput.TabIndex = 12
        Me.FeTrimInput.Text = "0"
        '
        'FeCitTrimLabel
        '
        Me.FeCitTrimLabel.AutoSize = True
        Me.FeCitTrimLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FeCitTrimLabel.Location = New System.Drawing.Point(28, 206)
        Me.FeCitTrimLabel.Name = "FeCitTrimLabel"
        Me.FeCitTrimLabel.Size = New System.Drawing.Size(89, 17)
        Me.FeCitTrimLabel.TabIndex = 11
        Me.FeCitTrimLabel.Text = "Fe CIT Trim: "
        '
        'NeCitTrimLabel
        '
        Me.NeCitTrimLabel.AutoSize = True
        Me.NeCitTrimLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.NeCitTrimLabel.Location = New System.Drawing.Point(28, 182)
        Me.NeCitTrimLabel.Name = "NeCitTrimLabel"
        Me.NeCitTrimLabel.Size = New System.Drawing.Size(91, 17)
        Me.NeCitTrimLabel.TabIndex = 10
        Me.NeCitTrimLabel.Text = "Ne CIT Trim: "
        '
        'FeTrimLabel
        '
        Me.FeTrimLabel.AutoSize = True
        Me.FeTrimLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FeTrimLabel.Location = New System.Drawing.Point(28, 158)
        Me.FeTrimLabel.Name = "FeTrimLabel"
        Me.FeTrimLabel.Size = New System.Drawing.Size(64, 17)
        Me.FeTrimLabel.TabIndex = 9
        Me.FeTrimLabel.Text = "Fe Trim: "
        '
        'NeTrimLabel
        '
        Me.NeTrimLabel.AutoSize = True
        Me.NeTrimLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.NeTrimLabel.Location = New System.Drawing.Point(28, 134)
        Me.NeTrimLabel.Name = "NeTrimLabel"
        Me.NeTrimLabel.Size = New System.Drawing.Size(66, 17)
        Me.NeTrimLabel.TabIndex = 8
        Me.NeTrimLabel.Text = "Ne Trim: "
        '
        'SimulCypress
        '
        Me.SimulCypress.BackColor = System.Drawing.Color.LightGray
        Me.SimulCypress.ComComponent = Me.EthernetIPforCLXCom1
        Me.SimulCypress.ForeColor = System.Drawing.Color.Black
        Me.SimulCypress.ForeColorAlternate = System.Drawing.Color.Black
        Me.SimulCypress.Highlight = False
        Me.SimulCypress.HighlightColor = System.Drawing.Color.Green
        Me.SimulCypress.Location = New System.Drawing.Point(30, 15)
        Me.SimulCypress.MaximumHoldTime = 3000
        Me.SimulCypress.MinimumHoldTime = 500
        Me.SimulCypress.Name = "SimulCypress"
        Me.SimulCypress.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.SimulCypress.PLCAddressClick = "Program:ACT_CYPRESS_ETHERNET.bSimul"
        Me.SimulCypress.PLCAddressHighlightX = "Program:ACT_CYPRESS_ETHERNET.bSimul"
        Me.SimulCypress.SelectTextAlternate = False
        Me.SimulCypress.Size = New System.Drawing.Size(167, 60)
        Me.SimulCypress.TabIndex = 4
        Me.SimulCypress.Text = "Simul Cypress"
        Me.SimulCypress.TextAlternate = Nothing
        Me.SimulCypress.UseVisualStyleBackColor = True
        Me.SimulCypress.ValueToWrite = 0
        '
        'CypressLugIdx
        '
        Me.CypressLugIdx.AutoSize = True
        Me.CypressLugIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CypressLugIdx.Location = New System.Drawing.Point(28, 85)
        Me.CypressLugIdx.Name = "CypressLugIdx"
        Me.CypressLugIdx.Size = New System.Drawing.Size(100, 17)
        Me.CypressLugIdx.TabIndex = 0
        Me.CypressLugIdx.Text = "CypressLugIdx"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BasicLabel1)
        Me.GroupBox3.Controls.Add(Me.LS16fbk)
        Me.GroupBox3.Controls.Add(Me.LS15fbk)
        Me.GroupBox3.Controls.Add(Me.LS14fbk)
        Me.GroupBox3.Controls.Add(Me.LS13fbk)
        Me.GroupBox3.Controls.Add(Me.LS12fbk)
        Me.GroupBox3.Controls.Add(Me.LS11fbk)
        Me.GroupBox3.Controls.Add(Me.LS10fbk)
        Me.GroupBox3.Controls.Add(Me.LS9fbk)
        Me.GroupBox3.Controls.Add(Me.LS8fbk)
        Me.GroupBox3.Controls.Add(Me.LS7fbk)
        Me.GroupBox3.Controls.Add(Me.LS6fbk)
        Me.GroupBox3.Controls.Add(Me.LS3fbk)
        Me.GroupBox3.Controls.Add(Me.LS0fbk)
        Me.GroupBox3.Controls.Add(Me.CheckBox12)
        Me.GroupBox3.Controls.Add(Me.CheckBox11)
        Me.GroupBox3.Controls.Add(Me.CheckBox10)
        Me.GroupBox3.Controls.Add(Me.CheckBox9)
        Me.GroupBox3.Controls.Add(Me.CheckBox8)
        Me.GroupBox3.Controls.Add(Me.CheckBox7)
        Me.GroupBox3.Controls.Add(Me.CheckBox6)
        Me.GroupBox3.Controls.Add(Me.CheckBox5)
        Me.GroupBox3.Controls.Add(Me.CheckBox4)
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.ReadWidthIdx)
        Me.GroupBox3.Controls.Add(Me.SimulReadWidth)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.Ls0Check)
        Me.GroupBox3.Controls.Add(Me.ReadWidthInput)
        Me.GroupBox3.Controls.Add(Me.ReadWidthLabel)
        Me.GroupBox3.Controls.Add(Me.SimulReadLen1)
        Me.GroupBox3.Controls.Add(Me.ReadLen1Idx)
        Me.GroupBox3.Location = New System.Drawing.Point(910, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(424, 444)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
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
        Me.BasicLabel1.Location = New System.Drawing.Point(315, 158)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = Nothing
        Me.BasicLabel1.PLCAddressKeypad = ""
        Me.BasicLabel1.PLCAddressValue = "Program:ACT_READ_WIDTH.dFinalValue"
        Me.BasicLabel1.Size = New System.Drawing.Size(74, 17)
        Me.BasicLabel1.TabIndex = 103
        Me.BasicLabel1.Text = "FinalValue"
        Me.BasicLabel1.Value = "FinalValue"
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel1.ValueLeftPadLength = 0
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 0.001R
        Me.BasicLabel1.ValueSuffix = Nothing
        Me.BasicLabel1.ValueToSubtractFrom = 0!
        '
        'LS16fbk
        '
        Me.LS16fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS16fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS16fbk.Location = New System.Drawing.Point(124, 417)
        Me.LS16fbk.Name = "LS16fbk"
        Me.LS16fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS16fbk.PLCAddressClick = ""
        Me.LS16fbk.PLCAddressText = ""
        Me.LS16fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_1.dLengthLS.12"
        Me.LS16fbk.PLCAddressVisible = ""
        Me.LS16fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS16fbk.TabIndex = 102
        Me.LS16fbk.Value = False
        '
        'LS15fbk
        '
        Me.LS15fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS15fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS15fbk.Location = New System.Drawing.Point(124, 392)
        Me.LS15fbk.Name = "LS15fbk"
        Me.LS15fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS15fbk.PLCAddressClick = ""
        Me.LS15fbk.PLCAddressText = ""
        Me.LS15fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_1.dLengthLS.11"
        Me.LS15fbk.PLCAddressVisible = ""
        Me.LS15fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS15fbk.TabIndex = 101
        Me.LS15fbk.Value = False
        '
        'LS14fbk
        '
        Me.LS14fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS14fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS14fbk.Location = New System.Drawing.Point(124, 367)
        Me.LS14fbk.Name = "LS14fbk"
        Me.LS14fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS14fbk.PLCAddressClick = ""
        Me.LS14fbk.PLCAddressText = ""
        Me.LS14fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_1.dLengthLS.10"
        Me.LS14fbk.PLCAddressVisible = ""
        Me.LS14fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS14fbk.TabIndex = 100
        Me.LS14fbk.Value = False
        '
        'LS13fbk
        '
        Me.LS13fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS13fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS13fbk.Location = New System.Drawing.Point(124, 343)
        Me.LS13fbk.Name = "LS13fbk"
        Me.LS13fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS13fbk.PLCAddressClick = ""
        Me.LS13fbk.PLCAddressText = ""
        Me.LS13fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_1.dLengthLS.9"
        Me.LS13fbk.PLCAddressVisible = ""
        Me.LS13fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS13fbk.TabIndex = 99
        Me.LS13fbk.Value = False
        '
        'LS12fbk
        '
        Me.LS12fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS12fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS12fbk.Location = New System.Drawing.Point(124, 319)
        Me.LS12fbk.Name = "LS12fbk"
        Me.LS12fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS12fbk.PLCAddressClick = ""
        Me.LS12fbk.PLCAddressText = ""
        Me.LS12fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_1.dLengthLS.8"
        Me.LS12fbk.PLCAddressVisible = ""
        Me.LS12fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS12fbk.TabIndex = 98
        Me.LS12fbk.Value = False
        '
        'LS11fbk
        '
        Me.LS11fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS11fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS11fbk.Location = New System.Drawing.Point(124, 293)
        Me.LS11fbk.Name = "LS11fbk"
        Me.LS11fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS11fbk.PLCAddressClick = ""
        Me.LS11fbk.PLCAddressText = ""
        Me.LS11fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_1.dLengthLS.7"
        Me.LS11fbk.PLCAddressVisible = ""
        Me.LS11fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS11fbk.TabIndex = 97
        Me.LS11fbk.Value = False
        '
        'LS10fbk
        '
        Me.LS10fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS10fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS10fbk.Location = New System.Drawing.Point(124, 269)
        Me.LS10fbk.Name = "LS10fbk"
        Me.LS10fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS10fbk.PLCAddressClick = ""
        Me.LS10fbk.PLCAddressText = ""
        Me.LS10fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_1.dLengthLS.6"
        Me.LS10fbk.PLCAddressVisible = ""
        Me.LS10fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS10fbk.TabIndex = 96
        Me.LS10fbk.Value = False
        '
        'LS9fbk
        '
        Me.LS9fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS9fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS9fbk.Location = New System.Drawing.Point(124, 244)
        Me.LS9fbk.Name = "LS9fbk"
        Me.LS9fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS9fbk.PLCAddressClick = ""
        Me.LS9fbk.PLCAddressText = ""
        Me.LS9fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_1.dLengthLS.5"
        Me.LS9fbk.PLCAddressVisible = ""
        Me.LS9fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS9fbk.TabIndex = 95
        Me.LS9fbk.Value = False
        '
        'LS8fbk
        '
        Me.LS8fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS8fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS8fbk.Location = New System.Drawing.Point(124, 219)
        Me.LS8fbk.Name = "LS8fbk"
        Me.LS8fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS8fbk.PLCAddressClick = ""
        Me.LS8fbk.PLCAddressText = ""
        Me.LS8fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_1.dLengthLS.4"
        Me.LS8fbk.PLCAddressVisible = ""
        Me.LS8fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS8fbk.TabIndex = 94
        Me.LS8fbk.Value = False
        '
        'LS7fbk
        '
        Me.LS7fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS7fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS7fbk.Location = New System.Drawing.Point(124, 194)
        Me.LS7fbk.Name = "LS7fbk"
        Me.LS7fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS7fbk.PLCAddressClick = ""
        Me.LS7fbk.PLCAddressText = ""
        Me.LS7fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_1.dLengthLS.3"
        Me.LS7fbk.PLCAddressVisible = ""
        Me.LS7fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS7fbk.TabIndex = 93
        Me.LS7fbk.Value = False
        '
        'LS6fbk
        '
        Me.LS6fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS6fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS6fbk.Location = New System.Drawing.Point(124, 170)
        Me.LS6fbk.Name = "LS6fbk"
        Me.LS6fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS6fbk.PLCAddressClick = ""
        Me.LS6fbk.PLCAddressText = ""
        Me.LS6fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_1.dLengthLS.2"
        Me.LS6fbk.PLCAddressVisible = ""
        Me.LS6fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS6fbk.TabIndex = 92
        Me.LS6fbk.Value = False
        '
        'LS3fbk
        '
        Me.LS3fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS3fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS3fbk.Location = New System.Drawing.Point(124, 146)
        Me.LS3fbk.Name = "LS3fbk"
        Me.LS3fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS3fbk.PLCAddressClick = ""
        Me.LS3fbk.PLCAddressText = ""
        Me.LS3fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_1.dLengthLS.1"
        Me.LS3fbk.PLCAddressVisible = ""
        Me.LS3fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS3fbk.TabIndex = 91
        Me.LS3fbk.Value = False
        '
        'LS0fbk
        '
        Me.LS0fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS0fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS0fbk.Location = New System.Drawing.Point(124, 122)
        Me.LS0fbk.Name = "LS0fbk"
        Me.LS0fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS0fbk.PLCAddressClick = ""
        Me.LS0fbk.PLCAddressText = ""
        Me.LS0fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_1.dLengthLS.0"
        Me.LS0fbk.PLCAddressVisible = ""
        Me.LS0fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS0fbk.TabIndex = 90
        Me.LS0fbk.Value = False
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox12.Location = New System.Drawing.Point(31, 417)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_1.dSimulLS.12"
        Me.CheckBox12.PLCAddressChecked = "Program:ACT_READ_LENGTH_1.dSimulLS.12"
        Me.CheckBox12.PLCAddressText = ""
        Me.CheckBox12.PLCAddressVisible = ""
        Me.CheckBox12.Size = New System.Drawing.Size(70, 21)
        Me.CheckBox12.TabIndex = 43
        Me.CheckBox12.Text = "LS 16'"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox11.Location = New System.Drawing.Point(31, 392)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_1.dSimulLS.11"
        Me.CheckBox11.PLCAddressChecked = "Program:ACT_READ_LENGTH_1.dSimulLS.11"
        Me.CheckBox11.PLCAddressText = ""
        Me.CheckBox11.PLCAddressVisible = ""
        Me.CheckBox11.Size = New System.Drawing.Size(70, 21)
        Me.CheckBox11.TabIndex = 42
        Me.CheckBox11.Text = "LS 15'"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox10.Location = New System.Drawing.Point(31, 367)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_1.dSimulLS.10"
        Me.CheckBox10.PLCAddressChecked = "Program:ACT_READ_LENGTH_1.dSimulLS.10"
        Me.CheckBox10.PLCAddressText = ""
        Me.CheckBox10.PLCAddressVisible = ""
        Me.CheckBox10.Size = New System.Drawing.Size(70, 21)
        Me.CheckBox10.TabIndex = 41
        Me.CheckBox10.Text = "LS 14'"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox9.Location = New System.Drawing.Point(31, 343)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_1.dSimulLS.9"
        Me.CheckBox9.PLCAddressChecked = "Program:ACT_READ_LENGTH_1.dSimulLS.9"
        Me.CheckBox9.PLCAddressText = ""
        Me.CheckBox9.PLCAddressVisible = ""
        Me.CheckBox9.Size = New System.Drawing.Size(70, 21)
        Me.CheckBox9.TabIndex = 40
        Me.CheckBox9.Text = "LS 13'"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox8.Location = New System.Drawing.Point(31, 319)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_1.dSimulLS.8"
        Me.CheckBox8.PLCAddressChecked = "Program:ACT_READ_LENGTH_1.dSimulLS.8"
        Me.CheckBox8.PLCAddressText = ""
        Me.CheckBox8.PLCAddressVisible = ""
        Me.CheckBox8.Size = New System.Drawing.Size(70, 21)
        Me.CheckBox8.TabIndex = 39
        Me.CheckBox8.Text = "LS 12'"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox7.Location = New System.Drawing.Point(31, 295)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_1.dSimulLS.7"
        Me.CheckBox7.PLCAddressChecked = "Program:ACT_READ_LENGTH_1.dSimulLS.7"
        Me.CheckBox7.PLCAddressText = ""
        Me.CheckBox7.PLCAddressVisible = ""
        Me.CheckBox7.Size = New System.Drawing.Size(70, 21)
        Me.CheckBox7.TabIndex = 38
        Me.CheckBox7.Text = "LS 11'"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox6.Location = New System.Drawing.Point(31, 269)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_1.dSimulLS.6"
        Me.CheckBox6.PLCAddressChecked = "Program:ACT_READ_LENGTH_1.dSimulLS.6"
        Me.CheckBox6.PLCAddressText = ""
        Me.CheckBox6.PLCAddressVisible = ""
        Me.CheckBox6.Size = New System.Drawing.Size(70, 21)
        Me.CheckBox6.TabIndex = 37
        Me.CheckBox6.Text = "LS 10'"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox5.Location = New System.Drawing.Point(31, 244)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_1.dSimulLS.5"
        Me.CheckBox5.PLCAddressChecked = "Program:ACT_READ_LENGTH_1.dSimulLS.5"
        Me.CheckBox5.PLCAddressText = ""
        Me.CheckBox5.PLCAddressVisible = ""
        Me.CheckBox5.Size = New System.Drawing.Size(62, 21)
        Me.CheckBox5.TabIndex = 36
        Me.CheckBox5.Text = "LS 9'"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox4.Location = New System.Drawing.Point(31, 219)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_1.dSimulLS.4"
        Me.CheckBox4.PLCAddressChecked = "Program:ACT_READ_LENGTH_1.dSimulLS.4"
        Me.CheckBox4.PLCAddressText = ""
        Me.CheckBox4.PLCAddressVisible = ""
        Me.CheckBox4.Size = New System.Drawing.Size(62, 21)
        Me.CheckBox4.TabIndex = 35
        Me.CheckBox4.Text = "LS 8'"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox3.Location = New System.Drawing.Point(31, 194)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_1.dSimulLS.3"
        Me.CheckBox3.PLCAddressChecked = "Program:ACT_READ_LENGTH_1.dSimulLS.3"
        Me.CheckBox3.PLCAddressText = ""
        Me.CheckBox3.PLCAddressVisible = ""
        Me.CheckBox3.Size = New System.Drawing.Size(62, 21)
        Me.CheckBox3.TabIndex = 34
        Me.CheckBox3.Text = "LS 7'"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox2.Location = New System.Drawing.Point(31, 170)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_1.dSimulLS.2"
        Me.CheckBox2.PLCAddressChecked = "Program:ACT_READ_LENGTH_1.dSimulLS.2"
        Me.CheckBox2.PLCAddressText = ""
        Me.CheckBox2.PLCAddressVisible = ""
        Me.CheckBox2.Size = New System.Drawing.Size(62, 21)
        Me.CheckBox2.TabIndex = 33
        Me.CheckBox2.Text = "LS 6'"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'ReadWidthIdx
        '
        Me.ReadWidthIdx.AutoSize = True
        Me.ReadWidthIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReadWidthIdx.Location = New System.Drawing.Point(230, 85)
        Me.ReadWidthIdx.Name = "ReadWidthIdx"
        Me.ReadWidthIdx.Size = New System.Drawing.Size(95, 17)
        Me.ReadWidthIdx.TabIndex = 32
        Me.ReadWidthIdx.Text = "ReadWidthIdx"
        '
        'SimulReadWidth
        '
        Me.SimulReadWidth.BackColor = System.Drawing.Color.LightGray
        Me.SimulReadWidth.ComComponent = Me.EthernetIPforCLXCom1
        Me.SimulReadWidth.ForeColor = System.Drawing.Color.Black
        Me.SimulReadWidth.ForeColorAlternate = System.Drawing.Color.Black
        Me.SimulReadWidth.Highlight = False
        Me.SimulReadWidth.HighlightColor = System.Drawing.Color.Green
        Me.SimulReadWidth.Location = New System.Drawing.Point(230, 15)
        Me.SimulReadWidth.MaximumHoldTime = 3000
        Me.SimulReadWidth.MinimumHoldTime = 500
        Me.SimulReadWidth.Name = "SimulReadWidth"
        Me.SimulReadWidth.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.SimulReadWidth.PLCAddressClick = "Program:ACT_READ_WIDTH.bSimul"
        Me.SimulReadWidth.PLCAddressHighlightX = "Program:ACT_READ_WIDTH.bSimul"
        Me.SimulReadWidth.SelectTextAlternate = False
        Me.SimulReadWidth.Size = New System.Drawing.Size(167, 60)
        Me.SimulReadWidth.TabIndex = 31
        Me.SimulReadWidth.Text = "Simul Read Width"
        Me.SimulReadWidth.TextAlternate = Nothing
        Me.SimulReadWidth.UseVisualStyleBackColor = True
        Me.SimulReadWidth.ValueToWrite = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox1.Location = New System.Drawing.Point(31, 146)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_1.dSimulLS.1"
        Me.CheckBox1.PLCAddressChecked = "Program:ACT_READ_LENGTH_1.dSimulLS.1"
        Me.CheckBox1.PLCAddressText = ""
        Me.CheckBox1.PLCAddressVisible = ""
        Me.CheckBox1.Size = New System.Drawing.Size(62, 21)
        Me.CheckBox1.TabIndex = 30
        Me.CheckBox1.Text = "LS 3'"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Ls0Check
        '
        Me.Ls0Check.AutoSize = True
        Me.Ls0Check.ComComponent = Me.EthernetIPforCLXCom1
        Me.Ls0Check.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Ls0Check.Location = New System.Drawing.Point(31, 122)
        Me.Ls0Check.Name = "Ls0Check"
        Me.Ls0Check.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_1.dSimulLS.0"
        Me.Ls0Check.PLCAddressChecked = "Program:ACT_READ_LENGTH_1.dSimulLS.0"
        Me.Ls0Check.PLCAddressText = ""
        Me.Ls0Check.PLCAddressVisible = ""
        Me.Ls0Check.Size = New System.Drawing.Size(62, 21)
        Me.Ls0Check.TabIndex = 29
        Me.Ls0Check.Text = "LS 0'"
        Me.Ls0Check.UseVisualStyleBackColor = True
        '
        'ReadWidthInput
        '
        Me.ReadWidthInput.ClearAfterEnterKey = False
        Me.ReadWidthInput.ComComponent = Me.EthernetIPforCLXCom1
        Me.ReadWidthInput.GetFocusMatchValue = 1
        Me.ReadWidthInput.GetFocusValue = 0
        Me.ReadWidthInput.Location = New System.Drawing.Point(315, 129)
        Me.ReadWidthInput.Name = "ReadWidthInput"
        Me.ReadWidthInput.PLCAddressGetFocusValue = Nothing
        Me.ReadWidthInput.PLCAddressWriteValue = New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_READ_Width.dSimulValue", 1)
        Me.ReadWidthInput.Size = New System.Drawing.Size(59, 22)
        Me.ReadWidthInput.TabIndex = 23
        Me.ReadWidthInput.Text = "40000"
        '
        'ReadWidthLabel
        '
        Me.ReadWidthLabel.AutoSize = True
        Me.ReadWidthLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReadWidthLabel.Location = New System.Drawing.Point(223, 132)
        Me.ReadWidthLabel.Name = "ReadWidthLabel"
        Me.ReadWidthLabel.Size = New System.Drawing.Size(52, 17)
        Me.ReadWidthLabel.TabIndex = 18
        Me.ReadWidthLabel.Text = "Width: "
        '
        'SimulReadLen1
        '
        Me.SimulReadLen1.BackColor = System.Drawing.Color.LightGray
        Me.SimulReadLen1.ComComponent = Me.EthernetIPforCLXCom1
        Me.SimulReadLen1.ForeColor = System.Drawing.Color.Black
        Me.SimulReadLen1.ForeColorAlternate = System.Drawing.Color.Black
        Me.SimulReadLen1.Highlight = False
        Me.SimulReadLen1.HighlightColor = System.Drawing.Color.Green
        Me.SimulReadLen1.Location = New System.Drawing.Point(30, 15)
        Me.SimulReadLen1.MaximumHoldTime = 3000
        Me.SimulReadLen1.MinimumHoldTime = 500
        Me.SimulReadLen1.Name = "SimulReadLen1"
        Me.SimulReadLen1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.SimulReadLen1.PLCAddressClick = "Program:ACT_READ_LENGTH_1.bSimul"
        Me.SimulReadLen1.PLCAddressHighlightX = "Program:ACT_READ_LENGTH_1.bSimul"
        Me.SimulReadLen1.SelectTextAlternate = False
        Me.SimulReadLen1.Size = New System.Drawing.Size(167, 60)
        Me.SimulReadLen1.TabIndex = 4
        Me.SimulReadLen1.Text = "Simul Read Length 1"
        Me.SimulReadLen1.TextAlternate = Nothing
        Me.SimulReadLen1.UseVisualStyleBackColor = True
        Me.SimulReadLen1.ValueToWrite = 0
        '
        'ReadLen1Idx
        '
        Me.ReadLen1Idx.AutoSize = True
        Me.ReadLen1Idx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReadLen1Idx.Location = New System.Drawing.Point(28, 85)
        Me.ReadLen1Idx.Name = "ReadLen1Idx"
        Me.ReadLen1Idx.Size = New System.Drawing.Size(91, 17)
        Me.ReadLen1Idx.TabIndex = 0
        Me.ReadLen1Idx.Text = "ReadLen1Idx"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.AnalogValueDisplay1)
        Me.GroupBox4.Controls.Add(Me.FenceCheckLugIdx)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton61)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton62)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton60)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton59)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton56)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton57)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton58)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton53)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton54)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton55)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton50)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton51)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton52)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton49)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton48)
        Me.GroupBox4.Controls.Add(Me.SquareIlluminatedButton47)
        Me.GroupBox4.Controls.Add(Me.FenceSkidLugIdx)
        Me.GroupBox4.Controls.Add(Me.FenceLugIdx)
        Me.GroupBox4.Location = New System.Drawing.Point(1368, 78)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(424, 444)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'AnalogValueDisplay1
        '
        Me.AnalogValueDisplay1.AutoSize = True
        Me.AnalogValueDisplay1.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay1.ForeColor = System.Drawing.Color.White
        Me.AnalogValueDisplay1.ForeColorInLimits = System.Drawing.Color.White
        Me.AnalogValueDisplay1.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay1.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay1.KeypadMaxValue = 0R
        Me.AnalogValueDisplay1.KeypadMinValue = 0R
        Me.AnalogValueDisplay1.KeypadPasscode = Nothing
        Me.AnalogValueDisplay1.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay1.KeypadText = Nothing
        Me.AnalogValueDisplay1.KeypadWidth = 300
        Me.AnalogValueDisplay1.Location = New System.Drawing.Point(25, 278)
        Me.AnalogValueDisplay1.Name = "AnalogValueDisplay1"
        Me.AnalogValueDisplay1.NumericFormat = Nothing
        Me.AnalogValueDisplay1.PLCAddressKeypad = ""
        Me.AnalogValueDisplay1.PLCAddressValue = New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("PROGRAM:ACT_FENCE_CHECKER.rFenceValid", 1)
        Me.AnalogValueDisplay1.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay1.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay1.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay1.ShowValue = True
        Me.AnalogValueDisplay1.Size = New System.Drawing.Size(40, 17)
        Me.AnalogValueDisplay1.TabIndex = 89
        Me.AnalogValueDisplay1.Text = "0000"
        Me.AnalogValueDisplay1.Value = "0000"
        Me.AnalogValueDisplay1.ValueLimitLower = -999999.0R
        Me.AnalogValueDisplay1.ValueLimitUpper = 999999.0R
        Me.AnalogValueDisplay1.ValuePrefix = Nothing
        Me.AnalogValueDisplay1.ValueSuffix = Nothing
        Me.AnalogValueDisplay1.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlOptions.Always
        '
        'FenceCheckLugIdx
        '
        Me.FenceCheckLugIdx.AutoSize = True
        Me.FenceCheckLugIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FenceCheckLugIdx.Location = New System.Drawing.Point(25, 253)
        Me.FenceCheckLugIdx.Name = "FenceCheckLugIdx"
        Me.FenceCheckLugIdx.Size = New System.Drawing.Size(127, 17)
        Me.FenceCheckLugIdx.TabIndex = 88
        Me.FenceCheckLugIdx.Text = "FenceCheckLugIdx"
        '
        'SquareIlluminatedButton61
        '
        Me.SquareIlluminatedButton61.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton61.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton61.Location = New System.Drawing.Point(272, 153)
        Me.SquareIlluminatedButton61.Name = "SquareIlluminatedButton61"
        Me.SquareIlluminatedButton61.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton61.PLCAddressClick = ""
        Me.SquareIlluminatedButton61.PLCAddressText = ""
        Me.SquareIlluminatedButton61.PLCAddressValue = "Program:ACT_SKIDS._OUT_Skid04"
        Me.SquareIlluminatedButton61.PLCAddressVisible = ""
        Me.SquareIlluminatedButton61.Size = New System.Drawing.Size(43, 23)
        Me.SquareIlluminatedButton61.TabIndex = 87
        Me.SquareIlluminatedButton61.Text = "Skid 4"
        Me.SquareIlluminatedButton61.Value = False
        '
        'SquareIlluminatedButton62
        '
        Me.SquareIlluminatedButton62.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton62.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton62.Location = New System.Drawing.Point(272, 129)
        Me.SquareIlluminatedButton62.Name = "SquareIlluminatedButton62"
        Me.SquareIlluminatedButton62.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton62.PLCAddressClick = ""
        Me.SquareIlluminatedButton62.PLCAddressText = ""
        Me.SquareIlluminatedButton62.PLCAddressValue = "Program:ACT_SKIDS._OUT_Skid03"
        Me.SquareIlluminatedButton62.PLCAddressVisible = ""
        Me.SquareIlluminatedButton62.Size = New System.Drawing.Size(43, 23)
        Me.SquareIlluminatedButton62.TabIndex = 86
        Me.SquareIlluminatedButton62.Text = "Skid 3"
        Me.SquareIlluminatedButton62.Value = False
        '
        'SquareIlluminatedButton60
        '
        Me.SquareIlluminatedButton60.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton60.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton60.Location = New System.Drawing.Point(223, 153)
        Me.SquareIlluminatedButton60.Name = "SquareIlluminatedButton60"
        Me.SquareIlluminatedButton60.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton60.PLCAddressClick = ""
        Me.SquareIlluminatedButton60.PLCAddressText = ""
        Me.SquareIlluminatedButton60.PLCAddressValue = "Program:ACT_SKIDS._OUT_Skid02"
        Me.SquareIlluminatedButton60.PLCAddressVisible = ""
        Me.SquareIlluminatedButton60.Size = New System.Drawing.Size(43, 23)
        Me.SquareIlluminatedButton60.TabIndex = 85
        Me.SquareIlluminatedButton60.Text = "Skid 2"
        Me.SquareIlluminatedButton60.Value = False
        '
        'SquareIlluminatedButton59
        '
        Me.SquareIlluminatedButton59.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton59.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton59.Location = New System.Drawing.Point(223, 129)
        Me.SquareIlluminatedButton59.Name = "SquareIlluminatedButton59"
        Me.SquareIlluminatedButton59.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton59.PLCAddressClick = ""
        Me.SquareIlluminatedButton59.PLCAddressText = ""
        Me.SquareIlluminatedButton59.PLCAddressValue = "Program:ACT_SKIDS._OUT_Skid01"
        Me.SquareIlluminatedButton59.PLCAddressVisible = ""
        Me.SquareIlluminatedButton59.Size = New System.Drawing.Size(43, 23)
        Me.SquareIlluminatedButton59.TabIndex = 84
        Me.SquareIlluminatedButton59.Text = "Skid 1"
        Me.SquareIlluminatedButton59.Value = False
        '
        'SquareIlluminatedButton56
        '
        Me.SquareIlluminatedButton56.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton56.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton56.Location = New System.Drawing.Point(126, 201)
        Me.SquareIlluminatedButton56.Name = "SquareIlluminatedButton56"
        Me.SquareIlluminatedButton56.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton56.PLCAddressClick = ""
        Me.SquareIlluminatedButton56.PLCAddressText = ""
        Me.SquareIlluminatedButton56.PLCAddressValue = "Program:ACT_FENCES_PNEUMATIC.dFenceConfirm[2].0"
        Me.SquareIlluminatedButton56.PLCAddressVisible = ""
        Me.SquareIlluminatedButton56.Size = New System.Drawing.Size(34, 23)
        Me.SquareIlluminatedButton56.TabIndex = 83
        Me.SquareIlluminatedButton56.Text = "4"""
        Me.SquareIlluminatedButton56.Value = False
        '
        'SquareIlluminatedButton57
        '
        Me.SquareIlluminatedButton57.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton57.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton57.Location = New System.Drawing.Point(77, 201)
        Me.SquareIlluminatedButton57.Name = "SquareIlluminatedButton57"
        Me.SquareIlluminatedButton57.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton57.PLCAddressClick = ""
        Me.SquareIlluminatedButton57.PLCAddressText = ""
        Me.SquareIlluminatedButton57.PLCAddressValue = "Program:ACT_FENCES_PNEUMATIC.dFenceConfirm[1].0"
        Me.SquareIlluminatedButton57.PLCAddressVisible = ""
        Me.SquareIlluminatedButton57.Size = New System.Drawing.Size(34, 23)
        Me.SquareIlluminatedButton57.TabIndex = 82
        Me.SquareIlluminatedButton57.Text = "4"""
        Me.SquareIlluminatedButton57.Value = False
        '
        'SquareIlluminatedButton58
        '
        Me.SquareIlluminatedButton58.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton58.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton58.Location = New System.Drawing.Point(28, 201)
        Me.SquareIlluminatedButton58.Name = "SquareIlluminatedButton58"
        Me.SquareIlluminatedButton58.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton58.PLCAddressClick = ""
        Me.SquareIlluminatedButton58.PLCAddressText = ""
        Me.SquareIlluminatedButton58.PLCAddressValue = "Program:ACT_FENCES_PNEUMATIC.dFenceConfirm[0].0"
        Me.SquareIlluminatedButton58.PLCAddressVisible = ""
        Me.SquareIlluminatedButton58.Size = New System.Drawing.Size(34, 23)
        Me.SquareIlluminatedButton58.TabIndex = 81
        Me.SquareIlluminatedButton58.Text = "4"""
        Me.SquareIlluminatedButton58.Value = False
        '
        'SquareIlluminatedButton53
        '
        Me.SquareIlluminatedButton53.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton53.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton53.Location = New System.Drawing.Point(126, 177)
        Me.SquareIlluminatedButton53.Name = "SquareIlluminatedButton53"
        Me.SquareIlluminatedButton53.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton53.PLCAddressClick = ""
        Me.SquareIlluminatedButton53.PLCAddressText = ""
        Me.SquareIlluminatedButton53.PLCAddressValue = "Program:ACT_FENCES_PNEUMATIC.dFenceConfirm[2].1"
        Me.SquareIlluminatedButton53.PLCAddressVisible = ""
        Me.SquareIlluminatedButton53.Size = New System.Drawing.Size(34, 23)
        Me.SquareIlluminatedButton53.TabIndex = 80
        Me.SquareIlluminatedButton53.Text = "2"""
        Me.SquareIlluminatedButton53.Value = False
        '
        'SquareIlluminatedButton54
        '
        Me.SquareIlluminatedButton54.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton54.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton54.Location = New System.Drawing.Point(77, 177)
        Me.SquareIlluminatedButton54.Name = "SquareIlluminatedButton54"
        Me.SquareIlluminatedButton54.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton54.PLCAddressClick = ""
        Me.SquareIlluminatedButton54.PLCAddressText = ""
        Me.SquareIlluminatedButton54.PLCAddressValue = "Program:ACT_FENCES_PNEUMATIC.dFenceConfirm[1].1"
        Me.SquareIlluminatedButton54.PLCAddressVisible = ""
        Me.SquareIlluminatedButton54.Size = New System.Drawing.Size(34, 23)
        Me.SquareIlluminatedButton54.TabIndex = 79
        Me.SquareIlluminatedButton54.Text = "2"""
        Me.SquareIlluminatedButton54.UseWaitCursor = True
        Me.SquareIlluminatedButton54.Value = False
        '
        'SquareIlluminatedButton55
        '
        Me.SquareIlluminatedButton55.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton55.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton55.Location = New System.Drawing.Point(28, 177)
        Me.SquareIlluminatedButton55.Name = "SquareIlluminatedButton55"
        Me.SquareIlluminatedButton55.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton55.PLCAddressClick = ""
        Me.SquareIlluminatedButton55.PLCAddressText = ""
        Me.SquareIlluminatedButton55.PLCAddressValue = "Program:ACT_FENCES_PNEUMATIC.dFenceConfirm[0].1"
        Me.SquareIlluminatedButton55.PLCAddressVisible = ""
        Me.SquareIlluminatedButton55.Size = New System.Drawing.Size(34, 23)
        Me.SquareIlluminatedButton55.TabIndex = 78
        Me.SquareIlluminatedButton55.Text = "2"""
        Me.SquareIlluminatedButton55.Value = False
        '
        'SquareIlluminatedButton50
        '
        Me.SquareIlluminatedButton50.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton50.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton50.Location = New System.Drawing.Point(126, 153)
        Me.SquareIlluminatedButton50.Name = "SquareIlluminatedButton50"
        Me.SquareIlluminatedButton50.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton50.PLCAddressClick = ""
        Me.SquareIlluminatedButton50.PLCAddressText = ""
        Me.SquareIlluminatedButton50.PLCAddressValue = "Program:ACT_FENCES_PNEUMATIC.dFenceConfirm[2].2"
        Me.SquareIlluminatedButton50.PLCAddressVisible = ""
        Me.SquareIlluminatedButton50.Size = New System.Drawing.Size(34, 23)
        Me.SquareIlluminatedButton50.TabIndex = 77
        Me.SquareIlluminatedButton50.Text = "1"""
        Me.SquareIlluminatedButton50.Value = False
        '
        'SquareIlluminatedButton51
        '
        Me.SquareIlluminatedButton51.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton51.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton51.Location = New System.Drawing.Point(77, 153)
        Me.SquareIlluminatedButton51.Name = "SquareIlluminatedButton51"
        Me.SquareIlluminatedButton51.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton51.PLCAddressClick = ""
        Me.SquareIlluminatedButton51.PLCAddressText = ""
        Me.SquareIlluminatedButton51.PLCAddressValue = "Program:ACT_FENCES_PNEUMATIC.dFenceConfirm[1].2"
        Me.SquareIlluminatedButton51.PLCAddressVisible = ""
        Me.SquareIlluminatedButton51.Size = New System.Drawing.Size(34, 23)
        Me.SquareIlluminatedButton51.TabIndex = 76
        Me.SquareIlluminatedButton51.Text = "1"""
        Me.SquareIlluminatedButton51.Value = False
        '
        'SquareIlluminatedButton52
        '
        Me.SquareIlluminatedButton52.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton52.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton52.Location = New System.Drawing.Point(28, 153)
        Me.SquareIlluminatedButton52.Name = "SquareIlluminatedButton52"
        Me.SquareIlluminatedButton52.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton52.PLCAddressClick = ""
        Me.SquareIlluminatedButton52.PLCAddressText = ""
        Me.SquareIlluminatedButton52.PLCAddressValue = "Program:ACT_FENCES_PNEUMATIC.dFenceConfirm[0].2"
        Me.SquareIlluminatedButton52.PLCAddressVisible = ""
        Me.SquareIlluminatedButton52.Size = New System.Drawing.Size(34, 23)
        Me.SquareIlluminatedButton52.TabIndex = 75
        Me.SquareIlluminatedButton52.Text = "1"""
        Me.SquareIlluminatedButton52.Value = False
        '
        'SquareIlluminatedButton49
        '
        Me.SquareIlluminatedButton49.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton49.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton49.Location = New System.Drawing.Point(126, 129)
        Me.SquareIlluminatedButton49.Name = "SquareIlluminatedButton49"
        Me.SquareIlluminatedButton49.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton49.PLCAddressClick = ""
        Me.SquareIlluminatedButton49.PLCAddressText = ""
        Me.SquareIlluminatedButton49.PLCAddressValue = "Program:ACT_FENCES_PNEUMATIC.dFenceConfirm[2].3"
        Me.SquareIlluminatedButton49.PLCAddressVisible = ""
        Me.SquareIlluminatedButton49.Size = New System.Drawing.Size(34, 23)
        Me.SquareIlluminatedButton49.TabIndex = 74
        Me.SquareIlluminatedButton49.Text = "1"""
        Me.SquareIlluminatedButton49.Value = False
        '
        'SquareIlluminatedButton48
        '
        Me.SquareIlluminatedButton48.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton48.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton48.Location = New System.Drawing.Point(77, 129)
        Me.SquareIlluminatedButton48.Name = "SquareIlluminatedButton48"
        Me.SquareIlluminatedButton48.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton48.PLCAddressClick = ""
        Me.SquareIlluminatedButton48.PLCAddressText = ""
        Me.SquareIlluminatedButton48.PLCAddressValue = "Program:ACT_FENCES_PNEUMATIC.dFenceConfirm[1].3"
        Me.SquareIlluminatedButton48.PLCAddressVisible = ""
        Me.SquareIlluminatedButton48.Size = New System.Drawing.Size(34, 23)
        Me.SquareIlluminatedButton48.TabIndex = 73
        Me.SquareIlluminatedButton48.Text = "1"""
        Me.SquareIlluminatedButton48.Value = False
        '
        'SquareIlluminatedButton47
        '
        Me.SquareIlluminatedButton47.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton47.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton47.Location = New System.Drawing.Point(28, 129)
        Me.SquareIlluminatedButton47.Name = "SquareIlluminatedButton47"
        Me.SquareIlluminatedButton47.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton47.PLCAddressClick = ""
        Me.SquareIlluminatedButton47.PLCAddressText = ""
        Me.SquareIlluminatedButton47.PLCAddressValue = "Program:ACT_FENCES_PNEUMATIC.dFenceConfirm[0].3"
        Me.SquareIlluminatedButton47.PLCAddressVisible = ""
        Me.SquareIlluminatedButton47.Size = New System.Drawing.Size(34, 23)
        Me.SquareIlluminatedButton47.TabIndex = 72
        Me.SquareIlluminatedButton47.Text = "1"""
        Me.SquareIlluminatedButton47.Value = False
        '
        'FenceSkidLugIdx
        '
        Me.FenceSkidLugIdx.AutoSize = True
        Me.FenceSkidLugIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FenceSkidLugIdx.Location = New System.Drawing.Point(230, 85)
        Me.FenceSkidLugIdx.Name = "FenceSkidLugIdx"
        Me.FenceSkidLugIdx.Size = New System.Drawing.Size(115, 17)
        Me.FenceSkidLugIdx.TabIndex = 32
        Me.FenceSkidLugIdx.Text = "FenceSkidLugIdx"
        '
        'FenceLugIdx
        '
        Me.FenceLugIdx.AutoSize = True
        Me.FenceLugIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FenceLugIdx.Location = New System.Drawing.Point(28, 85)
        Me.FenceLugIdx.Name = "FenceLugIdx"
        Me.FenceLugIdx.Size = New System.Drawing.Size(88, 17)
        Me.FenceLugIdx.TabIndex = 0
        Me.FenceLugIdx.Text = "FenceLugIdx"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.SquareIlluminatedButton63)
        Me.GroupBox5.Controls.Add(Me.BasicLabel3)
        Me.GroupBox5.Controls.Add(Me.BasicLabel2)
        Me.GroupBox5.Controls.Add(Me.LS0_2fbk)
        Me.GroupBox5.Controls.Add(Me.LS6_2fbk)
        Me.GroupBox5.Controls.Add(Me.LS8_2fbk)
        Me.GroupBox5.Controls.Add(Me.LS10_2fbk)
        Me.GroupBox5.Controls.Add(Me.LS12_2fbk)
        Me.GroupBox5.Controls.Add(Me.LS14_2fbk)
        Me.GroupBox5.Controls.Add(Me.LS16_2fbk)
        Me.GroupBox5.Controls.Add(Me.SquareIlluminatedButton13)
        Me.GroupBox5.Controls.Add(Me.SquareIlluminatedButton12)
        Me.GroupBox5.Controls.Add(Me.SquareIlluminatedButton11)
        Me.GroupBox5.Controls.Add(Me.SquareIlluminatedButton10)
        Me.GroupBox5.Controls.Add(Me.SquareIlluminatedButton9)
        Me.GroupBox5.Controls.Add(Me.SquareIlluminatedButton8)
        Me.GroupBox5.Controls.Add(Me.SquareIlluminatedButton7)
        Me.GroupBox5.Controls.Add(Me.SquareIlluminatedButton6)
        Me.GroupBox5.Controls.Add(Me.SquareIlluminatedButton5)
        Me.GroupBox5.Controls.Add(Me.SquareIlluminatedButton4)
        Me.GroupBox5.Controls.Add(Me.SquareIlluminatedButton3)
        Me.GroupBox5.Controls.Add(Me.SquareIlluminatedButton2)
        Me.GroupBox5.Controls.Add(Me.SquareIlluminatedButton1)
        Me.GroupBox5.Controls.Add(Me.CheckBox13)
        Me.GroupBox5.Controls.Add(Me.SimulReadLen2Button)
        Me.GroupBox5.Controls.Add(Me.CheckBox17)
        Me.GroupBox5.Controls.Add(Me.CheckBox30)
        Me.GroupBox5.Controls.Add(Me.CheckBox39)
        Me.GroupBox5.Controls.Add(Me.CheckBox41)
        Me.GroupBox5.Controls.Add(Me.CheckBox43)
        Me.GroupBox5.Controls.Add(Me.CheckBox52)
        Me.GroupBox5.Controls.Add(Me.CitSkidLugIdx)
        Me.GroupBox5.Controls.Add(Me.ReadLen2LugIdx)
        Me.GroupBox5.Controls.Add(Me.SawsLugIdx)
        Me.GroupBox5.Location = New System.Drawing.Point(27, 524)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(424, 444)
        Me.GroupBox5.TabIndex = 47
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'SquareIlluminatedButton63
        '
        Me.SquareIlluminatedButton63.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton63.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton63.Location = New System.Drawing.Point(179, 414)
        Me.SquareIlluminatedButton63.Name = "SquareIlluminatedButton63"
        Me.SquareIlluminatedButton63.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton63.PLCAddressClick = ""
        Me.SquareIlluminatedButton63.PLCAddressText = ""
        Me.SquareIlluminatedButton63.PLCAddressValue = "Program:ACT_SAWS.bNoTrimDebug"
        Me.SquareIlluminatedButton63.PLCAddressVisible = ""
        Me.SquareIlluminatedButton63.Size = New System.Drawing.Size(61, 21)
        Me.SquareIlluminatedButton63.TabIndex = 106
        Me.SquareIlluminatedButton63.Text = "NoTrim"
        Me.SquareIlluminatedButton63.Value = False
        '
        'BasicLabel3
        '
        Me.BasicLabel3.AutoSize = True
        Me.BasicLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel3.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel3.ComComponent = Me.EthernetIPforCLXCom1
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
        Me.BasicLabel3.Location = New System.Drawing.Point(176, 394)
        Me.BasicLabel3.Name = "BasicLabel3"
        Me.BasicLabel3.NumericFormat = Nothing
        Me.BasicLabel3.PLCAddressKeypad = ""
        Me.BasicLabel3.PLCAddressValue = "Program:ACT_SAWS.dLengthDebug[1]"
        Me.BasicLabel3.Size = New System.Drawing.Size(110, 17)
        Me.BasicLabel3.TabIndex = 105
        Me.BasicLabel3.Text = "Len2 FinalValue"
        Me.BasicLabel3.Value = "FinalValue"
        Me.BasicLabel3.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel3.ValueLeftPadLength = 0
        Me.BasicLabel3.ValuePrefix = "Len2 "
        Me.BasicLabel3.ValueScaleFactor = 0.1R
        Me.BasicLabel3.ValueSuffix = Nothing
        Me.BasicLabel3.ValueToSubtractFrom = 0!
        '
        'BasicLabel2
        '
        Me.BasicLabel2.AutoSize = True
        Me.BasicLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel2.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel2.ComComponent = Me.EthernetIPforCLXCom1
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
        Me.BasicLabel2.Location = New System.Drawing.Point(176, 377)
        Me.BasicLabel2.Name = "BasicLabel2"
        Me.BasicLabel2.NumericFormat = Nothing
        Me.BasicLabel2.PLCAddressKeypad = ""
        Me.BasicLabel2.PLCAddressValue = "Program:ACT_SAWS.dLengthDebug[0]"
        Me.BasicLabel2.Size = New System.Drawing.Size(110, 17)
        Me.BasicLabel2.TabIndex = 104
        Me.BasicLabel2.Text = "Len1 FinalValue"
        Me.BasicLabel2.Value = "FinalValue"
        Me.BasicLabel2.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel2.ValueLeftPadLength = 0
        Me.BasicLabel2.ValuePrefix = "Len1 "
        Me.BasicLabel2.ValueScaleFactor = 0.1R
        Me.BasicLabel2.ValueSuffix = Nothing
        Me.BasicLabel2.ValueToSubtractFrom = 0!
        '
        'LS0_2fbk
        '
        Me.LS0_2fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS0_2fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS0_2fbk.Location = New System.Drawing.Point(107, 112)
        Me.LS0_2fbk.Name = "LS0_2fbk"
        Me.LS0_2fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS0_2fbk.PLCAddressClick = ""
        Me.LS0_2fbk.PLCAddressText = ""
        Me.LS0_2fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_2.dLengthLS.0"
        Me.LS0_2fbk.PLCAddressVisible = ""
        Me.LS0_2fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS0_2fbk.TabIndex = 97
        Me.LS0_2fbk.Value = False
        '
        'LS6_2fbk
        '
        Me.LS6_2fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS6_2fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS6_2fbk.Location = New System.Drawing.Point(107, 136)
        Me.LS6_2fbk.Name = "LS6_2fbk"
        Me.LS6_2fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS6_2fbk.PLCAddressClick = ""
        Me.LS6_2fbk.PLCAddressText = ""
        Me.LS6_2fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_2.dLengthLS.1"
        Me.LS6_2fbk.PLCAddressVisible = ""
        Me.LS6_2fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS6_2fbk.TabIndex = 96
        Me.LS6_2fbk.Value = False
        '
        'LS8_2fbk
        '
        Me.LS8_2fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS8_2fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS8_2fbk.Location = New System.Drawing.Point(107, 160)
        Me.LS8_2fbk.Name = "LS8_2fbk"
        Me.LS8_2fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS8_2fbk.PLCAddressClick = ""
        Me.LS8_2fbk.PLCAddressText = ""
        Me.LS8_2fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_2.dLengthLS.2"
        Me.LS8_2fbk.PLCAddressVisible = ""
        Me.LS8_2fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS8_2fbk.TabIndex = 95
        Me.LS8_2fbk.Value = False
        '
        'LS10_2fbk
        '
        Me.LS10_2fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS10_2fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS10_2fbk.Location = New System.Drawing.Point(107, 184)
        Me.LS10_2fbk.Name = "LS10_2fbk"
        Me.LS10_2fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS10_2fbk.PLCAddressClick = ""
        Me.LS10_2fbk.PLCAddressText = ""
        Me.LS10_2fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_2.dLengthLS.3"
        Me.LS10_2fbk.PLCAddressVisible = ""
        Me.LS10_2fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS10_2fbk.TabIndex = 94
        Me.LS10_2fbk.Value = False
        '
        'LS12_2fbk
        '
        Me.LS12_2fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS12_2fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS12_2fbk.Location = New System.Drawing.Point(107, 209)
        Me.LS12_2fbk.Name = "LS12_2fbk"
        Me.LS12_2fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS12_2fbk.PLCAddressClick = ""
        Me.LS12_2fbk.PLCAddressText = ""
        Me.LS12_2fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_2.dLengthLS.4"
        Me.LS12_2fbk.PLCAddressVisible = ""
        Me.LS12_2fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS12_2fbk.TabIndex = 93
        Me.LS12_2fbk.Value = False
        '
        'LS14_2fbk
        '
        Me.LS14_2fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS14_2fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS14_2fbk.Location = New System.Drawing.Point(107, 234)
        Me.LS14_2fbk.Name = "LS14_2fbk"
        Me.LS14_2fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS14_2fbk.PLCAddressClick = ""
        Me.LS14_2fbk.PLCAddressText = ""
        Me.LS14_2fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_2.dLengthLS.5"
        Me.LS14_2fbk.PLCAddressVisible = ""
        Me.LS14_2fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS14_2fbk.TabIndex = 92
        Me.LS14_2fbk.Value = False
        '
        'LS16_2fbk
        '
        Me.LS16_2fbk.ComComponent = Me.EthernetIPforCLXCom1
        Me.LS16_2fbk.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.LS16_2fbk.Location = New System.Drawing.Point(107, 257)
        Me.LS16_2fbk.Name = "LS16_2fbk"
        Me.LS16_2fbk.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.LS16_2fbk.PLCAddressClick = ""
        Me.LS16_2fbk.PLCAddressText = ""
        Me.LS16_2fbk.PLCAddressValue = "Program:ACT_READ_LENGTH_2.dLengthLS.6"
        Me.LS16_2fbk.PLCAddressVisible = ""
        Me.LS16_2fbk.Size = New System.Drawing.Size(21, 21)
        Me.LS16_2fbk.TabIndex = 91
        Me.LS16_2fbk.Value = False
        '
        'SquareIlluminatedButton13
        '
        Me.SquareIlluminatedButton13.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton13.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton13.Location = New System.Drawing.Point(298, 131)
        Me.SquareIlluminatedButton13.Name = "SquareIlluminatedButton13"
        Me.SquareIlluminatedButton13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton13.PLCAddressClick = ""
        Me.SquareIlluminatedButton13.PLCAddressText = ""
        Me.SquareIlluminatedButton13.PLCAddressValue = "Program:ACT_CIT_SKID._OUT_Skid02"
        Me.SquareIlluminatedButton13.PLCAddressVisible = ""
        Me.SquareIlluminatedButton13.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton13.TabIndex = 62
        Me.SquareIlluminatedButton13.Text = "6-7'"
        Me.SquareIlluminatedButton13.Value = False
        '
        'SquareIlluminatedButton12
        '
        Me.SquareIlluminatedButton12.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton12.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton12.Location = New System.Drawing.Point(298, 107)
        Me.SquareIlluminatedButton12.Name = "SquareIlluminatedButton12"
        Me.SquareIlluminatedButton12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton12.PLCAddressClick = ""
        Me.SquareIlluminatedButton12.PLCAddressText = ""
        Me.SquareIlluminatedButton12.PLCAddressValue = "Program:ACT_CIT_SKID._OUT_Skid01"
        Me.SquareIlluminatedButton12.PLCAddressVisible = ""
        Me.SquareIlluminatedButton12.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton12.TabIndex = 61
        Me.SquareIlluminatedButton12.Text = "0-6'"
        Me.SquareIlluminatedButton12.Value = False
        '
        'SquareIlluminatedButton11
        '
        Me.SquareIlluminatedButton11.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton11.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton11.Location = New System.Drawing.Point(175, 348)
        Me.SquareIlluminatedButton11.Name = "SquareIlluminatedButton11"
        Me.SquareIlluminatedButton11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton11.PLCAddressClick = ""
        Me.SquareIlluminatedButton11.PLCAddressText = ""
        Me.SquareIlluminatedButton11.PLCAddressValue = "Program:ACT_SAWS._OUT_SAW11"
        Me.SquareIlluminatedButton11.PLCAddressVisible = ""
        Me.SquareIlluminatedButton11.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton11.TabIndex = 60
        Me.SquareIlluminatedButton11.Text = "Saw 16'"
        Me.SquareIlluminatedButton11.Value = False
        '
        'SquareIlluminatedButton10
        '
        Me.SquareIlluminatedButton10.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton10.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton10.Location = New System.Drawing.Point(175, 324)
        Me.SquareIlluminatedButton10.Name = "SquareIlluminatedButton10"
        Me.SquareIlluminatedButton10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton10.PLCAddressClick = ""
        Me.SquareIlluminatedButton10.PLCAddressText = ""
        Me.SquareIlluminatedButton10.PLCAddressValue = "Program:ACT_SAWS._OUT_SAW10"
        Me.SquareIlluminatedButton10.PLCAddressVisible = ""
        Me.SquareIlluminatedButton10.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton10.TabIndex = 59
        Me.SquareIlluminatedButton10.Text = "Saw 14'"
        Me.SquareIlluminatedButton10.Value = False
        '
        'SquareIlluminatedButton9
        '
        Me.SquareIlluminatedButton9.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton9.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton9.Location = New System.Drawing.Point(175, 302)
        Me.SquareIlluminatedButton9.Name = "SquareIlluminatedButton9"
        Me.SquareIlluminatedButton9.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton9.PLCAddressClick = ""
        Me.SquareIlluminatedButton9.PLCAddressText = ""
        Me.SquareIlluminatedButton9.PLCAddressValue = "Program:ACT_SAWS._OUT_SAW09"
        Me.SquareIlluminatedButton9.PLCAddressVisible = ""
        Me.SquareIlluminatedButton9.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton9.TabIndex = 58
        Me.SquareIlluminatedButton9.Text = "Saw 12'"
        Me.SquareIlluminatedButton9.Value = False
        '
        'SquareIlluminatedButton8
        '
        Me.SquareIlluminatedButton8.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton8.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton8.Location = New System.Drawing.Point(175, 278)
        Me.SquareIlluminatedButton8.Name = "SquareIlluminatedButton8"
        Me.SquareIlluminatedButton8.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton8.PLCAddressClick = ""
        Me.SquareIlluminatedButton8.PLCAddressText = ""
        Me.SquareIlluminatedButton8.PLCAddressValue = "Program:ACT_SAWS._OUT_SAW08"
        Me.SquareIlluminatedButton8.PLCAddressVisible = ""
        Me.SquareIlluminatedButton8.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton8.TabIndex = 57
        Me.SquareIlluminatedButton8.Text = "Saw 10'"
        Me.SquareIlluminatedButton8.Value = False
        '
        'SquareIlluminatedButton7
        '
        Me.SquareIlluminatedButton7.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton7.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton7.Location = New System.Drawing.Point(175, 254)
        Me.SquareIlluminatedButton7.Name = "SquareIlluminatedButton7"
        Me.SquareIlluminatedButton7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton7.PLCAddressClick = ""
        Me.SquareIlluminatedButton7.PLCAddressText = ""
        Me.SquareIlluminatedButton7.PLCAddressValue = "Program:ACT_SAWS._OUT_SAW07"
        Me.SquareIlluminatedButton7.PLCAddressVisible = ""
        Me.SquareIlluminatedButton7.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton7.TabIndex = 56
        Me.SquareIlluminatedButton7.Text = "Saw 8'"
        Me.SquareIlluminatedButton7.Value = False
        '
        'SquareIlluminatedButton6
        '
        Me.SquareIlluminatedButton6.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton6.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton6.Location = New System.Drawing.Point(175, 229)
        Me.SquareIlluminatedButton6.Name = "SquareIlluminatedButton6"
        Me.SquareIlluminatedButton6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton6.PLCAddressClick = ""
        Me.SquareIlluminatedButton6.PLCAddressText = ""
        Me.SquareIlluminatedButton6.PLCAddressValue = "Program:ACT_SAWS._OUT_SAW06"
        Me.SquareIlluminatedButton6.PLCAddressVisible = ""
        Me.SquareIlluminatedButton6.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton6.TabIndex = 55
        Me.SquareIlluminatedButton6.Text = "Saw 6'"
        Me.SquareIlluminatedButton6.Value = False
        '
        'SquareIlluminatedButton5
        '
        Me.SquareIlluminatedButton5.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton5.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton5.Location = New System.Drawing.Point(175, 204)
        Me.SquareIlluminatedButton5.Name = "SquareIlluminatedButton5"
        Me.SquareIlluminatedButton5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton5.PLCAddressClick = ""
        Me.SquareIlluminatedButton5.PLCAddressText = ""
        Me.SquareIlluminatedButton5.PLCAddressValue = "Program:ACT_SAWS._OUT_SAW05"
        Me.SquareIlluminatedButton5.PLCAddressVisible = ""
        Me.SquareIlluminatedButton5.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton5.TabIndex = 54
        Me.SquareIlluminatedButton5.Text = "Saw 4'"
        Me.SquareIlluminatedButton5.Value = False
        '
        'SquareIlluminatedButton4
        '
        Me.SquareIlluminatedButton4.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton4.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton4.Location = New System.Drawing.Point(175, 179)
        Me.SquareIlluminatedButton4.Name = "SquareIlluminatedButton4"
        Me.SquareIlluminatedButton4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton4.PLCAddressClick = ""
        Me.SquareIlluminatedButton4.PLCAddressText = ""
        Me.SquareIlluminatedButton4.PLCAddressValue = "Program:ACT_SAWS._OUT_SAW04"
        Me.SquareIlluminatedButton4.PLCAddressVisible = ""
        Me.SquareIlluminatedButton4.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton4.TabIndex = 53
        Me.SquareIlluminatedButton4.Text = "Saw 2'"
        Me.SquareIlluminatedButton4.Value = False
        '
        'SquareIlluminatedButton3
        '
        Me.SquareIlluminatedButton3.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton3.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton3.Location = New System.Drawing.Point(175, 155)
        Me.SquareIlluminatedButton3.Name = "SquareIlluminatedButton3"
        Me.SquareIlluminatedButton3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton3.PLCAddressClick = ""
        Me.SquareIlluminatedButton3.PLCAddressText = ""
        Me.SquareIlluminatedButton3.PLCAddressValue = "Program:ACT_SAWS._OUT_SAW03"
        Me.SquareIlluminatedButton3.PLCAddressVisible = ""
        Me.SquareIlluminatedButton3.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton3.TabIndex = 52
        Me.SquareIlluminatedButton3.Text = "Saw 1'"
        Me.SquareIlluminatedButton3.Value = False
        '
        'SquareIlluminatedButton2
        '
        Me.SquareIlluminatedButton2.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton2.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton2.Location = New System.Drawing.Point(175, 131)
        Me.SquareIlluminatedButton2.Name = "SquareIlluminatedButton2"
        Me.SquareIlluminatedButton2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton2.PLCAddressClick = ""
        Me.SquareIlluminatedButton2.PLCAddressText = ""
        Me.SquareIlluminatedButton2.PLCAddressValue = "Program:ACT_SAWS._OUT_SAW02"
        Me.SquareIlluminatedButton2.PLCAddressVisible = ""
        Me.SquareIlluminatedButton2.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton2.TabIndex = 51
        Me.SquareIlluminatedButton2.Text = "Saw 0'"
        Me.SquareIlluminatedButton2.Value = False
        '
        'SquareIlluminatedButton1
        '
        Me.SquareIlluminatedButton1.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton1.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton1.Location = New System.Drawing.Point(175, 105)
        Me.SquareIlluminatedButton1.Name = "SquareIlluminatedButton1"
        Me.SquareIlluminatedButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton1.PLCAddressClick = ""
        Me.SquareIlluminatedButton1.PLCAddressText = ""
        Me.SquareIlluminatedButton1.PLCAddressValue = "Program:ACT_SAWS._OUT_SAW01"
        Me.SquareIlluminatedButton1.PLCAddressVisible = ""
        Me.SquareIlluminatedButton1.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton1.TabIndex = 48
        Me.SquareIlluminatedButton1.Text = "Saw -1'"
        Me.SquareIlluminatedButton1.Value = False
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox13.Location = New System.Drawing.Point(31, 259)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_2.dSimulLS.6"
        Me.CheckBox13.PLCAddressChecked = "Program:ACT_READ_LENGTH_2.dSimulLS.6"
        Me.CheckBox13.PLCAddressText = ""
        Me.CheckBox13.PLCAddressVisible = ""
        Me.CheckBox13.Size = New System.Drawing.Size(70, 21)
        Me.CheckBox13.TabIndex = 50
        Me.CheckBox13.Text = "LS 16'"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'SimulReadLen2Button
        '
        Me.SimulReadLen2Button.BackColor = System.Drawing.Color.LightGray
        Me.SimulReadLen2Button.ComComponent = Me.EthernetIPforCLXCom1
        Me.SimulReadLen2Button.ForeColor = System.Drawing.Color.Black
        Me.SimulReadLen2Button.ForeColorAlternate = System.Drawing.Color.Black
        Me.SimulReadLen2Button.Highlight = False
        Me.SimulReadLen2Button.HighlightColor = System.Drawing.Color.Green
        Me.SimulReadLen2Button.Location = New System.Drawing.Point(30, 15)
        Me.SimulReadLen2Button.MaximumHoldTime = 3000
        Me.SimulReadLen2Button.MinimumHoldTime = 500
        Me.SimulReadLen2Button.Name = "SimulReadLen2Button"
        Me.SimulReadLen2Button.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.SimulReadLen2Button.PLCAddressClick = "Program:ACT_READ_LENGTH_2.bSimul"
        Me.SimulReadLen2Button.PLCAddressHighlightX = "Program:ACT_READ_LENGTH_2.bSimul"
        Me.SimulReadLen2Button.SelectTextAlternate = False
        Me.SimulReadLen2Button.Size = New System.Drawing.Size(167, 60)
        Me.SimulReadLen2Button.TabIndex = 47
        Me.SimulReadLen2Button.Text = "Simul Read Len 2"
        Me.SimulReadLen2Button.TextAlternate = Nothing
        Me.SimulReadLen2Button.UseVisualStyleBackColor = True
        Me.SimulReadLen2Button.ValueToWrite = 1
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox17.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox17.Location = New System.Drawing.Point(31, 234)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_2.dSimulLS.5"
        Me.CheckBox17.PLCAddressChecked = "Program:ACT_READ_LENGTH_2.dSimulLS.5"
        Me.CheckBox17.PLCAddressText = ""
        Me.CheckBox17.PLCAddressVisible = ""
        Me.CheckBox17.Size = New System.Drawing.Size(70, 21)
        Me.CheckBox17.TabIndex = 49
        Me.CheckBox17.Text = "LS 14'"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox30
        '
        Me.CheckBox30.AutoSize = True
        Me.CheckBox30.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox30.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox30.Location = New System.Drawing.Point(31, 209)
        Me.CheckBox30.Name = "CheckBox30"
        Me.CheckBox30.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_2.dSimulLS.4"
        Me.CheckBox30.PLCAddressChecked = "Program:ACT_READ_LENGTH_2.dSimulLS.4"
        Me.CheckBox30.PLCAddressText = ""
        Me.CheckBox30.PLCAddressVisible = ""
        Me.CheckBox30.Size = New System.Drawing.Size(70, 21)
        Me.CheckBox30.TabIndex = 48
        Me.CheckBox30.Text = "LS 12'"
        Me.CheckBox30.UseVisualStyleBackColor = True
        '
        'CheckBox39
        '
        Me.CheckBox39.AutoSize = True
        Me.CheckBox39.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox39.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox39.Location = New System.Drawing.Point(31, 184)
        Me.CheckBox39.Name = "CheckBox39"
        Me.CheckBox39.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_2.dSimulLS.3"
        Me.CheckBox39.PLCAddressChecked = "Program:ACT_READ_LENGTH_2.dSimulLS.3"
        Me.CheckBox39.PLCAddressText = ""
        Me.CheckBox39.PLCAddressVisible = ""
        Me.CheckBox39.Size = New System.Drawing.Size(70, 21)
        Me.CheckBox39.TabIndex = 47
        Me.CheckBox39.Text = "LS 10'"
        Me.CheckBox39.UseVisualStyleBackColor = True
        '
        'CheckBox41
        '
        Me.CheckBox41.AutoSize = True
        Me.CheckBox41.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox41.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox41.Location = New System.Drawing.Point(31, 160)
        Me.CheckBox41.Name = "CheckBox41"
        Me.CheckBox41.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_2.dSimulLS.2"
        Me.CheckBox41.PLCAddressChecked = "Program:ACT_READ_LENGTH_2.dSimulLS.2"
        Me.CheckBox41.PLCAddressText = ""
        Me.CheckBox41.PLCAddressVisible = ""
        Me.CheckBox41.Size = New System.Drawing.Size(62, 21)
        Me.CheckBox41.TabIndex = 46
        Me.CheckBox41.Text = "LS 8'"
        Me.CheckBox41.UseVisualStyleBackColor = True
        '
        'CheckBox43
        '
        Me.CheckBox43.AutoSize = True
        Me.CheckBox43.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox43.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox43.Location = New System.Drawing.Point(31, 136)
        Me.CheckBox43.Name = "CheckBox43"
        Me.CheckBox43.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_2.dSimulLS.1"
        Me.CheckBox43.PLCAddressChecked = "Program:ACT_READ_LENGTH_2.dSimulLS.1"
        Me.CheckBox43.PLCAddressText = ""
        Me.CheckBox43.PLCAddressVisible = ""
        Me.CheckBox43.Size = New System.Drawing.Size(62, 21)
        Me.CheckBox43.TabIndex = 45
        Me.CheckBox43.Text = "LS 6'"
        Me.CheckBox43.UseVisualStyleBackColor = True
        '
        'CheckBox52
        '
        Me.CheckBox52.AutoSize = True
        Me.CheckBox52.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox52.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox52.Location = New System.Drawing.Point(31, 112)
        Me.CheckBox52.Name = "CheckBox52"
        Me.CheckBox52.PLCAddressCheckChanged = "Program:ACT_READ_LENGTH_2.dSimulLS.0"
        Me.CheckBox52.PLCAddressChecked = "Program:ACT_READ_LENGTH_2.dSimulLS.0"
        Me.CheckBox52.PLCAddressText = ""
        Me.CheckBox52.PLCAddressVisible = ""
        Me.CheckBox52.Size = New System.Drawing.Size(62, 21)
        Me.CheckBox52.TabIndex = 44
        Me.CheckBox52.Text = "LS 0'"
        Me.CheckBox52.UseVisualStyleBackColor = True
        '
        'CitSkidLugIdx
        '
        Me.CitSkidLugIdx.AutoSize = True
        Me.CitSkidLugIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CitSkidLugIdx.Location = New System.Drawing.Point(295, 85)
        Me.CitSkidLugIdx.Name = "CitSkidLugIdx"
        Me.CitSkidLugIdx.Size = New System.Drawing.Size(92, 17)
        Me.CitSkidLugIdx.TabIndex = 32
        Me.CitSkidLugIdx.Text = "CitSkidLugIdx"
        '
        'ReadLen2LugIdx
        '
        Me.ReadLen2LugIdx.AutoSize = True
        Me.ReadLen2LugIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReadLen2LugIdx.Location = New System.Drawing.Point(28, 85)
        Me.ReadLen2LugIdx.Name = "ReadLen2LugIdx"
        Me.ReadLen2LugIdx.Size = New System.Drawing.Size(115, 17)
        Me.ReadLen2LugIdx.TabIndex = 32
        Me.ReadLen2LugIdx.Text = "ReadLen2LugIdx"
        '
        'SawsLugIdx
        '
        Me.SawsLugIdx.AutoSize = True
        Me.SawsLugIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SawsLugIdx.Location = New System.Drawing.Point(172, 85)
        Me.SawsLugIdx.Name = "SawsLugIdx"
        Me.SawsLugIdx.Size = New System.Drawing.Size(82, 17)
        Me.SawsLugIdx.TabIndex = 0
        Me.SawsLugIdx.Text = "SawsLugIdx"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.SquareIlluminatedButton21)
        Me.GroupBox6.Controls.Add(Me.SquareIlluminatedButton20)
        Me.GroupBox6.Controls.Add(Me.SquareIlluminatedButton19)
        Me.GroupBox6.Controls.Add(Me.SquareIlluminatedButton18)
        Me.GroupBox6.Controls.Add(Me.SquareIlluminatedButton17)
        Me.GroupBox6.Controls.Add(Me.SquareIlluminatedButton16)
        Me.GroupBox6.Controls.Add(Me.SquareIlluminatedButton15)
        Me.GroupBox6.Controls.Add(Me.SquareIlluminatedButton14)
        Me.GroupBox6.Controls.Add(Me.BasicButton2)
        Me.GroupBox6.Controls.Add(Me.CheckBox48)
        Me.GroupBox6.Controls.Add(Me.CheckBox49)
        Me.GroupBox6.Controls.Add(Me.CheckBox50)
        Me.GroupBox6.Controls.Add(Me.CheckBox51)
        Me.GroupBox6.Controls.Add(Me.PositionConfLugIdx)
        Me.GroupBox6.Controls.Add(Me.PositionSkidLugIdx)
        Me.GroupBox6.Location = New System.Drawing.Point(471, 524)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(424, 444)
        Me.GroupBox6.TabIndex = 48
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GroupBox6"
        '
        'SquareIlluminatedButton21
        '
        Me.SquareIlluminatedButton21.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton21.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton21.Location = New System.Drawing.Point(30, 278)
        Me.SquareIlluminatedButton21.Name = "SquareIlluminatedButton21"
        Me.SquareIlluminatedButton21.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton21.PLCAddressClick = ""
        Me.SquareIlluminatedButton21.PLCAddressText = ""
        Me.SquareIlluminatedButton21.PLCAddressValue = "Program:ACT_BUMPERS._OUT_Bumper08"
        Me.SquareIlluminatedButton21.PLCAddressVisible = ""
        Me.SquareIlluminatedButton21.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton21.TabIndex = 70
        Me.SquareIlluminatedButton21.Text = "Skid3_3"
        Me.SquareIlluminatedButton21.Value = False
        '
        'SquareIlluminatedButton20
        '
        Me.SquareIlluminatedButton20.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton20.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton20.Location = New System.Drawing.Point(30, 254)
        Me.SquareIlluminatedButton20.Name = "SquareIlluminatedButton20"
        Me.SquareIlluminatedButton20.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton20.PLCAddressClick = ""
        Me.SquareIlluminatedButton20.PLCAddressText = ""
        Me.SquareIlluminatedButton20.PLCAddressValue = "Program:ACT_BUMPERS._OUT_Bumper07"
        Me.SquareIlluminatedButton20.PLCAddressVisible = ""
        Me.SquareIlluminatedButton20.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton20.TabIndex = 69
        Me.SquareIlluminatedButton20.Text = "Skid3_2"
        Me.SquareIlluminatedButton20.Value = False
        '
        'SquareIlluminatedButton19
        '
        Me.SquareIlluminatedButton19.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton19.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton19.Location = New System.Drawing.Point(30, 229)
        Me.SquareIlluminatedButton19.Name = "SquareIlluminatedButton19"
        Me.SquareIlluminatedButton19.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton19.PLCAddressClick = ""
        Me.SquareIlluminatedButton19.PLCAddressText = ""
        Me.SquareIlluminatedButton19.PLCAddressValue = "Program:ACT_BUMPERS._OUT_Bumper06"
        Me.SquareIlluminatedButton19.PLCAddressVisible = ""
        Me.SquareIlluminatedButton19.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton19.TabIndex = 68
        Me.SquareIlluminatedButton19.Text = "Skid3_1"
        Me.SquareIlluminatedButton19.Value = False
        '
        'SquareIlluminatedButton18
        '
        Me.SquareIlluminatedButton18.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton18.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton18.Location = New System.Drawing.Point(30, 202)
        Me.SquareIlluminatedButton18.Name = "SquareIlluminatedButton18"
        Me.SquareIlluminatedButton18.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton18.PLCAddressClick = ""
        Me.SquareIlluminatedButton18.PLCAddressText = ""
        Me.SquareIlluminatedButton18.PLCAddressValue = "Program:ACT_BUMPERS._OUT_Bumper05"
        Me.SquareIlluminatedButton18.PLCAddressVisible = ""
        Me.SquareIlluminatedButton18.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton18.TabIndex = 67
        Me.SquareIlluminatedButton18.Text = "Skid2_3"
        Me.SquareIlluminatedButton18.Value = False
        '
        'SquareIlluminatedButton17
        '
        Me.SquareIlluminatedButton17.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton17.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton17.Location = New System.Drawing.Point(30, 177)
        Me.SquareIlluminatedButton17.Name = "SquareIlluminatedButton17"
        Me.SquareIlluminatedButton17.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton17.PLCAddressClick = ""
        Me.SquareIlluminatedButton17.PLCAddressText = ""
        Me.SquareIlluminatedButton17.PLCAddressValue = "Program:ACT_BUMPERS._OUT_Bumper04"
        Me.SquareIlluminatedButton17.PLCAddressVisible = ""
        Me.SquareIlluminatedButton17.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton17.TabIndex = 66
        Me.SquareIlluminatedButton17.Text = "Skid2_2"
        Me.SquareIlluminatedButton17.Value = False
        '
        'SquareIlluminatedButton16
        '
        Me.SquareIlluminatedButton16.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton16.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton16.Location = New System.Drawing.Point(30, 155)
        Me.SquareIlluminatedButton16.Name = "SquareIlluminatedButton16"
        Me.SquareIlluminatedButton16.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton16.PLCAddressClick = ""
        Me.SquareIlluminatedButton16.PLCAddressText = ""
        Me.SquareIlluminatedButton16.PLCAddressValue = "Program:ACT_BUMPERS._OUT_Bumper03"
        Me.SquareIlluminatedButton16.PLCAddressVisible = ""
        Me.SquareIlluminatedButton16.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton16.TabIndex = 65
        Me.SquareIlluminatedButton16.Text = "Skid2_1"
        Me.SquareIlluminatedButton16.Value = False
        '
        'SquareIlluminatedButton15
        '
        Me.SquareIlluminatedButton15.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton15.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton15.Location = New System.Drawing.Point(30, 131)
        Me.SquareIlluminatedButton15.Name = "SquareIlluminatedButton15"
        Me.SquareIlluminatedButton15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton15.PLCAddressClick = ""
        Me.SquareIlluminatedButton15.PLCAddressText = ""
        Me.SquareIlluminatedButton15.PLCAddressValue = "Program:ACT_BUMPERS._OUT_Bumper02"
        Me.SquareIlluminatedButton15.PLCAddressVisible = ""
        Me.SquareIlluminatedButton15.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton15.TabIndex = 64
        Me.SquareIlluminatedButton15.Text = "Skid1_2"
        Me.SquareIlluminatedButton15.Value = False
        '
        'SquareIlluminatedButton14
        '
        Me.SquareIlluminatedButton14.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton14.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton14.Location = New System.Drawing.Point(30, 105)
        Me.SquareIlluminatedButton14.Name = "SquareIlluminatedButton14"
        Me.SquareIlluminatedButton14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton14.PLCAddressClick = ""
        Me.SquareIlluminatedButton14.PLCAddressText = ""
        Me.SquareIlluminatedButton14.PLCAddressValue = "Program:ACT_BUMPERS._OUT_Bumper01"
        Me.SquareIlluminatedButton14.PLCAddressVisible = ""
        Me.SquareIlluminatedButton14.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton14.TabIndex = 63
        Me.SquareIlluminatedButton14.Text = "Skid1_1"
        Me.SquareIlluminatedButton14.Value = False
        '
        'BasicButton2
        '
        Me.BasicButton2.BackColor = System.Drawing.Color.LightGray
        Me.BasicButton2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicButton2.ForeColor = System.Drawing.Color.Black
        Me.BasicButton2.ForeColorAlternate = System.Drawing.Color.Black
        Me.BasicButton2.Highlight = False
        Me.BasicButton2.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton2.Location = New System.Drawing.Point(230, 15)
        Me.BasicButton2.MaximumHoldTime = 3000
        Me.BasicButton2.MinimumHoldTime = 500
        Me.BasicButton2.Name = "BasicButton2"
        Me.BasicButton2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BasicButton2.PLCAddressClick = "Program:ACT_BOARD_CENTERED_CONFIRMATION.bSimul"
        Me.BasicButton2.PLCAddressHighlightX = "Program:ACT_BOARD_CENTERED_CONFIRMATION.bSimul"
        Me.BasicButton2.SelectTextAlternate = False
        Me.BasicButton2.Size = New System.Drawing.Size(167, 60)
        Me.BasicButton2.TabIndex = 47
        Me.BasicButton2.Text = "Simul Position Conf"
        Me.BasicButton2.TextAlternate = Nothing
        Me.BasicButton2.UseVisualStyleBackColor = True
        Me.BasicButton2.ValueToWrite = 1
        '
        'CheckBox48
        '
        Me.CheckBox48.AutoSize = True
        Me.CheckBox48.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox48.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox48.Location = New System.Drawing.Point(226, 187)
        Me.CheckBox48.Name = "CheckBox48"
        Me.CheckBox48.PLCAddressCheckChanged = "Program:ACT_BOARD_CENTERED_CONFIRMATION.dSimulLS.3"
        Me.CheckBox48.PLCAddressChecked = "Program:ACT_BOARD_CENTERED_CONFIRMATION.dSimulLS.3"
        Me.CheckBox48.PLCAddressText = ""
        Me.CheckBox48.PLCAddressVisible = ""
        Me.CheckBox48.Size = New System.Drawing.Size(70, 21)
        Me.CheckBox48.TabIndex = 47
        Me.CheckBox48.Text = "LS 10'"
        Me.CheckBox48.UseVisualStyleBackColor = True
        '
        'CheckBox49
        '
        Me.CheckBox49.AutoSize = True
        Me.CheckBox49.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox49.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox49.Location = New System.Drawing.Point(226, 163)
        Me.CheckBox49.Name = "CheckBox49"
        Me.CheckBox49.PLCAddressCheckChanged = "Program:ACT_BOARD_CENTERED_CONFIRMATION.dSimulLS.2"
        Me.CheckBox49.PLCAddressChecked = "Program:ACT_BOARD_CENTERED_CONFIRMATION.dSimulLS.2"
        Me.CheckBox49.PLCAddressText = ""
        Me.CheckBox49.PLCAddressVisible = ""
        Me.CheckBox49.Size = New System.Drawing.Size(62, 21)
        Me.CheckBox49.TabIndex = 46
        Me.CheckBox49.Text = "LS 8'"
        Me.CheckBox49.UseVisualStyleBackColor = True
        '
        'CheckBox50
        '
        Me.CheckBox50.AutoSize = True
        Me.CheckBox50.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox50.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox50.Location = New System.Drawing.Point(226, 139)
        Me.CheckBox50.Name = "CheckBox50"
        Me.CheckBox50.PLCAddressCheckChanged = "Program:ACT_BOARD_CENTERED_CONFIRMATION.dSimulLS.1"
        Me.CheckBox50.PLCAddressChecked = "Program:ACT_BOARD_CENTERED_CONFIRMATION.dSimulLS.1"
        Me.CheckBox50.PLCAddressText = ""
        Me.CheckBox50.PLCAddressVisible = ""
        Me.CheckBox50.Size = New System.Drawing.Size(62, 21)
        Me.CheckBox50.TabIndex = 45
        Me.CheckBox50.Text = "LS 6'"
        Me.CheckBox50.UseVisualStyleBackColor = True
        '
        'CheckBox51
        '
        Me.CheckBox51.AutoSize = True
        Me.CheckBox51.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox51.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox51.Location = New System.Drawing.Point(226, 115)
        Me.CheckBox51.Name = "CheckBox51"
        Me.CheckBox51.PLCAddressCheckChanged = "Program:ACT_BOARD_CENTERED_CONFIRMATION.dSimulLS.0"
        Me.CheckBox51.PLCAddressChecked = "Program:ACT_BOARD_CENTERED_CONFIRMATION.dSimulLS.0"
        Me.CheckBox51.PLCAddressText = ""
        Me.CheckBox51.PLCAddressVisible = ""
        Me.CheckBox51.Size = New System.Drawing.Size(62, 21)
        Me.CheckBox51.TabIndex = 44
        Me.CheckBox51.Text = "LS 0'"
        Me.CheckBox51.UseVisualStyleBackColor = True
        '
        'PositionConfLugIdx
        '
        Me.PositionConfLugIdx.AutoSize = True
        Me.PositionConfLugIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PositionConfLugIdx.Location = New System.Drawing.Point(230, 85)
        Me.PositionConfLugIdx.Name = "PositionConfLugIdx"
        Me.PositionConfLugIdx.Size = New System.Drawing.Size(128, 17)
        Me.PositionConfLugIdx.TabIndex = 32
        Me.PositionConfLugIdx.Text = "PositionConfLugIdx"
        '
        'PositionSkidLugIdx
        '
        Me.PositionSkidLugIdx.AutoSize = True
        Me.PositionSkidLugIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PositionSkidLugIdx.Location = New System.Drawing.Point(28, 85)
        Me.PositionSkidLugIdx.Name = "PositionSkidLugIdx"
        Me.PositionSkidLugIdx.Size = New System.Drawing.Size(126, 17)
        Me.PositionSkidLugIdx.TabIndex = 0
        Me.PositionSkidLugIdx.Text = "PositionSkidLugIdx"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.BasicButton1)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton46)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton45)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton44)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton43)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton42)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton41)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton40)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton39)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton38)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton37)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton36)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton35)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton34)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton33)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton32)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton31)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton30)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton29)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton28)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton27)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton26)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton25)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton24)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton23)
        Me.GroupBox7.Controls.Add(Me.SquareIlluminatedButton22)
        Me.GroupBox7.Controls.Add(Me.SimulPresSorterButton)
        Me.GroupBox7.Controls.Add(Me.HistoryLugIdx)
        Me.GroupBox7.Controls.Add(Me.PresSorterLugIdx)
        Me.GroupBox7.Location = New System.Drawing.Point(910, 524)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(424, 444)
        Me.GroupBox7.TabIndex = 49
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "GroupBox7"
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.Color.LightGray
        Me.BasicButton1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAlternate = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(230, 15)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BasicButton1.PLCAddressClick = "Program:ACT_LOST_PIECE.bSimul"
        Me.BasicButton1.PLCAddressHighlightX = "Program:ACT_LOST_PIECE.bSimul"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(167, 60)
        Me.BasicButton1.TabIndex = 96
        Me.BasicButton1.Text = "Simul Lost Piece"
        Me.BasicButton1.TextAlternate = Nothing
        Me.BasicButton1.UseVisualStyleBackColor = True
        Me.BasicButton1.ValueToWrite = 1
        '
        'SquareIlluminatedButton46
        '
        Me.SquareIlluminatedButton46.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton46.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton46.Location = New System.Drawing.Point(322, 397)
        Me.SquareIlluminatedButton46.Name = "SquareIlluminatedButton46"
        Me.SquareIlluminatedButton46.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton46.PLCAddressClick = ""
        Me.SquareIlluminatedButton46.PLCAddressText = ""
        Me.SquareIlluminatedButton46.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker025"
        Me.SquareIlluminatedButton46.PLCAddressVisible = ""
        Me.SquareIlluminatedButton46.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton46.TabIndex = 95
        Me.SquareIlluminatedButton46.Text = "Bin 25"
        Me.SquareIlluminatedButton46.Value = False
        '
        'SquareIlluminatedButton45
        '
        Me.SquareIlluminatedButton45.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton45.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton45.Location = New System.Drawing.Point(322, 368)
        Me.SquareIlluminatedButton45.Name = "SquareIlluminatedButton45"
        Me.SquareIlluminatedButton45.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton45.PLCAddressClick = ""
        Me.SquareIlluminatedButton45.PLCAddressText = ""
        Me.SquareIlluminatedButton45.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker024"
        Me.SquareIlluminatedButton45.PLCAddressVisible = ""
        Me.SquareIlluminatedButton45.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton45.TabIndex = 94
        Me.SquareIlluminatedButton45.Text = "Bin 24"
        Me.SquareIlluminatedButton45.Value = False
        '
        'SquareIlluminatedButton44
        '
        Me.SquareIlluminatedButton44.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton44.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton44.Location = New System.Drawing.Point(322, 343)
        Me.SquareIlluminatedButton44.Name = "SquareIlluminatedButton44"
        Me.SquareIlluminatedButton44.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton44.PLCAddressClick = ""
        Me.SquareIlluminatedButton44.PLCAddressText = ""
        Me.SquareIlluminatedButton44.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker023"
        Me.SquareIlluminatedButton44.PLCAddressVisible = ""
        Me.SquareIlluminatedButton44.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton44.TabIndex = 93
        Me.SquareIlluminatedButton44.Text = "Bin 23"
        Me.SquareIlluminatedButton44.Value = False
        '
        'SquareIlluminatedButton43
        '
        Me.SquareIlluminatedButton43.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton43.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton43.Location = New System.Drawing.Point(322, 317)
        Me.SquareIlluminatedButton43.Name = "SquareIlluminatedButton43"
        Me.SquareIlluminatedButton43.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton43.PLCAddressClick = ""
        Me.SquareIlluminatedButton43.PLCAddressText = ""
        Me.SquareIlluminatedButton43.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker022"
        Me.SquareIlluminatedButton43.PLCAddressVisible = ""
        Me.SquareIlluminatedButton43.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton43.TabIndex = 92
        Me.SquareIlluminatedButton43.Text = "Bin 22"
        Me.SquareIlluminatedButton43.Value = False
        '
        'SquareIlluminatedButton42
        '
        Me.SquareIlluminatedButton42.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton42.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton42.Location = New System.Drawing.Point(322, 293)
        Me.SquareIlluminatedButton42.Name = "SquareIlluminatedButton42"
        Me.SquareIlluminatedButton42.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton42.PLCAddressClick = ""
        Me.SquareIlluminatedButton42.PLCAddressText = ""
        Me.SquareIlluminatedButton42.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker021"
        Me.SquareIlluminatedButton42.PLCAddressVisible = ""
        Me.SquareIlluminatedButton42.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton42.TabIndex = 91
        Me.SquareIlluminatedButton42.Text = "Bin 21"
        Me.SquareIlluminatedButton42.Value = False
        '
        'SquareIlluminatedButton41
        '
        Me.SquareIlluminatedButton41.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton41.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton41.Location = New System.Drawing.Point(322, 271)
        Me.SquareIlluminatedButton41.Name = "SquareIlluminatedButton41"
        Me.SquareIlluminatedButton41.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton41.PLCAddressClick = ""
        Me.SquareIlluminatedButton41.PLCAddressText = ""
        Me.SquareIlluminatedButton41.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker020"
        Me.SquareIlluminatedButton41.PLCAddressVisible = ""
        Me.SquareIlluminatedButton41.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton41.TabIndex = 90
        Me.SquareIlluminatedButton41.Text = "Bin 20"
        Me.SquareIlluminatedButton41.Value = False
        '
        'SquareIlluminatedButton40
        '
        Me.SquareIlluminatedButton40.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton40.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton40.Location = New System.Drawing.Point(322, 247)
        Me.SquareIlluminatedButton40.Name = "SquareIlluminatedButton40"
        Me.SquareIlluminatedButton40.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton40.PLCAddressClick = ""
        Me.SquareIlluminatedButton40.PLCAddressText = ""
        Me.SquareIlluminatedButton40.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker019"
        Me.SquareIlluminatedButton40.PLCAddressVisible = ""
        Me.SquareIlluminatedButton40.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton40.TabIndex = 89
        Me.SquareIlluminatedButton40.Text = "Bin 19"
        Me.SquareIlluminatedButton40.Value = False
        '
        'SquareIlluminatedButton39
        '
        Me.SquareIlluminatedButton39.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton39.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton39.Location = New System.Drawing.Point(322, 219)
        Me.SquareIlluminatedButton39.Name = "SquareIlluminatedButton39"
        Me.SquareIlluminatedButton39.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton39.PLCAddressClick = ""
        Me.SquareIlluminatedButton39.PLCAddressText = ""
        Me.SquareIlluminatedButton39.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker018"
        Me.SquareIlluminatedButton39.PLCAddressVisible = ""
        Me.SquareIlluminatedButton39.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton39.TabIndex = 88
        Me.SquareIlluminatedButton39.Text = "Bin 18"
        Me.SquareIlluminatedButton39.Value = False
        '
        'SquareIlluminatedButton38
        '
        Me.SquareIlluminatedButton38.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton38.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton38.Location = New System.Drawing.Point(322, 192)
        Me.SquareIlluminatedButton38.Name = "SquareIlluminatedButton38"
        Me.SquareIlluminatedButton38.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton38.PLCAddressClick = ""
        Me.SquareIlluminatedButton38.PLCAddressText = ""
        Me.SquareIlluminatedButton38.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker017"
        Me.SquareIlluminatedButton38.PLCAddressVisible = ""
        Me.SquareIlluminatedButton38.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton38.TabIndex = 87
        Me.SquareIlluminatedButton38.Text = "Bin 17"
        Me.SquareIlluminatedButton38.Value = False
        '
        'SquareIlluminatedButton37
        '
        Me.SquareIlluminatedButton37.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton37.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton37.Location = New System.Drawing.Point(322, 166)
        Me.SquareIlluminatedButton37.Name = "SquareIlluminatedButton37"
        Me.SquareIlluminatedButton37.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton37.PLCAddressClick = ""
        Me.SquareIlluminatedButton37.PLCAddressText = ""
        Me.SquareIlluminatedButton37.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker016"
        Me.SquareIlluminatedButton37.PLCAddressVisible = ""
        Me.SquareIlluminatedButton37.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton37.TabIndex = 86
        Me.SquareIlluminatedButton37.Text = "Bin 16"
        Me.SquareIlluminatedButton37.Value = False
        '
        'SquareIlluminatedButton36
        '
        Me.SquareIlluminatedButton36.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton36.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton36.Location = New System.Drawing.Point(322, 139)
        Me.SquareIlluminatedButton36.Name = "SquareIlluminatedButton36"
        Me.SquareIlluminatedButton36.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton36.PLCAddressClick = ""
        Me.SquareIlluminatedButton36.PLCAddressText = ""
        Me.SquareIlluminatedButton36.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker015"
        Me.SquareIlluminatedButton36.PLCAddressVisible = ""
        Me.SquareIlluminatedButton36.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton36.TabIndex = 85
        Me.SquareIlluminatedButton36.Text = "Bin 15"
        Me.SquareIlluminatedButton36.Value = False
        '
        'SquareIlluminatedButton35
        '
        Me.SquareIlluminatedButton35.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton35.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton35.Location = New System.Drawing.Point(322, 113)
        Me.SquareIlluminatedButton35.Name = "SquareIlluminatedButton35"
        Me.SquareIlluminatedButton35.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton35.PLCAddressClick = ""
        Me.SquareIlluminatedButton35.PLCAddressText = ""
        Me.SquareIlluminatedButton35.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker014"
        Me.SquareIlluminatedButton35.PLCAddressVisible = ""
        Me.SquareIlluminatedButton35.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton35.TabIndex = 84
        Me.SquareIlluminatedButton35.Text = "Bin 14"
        Me.SquareIlluminatedButton35.Value = False
        '
        'SquareIlluminatedButton34
        '
        Me.SquareIlluminatedButton34.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton34.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton34.Location = New System.Drawing.Point(233, 399)
        Me.SquareIlluminatedButton34.Name = "SquareIlluminatedButton34"
        Me.SquareIlluminatedButton34.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton34.PLCAddressClick = ""
        Me.SquareIlluminatedButton34.PLCAddressText = ""
        Me.SquareIlluminatedButton34.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker013"
        Me.SquareIlluminatedButton34.PLCAddressVisible = ""
        Me.SquareIlluminatedButton34.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton34.TabIndex = 83
        Me.SquareIlluminatedButton34.Text = "Bin 13"
        Me.SquareIlluminatedButton34.Value = False
        '
        'SquareIlluminatedButton33
        '
        Me.SquareIlluminatedButton33.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton33.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton33.Location = New System.Drawing.Point(233, 374)
        Me.SquareIlluminatedButton33.Name = "SquareIlluminatedButton33"
        Me.SquareIlluminatedButton33.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton33.PLCAddressClick = ""
        Me.SquareIlluminatedButton33.PLCAddressText = ""
        Me.SquareIlluminatedButton33.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker012"
        Me.SquareIlluminatedButton33.PLCAddressVisible = ""
        Me.SquareIlluminatedButton33.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton33.TabIndex = 82
        Me.SquareIlluminatedButton33.Text = "Bin 12"
        Me.SquareIlluminatedButton33.Value = False
        '
        'SquareIlluminatedButton32
        '
        Me.SquareIlluminatedButton32.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton32.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton32.Location = New System.Drawing.Point(233, 349)
        Me.SquareIlluminatedButton32.Name = "SquareIlluminatedButton32"
        Me.SquareIlluminatedButton32.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton32.PLCAddressClick = ""
        Me.SquareIlluminatedButton32.PLCAddressText = ""
        Me.SquareIlluminatedButton32.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker011"
        Me.SquareIlluminatedButton32.PLCAddressVisible = ""
        Me.SquareIlluminatedButton32.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton32.TabIndex = 81
        Me.SquareIlluminatedButton32.Text = "Bin 11"
        Me.SquareIlluminatedButton32.Value = False
        '
        'SquareIlluminatedButton31
        '
        Me.SquareIlluminatedButton31.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton31.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton31.Location = New System.Drawing.Point(233, 325)
        Me.SquareIlluminatedButton31.Name = "SquareIlluminatedButton31"
        Me.SquareIlluminatedButton31.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton31.PLCAddressClick = ""
        Me.SquareIlluminatedButton31.PLCAddressText = ""
        Me.SquareIlluminatedButton31.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker010"
        Me.SquareIlluminatedButton31.PLCAddressVisible = ""
        Me.SquareIlluminatedButton31.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton31.TabIndex = 80
        Me.SquareIlluminatedButton31.Text = "Bin 10"
        Me.SquareIlluminatedButton31.Value = False
        '
        'SquareIlluminatedButton30
        '
        Me.SquareIlluminatedButton30.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton30.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton30.Location = New System.Drawing.Point(233, 301)
        Me.SquareIlluminatedButton30.Name = "SquareIlluminatedButton30"
        Me.SquareIlluminatedButton30.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton30.PLCAddressClick = ""
        Me.SquareIlluminatedButton30.PLCAddressText = ""
        Me.SquareIlluminatedButton30.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker009"
        Me.SquareIlluminatedButton30.PLCAddressVisible = ""
        Me.SquareIlluminatedButton30.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton30.TabIndex = 79
        Me.SquareIlluminatedButton30.Text = "Bin 9"
        Me.SquareIlluminatedButton30.Value = False
        '
        'SquareIlluminatedButton29
        '
        Me.SquareIlluminatedButton29.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton29.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton29.Location = New System.Drawing.Point(233, 279)
        Me.SquareIlluminatedButton29.Name = "SquareIlluminatedButton29"
        Me.SquareIlluminatedButton29.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton29.PLCAddressClick = ""
        Me.SquareIlluminatedButton29.PLCAddressText = ""
        Me.SquareIlluminatedButton29.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker008"
        Me.SquareIlluminatedButton29.PLCAddressVisible = ""
        Me.SquareIlluminatedButton29.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton29.TabIndex = 78
        Me.SquareIlluminatedButton29.Text = "Bin 8"
        Me.SquareIlluminatedButton29.Value = False
        '
        'SquareIlluminatedButton28
        '
        Me.SquareIlluminatedButton28.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton28.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton28.Location = New System.Drawing.Point(233, 255)
        Me.SquareIlluminatedButton28.Name = "SquareIlluminatedButton28"
        Me.SquareIlluminatedButton28.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton28.PLCAddressClick = ""
        Me.SquareIlluminatedButton28.PLCAddressText = ""
        Me.SquareIlluminatedButton28.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker007"
        Me.SquareIlluminatedButton28.PLCAddressVisible = ""
        Me.SquareIlluminatedButton28.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton28.TabIndex = 77
        Me.SquareIlluminatedButton28.Text = "Bin 7"
        Me.SquareIlluminatedButton28.Value = False
        '
        'SquareIlluminatedButton27
        '
        Me.SquareIlluminatedButton27.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton27.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton27.Location = New System.Drawing.Point(233, 231)
        Me.SquareIlluminatedButton27.Name = "SquareIlluminatedButton27"
        Me.SquareIlluminatedButton27.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton27.PLCAddressClick = ""
        Me.SquareIlluminatedButton27.PLCAddressText = ""
        Me.SquareIlluminatedButton27.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker006"
        Me.SquareIlluminatedButton27.PLCAddressVisible = ""
        Me.SquareIlluminatedButton27.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton27.TabIndex = 76
        Me.SquareIlluminatedButton27.Text = "Bin 6"
        Me.SquareIlluminatedButton27.Value = False
        '
        'SquareIlluminatedButton26
        '
        Me.SquareIlluminatedButton26.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton26.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton26.Location = New System.Drawing.Point(233, 207)
        Me.SquareIlluminatedButton26.Name = "SquareIlluminatedButton26"
        Me.SquareIlluminatedButton26.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton26.PLCAddressClick = ""
        Me.SquareIlluminatedButton26.PLCAddressText = ""
        Me.SquareIlluminatedButton26.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker005"
        Me.SquareIlluminatedButton26.PLCAddressVisible = ""
        Me.SquareIlluminatedButton26.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton26.TabIndex = 75
        Me.SquareIlluminatedButton26.Text = "Bin 5"
        Me.SquareIlluminatedButton26.Value = False
        '
        'SquareIlluminatedButton25
        '
        Me.SquareIlluminatedButton25.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton25.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton25.Location = New System.Drawing.Point(233, 183)
        Me.SquareIlluminatedButton25.Name = "SquareIlluminatedButton25"
        Me.SquareIlluminatedButton25.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton25.PLCAddressClick = ""
        Me.SquareIlluminatedButton25.PLCAddressText = ""
        Me.SquareIlluminatedButton25.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker004"
        Me.SquareIlluminatedButton25.PLCAddressVisible = ""
        Me.SquareIlluminatedButton25.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton25.TabIndex = 74
        Me.SquareIlluminatedButton25.Text = "Bin 4"
        Me.SquareIlluminatedButton25.Value = False
        '
        'SquareIlluminatedButton24
        '
        Me.SquareIlluminatedButton24.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton24.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton24.Location = New System.Drawing.Point(233, 159)
        Me.SquareIlluminatedButton24.Name = "SquareIlluminatedButton24"
        Me.SquareIlluminatedButton24.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton24.PLCAddressClick = ""
        Me.SquareIlluminatedButton24.PLCAddressText = ""
        Me.SquareIlluminatedButton24.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker003"
        Me.SquareIlluminatedButton24.PLCAddressVisible = ""
        Me.SquareIlluminatedButton24.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton24.TabIndex = 73
        Me.SquareIlluminatedButton24.Text = "Bin 3"
        Me.SquareIlluminatedButton24.Value = False
        '
        'SquareIlluminatedButton23
        '
        Me.SquareIlluminatedButton23.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton23.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton23.Location = New System.Drawing.Point(233, 135)
        Me.SquareIlluminatedButton23.Name = "SquareIlluminatedButton23"
        Me.SquareIlluminatedButton23.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton23.PLCAddressClick = ""
        Me.SquareIlluminatedButton23.PLCAddressText = ""
        Me.SquareIlluminatedButton23.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker002"
        Me.SquareIlluminatedButton23.PLCAddressVisible = ""
        Me.SquareIlluminatedButton23.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton23.TabIndex = 72
        Me.SquareIlluminatedButton23.Text = "Bin 2"
        Me.SquareIlluminatedButton23.Value = False
        '
        'SquareIlluminatedButton22
        '
        Me.SquareIlluminatedButton22.ComComponent = Me.EthernetIPforCLXCom1
        Me.SquareIlluminatedButton22.LightColor = MfgControl.AdvancedHMI.Controls.SquareIlluminatedButton.LightColorOption.Green
        Me.SquareIlluminatedButton22.Location = New System.Drawing.Point(233, 110)
        Me.SquareIlluminatedButton22.Name = "SquareIlluminatedButton22"
        Me.SquareIlluminatedButton22.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SquareIlluminatedButton22.PLCAddressClick = ""
        Me.SquareIlluminatedButton22.PLCAddressText = ""
        Me.SquareIlluminatedButton22.PLCAddressValue = "Program:ACT_KICKERS._OUT_Kicker001"
        Me.SquareIlluminatedButton22.PLCAddressVisible = ""
        Me.SquareIlluminatedButton22.Size = New System.Drawing.Size(75, 23)
        Me.SquareIlluminatedButton22.TabIndex = 71
        Me.SquareIlluminatedButton22.Text = "Bin 1"
        Me.SquareIlluminatedButton22.Value = False
        '
        'SimulPresSorterButton
        '
        Me.SimulPresSorterButton.BackColor = System.Drawing.Color.LightGray
        Me.SimulPresSorterButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.SimulPresSorterButton.ForeColor = System.Drawing.Color.Black
        Me.SimulPresSorterButton.ForeColorAlternate = System.Drawing.Color.Black
        Me.SimulPresSorterButton.Highlight = False
        Me.SimulPresSorterButton.HighlightColor = System.Drawing.Color.Green
        Me.SimulPresSorterButton.Location = New System.Drawing.Point(30, 15)
        Me.SimulPresSorterButton.MaximumHoldTime = 3000
        Me.SimulPresSorterButton.MinimumHoldTime = 500
        Me.SimulPresSorterButton.Name = "SimulPresSorterButton"
        Me.SimulPresSorterButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.SimulPresSorterButton.PLCAddressClick = "Program:ACT_PRES_SORTER.bSimul"
        Me.SimulPresSorterButton.PLCAddressHighlightX = "Program:ACT_PRES_SORTER.bSimul"
        Me.SimulPresSorterButton.SelectTextAlternate = False
        Me.SimulPresSorterButton.Size = New System.Drawing.Size(167, 60)
        Me.SimulPresSorterButton.TabIndex = 47
        Me.SimulPresSorterButton.Text = "Simul Presence Sorter"
        Me.SimulPresSorterButton.TextAlternate = Nothing
        Me.SimulPresSorterButton.UseVisualStyleBackColor = True
        Me.SimulPresSorterButton.ValueToWrite = 1
        '
        'HistoryLugIdx
        '
        Me.HistoryLugIdx.AutoSize = True
        Me.HistoryLugIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.HistoryLugIdx.Location = New System.Drawing.Point(230, 85)
        Me.HistoryLugIdx.Name = "HistoryLugIdx"
        Me.HistoryLugIdx.Size = New System.Drawing.Size(93, 17)
        Me.HistoryLugIdx.TabIndex = 32
        Me.HistoryLugIdx.Text = "HistoryLugIdx"
        '
        'PresSorterLugIdx
        '
        Me.PresSorterLugIdx.AutoSize = True
        Me.PresSorterLugIdx.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PresSorterLugIdx.Location = New System.Drawing.Point(28, 85)
        Me.PresSorterLugIdx.Name = "PresSorterLugIdx"
        Me.PresSorterLugIdx.Size = New System.Drawing.Size(117, 17)
        Me.PresSorterLugIdx.TabIndex = 0
        Me.PresSorterLugIdx.Text = "PresSorterLugIdx"
        '
        'ReadInputValuesButton
        '
        Me.ReadInputValuesButton.BackColor = System.Drawing.Color.LightGray
        Me.ReadInputValuesButton.ComComponent = Me.EthernetIPforCLXCom1
        Me.ReadInputValuesButton.ForeColor = System.Drawing.Color.Black
        Me.ReadInputValuesButton.ForeColorAlternate = System.Drawing.Color.Black
        Me.ReadInputValuesButton.Highlight = False
        Me.ReadInputValuesButton.HighlightColor = System.Drawing.Color.Green
        Me.ReadInputValuesButton.Location = New System.Drawing.Point(183, 12)
        Me.ReadInputValuesButton.MaximumHoldTime = 3000
        Me.ReadInputValuesButton.MinimumHoldTime = 500
        Me.ReadInputValuesButton.Name = "ReadInputValuesButton"
        Me.ReadInputValuesButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.ReadInputValuesButton.PLCAddressClick = ""
        Me.ReadInputValuesButton.SelectTextAlternate = False
        Me.ReadInputValuesButton.Size = New System.Drawing.Size(121, 44)
        Me.ReadInputValuesButton.TabIndex = 8
        Me.ReadInputValuesButton.Text = "Read Inputs"
        Me.ReadInputValuesButton.TextAlternate = Nothing
        Me.ReadInputValuesButton.UseVisualStyleBackColor = True
        Me.ReadInputValuesButton.ValueToWrite = 1
        '
        'Simulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1902, 995)
        Me.Controls.Add(Me.ReadInputValuesButton)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Simulation"
        Me.Text = "Simulation"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriber21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LineSpeedInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents DataSubscriber21 As AdvancedHMIControls.DataSubscriber2
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LineSpeedInput As NumericUpDown
    Friend WithEvents LineSpeedLabel As Label
    Friend WithEvents LugSlaveIdx As Label
    Friend WithEvents LugMasterIdx As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SimulEncoderButton As AdvancedHMIControls.BasicButton
    Friend WithEvents SimulLugLoader As AdvancedHMIControls.BasicButton
    Friend WithEvents SimulLoaderOnce As AdvancedHMIControls.BasicButton
    Friend WithEvents LugLoaderIdx As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SimulCypress As AdvancedHMIControls.BasicButton
    Friend WithEvents CypressLugIdx As Label
    Friend WithEvents NeTrimLabel As Label
    Friend WithEvents FeCitTrimLabel As Label
    Friend WithEvents NeCitTrimLabel As Label
    Friend WithEvents FeTrimLabel As Label
    Friend WithEvents FenceValInput As AdvancedHMIControls.KeyboardInput
    Friend WithEvents FenceValLabel As Label
    Friend WithEvents FeCitTrimInput As AdvancedHMIControls.KeyboardInput
    Friend WithEvents NeCitTrimInput As AdvancedHMIControls.KeyboardInput
    Friend WithEvents NeTrimInput As AdvancedHMIControls.KeyboardInput
    Friend WithEvents FeTrimInput As AdvancedHMIControls.KeyboardInput
    Friend WithEvents RemanCheckBox As AdvancedHMIControls.CheckBox
    Friend WithEvents SlashCheckBox As AdvancedHMIControls.CheckBox
    Friend WithEvents SpeciesInput As AdvancedHMIControls.KeyboardInput
    Friend WithEvents SpeciesLabel As Label
    Friend WithEvents FeDestInput As AdvancedHMIControls.KeyboardInput
    Friend WithEvents NeDestInput As AdvancedHMIControls.KeyboardInput
    Friend WithEvents NeGradeInput As AdvancedHMIControls.KeyboardInput
    Friend WithEvents FeGradeInout As AdvancedHMIControls.KeyboardInput
    Friend WithEvents FeDestLabel As Label
    Friend WithEvents NeDestLabel As Label
    Friend WithEvents FeGradeLabel As Label
    Friend WithEvents NeGradeLabel As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SimulReadWidth As AdvancedHMIControls.BasicButton
    Friend WithEvents CheckBox1 As AdvancedHMIControls.CheckBox
    Friend WithEvents Ls0Check As AdvancedHMIControls.CheckBox
    Friend WithEvents ReadWidthInput As AdvancedHMIControls.KeyboardInput
    Friend WithEvents ReadWidthLabel As Label
    Friend WithEvents SimulReadLen1 As AdvancedHMIControls.BasicButton
    Friend WithEvents ReadLen1Idx As Label
    Friend WithEvents ReadWidthIdx As Label
    Friend WithEvents CheckBox12 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox11 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox10 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox9 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox8 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox7 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox6 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox5 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox4 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox3 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox2 As AdvancedHMIControls.CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents FenceSkidLugIdx As Label
    Friend WithEvents FenceLugIdx As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CitSkidLugIdx As Label
    Friend WithEvents SawsLugIdx As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents BasicButton2 As AdvancedHMIControls.BasicButton
    Friend WithEvents PositionConfLugIdx As Label
    Friend WithEvents PositionSkidLugIdx As Label
    Friend WithEvents CheckBox48 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox49 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox50 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox51 As AdvancedHMIControls.CheckBox
    Friend WithEvents SimulReadLen2Button As AdvancedHMIControls.BasicButton
    Friend WithEvents CheckBox13 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox17 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox30 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox39 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox41 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox43 As AdvancedHMIControls.CheckBox
    Friend WithEvents CheckBox52 As AdvancedHMIControls.CheckBox
    Friend WithEvents ReadLen2LugIdx As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents SimulPresSorterButton As AdvancedHMIControls.BasicButton
    Friend WithEvents HistoryLugIdx As Label
    Friend WithEvents PresSorterLugIdx As Label
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
    Friend WithEvents SquareIlluminatedButton13 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton12 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton21 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton20 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton19 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton18 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton17 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton16 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton15 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton14 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton22 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton61 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton62 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton60 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton59 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton56 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton57 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton58 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton53 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton54 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton55 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton50 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton51 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton52 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton49 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton48 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton47 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton46 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton45 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton44 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton43 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton42 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton41 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton40 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton39 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton38 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton37 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton36 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton35 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton34 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton33 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton32 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton31 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton30 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton29 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton28 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton27 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton26 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton25 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton24 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton23 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents ReadInputValuesButton As AdvancedHMIControls.BasicButton
    Friend WithEvents AnalogValueDisplay1 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents FenceCheckLugIdx As Label
    Friend WithEvents LS10fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS9fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS8fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS7fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS6fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS3fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS0fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS16fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS15fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS14fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS13fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS12fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS11fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents LS0_2fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS6_2fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS8_2fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS10_2fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS12_2fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS14_2fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents LS16_2fbk As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents SquareIlluminatedButton63 As AdvancedHMIControls.SquareIlluminatedButton
    Friend WithEvents BasicLabel3 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel2 As AdvancedHMIControls.BasicLabel
End Class
