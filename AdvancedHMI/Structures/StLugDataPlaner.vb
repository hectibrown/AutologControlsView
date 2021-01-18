Public Class StBaseDataPlaner
    Public dUvCode As Int32
    Public dIdNumber As Int32
    Public dThickBefore As Int32
    Public dWidthBefore As Int32
    Public dLengthBefore As Int32
    Public dVolumeBefore As Int32
    Public dRealDensity As Int32
    Public dThick(1) As Int32
    Public dWidth(1) As Int32
    Public dLength(1) As Int32
    Public dGrade(1) As Int32
    Public dGraderId As Int32
    Public dSpecie As Int32
    Public dSortingSpecie As Int32
    Public dColor(1) As Int32
    Public dDestination(1) As Int32
    Public dBin(1) As Int32
    Public dSort(1) As Int32
    Public dSubSort(1) As Int32
    Public dParamTable(1) As Int32
    Public dPmpCalculation As Int32
    Public dActiveTable(1) As Int32
    Public dSortingTable(1) As Int32
    Public dIdentityInBin(1) As Int32
    Public dLastPieceTimeStamp(1) As Int32
    Public dBinTest As Int32
    Public dTestId As Int32
    Public dTestNoTrim As Int32
    Public dInfoCode As Int32
    Public dOptiInfo As Int32
    Public dPrinterInfo As Int32
    Public dManualReason As Int32
    Public dCodeErr As Int32
    Public dSortError(1) As Int32
    Public dVolume(1) As Int32
    Public dCountValue(1) As Int32
    Public dNbProduct As Int32
    Public dZone As Int32
    Public dIdxPieces As Int32
    Public dTrimBlocks(9) As Int32
    Public dAnticipatedUvCode As Int32
    Public dJBarNum As Int32
    Public dLugSlave As Int32
    Public dLugMaster As Int32
    Public dFencePaddleNum As Int32
    Public dLastUvCode As Int32
    Public dSawsB1 As Int32
    Public dSawsOutB1 As Int32
    Public dSawsB2(1) As Int32
    Public dSawsOutB2(1) As Int32
    Public dCITSawBit As Int32
    Public dReopCode As Int32
End Class

Public Class StFlagPlaner
    Public dPresence As Boolean
    Public bPresenceUv As Boolean
    Public bPresenceGMR As Boolean
    Public bPresenceOptiSol As Boolean
    Public bPresenceTrimmer As Boolean
    Public bPresenceLengthConf As Boolean
    Public bPresenceSorter As Boolean
    Public bPresenceLostPiece As Boolean
    Public bPresenceSolution As Boolean
    Public bPresenceSolutionCmd8 As Boolean
    Public bPresenceIn As Boolean
    Public bPresenceOut As Boolean
    Public bBoardLoaded As Boolean
    Public bStartInAuto As Boolean
    Public bAuto As Boolean
    Public bReEntry As Boolean
    Public bNoTrim As Boolean
    Public bTestOpti As Boolean
    Public bTestOptiNoTrim As Boolean
    Public bReject As Boolean
    Public bSlash As Boolean
    Public bSlashOpti As Boolean
    Public bSlashConsole As Boolean
    Public bAnticipatedCIT As Boolean
    Public bGmrCIT As Boolean
    Public bOptiCIT As Boolean
    Public bCITSecondPiece As Boolean
    Public bOptiSolNotValid As Boolean
    Public bOptiSolTooLate As Boolean
    Public bManFenceRecieved As Boolean
    Public bDefaultTrim As Boolean
    Public bBadUvCode As Boolean
    Public bBadUvGuess As Boolean
    Public bLs0Missed As Boolean
    Public bTooShort As Boolean
    Public bNextLugEmpty As Boolean
    Public bJBarCanceled As Boolean
    Public bFencePaddleCanceled As Boolean
    Public bForceReOp As Boolean
    Public bNeedSubFe As Boolean
    Public bSimul As Boolean
    Public bStoryBoard As Boolean
    Public bTestFenceChecker As Boolean
    Public bTestLengthSensors As Boolean
    Public bTestLengthConfSensors As Boolean
    Public bPassedFenceTiming As Boolean
    Public bNeedOptiReOp As Boolean
    Public bNoOptiReOp As Boolean
    Public bBypassOptiInfo As Boolean
End Class

Public Class StInputPlaner
    Public dLsInfeed As Int32
    Public dLsLength(1) As Int32
    Public dLength(1) As Int32
    Public dLsLengthConf As Int32
    Public dLengthConf As Int32
    Public dLsPosConfrim As Int32
    Public dPosConfirm As Int32
    Public dLsLengthNeg As Int32
    Public dLengthNeg As Int32
    Public dSawProx(1) As Int32
    Public dFenceConfirmation As Int32
    Public dFenceConfirmationB2 As Int32
    Public dSmallestWidth As Int32
    Public dGreatestWidth As Int32
    Public dAverageWidth As Int32
    Public dMedianWidth As Int32
    Public dFinalWidth As Int32
End Class

Public Class StOutputPlaner
    Public dSawsApplied As Int32
    Public dSawsAppliedB2 As Int32
    Public dCITSawsApplied As Int32
    Public dGates(1) As Int32
    Public dFence As Int32
    Public dFenceB2(1) As Int32
    Public dCitSkidsApplied As Int32
    Public dSprays As Int32
    Public dStamps(1) As Int32
    Public dNeSawIdx(1) As Int32
    Public dFeSawIdx(1) As Int32
    Public dNeCitSawIdx(1) As Int32
    Public dFeCitSawIdx(1) As Int32
    Public dMobileSawPos(1) As Int32
    Public dMaskPaintApplied(1) As Int32
End Class

