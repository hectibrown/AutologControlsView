﻿'****************************************************************************
'* Archie Jacobs
'* Manufacturing Automation, LLC
'* support@advancedhmi.com
'* 12-JUN-11
'*
'* Copyright 2011 Archie Jacobs
'*
'* Distributed under the GNU General Public License (www.gnu.org)
'*
'* This program is free software; you can redistribute it and/or
'* as published by the Free Software Foundation; either version 2
'* of the License, or (at your option) any later version.
'*
'* This program is distributed in the hope that it will be useful,
'* but WITHOUT ANY WARRANTY; without even the implied warranty of
'* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'* GNU General Public License for more details.

'* You should have received a copy of the GNU General Public License
'* along with this program; if not, write to the Free Software
'* Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
'*
'* 12-JUN-11 Created
'****************************************************************************
Public Class TempController
    Inherits MfgControl.AdvancedHMI.Controls.TempController


#Region "Properties"
    Private SavedBackColor As System.Drawing.Color

    Private _ValueScaleFactor As Decimal = 1
    <System.ComponentModel.Category("Numeric Display")> _
    Public Property ScaleFactor() As Decimal
        Get
            Return _ValueScaleFactor
        End Get
        Set(ByVal value As Decimal)
            _ValueScaleFactor = value
        End Set
    End Property
#End Region

#Region "PLC Related Properties"
    '*****************************************************
    '* Property - Component to communicate to PLC through
    '*****************************************************
    Private m_ComComponent As MfgControl.AdvancedHMI.Drivers.IComComponent
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property ComComponent()  As MfgControl.AdvancedHMI.Drivers.IComComponent
        Get
            Return m_ComComponent
        End Get
        Set(ByVal value As  MfgControl.AdvancedHMI.Drivers.IComComponent)
            If m_ComComponent IsNot value Then
                If SubScriptions IsNot Nothing Then
                    SubScriptions.UnsubscribeAll()
                End If

                m_ComComponent = value

                SubscribeToComDriver()
            End If
        End Set
    End Property


    '*****************************************
    '* Property - Address in PLC to Link to
    '*****************************************
    Private m_PLCAddressText As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressText() As String
        Get
            Return m_PLCAddressText
        End Get
        Set(ByVal value As String)
            If m_PLCAddressText <> value Then
                m_PLCAddressText = value

                '* When address is changed, re-subscribe to new address
                SubscribeToComDriver()
            End If
        End Set
    End Property

    '*****************************************
    '* Property - Address in PLC to Link to
    '*****************************************
    Private m_PLCAddressVisible As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressVisible() As String
        Get
            Return m_PLCAddressVisible
        End Get
        Set(ByVal value As String)
            If m_PLCAddressVisible <> value Then
                m_PLCAddressVisible = value

                '* When address is changed, re-subscribe to new address
                SubscribeToComDriver()
            End If
        End Set
    End Property

    '*****************************************
    '* Property - Address in PLC to Link to
    '*****************************************
    Private m_PLCAddressValuePV As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressValuePV() As String
        Get
            Return m_PLCAddressValuePV
        End Get
        Set(ByVal value As String)
            If m_PLCAddressValuePV <> value Then
                m_PLCAddressValuePV = value

                '* When address is changed, re-subscribe to new address
                SubscribeToComDriver()
            End If
        End Set
    End Property

    '*****************************************
    '* Property - Address in PLC to Link to
    '*****************************************
    Private m_PLCAddressValueSP As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressValueSP() As String
        Get
            Return m_PLCAddressValueSP
        End Get
        Set(ByVal value As String)
            If m_PLCAddressValueSP <> value Then
                m_PLCAddressValueSP = value

                '* When address is changed, re-subscribe to new address
                SubscribeToComDriver()
            End If
        End Set
    End Property

    '********************************************
    '* Property - Address in PLC for click event
    '********************************************
    Private m_PLCAddressClick1 As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressClick1() As String
        Get
            Return m_PLCAddressClick1
        End Get
        Set(ByVal value As String)
            m_PLCAddressClick1 = value
        End Set
    End Property

    Private m_PLCAddressClick2 As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressClick2() As String
        Get
            Return m_PLCAddressClick2
        End Get
        Set(ByVal value As String)
            m_PLCAddressClick2 = value
        End Set
    End Property

    Private m_PLCAddressClick3 As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressClick3() As String
        Get
            Return m_PLCAddressClick3
        End Get
        Set(ByVal value As String)
            m_PLCAddressClick3 = value
        End Set
    End Property

    Private m_PLCAddressClick4 As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressClick4() As String
        Get
            Return m_PLCAddressClick4
        End Get
        Set(ByVal value As String)
            m_PLCAddressClick4 = value
        End Set
    End Property

    '*****************************************
    '* Property - What to do to bit in PLC
    '*****************************************
    Private m_OutputType As MfgControl.AdvancedHMI.Controls.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property OutputType() As MfgControl.AdvancedHMI.Controls.OutputType
        Get
            Return m_OutputType
        End Get
        Set(ByVal value As MfgControl.AdvancedHMI.Controls.OutputType)
            m_OutputType = value
        End Set
    End Property

    Private m_SuppressErrorDisplay As Boolean
    <System.ComponentModel.DefaultValue(False)> _
    Public Property SuppressErrorDisplay As Boolean
        Get
            Return m_SuppressErrorDisplay
        End Get
        Set(value As Boolean)
            m_SuppressErrorDisplay = value
        End Set
    End Property
