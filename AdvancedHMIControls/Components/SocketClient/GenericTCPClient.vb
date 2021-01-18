Option Strict On
Imports System.Net.Sockets
'**********************************************************************************************
'* Generic TCp Client
'*
'* Archie Jacobs
'* Manufacturing Automation, LLC
'* support@advancedhmi.com
'* 19-JAN-18
'*
'* This client will connect to a TCP server and listen for data
'* When data is received, it will buffer until receing the value
'* specified by TerminatingByteValue. At that point it will fire the
'* DataReceived event and send the received data
'* 
'* Copyright 2018 Archie Jacobs
'* Licensed under GPL v3
'*
'* Reference : 
'*
'**********************************************************************************************
<System.ComponentModel.DefaultEvent("DataReceived")>
Public Class GenericTcpClient
    Inherits System.ComponentModel.Component
    Implements IDisposable
    Implements System.ComponentModel.ISupportInitialize

    Private WorkSocket As System.Net.Sockets.Socket

    Public Event DataReceived As EventHandler(Of GenericTcpEventArgs)
    Public Event ConnectionClosed As EventHandler
    Public Event ConnectionEstablished As EventHandler
    Public Event ComError As EventHandler(Of MessageEventArgs)

    Private m_synchronizationContext As System.Threading.SynchronizationContext

    Private TestConnectionTask As System.Threading.Tasks.Task
    Private EndTaskToken As New Threading.CancellationTokenSource




#Region "Constructor/Destructors"
    Public Sub New()
        'DataReceivedCallBackDelegate = New AsyncCallback(AddressOf DataReceivedCallback)
        m_ProtocolType = Net.Sockets.ProtocolType.Tcp
        m_synchronizationContext = System.Windows.Forms.WindowsFormsSynchronizationContext.Current
    End Sub



    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)

        If disposing Then
            EndTaskToken.Cancel(True)
            TestConnectionTask.Wait()

            CloseConnection()

            If EndTaskToken IsNot Nothing Then EndTaskToken.Dispose()
        End If
    End Sub
#End Region

#Region "Properties"
    Private m_IPAddress As String = "192.168.0.1"   '* this is a deafult value
    Public Property IPAddress() As String
        Get
            Return m_IPAddress.ToString
        End Get
        Set(ByVal value As String)
            Dim address As New System.Net.IPAddress(0)
            If System.Net.IPAddress.TryParse(m_IPAddress, address) AndAlso System.Net.IPAddress.TryParse(value, address) Then
                If Not System.Net.IPAddress.Parse(m_IPAddress).Equals(System.Net.IPAddress.Parse(value)) Then
                    '* if the address is changed, be sure to disconnect first
                    If WorkSocket IsNot Nothing AndAlso WorkSocket.Connected Then
                        CloseConnection()
                    End If
                End If
            Else
                If m_IPAddress <> value Then
                    '* if the address is changed, be sure to disconnect first
                    If WorkSocket IsNot Nothing AndAlso WorkSocket.Connected Then
                        CloseConnection()
                    End If
                End If
            End If
            m_IPAddress = value

        End Set
    End Property

    Private m_Port As UShort = 23
    Public Property Port As UShort
        Get
            Return m_Port
        End Get
        Set(value As UShort)
            If m_Port <> value Then
                If WorkSocket IsNot Nothing AndAlso WorkSocket.Connected Then
                    CloseConnection()
                End If
                m_Port = value
            End If
        End Set
    End Property

    Private Property m_ProtocolType As ProtocolType = ProtocolType.Tcp
    Public Property ProtocolType As ProtocolType
        Get
            Return m_ProtocolType
        End Get
        Set(value As ProtocolType)
            m_ProtocolType = value
        End Set
    End Property

    Private m_TerminatingByteValue As Byte = 13
    Public Property TerminatingByteValue As Byte
        Get
            Return m_TerminatingByteValue
        End Get
        Set(value As Byte)
            m_TerminatingByteValue = value
        End Set
    End Property

    Private m_AutoConnect As Boolean = True
    Public Property AutoConnect As Boolean
        Get
            Return m_AutoConnect
        End Get
        Set(value As Boolean)
            m_AutoConnect = value
        End Set
    End Property
#End Region


