<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class History
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        Me.EthernetIPforCLXCom2 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BasicDataLogger21 = New AdvancedHMIControls.BasicDataLogger2()
        Me.DataSubscriber21 = New AdvancedHMIControls.DataSubscriber2(Me.components)
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DateAndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SortId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductionDisplay = New AdvancedHMIControls.BasicLabel()
        Me.CircularProgressBar1 = New AdvancedHMIControls.CircularProgressBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PauseHistory = New System.Windows.Forms.ToolStripButton()
        Me.ClearHistory = New System.Windows.Forms.ToolStripButton()
        Me.SaveHistory = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.EthernetIPforCLXCom2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasicDataLogger21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriber21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CircularProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EthernetIPforCLXCom2
        '
        Me.EthernetIPforCLXCom2.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom2.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom2.DisableSubscriptions = False
        Me.EthernetIPforCLXCom2.IniFileName = ""
        Me.EthernetIPforCLXCom2.IniFileSection = Nothing
        Me.EthernetIPforCLXCom2.IPAddress = "150.150.10.152"
        Me.EthernetIPforCLXCom2.PollRateOverride = 100
        Me.EthernetIPforCLXCom2.Port = 44818
        Me.EthernetIPforCLXCom2.ProcessorSlot = 0
        Me.EthernetIPforCLXCom2.RoutePath = Nothing
        Me.EthernetIPforCLXCom2.Timeout = 4000
        '
        'BasicDataLogger21
        '
        Me.BasicDataLogger21.ComComponent = Me.EthernetIPforCLXCom2
        Me.BasicDataLogger21.CreateNewLogFileAtMaxPoints = False
        Me.BasicDataLogger21.CreateNewLogFileDaily = False
        Me.BasicDataLogger21.EnableLogging = True
        Me.BasicDataLogger21.FileFolder = "C:\Users\brownhe\Documents"
        Me.BasicDataLogger21.FileName = "PLCData"
        Me.BasicDataLogger21.FileNameIncludesDate = False
        Me.BasicDataLogger21.LogInterval = 1000
        Me.BasicDataLogger21.LogTriggerType = AdvancedHMIControls.BasicDataLogger2.TriggerType.WriteOnTrigger
        Me.BasicDataLogger21.MaximumPoints = 0
        Me.BasicDataLogger21.PLCAddressEnableeLogging = Nothing
        Me.BasicDataLogger21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("PROGRAM:TX_MSG_UNS_BLOCK1_200.dLugIdx", 1, "Lug Id"))
        Me.BasicDataLogger21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("PROGRAM:TX_MSG_UNS_BLOCK1_200.dTestData[0]", 1, "Data 1"))
        Me.BasicDataLogger21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("PROGRAM:TX_MSG_UNS_BLOCK1_200.dTestData[1]", 1, "Data 2"))
        Me.BasicDataLogger21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("PROGRAM:TX_MSG_UNS_BLOCK1_200.dTestData[2]", 1, "Data 3"))
        Me.BasicDataLogger21.PLCAddressWriteTrigger = "PROGRAM:TX_MSG_UNS_BLOCK1_200.bSendInfo"
        Me.BasicDataLogger21.Prefix = ""
        Me.BasicDataLogger21.TimestampFormat = "dd-MMM-yy HH:mm:ss"
        Me.BasicDataLogger21.WriteTrigger = False
        '
        'DataSubscriber21
        '
        Me.DataSubscriber21.ComComponent = Me.EthernetIPforCLXCom2
        Me.DataSubscriber21.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("g_dAcvLugIdxTrig", 1, "LugId"))
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateAndTime, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Column1, Me.SortId, Me.NomDim})
        Me.DataGridView3.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.DataGridView3.Location = New System.Drawing.Point(9, 68)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(1408, 730)
        Me.DataGridView3.TabIndex = 76
        '
        'DateAndTime
        '
        Me.DateAndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DateAndTime.HeaderText = "Time"
        Me.DateAndTime.Name = "DateAndTime"
        Me.DateAndTime.ReadOnly = True
        Me.DateAndTime.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.HeaderText = "Lug Id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.HeaderText = "OptiId"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.HeaderText = "OptiDest"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.HeaderText = "SortDest"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "Bin #"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'SortId
        '
        Me.SortId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SortId.HeaderText = "Sort Id"
        Me.SortId.Name = "SortId"
        Me.SortId.ReadOnly = True
        Me.SortId.Width = 55
        '
        'NomDim
        '
        Me.NomDim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NomDim.HeaderText = "Nominal Dimensions"
        Me.NomDim.Name = "NomDim"
        Me.NomDim.ReadOnly = True
        Me.NomDim.Width = 200
        '
        'ProductionDisplay
        '
        Me.ProductionDisplay.AutoSize = True
        Me.ProductionDisplay.BackColor = System.Drawing.Color.Transparent
        Me.ProductionDisplay.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.ProductionDisplay.ComComponent = Me.EthernetIPforCLXCom2
        Me.ProductionDisplay.DisplayAsTime = False
        Me.ProductionDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ProductionDisplay.Location = New System.Drawing.Point(67, 35)
        Me.ProductionDisplay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ProductionDisplay.Name = "ProductionDisplay"
        Me.ProductionDisplay.NumericFormat = Nothing
        Me.ProductionDisplay.PLCAddressKeypad = ""
        Me.ProductionDisplay.PLCAddressValue = "PROGRAM:PRODUCTION_DISPLAY.szDisplayString"
        Me.ProductionDisplay.Size = New System.Drawing.Size(314, 20)
        Me.ProductionDisplay.TabIndex = 227
        Me.ProductionDisplay.Text = "Afficheur du Production: Production Display"
        Me.ProductionDisplay.Value = "Production Display"
        Me.ProductionDisplay.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.ProductionDisplay.ValueLeftPadLength = 0
        Me.ProductionDisplay.ValuePrefix = "Afficheur du Production: "
        Me.ProductionDisplay.ValueScaleFactor = 1.0R
        Me.ProductionDisplay.ValueSuffix = Nothing
        Me.ProductionDisplay.ValueToSubtractFrom = 0!
        '
        'CircularProgressBar1
        '
        Me.CircularProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar1.ComComponent = Me.EthernetIPforCLXCom2
        Me.CircularProgressBar1.ForeColor = System.Drawing.Color.Gray
        Me.CircularProgressBar1.HighlightColor = System.Drawing.Color.Red
        Me.CircularProgressBar1.IniFileName = ""
        Me.CircularProgressBar1.IniFileSection = Nothing
        Me.CircularProgressBar1.Location = New System.Drawing.Point(12, 23)
        Me.CircularProgressBar1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CircularProgressBar1.Maximum = 2000
        Me.CircularProgressBar1.Minimum = 0
        Me.CircularProgressBar1.Name = "CircularProgressBar1"
        Me.CircularProgressBar1.NumericFormat = Nothing
        Me.CircularProgressBar1.PenBackColor = System.Drawing.Color.Gray
        Me.CircularProgressBar1.PenForeColor = System.Drawing.Color.Lime
        Me.CircularProgressBar1.PenSize = 10
        Me.CircularProgressBar1.PLCAddressText = ""
        Me.CircularProgressBar1.PLCAddressValue = New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("g_AdvHmiCountTest", 1)
        Me.CircularProgressBar1.PLCAddressVisible = ""
        Me.CircularProgressBar1.ShowValue = True
        Me.CircularProgressBar1.Size = New System.Drawing.Size(37, 44)
        Me.CircularProgressBar1.TabIndex = 228
        Me.CircularProgressBar1.Text = "CircularProgressBar1"
        Me.CircularProgressBar1.Value = 0R
        Me.CircularProgressBar1.ValueSuffix = "Ctl"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PauseHistory, Me.ClearHistory, Me.SaveHistory})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1426, 27)
        Me.ToolStrip1.TabIndex = 229
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'PauseHistory
        '
        Me.PauseHistory.AccessibleDescription = "Pause History Grid"
        Me.PauseHistory.CheckOnClick = True
        Me.PauseHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PauseHistory.Image = CType(resources.GetObject("PauseHistory.Image"), System.Drawing.Image)
        Me.PauseHistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PauseHistory.Name = "PauseHistory"
        Me.PauseHistory.Size = New System.Drawing.Size(24, 24)
        Me.PauseHistory.Text = "PauseHistory"
        '
        'ClearHistory
        '
        Me.ClearHistory.AccessibleDescription = "Clear History Grid"
        Me.ClearHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClearHistory.Image = CType(resources.GetObject("ClearHistory.Image"), System.Drawing.Image)
        Me.ClearHistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearHistory.Name = "ClearHistory"
        Me.ClearHistory.Size = New System.Drawing.Size(24, 24)
        Me.ClearHistory.Text = "ClearHistory"
        '
        'SaveHistory
        '
        Me.SaveHistory.AccessibleDescription = "Save History Grid"
        Me.SaveHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveHistory.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.SaveIcon2
        Me.SaveHistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveHistory.Name = "SaveHistory"
        Me.SaveHistory.Size = New System.Drawing.Size(24, 24)
        Me.SaveHistory.Text = "SaveHistory"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 443)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(641, 730)
        Me.DataGridView1.TabIndex = 230
        Me.DataGridView1.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 55
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "Lug Id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 62
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.HeaderText = "OptiId"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "OptiDest"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 73
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.HeaderText = "SortDest"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 73
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.HeaderText = "SortBin"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 66
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.HeaderText = "SortId"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 60
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "NominalDimensions"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1426, 808)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.CircularProgressBar1)
        Me.Controls.Add(Me.ProductionDisplay)
        Me.Controls.Add(Me.DataGridView3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "History"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Tag = "2"
        Me.Text = "History"
        CType(Me.EthernetIPforCLXCom2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasicDataLogger21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriber21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CircularProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EthernetIPforCLXCom2 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BasicDataLogger21 As AdvancedHMIControls.BasicDataLogger2
    Friend WithEvents DataSubscriber21 As AdvancedHMIControls.DataSubscriber2
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents ProductionDisplay As AdvancedHMIControls.BasicLabel
    Friend WithEvents CircularProgressBar1 As AdvancedHMIControls.CircularProgressBar
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents PauseHistory As ToolStripButton
    Friend WithEvents ClearHistory As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateAndTime As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents SortId As DataGridViewTextBoxColumn
    Friend WithEvents NomDim As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents SaveHistory As ToolStripButton
End Class
