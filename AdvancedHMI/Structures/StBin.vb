Public Class FbBin
    Public EnableIn As Boolean
    Public EnableOut As Boolean
    Public In_SelectorUp As Boolean
    Public In_SelectorDown As Boolean
    Public In_PanelViewUp As Boolean
    Public In_PanelViewDown As Boolean
    Public In_Pb_Soft As Boolean
    Public In_Pb_Kicker As Boolean
    Public In_Pb_FlipFlop As Boolean
    Public In_LevelSensor As Boolean
    Public In_SensorUp As Boolean
    Public In_SensorDown As Boolean
    Public In_AutoUp As Boolean
    Public In_AutoDown As Boolean
    Public In_Full As Boolean
    Public Is_Reject As Boolean
    Public In_Disable As Boolean
    Public In_PreviousBinUnderSensorDown As Boolean
    Public In_PreviousBinLatchDown As Boolean
    Public In_NextBinUnderSensorDown As Boolean
    Public In_NextBinLatchDown As Boolean
    Public In_HPU_Running As Boolean
    Public In_SorterRunning As Boolean
    Public In_TestLamp As Boolean
    'Public InFlashCode(12) As Boolean
    'Public InParam(8) As Int32
    'Public InParamBool(5) As Boolean
    Public Out_bBinUp As Boolean
    Public Out_bBinDown As Boolean
    Public Out_bSoftDisDwn As Boolean
    Public Out_bLight As Boolean
    Public Out_bForceFlipFlop As Boolean
    Public Out_bForceKicker As Boolean
    Public bLatchUp As Boolean
    Public bLatchDown As Boolean
    Public bResetCmd As Boolean
    Public bOnSensorDown As Boolean
    Public bUnderSensorDown As Boolean
    Public bBinLevelSensorBlocked As Boolean
    Public bDischargeDone As Boolean
    Public bCloseFrontSoft As Boolean
End Class

Public Class StBinPv
    Public dAdjustCount As Int32
    Public dAdjustMaxCount As Int32
    Public bResetBin As Boolean
    Public bBinEnable As Boolean
    Public bFillBin As Boolean
    Public bPbBinUp As Boolean
    Public bPbBinDown As Boolean
    Public bUnit As Boolean
End Class


Public Class StBinData
    Public BinPv As New StBinPv
    Public rThickness(2) As Single
    Public rWidth(2) As Single
    Public rLength(2) As Single
    Public dBinNo As Int32
    Public dStatus As Int32
    Public dDistance As Int32
    Public dDuration As Int32
    Public dRecipeId As Int32
    Public dActual As Int32
    Public dMaximum As Int32
    Public dPercent As Int32
    Public dGrade(2) As Int32
    Public dSpecie(2) As Int32
    Public dColor(2) As Int32
    Public dUseTransfer As Int32
    Public dLastPieceTimeStamp As Int32
    Public dNbPcs As Int32
    Public dNbBundle As Int32
    Public bClosing As Boolean
    Public bLastPiece As Boolean
    Public bKicker As Boolean
    Public bFlipFlop As Boolean
    Public szDescription As String
    Public Control As New FbBin
End Class

Public Class StBin
    'Public Data(99) As StBinData
    Public Data As StBinData() = New StBinData(99) {}
    Public dCompensation As Int32
    Public dPViewNbBinFull As Int32
    Public dLevelSensorBlockedNum As Int32
    Public bLevelSensorBlocked As Boolean
End Class

Public Class StBinMisc

    Public dBinNo As New Int32
    Public dSort As New Int32
    Public dStatus As New Int32
    Public dDistance As New Int32
    Public dDuration As New Int32
    Public dRecipeId As New Int32
    Public dActual As New Int32
    Public dMaximum As New Int32
    Public dPercent As New Int32
    Public dUseTransfer As New Int32
    Public dLastPieceTimeStamp As New Int32
    Public dGrade As Int32() = New Int32(2) {}
    Public dSpecies As Int32() = New Int32(2) {}
    Public dColor As Int32() = New Int32(2) {}
    Public dNbPcs As New Int32
    Public dNbBundle As New Int32
    Public rThickness As Single() = New Single(2) {}
    Public rWidth As Single() = New Single(2) {}
    Public rLength As Single() = New Single(2) {}
    Public szDescription As String
    Public bClosing As New Boolean
    Public bLastPiece As New Boolean
    Public bKicker As New Boolean
    Public bFlipFlop As New Boolean

End Class