#Region "Private Methods"
    '*********************************************
    '* Connect to the socket and begin listening
    '* for responses
    '********************************************
    Private Sub Connect()
        Dim endPoint As System.Net.IPEndPoint
        Dim IP As System.Net.IPHostEntry

        Dim address As New System.Net.IPAddress(0)
        If System.Net.IPAddress.TryParse(m_IPAddress, address) Then
            endPoint = New System.Net.IPEndPoint(address, m_Port)
        Else
            Try
                IP = System.Net.Dns.GetHostEntry(m_IPAddress)
                '* Ethernet/IP uses port AF12 (44818)
                endPoint = New System.Net.IPEndPoint(IP.AddressList(0), m_Port)
            Catch ex As Exception
                Throw New FormatException("Can't resolve the address " & m_IPAddress)
                Exit Sub
            End Try
        End If


        If WorkSocket Is Nothing OrElse Not WorkSocket.Connected Then
            If m_ProtocolType = Net.Sockets.ProtocolType.Tcp Then
                WorkSocket = New System.Net.Sockets.Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
                '* Comment these out for Compact Framework
                WorkSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, 5000)
                WorkSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, True)
            Else
                WorkSocket = New System.Net.Sockets.Socket(endPoint.AddressFamily, SocketType.Dgram, m_ProtocolType)
            End If

            WorkSocket.SendTimeout = 2000
            WorkSocket.ReceiveBufferSize = &H5000
        End If

        Try
            Try
                WorkSocket.Connect(endPoint)
            Catch ex As SocketException
                '* Return an error code
                OnComError("Could Not Connect to Server : " & ex.Message)

                CloseConnection()
                Throw
            End Try


            OnConnectionEstablished(System.EventArgs.Empty)

            StartTestThread()
        Catch ex As SocketException
            ' 10035 == WSAEWOULDBLOCK
            If ex.NativeErrorCode.Equals(10035) Then
                'Throw
            Else
                Throw 'New Exception(m_IPAddress & " " & ex.Message)
            End If
        End Try


        WorkSocket.Blocking = True
        If m_ProtocolType = Net.Sockets.ProtocolType.Tcp Then
            WorkSocket.LingerState = New System.Net.Sockets.LingerOption(True, 1000)
        End If


        '* Don't buffer the data, so it goes out immediately
        '* Otherwise packets send really fast will get grouped
        '* And the PLC will not respond to all of them
        WorkSocket.SendBufferSize = 1

        Dim so As New Common.SocketStateObject
        so.WorkSocket = WorkSocket

        WorkSocket.BeginReceive(so.data, 0, so.data.Length, SocketFlags.None, AddressOf DataReceivedCallback, so)
    End Sub

    Private Sub StartTestThread()
        If TestConnectionTask Is Nothing OrElse (Not TestConnectionTask.Status = Threading.Tasks.TaskStatus.Created And
                                    Not TestConnectionTask.Status = Threading.Tasks.TaskStatus.Running And
                                    Not TestConnectionTask.Status = Threading.Tasks.TaskStatus.WaitingToRun) Then
            TestConnectionTask = System.Threading.Tasks.Task.Factory.StartNew(AddressOf TestConnection, EndTaskToken.Token)
        End If
    End Sub

    '* Runs as a background task to reconnect if connection is lost
    Private Sub TestConnection(ByVal cancelToken As Object)
        Dim token As Threading.CancellationToken = DirectCast(cancelToken, Threading.CancellationToken)

        While Not token.IsCancellationRequested
            'Console.WriteLine("Top of While")
            If AutoConnect Then
                If WorkSocket IsNot Nothing Then
                    If (WorkSocket.Poll(2000, SelectMode.SelectRead)) And (WorkSocket.Available = 0) Then
                        Try
                            CloseConnection()
                            Connect()
                        Catch ex As Exception
                        End Try
                        'Console.WriteLine(Now & "Open again")
                    End If
                Else
                    Try
                        Connect()
                    Catch ex As Exception
                    End Try
                End If
            End If

            token.WaitHandle.WaitOne(3000)
            'Threading.Thread.SpinWait(2000)
        End While
    End Sub

    '************************************************************
    '* Call back procedure - called when data comes back
    '* This is the procedure pointed to by the BeginWrite method
    '************************************************************
    Private ReceivedDataPacketBuilder As New List(Of Byte)
    Private DataReceivedLock As New Object
    Private Sub DataReceivedCallback(ByVal ar As System.IAsyncResult)
        ' Retrieve the state object and the client socket 
        ' from the asynchronous state object.
        Dim StateObject As Common.SocketStateObject = CType(ar.AsyncState, Common.SocketStateObject)


        '* If the socket was closed, then we cannot do anything
        If Not StateObject.WorkSocket.Connected Then
            Exit Sub
        End If

        '* Get the number of bytes read and add it to the state object accumulator
        Try
            '* Add the byte count to the state object
            StateObject.CurrentIndex += StateObject.WorkSocket.EndReceive(ar)
        Catch ex As Exception
            '* Return an error code
            OnComError("Socket Error : " & ex.Message)
            Exit Sub
        End Try

        SyncLock (DataReceivedLock)
            ' Console.WriteLine("DataReceived Received - Index=" & StateObject.CurrentIndex)

            '*************************************************************************************************************************
            Dim i As Integer = 0
            Dim CurrentByte As Byte

            While i < StateObject.CurrentIndex
                CurrentByte = StateObject.data(i)

                If CurrentByte = m_TerminatingByteValue Then
                    Dim dataArray As Byte() = ReceivedDataPacketBuilder.ToArray
                    Dim dataString As String = ""
                    For index2 = 0 To dataArray.Length - 1
                        If dataArray(index2) >= 32 And dataArray(index2) < 128 Then
                            dataString &= Chr(dataArray(index2))
                        End If
                    Next
                    OnDataReceived(New GenericTcpEventArgs(dataArray, dataString))

                    CurrentByte = 0 'make sure last byte isn't falsely 16
                    ReceivedDataPacketBuilder.Clear()

                Else
                    ReceivedDataPacketBuilder.Add(CurrentByte)
                End If

                i += 1
            End While
        End SyncLock

        Dim so As New Common.SocketStateObject(WorkSocket)

        WorkSocket.BeginReceive(so.data, 0, so.data.Length, SocketFlags.None, AddressOf DataReceivedCallback, so)
    End Sub



