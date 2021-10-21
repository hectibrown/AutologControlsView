'Option Strict On
'Option Explicit On


Public Class BinControl

    Public g_stAcv As New StAcvMain
    Public g_bCommsOk As New Boolean
    Public g_dLastValueWatchDog As New Int32
    Public g_Bin As New StBin
    Public dBinIdx As Int32
    Public BinMisc(100) As StBinMisc
    Public BinPv As New StBinPv



    Private Sub BinControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 50
        Timer1.Start()
        CommsOk.Visible = 0
        If BinGrid.Rows.Count = 0 Then
            BinGrid.Rows.Add(65)
        End If
        For dBinIdx = 0 To 99
            If g_Bin.Data(dBinIdx) Is Nothing Then
                Dim stBinData As StBinData = New StBinData
                g_Bin.Data(dBinIdx) = stBinData
                g_Bin.Data(dBinIdx).dBinNo = dBinIdx + 1

            End If
            If BinMisc(dBinIdx) Is Nothing Then
                Dim stBinMisc As StBinMisc = New StBinMisc
                BinMisc(dBinIdx) = stBinMisc

            End If
        Next
        dBinIdx = 0
    End Sub

    Private Sub DataSubscriber22_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber22.DataChanged
        g_stAcv.dWatchDog = CInt(DataSubscriber22.PLCAddressValueItems(0).LastValue)
        g_stAcv.dNbAlarms = CInt(DataSubscriber22.PLCAddressValueItems(1).LastValue)
        g_stAcv.dLugIdxHistory = CInt(DataSubscriber22.PLCAddressValueItems(2).LastValue)
        g_stAcv.dConnected = CInt(DataSubscriber22.PLCAddressValueItems(3).LastValue)
        g_stAcv.szAlarm = (DataSubscriber22.PLCAddressValueItems(4).LastValue)
        If g_stAcv.dWatchDog <> g_dLastValueWatchDog Then
            CommsOk.Visible = True
            g_bCommsOk = True
            g_dLastValueWatchDog = g_stAcv.dWatchDog
        Else
            CommsOk.Visible = False
            g_bCommsOk = False

        End If
        szSorterDisplay.Text = g_stAcv.szAlarm

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dErrorCode As Int32
        Dim dmessage As String
        If g_bCommsOk Then
            Try
                BinMisc(dBinIdx) = EthernetIPforCLXCom1.ReadUDT(Of StBinMisc)("g_stAcvBin[" & dBinIdx & "]")
            Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                dErrorCode = ex.ErrorCode
                dmessage = ex.Message
            End Try
            BinGrid.Rows.Item(dBinIdx).Cells.Item(0).Value = BinMisc(dBinIdx).dBinNo
            BinGrid.Rows.Item(dBinIdx).Cells.Item(1).Value = BinMisc(dBinIdx).dSort
            BinGrid.Rows.Item(dBinIdx).Cells.Item(2).Value = BinMisc(dBinIdx).dActual
            BinGrid.Rows.Item(dBinIdx).Cells.Item(3).Value = BinMisc(dBinIdx).dMaximum
            BinGrid.Rows.Item(dBinIdx).Cells.Item(4).Value = BinMisc(dBinIdx).dPercent
            If BinMisc(dBinIdx).dStatus Then
                BinGrid.Rows.Item(dBinIdx).Cells.Item(5).Value = "Enabled"
            Else
                BinGrid.Rows.Item(dBinIdx).Cells.Item(5).Value = "Disabled"
            End If

            BinGrid.Rows.Item(dBinIdx).Cells.Item(6).Value = BinMisc(dBinIdx).szDescription

            dBinIdx += 1
            If dBinIdx > 64 Then
                dBinIdx = 0
            End If

        End If

    End Sub

End Class