
Public Interface IPlcAlertService
    Sub PublishNewAlarm(toString As String, [error] As PlcAlertType, Optional duration As Integer = 1)
End Interface
Public Enum PlcAlertType
    [Error]
    Message
End Enum