#End Region

#Region "Public Methods"
    Public Sub CloseConnection()
        Try
            If WorkSocket IsNot Nothing Then
                If WorkSocket.Connected Then
                    Try
                        WorkSocket.Shutdown(System.Net.Sockets.SocketShutdown.Send)
                    Catch ex As Exception
                    End Try
                    WorkSocket.Close()
                    OnConnectionClosed(System.EventArgs.Empty)
                End If
                If WorkSocket IsNot Nothing Then
                    WorkSocket.Dispose()
                    WorkSocket = Nothing
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    '*********************************
    '* Send data out the tcp socket
    '*********************************
    Public Sub SendPacket(ByVal data() As Byte) 'As Boolean ' System.IAsyncResult
        '* connect if it has not been already
        If data IsNot Nothing Then
            If WorkSocket Is Nothing OrElse Not WorkSocket.Connected Then
                Connect()
            End If


            Try
                WorkSocket.Send(data, data.Length, SocketFlags.None)
            Catch ex As Exception
                CloseConnection()
                Throw
            End Try
        End If
    End Sub

    Public Sub SendString(ByVal s As String)
        Dim data() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes(s & CStr(Chr(m_TerminatingByteValue)))
        SendPacket(data)
    End Sub

    Public Sub BeginInit() Implements System.ComponentModel.ISupportInitialize.BeginInit
    End Sub

    Public Sub EndInit() Implements System.ComponentModel.ISupportInitialize.EndInit
        Try
            If Not DesignMode And AutoConnect Then
                StartTestThread()
                'Connect()
            End If
        Catch
        End Try
    End Sub
#End Region

#Region "Events"
    Protected Sub OnDataReceived(ByVal e As GenericTcpEventArgs)
        If m_synchronizationContext IsNot Nothing Then
            Try
                m_synchronizationContext.Post(AddressOf DataReceivedSync, e)
            Catch
            End Try
        Else
            RaiseEvent DataReceived(Me, e)
        End If
    End Sub

    Private Sub DataReceivedSync(ByVal e As Object)
        Try
            Dim e1 As GenericTcpEventArgs = DirectCast(e, GenericTcpEventArgs)
            RaiseEvent DataReceived(Me, e1)
        Catch ex As Exception
            'Dim dbg = 0
        End Try
    End Sub


    Protected Overridable Sub OnComError(ByVal description As String)
        RaiseEvent ComError(Me, New MessageEventArgs(description))
    End Sub

    Protected Overridable Sub OnConnectionClosed(ByVal e As EventArgs)
        RaiseEvent ConnectionClosed(Me, e)
    End Sub

    Protected Overridable Sub OnConnectionEstablished(ByVal e As EventArgs)
        RaiseEvent ConnectionEstablished(Me, e)
    End Sub
#End Region
End Class
