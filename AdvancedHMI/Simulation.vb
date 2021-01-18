Public Class Simulation
    Dim g_dCommError As Int32
    Dim g_dConnected As Int32
    Dim bEncoderSimul As Boolean

    Private Sub Simulation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Interval = 200
        Timer1.Start()

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'HydraulicCylinderAnalog1.Value = DataSubscriber21.PLCAddressValueItems(2).LastValue
        LugMasterIdx.Text = "Lug Master Idx: " & DataSubscriber21.PLCAddressValueItems(2).LastValue
        LugSlaveIdx.Text = "Lug Slave Idx: " & DataSubscriber21.PLCAddressValueItems(3).LastValue
        LugLoaderIdx.Text = "Lug Loader Idx: " & DataSubscriber21.PLCAddressValueItems(4).LastValue
        CypressLugIdx.Text = "Cypress Lug Idx: " & DataSubscriber21.PLCAddressValueItems(5).LastValue
        ReadLen1Idx.Text = "Read Len 1 Lug Idx: " & DataSubscriber21.PLCAddressValueItems(6).LastValue
        ReadWidthIdx.Text = "Read Width Lug Idx: " & DataSubscriber21.PLCAddressValueItems(7).LastValue
        FenceLugIdx.Text = "Fence Lug Idx: " & DataSubscriber21.PLCAddressValueItems(8).LastValue
        FenceSkidLugIdx.Text = "Fence Skid Lug Idx: " & DataSubscriber21.PLCAddressValueItems(9).LastValue
        ReadLen2LugIdx.Text = "Read Len 2 Idx: " & DataSubscriber21.PLCAddressValueItems(10).LastValue
        SawsLugIdx.Text = "Saws Lug Idx: " & DataSubscriber21.PLCAddressValueItems(11).LastValue
        CitSkidLugIdx.Text = "CIT Skid Lug Idx: " & DataSubscriber21.PLCAddressValueItems(12).LastValue
        PositionSkidLugIdx.Text = "Pos Skid Lug Idx: " & DataSubscriber21.PLCAddressValueItems(13).LastValue
        PositionConfLugIdx.Text = "Pos Conf Lug Idx: " & DataSubscriber21.PLCAddressValueItems(14).LastValue
        PresSorterLugIdx.Text = "Pres Sorter Lug Idx: " & DataSubscriber21.PLCAddressValueItems(17).LastValue
        HistoryLugIdx.Text = "History Lug Idx: " & DataSubscriber21.PLCAddressValueItems(18).LastValue
        FenceCheckLugIdx.Text = "Fence Check Lug Idx: " & DataSubscriber21.PLCAddressValueItems(20).LastValue
        'ReadLen2LugIdx.Text = "Read Len 2 Lug Idx: " & DataSubscriber21.PLCAddressValueItems(10).LastValue
    End Sub

    Private Sub LineSpeedInput_ValueChanged(sender As Object, e As EventArgs) Handles LineSpeedInput.ValueChanged
        Dim dLineSpeedLugs As Int32
        dLineSpeedLugs = LineSpeedInput.Value / 3
        Try
            EthernetIPforCLXCom1.Write("PROGRAM:LUG_MASTER.dSimulPulseScan", Str(dLineSpeedLugs))
            EthernetIPforCLXCom1.Write("PROGRAM:LUG_SLAVE.dSimulPulseScan", Str(dLineSpeedLugs))
        Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
            g_dCommError = ex.ErrorCode
            If g_dCommError <> 0 Then
                g_dConnected = 0
            End If
        End Try

    End Sub

    Private Sub ReadInputValuesButton_Click(sender As Object, e As EventArgs) Handles ReadInputValuesButton.Click

        Try
            LineSpeedInput.Value = CInt(EthernetIPforCLXCom1.Read("PROGRAM:LUG_MASTER.dSimulPulseScan")) * 3
            NeTrimInput.Text = EthernetIPforCLXCom1.Read("PROGRAM:ACT_CYPRESS_ETHERNET.SimulGMR.dNETrimVal")
            FeTrimInput.Text = EthernetIPforCLXCom1.Read("PROGRAM:ACT_CYPRESS_ETHERNET.SimulGMR.dFETrimVal")
            NeCitTrimInput.Text = EthernetIPforCLXCom1.Read("PROGRAM:ACT_CYPRESS_ETHERNET.SimulGMR.dNECITVal")
            FeCitTrimInput.Text = EthernetIPforCLXCom1.Read("PROGRAM:ACT_CYPRESS_ETHERNET.SimulGMR.dFECITVal")
            FenceValInput.Text = EthernetIPforCLXCom1.Read("PROGRAM:ACT_CYPRESS_ETHERNET.SimulGMR.dFenceVal")
            NeGradeInput.Text = EthernetIPforCLXCom1.Read("PROGRAM:ACT_CYPRESS_ETHERNET.SimulGMR.dGrade[0]")
            FeGradeInout.Text = EthernetIPforCLXCom1.Read("PROGRAM:ACT_CYPRESS_ETHERNET.SimulGMR.dGrade[1]")
            NeDestInput.Text = EthernetIPforCLXCom1.Read("PROGRAM:ACT_CYPRESS_ETHERNET.SimulGMR.dDestination[0]")
            FeDestInput.Text = EthernetIPforCLXCom1.Read("PROGRAM:ACT_CYPRESS_ETHERNET.SimulGMR.dDestination[1]")
            SpeciesInput.Text = EthernetIPforCLXCom1.Read("PROGRAM:ACT_CYPRESS_ETHERNET.SimulGMR.dSpecie")
            SlashCheckBox.Text = EthernetIPforCLXCom1.Read("PROGRAM:ACT_CYPRESS_ETHERNET.SimulGMR.bSlash")
            RemanCheckBox.Text = EthernetIPforCLXCom1.Read("PROGRAM:ACT_CYPRESS_ETHERNET.SimulGMR.bReman")

        Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
            g_dCommError = ex.ErrorCode
            If g_dCommError <> 0 Then
                g_dConnected = 0
            End If
        End Try

    End Sub


End Class