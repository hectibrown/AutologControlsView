Public Class MiniData1

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
    Dim g_stReportData As New StReportData
    Dim g_dSaws As Int32
    Dim g_bSaws(32) As Boolean
    Dim g_dGates As Int32
    Dim g_bGates(32) As Boolean
    Dim g_dCitSkids As Int32
    Dim g_bCitSkids(32) As Boolean
    Dim g_dPc As Int32
    Dim g_bPc(32) As Boolean
    Dim g_dFence As Int32
    Dim g_bFence(32) As Boolean
    Dim g_dBin1to32 As Int32
    Dim g_dBin33to39 As Int32
    Dim g_bBin1to32(32) As Boolean
    Dim g_bBin33to39(32) As Boolean
    Dim g_bTemp1(32) As Boolean
    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    '***************************************************************
    '* .NET does not close hidden forms, so do it here
    '* to make sure forms are disposed and drivers close
    '***************************************************************
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim index As Integer
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'InitializeComponent()
        Timer100.Interval = 10
        Timer100.Start()
        Timer500.Interval = 500
        Timer500.Start()
        Timer1000.Interval = 1000
        Timer1000.Start()
        Timer10000.Interval = 10000
        Timer10000.Start()
        dMessageLoadStep = 0
        CommsOk.Visible = 0
    End Sub

    Private Sub DataSubscriber22_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber22.DataChanged

        'Watchdog
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

        'Display
        szSorterDisplay.Text = DataSubscriber22.PLCAddressValueItems(3).LastValue
        'szLTSDisplay.Text = DataSubscriber22.PLCAddressValueItems(4).LastValue
    End Sub

    Private Sub Timer1000_Tick(sender As Object, e As EventArgs) Handles Timer1000.Tick
        Dim dTemp As Int32
        dTemp = g_stReportData.dVolumeBoardFtIn / 1000
        LabelVolumePmp.Text = dTemp.ToString(format:="0") & " BF"
        LabelVolumeHour.Text = g_stReportData.dAverageSpeedBoardFtHour & " BF"
        LabelLugFill.Text = g_stReportData.dLugsFilledPercentage & "%"
        LabelVolProj.Text = g_stReportData.dProjectedBoardFt & " BF"
        LabelPiecesIn.Text = g_stReportData.dNbPiecesIn & ""
        LabelPiecesOut.Text = g_stReportData.dNbPiecesOut & ""
        LabelSlashed.Text = g_stReportData.dNbPiecesSlashed & ""
        LabelNbRej.Text = g_stReportData.dNbPiecesRejected & ""

    End Sub

    Private Sub Timer10000_Tick(sender As Object, e As EventArgs) Handles Timer10000.Tick
        If g_bCommsOk Then
            Try
                'g_dACVReportsTest = EthernetIPforCLXCom1.ReadUDT(Of stACVReportsTest)("g_stACVReportsTest")
                g_stReportData = EthernetIPforCLXCom1.ReadUDT(Of StReportData)("g_par.ReportData")


            Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                g_dCommError = ex.ErrorCode
                If g_dCommError <> 0 Then
                    CommsOk.Visible = 0
                    DataSubscriber22.PLCAddressValueItems(0).LastValue = 0
                    Exit Sub
                End If
            End Try
        End If
    End Sub

    Private Sub DataSubscriber21_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber21.DataChanged
        'Saws 
        g_dSaws = DataSubscriber21.PLCAddressValueItems(0).LastValue
        'Gates
        g_dGates = DataSubscriber21.PLCAddressValueItems(1).LastValue
        'Cit SKids
        g_dCitSkids = DataSubscriber21.PLCAddressValueItems(2).LastValue
        'Pc
        g_dPc = DataSubscriber21.PLCAddressValueItems(3).LastValue
        'Fence
        g_dFence = DataSubscriber21.PLCAddressValueItems(4).LastValue
        'Bins
        g_dBin1to32 = DataSubscriber21.PLCAddressValueItems(5).LastValue
        g_dBin33to39 = DataSubscriber21.PLCAddressValueItems(6).LastValue
    End Sub

    Private Function byteToBits(ByVal byteToConvert As Int32) As String
        'Takes a byte and converts it
        'to a string of 1s (ones) and 0s (zeros)
        'representing the number in binary notation
        'Byte variable to hold the shifted bit

        Dim shiftByte As Int32
        'Set to 1 or, more importantly, 00000001
        shiftByte = 1
        'Byte variable to hold a temporary byte

        Dim tempByte As Int32
        tempByte = 0
        'String variables to hold working strings

        Dim testBit As String = ""
        Dim result As String = ""
        'Loop 8 times with i counting
        'down from 7 to 0
        For i As Integer = 31 To 0 Step -1
            'Reset shiftByte to 1
            shiftByte = 1
            'Each time through the loop 1 is shifted
            ' i times to the left in shiftByte
            ' eg. shiftByte is 00000001
            ' the bits are shifted by i places
            ' if i is 3 then shiftByte will be 00001000
            ' tempByte becomes shiftByte ANDed with the 
            ' byteToConvert. 
            tempByte = (shiftByte << i) And byteToConvert
            'Test if the result of above is 0 (zero)
            If tempByte = 0 Then
                'Will be 0 if there is a 0
                'at the same position in the 
                'byteToConvert where the 1 is currently in the
                'shiftByte
                testBit = "0"
            Else
                testBit = "1"
            End If
            'Append the "0" or "1" to build up the result string

            result = result & testBit

        Next
        'And return it
        'Return result
        Dim y As Int32 = 0
        For x As Int32 = 31 To 0 Step -1
            If result.Chars(x) = "1" Then
                'g_bTemp.SetValue(True, i)
                g_bTemp1(y) = 1
            Else
                'g_bTemp.SetValue(False, i)
                g_bTemp1(y) = 0
            End If
            y += 1
        Next
        Dim bTemp As Boolean = g_bTemp1(0)
    End Function

    Private Sub Timer100_Tick(sender As Object, e As EventArgs) Handles Timer100.Tick
        Dim Saws() As Button = New Button(10) {Saw0ft, Saw2ft, Saw4ft, Saw6ft, Saw8ft, Saw10ft, Saw12ft, Saw14ft, Saw16ft, Saw18ft, Saw20ft}
        Dim Gates() As Button = New Button(7) {Gate0, Gate1, Gate2, Gate3, Gate4, Gate5, Gate6, Gate7}
        Dim Cit() As Button = New Button(3) {Cit0, Cit1, Cit2, Cit3}
        Dim Pc() As Button = New Button(8) {Pc0, Pc6, Pc8, Pc10, Pc12, Pc14, Pc16, Pc18, Pc20}
        Dim Fence() As Button = New Button(11) {Fence0, Fence1, Fence2, Fence3, Fence4, Fence5, Fence6, Fence7, Fence8, Fence9, Fence10, Fence11}
        Dim Bin1to32() As Button = New Button(31) {Bin1, Bin2, Bin3, Bin4, Bin5, Bin6, Bin7, Bin8, Bin9, Bin10, Bin11, Bin12, Bin13, Bin14, Bin15, Bin16, Bin17, Bin18, Bin19, Bin20, Bin21, Bin22, Bin23, Bin24, Bin25, Bin26, Bin27, Bin28, Bin29, Bin30, Bin31, Bin32}
        Dim Bin33to39() As Button = New Button(6) {Bin33, Bin34, Bin35, Bin36, Bin37, Bin38, Bin39}
        'Saws
        Call byteToBits(g_dSaws)
        g_bSaws = g_bTemp1
        For i As Int32 = 0 To 10
            If g_bSaws(i) Then
                Saws(i).BackColor = Color.Green
            Else
                Saws(i).BackColor = Color.Gray
            End If
        Next

        'Gates
        Call byteToBits(g_dGates)
        g_bGates = g_bTemp1
        For i As Int32 = 0 To 7
            If g_bGates(i) Then
                Gates(i).BackColor = Color.Green
            Else
                Gates(i).BackColor = Color.Gray
            End If
        Next
        'Cit SKids
        Call byteToBits(g_dCitSkids)
        g_bCitSkids = g_bTemp1
        For i As Int32 = 0 To 3
            If g_bCitSkids(i) Then
                Cit(i).BackColor = Color.Green
            Else
                Cit(i).BackColor = Color.Gray
            End If
        Next
        'PC
        Call byteToBits(g_dPc)
        g_bPc = g_bTemp1
        For i As Int32 = 0 To 8
            If g_bPc(i) Then
                Pc(i).BackColor = Color.Green
            Else
                Pc(i).BackColor = Color.Gray
            End If
        Next
        'Fence
        Call byteToBits(g_dFence)
        g_bFence = g_bTemp1
        For i As Int32 = 0 To 8
            If g_bFence(i) Then
                Fence(i).BackColor = Color.Green
            Else
                Fence(i).BackColor = Color.Gray
            End If
        Next
        'bin
        Call byteToBits(g_dBin1to32)
        g_bBin1to32 = g_bTemp1
        For i As Int32 = 0 To 31
            If g_bBin1to32(i) Then
                Bin1to32(i).BackColor = Color.Green
            Else
                Bin1to32(i).BackColor = Color.Gray
            End If
        Next
        Call byteToBits(g_dBin33to39)
        g_bBin33to39 = g_bTemp1
        For i As Int32 = 0 To 6
            If g_bBin33to39(i) Then
                Bin33to39(i).BackColor = Color.Green
            Else
                Bin33to39(i).BackColor = Color.Gray
            End If
        Next
    End Sub
End Class
