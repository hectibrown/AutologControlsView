<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BinControl
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BinControl))
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.szSorterDisplay = New System.Windows.Forms.Label()
        Me.BinGrid = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CommsOk = New System.Windows.Forms.PictureBox()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.DataSubscriber22 = New AdvancedHMIControls.DataSubscriber2(Me.components)
        Me.BinNb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Max = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Percent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistoryGrid = New System.Windows.Forms.DataGridView()
        Me.DateAndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BinGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommsOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriber22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        Me.DateLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.DateLabel.Location = New System.Drawing.Point(12, 950)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(331, 31)
        Me.DateLabel.TabIndex = 297
        Me.DateLabel.Text = "YYYY-MM-DD HH:MM:SS"
        '
        'szSorterDisplay
        '
        Me.szSorterDisplay.BackColor = System.Drawing.Color.Transparent
        Me.szSorterDisplay.Font = New System.Drawing.Font("Arial", 24.0!)
        Me.szSorterDisplay.ForeColor = System.Drawing.Color.Coral
        Me.szSorterDisplay.Location = New System.Drawing.Point(348, 918)
        Me.szSorterDisplay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.szSorterDisplay.Name = "szSorterDisplay"
        Me.szSorterDisplay.Size = New System.Drawing.Size(1207, 82)
        Me.szSorterDisplay.TabIndex = 338
        Me.szSorterDisplay.Text = "szSorterDisplay"
        Me.szSorterDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BinGrid
        '
        Me.BinGrid.AllowUserToAddRows = False
        Me.BinGrid.AllowUserToDeleteRows = False
        Me.BinGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BinGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BinGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BinGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BinNb, Me.Sort, Me.Actual, Me.Max, Me.Percent, Me.Status, Me.Description})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BinGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.BinGrid.Location = New System.Drawing.Point(12, 12)
        Me.BinGrid.Name = "BinGrid"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BinGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.BinGrid.RowHeadersVisible = False
        Me.BinGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.BinGrid.ShowCellErrors = False
        Me.BinGrid.ShowCellToolTips = False
        Me.BinGrid.ShowEditingIcon = False
        Me.BinGrid.ShowRowErrors = False
        Me.BinGrid.Size = New System.Drawing.Size(1151, 895)
        Me.BinGrid.TabIndex = 339
        '
        'Timer1
        '
        '
        'CommsOk
        '
        Me.CommsOk.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Autolog_logo_Officiel_sans_texte_transparent_white
        Me.CommsOk.Location = New System.Drawing.Point(1572, 917)
        Me.CommsOk.Name = "CommsOk"
        Me.CommsOk.Size = New System.Drawing.Size(334, 82)
        Me.CommsOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CommsOk.TabIndex = 0
        Me.CommsOk.TabStop = False
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "150.150.10.151"
        Me.EthernetIPforCLXCom1.PollRateOverride = 50
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'DataSubscriber22
        '
        Me.DataSubscriber22.ComComponent = Me.EthernetIPforCLXCom1
        Me.DataSubscriber22.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("g_stAcv.dWatchDog", 1))
        Me.DataSubscriber22.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("g_stAcv.dNbAlarms", 1))
        Me.DataSubscriber22.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("g_stAcv.dLugIdxHistory", 1))
        Me.DataSubscriber22.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("g_stAcv.dConnected", 1))
        Me.DataSubscriber22.PLCAddressValueItems.Add(New MfgControl.AdvancedHMI.Drivers.PLCAddressItem("g_stAcv.szAlarm", 1))
        '
        'BinNb
        '
        Me.BinNb.HeaderText = "Bin #"
        Me.BinNb.Name = "BinNb"
        Me.BinNb.Width = 85
        '
        'Sort
        '
        Me.Sort.HeaderText = "Sort"
        Me.Sort.Name = "Sort"
        Me.Sort.Width = 75
        '
        'Actual
        '
        Me.Actual.HeaderText = "Actual"
        Me.Actual.Name = "Actual"
        '
        'Max
        '
        Me.Max.HeaderText = "Maximum"
        Me.Max.Name = "Max"
        Me.Max.Width = 120
        '
        'Percent
        '
        Me.Percent.HeaderText = "Percent"
        Me.Percent.Name = "Percent"
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.Width = 125
        '
        'Description
        '
        Me.Description.HeaderText = "Descritpion"
        Me.Description.Name = "Description"
        Me.Description.Width = 1000
        '
        'HistoryGrid
        '
        Me.HistoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.HistoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.HistoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HistoryGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.HistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistoryGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateAndTime, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.Column1, Me.NomDim})
        Me.HistoryGrid.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.HistoryGrid.Location = New System.Drawing.Point(1168, 13)
        Me.HistoryGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.HistoryGrid.Name = "HistoryGrid"
        Me.HistoryGrid.ReadOnly = True
        Me.HistoryGrid.RowTemplate.Height = 24
        Me.HistoryGrid.Size = New System.Drawing.Size(819, 730)
        Me.HistoryGrid.TabIndex = 340
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
        Me.DataGridViewTextBoxColumn2.HeaderText = "LugId"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 85
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.HeaderText = "OptiId"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.HeaderText = "Destination"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "Bin"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'NomDim
        '
        Me.NomDim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NomDim.HeaderText = "Dimensions"
        Me.NomDim.Name = "NomDim"
        Me.NomDim.ReadOnly = True
        Me.NomDim.Width = 200
        '
        'BinControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(1904, 1001)
        Me.Controls.Add(Me.HistoryGrid)
        Me.Controls.Add(Me.BinGrid)
        Me.Controls.Add(Me.szSorterDisplay)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.CommsOk)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BinControl"
        Me.Text = "Autolog Sorter Control"
        CType(Me.BinGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommsOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriber22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EthernetIPforCLXCom1 As EthernetIPforCLXCom
    Friend WithEvents DataSubscriber22 As DataSubscriber2
    Friend WithEvents CommsOk As PictureBox
    Friend WithEvents DateLabel As Label
    Friend WithEvents szSorterDisplay As Label
    Friend WithEvents BinGrid As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BinNb As DataGridViewTextBoxColumn
    Friend WithEvents Sort As DataGridViewTextBoxColumn
    Friend WithEvents Actual As DataGridViewTextBoxColumn
    Friend WithEvents Max As DataGridViewTextBoxColumn
    Friend WithEvents Percent As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents HistoryGrid As DataGridView
    Friend WithEvents DateAndTime As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents NomDim As DataGridViewTextBoxColumn
End Class
