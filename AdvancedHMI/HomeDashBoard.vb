Public Class HomeDashBoard
    Dim bIdDetailStructurePresent As Boolean = True 'For testing purposes, as of 2021-02-03
    Public stAlarm As New StAlarms
    Dim szString(249) As String
    Dim dMessageLoadStep As Int32 = 0
    Dim g_dAcvConnected As Int32 = 0
    Dim g_dCommError As Int32
    Dim g_dAcvWatchDog As Int32
    Dim g_dLastValueWatchDog As Int32
    Dim g_dAcvNbAlarmsActive As Int32
    Dim dNbPrevAlarms As Int32
    Dim g_bCommsOk As Boolean = 0
    Dim g_dAcvReportsTest As New StACVReportsTest
    Dim g_stReportData As New StReportData
    Dim g_szNewMessage As New StAlarmMessages
    'Dim g_bOff As Boolean = 0

    Private Sub HomeDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'InitializeComponent()
        Timer500.Interval = 500
        Timer500.Start()
        Timer1000.Interval = 1000
        Timer1000.Start()
        Timer10000.Interval = 10000
        Timer10000.Start()
        TimerMarquee.Interval = 5
        TimerMarquee.Start()
        TimerMarquee.Enabled = True
        ComboBox1.Text = "Off"
        dMessageLoadStep = 0
        CommsOk.Visible = 0

        Label4.Visible = 0
        ComboBox1.Visible = 0
        Label10.Visible = 0
        Label11.Visible = 0
        TrackBar1.Visible = 0
        TrackBar2.Visible = 0
        Label12.Visible = 0
        Label13.Visible = 0
    End Sub

    Private Sub UpdateMesssagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateMesssagesToolStripMenuItem.Click
        Timer2000.Interval = 2000
        Timer2000.Start()
        dMessageLoadStep = 0
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer2000.Tick
        If g_bCommsOk Then
            Call LoadMessages()
        End If
    End Sub

    Public Sub LoadMessages()
        Select Case dMessageLoadStep
            Case 0
                Try
                    szString = EthernetIPforCLXCom1.Read("g_stAlarm.String.Intlk", 250) '("g_HMI_szAlarmHistory.String.Intlk", 250) 
                    stAlarm.szString.szIntlk = szString
                    dMessageLoadStep += 1
                Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                    g_dCommError = ex.ErrorCode
                    If g_dCommError <> 0 Then
                        CommsOk.Visible = 0
                    End If
                End Try
            Case 1
                Try
                    szString = EthernetIPforCLXCom1.Read("g_stAlarm.String.Msg", 250)
                    stAlarm.szString.szMsg = szString
                    dMessageLoadStep += 1
                Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                    g_dCommError = ex.ErrorCode
                    If g_dCommError <> 0 Then
                        CommsOk.Visible = 0
                        DataSubscriber22.PLCAddressValueItems(0).LastValue = 0
                    End If
                End Try
            Case 2
                Try
                    szString = EthernetIPforCLXCom1.Read("g_stAlarm.String.LineError", 250)
                    stAlarm.szString.szLineError = szString
                    dMessageLoadStep += 1
                Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                    g_dCommError = ex.ErrorCode
                    If g_dCommError <> 0 Then
                        CommsOk.Visible = 0
                        DataSubscriber22.PLCAddressValueItems(0).LastValue = 0
                    End If
                End Try
            Case 3
                Timer2000.Enabled = 0
                'Test for Wrtining to file
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter("c:\Drive_D\Test.txt", True)
                For i = 0 To 249
                    file.WriteLine($"{stAlarm.szString.szIntlk(i)}")
                Next
                For i = 0 To 249
                    file.WriteLine($"{stAlarm.szString.szLineError(i)}")
                Next
                For i = 0 To 249
                    file.WriteLine($"{stAlarm.szString.szMsg(i)}")
                Next

                file.Close()
        End Select
    End Sub

    Private Sub T1_Tick(sender As Object, e As EventArgs) Handles Timer500.Tick
        Dim bIntlkLeActive As Boolean = 0
        Dim bMsgActive As Boolean = 0
        Label21.Text = dMessageLoadStep

        'szMarqProdDisp.TextScrollSpeed = TrackBar1.Value
        'szMarqProdDisp.TextScrollDistance = TrackBar2.Value
        ScrollingText1.TextScrollDistance = TrackBar2.Value
        ScrollingText1.TextScrollSpeed = TrackBar1.Value
        Label12.Text = TrackBar1.Value
        Label13.Text = TrackBar2.Value
        If ComboBox1.Text = "On" And Not g_bCommsOk Then
            'szMarqProdDisp.Text = "INTLK:MASTER DRIVE AUX FAULT"
            'szMarqProdDisp.Visible = 1
            ScrollingText1.Visible = 1
            szProductionDisplay.Visible = 0
            Panel2.Visible = 1
            Panel2.BringToFront()
            DataGridView1.Visible = 1
            If DataGridView1.Rows.Count < 8 Then
                Me.DataGridView1.Rows.Insert(0, "INTLK:MASTER DRIVE AUX FAULT")
            End If
        ElseIf g_bCommsOk Then
            For dIdx = 0 To 249
                If stAlarm.bBits.bIntlk(dIdx) Then
                    bIntlkLeActive = 1
                End If
                If stAlarm.bBits.bLineError(dIdx) Then
                    bIntlkLeActive = 1
                End If
                If stAlarm.bBits.bMsg(dIdx) Then
                    bMsgActive = 1
                End If
            Next
            If g_dAcvNbAlarmsActive <> dNbPrevAlarms Then
                Try
                    stAlarm.bBits = EthernetIPforCLXCom1.ReadUDT(Of StAlarmBits)("g_stAlarm.Bits") '("g_HMI_szAlarmHistory.Bits")
                    If bIdDetailStructurePresent Then
                        stAlarm.IdDetail = EthernetIPforCLXCom1.ReadUDT(Of StAlarmIdDetail)("g_stAlarm.IdDetail")
                    End If
                    dNbPrevAlarms = g_dAcvNbAlarmsActive
                    'Call FbCheckAlarms()
                Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                    g_dCommError = ex.ErrorCode
                    If g_dCommError <> 0 Then
                        CommsOk.Visible = 0
                        DataSubscriber22.PLCAddressValueItems(0).LastValue = 0
                    End If
                End Try
            End If
            If dMessageLoadStep = 3 And g_dAcvNbAlarmsActive > 0 Or ComboBox1.Text = "On" And g_dAcvNbAlarmsActive <> dNbPrevAlarms Then
                dNbPrevAlarms = g_dAcvNbAlarmsActive
                'DataGridView1.Rows.Clear()
                'DataGridView1.Refresh()
                Call FbCheckAlarms()
                'szMarqProdDisp.Text = szProductionDisplay.Value
                'szMarqProdDisp.Visible = 1
                ScrollingText1.ScrollText = DataSubscriber22.PLCAddressValueItems(3).LastValue
                ScrollingText1.Visible = 1
                If bIntlkLeActive Then
                    Panel2.Visible = 1
                    Panel2.BringToFront()
                    DataGridView1.Visible = 1
                Else
                    Panel2.Visible = 0
                    DataGridView1.Visible = 0
                End If
            Else
                'szMarqProdDisp.Visible = 0
                'szMarqProdDisp.Hide()
                If bMsgActive Then
                    ScrollingText1.Visible = 1
                    Panel2.Visible = 1
                Else
                    ScrollingText1.Visible = 0
                    Panel2.Visible = 0
                End If
                szProductionDisplay.Visible = 1
                Panel2.Visible = 0
                DataGridView1.Visible = 0
            End If
        Else
            'szMarqProdDisp.Visible = 0
            'szMarqProdDisp.Hide()
            ScrollingText1.Visible = 0
            szProductionDisplay.Visible = 1
            Panel2.Visible = 0
            DataGridView1.Visible = 0
        End If

        '**************************************************
    End Sub

    Public Sub FbCheckAlarms()
        Dim dIdx As Int32
        DataGridView1.Rows.Clear()
        For dIdx = 0 To 249
            If stAlarm.bBits.bIntlk(dIdx) Then
                If stAlarm.IdDetail.dIntlkIdDetail(dIdx) > 0 Then
                    Call FindStars(stAlarm.szString.szIntlk(dIdx), dIdx, "INTLK")
                    Me.DataGridView1.Rows.Insert(0, g_szNewMessage.szIntlk(dIdx))
                Else
                    Me.DataGridView1.Rows.Insert(0, stAlarm.szString.szIntlk(dIdx))
                End If
            End If
            If stAlarm.bBits.bLineError(dIdx) Then
                If stAlarm.IdDetail.dLeIdDetail(dIdx) > 0 Then
                    Call FindStars(stAlarm.szString.szLineError(dIdx), dIdx, "LE")
                    Me.DataGridView1.Rows.Insert(0, g_szNewMessage.szLineError(dIdx))
                Else
                    Me.DataGridView1.Rows.Insert(0, stAlarm.szString.szLineError(dIdx))
                End If
            End If
            If stAlarm.bBits.bMsg(dIdx) Then
                If stAlarm.IdDetail.dMsgIdDetail(dIdx) > 0 Then
                    Call FindStars(stAlarm.szString.szMsg(dIdx), dIdx, "MSG")
                    stAlarm.szString.szMsg(dIdx) = g_szNewMessage.szMsg(dIdx)

                End If

            End If
        Next
        Me.DataGridView1.Sort(DataGridView1.Columns(0), 0)
    End Sub

    Sub FindStars(szMessage As String, dIdx As Int32, szErrorTyp As String)
        Dim szNewMessage As String = szMessage
        Dim szIdDetail As String = stAlarm.IdDetail.dIntlkIdDetail(dIdx)
        If szErrorTyp = "INTLK" Then
            If szNewMessage.Contains("****") Then
                g_szNewMessage.szIntlk(dIdx) = szNewMessage.Replace("****", szIdDetail)
            ElseIf szNewMessage.Contains("***") Then
                g_szNewMessage.szIntlk(dIdx) = szNewMessage.Replace("***", szIdDetail)
            ElseIf szNewMessage.Contains("**") Then
                g_szNewMessage.szIntlk(dIdx) = szNewMessage.Replace("**", szIdDetail)
            ElseIf szNewMessage.Contains("*") Then
                g_szNewMessage.szIntlk(dIdx) = szNewMessage.Replace("*", szIdDetail)
            End If
        ElseIf szErrorTyp = "LE" Then
            If szNewMessage.Contains("****") Then
                g_szNewMessage.szLineError(dIdx) = szNewMessage.Replace("****", szIdDetail)
            ElseIf szNewMessage.Contains("***") Then
                g_szNewMessage.szLineError(dIdx) = szNewMessage.Replace("***", szIdDetail)
            ElseIf szNewMessage.Contains("**") Then
                g_szNewMessage.szLineError(dIdx) = szNewMessage.Replace("**", szIdDetail)
            ElseIf szNewMessage.Contains("*") Then
                g_szNewMessage.szLineError(dIdx) = szNewMessage.Replace("*", szIdDetail)
            End If
        ElseIf szErrorTyp = "MSG" Then
            If szNewMessage.Contains("****") Then
                g_szNewMessage.szMsg(dIdx) = szNewMessage.Replace("****", szIdDetail)
            ElseIf szNewMessage.Contains("***") Then
                g_szNewMessage.szMsg(dIdx) = szNewMessage.Replace("***", szIdDetail)
            ElseIf szNewMessage.Contains("**") Then
                g_szNewMessage.szMsg(dIdx) = szNewMessage.Replace("**", szIdDetail)
            ElseIf szNewMessage.Contains("*") Then
                g_szNewMessage.szMsg(dIdx) = szNewMessage.Replace("*", szIdDetail)
            End If
        End If
    End Sub

    Private Sub EthernetIPforCLXCom1_ConnectionEstablished(sender As Object, e As EventArgs) Handles EthernetIPforCLXCom1.ConnectionEstablished
        Timer2000.Interval = 2000
        Timer2000.Start()
        g_dAcvConnected = 1
    End Sub

    Private Sub EthernetIPforCLXCom1_ConnectionClosed(sender As Object, e As EventArgs) Handles EthernetIPforCLXCom1.ConnectionClosed
        g_dAcvConnected = 0
    End Sub

    Private Sub DataSubscriber22_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber22.DataChanged
        g_dAcvConnected = CInt(DataSubscriber22.PLCAddressValueItems(0).LastValue)
        g_dAcvWatchDog = CInt(DataSubscriber22.PLCAddressValueItems(1).LastValue)
        g_dAcvNbAlarmsActive = CInt(DataSubscriber22.PLCAddressValueItems(2).LastValue)
        If g_dAcvWatchDog <> g_dLastValueWatchDog Then
            CommsOk.Visible = 1
            g_bCommsOk = 1
            g_dLastValueWatchDog = g_dAcvWatchDog
        Else
            CommsOk.Visible = 0
        End If
    End Sub

    Private Sub EthernetIPforCLXCom1_ComError(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles EthernetIPforCLXCom1.ComError
        g_dACVConnected = 0
    End Sub




    Private Sub Timer10000_Tick(sender As Object, e As EventArgs) Handles Timer10000.Tick
        Dim dTotalGrades As Int32
        Dim dTotalLengths As Int32
        Dim dTotalDest As Int32
        Dim rGrade(9) As Double
        Dim rLength(9) As Double
        Dim rDest(9) As Double
        Dim dLenthToStart As Int32 = 8



        If g_bCommsOk Then
            Try
                g_dACVReportsTest = EthernetIPforCLXCom1.ReadUDT(Of stACVReportsTest)("g_stACVReportsTest")
                g_stReportData = EthernetIPforCLXCom1.ReadUDT(Of stReportData)("g_par.ReportData")
            Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                g_dCommError = ex.ErrorCode
                If g_dCommError <> 0 Then
                    CommsOk.Visible = 0
                    DataSubscriber22.PLCAddressValueItems(0).LastValue = 0
                    Exit Sub
                End If
            End Try
        End If

        dTotalGrades = g_dACVReportsTest.Data(1) + g_dACVReportsTest.Data(2) + g_dACVReportsTest.Data(3) + g_dACVReportsTest.Data(4) + g_dACVReportsTest.Data(5) + g_dACVReportsTest.Data(6)
        dTotalLengths = g_dAcvReportsTest.Data(10) + g_dAcvReportsTest.Data(11) + g_dAcvReportsTest.Data(12) + g_dAcvReportsTest.Data(13) + g_dAcvReportsTest.Data(14) + g_dAcvReportsTest.Data(15) + g_dAcvReportsTest.Data(16) + g_dAcvReportsTest.Data(17) + g_dAcvReportsTest.Data(18) + g_dAcvReportsTest.Data(19)
        dTotalDest = g_dAcvReportsTest.Data(20) + g_dAcvReportsTest.Data(21) + g_dAcvReportsTest.Data(22) + g_dAcvReportsTest.Data(23) + g_dAcvReportsTest.Data(24) + g_dAcvReportsTest.Data(25) + g_dAcvReportsTest.Data(26) + g_dAcvReportsTest.Data(27) + g_dAcvReportsTest.Data(28) + g_dAcvReportsTest.Data(29)

        For x = 0 To 9
            If dTotalGrades > 0 Then
                rGrade(x) = g_dAcvReportsTest.Data(x) / dTotalGrades * 100
            Else
                rGrade(x) = 0
            End If

            If dTotalLengths > 0 Then
                rLength(x) = g_dAcvReportsTest.Data(x + 10) / dTotalLengths * 100
            Else
                rLength(x) = 0
            End If

            If dTotalDest > 0 Then
                rDest(x) = g_dAcvReportsTest.Data(x + 20) / dTotalDest * 100
            Else
                rDest(x) = 0
            End If
        Next


        For x = 0 To 9
            If rGrade(x) > 0 Then
                GradeBarChart.Series(x).Points(0).SetValueY(rGrade(x))
                If rGrade(x) > 5 Then
                    GradeBarChart.Series(x).Points(0).Label = "#" & x & ":" & vbCrLf & rGrade(x).ToString(format:="0.0") & "%" & vbCrLf & g_dAcvReportsTest.Data(x) & "pcs"
                Else
                    GradeBarChart.Series(x).Points(0).Label = ""
                End If
            Else
                GradeBarChart.Series(x).Points(0).SetValueY(0)
                GradeBarChart.Series(x).Points(0).Label = ""
                GradeBarChart.Series(x).Points(0).IsVisibleInLegend = 0
            End If
        Next

        For x = 0 To 9
            If rLength(x) > 0 Then
                LenghtBarChart.Series(x).Points(0).SetValueY(rLength(x))
                If rLength(x) > 5 Then
                    LenghtBarChart.Series(x).Points(0).Label = (x + dLenthToStart) * 12 & "in:" & vbCrLf & rLength(x).ToString(format:="0.0") & "%" & vbCrLf & g_dAcvReportsTest.Data(10 + x) & "pcs"
                Else
                    LenghtBarChart.Series(x).Points(0).Label = ""
                End If

            Else
                LenghtBarChart.Series(x).Points(0).SetValueY(0)
                LenghtBarChart.Series(x).Points(0).Label = ""
                LenghtBarChart.Series(x).Points(0).IsVisibleInLegend = 0
            End If
        Next

        For x = 0 To 9
            If rDest(x) > 0 Then
                DestBarChart.Series(x).Points(0).SetValueY(rDest(x))
                DestBarChart.Series(x).Points(0).Label = DestBarChart.Series(x).Name & ":" & vbCrLf & rDest(x).ToString(format:="0.0") & "%" & vbCrLf & g_dAcvReportsTest.Data(20 + x) & "pcs"
            Else
                DestBarChart.Series(x).Points(0).SetValueY(0)
                DestBarChart.Series(x).Points(0).Label = ""
                DestBarChart.Series(x).Points(0).IsVisibleInLegend = 0
            End If
        Next

        'Report Data
        'g_stReportData.dVolumeBoardFtIn /= 1000
        LabelVolumePmp.Text = g_stReportData.dVolumeBoardFtIn & " BF"
        LabelVolumeHour.Text = g_stReportData.dAverageSpeedBoardFtHour & " BF"
        LabelLugFill.Text = g_stReportData.dLugsFilledPercentage & "%"
        LabelVolProj.Text = g_stReportData.dProjectedBoardFt & " BF"
        LabelPiecesIn.Text = g_stReportData.dNbPiecesIn & ""
        LabelPiecesOut.Text = g_stReportData.dNbPiecesOut & ""
        LabelSlashed.Text = g_stReportData.dNbPiecesSlashed & ""
        LabelNbRej.Text = g_stReportData.dNbPiecesRejected & ""

        Dim dTemp As Int32 = (((g_stReportData.dProjectedBoardFt - 300000) / 400000) * 284) + 423
        KpiBar1.Location = New Point(dTemp, 157)

        DateLabel.Text = System.DateTime.Now

    End Sub

    Private Sub TimerMarquee_Tick(sender As Object, e As EventArgs) Handles TimerMarquee.Tick
        'If LabelMarquee.Location.X + LabelMarquee.Width < 0 Then
        'LabelMarquee.Location = New Point(Me.Width, LabelMarquee.Location.Y)
        'Else
        'LabelMarquee.Location = New Point(LabelMarquee.Location.X - TrackBar2.Value, LabelMarquee.Location.Y)
        'End If
        If ScrollingText1.Visible = 1 Then
            'szMarqProdDisp.Invalidate()
            'szMarqProdDisp.Update()
            ScrollingText1.Invalidate()
            ScrollingText1.Update()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Label11.Visible Then
            Label4.Visible = 0
            ComboBox1.Visible = 0
            Label10.Visible = 0
            Label11.Visible = 0
            TrackBar1.Visible = 0
            TrackBar2.Visible = 0
            Label12.Visible = 0
            Label13.Visible = 0
        Else
            Label4.Visible = 1
            ComboBox1.Visible = 1
            Label10.Visible = 1
            Label11.Visible = 1
            TrackBar1.Visible = 1
            TrackBar2.Visible = 1
            Label12.Visible = 1
            Label13.Visible = 1
        End If


    End Sub
End Class