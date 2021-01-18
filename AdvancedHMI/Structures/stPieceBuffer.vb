Public Class StOptiTxLinear
    Public dLogId As Int32
    Public dLogLength As Int32
    Public dActiveTable As Int32
    Public dTwinActive As Int32
    Public dProfilersActive As Int32
    Public dActualBin As Int32
    Public dNbManualLogs As Int32
    Public dLastGap As Int32
End Class
Public Class StOptiRxTurnerPrepos
    Public rFirstCenter As Single
    Public rFirstDiam As Single
End Class

Public Class StOptiRxTurner
    Public dIdOpti As Int32
    Public rFirstDiam As Single
    Public rLastDiam As Single
    Public rLastDiam2 As Single
    Public rRotation As Single
    Public rRotationDeg As Single
    Public bHornDirection As Boolean
    Public bButtFirst As Boolean
    Public rSweeep As Single
    Public rTaper As Single
    Public dDistSart As Int32
    Public dDistEnd As Int32
    Public rDistanceBetweenSections As Int32
    Public dNbSections As Int32
    Public rDiameters(249) As Single
End Class

Public Class StOptiRxFinalSolLinear
    Public dIdOpti As Int32
    Public bValid As Int32
    Public dLength As Int32
    Public dVolume As Int32
    Public dFinishedVol As Int32
    Public rLeftCanter As Single
    Public rRigthCanter As Single
    Public rLeftTwin1 As Single
    Public rRigthTwin1 As Single
    Public rLeftTwin2 As Single
    Public rRightTwin2 As Single
    Public dSpeed As Int32
    Public rLeftBoard2 As Single
    Public rLeftBoard1 As Single
    Public rCantSize As Single
    Public rRightBoard1 As Single
    Public rRightBoard2 As Single
    Public dPatern(7) As Int32
    Public rInfeedShiftPos As Single
    Public rTopHeadPos As Single
    Public rInfeedLiftSlope As Single
End Class

Public Class StTurnerPositions
    Public rPrePos As Single
    Public rLiftMove As Single
    Public rTurnMove As Single
End Class

Public Class StTimingLinear
    Public dTiming(15) As Int32
End Class

Public Class StActionLinear
    Public dDistance As Int32
    Public dDistanceReverse As Int32
    Public rCompensation As Single
    Public dStep As Int32
    Public bOnRisingEdge As Boolean
    Public bOnRisingEdgeRev As Boolean
    Public bExecute As Boolean
    Public bExecuteRev As Boolean
End Class

Public Class StDiametersLinear
    Public rDiameter(249) As Single
End Class


Public Class StPieceDataLinear
    Public dIdOpti As Int32
    Public dRe As Int32
    Public dOldRe As Int32
    Public dFe As Int32
    Public dOldFe As Int32
    Public dLength As Int32
    Public DistLock As Int32
    Public DistLockRev As Int32
    Public DistSinceLock As Int32
    Public dNextPc As Int32
    Public bTrackingExpired As Boolean
    Public bLocked As Boolean
    Public LockedRev As Boolean
    Public dGap As Int32
    Public ToOpti As New StOptiTxLinear
    Public TurnerClosePrepos As New StOptiRxTurnerPrepos
    Public TurnerSol As New StOptiRxTurner
    Public Solution As New StOptiRxFinalSolLinear
    Public TurnerPositions() As StTurnerPositions = New StTurnerPositions(1) {}
    Public Timing As New StTimingLinear
    Public Action() As StActionLinear = New StActionLinear(49) {}
    Public Diameters As New StDiametersLinear
    Public dManualSetId As Int32
    Public rDiameterForPresses As Single
    Public dSpeed As Int32
    Public rLeftCanterPos As New Single
    Public rRightCanterPos As Single
    Public rLeftSawPos As Single
    Public rRightSawPos As Single
    Public rInfeedLiftPos As Single
    Public rInfeedLiftSlope As Single
    Public rInfeedShiftPos As Single
    Public rTopHeadPos As Single
    Public bTurnerClosePreposRx As Boolean
    Public bSolTx As Boolean
    Public bTurnerSolRx As Boolean
    Public bSolRx As Boolean
    Public bSolValid As Boolean
    Public bShiftSolRx As Boolean
    Public bManual As Boolean
    Public bSideBoard As Boolean
    Public bSideCants As Boolean
    Public bScrap As Boolean
    Public bTooLong As Boolean
    Public bTooShort As Boolean
    Public szPattern As String82
    Public dSpare(9) As Int32
    Public rLeftSide As Single
    Public rCant As Single
    Public rRightSide As Single
End Class

Public Class StPieceBuffer
    Public dBufferLength As New Int32
    Public dPieceId As New Int32
    Public Data As StPieceDataLinear() = New StPieceDataLinear(9) {}
End Class

Public Class StLogs9
    Public Data() As StPieceDataLinear = New StPieceDataLinear(9) {}
End Class