Public Class tester
    Public AssetNumber As String
    Public Counts As Tester_Counts
    Public PartInfo As partInformation
    Public SetPoints As Setpoints
    Public Nest1 As Nest
    Public Nest2 As Nest
    Public User As User
    Public Daq_Hb As HeartBeat
    Public LogBuffer As LgBuffCntrl
    Public LoginReq As LogReq
    Public ScannedBadge As String
    Public BadgeSyncTmr As AutomatedSolutions.Win.Comm.AB.Logix.Data.TIMER
    Public LogCalibrationEvent As LogReq
    Public LogSetpointChange As LogReq
    Public ShiftValue As Integer
    Public LastShift As Integer
    Public RequestLogOut As Integer

End Class
