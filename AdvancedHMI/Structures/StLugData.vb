Public Class StBaseData
    Public dNbProduct As Int32
    Public dOptiNumber As Int32
    Public dIdxPcs As Int32
    Public dThickBefore As Int32
    Public dWidthBefore As Int32
    Public dLengthBefore As Int32
    Public dVolumeBefore As Int32
    Public dThickNom(1) As Int32
    Public dWidthNom(1) As Int32
    Public dLengthNom(1) As Int32
    Public dRealLength(1) As Int32
    Public dVolume(1) As Int32
    Public dGrade(1) As Int32
    Public dSpecie As Int32
    Public dSortingSpecie As Int32
    Public dGraderId As Int32
    Public dColor(1) As Int32
    Public dDestination(1) As Int32
    Public dBin(1) As Int32
    Public dSort(1) As Int32
    Public dSubSort(1) As Int32
    Public dParamTable(1) As Int32
    Public dActiveTable(1) As Int32
    Public dSortingTable(1) As Int32
    Public dIdentityInBin(1) As Int32
    Public dLastPieceTimeStamp(1) As Int32
    Public dZone As Int32
    Public dWayneId As Int32
    Public dFencePaddleNum As Int32
    Public dConcentratorId As Int32
    Public dIdNumber As Int32
    Public dCodeErr As Int32
    Public dInfoCode As Int32
    Public dOptiInfo As Int32
    Public dSortError(1) As Int32
    Public dTrimBlocks(9) As Int32
    Public dJBarNum As Int32
    Public dCountValue(1) As Int32
    Public dPmpCalculation As Int32
    Public dFenceTrackNum As Int32
    Public dLugSlave As Int32
    Public bPresenceOut As Boolean
    Public bPresenceIn As Boolean
    Public dTaper As Int32
    Public dSideBent As Int32
End Class

Public Class StFlag
    Public dPresenceTrimmer As Int32
    Public dFencePosErr As Int32
    Public bSimul As Boolean
    Public bBoardLoaded As Boolean
    Public bJBarCanceled As Boolean
    Public bFencePaddleCanceled As Boolean
    Public bPresenceSolutionOpti As Boolean
    Public bPresenceLengthConf As Boolean
    Public bReject As Boolean
    Public bPresenceSorter As Boolean
    Public bPresenceSortingAcc As Boolean
    Public bFencePositionReqPassed As Boolean
    Public bSolutionTooLate As Boolean
    Public bSlash As Boolean
    Public bTestopti As Boolean
    Public bReman As Boolean
    Public bStoryBoard As Boolean
    Public bTestFenceChecker As Boolean
    Public bTestLengthSensors As Boolean
    Public bTestLengthConfSensors As Boolean
End Class

Public Class StInput
    Public dLsLength As Int32
    Public dLsLengthConf(1) As Int32
    Public dLsSorterConf As Int32
    Public dReadThickness As Int32
    Public dReadWidth As Int32
    Public dMoistureData As Int32
    Public dPxSaws As Int32
End Class

Public Class StOutput
    Public dFence(1) As Int32
    Public dFenceConfirmation(1) As Int32
    Public dSaws(1) As Int32
    Public dSawsOut(1) As Int32
    Public dSawsApplied(1) As Int32
    Public dSawsProx(1) As Int32
    Public dMobileSawPos(1) As Int32
    Public dGateRemanSmart As Int32
    Public dGateShort As Int32
    Public dJumpArm As Int32
    Public dWayneSpray As Int32
    Public dStamps(1) As Int32
    Public dInkJet1(2) As Int32
    Public dInkJet2(2) As Int32
    Public dPaddlefenceUsed As Int32
    Public dFinalFencePos As Int32
End Class

Public Class StConsoleButtonData
    Public bInput As Boolean
    Public bOldInput As Boolean
    Public bLightOutput As Boolean
End Class

Public Class StConsole
    Public dNeTrim As Int32
    Public dFeTrim As Int32
    Public dNeCit As Int32
    Public dFeCit As Int32
    Public dNeGrade As Int32
    Public dFeGrade As Int32
    Public dNeDestination As Int32
    Public dFeDestination As Int32
    Public dSpecie As Int32
    Public dFenceCancelled As Int32
    Public dCitCancelled As Int32
    Public dNeColor As Int32
    Public dFeColor As Int32
    Public dNeMisc As Int32
    Public dFeMisc As Int32
    Public dNeTrimBits As Int32
    Public dFetrimBits As Int32
    Public bRemanCancel As Boolean
    Public bSlash As Boolean
    Public bReman As Boolean
    Public ButtonData(19) As StConsoleButtonData
