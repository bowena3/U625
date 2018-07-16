Public Class TesterResult(Of T)
    Inherits TesterResult
    Public Property Value As T

    Public Sub New(val As T)
        MyBase.New(True, String.Empty)
        Value = val
    End Sub
    Public Sub New(success As Boolean, message As String)
        MyBase.New(success, message)
    End Sub
    Public Sub New(ex As Exception)
        MyBase.New(ex)
    End Sub
    Public Sub New(val As T, success As Boolean, message As String)
        MyBase.New(success, message)
        Value = val
    End Sub

End Class

Public Class TesterResult
    Public Property Success As Boolean
    Public Property Message As String

    Public Sub New(success As Boolean, message As String)
        Me.Success = success
        Me.Message = message
    End Sub
    Public Sub New(ex As Exception)
        Success = False
        Message = ex.Message
    End Sub
    Public Sub New(success As Boolean)
        Me.Success = success
    End Sub
End Class
