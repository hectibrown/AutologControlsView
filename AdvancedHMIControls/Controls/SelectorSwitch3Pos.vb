﻿'**********************************************************************************************
'* Selector Switch for AdvancedHMI
'*
'* Archie Jacobs
'* Manufacturing Automation, LLC
'* support@advancedhmi.com
'* 
'*
'* Copyright 2011 Archie Jacobs
'*
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
'**********************************************************************************************

Public Class SelectorSwitch3Pos
    Inherits MfgControl.AdvancedHMI.Controls.SelectorSwitch3Pos


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
    Private m_PLCAddressValueLeft As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressValueLeft() As String
        Get
            Return m_PLCAddressValueLeft
        End Get
        Set(ByVal value As String)
            If m_PLCAddressValueLeft <> value Then
                m_PLCAddressValueLeft = value

                '* When address is changed, re-subscribe to new address
                SubscribeToComDriver()
            End If
        End Set
    End Property

    '*****************************************
    '* Property - Address in PLC to Link to
    '*****************************************
    Private m_PLCAddressValueRight As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressValueRight() As String
        Get
            Return m_PLCAddressValueRight
        End Get
        Set(ByVal value As String)
            If m_PLCAddressValueRight <> value Then
                m_PLCAddressValueRight = value

                '* When address is changed, re-subscribe to new address
                SubscribeToComDriver()
            End If
        End Set
    End Property

    '*****************************************
    '* Property - Address in PLC to Link to
    '*****************************************
    Private m_PLCAddressClickLeft As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressClickLeft() As String
        Get
            Return m_PLCAddressClickLeft
        End Get
        Set(ByVal value As String)
            If m_PLCAddressClickLeft <> value Then
                m_PLCAddressClickLeft = value

                '* When address is changed, re-subscribe to new address
                SubscribeToComDriver()
            End If
        End Set
    End Property

    '*****************************************
    '* Property - Address in PLC to Link to
    '*****************************************
    Private m_PLCAddressClickRight As String = ""
    <System.ComponentModel.Category("PLC Properties")> _
    Public Property PLCAddressClickRight() As String
        Get
            Return m_PLCAddressClickRight
        End Get
        Set(ByVal value As String)
            If m_PLCAddressClickRight <> value Then
                m_PLCAddressClickRight = value

                '* When address is changed, re-subscribe to new address
                SubscribeToComDriver()
            End If
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

    'Private m_ValueLeft As Boolean
    Public Property ValueLeft As Boolean
        Get
            Return (Value = ValueOfLeftPosition)
        End Get
        Set(value As Boolean)
            '* V3.99v - commented out
            '    If Me.Value <> ValueOfLeftPosition Then
            If value Then
                Me.Value = ValueOfLeftPosition
            ElseIf Not ValueRight Then
                Me.Value = ValueOfCenterPosition
            End If
            'm_ValueLeft = value
            ' End If
        End Set
    End Property

    'Private m_ValueRight As Boolean
    Public Property ValueRight As Boolean
        Get
            Return (Value = ValueOfRightPosition)
        End Get
        Set(value As Boolean)
            '  If Me.Value <> ValueOfRightPosition Then
            If value Then
                    Me.Value = ValueOfRightPosition
                ElseIf Not ValueLeft Then
                    Me.Value = ValueOfCenterPosition
                End If
            'm_ValueRight = value
            '    End If
        End Set
    End Property

#End Region

#Region "Events"
    Private WithEvents tmrError As New System.Windows.Forms.Timer

    Private Sub ClickedLeft() Handles MyBase.SwitchLeft
        Try
            If (m_PLCAddressClickLeft IsNot Nothing AndAlso (String.Compare(m_PLCAddressClickLeft, "") <> 0)) Then
                m_ComComponent.Write(m_PLCAddressClickLeft, 1)
            End If

            If (m_PLCAddressClickRight IsNot Nothing AndAlso (String.Compare(m_PLCAddressClickRight, "") <> 0)) Then
                m_ComComponent.Write(m_PLCAddressClickRight, 0)
            End If
        Catch ex As Exception
            DisplayError("WRITE FAILED!" & ex.Message)
        End Try
    End Sub

    Private Sub ClickedCenter() Handles MyBase.SwitchCenter
        Try
            If (m_PLCAddressClickLeft IsNot Nothing AndAlso (String.Compare(m_PLCAddressClickLeft, "") <> 0)) Then
                m_ComComponent.Write(m_PLCAddressClickLeft, 0)
            End If

            If (m_PLCAddressClickRight IsNot Nothing AndAlso (String.Compare(m_PLCAddressClickRight, "") <> 0)) Then
                m_ComComponent.Write(m_PLCAddressClickRight, 0)
            End If
        Catch ex As Exception
            DisplayError("WRITE FAILED!" & ex.Message)
        End Try
    End Sub

    Private Sub ClickedRight() Handles MyBase.SwitchRight
        Try
            If (m_PLCAddressClickLeft IsNot Nothing AndAlso (String.Compare(m_PLCAddressClickLeft, "") <> 0)) Then
                m_ComComponent.Write(m_PLCAddressClickLeft, 0)
            End If

            If (m_PLCAddressClickRight IsNot Nothing AndAlso (String.Compare(m_PLCAddressClickRight, "") <> 0)) Then
                m_ComComponent.Write(m_PLCAddressClickRight, 1)
            End If
        Catch ex As Exception
            DisplayError("WRITE FAILED!" & ex.Message)
        End Try
    End Sub


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
                ErrorDisplayTime.Interval = 5000
            End If

            '* Save the text to return to
            If Not ErrorDisplayTime.Enabled Then
                OriginalText = Me.Text
            End If

            ErrorDisplayTime.Enabled = True

            Me.Text = ErrorMessage
        End If
    End Sub


    '**************************************************************************************
    '* Return the text back to its original after displaying the error for a few seconds.
    '**************************************************************************************
    Private Sub ErrorDisplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErrorDisplayTime.Tick
        Text = OriginalText

        If ErrorDisplayTime IsNot Nothing Then
            ErrorDisplayTime.Enabled = False
            ErrorDisplayTime.Dispose()
            ErrorDisplayTime = Nothing
        End If
    End Sub
#End Region

End Class
