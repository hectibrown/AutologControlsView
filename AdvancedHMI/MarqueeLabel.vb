
Imports System.Windows.Forms

Public Class MarqueeLabel
    Inherits System.Windows.Forms.Label
    Private _CurrentText As String = "Paul's Custom Marquee"
    Private _Scrolltext As String = "Paul's Custom Marquee"
    Public _MarqueeText As String = "Paul's Custom Marquee"
    Private _Direction As Direction = Direction.Left
    Private _ScrollLength As Integer = 1000000
    WithEvents Timer1 As New System.Windows.Forms.Timer
    Private Property _Interval As Integer = 500
    Public Property Interval As Integer
        Get
            Return _Interval
        End Get
        Set(ByVal value As Integer)
            _Interval = value
            Timer1.Interval = value
        End Set
    End Property
    Public ReadOnly Property MarqueeText As String
        Get
            Return _MarqueeText
        End Get
    End Property
    Public Property ScrollDirection As Direction
        Get
            Return _Direction
        End Get
        Set(ByVal value As Direction)
            _Direction = value
        End Set
    End Property
    Private ReadOnly Property CurrentText As String
        Get
            Return _CurrentText
        End Get
    End Property
    Public Property ScrollText As String
        Get
            Return _Scrolltext
        End Get
        Set(ByVal value As String)
            _Scrolltext = value & Space(Len(value))
            _CurrentText = value
        End Set
    End Property
    Public Property ScrollLength As Integer
        Get
            Return _ScrollLength
        End Get
        Set(ByVal value As Integer)
            If value < 1 Then value = 1
            _ScrollLength = value
        End Set
    End Property
    Public Sub ScrollStart()
        Timer1.Enabled = True
    End Sub
    Public Sub ScrollStop()
        Timer1.Enabled = False
    End Sub
    Sub New(ByVal Text As String, Optional ByVal Interval As Integer = 500, Optional ByVal ScrollDirection As Direction = Direction.Right, Optional ByVal ScrollLength As Integer = 5)
        Me.ScrollText = Text & Space(Len(Text))
        Me.Interval = Interval
        Me.ScrollDirection = ScrollDirection
        Me.ScrollLength = ScrollLength
    End Sub
    Private Sub Tick() Handles Timer1.Tick
        If ScrollLength > Len(_Scrolltext) Then ScrollLength = Len(_Scrolltext)
        If ScrollDirection = Direction.Left Then
            Dim MoveCharacter As String = Mid$(_CurrentText, 1, 1)
            _CurrentText = Replace(_CurrentText, MoveCharacter, "", 1, 1)
            _CurrentText = _CurrentText & MoveCharacter
            _MarqueeText = Mid$(_CurrentText, 1, _ScrollLength)
            Me.Text = _MarqueeText
        ElseIf ScrollDirection = Direction.Right Then
            Dim MoveCharacter As String = Mid$(_CurrentText, Len(_CurrentText), 1)
            _CurrentText = Mid$(_CurrentText, 1, Len(_CurrentText) - 1)
            _CurrentText = MoveCharacter & _CurrentText
            _MarqueeText = Mid$(_CurrentText, 1, _ScrollLength)
            Me.Text = _MarqueeText
        End If
    End Sub
    Public Enum Direction
        Left
        Right
    End Enum
End Class
