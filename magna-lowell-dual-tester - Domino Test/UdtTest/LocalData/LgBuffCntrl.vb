Public Class LgBuffCntrl
    Public Buffer(100) As Logvalues
    Public Log As LogReq
    Public Queue As Logvalues
    Public LogFifo As AutomatedSolutions.Win.Comm.AB.Logix.Data.CONTROL
    Public State As Integer
    Public Interval As AutomatedSolutions.Win.Comm.AB.Logix.Data.TIMER

End Class