End Class

Public Class StOptiTrimmerRx
    Public dCmdId As Int32
    Public dLugId As Int32
    Public dNbProduct As Int32
    Public dOptiNumber As Int32
    Public dThickBefore As Int32
    Public dWidthBefore As Int32
    Public dLengthBefore As Int32
    Public dVolumeBefore As Int32
    Public dThickNom(1) As Int32
    Public dWidthNom(1) As Int32
    Public dLengthNom(1) As Int32
    Public dLengthReal(1) As Int32
    Public dVolume(1) As Int32
    Public dGrade(1) As Int32
    Public dDestination(1) As Int32
    Public dFence As Int32
    Public dSaws(1) As Int32
    Public dSawsOut(1) As Int32
    Public dSawsB2(1) As Int32
    Public dSawsOutB2(1) As Int32
    Public dMobileSawPos As Int32
    Public dGates(4) As Int32
    Public dWayneSpray(1) As Int32
    Public dSorterRealVol As Int32
    Public dAlarm As Int32
    Public dThickNomBefTrim As Int32
    Public dWidthNomBefTrim As Int32
    Public dLengthNomBefTrim As Int32
    Public dRemanRealLength(1) As Int32
    Public dRemanNomLength(1) As Int32
    Public dRemanNomVol(1) As Int32
    Public dSpray(1) As Int32
    Public dSpare1 As Int32
End Class

Public Class StOptiTrimmerTx
    Public dCmd As Int32
    Public dLugIdx As Int32
    Public dConcIdx As Int32
    Public dTrim(1) As Int32
    Public dCitPosition As Int32
    Public dGrade(1) As Int32
    Public dDestination(1) As Int32
    Public dSpecie As Int32
    Public dFenceCancelled As Int32
    Public dCitCancelled As Int32
    Public dCancelReman As Int32
    Public dColor(1) As Int32
    Public dMisc(1) As Int32
    Public dTestOpti As Int32
    Public dSpare1 As Int32
    Public dSpare2 As Int32
End Class

Public Class StSortRxCmd2
    Public dCmd As Int32
    Public dLugId As Int32
    Public dSortingIndex As Int32
    Public dThicknessIn As Int32
    Public dWidthIn As Int32
    Public dLengthIn As Int32
    Public dVolumeIn As Int32
    Public dSpecie As Int32
    Public dNbProduct As Int32
    Public dPmpMethod As Int32
    Public dCountValue(1) As Int32
    Public dSortError(1) As Int32
    Public dStamps(1) As Int32
    Public dVolume(1) As Int32
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
    Public dParamTable(1) As Int32
    Public dActiveTable(1) As Int32
    Public dSortingTable(1) As Int32
    Public dLastPieceTimeStamp(1) As Int32
End Class

Public Class StSortTxCmd2
    Public dCmdVer As Int32
    Public dLugId As Int32
    Public dSortingIndex As Int32
    Public dThickNom(1) As Int32
    Public dWidthNom(1) As Int32
    Public dLengthNom(1) As Int32
    Public dGrade(1) As Int32
    Public dColor(1) As Int32
    Public dSpecie As Int32
    Public dForceReject As Int32
    Public dSideBent As Int32
    Public dTaper As Int32
    Public dMoistureData As Int32
    Public dSpare(2) As Int32
End Class

Public Class StTiming
    Public dOptiReqTime As Int32
    Public dOptiRecTime As Int32
    Public dOptiDelayTime As Int32
    Public dOptiReqCtl As Int32
    Public dOptiRecCtl As Int32
    Public dOptiDelayCtl As Int32
End Class

Public Class StLugData
    Public BaseData As StBaseData
    Public Flag As StFlag
    Public Input As StInput
    Public Output As StOutput
    Public Console As StConsole
    Public OptiRx As StOptiTrimmerRx
    Public OptiTx As StOptiTrimmerTx
    Public SortingRx As StSortRxCmd2
    Public SortingTx As StSortTxCmd2
    Public Timing As StTiming
End Class

Public Class StLugsTrimmer
    Public Data(199) As StLugData
End Class
