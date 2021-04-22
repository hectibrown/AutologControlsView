Public Class StAlarmMessages
    Public szIntlk(249) As String
    Public szMsg(249) As String
    Public szLineError(249) As String
End Class

Public Class StAlarmBits
    Public bIntlk(255) As Boolean
    Public bMsg(255) As Boolean
    Public bLineError(255) As Boolean
End Class
Public Class StAlarmIdDetail
    Public dIntlkIdDetail(249) As Int32
    Public dLeIdDetail(249) As Int32
    Public dMsgIdDetail(249) As Int32
End Class

Public Class StAlarms
    Public szString As New StAlarmMessages
    Public bBits As New StAlarmBits
    Public IdDetail As New StAlarmIdDetail
End Class
