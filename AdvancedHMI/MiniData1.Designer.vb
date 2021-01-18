<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MiniData1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MiniData1))
        Me.Timer500 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1000 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2000 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer10000 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelNbRej = New System.Windows.Forms.Label()
        Me.LabelPiecesOut = New System.Windows.Forms.Label()
        Me.LabelPiecesIn = New System.Windows.Forms.Label()
        Me.LabelVolProj = New System.Windows.Forms.Label()
        Me.LabelSlashed = New System.Windows.Forms.Label()
        Me.LabelLugFill = New System.Windows.Forms.Label()
        Me.LabelVolumeHour = New System.Windows.Forms.Label()
        Me.LabelVolumePmp = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CommsOk = New System.Windows.Forms.PictureBox()
        Me.szSorterDisplay = New System.Windows.Forms.Label()
        Me.szProductionDisplay = New AdvancedHMIControls.BasicLabel()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.DataSubscriber21 = New AdvancedHMIControls.DataSubscriber2(Me.components)
        Me.DataSubscriber22 = New AdvancedHMIControls.DataSubscriber2(Me.components)
        Me.Timer100 = New System.Windows.Forms.Timer(Me.components)
        Me.Saw20ft = New System.Windows.Forms.Button()
        Me.Saw18ft = New System.Windows.Forms.Button()
        Me.Saw16ft = New System.Windows.Forms.Button()
        Me.Saw14ft = New System.Windows.Forms.Button()
        Me.Saw12ft = New System.Windows.Forms.Button()
        Me.Saw10ft = New System.Windows.Forms.Button()
        Me.Saw8ft = New System.Windows.Forms.Button()
        Me.Saw0ft = New System.Windows.Forms.Button()
        Me.Saw2ft = New System.Windows.Forms.Button()
        Me.Saw4ft = New System.Windows.Forms.Button()
        Me.Saw6ft = New System.Windows.Forms.Button()
        Me.Gate0 = New System.Windows.Forms.Button()
        Me.Gate1 = New System.Windows.Forms.Button()
        Me.Gate2 = New System.Windows.Forms.Button()
        Me.Gate3 = New System.Windows.Forms.Button()
        Me.Gate4 = New System.Windows.Forms.Button()
        Me.Gate5 = New System.Windows.Forms.Button()
        Me.Gate6 = New System.Windows.Forms.Button()
        Me.Gate7 = New System.Windows.Forms.Button()
        Me.Cit0 = New System.Windows.Forms.Button()
        Me.Cit1 = New System.Windows.Forms.Button()
        Me.Cit2 = New System.Windows.Forms.Button()
        Me.Cit3 = New System.Windows.Forms.Button()
        CType(Me.CommsOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriber21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriber22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1000
        '
        '
        'Timer10000
        '
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(69, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(169, 42)
        Me.Label5.TabIndex = 289
        Me.Label5.Text = "Sorter Speed"
        '
        'LabelNbRej
        '
        Me.LabelNbRej.AutoSize = True
        Me.LabelNbRej.BackColor = System.Drawing.Color.Transparent
        Me.LabelNbRej.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNbRej.ForeColor = System.Drawing.Color.White
        Me.LabelNbRej.Location = New System.Drawing.Point(1144, 62)
        Me.LabelNbRej.Name = "LabelNbRej"
        Me.LabelNbRej.Size = New System.Drawing.Size(137, 27)
        Me.LabelNbRej.TabIndex = 288
        Me.LabelNbRej.Text = "dNbRejects"
        '
        'LabelPiecesOut
        '
        Me.LabelPiecesOut.AutoSize = True
        Me.LabelPiecesOut.BackColor = System.Drawing.Color.Transparent
        Me.LabelPiecesOut.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPiecesOut.ForeColor = System.Drawing.Color.White
        Me.LabelPiecesOut.Location = New System.Drawing.Point(672, 106)
        Me.LabelPiecesOut.Name = "LabelPiecesOut"
        Me.LabelPiecesOut.Size = New System.Drawing.Size(168, 27)
        Me.LabelPiecesOut.TabIndex = 287
        Me.LabelPiecesOut.Text = "dNbPiecesOut"
        '
        'LabelPiecesIn
        '
        Me.LabelPiecesIn.AutoSize = True
        Me.LabelPiecesIn.BackColor = System.Drawing.Color.Transparent
        Me.LabelPiecesIn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPiecesIn.ForeColor = System.Drawing.Color.White
        Me.LabelPiecesIn.Location = New System.Drawing.Point(672, 62)
        Me.LabelPiecesIn.Name = "LabelPiecesIn"
        Me.LabelPiecesIn.Size = New System.Drawing.Size(148, 27)
        Me.LabelPiecesIn.TabIndex = 286
        Me.LabelPiecesIn.Text = "dNbPiecesIn"
        '
        'LabelVolProj
        '
        Me.LabelVolProj.AutoSize = True
        Me.LabelVolProj.BackColor = System.Drawing.Color.Transparent
        Me.LabelVolProj.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVolProj.ForeColor = System.Drawing.Color.White
        Me.LabelVolProj.Location = New System.Drawing.Point(244, 106)
        Me.LabelVolProj.Name = "LabelVolProj"
        Me.LabelVolProj.Size = New System.Drawing.Size(149, 27)
        Me.LabelVolProj.TabIndex = 284
        Me.LabelVolProj.Text = "dVolumeProj"
        '
        'LabelSlashed
        '
        Me.LabelSlashed.AutoSize = True
        Me.LabelSlashed.BackColor = System.Drawing.Color.Transparent
        Me.LabelSlashed.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSlashed.ForeColor = System.Drawing.Color.White
        Me.LabelSlashed.Location = New System.Drawing.Point(1144, 106)
        Me.LabelSlashed.Name = "LabelSlashed"
        Me.LabelSlashed.Size = New System.Drawing.Size(145, 27)
        Me.LabelSlashed.TabIndex = 283
        Me.LabelSlashed.Text = "dNbSlashed"
        '
        'LabelLugFill
        '
        Me.LabelLugFill.AutoSize = True
        Me.LabelLugFill.BackColor = System.Drawing.Color.Transparent
        Me.LabelLugFill.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLugFill.ForeColor = System.Drawing.Color.White
        Me.LabelLugFill.Location = New System.Drawing.Point(672, 24)
        Me.LabelLugFill.Name = "LabelLugFill"
        Me.LabelLugFill.Size = New System.Drawing.Size(148, 27)
        Me.LabelLugFill.TabIndex = 282
        Me.LabelLugFill.Text = "dLugFillPerc"
        '
        'LabelVolumeHour
        '
        Me.LabelVolumeHour.AutoSize = True
        Me.LabelVolumeHour.BackColor = System.Drawing.Color.Transparent
        Me.LabelVolumeHour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVolumeHour.ForeColor = System.Drawing.Color.White
        Me.LabelVolumeHour.Location = New System.Drawing.Point(1144, 24)
        Me.LabelVolumeHour.Name = "LabelVolumeHour"
        Me.LabelVolumeHour.Size = New System.Drawing.Size(171, 27)
        Me.LabelVolumeHour.TabIndex = 281
        Me.LabelVolumeHour.Text = "dVolumeHeure"
        '
        'LabelVolumePmp
        '
        Me.LabelVolumePmp.AutoSize = True
        Me.LabelVolumePmp.BackColor = System.Drawing.Color.Transparent
        Me.LabelVolumePmp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVolumePmp.ForeColor = System.Drawing.Color.White
        Me.LabelVolumePmp.Location = New System.Drawing.Point(244, 62)
        Me.LabelVolumePmp.Name = "LabelVolumePmp"
        Me.LabelVolumePmp.Size = New System.Drawing.Size(106, 27)
        Me.LabelVolumePmp.TabIndex = 280
        Me.LabelVolumePmp.Text = "dVolume"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LightGray
        Me.Label19.Location = New System.Drawing.Point(477, 47)
        Me.Label19.Name = "Label19"
        Me.Label19.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label19.Size = New System.Drawing.Size(189, 42)
        Me.Label19.TabIndex = 278
        Me.Label19.Text = "Pieces Rentres"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LightGray
        Me.Label18.Location = New System.Drawing.Point(487, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label18.Size = New System.Drawing.Size(179, 42)
        Me.Label18.TabIndex = 276
        Me.Label18.Text = "Pieces Sorties"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LightGray
        Me.Label17.Location = New System.Drawing.Point(952, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label17.Size = New System.Drawing.Size(186, 42)
        Me.Label17.TabIndex = 274
        Me.Label17.Text = "Pieces Rejetés"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightGray
        Me.Label16.Location = New System.Drawing.Point(911, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label16.Size = New System.Drawing.Size(227, 42)
        Me.Label16.TabIndex = 272
        Me.Label16.Text = "Pieces Deshiqueté"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightGray
        Me.Label15.Location = New System.Drawing.Point(417, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label15.Size = New System.Drawing.Size(249, 42)
        Me.Label15.TabIndex = 270
        Me.Label15.Text = "Taquets Remplis (%)"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(-4, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(242, 42)
        Me.Label3.TabIndex = 269
        Me.Label3.Text = "Volume projeté (BF)"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(866, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(272, 42)
        Me.Label2.TabIndex = 266
        Me.Label2.Text = "Volume par heure (BF)"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(77, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(161, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Volume (BF)"
        '
        'CommsOk
        '
        Me.CommsOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CommsOk.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.autolog_juste_logo
        Me.CommsOk.Location = New System.Drawing.Point(1297, 161)
        Me.CommsOk.Margin = New System.Windows.Forms.Padding(4)
        Me.CommsOk.Name = "CommsOk"
        Me.CommsOk.Size = New System.Drawing.Size(25, 26)
        Me.CommsOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CommsOk.TabIndex = 336
        Me.CommsOk.TabStop = False
        '
        'szSorterDisplay
        '
        Me.szSorterDisplay.AutoSize = True
        Me.szSorterDisplay.BackColor = System.Drawing.Color.Transparent
        Me.szSorterDisplay.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.szSorterDisplay.ForeColor = System.Drawing.Color.Coral
        Me.szSorterDisplay.Location = New System.Drawing.Point(23, 150)
        Me.szSorterDisplay.Name = "szSorterDisplay"
        Me.szSorterDisplay.Size = New System.Drawing.Size(180, 27)
        Me.szSorterDisplay.TabIndex = 337
        Me.szSorterDisplay.Text = "szSorterDisplay"
        '
        'szProductionDisplay
        '
        Me.szProductionDisplay.AllowDrop = True
        Me.szProductionDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.szProductionDisplay.AutoSize = True
        Me.szProductionDisplay.BackColor = System.Drawing.Color.Transparent
        Me.szProductionDisplay.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.szProductionDisplay.ComComponent = Me.EthernetIPforCLXCom1
        Me.szProductionDisplay.DisplayAsTime = False
        Me.szProductionDisplay.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.szProductionDisplay.ForeColor = System.Drawing.Color.White
        Me.szProductionDisplay.Highlight = False
        Me.szProductionDisplay.HighlightColor = System.Drawing.Color.Red
        Me.szProductionDisplay.HighlightForeColor = System.Drawing.Color.White
        Me.szProductionDisplay.HighlightKeyCharacter = "!"
        Me.szProductionDisplay.InterpretValueAsBCD = False
        Me.szProductionDisplay.KeypadAlphanumeric = False
        Me.szProductionDisplay.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.szProductionDisplay.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.szProductionDisplay.KeypadMaxValue = 0R
        Me.szProductionDisplay.KeypadMinValue = 0R
        Me.szProductionDisplay.KeypadScaleFactor = 1.0R
        Me.szProductionDisplay.KeypadShowCurrentValue = False
        Me.szProductionDisplay.KeypadText = Nothing
        Me.szProductionDisplay.KeypadWidth = 300
        Me.szProductionDisplay.Location = New System.Drawing.Point(244, 24)
        Me.szProductionDisplay.Name = "szProductionDisplay"
        Me.szProductionDisplay.NumericFormat = Nothing
        Me.szProductionDisplay.PLCAddressKeypad = ""
        Me.szProductionDisplay.PLCAddressValue = "g_ActLug.Master.Encoder.Data.dRPM"
        Me.szProductionDisplay.Size = New System.Drawing.Size(187, 27)
        Me.szProductionDisplay.TabIndex = 284
        Me.szProductionDisplay.Text = "Speed Lugs/Min"
        Me.szProductionDisplay.Value = "Speed"
        Me.szProductionDisplay.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.szProductionDisplay.ValueLeftPadLength = 0
        Me.szProductionDisplay.ValuePrefix = Nothing
        Me.szProductionDisplay.ValueScaleFactor = 1.0R
        Me.szProductionDisplay.ValueSuffix = " Lugs/Min"
        Me.szProductionDisplay.ValueToSubtractFrom = 0!
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "150.150.10.153"
        Me.EthernetIPforCLXCom1.PollRateOverride = 50
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'DataSubscriber21
        '
        Me.DataSubscriber21.ComComponent = Me.EthernetIPforCLXCom1
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_SAWS.dSaws", 1))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_SMART_GATES.dGates", 1))
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("Program:ACT_CIT_SKID.dCitSkids", 1))
        '
        'DataSubscriber22
        '
        Me.DataSubscriber22.ComComponent = Me.EthernetIPforCLXCom1
        Me.DataSubscriber22.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("g_dAcvConnected", 1))
        Me.DataSubscriber22.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("g_dAcvWatchDog", 1))
        Me.DataSubscriber22.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("g_dAcvNbAlarms", 1))
        Me.DataSubscriber22.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("g_szDisplayString", 1))
        Me.DataSubscriber22.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("g_szLTSDisplayDowntime", 1))
        '
        'Timer100
        '
        Me.Timer100.Interval = 20
        '
        'Saw20ft
        '
        Me.Saw20ft.BackColor = System.Drawing.Color.Gray
        Me.Saw20ft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Saw20ft.ForeColor = System.Drawing.Color.White
        Me.Saw20ft.Location = New System.Drawing.Point(858, 160)
        Me.Saw20ft.Margin = New System.Windows.Forms.Padding(0)
        Me.Saw20ft.Name = "Saw20ft"
        Me.Saw20ft.Size = New System.Drawing.Size(55, 30)
        Me.Saw20ft.TabIndex = 362
        Me.Saw20ft.Text = "20ft"
        Me.Saw20ft.UseVisualStyleBackColor = False
        '
        'Saw18ft
        '
        Me.Saw18ft.BackColor = System.Drawing.Color.Gray
        Me.Saw18ft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Saw18ft.ForeColor = System.Drawing.Color.White
        Me.Saw18ft.Location = New System.Drawing.Point(858, 187)
        Me.Saw18ft.Margin = New System.Windows.Forms.Padding(0)
        Me.Saw18ft.Name = "Saw18ft"
        Me.Saw18ft.Size = New System.Drawing.Size(55, 30)
        Me.Saw18ft.TabIndex = 363
        Me.Saw18ft.Text = "18ft"
        Me.Saw18ft.UseVisualStyleBackColor = False
        '
        'Saw16ft
        '
        Me.Saw16ft.BackColor = System.Drawing.Color.Gray
        Me.Saw16ft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Saw16ft.ForeColor = System.Drawing.Color.White
        Me.Saw16ft.Location = New System.Drawing.Point(858, 216)
        Me.Saw16ft.Margin = New System.Windows.Forms.Padding(0)
        Me.Saw16ft.Name = "Saw16ft"
        Me.Saw16ft.Size = New System.Drawing.Size(55, 30)
        Me.Saw16ft.TabIndex = 364
        Me.Saw16ft.Text = "16ft"
        Me.Saw16ft.UseVisualStyleBackColor = False
        '
        'Saw14ft
        '
        Me.Saw14ft.BackColor = System.Drawing.Color.Gray
        Me.Saw14ft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Saw14ft.ForeColor = System.Drawing.Color.White
        Me.Saw14ft.Location = New System.Drawing.Point(858, 245)
        Me.Saw14ft.Margin = New System.Windows.Forms.Padding(0)
        Me.Saw14ft.Name = "Saw14ft"
        Me.Saw14ft.Size = New System.Drawing.Size(55, 30)
        Me.Saw14ft.TabIndex = 365
        Me.Saw14ft.Text = "14ft"
        Me.Saw14ft.UseVisualStyleBackColor = False
        '
        'Saw12ft
        '
        Me.Saw12ft.BackColor = System.Drawing.Color.Gray
        Me.Saw12ft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Saw12ft.ForeColor = System.Drawing.Color.White
        Me.Saw12ft.Location = New System.Drawing.Point(858, 274)
        Me.Saw12ft.Margin = New System.Windows.Forms.Padding(0)
        Me.Saw12ft.Name = "Saw12ft"
        Me.Saw12ft.Size = New System.Drawing.Size(55, 30)
        Me.Saw12ft.TabIndex = 366
        Me.Saw12ft.Text = "12ft"
        Me.Saw12ft.UseVisualStyleBackColor = False
        '
        'Saw10ft
        '
        Me.Saw10ft.BackColor = System.Drawing.Color.Gray
        Me.Saw10ft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Saw10ft.ForeColor = System.Drawing.Color.White
        Me.Saw10ft.Location = New System.Drawing.Point(858, 303)
        Me.Saw10ft.Margin = New System.Windows.Forms.Padding(0)
        Me.Saw10ft.Name = "Saw10ft"
        Me.Saw10ft.Size = New System.Drawing.Size(55, 30)
        Me.Saw10ft.TabIndex = 367
        Me.Saw10ft.Text = "10ft"
        Me.Saw10ft.UseVisualStyleBackColor = False
        '
        'Saw8ft
        '
        Me.Saw8ft.BackColor = System.Drawing.Color.Gray
        Me.Saw8ft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Saw8ft.ForeColor = System.Drawing.Color.White
        Me.Saw8ft.Location = New System.Drawing.Point(858, 332)
        Me.Saw8ft.Margin = New System.Windows.Forms.Padding(0)
        Me.Saw8ft.Name = "Saw8ft"
        Me.Saw8ft.Size = New System.Drawing.Size(55, 30)
        Me.Saw8ft.TabIndex = 368
        Me.Saw8ft.Text = "8ft"
        Me.Saw8ft.UseVisualStyleBackColor = False
        '
        'Saw0ft
        '
        Me.Saw0ft.BackColor = System.Drawing.Color.Gray
        Me.Saw0ft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Saw0ft.ForeColor = System.Drawing.Color.White
        Me.Saw0ft.Location = New System.Drawing.Point(858, 446)
        Me.Saw0ft.Margin = New System.Windows.Forms.Padding(0)
        Me.Saw0ft.Name = "Saw0ft"
        Me.Saw0ft.Size = New System.Drawing.Size(55, 30)
        Me.Saw0ft.TabIndex = 372
        Me.Saw0ft.Text = "0ft"
        Me.Saw0ft.UseVisualStyleBackColor = False
        '
        'Saw2ft
        '
        Me.Saw2ft.BackColor = System.Drawing.Color.Gray
        Me.Saw2ft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Saw2ft.ForeColor = System.Drawing.Color.White
        Me.Saw2ft.Location = New System.Drawing.Point(858, 417)
        Me.Saw2ft.Margin = New System.Windows.Forms.Padding(0)
        Me.Saw2ft.Name = "Saw2ft"
        Me.Saw2ft.Size = New System.Drawing.Size(55, 30)
        Me.Saw2ft.TabIndex = 371
        Me.Saw2ft.Text = "2ft"
        Me.Saw2ft.UseVisualStyleBackColor = False
        '
        'Saw4ft
        '
        Me.Saw4ft.BackColor = System.Drawing.Color.Gray
        Me.Saw4ft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Saw4ft.ForeColor = System.Drawing.Color.White
        Me.Saw4ft.Location = New System.Drawing.Point(858, 388)
        Me.Saw4ft.Margin = New System.Windows.Forms.Padding(0)
        Me.Saw4ft.Name = "Saw4ft"
        Me.Saw4ft.Size = New System.Drawing.Size(55, 30)
        Me.Saw4ft.TabIndex = 370
        Me.Saw4ft.Text = "4ft"
        Me.Saw4ft.UseVisualStyleBackColor = False
        '
        'Saw6ft
        '
        Me.Saw6ft.BackColor = System.Drawing.Color.Gray
        Me.Saw6ft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Saw6ft.ForeColor = System.Drawing.Color.White
        Me.Saw6ft.Location = New System.Drawing.Point(858, 361)
        Me.Saw6ft.Margin = New System.Windows.Forms.Padding(0)
        Me.Saw6ft.Name = "Saw6ft"
        Me.Saw6ft.Size = New System.Drawing.Size(55, 30)
        Me.Saw6ft.TabIndex = 369
        Me.Saw6ft.Text = "6ft"
        Me.Saw6ft.UseVisualStyleBackColor = False
        '
        'Gate0
        '
        Me.Gate0.BackColor = System.Drawing.Color.Gray
        Me.Gate0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Gate0.ForeColor = System.Drawing.Color.White
        Me.Gate0.Location = New System.Drawing.Point(795, 432)
        Me.Gate0.Margin = New System.Windows.Forms.Padding(0)
        Me.Gate0.Name = "Gate0"
        Me.Gate0.Size = New System.Drawing.Size(55, 30)
        Me.Gate0.TabIndex = 380
        Me.Gate0.Text = "G0"
        Me.Gate0.UseVisualStyleBackColor = False
        '
        'Gate1
        '
        Me.Gate1.BackColor = System.Drawing.Color.Gray
        Me.Gate1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Gate1.ForeColor = System.Drawing.Color.White
        Me.Gate1.Location = New System.Drawing.Point(795, 403)
        Me.Gate1.Margin = New System.Windows.Forms.Padding(0)
        Me.Gate1.Name = "Gate1"
        Me.Gate1.Size = New System.Drawing.Size(55, 30)
        Me.Gate1.TabIndex = 379
        Me.Gate1.Text = "G1"
        Me.Gate1.UseVisualStyleBackColor = False
        '
        'Gate2
        '
        Me.Gate2.BackColor = System.Drawing.Color.Gray
        Me.Gate2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Gate2.ForeColor = System.Drawing.Color.White
        Me.Gate2.Location = New System.Drawing.Point(795, 374)
        Me.Gate2.Margin = New System.Windows.Forms.Padding(0)
        Me.Gate2.Name = "Gate2"
        Me.Gate2.Size = New System.Drawing.Size(55, 30)
        Me.Gate2.TabIndex = 378
        Me.Gate2.Text = "G2"
        Me.Gate2.UseVisualStyleBackColor = False
        '
        'Gate3
        '
        Me.Gate3.BackColor = System.Drawing.Color.Gray
        Me.Gate3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Gate3.ForeColor = System.Drawing.Color.White
        Me.Gate3.Location = New System.Drawing.Point(795, 347)
        Me.Gate3.Margin = New System.Windows.Forms.Padding(0)
        Me.Gate3.Name = "Gate3"
        Me.Gate3.Size = New System.Drawing.Size(55, 30)
        Me.Gate3.TabIndex = 377
        Me.Gate3.Text = "G3"
        Me.Gate3.UseVisualStyleBackColor = False
        '
        'Gate4
        '
        Me.Gate4.BackColor = System.Drawing.Color.Gray
        Me.Gate4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Gate4.ForeColor = System.Drawing.Color.White
        Me.Gate4.Location = New System.Drawing.Point(795, 318)
        Me.Gate4.Margin = New System.Windows.Forms.Padding(0)
        Me.Gate4.Name = "Gate4"
        Me.Gate4.Size = New System.Drawing.Size(55, 30)
        Me.Gate4.TabIndex = 376
        Me.Gate4.Text = "G4"
        Me.Gate4.UseVisualStyleBackColor = False
        '
        'Gate5
        '
        Me.Gate5.BackColor = System.Drawing.Color.Gray
        Me.Gate5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Gate5.ForeColor = System.Drawing.Color.White
        Me.Gate5.Location = New System.Drawing.Point(795, 289)
        Me.Gate5.Margin = New System.Windows.Forms.Padding(0)
        Me.Gate5.Name = "Gate5"
        Me.Gate5.Size = New System.Drawing.Size(55, 30)
        Me.Gate5.TabIndex = 375
        Me.Gate5.Text = "G5"
        Me.Gate5.UseVisualStyleBackColor = False
        '
        'Gate6
        '
        Me.Gate6.BackColor = System.Drawing.Color.Gray
        Me.Gate6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Gate6.ForeColor = System.Drawing.Color.White
        Me.Gate6.Location = New System.Drawing.Point(795, 260)
        Me.Gate6.Margin = New System.Windows.Forms.Padding(0)
        Me.Gate6.Name = "Gate6"
        Me.Gate6.Size = New System.Drawing.Size(55, 30)
        Me.Gate6.TabIndex = 374
        Me.Gate6.Text = "G6"
        Me.Gate6.UseVisualStyleBackColor = False
        '
        'Gate7
        '
        Me.Gate7.BackColor = System.Drawing.Color.Gray
        Me.Gate7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Gate7.ForeColor = System.Drawing.Color.White
        Me.Gate7.Location = New System.Drawing.Point(795, 231)
        Me.Gate7.Margin = New System.Windows.Forms.Padding(0)
        Me.Gate7.Name = "Gate7"
        Me.Gate7.Size = New System.Drawing.Size(55, 30)
        Me.Gate7.TabIndex = 373
        Me.Gate7.Text = "G7"
        Me.Gate7.UseVisualStyleBackColor = False
        '
        'Cit0
        '
        Me.Cit0.BackColor = System.Drawing.Color.Gray
        Me.Cit0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cit0.ForeColor = System.Drawing.Color.White
        Me.Cit0.Location = New System.Drawing.Point(732, 432)
        Me.Cit0.Margin = New System.Windows.Forms.Padding(0)
        Me.Cit0.Name = "Cit0"
        Me.Cit0.Size = New System.Drawing.Size(55, 30)
        Me.Cit0.TabIndex = 384
        Me.Cit0.Text = "CIT0"
        Me.Cit0.UseVisualStyleBackColor = False
        '
        'Cit1
        '
        Me.Cit1.BackColor = System.Drawing.Color.Gray
        Me.Cit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cit1.ForeColor = System.Drawing.Color.White
        Me.Cit1.Location = New System.Drawing.Point(732, 403)
        Me.Cit1.Margin = New System.Windows.Forms.Padding(0)
        Me.Cit1.Name = "Cit1"
        Me.Cit1.Size = New System.Drawing.Size(55, 30)
        Me.Cit1.TabIndex = 383
        Me.Cit1.Text = "CIT1"
        Me.Cit1.UseVisualStyleBackColor = False
        '
        'Cit2
        '
        Me.Cit2.BackColor = System.Drawing.Color.Gray
        Me.Cit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cit2.ForeColor = System.Drawing.Color.White
        Me.Cit2.Location = New System.Drawing.Point(732, 374)
        Me.Cit2.Margin = New System.Windows.Forms.Padding(0)
        Me.Cit2.Name = "Cit2"
        Me.Cit2.Size = New System.Drawing.Size(55, 30)
        Me.Cit2.TabIndex = 382
        Me.Cit2.Text = "CIT2"
        Me.Cit2.UseVisualStyleBackColor = False
        '
        'Cit3
        '
        Me.Cit3.BackColor = System.Drawing.Color.Gray
        Me.Cit3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cit3.ForeColor = System.Drawing.Color.White
        Me.Cit3.Location = New System.Drawing.Point(732, 347)
        Me.Cit3.Margin = New System.Windows.Forms.Padding(0)
        Me.Cit3.Name = "Cit3"
        Me.Cit3.Size = New System.Drawing.Size(55, 30)
        Me.Cit3.TabIndex = 381
        Me.Cit3.Text = "CIT3"
        Me.Cit3.UseVisualStyleBackColor = False
        '
        'MiniData1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(1354, 526)
        Me.Controls.Add(Me.Cit0)
        Me.Controls.Add(Me.Cit1)
        Me.Controls.Add(Me.Cit2)
        Me.Controls.Add(Me.Cit3)
        Me.Controls.Add(Me.Gate0)
        Me.Controls.Add(Me.Gate1)
        Me.Controls.Add(Me.Gate2)
        Me.Controls.Add(Me.Gate3)
        Me.Controls.Add(Me.Gate4)
        Me.Controls.Add(Me.Gate5)
        Me.Controls.Add(Me.Gate6)
        Me.Controls.Add(Me.Gate7)
        Me.Controls.Add(Me.Saw0ft)
        Me.Controls.Add(Me.Saw2ft)
        Me.Controls.Add(Me.Saw4ft)
        Me.Controls.Add(Me.Saw6ft)
        Me.Controls.Add(Me.Saw8ft)
        Me.Controls.Add(Me.Saw10ft)
        Me.Controls.Add(Me.Saw12ft)
        Me.Controls.Add(Me.Saw14ft)
        Me.Controls.Add(Me.Saw16ft)
        Me.Controls.Add(Me.Saw18ft)
        Me.Controls.Add(Me.Saw20ft)
        Me.Controls.Add(Me.szSorterDisplay)
        Me.Controls.Add(Me.CommsOk)
        Me.Controls.Add(Me.LabelVolumeHour)
        Me.Controls.Add(Me.LabelVolProj)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelPiecesOut)
        Me.Controls.Add(Me.LabelLugFill)
        Me.Controls.Add(Me.LabelVolumePmp)
        Me.Controls.Add(Me.LabelNbRej)
        Me.Controls.Add(Me.LabelPiecesIn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.szProductionDisplay)
        Me.Controls.Add(Me.LabelSlashed)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MiniData1"
        Me.Text = "AutologControlsView"
        CType(Me.CommsOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriber21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriber22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EthernetIPforCLXCom1 As EthernetIPforCLXCom
    Friend WithEvents DataSubscriber21 As DataSubscriber2
    Friend WithEvents DataSubscriber22 As DataSubscriber2
    Friend WithEvents Timer500 As Timer
    Friend WithEvents Timer1000 As Timer
    Friend WithEvents Timer2000 As Timer
    Friend WithEvents Timer10000 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelNbRej As Label
    Friend WithEvents LabelPiecesOut As Label
    Friend WithEvents LabelPiecesIn As Label
    Friend WithEvents LabelVolProj As Label
    Friend WithEvents LabelSlashed As Label
    Friend WithEvents szProductionDisplay As BasicLabel
    Friend WithEvents LabelLugFill As Label
    Friend WithEvents LabelVolumeHour As Label
    Friend WithEvents LabelVolumePmp As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CommsOk As PictureBox
    Friend WithEvents szSorterDisplay As Label
    Friend WithEvents Timer100 As Timer
    Friend WithEvents Saw20ft As Button
    Friend WithEvents Saw18ft As Button
    Friend WithEvents Saw16ft As Button
    Friend WithEvents Saw14ft As Button
    Friend WithEvents Saw12ft As Button
    Friend WithEvents Saw10ft As Button
    Friend WithEvents Saw8ft As Button
    Friend WithEvents Saw0ft As Button
    Friend WithEvents Saw2ft As Button
    Friend WithEvents Saw4ft As Button
    Friend WithEvents Saw6ft As Button
    Friend WithEvents Gate0 As Button
    Friend WithEvents Gate1 As Button
    Friend WithEvents Gate2 As Button
    Friend WithEvents Gate3 As Button
    Friend WithEvents Gate4 As Button
    Friend WithEvents Gate5 As Button
    Friend WithEvents Gate6 As Button
    Friend WithEvents Gate7 As Button
    Friend WithEvents Cit0 As Button
    Friend WithEvents Cit1 As Button
    Friend WithEvents Cit2 As Button
    Friend WithEvents Cit3 As Button
End Class
