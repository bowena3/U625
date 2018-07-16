Public Interface IMessageAlertService
    Property Errors As Queue(Of EventErrorArgs)
    Event NewAlert As Action
    Sub PublishNewAlarm(message As String, level As ErrorLevel)
    Sub PublishNewAlarm(message As String, level As ErrorLevel, seconds As Integer)
    Function GetAllMessages() As List(Of EventErrorArgs)
End Interface

Public Enum ErrorLevel
    [Error]
    Alert
    Message
End Enum

Public Class EventErrorArgs
    Public Property Message As String
    Public Property AlertLevel As ErrorLevel
    Public Property Seconds As Integer
    Public Sub New(message As String, level As ErrorLevel)
        Me.Message = message
        Me.AlertLevel = level
        Me.Seconds = 1
    End Sub
    Public Sub New(message As String, level As ErrorLevel, seconds As Integer)
        Me.New(message, level)
        Me.Seconds = If(seconds >= 1, seconds, 1)
    End Sub
End Class