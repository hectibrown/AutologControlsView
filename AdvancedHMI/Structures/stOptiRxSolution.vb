'Opit Carrige Solution
Public Class StOptiStackData
    Public dValue As Int32
End Class

Public Class StOptiFace
    'Public Stack(19) As StOptiStackData
    Public Stack() As StOptiStackData = New StOptiStackData(19) {}
    Public dNbPieces As Int32
End Class

Public Class StOptiKneeData
    Public dPosition As Int32
    Public bActive As Boolean
End Class

Public Class StOptiSide
    'Public Face(1) As StOptiFace
    'Public Knee(3) As StOptiKneeData
    Public Face() As StOptiFace = New StOptiFace(1) {}
    Public Knee() As StOptiKneeData = New StOptiKneeData(3) {}
End Class

Public Class StOptiStack
    Public Side() As StOptiSide = New StOptiSide(1) {}
End Class

Public Class StOptiRxSolution
    Public dCmd As Int32
    Public dLogId As Int32
    Public dDiameterBigEnd As Int32
    Public dDiameterSmallEnd As Int32
    Public dVolumePmp As Int32
    Public dVolumeCubic As Int32
    Public dDefilement As Int32
    Public dLength As Int32
    Public dDiameterMax As Int32
    Public dThicknessCroute1A As Int32
    Public dThicknessCroute2B As Int32
    Public dLogStart As Int32
    Public dLogEnd As Int32
    Public dHeightSawGuide As Int32
    Public rLogStartFromFirstKnee As Single
    Public rLogEndFromFirstKnee As Single
    Public stOptiStack As New StOptiStack
    Public bNoSolution As Boolean
    Public dSizeOfStack As Int32
    Public bPresenceOptiSol As Boolean
End Class