Public Class StGMRPlaner
    Public dNeTrimBits As Int32
    Public dFetrimBits As Int32
    Public dNeTrimVal As Int32
    Public dFeTrimVal As Int32
    Public dGrade(1) As Int32
    Public dColor(1) As Int32
    Public dSpecie As Int32
    Public dFenceBits As Int32
    Public dFenceVal As Int32
    Public dCITBits As Int32
    Public dNeCitVal As Int32
    Public dFeCitVal As Int32
    Public dNeMisc As Int32
    Public dFeMisc As Int32
    Public bNEReman As Boolean
    Public bFEReman As Boolean
    Public bReject As Boolean
    Public bNoMark As Boolean
    Public bSlash As Boolean
    Public bNoTrim As Boolean
    Public bUnrecognized As Boolean
End Class

Public Class StSolutionTxPlaner
    Public dCmdVer As Int32
    Public dCmd As Int32
    Public dThick(1) As Int32
    Public dWidth(1) As Int32
    Public dLength(1) As Int32
    Public dNETrim As Int32
    Public dFETrim As Int32
    Public dCIT(1) As Int32
    Public dGrade(1) As Int32
    Public dColor(1) As Int32
    Public dDivers(1) As Int32
    Public dSpecie As Int32
    Public dForceFence As Int32
    Public dSideBent As Int32
    Public dTaper As Int32
    Public dCustom1 As Int32
    Public dCustom2 As Int32
    Public dCustom3 As Int32
    Public dIdxPcs As Int32
    Public bNoMoreFence As Boolean
    Public bForceReject As Boolean
    Public bCancelDestination1 As Boolean
    Public bCancelDestination2 As Boolean
    Public bCancelUpdateDestination1 As Boolean
    Public bCancelUpdateDestination2 As Boolean
    Public bUseGraderInfo As Boolean
    Public bUseOptiInfo As Boolean
    Public bUseDefaultInfo As Boolean
End Class

Public Class StSolutionRxPlaner
    Public dCommVer As Int32
    Public dCmd As Int32
    Public dLugId As Int32
    Public dSortingIndex As Int32
    Public dSolError As Int32
    Public dThicknessIn As Int32
    Public dWidthIn As Int32
    Public dLengthIn As Int32
    Public dSpecie As Int32
    Public dNbProduct As Int32
    Public dPmpMethod As Int32
    Public dVolumeIn As Int32
    Public dVolume(1) As Int32
    Public dCountValue(1) As Int32
    Public dSortError(1) As Int32
    Public dStamps(1) As Int32
    Public dSaws As Int32
    Public dSawsWithBlocks As Int32
    Public dSawsOut As Int32
    Public dNeSawIdx(1) As Int32
    Public dFeSawIdx(1) As Int32
    Public dNeCitSawIdx(1) As Int32
    Public dFeCitSawIdx(1) As Int32
    Public dThickness(1) As Int32
    Public dWidth(1) As Int32
    Public dLength(1) As Int32
    Public dGrade(1) As Int32
    Public dColor(1) As Int32
    Public dSort(1) As Int32
    Public dSubSort(1) As Int32
    Public dDestination(1) As Int32
    Public dBin(1) As Int32
    Public dIdentityInBin(1) As Int32
    Public dLastPieceTimeStamp(1) As Int32
    Public dParamTable(1) As Int32
    Public dActiveTable(1) As Int32
    Public dSortingTable(1) As Int32
    Public dFence As Int32
    Public dFenceB2(1) As Int32
    Public dMobileSawPos(1) As Int32
    Public dSawsB2(1) As Int32
    Public dSawsOutB2(1) As Int32
    Public dValid As Int32
    Public dForceReOp As Int32
End Class

Public Class StTimingPlaner
    Public dOptiCmd2ReqTime As Int32
    Public dOptiCmd2RecTime As Int32
    Public dOptiCmd2DelayTime As Int32
    Public dOptiCmd2ReqCtlg As Int32
    Public dOptiCmd2RecCtlg As Int32
    Public dOptiCmd2DelayCtlg As Int32
    Public dCmd8ReqTime As Int32
    Public dCmd8RecTime As Int32
    Public dCmd8DelayTime As Int32
    Public dCmd8ReqCtlg As Int32
    Public dCmd8RecCtlg As Int32
    Public dCmd8DelayCtlg As Int32
    Public dCmd6ReqTime As Int32
    Public dCmd6RecTime As Int32
    Public dCmd6DelayTime As Int32
    Public dCmd6ReqCtlg As Int32
    Public dCmd6RecCtlg As Int32
    Public dCmd6DelayCtlg As Int32
    Public dCmd2ReqTime As Int32
    Public dCmd2RecTime As Int32
    Public dCmd2DelayTime As Int32
    Public dCmd2ReqCtlg As Int32
    Public dCmd2RecCtlg As Int32
    Public dCmd2DelayCtlg As Int32
End Class

Public Class StLugDataPlaner
    Public BaseData As StBaseDataPlaner
    Public Flag As StFlagPlaner
    Public Input As StInputPlaner
    Public Output As StOutputPlaner
    Public Console As StGMRPlaner
    Public Cmd2Tx As StSolutionTxPlaner
    Public Cmd6Tx As StSolutionTxPlaner
    Public Cmd8Tx As StSolutionTxPlaner
    Public Cmd2Rx As StSolutionRxPlaner
    Public Cmd6Rx As StSolutionRxPlaner
    Public Cmd8Rx As StSolutionRxPlaner
    Public Timing As StTimingPlaner
End Class

Public Class StLug
    Public Data(199) As StLugDataPlaner
End Class

Public Class StLugsPlaner
    Public Master As New StLug
    Public Slave As New StLug
End Class
