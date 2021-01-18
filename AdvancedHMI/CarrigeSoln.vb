Public Class CarrigeSoln

    Private Sub CarrigeSoln_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 250
        Timer1.Start()
    End Sub

    Dim g_dAdvHmiWatchDog As Int32
    Dim g_dLastValueWatchDog(15) As Int32
    Dim g_dConnected As Int32 = 0
    Dim g_dCommError As Int32
    Dim g_OptiRx As New StOptiRxSolution
    Dim CnstWidth As Int32 = 175
    Dim CnstOrigin As New Point(1000, 500)
    ReadOnly CnstSpace As Int32 = 25
    Dim CnstDivider As Int32 = 35
    Dim dSide1XPoint As Int32
    Dim dSide1XDim As Int32
    Dim dTestIncr As Int32
    '               Side1 Face0
    '   Side0 Face1            Side0 Face0
    '               Side1 Face1

    Private Sub DataSubscriber21_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber21.DataChanged
        Me.Invalidate()
        Dim dIdx As Int32
        Dim x As Int32
        Dim y As Int32
        Dim W As Int32
        g_OptiRx = EthernetIPforCLXCom1.ReadUDT(Of StOptiRxSolution)("g_OptiRx")
        'Label1.Text = CStr(g_OptiRx.dLogId)
        'Label2.Text = CStr(g_OptiRx.stOptiStack.Side(0).Face(0).Stack(0).dValue)
        'Label3.Text = CStr(g_OptiRx.stOptiStack.Side(0).Face(0).Stack(19).dValue)
        'Label4.Text = CStr(g_OptiRx.bNoSolution)
        dSide1XDim = g_OptiRx.stOptiStack.Side(0).Face(1).Stack(0).dValue / CnstDivider
        dSide1XPoint = CnstOrigin.X - (g_OptiRx.stOptiStack.Side(0).Face(1).Stack(0).dValue / CnstDivider) - CnstSpace
        'Side 0 Face 0
        For dIdx = 0 To g_OptiRx.stOptiStack.Side(0).Face(0).dNbPieces
            x = g_OptiRx.stOptiStack.Side(0).Face(0).Stack(dIdx).dValue / CnstDivider
            If dIdx > 0 Then
                W += g_OptiRx.stOptiStack.Side(0).Face(0).Stack(dIdx - 1).dValue / CnstDivider
            End If
            Call FbRectS0F0(x, dIdx, W)
        Next
        'Side 0 Face 1
        For dIdx = 0 To g_OptiRx.stOptiStack.Side(0).Face(1).dNbPieces
            x = g_OptiRx.stOptiStack.Side(0).Face(1).Stack(dIdx).dValue / CnstDivider
            W += g_OptiRx.stOptiStack.Side(0).Face(1).Stack(dIdx).dValue / CnstDivider
            Call FbRectS0F1(x, dIdx, W)
        Next
        'Side 1 Face 0
        For dIdx = 0 To g_OptiRx.stOptiStack.Side(1).Face(0).dNbPieces
            y = g_OptiRx.stOptiStack.Side(1).Face(0).Stack(dIdx).dValue / CnstDivider
            W += g_OptiRx.stOptiStack.Side(1).Face(0).Stack(dIdx).dValue / CnstDivider
            Call FbRectS1F0(y, dIdx, W)
        Next
        'Side 1 Face 1
        For dIdx = 0 To g_OptiRx.stOptiStack.Side(1).Face(1).dNbPieces
            y = g_OptiRx.stOptiStack.Side(1).Face(1).Stack(dIdx).dValue / CnstDivider
            If dIdx > 0 Then
                W += g_OptiRx.stOptiStack.Side(1).Face(1).Stack(dIdx - 1).dValue / CnstDivider
            End If
            Call FbRectS1F1(y, dIdx, W)
        Next
    End Sub

    Public Sub FbRectS0F0(x As Int32, dIdx As Int32, W As Int32)
        Dim MyGraphics As Graphics
        Dim pen() As Pen = New Pen(9) {New Pen(Color.Coral, 3), New Pen(Color.Coral, 3),
            New Pen(Color.Coral, 3), New Pen(Color.Coral, 3), New Pen(Color.Coral, 3), New Pen(Color.Coral, 3),
            New Pen(Color.Coral, 3), New Pen(Color.Coral, 3), New Pen(Color.Coral, 3), New Pen(Color.Coral, 3)}
        MyGraphics = Graphics.FromHwnd(Me.Handle)

        If dIdx = 0 Then
            Dim Rectangle As New Rectangle(CnstOrigin.X, CnstOrigin.Y, x, CnstWidth)
            MyGraphics.DrawRectangle(pen(0), Rectangle)
        Else
            Dim NewX As Int32 = CnstOrigin.X + (CnstSpace * dIdx) + W
            Dim Rectangle As New Rectangle(NewX, CnstOrigin.Y, x, CnstWidth)
            MyGraphics.DrawRectangle(pen(dIdx), Rectangle)
        End If
    End Sub

    Public Sub FbRectS0F1(x As Int32, dIdx As Int32, W As Int32)
        Dim MyGraphics As Graphics
        Dim pen() As Pen = New Pen(9) {New Pen(Color.Yellow, 3), New Pen(Color.Yellow, 3),
            New Pen(Color.Yellow, 3), New Pen(Color.Yellow, 3), New Pen(Color.Yellow, 3), New Pen(Color.Yellow, 3),
            New Pen(Color.Yellow, 3), New Pen(Color.Yellow, 3), New Pen(Color.Yellow, 3), New Pen(Color.Yellow, 3)}
        MyGraphics = Graphics.FromHwnd(Me.Handle)

        Dim NewX As Int32 = CnstOrigin.X - (CnstSpace * (dIdx + 1)) - W
        Dim Rectangle As New Rectangle(NewX, CnstOrigin.Y, x, CnstWidth)
        MyGraphics.DrawRectangle(pen(0), Rectangle)
    End Sub

    Public Sub FbRectS1F0(y As Int32, dIdx As Int32, W As Int32)
        Dim MyGraphics As Graphics
        Dim pen() As Pen = New Pen(9) {New Pen(Color.Green, 3), New Pen(Color.Green, 3),
            New Pen(Color.Green, 3), New Pen(Color.Green, 3), New Pen(Color.Green, 3), New Pen(Color.Green, 3),
            New Pen(Color.Green, 3), New Pen(Color.Green, 3), New Pen(Color.Green, 3), New Pen(Color.Green, 3)}
        MyGraphics = Graphics.FromHwnd(Me.Handle)

        Dim NewY As Int32 = CnstOrigin.Y - (CnstSpace * (dIdx + 1)) - W
        Dim Rectangle As New Rectangle(dSide1XPoint, NewY, dSide1XDim, y)
        MyGraphics.DrawRectangle(pen(dIdx), Rectangle)
    End Sub

    Public Sub FbRectS1F1(y As Int32, dIdx As Int32, W As Int32)
        Dim MyGraphics As Graphics
        Dim pen() As Pen = New Pen(9) {New Pen(Color.Purple, 3), New Pen(Color.Purple, 3),
            New Pen(Color.Purple, 3), New Pen(Color.Purple, 3), New Pen(Color.Purple, 3), New Pen(Color.Purple, 3),
            New Pen(Color.Purple, 3), New Pen(Color.Purple, 3), New Pen(Color.Purple, 3), New Pen(Color.Purple, 3)}
        MyGraphics = Graphics.FromHwnd(Me.Handle)

        Dim NewY As Int32 = CnstOrigin.Y + (CnstSpace * (dIdx + 1)) + W + CnstWidth
        Dim Rectangle As New Rectangle(dSide1XPoint, NewY, dSide1XDim, y)
        MyGraphics.DrawRectangle(pen(dIdx), Rectangle)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim bCommsOk As Boolean = 0
        'For Testing**************************************
        If g_dAdvHmiWatchDog <> g_dLastValueWatchDog(0) Then
            Label14.Visible = 1
            bCommsOk = 1
            g_dLastValueWatchDog(0) = g_dAdvHmiWatchDog
        Else
            Label14.Visible = 0
        End If
        g_dCommError = 0
        If bCommsOk And g_dConnected > 0 Then
            Try
                g_OptiRx = EthernetIPforCLXCom1.ReadUDT(Of StOptiRxSolution)("g_OptiRx")
                Label1.Text = CStr(g_OptiRx.stOptiStack.Side(0).Knee(0).dPosition / 1000) & " in"
                Label2.Text = CStr(g_OptiRx.stOptiStack.Side(0).Knee(1).dPosition / 1000) & " in"
                Label3.Text = CStr(g_OptiRx.stOptiStack.Side(0).Knee(2).dPosition / 1000) & " in"
                Label4.Text = CStr(g_OptiRx.stOptiStack.Side(0).Knee(3).dPosition / 1000) & " in"
                Label5.Text = "Log Id: " & CStr(g_OptiRx.dLogId)
            Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                g_dCommError = ex.ErrorCode
                If g_dCommError <> 0 Then
                    g_dConnected = 0
                End If
            End Try
        End If
        Label14.Text = g_dCommError

        'Radar Chart
        dTestIncr += 1
        If dTestIncr > 100 Then
            dTestIncr = 0
        End If
        Chart1.Series(0).Points.Item(0).YValues(0) = dTestIncr
        Chart1.Invalidate()
        Chart1.ChartAreas(0).RecalculateAxesScale()

    End Sub


    Private Sub EthernetIPforCLXCom1_ConnectionClosed(sender As Object, e As EventArgs) Handles EthernetIPforCLXCom1.ConnectionClosed
        g_dConnected = 0
    End Sub

    Private Sub DataSubscriber22_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber22.DataChanged
        g_dConnected = CInt(DataSubscriber22.PLCAddressValueItems(0).LastValue)
        g_dAdvHmiWatchDog = CInt(DataSubscriber22.PLCAddressValueItems(1).LastValue)
    End Sub

    Private Sub EthernetIPforCLXCom1_ComError(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles EthernetIPforCLXCom1.ComError
        g_dConnected = 0
    End Sub

End Class