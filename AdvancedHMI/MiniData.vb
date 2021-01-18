Public Class MiniData

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
        szLTSDisplay.Text = DataSubscriber22.PLCAddressValueItems(4).LastValue
    End Sub

    Private Sub Timer1000_Tick(sender As Object, e As EventArgs) Handles Timer1000.Tick
        LabelVolumePmp.Text = g_stReportData.dVolumeBoardFtIn & " BF"
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


End Class
