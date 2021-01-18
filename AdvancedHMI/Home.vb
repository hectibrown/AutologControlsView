Public Class Home
    Dim dLastSpeed As Integer
    Dim i As Integer
    'Private oXL As Microsoft.Office.Interop.Excel.Application
    'Private oWB As Microsoft.Office.Interop.Excel.Workbook
    'Private oSheet As Microsoft.Office.Interop.Excel.Worksheet

    'Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    ' Start Excel and get Application object.
    '    oXL = CreateObject("Excel.Application")
    '    oXL.Visible = True

    ' Get a new workbook.
    '    oWB = oXL.Workbooks.Add
    '    oSheet = oWB.ActiveSheet
    '    oSheet.Cells(2, 1).Value = "dSimulSpeed->"
    'Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
    'Dim x = CType(resources.GetObject("MessageListByValue1.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue)
    'End Sub


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
    'Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    'Dim index As Integer
    'While index < My.Application.OpenForms.Count
    'If My.Application.OpenForms(index) IsNot Me Then
    '           My.Application.OpenForms(index).Close()
    'End If
    '       index += 1
    'End While
    'End Sub

    Private Sub DataSubscriber21_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber21.DataChanged
        Dim r As Int32 = 52
        Dim szTestArray() As String = EthernetIPforCLXCom1.Read("PROGRAM:DIRECT.dTestArray[0]", r + 1)
        For i = 0 To r
            'oSheet.Cells((i + 1), 3).Value = szTestArray(i)
        Next i
    End Sub

    Private Sub DataSubscriber1_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)
        'oSheet.Cells(1, 1).Value = e.Values(0)
        'If dLastSpeed <> oSheet.Cells(2, 2).Value Then
        'EthernetIPforCLXCom1.Write("PROGRAM:DIRECT.dSimulSpeed", CStr(oSheet.Cells(2, 2).Value))
        'dLastSpeed = oSheet.Cells(2, 2).Value
        'End If
    End Sub

    Private Sub DataSubscriber2_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs)
        'oSheet.Cells(1, 2).Value = e.Values(0)
    End Sub

    Private Sub EthernetIPforCLXCom1_DataReceived(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles EthernetIPforCLXCom1.DataReceived

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call DrawLinePoint()

    End Sub

    Private Sub Home_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'Line 1
        Dim Pen1 As New Pen(Color.DimGray, 2)
        Dim point11 As New Point(10, 82)
        Dim point12 As New Point(1100, 82)
        e.Graphics.DrawLine(Pen1, point11, point12)
        'Line 2
        Dim Pen2 As New Pen(Color.DimGray, 2)
        Dim point21 As New Point(10, 115)
        Dim point22 As New Point(1100, 115)
        e.Graphics.DrawLine(Pen2, point21, point22)
        'Line 3
        Dim Pen3 As New Pen(Color.DimGray, 2)
        Dim point31 As New Point(10, 145)
        Dim point32 As New Point(1100, 145)
        e.Graphics.DrawLine(Pen3, point31, point32)
        'Line 4
        Dim Pen4 As New Pen(Color.DimGray, 2)
        Dim point41 As New Point(10, 180)
        Dim point42 As New Point(1100, 180)
        e.Graphics.DrawLine(Pen4, point41, point42)
        'Line 5
        Dim Pen5 As New Pen(Color.DimGray, 2)
        Dim point51 As New Point(10, 215)
        Dim point52 As New Point(500, 215)
        e.Graphics.DrawLine(Pen5, point51, point52)
        'Line 6
        Dim Pen6 As New Pen(Color.DimGray, 2)
        Dim point61 As New Point(10, 247)
        Dim point62 As New Point(500, 247)
        e.Graphics.DrawLine(Pen6, point61, point62)
        'Line 7
        Dim Pen7 As New Pen(Color.DimGray, 2)
        Dim point71 As New Point(10, 280)
        Dim point72 As New Point(500, 280)
        e.Graphics.DrawLine(Pen7, point71, point72)
        'Line 8
        Dim Pen8 As New Pen(Color.DimGray, 2)
        Dim point81 As New Point(10, 312)
        Dim point82 As New Point(500, 312)
        e.Graphics.DrawLine(Pen8, point81, point82)
        'Line 9
        Dim Pen9 As New Pen(Color.DimGray, 2)
        Dim point91 As New Point(10, 348)
        Dim point92 As New Point(500, 348)
        e.Graphics.DrawLine(Pen9, point91, point92)
        'Line 10
        Dim Pen10 As New Pen(Color.DimGray, 2)
        Dim point101 As New Point(10, 379)
        Dim point102 As New Point(500, 379)
        e.Graphics.DrawLine(Pen10, point101, point102)
        'Line 11
        Dim Pen11 As New Pen(Color.DimGray, 2)
        Dim point111 As New Point(10, 413)
        Dim point112 As New Point(500, 413)
        e.Graphics.DrawLine(Pen11, point111, point112)
        'Line 12
        Dim Pen12 As New Pen(Color.DimGray, 2)
        Dim point121 As New Point(10, 445)
        Dim point122 As New Point(500, 445)
        e.Graphics.DrawLine(Pen12, point121, point122)
        'Line 13
        Dim Pen13 As New Pen(Color.DimGray, 2)
        Dim point131 As New Point(10, 477)
        Dim point132 As New Point(500, 477)
        e.Graphics.DrawLine(Pen13, point131, point132)
    End Sub

End Class
