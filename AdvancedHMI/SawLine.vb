Imports System.Windows.Forms

Public Class SawLine
    Dim g_PieceBuffer(9) As StPieceDataLinear
    Private Shared WithEvents myTimer As New System.Windows.Forms.Timer()

    Private Sub SawLine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label1.Text = "ECDiffieHellman"
        myTimer.Interval = 200
        myTimer.Enabled = True

        myTimer.Start()


    End Sub

    Private Sub TimerEventProcessor(myObject As Object, ByVal myEventArgs As EventArgs)
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

    Public Sub New()
        'In VB, you give the max index, not the length.
        'I prefer listing this as (whatever I want for length) - 1
        Me.g_PieceBuffer = New StPieceDataLinear(9) {}
        For i = 0 To 9
            Me.g_PieceBuffer(i) = New StPieceDataLinear()
        Next
        'similarly for other fields
    End Sub

    Private Sub EthernetIPforCLXCom1_DataReceived(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles EthernetIPforCLXCom1.DataReceived

    End Sub
End Class