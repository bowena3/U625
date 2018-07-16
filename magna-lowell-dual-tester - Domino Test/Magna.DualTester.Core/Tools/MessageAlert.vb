


Namespace Tools
    Public Class MessageAlertService
        Implements IMessageAlertService, IPlcAlertService

        Public Const PermissionAlert As String = "You have Insufficient Privileges for this action."
        Public Event NewAlert As Action Implements IMessageAlertService.NewAlert
        Public Property Errors As New Queue(Of EventErrorArgs) Implements IMessageAlertService.Errors

        Public Sub PublishNewAlarm(message As String, level As ErrorLevel) Implements IMessageAlertService.PublishNewAlarm
            If Not Errors.ToList().Exists(Function(x) x.Message = message) Then
                Dim err = New EventErrorArgs(message, level)
                Errors.Enqueue(err)
                RaiseEvent NewAlert()
            End If
        End Sub
        Public Sub PublishNewAlarm(message As String, level As ErrorLevel, seconds As Integer) Implements IMessageAlertService.PublishNewAlarm
            If Not Errors.ToList().Exists(Function(x) x.Message = message) Then
                Dim err = New EventErrorArgs(message, level, seconds)
                Errors.Enqueue(err)
                RaiseEvent NewAlert()
            End If
        End Sub

        Public Function GetAllMessages() As List(Of EventErrorArgs) Implements IMessageAlertService.GetAllMessages
            Dim res = New List(Of EventErrorArgs)
            While Errors.Count > 0
                res.Add(Errors.Dequeue)
            End While
            Return res
        End Function

        Public Sub PublishNewAlarm(toString As String, [error] As PlcAlertType, Optional seconds As Integer = 1) Implements IPlcAlertService.PublishNewAlarm
            PublishNewAlarm(toString, If([error] = PlcAlertType.Error, ErrorLevel.Error, ErrorLevel.Message), seconds)
        End Sub
    End Class
End Namespace