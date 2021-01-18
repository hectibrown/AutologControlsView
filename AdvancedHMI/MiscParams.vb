

Public Class MiscParams

    'Dim tcClient As TcAdsClient
    'Dim hVar As Integer
    Dim g_PieceBuffer(9) As StPieceDataLinear

    'Scroll Text Test********************

    Dim ScrollLabel2 As MarqueeLabel
    Dim szOldValueL89 As String

    Dim ScrollTextNr As Integer
    'Dim Test As String = BasicLabel89.Value
    Dim ExtraSpace As String = " "
    Dim bBeckhoff As Boolean
    Private Sub MiscParams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer1.InitializeLifetimeService()
        Timer1.Interval = 200
        Timer1.Start()

        If bBeckhoff Then
            'TwinCat Ads Client Start
            'tcClient = New TcAdsClient()
            'tcClient.Connect("150.150.10.1.1.1", 851)
            'Try
            'hVar = tcClient.CreateVariableHandle("MAIN.PLCVar")
            'Catch err As Exception
            'MessageBox.Show(err.Message)
            'End Try

        End If
    End Sub


    Public Sub New()
        'In VB, you give the max index, not the length.
        'I prefer listing this as (whatever I want for length) - 1
        Me.g_PieceBuffer = New StPieceDataLinear(9) {}
        For i = 0 To 9
            Me.g_PieceBuffer(i) = New StPieceDataLinear()
        Next
        'similarly for other fields
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dErrorCode As Int32

        If g_PieceBuffer(0) Is Nothing Then
            Label1.Text = "null"
        Else
            Label1.Text = g_PieceBuffer(0).dIdOpti
        End If

        Try
            g_PieceBuffer(0) = EthernetIPforCLXCom1.ReadUDT(Of StPieceDataLinear)("g_PieceBuffer.Data[0]")
        Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
            dErrorCode = ex.ErrorCode
        End Try
        Label2.Text = dErrorCode
    End Sub



    Dim dLugId As Int32 = 0
    Dim dLastLugId As Int32
    Dim bPauseHistory As Boolean
    Dim stLugData As New StLugData
    Dim szDest As String
    Dim i As Int32

    Private Sub DataSubscriber21_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber21.DataChanged
        'Verification de nouveau lug
        dLugId = DataSubscriber21.PLCAddressValueItems(0).LastValue
        If dLugId > -1 And dLugId < 200 Then
            stLugData = EthernetIPforCLXCom1.ReadUDT(Of StLugData)("g_ActLug.Data[" & CStr(dLugId) & "]")
            If dLastLugId <> dLugId And Not bPauseHistory Then
                Dim timeStamp1 As DateTime = DateTime.Now
                'Achifer sur le tableau
                Call DestIntToString(stLugData.BaseData.dDestination(0))
                If stLugData.BaseData.dDestination(0) <> 0 Or stLugData.BaseData.dDestination(1) <> 0 Then
                    Me.DataGridView1.Rows.Insert(0, timeStamp1,
                                                 stLugData.OptiRx.dLugId,
                                                 stLugData.OptiRx.dOptiNumber,
                                                 szDest,
                                                 stLugData.BaseData.dSort(0),
                                                 stLugData.BaseData.dBin(0),
                                                 CStr(stLugData.BaseData.dThickNom(0) / 1000) & " in x " & CStr(stLugData.BaseData.dWidthNom(0) / 1000) & " in x " & CStr(stLugData.BaseData.dLengthNom(0) / 10) & " in")
                End If
                dLastLugId = dLugId
                'Limit de ranges du tableau
                If DataGridView1.Rows.Count > 50 Then
                    Me.DataGridView1.Rows.Remove(DataGridView1.Rows(49))
                End If
            End If
        End If

    End Sub

    'Gestion de conversion de destiantion a string
    Sub DestIntToString(dDest As Int32)
        Select Case dDest
            Case 0
                szDest = "Rejet"
            Case 1
                szDest = "Classeur"
            Case 3
                szDest = "Deligneuse"
            Case 10
                szDest = "Deshiqueteuse"
        End Select
    End Sub


    Private Sub MiscParams_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Resourcen wieder freigeben
        If bBeckhoff Then
            'Try
            'tcClient.DeleteVariableHandle(hVar)
            'Catch err As Exception
            'MessageBox.Show(err.Message)
            'End Try
            'tcClient.Dispose()
        End If

    End Sub

End Class