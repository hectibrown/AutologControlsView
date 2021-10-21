Public Class HomeDashBoard  'As System.Windows.Forms.UserControl
    'To create a User Control to export to another project use the following line:
    'Inherits System.Windows.Forms.UserControl
    'Use the following guide to setup the server:
    'https://www.codeproject.com/Questions/1228587/How-to-host-windows-form-application-in-web-ASP-NE
    'https://www.c-sharpcorner.com/article/using-a-windows-application-on-the-web/

    Public g_stAcv As New StAcvMain
    Public stAlarm As New StAlarms
    Dim szString(249) As String
    Dim g_dAcvReportsTest As New StACVReportsTest
    Dim g_stReportData As New StReportData
    Dim g_szNewMsg As String
    Dim g_stAcvError As New StAcvError
    Dim g_szDest(1) As String
    Dim g_RxAcvComm As New StAcvComm
    Dim g_dAcvTxMsgNb As New Int32

    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    'NEW MESSAGE MANAGER
    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************

    Private Sub DataSubscriber22_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber22.DataChanged
        EthernetIPforCLXCom1.PollRateOverride = 45 'Must be a multiple of PLC Scan Time - LEB8282 = 15ms
        g_stAcv.dWatchDog = CInt(DataSubscriber22.PLCAddressValueItems(0).LastValue)
        g_stAcv.dNbAlarms = CInt(DataSubscriber22.PLCAddressValueItems(1).LastValue)
        g_stAcv.dConnected = CInt(DataSubscriber22.PLCAddressValueItems(2).LastValue)
        g_stAcv.dLugIdxHistory = CInt(DataSubscriber22.PLCAddressValueItems(3).LastValue)
        g_stAcv.dRxMsgNb = (DataSubscriber22.PLCAddressValueItems(4).LastValue)

        If g_stAcv.dWatchDog <> g_stAcv.dOldWatchDog Then
            CommsOk.Visible = True
            g_stAcv.bCommsOk = True
            g_stAcv.dOldWatchDog = g_stAcv.dWatchDog
        Else
            CommsOk.Visible = False
            g_stAcv.bCommsOk = False
        End If

        If g_stAcv.dRxMsgNb <> g_stAcv.dOldMsgNb And g_stAcv.bCommsOk And g_stAcv.dMessegeLoadStep = 3 Then
            Try
                g_RxAcvComm = EthernetIPforCLXCom1.ReadUDT(Of StAcvComm)("g_TxAcvComm")
            Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                g_stAcv.dCommErrorCode = ex.ErrorCode
                If g_stAcv.dCommErrorCode <> 0 Then
                    LabelDebug.Text = g_stAcv.dCommErrorCode
                    Exit Sub
                End If
            End Try
            If g_RxAcvComm.Data(1) = 4 Or g_bKeepAlarmsUp Or g_stAcv.dNbAlarms > 0 Then
                g_bKeepAlarmsUp = True
                Call FbAlarms()
            ElseIf g_RxAcvComm.Data(1) = 1 Then
                Call FbHistoryTest1()
            ElseIf g_RxAcvComm.Data(1) = 2 Then
                Call FbReportData()
            ElseIf g_RxAcvComm.Data(1) = 3 Then
                Call FbErrorPercent()
            End If
            g_stAcv.dOldMsgNb = g_stAcv.dRxMsgNb
            LabelSorterSpeed.Text = g_RxAcvComm.Data(98) & "Lugs/min"
            LabelMsgNb.Text = g_stAcv.dRxMsgNb
            EthernetIPforCLXCom1.Write("g_stAcv.dRxMsgNb", g_stAcv.dRxMsgNb)
        End If

        If g_stAcv.dNbAlarms = 0 And g_bKeepAlarmsUp Then
            Call FbAlarms()
        End If

        LabelDebug.Text = g_stAcv.dMessegeLoadStep
        ScrollingText1.TextScrollDistance = TrackBar2.Value
        ScrollingText1.TextScrollSpeed = TrackBar1.Value
        Label12.Text = TrackBar1.Value
        Label13.Text = TrackBar2.Value


    End Sub


    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    'SECTION HISTORIQUE
    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    Dim g_bPauseHistory As Int32

    Public Sub FbHistoryTest1()

        Dim timeStamp1 As DateTime = DateTime.Now
        Dim _InRxCom(19) As Int32

        For x = 2 To 19 Step 1
            _InRxCom(x - 2) = g_RxAcvComm.Data(x)
        Next
        Call DestToString(_InRxCom(2), _InRxCom(3))
        If _InRxCom(1) <> 0 And (_InRxCom(0) = _InRxCom(15)) And Not g_bPauseHistory Then
            Me.History.Rows.Insert(0, timeStamp1,
                                             _InRxCom(0),
                                             _InRxCom(1),
                                             g_szDest(1),
                                             g_szDest(0),
                                             _InRxCom(4),
                                             _InRxCom(5),
                                             CStr(_InRxCom(6) / 1000) & " in x " & CStr(_InRxCom(7) / 1000) & " in x " & CStr(_InRxCom(8) / 10) & " in",
                                             _InRxCom(9) & " / " & _InRxCom(10) & " / " & _InRxCom(11) & " - " & _InRxCom(12),
                                             _InRxCom(13) & " / " & _InRxCom(14)
                                             )
        End If
        'Limit de ranges du tableau
        If History.Rows.Count > 30 Then
            Me.History.Rows.Remove(History.Rows(29))
        End If
    End Sub

    Private Sub History_Click(sender As Object, e As EventArgs) Handles History.Click
        If Not g_bPauseHistory Then
            g_bPauseHistory = True
        Else
            g_bPauseHistory = False
        End If
    End Sub

    Sub DestToString(dDestSorter As Int32, dDestOpti As Int32)
        Select Case dDestSorter
            Case 0
                g_szDest(0) = "Rejet"
            Case 1
                g_szDest(0) = "Classeur"
            Case 3
                g_szDest(0) = "Deshiqueteuse"
            Case 4
                g_szDest(0) = "Reman"
            Case 5
                g_szDest(0) = "Reedge"
            Case 6
                g_szDest(0) = "Resaw"
            Case 7
                g_szDest(0) = "Bois courte"
            Case 10
                g_szDest(0) = "Refente"
        End Select
        Select Case dDestOpti
            Case 0
                g_szDest(1) = "Rejet"
            Case 1
                g_szDest(1) = "Classeur"
            Case 2
                g_szDest(1) = "Deshiqueteuse"
            Case 4
                g_szDest(1) = "Reman"
            Case 5
                g_szDest(1) = "Reedge"
            Case 6
                g_szDest(1) = "Resaw"
            Case 7
                g_szDest(1) = "Bois courte"
            Case 10
                g_szDest(1) = "Refente"
        End Select
    End Sub

    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    'INTERLOCKS / LINE ERRORS / MESSAGES
    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************

    Dim g_bKeepAlarmsUp As Boolean
    Dim dActiveInterlocks(19) As Int32
    Dim dActiveIntlkDetail(19) As Int32
    Dim dActiveMsgs(19) As Int32
    Dim dActiveMsgDetail(19) As Int32
    Public Sub FbAlarms()
        If g_RxAcvComm.Data(1) = 4 Then
            For dIdx = 0 To 249
                stAlarm.bBits.bIntlk(dIdx) = 0
                stAlarm.bBits.bMsg(dIdx) = 0
            Next
            Array.Copy(g_RxAcvComm.Data, 2, dActiveInterlocks, 0, 20)
            Array.Copy(g_RxAcvComm.Data, 22, dActiveIntlkDetail, 0, 20)
            Array.Copy(g_RxAcvComm.Data, 42, dActiveMsgs, 0, 20)
            Array.Copy(g_RxAcvComm.Data, 62, dActiveMsgDetail, 0, 20)
            stAlarm.bBits.dLineError = g_RxAcvComm.Data(82)
            stAlarm.IdDetail.dLeIdDetail = g_RxAcvComm.Data(83)
            For i = 0 To 19 Step 1
                If dActiveInterlocks(i) > -1 Then
                    stAlarm.bBits.bIntlk(dActiveInterlocks(i)) = True
                    stAlarm.IdDetail.dIntlkIdDetail(dActiveInterlocks(i)) = dActiveIntlkDetail(i)
                End If
                If dActiveMsgs(i) > -1 Then
                    stAlarm.bBits.bMsg(dActiveMsgs(i)) = True
                    stAlarm.IdDetail.dMsgIdDetail(dActiveMsgs(i)) = dActiveMsgDetail(i)
                End If
            Next
        End If

        If g_stAcv.dNbAlarms > 0 Then
            Call FbCheckAlarms()
            g_stAcv.dOldNbAlarms = g_stAcv.dNbAlarms
            ScrollingText1.ScrollText = Me.DataGridView1.Rows(0).Cells(0).Value 'g_stAcv.szAlarm
            ScrollingText1.Visible = 1
            Panel2.Visible = 1
            Panel2.BringToFront()
            DataGridView1.Visible = 1
        Else
            History.BringToFront()
            ScrollingText1.Visible = 0
            Panel2.Visible = 0
            Panel2.Visible = 0
            DataGridView1.Visible = 0
            History.Visible = 1
            History.BringToFront()
            g_bKeepAlarmsUp = False
        End If
    End Sub

    Public Sub FbCheckAlarms()
        Dim dIdx As Int32 = 0
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView1.Invalidate()
        If stAlarm.bBits.dLineError > 0 Then
            If stAlarm.IdDetail.dLeIdDetail > 0 Then
                Call FindStars(stAlarm.szString.szLineError(stAlarm.bBits.dLineError), dIdx, "LE", stAlarm.IdDetail.dLeIdDetail)
                Me.DataGridView1.Rows.Insert(0, g_szNewMsg)
            Else
                Me.DataGridView1.Rows.Insert(0, stAlarm.szString.szLineError(stAlarm.bBits.dLineError))
            End If
        End If
        For dIdx = 249 To 0 Step -1
            If stAlarm.bBits.bMsg(dIdx) Then
                If stAlarm.IdDetail.dMsgIdDetail(dIdx) > 0 Then
                    Call FindStars(stAlarm.szString.szMsg(dIdx), dIdx, "Msg", stAlarm.IdDetail.dMsgIdDetail(dIdx))
                    Me.DataGridView1.Rows.Insert(0, g_szNewMsg)
                Else
                    Me.DataGridView1.Rows.Insert(0, stAlarm.szString.szMsg(dIdx))
                End If
            End If
        Next
        For dIdx = 249 To 0 Step -1
            If stAlarm.bBits.bIntlk(dIdx) Then
                If stAlarm.IdDetail.dIntlkIdDetail(dIdx) > 0 Then
                    Call FindStars(stAlarm.szString.szIntlk(dIdx), dIdx, "INTLK", stAlarm.IdDetail.dIntlkIdDetail(dIdx))
                    Me.DataGridView1.Rows.Insert(0, g_szNewMsg)
                Else
                    Me.DataGridView1.Rows.Insert(0, stAlarm.szString.szIntlk(dIdx))
                End If
            End If

        Next
    End Sub

    Sub FindStars(szMessage As String, dIdx As Int32, szErrorTyp As String, dIdDetail As Int32)
        Dim szNewMessage As String = szMessage
        Dim szIdDetail As String = dIdDetail
        If szErrorTyp = "INTLK" Then
            If szNewMessage.Contains("****") Then
                g_szNewMsg = szNewMessage.Replace("****", szIdDetail)
            ElseIf szNewMessage.Contains("***") Then
                g_szNewMsg = szNewMessage.Replace("***", szIdDetail)
            ElseIf szNewMessage.Contains("**") Then
                g_szNewMsg = szNewMessage.Replace("**", szIdDetail)
            ElseIf szNewMessage.Contains("*") Then
                g_szNewMsg = szNewMessage.Replace("*", szIdDetail)
            Else
                g_szNewMsg = szMessage
            End If
        ElseIf szErrorTyp = "LE" Then
            If szNewMessage.Contains("****") Then
                g_szNewMsg = szNewMessage.Replace("****", szIdDetail)
            ElseIf szNewMessage.Contains("***") Then
                g_szNewMsg = szNewMessage.Replace("***", szIdDetail)
            ElseIf szNewMessage.Contains("**") Then
                g_szNewMsg = szNewMessage.Replace("**", szIdDetail)
            ElseIf szNewMessage.Contains("*") Then
                g_szNewMsg = szNewMessage.Replace("*", szIdDetail)
            Else
                g_szNewMsg = szMessage
            End If
        ElseIf szErrorTyp = "MSG" Then
            If szNewMessage.Contains("****") Then
                g_szNewMsg = szNewMessage.Replace("****", szIdDetail)
            ElseIf szNewMessage.Contains("***") Then
                g_szNewMsg = szNewMessage.Replace("***", szIdDetail)
            ElseIf szNewMessage.Contains("**") Then
                g_szNewMsg = szNewMessage.Replace("**", szIdDetail)
            ElseIf szNewMessage.Contains("*") Then
                g_szNewMsg = szNewMessage.Replace("*", szIdDetail)
            Else
                g_szNewMsg = szMessage
            End If
        End If
    End Sub

    Private Sub TimerMarquee_Tick(sender As Object, e As EventArgs) Handles TimerMarquee.Tick
        If ScrollingText1.Visible = 1 Then
            ScrollingText1.Invalidate()
            ScrollingText1.Update()
        End If
    End Sub

    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    'error percent/max
    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    Public Sub FbErrorPercent()

        g_stAcvError.ErrorPercent.rPresTrimNoPres = g_RxAcvComm.Data(2)
        g_stAcvError.ErrorPercent.rPresTrimNoSoln = g_RxAcvComm.Data(3)
        g_stAcvError.ErrorPercent.rRxOptiTooManySlash = g_RxAcvComm.Data(4)
        g_stAcvError.ErrorPercent.rRxOptiTooManyReman = g_RxAcvComm.Data(5)
        g_stAcvError.ErrorPercent.rRxOptiTooManyResaw = g_RxAcvComm.Data(6)
        g_stAcvError.ErrorPercent.rRxOptiTooManyReedge = g_RxAcvComm.Data(7)
        g_stAcvError.ErrorPercent.rRxOptiTooManyRejects = g_RxAcvComm.Data(8)
        g_stAcvError.ErrorPercent.rRxOptiSolnTooLate = g_RxAcvComm.Data(9)
        g_stAcvError.ErrorPercent.rLsConfLs0 = g_RxAcvComm.Data(10)
        g_stAcvError.ErrorPercent.rLsConfTooLong = g_RxAcvComm.Data(11)
        g_stAcvError.ErrorPercent.rLsCOnfTooShort = g_RxAcvComm.Data(12)
        g_stAcvError.ErrorPercent.rLsConfNotEqual = g_RxAcvComm.Data(13)
        g_stAcvError.ErrorPercent.rPresSorterShortGate = g_RxAcvComm.Data(14)
        g_stAcvError.ErrorPercent.rPresSorterRemanGate = g_RxAcvComm.Data(15)
        g_stAcvError.ErrorPercent.rPresSorterTooManyRejects = g_RxAcvComm.Data(16)
        g_stAcvError.ErrorPercent.rPresSorterNoPres = g_RxAcvComm.Data(17)
        g_stAcvError.ErrorPercent.rLostPieceKicker = g_RxAcvComm.Data(18)

        g_stAcvError.ErrorMax.rPresTrimNoPres = g_RxAcvComm.Data(20)
        g_stAcvError.ErrorMax.rPresTrimNoSoln = g_RxAcvComm.Data(21)
        g_stAcvError.ErrorMax.rRxOptiTooManySlash = g_RxAcvComm.Data(22)
        g_stAcvError.ErrorMax.rRxOptiTooManyReman = g_RxAcvComm.Data(23)
        g_stAcvError.ErrorMax.rRxOptiTooManyResaw = g_RxAcvComm.Data(24)
        g_stAcvError.ErrorMax.rRxOptiTooManyReedge = g_RxAcvComm.Data(25)
        g_stAcvError.ErrorMax.rRxOptiTooManyRejects = g_RxAcvComm.Data(26)
        g_stAcvError.ErrorMax.rRxOptiSolnTooLate = g_RxAcvComm.Data(27)
        g_stAcvError.ErrorMax.rLsConfLs0 = g_RxAcvComm.Data(28)
        g_stAcvError.ErrorMax.rLsConfTooLong = g_RxAcvComm.Data(29)
        g_stAcvError.ErrorMax.rLsCOnfTooShort = g_RxAcvComm.Data(30)
        g_stAcvError.ErrorMax.rLsConfNotEqual = g_RxAcvComm.Data(31)
        g_stAcvError.ErrorMax.rPresSorterShortGate = g_RxAcvComm.Data(32)
        g_stAcvError.ErrorMax.rPresSorterRemanGate = g_RxAcvComm.Data(33)
        g_stAcvError.ErrorMax.rPresSorterTooManyRejects = g_RxAcvComm.Data(34)
        g_stAcvError.ErrorMax.rPresSorterNoPres = g_RxAcvComm.Data(35)
        g_stAcvError.ErrorMax.rLostPieceKicker = g_RxAcvComm.Data(36)

        'OptiSLash
        ErrorBarOptiSLash.Maximum = g_stAcvError.ErrorMax.rRxOptiTooManySlash
        If ErrorBarOptiSLash.Maximum > 0 Then
            ErrorBarOptiSLash.Value = g_stAcvError.ErrorPercent.rRxOptiTooManySlash
        Else
            ErrorBarOptiSLash.Value = 0
        End If
        Dim rPercent As Single = g_stAcvError.ErrorPercent.rRxOptiTooManySlash / g_stAcvError.ErrorMax.rRxOptiTooManySlash
        If rPercent > 0.8 Then
            ErrorBarOptiSLash.ForeColor = Color.Red
        ElseIf rPercent > 0.5 Then
            ErrorBarOptiSLash.ForeColor = Color.Coral
        Else
            ErrorBarOptiSLash.ForeColor = Color.Gold
        End If
        'Opti Reman
        ErrorBarOptiReman.Maximum = g_stAcvError.ErrorMax.rRxOptiTooManyReman
        If ErrorBarOptiReman.Maximum > 0 Then
            ErrorBarOptiReman.Value = g_stAcvError.ErrorPercent.rRxOptiTooManyReman
        Else
            ErrorBarOptiReman.Value = 0
        End If
        rPercent = g_stAcvError.ErrorPercent.rRxOptiTooManyReman / g_stAcvError.ErrorMax.rRxOptiTooManyReman
        If rPercent > 0.8 Then
            ErrorBarOptiReman.ForeColor = Color.Red
        ElseIf rPercent > 0.5 Then
            ErrorBarOptiReman.ForeColor = Color.Coral
        Else
            ErrorBarOptiReman.ForeColor = Color.Gold
        End If
        'Opti Reedge
        ErrorBarOptiReedge.Maximum = g_stAcvError.ErrorMax.rRxOptiTooManyReedge
        If ErrorBarOptiReedge.Maximum > 0 Then
            ErrorBarOptiReedge.Value = g_stAcvError.ErrorPercent.rRxOptiTooManyReedge
        Else
            ErrorBarOptiReedge.Value = 0
        End If
        rPercent = g_stAcvError.ErrorPercent.rRxOptiTooManyReedge / g_stAcvError.ErrorMax.rRxOptiTooManyReedge
        If rPercent > 0.8 Then
            ErrorBarOptiReedge.ForeColor = Color.Red
        ElseIf rPercent > 0.5 Then
            ErrorBarOptiReedge.ForeColor = Color.Coral
        Else
            ErrorBarOptiReedge.ForeColor = Color.Gold
        End If
        'Opti Resaw
        ErrorBarOptiResaw.Maximum = g_stAcvError.ErrorMax.rRxOptiTooManyResaw
        If ErrorBarOptiResaw.Maximum > 0 Then
            ErrorBarOptiResaw.Value = g_stAcvError.ErrorPercent.rRxOptiTooManyResaw
        Else
            ErrorBarOptiResaw.Value = 0
        End If
        rPercent = g_stAcvError.ErrorPercent.rRxOptiTooManyResaw / g_stAcvError.ErrorMax.rRxOptiTooManyResaw
        If rPercent > 0.8 Then
            ErrorBarOptiResaw.ForeColor = Color.Red
        ElseIf rPercent > 0.5 Then
            ErrorBarOptiResaw.ForeColor = Color.Coral
        Else
            ErrorBarOptiResaw.ForeColor = Color.Gold
        End If
        'Opti Reject
        ErrorBarSorterRejects.Maximum = g_stAcvError.ErrorMax.rPresSorterTooManyRejects
        If ErrorBarSorterRejects.Maximum > 0 Then
            ErrorBarSorterRejects.Value = g_stAcvError.ErrorPercent.rPresSorterTooManyRejects
        Else
            ErrorBarSorterRejects.Value = 0
        End If
        rPercent = g_stAcvError.ErrorPercent.rPresSorterTooManyRejects / g_stAcvError.ErrorMax.rPresSorterTooManyRejects
        If rPercent > 0.8 Then
            ErrorBarSorterRejects.ForeColor = Color.Red
        ElseIf rPercent > 0.5 Then
            ErrorBarSorterRejects.ForeColor = Color.Coral
        Else
            ErrorBarSorterRejects.ForeColor = Color.Gold
        End If
    End Sub


    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    'Donnees de rapports
    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    Public Sub FbReportData()
        g_stReportData.dVolumeBoardFtIn = g_RxAcvComm.Data(2)
        g_stReportData.dAverageSpeedBoardFtHour = g_RxAcvComm.Data(3)
        g_stReportData.dLugsFilledPercentage = g_RxAcvComm.Data(4)
        g_stReportData.dProjectedBoardFt = g_RxAcvComm.Data(5)
        g_stReportData.dNbPiecesIn = g_RxAcvComm.Data(6)
        g_stReportData.dNbPiecesOut = g_RxAcvComm.Data(7)
        g_stReportData.dNbPiecesSlashed = g_RxAcvComm.Data(8)
        g_stReportData.dNbPiecesRejected = g_RxAcvComm.Data(9)

        LabelVolumePmp.Text = g_stReportData.dVolumeBoardFtIn & " BF"
        LabelVolumeHour.Text = g_stReportData.dAverageSpeedBoardFtHour & " BF"
        LabelLugFill.Text = g_stReportData.dLugsFilledPercentage & "%"
        LabelVolProj.Text = g_stReportData.dProjectedBoardFt & " BF"
        LabelPiecesIn.Text = g_stReportData.dNbPiecesIn & ""
        LabelPiecesOut.Text = g_stReportData.dNbPiecesOut & ""
        LabelSlashed.Text = g_stReportData.dNbPiecesSlashed & ""
        LabelNbRej.Text = g_stReportData.dNbPiecesRejected & ""

        Dim dTemp As Int32
        If g_stReportData.dProjectedBoardFt > 200000 Then
            dTemp = (((g_stReportData.dProjectedBoardFt - 200000) / 100000) * 284) + 400
        Else
            dTemp = 400
        End If
        KpiBar1.Location = New Point(dTemp, 157)
    End Sub

    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    'MODE TEST SCROLL SANS PLC
    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
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

    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    'ALARM MESSAGE STRING LOADER
    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    Private Sub UpdateMesssagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateMesssagesToolStripMenuItem.Click
        Timer2000.Interval = 2000
        Timer2000.Start()
        g_stAcv.dMessegeLoadStep = 0
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer2000.Tick
        If g_stAcv.bCommsOk Then
            Call LoadMessages()
        End If
    End Sub

    Public Sub LoadMessages()
        Select Case g_stAcv.dMessegeLoadStep
            Case 0
                Try
                    szString = EthernetIPforCLXCom1.Read("g_stAlarm.String.Intlk", 250) '("g_HMI_szAlarmHistory.String.Intlk", 250) 
                    stAlarm.szString.szIntlk = szString
                    g_stAcv.dMessegeLoadStep += 1
                Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                    g_stAcv.dCommErrorCode = ex.ErrorCode
                    If g_stAcv.dCommErrorCode <> 0 Then
                        CommsOk.Visible = 0
                    End If
                End Try
            Case 1
                Try
                    szString = EthernetIPforCLXCom1.Read("g_stAlarm.String.Msg", 250)
                    stAlarm.szString.szMsg = szString
                    g_stAcv.dMessegeLoadStep += 1
                Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                    g_stAcv.dCommErrorCode = ex.ErrorCode
                    If g_stAcv.dCommErrorCode <> 0 Then
                        CommsOk.Visible = 0
                        DataSubscriber22.PLCAddressValueItems(0).LastValue = 0
                    End If
                End Try
            Case 2
                Try
                    szString = EthernetIPforCLXCom1.Read("g_stAlarm.String.LineError", 250)
                    stAlarm.szString.szLineError = szString
                    g_stAcv.dMessegeLoadStep += 1
                Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                    g_stAcv.dCommErrorCode = ex.ErrorCode
                    If g_stAcv.dCommErrorCode <> 0 Then
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

    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    'AUX COMM CHECKS AND OTHER
    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    Private Sub HomeDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'InitializeComponent()
        TimerMarquee.Interval = 5
        TimerMarquee.Start()
        TimerMarquee.Enabled = True
        ComboBox1.Text = "Off"
        g_stAcv.dMessegeLoadStep = 0
        CommsOk.Visible = 0

        Label4.Visible = 0
        ComboBox1.Visible = 0
        Label10.Visible = 0
        Label11.Visible = 0
        TrackBar1.Visible = 0
        TrackBar2.Visible = 0
        Label12.Visible = 0
        Label13.Visible = 0
        ScrollingText1.Visible = 0
    End Sub

    Private Sub EthernetIPforCLXCom1_ConnectionEstablished(sender As Object, e As EventArgs) Handles EthernetIPforCLXCom1.ConnectionEstablished
        Timer2000.Interval = 2000
        Timer2000.Start()
        g_stAcv.dConnected = 1
    End Sub

    Private Sub EthernetIPforCLXCom1_ConnectionClosed(sender As Object, e As EventArgs) Handles EthernetIPforCLXCom1.ConnectionClosed
        g_stAcv.dConnected = 0
        g_stAcv.bCommsOk = 0
    End Sub
    Private Sub EthernetIPforCLXCom1_ComError(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles EthernetIPforCLXCom1.ComError
        g_stAcv.dConnected = 0
        g_stAcv.bCommsOk = 0
    End Sub


    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************
    'OLD PROGRAMME
    '***************************************************************************************************************************************************
    '***************************************************************************************************************************************************

    'Private Sub Timer10000_Tick(sender As Object, e As EventArgs) Handles Timer10000.Tick
    Public Sub OldProgramme()
        Dim dTotalGrades As Int32
        Dim dTotalLengths As Int32
        Dim dTotalDest As Int32
        Dim rGrade(9) As Double
        Dim rLength(9) As Double
        Dim rDest(9) As Double
        Dim dLenthToStart As Int32 = 8


        dTotalGrades = g_dAcvReportsTest.Data(1) + g_dAcvReportsTest.Data(2) + g_dAcvReportsTest.Data(3) + g_dAcvReportsTest.Data(4) + g_dAcvReportsTest.Data(5) + g_dAcvReportsTest.Data(6)
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

        Dim dTemp As Int32 = (((g_stReportData.dProjectedBoardFt - 300000) / 200000) * 284) + 423
        KpiBar1.Location = New Point(dTemp, 157)

    End Sub

End Class