#End Region

#Region "Events"
    'Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
    'End Sub

    '********************************************************************
    '* When an instance is added to the form, set the comm component
    '* property. If a comm component does not exist, add one to the form
    '********************************************************************
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()

        If Me.DesignMode Then
            If m_ComComponent Is Nothing Then
                m_ComComponent = AdvancedHMIDrivers.Utilities.GetComComponent(Me.Site.Container)
            End If
        Else
            SubscribeToComDriver()
        End If
    End Sub

    '****************************
    '* Event - Button Click
    '****************************
    Private Sub _Click1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.Button1MouseDown
        MouseDownActon(m_PLCAddressClick1)
    End Sub

    Private Sub _MouseUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.Button1MouseUp
        MouseUpAction(m_PLCAddressClick1)
    End Sub

    Private Sub _click2(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.Button2MouseDown
        MouseDownActon(m_PLCAddressClick2)
    End Sub

    Private Sub _MouseUp2(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.Button2MouseUp
        MouseUpAction(m_PLCAddressClick2)
    End Sub

    Private Sub _click3(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.Button3MouseDown
        MouseDownActon(m_PLCAddressClick3)
    End Sub

    Private Sub _MouseUp3(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.Button3MouseUp
        MouseUpAction(m_PLCAddressClick3)
    End Sub

    Private Sub _click4(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.Button4MouseDown
        MouseDownActon(m_PLCAddressClick4)
    End Sub

    Private Sub _MouseUp4(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.Button4MouseUp
        MouseUpAction(m_PLCAddressClick4)
    End Sub

    Private Sub MouseDownActon(ByVal PLCAddress As String)
        If PLCAddress IsNot Nothing AndAlso (String.Compare(PLCAddress, "") <> 0) Then
            Try
                Select Case m_OutputType
                    Case MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet : m_ComComponent.Write(PLCAddress, 1)
                    Case MfgControl.AdvancedHMI.Controls.OutputType.MomentaryReset : m_ComComponent.Write(PLCAddress, 0)
                    Case MfgControl.AdvancedHMI.Controls.OutputType.SetTrue : m_ComComponent.Write(PLCAddress, 1)
                    Case MfgControl.AdvancedHMI.Controls.OutputType.SetFalse : m_ComComponent.Write(PLCAddress, 0)
                    Case MfgControl.AdvancedHMI.Controls.OutputType.Toggle
                        Dim CurrentValue As Boolean
                        CurrentValue = m_ComComponent.Read(PLCAddress, 1)(0)
                        If CurrentValue Then
                            m_ComComponent.Write(PLCAddress, 0)
                        Else
                            m_ComComponent.Write(PLCAddress, 1)
                        End If
                End Select
            Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                If ex.ErrorCode = 1808 Then
                    DisplayError("""" & PLCAddress & """ PLC Address not found")
                Else
                    DisplayError(ex.Message)
                End If
            End Try
        End If
    End Sub


    Private Sub MouseUpAction(ByVal PLCAddress As String)
        If PLCAddress IsNot Nothing AndAlso (String.Compare(PLCAddress, "") <> 0) And Enabled Then
            Try
                Select Case OutputType
                    Case MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet : m_ComComponent.Write(PLCAddress, 0)
                    Case MfgControl.AdvancedHMI.Controls.OutputType.MomentaryReset : m_ComComponent.Write(PLCAddress, 1)
                End Select
            Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                If ex.ErrorCode = 1808 Then
                    DisplayError("""" & PLCAddress & """ PLC Address not found")
                Else
                    DisplayError(ex.Message)
                End If
            End Try
        End If
    End Sub
#End Region

#Region "Constructor/Destructor"
    '****************************************************************
    '* UserControl overrides dispose to clean up the component list.
    '****************************************************************
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then
                If SubScriptions IsNot Nothing Then
                    SubScriptions.dispose()
                End If
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
#End Region

#Region "Subscribing and PLC data receiving"
    Private SubScriptions As SubscriptionHandler
    '**************************************************
    '* Subscribe to addresses in the Comm(PLC) Driver
    '**************************************************
    Private Sub SubscribeToComDriver()
        If Not DesignMode And IsHandleCreated Then
            '* Create a subscription handler object
            If SubScriptions Is Nothing Then
                SubScriptions = New SubscriptionHandler
                SubScriptions.Parent = Me
                AddHandler SubScriptions.DisplayError, AddressOf DisplaySubscribeError
            End If
            SubScriptions.ComComponent = m_ComComponent

            SubScriptions.subscribeAutoProperties()
        End If
    End Sub

    '***************************************
    '* Call backs for returned data
    '***************************************
    Private OriginalText As String
    Private Sub PolledDataReturned(ByVal sender As Object, ByVal e As SubscriptionHandlerEventArgs)
    End Sub

    Private Sub DisplaySubscribeError(ByVal sender As Object, ByVal e As MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
        DisplayError(e.ErrorMessage)
    End Sub
#End Region

#Region "Error Display"
    '********************************************************
    '* Show an error via the text property for a short time
    '********************************************************
    Private WithEvents ErrorDisplayTime As System.Windows.Forms.Timer
    Private Sub DisplayError(ByVal ErrorMessage As String)
        If Not m_SuppressErrorDisplay Then
            If ErrorDisplayTime Is Nothing Then
                ErrorDisplayTime = New System.Windows.Forms.Timer
                AddHandler ErrorDisplayTime.Tick, AddressOf ErrorDisplay_Tick
                ErrorDisplayTime.Interval = 6000
            End If

            '* Save the text to return to
            If Not ErrorDisplayTime.Enabled Then
                OriginalText = Me.Text
            End If

            ErrorDisplayTime.Enabled = True

            Text = ErrorMessage
        End If
    End Sub


    '**************************************************************************************
    '* Return the text back to its original after displaying the error for a few seconds.
    '**************************************************************************************
    Private Sub ErrorDisplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Text = OriginalText

        If ErrorDisplayTime IsNot Nothing Then
            ErrorDisplayTime.Enabled = False
            ErrorDisplayTime.Dispose()
            ErrorDisplayTime = Nothing
        End If
    End Sub
#End Region

End Class