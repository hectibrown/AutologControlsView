Public Class StAcvMain
    Public dWatchDog As New Int32
    Public dNbAlarms As New Int32
    Public dLugIdxHistory As New Int32
    Public dConnected As New Int32
    Public szAlarm As String
    Public dRxMsgNb As String
    Public dOldMsgNb As String
    Public dOldWatchDog As New Int32
    Public dOldNbAlarms As New Int32
    Public dCommErrorCode As New Int32
    Public dMessegeLoadStep As New Int32
    Public bCommsOk As New Boolean

End Class

Public Class StAcvComm
    Public Data(99) As Int32
End Class