<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.szSystemAlarm = New System.Windows.Forms.TextBox()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.DataSubscriber21 = New AdvancedHMIControls.DataSubscriber2(Me.components)
        Me.DataSubscriber22 = New AdvancedHMIControls.DataSubscriber2(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelNbRej = New System.Windows.Forms.Label()
        Me.LabelPiecesOut = New System.Windows.Forms.Label()
        Me.LabelPiecesIn = New System.Windows.Forms.Label()
        Me.LabelVolProj = New System.Windows.Forms.Label()
        Me.LabelSlashed = New System.Windows.Forms.Label()
        Me.szSpeed = New AdvancedHMIControls.BasicLabel()
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
        Me.Timer500 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1000 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2000 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer10000 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriber21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriber22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommsOk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'szSystemAlarm
        '
        Me.szSystemAlarm.BackColor = System.Drawing.Color.Black
        Me.szSystemAlarm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.szSystemAlarm.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.szSystemAlarm.ForeColor = System.Drawing.Color.Coral
        Me.szSystemAlarm.Location = New System.Drawing.Point(14, 140)
        Me.szSystemAlarm.Name = "szSystemAlarm"
        Me.szSystemAlarm.Size = New System.Drawing.Size(1254, 37)
        Me.szSystemAlarm.TabIndex = 0
        Me.szSystemAlarm.Text = "Intlk:Coucou"
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "150.150.10.153"
        Me.EthernetIPforCLXCom1.PollRateOverride = 100
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'DataSubscriber21
        '
        Me.DataSubscriber21.ComComponent = Me.EthernetIPforCLXCom1
        Me.DataSubscriber21.PollRate = 0
        Me.DataSubscriber21.SynchronizingObject = Me
        Me.DataSubscriber21.Value = Nothing
        '
        'DataSubscriber22
        '
        Me.DataSubscriber22.ComComponent = Me.EthernetIPforCLXCom1
        Me.DataSubscriber22.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriber22.PLCAddressValueItems"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriber22.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriber22.PLCAddressValueItems1"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriber22.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriber22.PLCAddressValueItems2"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriber22.PLCAddressValueItems.Add(CType(resources.GetObject("DataSubscriber22.PLCAddressValueItems3"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.DataSubscriber22.PollRate = 0
        Me.DataSubscriber22.SynchronizingObject = Me
        Me.DataSubscriber22.Value = Nothing
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(1, -3)
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
        Me.LabelNbRej.Location = New System.Drawing.Point(673, 54)
        Me.LabelNbRej.Name = "LabelNbRej"
        Me.LabelNbRej.Size = New System.Drawing.Size(137, 27)
        Me.LabelNbRej.TabIndex = 288
        Me.LabelNbRej.Text = "dNbRejects"
        Me.LabelNbRej.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelPiecesOut
        '
        Me.LabelPiecesOut.AutoSize = True
        Me.LabelPiecesOut.BackColor = System.Drawing.Color.Transparent
        Me.LabelPiecesOut.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPiecesOut.ForeColor = System.Drawing.Color.White
        Me.LabelPiecesOut.Location = New System.Drawing.Point(1041, 54)
        Me.LabelPiecesOut.Name = "LabelPiecesOut"
        Me.LabelPiecesOut.Size = New System.Drawing.Size(168, 27)
        Me.LabelPiecesOut.TabIndex = 287
        Me.LabelPiecesOut.Text = "dNbPiecesOut"
        Me.LabelPiecesOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelPiecesIn
        '
        Me.LabelPiecesIn.AutoSize = True
        Me.LabelPiecesIn.BackColor = System.Drawing.Color.Transparent
        Me.LabelPiecesIn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPiecesIn.ForeColor = System.Drawing.Color.White
        Me.LabelPiecesIn.Location = New System.Drawing.Point(1041, 12)
        Me.LabelPiecesIn.Name = "LabelPiecesIn"
        Me.LabelPiecesIn.Size = New System.Drawing.Size(148, 27)
        Me.LabelPiecesIn.TabIndex = 286
        Me.LabelPiecesIn.Text = "dNbPiecesIn"
        Me.LabelPiecesIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVolProj
        '
        Me.LabelVolProj.AutoSize = True
        Me.LabelVolProj.BackColor = System.Drawing.Color.Transparent
        Me.LabelVolProj.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVolProj.ForeColor = System.Drawing.Color.White
        Me.LabelVolProj.Location = New System.Drawing.Point(249, 99)
        Me.LabelVolProj.Name = "LabelVolProj"
        Me.LabelVolProj.Size = New System.Drawing.Size(149, 27)
        Me.LabelVolProj.TabIndex = 284
        Me.LabelVolProj.Text = "dVolumeProj"
        Me.LabelVolProj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelSlashed
        '
        Me.LabelSlashed.AutoSize = True
        Me.LabelSlashed.BackColor = System.Drawing.Color.Transparent
        Me.LabelSlashed.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSlashed.ForeColor = System.Drawing.Color.White
        Me.LabelSlashed.Location = New System.Drawing.Point(673, 99)
        Me.LabelSlashed.Name = "LabelSlashed"
        Me.LabelSlashed.Size = New System.Drawing.Size(145, 27)
        Me.LabelSlashed.TabIndex = 283
        Me.LabelSlashed.Text = "dNbSlashed"
        Me.LabelSlashed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'szSpeed
        '
        Me.szSpeed.AllowDrop = True
        Me.szSpeed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.szSpeed.AutoSize = True
        Me.szSpeed.BackColor = System.Drawing.Color.Transparent
        Me.szSpeed.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.szSpeed.ComComponent = Me.EthernetIPforCLXCom1
        Me.szSpeed.DisplayAsTime = False
        Me.szSpeed.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.szSpeed.ForeColor = System.Drawing.Color.White
        Me.szSpeed.Highlight = False
        Me.szSpeed.HighlightColor = System.Drawing.Color.Red
        Me.szSpeed.HighlightForeColor = System.Drawing.Color.White
        Me.szSpeed.HighlightKeyCharacter = "!"
        Me.szSpeed.InterpretValueAsBCD = False
        Me.szSpeed.KeypadAlphaNumeric = False
        Me.szSpeed.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.szSpeed.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.szSpeed.KeypadMaxValue = 0R
        Me.szSpeed.KeypadMinValue = 0R
        Me.szSpeed.KeypadScaleFactor = 1.0R
        Me.szSpeed.KeypadShowCurrentValue = False
        Me.szSpeed.KeypadText = Nothing
        Me.szSpeed.KeypadWidth = 300
        Me.szSpeed.Location = New System.Drawing.Point(176, 12)
        Me.szSpeed.Name = "szSpeed"
        Me.szSpeed.NumericFormat = Nothing
        Me.szSpeed.PLCAddressKeypad = ""
        Me.szSpeed.PLCAddressValue = "g_ActLug.Master.Encoder.Data.dRPM"
        Me.szSpeed.PollRate = 0
        Me.szSpeed.Size = New System.Drawing.Size(187, 27)
        Me.szSpeed.TabIndex = 284
        Me.szSpeed.Text = "Speed Lugs/Min"
        Me.szSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.szSpeed.Value = "Speed"
        Me.szSpeed.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.szSpeed.ValueLeftPadLength = 0
        Me.szSpeed.ValuePrefix = Nothing
        Me.szSpeed.ValueScaleFactor = 1.0R
        Me.szSpeed.ValueSuffix = " Lugs/Min"
        Me.szSpeed.ValueToSubtractFrom = 0!
        '
        'LabelLugFill
        '
        Me.LabelLugFill.AutoSize = True
        Me.LabelLugFill.BackColor = System.Drawing.Color.Transparent
        Me.LabelLugFill.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLugFill.ForeColor = System.Drawing.Color.White
        Me.LabelLugFill.Location = New System.Drawing.Point(673, 12)
        Me.LabelLugFill.Name = "LabelLugFill"
        Me.LabelLugFill.Size = New System.Drawing.Size(148, 27)
        Me.LabelLugFill.TabIndex = 282
        Me.LabelLugFill.Text = "dLugFillPerc"
        Me.LabelLugFill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVolumeHour
        '
        Me.LabelVolumeHour.AutoSize = True
        Me.LabelVolumeHour.BackColor = System.Drawing.Color.Transparent
        Me.LabelVolumeHour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVolumeHour.ForeColor = System.Drawing.Color.White
        Me.LabelVolumeHour.Location = New System.Drawing.Point(1134, 99)
        Me.LabelVolumeHour.Name = "LabelVolumeHour"
        Me.LabelVolumeHour.Size = New System.Drawing.Size(171, 27)
        Me.LabelVolumeHour.TabIndex = 281
        Me.LabelVolumeHour.Text = "dVolumeHeure"
        Me.LabelVolumeHour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVolumePmp
        '
        Me.LabelVolumePmp.AutoSize = True
        Me.LabelVolumePmp.BackColor = System.Drawing.Color.Transparent
        Me.LabelVolumePmp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVolumePmp.ForeColor = System.Drawing.Color.White
        Me.LabelVolumePmp.Location = New System.Drawing.Point(176, 54)
        Me.LabelVolumePmp.Name = "LabelVolumePmp"
        Me.LabelVolumePmp.Size = New System.Drawing.Size(106, 27)
        Me.LabelVolumePmp.TabIndex = 280
        Me.LabelVolumePmp.Text = "dVolume"
        Me.LabelVolumePmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LightGray
        Me.Label19.Location = New System.Drawing.Point(846, -3)
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
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LightGray
        Me.Label18.Location = New System.Drawing.Point(856, 39)
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
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LightGray
        Me.Label17.Location = New System.Drawing.Point(477, 39)
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
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightGray
        Me.Label16.Location = New System.Drawing.Point(436, 84)
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
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightGray
        Me.Label15.Location = New System.Drawing.Point(414, -3)
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
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(1, 84)
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
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(856, 84)
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
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(9, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(161, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Volume (BF)"
        '
        'CommsOk
        '
        Me.CommsOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CommsOk.Image = CType(resources.GetObject("CommsOk.Image"), System.Drawing.Image)
        Me.CommsOk.Location = New System.Drawing.Point(1307, 140)
        Me.CommsOk.Margin = New System.Windows.Forms.Padding(4)
        Me.CommsOk.Name = "CommsOk"
        Me.CommsOk.Size = New System.Drawing.Size(25, 26)
        Me.CommsOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CommsOk.TabIndex = 336
        Me.CommsOk.TabStop = False
        '
        'Timer500
        '
        Me.Timer500.Interval = 500
        '
        'Timer1000
        '
        Me.Timer1000.Interval = 1000
        '
        'Timer2000
        '
        Me.Timer2000.Interval = 2000
        '
        'Timer10000
        '
        Me.Timer10000.Interval = 10000
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1345, 186)
        Me.Controls.Add(Me.CommsOk)
        Me.Controls.Add(Me.LabelNbRej)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelSlashed)
        Me.Controls.Add(Me.LabelPiecesOut)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LabelPiecesIn)
        Me.Controls.Add(Me.szSystemAlarm)
        Me.Controls.Add(Me.LabelVolProj)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.LabelVolumeHour)
        Me.Controls.Add(Me.szSpeed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelLugFill)
        Me.Controls.Add(Me.LabelVolumePmp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Autolog Controls View"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriber21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriber22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommsOk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents szSystemAlarm As TextBox
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents DataSubscriber21 As AdvancedHMIControls.DataSubscriber2
    Friend WithEvents DataSubscriber22 As AdvancedHMIControls.DataSubscriber2
    Friend WithEvents LabelNbRej As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelSlashed As Label
    Friend WithEvents LabelPiecesOut As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LabelPiecesIn As Label
    Friend WithEvents LabelVolProj As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents LabelVolumeHour As Label
    Friend WithEvents szSpeed As AdvancedHMIControls.BasicLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelLugFill As Label
    Friend WithEvents LabelVolumePmp As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CommsOk As PictureBox
    Friend WithEvents Timer500 As Timer
    Friend WithEvents Timer1000 As Timer
    Friend WithEvents Timer2000 As Timer
    Friend WithEvents Timer10000 As Timer
End Class
