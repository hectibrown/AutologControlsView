Imports System
Imports System.IO
Imports System.Windows
Imports System.Text

Public Class HistoryPlaneur
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

    Private Sub ReturnToMainButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Home.Show()
        ' Me.Hide()
        Me.Visible = False
    End Sub


    'Items a completes:
    '   - Creation d'un base des données pour faire le classement 


    'Decalaration de variables requis pour l'ecran d'historique
    Dim bPauseHistory As Boolean
    Dim dLugId As Int32
    Dim dLastLugId As Int32
    Dim dIdx As Int32
    Dim dIdxSz As Int32
    Dim g_ActLug As New StLugsPlaner
    Dim szDest(1) As String

    'Gestion d'ecran d'historique
    Private Sub DataSubscriber21_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber21.DataChanged
        'Verification de nouveau lug
        dLugId = DataSubscriber21.PLCAddressValueItems(0).LastValue
        If dLugId > -1 And dLugId < 200 Then
            Dim szLugId As String = CStr(dLugId)

            g_ActLug.Master.Data(dLugId) = EthernetIPforCLXCom1.ReadUDT(Of StLugDataPlaner)("g_ActLug.Master.Data[" & szLugId & "]")

            If dLastLugId <> dLugId And Not bPauseHistory Then
                Dim timeStamp1 As DateTime = DateTime.Now
                'Achifer sur le tableau
                Call DestToString(g_ActLug.Master.Data(dLugId).BaseData.dDestination(0), g_ActLug.Master.Data(dLugId).Cmd8Rx.dDestination(0))
                If g_ActLug.Master.Data(dLugId).BaseData.dDestination(0) <> 0 Or g_ActLug.Master.Data(dLugId).BaseData.dDestination(1) <> 0 Then
                    Me.DataGridView3.Rows.Insert(0, timeStamp1,
                                                 g_ActLug.Master.Data(dLugId).Cmd8Rx.dLugId,
                                                 0, 'stLugDataPlaner.Cmd8Rx.dOptiNumber,
                                                 0, 'szDest(1),
                                                 szDest(0),
                                                 g_ActLug.Master.Data(dLugId).BaseData.dBin(0),
                                                 g_ActLug.Master.Data(dLugId).BaseData.dSort(0),
                                                 CStr(g_ActLug.Master.Data(dLugId).BaseData.dThick(0) / 1000) & " in x " & CStr(g_ActLug.Master.Data(dLugId).BaseData.dWidth(0) / 1000) & " in x " & CStr(g_ActLug.Master.Data(dLugId).BaseData.dLength(0) / 10) & " in")
                End If
                dLastLugId = dLugId
                'Limit de ranges du tableau
                If DataGridView3.Rows.Count > 50 Then
                    Me.DataGridView3.Rows.Remove(DataGridView3.Rows(49))
                End If
            ElseIf dLastLugId <> dLugId And bPauseHistory Then
                Dim timeStamp1 As DateTime = DateTime.Now
                'Achifer sur le tableau
                Call DestToString(g_ActLug.Master.Data(dLugId).BaseData.dDestination(0), g_ActLug.Master.Data(dLugId).Cmd8Rx.dDestination(0))
                If g_ActLug.Master.Data(dLugId).BaseData.dDestination(0) <> 0 Or g_ActLug.Master.Data(dLugId).BaseData.dDestination(1) <> 0 Then
                    Me.DataGridView1.Rows.Insert(0, timeStamp1,
                                                 g_ActLug.Master.Data(dLugId).Cmd8Rx.dLugId,
                                                 0, 'stLugDataPlaner.Cmd8Rx.dOptiNumber,
                                                 0, 'szDest(1),
                                                 szDest(0),
                                                 g_ActLug.Master.Data(dLugId).BaseData.dBin(0),
                                                 g_ActLug.Master.Data(dLugId).BaseData.dSort(0),
                                                 CStr(g_ActLug.Master.Data(dLugId).BaseData.dThick(0) / 1000) & " in x " & CStr(g_ActLug.Master.Data(dLugId).BaseData.dWidth(0) / 1000) & " in x " & CStr(g_ActLug.Master.Data(dLugId).BaseData.dLength(0) / 10) & " in")
                End If
                dLastLugId = dLugId
                'Limit de ranges du tableau
                If DataGridView1.Rows.Count > 50 Then
                    Me.DataGridView1.Rows.Remove(DataGridView3.Rows(49))
                End If
            End If
        End If
    End Sub

    'Gestion de conversion de destiantion a string
    Sub DestToString(dDestSorter As Int32, dDestOpti As Int32)
        Select Case dDestSorter
            Case 0
                szDest(0) = "Rejet"
            Case 1
                szDest(0) = "Classeur"
            Case 3
                szDest(0) = "Deligneuse"
            Case 10
                szDest(0) = "Deshiqueteuse"
        End Select
        Select Case dDestOpti
            Case 0
                szDest(1) = "Rejet"
            Case 1
                szDest(1) = "Classeur"
            Case 3
                szDest(1) = "Deligneuse"
            Case 10
                szDest(1) = "Deshiqueteuse"
        End Select
    End Sub

    '
    'Gestion de pause d'ecran d'historique
    Private Sub PauseHistory_Click(sender As Object, e As EventArgs) Handles PauseHistory.Click
        If Not bPauseHistory Then
            bPauseHistory = True
        ElseIf bPauseHistory Then
            bPauseHistory = False
            For Each r As DataGridViewRow In DataGridView1.Rows
                Me.DataGridView3.Rows.Insert(0, {r.Cells(0).Value, r.Cells(1).Value, r.Cells(2).Value, r.Cells(3).Value, r.Cells(4).Value, r.Cells(5).Value, r.Cells(6).Value, r.Cells(7).Value})
            Next
            Me.DataGridView3.Rows.Remove(DataGridView3.Rows(0))
            Me.DataGridView3.Sort(DataGridView3.Columns(0), 1)
        End If
    End Sub

    'Gestion de raz ecran d'historique
    Private Sub ClearHistory_Click(sender As Object, e As EventArgs) Handles ClearHistory.Click
        Dim x As Int32 = DataGridView3.Rows.Count - 1
        Dim i As Int32
        If x > 1 Then
            For i = 1 To x
                DataGridView3.Rows.Remove(DataGridView3.Rows(0))
            Next
        End If
    End Sub

    Public Sub FbLogLast100()
        Dim filePath As String = "C:\AUTOLOG\AutologControlsView\HistoryExport.csv"
        Dim delimeter As String = ","
        Dim sb As New StringBuilder
        For i As Integer = 0 To DataGridView3.Rows.Count - 1
            Dim array As String() = New String(DataGridView3.Columns.Count - 1) {}
            If i.Equals(0) Then
                For j As Integer = 0 To DataGridView3.Columns.Count - 1
                    array(j) = DataGridView3.Columns(j).HeaderText
                Next
                sb.AppendLine(String.Join(delimeter, array))
            End If
            For j As Integer = 0 To DataGridView3.Columns.Count - 1
                If Not DataGridView3.Rows(i).IsNewRow Then
                    array(j) = DataGridView3(j, i).Value.ToString
                End If
            Next
            If Not DataGridView3.Rows(i).IsNewRow Then
                sb.AppendLine(String.Join(delimeter, array))
            End If
        Next
        File.WriteAllText(filePath, sb.ToString)
        'Opens the file immediately after writing
        Process.Start(filePath)
    End Sub

    Private Sub SaveHistory_Click(sender As Object, e As EventArgs) Handles SaveHistory.Click
        Call FbLogLast100()
    End Sub
End Class