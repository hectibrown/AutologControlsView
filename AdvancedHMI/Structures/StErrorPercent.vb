Public Class StErrorPercent
    Public rPresTrimNoPres As Single = 0
    Public rPresTrimNoSoln As Single = 0
    Public rRxOptiTooManySlash As Single = 0
    Public rRxOptiTooManyReman As Single = 0
    Public rRxOptiTooManyResaw As Single = 0
    Public rRxOptiTooManyReedge As Single = 0
    Public rRxOptiTooManyRejects As Single = 0
    Public rRxOptiSolnTooLate As Single = 0
    Public rLsConfLs0 As Single = 0
    Public rLsConfTooLong As Single = 0
    Public rLsCOnfTooShort As Single = 0
    Public rLsConfNotEqual As Single = 0
    Public rPresSorterShortGate As Single = 0
    Public rPresSorterRemanGate As Single = 0
    Public rPresSorterTooManyRejects As Single = 0
    Public rPresSorterNoPres As Single = 0
    Public rLostPieceKicker As Single = 0
End Class

Public Class StErrorPercentMax
    Public rPresTrimNoPres As Single = 0
    Public rPresTrimNoSoln As Single = 0
    Public rRxOptiTooManySlash As Single = 0
    Public rRxOptiTooManyReman As Single = 0
    Public rRxOptiTooManyResaw As Single = 0
    Public rRxOptiTooManyReedge As Single = 0
    Public rRxOptiTooManyRejects As Single = 0
    Public rRxOptiSolnTooLate As Single = 0
    Public rLsConfLs0 As Single = 0
    Public rLsConfTooLong As Single = 0
    Public rLsCOnfTooShort As Single = 0
    Public rLsConfNotEqual As Single = 0
    Public rPresSorterShortGate As Single = 0
    Public rPresSorterRemanGate As Single = 0
    Public rPresSorterTooManyRejects As Single = 0
    Public rPresSorterNoPres As Single = 0
    Public rLostPieceKicker As Single = 0
End Class

Public Class StAcvError
    Public ErrorPercent As New StErrorPercent
    Public ErrorMax As New StErrorPercentMax
End Class
