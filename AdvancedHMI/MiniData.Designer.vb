<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiniData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MiniData))
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.DataSubscriber21 = New AdvancedHMIControls.DataSubscriber2(Me.components)
        Me.DataSubscriber22 = New AdvancedHMIControls.DataSubscriber2(Me.components)
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
        Me.szProductionDisplay = New AdvancedHMIControls.BasicLabel()
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
        Me.szLTSDisplay = New System.Windows.Forms.Label()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriber21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriber22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommsOk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "150.150,10.153"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'DataSubscriber21
        '
        Me.DataSubscriber21.ComComponent = Me.EthernetIPforCLXCom1
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
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(144, 44)
        Me.Label5.TabIndex = 307
        Me.Label5.Text = "Sorter Speed"
        '
        'LabelNbRej
        '
        Me.LabelNbRej.AutoSize = True
        Me.LabelNbRej.BackColor = System.Drawing.Color.Transparent
        Me.LabelNbRej.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNbRej.ForeColor = System.Drawing.Color.White
        Me.LabelNbRej.Location = New System.Drawing.Point(978, 24)
        Me.LabelNbRej.Name = "LabelNbRej"
        Me.LabelNbRej.Size = New System.Drawing.Size(114, 29)
        Me.LabelNbRej.TabIndex = 306
        Me.LabelNbRej.Text = "dNbRejects"
        '
        'LabelPiecesOut
        '
        Me.LabelPiecesOut.AutoSize = True
        Me.LabelPiecesOut.BackColor = System.Drawing.Color.Transparent
        Me.LabelPiecesOut.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPiecesOut.ForeColor = System.Drawing.Color.White
        Me.LabelPiecesOut.Location = New System.Drawing.Point(536, 111)
        Me.LabelPiecesOut.Name = "LabelPiecesOut"
        Me.LabelPiecesOut.Size = New System.Drawing.Size(139, 29)
        Me.LabelPiecesOut.TabIndex = 305
        Me.LabelPiecesOut.Text = "dNbPiecesOut"
        '
        'LabelPiecesIn
        '
        Me.LabelPiecesIn.AutoSize = True
        Me.LabelPiecesIn.BackColor = System.Drawing.Color.Transparent
        Me.LabelPiecesIn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPiecesIn.ForeColor = System.Drawing.Color.White
        Me.LabelPiecesIn.Location = New System.Drawing.Point(544, 68)
        Me.LabelPiecesIn.Name = "LabelPiecesIn"
        Me.LabelPiecesIn.Size = New System.Drawing.Size(123, 29)
        Me.LabelPiecesIn.TabIndex = 304
        Me.LabelPiecesIn.Text = "dNbPiecesIn"
        '
        'LabelVolProj
        '
        Me.LabelVolProj.AutoSize = True
        Me.LabelVolProj.BackColor = System.Drawing.Color.Transparent
        Me.LabelVolProj.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVolProj.ForeColor = System.Drawing.Color.White
        Me.LabelVolProj.Location = New System.Drawing.Point(221, 111)
        Me.LabelVolProj.Name = "LabelVolProj"
        Me.LabelVolProj.Size = New System.Drawing.Size(125, 29)
        Me.LabelVolProj.TabIndex = 303
        Me.LabelVolProj.Text = "dVolumeProj"
        '
        'LabelSlashed
        '
        Me.LabelSlashed.AutoSize = True
        Me.LabelSlashed.BackColor = System.Drawing.Color.Transparent
        Me.LabelSlashed.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSlashed.ForeColor = System.Drawing.Color.White
        Me.LabelSlashed.Location = New System.Drawing.Point(1011, 68)
        Me.LabelSlashed.Name = "LabelSlashed"
        Me.LabelSlashed.Size = New System.Drawing.Size(120, 29)
        Me.LabelSlashed.TabIndex = 301
        Me.LabelSlashed.Text = "dNbSlashed"
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
        Me.szProductionDisplay.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.szProductionDisplay.Location = New System.Drawing.Point(162, 24)
        Me.szProductionDisplay.Name = "szProductionDisplay"
        Me.szProductionDisplay.NumericFormat = Nothing
        Me.szProductionDisplay.PLCAddressKeypad = ""
        Me.szProductionDisplay.PLCAddressValue = "g_ActLug.Master.Encoder.Data.dRPM"
        Me.szProductionDisplay.Size = New System.Drawing.Size(155, 29)
        Me.szProductionDisplay.TabIndex = 302
        Me.szProductionDisplay.Text = "Speed Lugs/Min"
        Me.szProductionDisplay.Value = "Speed"
        Me.szProductionDisplay.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.szProductionDisplay.ValueLeftPadLength = 0
        Me.szProductionDisplay.ValuePrefix = Nothing
        Me.szProductionDisplay.ValueScaleFactor = 1.0R
        Me.szProductionDisplay.ValueSuffix = " Lugs/Min"
        Me.szProductionDisplay.ValueToSubtractFrom = 0!
        '
        'LabelLugFill
        '
        Me.LabelLugFill.AutoSize = True
        Me.LabelLugFill.BackColor = System.Drawing.Color.Transparent
        Me.LabelLugFill.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLugFill.ForeColor = System.Drawing.Color.White
        Me.LabelLugFill.Location = New System.Drawing.Point(1032, 111)
        Me.LabelLugFill.Name = "LabelLugFill"
        Me.LabelLugFill.Size = New System.Drawing.Size(122, 29)
        Me.LabelLugFill.TabIndex = 300
        Me.LabelLugFill.Text = "dLugFillPerc"
        '
        'LabelVolumeHour
        '
        Me.LabelVolumeHour.AutoSize = True
        Me.LabelVolumeHour.BackColor = System.Drawing.Color.Transparent
        Me.LabelVolumeHour.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVolumeHour.ForeColor = System.Drawing.Color.White
        Me.LabelVolumeHour.Location = New System.Drawing.Point(611, 24)
        Me.LabelVolumeHour.Name = "LabelVolumeHour"
        Me.LabelVolumeHour.Size = New System.Drawing.Size(144, 29)
        Me.LabelVolumeHour.TabIndex = 299
        Me.LabelVolumeHour.Text = "dVolumeHeure"
        '
        'LabelVolumePmp
        '
        Me.LabelVolumePmp.AutoSize = True
        Me.LabelVolumePmp.BackColor = System.Drawing.Color.Transparent
        Me.LabelVolumePmp.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVolumePmp.ForeColor = System.Drawing.Color.White
        Me.LabelVolumePmp.Location = New System.Drawing.Point(156, 68)
        Me.LabelVolumePmp.Name = "LabelVolumePmp"
        Me.LabelVolumePmp.Size = New System.Drawing.Size(90, 29)
        Me.LabelVolumePmp.TabIndex = 298
        Me.LabelVolumePmp.Text = "dVolume"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LightGray
        Me.Label19.Location = New System.Drawing.Point(377, 53)
        Me.Label19.Name = "Label19"
        Me.Label19.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label19.Size = New System.Drawing.Size(161, 44)
        Me.Label19.TabIndex = 297
        Me.Label19.Text = "Pieces Rentres"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LightGray
        Me.Label18.Location = New System.Drawing.Point(377, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label18.Size = New System.Drawing.Size(153, 44)
        Me.Label18.TabIndex = 296
        Me.Label18.Text = "Pieces Sorties"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LightGray
        Me.Label17.Location = New System.Drawing.Point(814, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label17.Size = New System.Drawing.Size(158, 44)
        Me.Label17.TabIndex = 295
        Me.Label17.Text = "Pieces Rejetés"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightGray
        Me.Label16.Location = New System.Drawing.Point(814, 53)
        Me.Label16.Name = "Label16"
        Me.Label16.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label16.Size = New System.Drawing.Size(191, 44)
        Me.Label16.TabIndex = 294
        Me.Label16.Text = "Pieces Deshiqueté"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightGray
        Me.Label15.Location = New System.Drawing.Point(814, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label15.Size = New System.Drawing.Size(212, 44)
        Me.Label15.TabIndex = 293
        Me.Label15.Text = "Taquets Remplis (%)"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(203, 44)
        Me.Label3.TabIndex = 292
        Me.Label3.Text = "Volume projeté (BF)"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(377, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(228, 44)
        Me.Label2.TabIndex = 291
        Me.Label2.Text = "Volume par heure (BF)"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(138, 44)
        Me.Label1.TabIndex = 290
        Me.Label1.Text = "Volume (BF)"
        '
        'CommsOk
        '
        Me.CommsOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CommsOk.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.autolog_juste_logo
        Me.CommsOk.Location = New System.Drawing.Point(1129, 227)
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
        Me.szSorterDisplay.BackColor = System.Drawing.SystemColors.ControlText
        Me.szSorterDisplay.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.szSorterDisplay.ForeColor = System.Drawing.Color.Coral
        Me.szSorterDisplay.Location = New System.Drawing.Point(66, 162)
        Me.szSorterDisplay.Name = "szSorterDisplay"
        Me.szSorterDisplay.Size = New System.Drawing.Size(163, 27)
        Me.szSorterDisplay.TabIndex = 337
        Me.szSorterDisplay.Text = "Sorter Display"
        '
        'szLTSDisplay
        '
        Me.szLTSDisplay.AutoSize = True
        Me.szLTSDisplay.BackColor = System.Drawing.SystemColors.ControlText
        Me.szLTSDisplay.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.szLTSDisplay.ForeColor = System.Drawing.Color.Coral
        Me.szLTSDisplay.Location = New System.Drawing.Point(66, 199)
        Me.szLTSDisplay.Name = "szLTSDisplay"
        Me.szLTSDisplay.Size = New System.Drawing.Size(139, 27)
        Me.szLTSDisplay.TabIndex = 338
        Me.szLTSDisplay.Text = "LTS Display"
        '
        'MiniData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(1157, 255)
        Me.Controls.Add(Me.szLTSDisplay)
        Me.Controls.Add(Me.szSorterDisplay)
        Me.Controls.Add(Me.CommsOk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelNbRej)
        Me.Controls.Add(Me.LabelPiecesOut)
        Me.Controls.Add(Me.LabelPiecesIn)
        Me.Controls.Add(Me.LabelVolProj)
        Me.Controls.Add(Me.LabelSlashed)
        Me.Controls.Add(Me.szProductionDisplay)
        Me.Controls.Add(Me.LabelLugFill)
        Me.Controls.Add(Me.LabelVolumeHour)
        Me.Controls.Add(Me.LabelVolumePmp)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MiniData"
        Me.Text = "Autolog Controls View"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriber21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriber22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommsOk, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents szLTSDisplay As Label
End Class
