Public Interface IStartupService
    ReadOnly Property ServiceName As String
    Event StartupResult As EventHandler(Of StartupEventResult)
    ReadOnly Property Status As StartupEventResult
End Interface

Public Class StartupEventResult
    Inherits EventArgs

    Public Sub New(isok As Boolean)
        Ok = isok
        Message = String.Empty
    End Sub
    Public Sub New(isok As Boolean, msg As String)
        Ok = isok
        Message = msg
    End Sub

    Public Property Ok As Boolean
    Public Property Message As String

End Class
