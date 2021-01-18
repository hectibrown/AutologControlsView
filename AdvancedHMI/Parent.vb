Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Runtime.CompilerServices
'Imports MfgControl.AdvancedHMI.MDITest


Public Class Parent
    Dim bFirstScan As Boolean

    Private Sub MiscParams_Load(sender As Object, e As EventArgs) Handles MiscParamsToolStripMenuItem.Click
        MiscParams.MdiParent = Me
        MiscParams.WindowState = FormWindowState.Normal
        MiscParams.Dock = DockStyle.Fill
        MiscParams.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        MiscParams.ControlBox = False
        MiscParams.MaximizeBox = False
        MiscParams.MinimizeBox = False
        MiscParams.ShowIcon = False
        MiscParams.Text = "Parameters Divers"
        MiscParams.Show()
        Me.Text = "Autolog Controls View - Parameters Divers"
        MiscParams.BringToFront()
    End Sub

    Private Sub CarrigeOptiSoln_Load(sender As Object, e As EventArgs) Handles CarrigeSolutionToolStripMenuItem.Click
        CarrigeSoln.MdiParent = Me
        CarrigeSoln.WindowState = FormWindowState.Normal
        CarrigeSoln.Dock = DockStyle.Fill
        CarrigeSoln.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        CarrigeSoln.ControlBox = False
        CarrigeSoln.MaximizeBox = False
        CarrigeSoln.MinimizeBox = False
        CarrigeSoln.ShowIcon = False
        CarrigeSoln.Text = "Carrige Opti Solution"
        CarrigeSoln.Show()
        Me.Text = "Autolog Controls View - Carrige Opti Solution"

        If bFirstScan Then
            CarrigeSoln.BringToFront()
        End If

    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        History.MdiParent = Me
        History.WindowState = FormWindowState.Normal
        History.Dock = DockStyle.Fill
        History.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        History.ControlBox = False
        History.MaximizeBox = False
        History.MinimizeBox = False
        History.ShowIcon = False
        History.Text = "Historique Classseur"
        History.Show()
        Me.Text = "Autolog Controls View - Historique Classseur"
        If bFirstScan Then
            History.BringToFront()
        End If
    End Sub

    Public Sub Home_Load(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Home.MdiParent = Me
        Home.WindowState = FormWindowState.Normal
        Home.Dock = DockStyle.Fill
        Home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Home.ControlBox = False
        Home.MaximizeBox = False
        Home.MinimizeBox = False
        Home.ShowIcon = False
        Home.Text = "Status Contrôle"
        Home.Show()
        Me.Text = "Autolog Controls View - Status Contrôle"
        If bFirstScan Then
            Home.BringToFront()
        End If
    End Sub

    Private Sub HomeDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load, DashBoardToolStripMenuItem.Click
        HomeDashBoard.MdiParent = Me
        ToolStripManager.Merge(HomeDashBoard.MenuStrip1, Me.MenuStrip1)
        HomeDashBoard.WindowState = FormWindowState.Normal
        HomeDashBoard.Dock = DockStyle.Fill
        HomeDashBoard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        HomeDashBoard.ControlBox = False
        HomeDashBoard.MaximizeBox = False
        HomeDashBoard.MinimizeBox = False
        HomeDashBoard.ShowIcon = False
        HomeDashBoard.Text = "Acceuil"
        HomeDashBoard.Show()

        Me.Text = "Autolog Controls View - Acceuil"
        If bFirstScan Then
            HomeDashBoard.BringToFront()
        End If
        bFirstScan = 1
    End Sub


    Private Sub ToolStripProgressBar1_Click(sender As Object, e As EventArgs)
        Dim cpu As New System.Diagnostics.PerformanceCounter()
        With cpu
            .CategoryName = "Processor"
            .CounterName = "% Processor Time"
            .InstanceName = "MyProcess"
        End With
        'ToolStripProgressBar1.Value = cpu.CounterName
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        If HomeDashBoard.Visible Then
            HomeDashBoard.Hide()
            HomeDashBoard.Dispose()
        End If
        If Home.Visible Then
            Home.Hide()
            Home.Dispose()
        End If
        If MiscParams.Visible Then
            MiscParams.Hide()
            MiscParams.Dispose()
        End If
        If History.Visible Then
            History.Hide()
            History.Dispose()
        End If
        If CarrigeSoln.Visible Then
            CarrigeSoln.Hide()
            CarrigeSoln.Dispose()
        End If
        If Simulation.Visible Then
            Simulation.Hide()
            Simulation.Dispose()
        End If
        If HistoryPlaneur.Visible Then
            HistoryPlaneur.Hide()
            HistoryPlaneur.Dispose()
        End If
        If SawLine.Visible Then
            SawLine.Hide()
            SawLine.Dispose()
        End If
    End Sub

    Private Sub MinimizeAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeAllToolStripMenuItem.Click
        HomeDashBoard.WindowState = 1
        Home.WindowState = 1
        MiscParams.WindowState = 1
        History.WindowState = 1
        CarrigeSoln.WindowState = 1
    End Sub

    Private Sub SimulationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimulationToolStripMenuItem.Click
        Simulation.MdiParent = Me
        Simulation.WindowState = FormWindowState.Normal
        Simulation.Dock = DockStyle.Fill
        Simulation.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Simulation.ControlBox = False
        Simulation.MaximizeBox = False
        Simulation.MinimizeBox = False
        Simulation.ShowIcon = False
        Simulation.Text = "Simulation"
        Simulation.Show()
        Me.Text = "Autolog Controls View - Simulation"
    End Sub

    Private Sub HistoryPlaneurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryPlaneurToolStripMenuItem.Click
        HistoryPlaneur.MdiParent = Me
        HistoryPlaneur.WindowState = FormWindowState.Normal
        HistoryPlaneur.Dock = DockStyle.Fill
        HistoryPlaneur.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        HistoryPlaneur.ControlBox = False
        HistoryPlaneur.MaximizeBox = False
        HistoryPlaneur.MinimizeBox = False
        HistoryPlaneur.ShowIcon = False
        HistoryPlaneur.Text = "Historique Classseur"
        HistoryPlaneur.Show()
        Me.Text = "Autolog Controls View - Historique Planeur"
    End Sub

    Private Sub SawLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SawLineToolStripMenuItem.Click
        SawLine.MdiParent = Me
        SawLine.WindowState = FormWindowState.Normal
        SawLine.Dock = DockStyle.Fill
        SawLine.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        SawLine.ControlBox = False
        SawLine.MaximizeBox = False
        SawLine.MinimizeBox = False
        SawLine.ShowIcon = False
        SawLine.Text = "Saw Line"
        SawLine.Show()
        Me.Text = "Autolog Controls View - Saw Line"
    End Sub
End Class

