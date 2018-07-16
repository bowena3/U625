Imports Magna.DualTester.Core.Data.Enums

Public Class DebugUserWatch
    Implements IUserWatch

    Private Shared _currentUser As User = New User() With {.AccessLevel = AccessLevel.Admin, .BadgeNumber = 1,
                                                    .ClockNumber = 2, .reamaingTrainingHours = 1.5,
                                                    .reamaingTrainingItems = 2, .RemainingErgoHours = 3.5,
                                                    .RemainingQualityAlerts = 3, .StationNumber = 5,
                                                    .Username = "Debug user"}


    Public ReadOnly Property CurrentValue As User Implements IWatch(Of User).CurrentValue
        Get
            Return _currentUser
        End Get
    End Property

    Public Event ValueChanged As Action(Of User) Implements IWatch(Of User).ValueChanged

    Private ReadOnly _msgsvc As IMessageAlertService

    Public Sub New(msgsvc As IMessageAlertService)
        _msgsvc = msgsvc
    End Sub

    Public Sub DebugLogin(user As User) Implements IUserWatch.DebugLogin
        _currentUser = user
        RaiseEvent ValueChanged(CurrentValue)
    End Sub

    Public Sub LogOut() Implements IUserWatch.LogOut
        _currentUser = Nothing
        RaiseEvent ValueChanged(CurrentValue)
    End Sub

    Public Sub LogIn(badgeNumber As String) Implements IUserWatch.LogIn
        _currentUser.BadgeNumber = CInt(badgeNumber)
        RaiseEvent ValueChanged(CurrentValue)
    End Sub

    Public Function CheckCurrentUserPermission(level As AccessLevel) As Boolean Implements IUserWatch.CheckCurrentUserPermission
        Dim res = (_currentUser IsNot Nothing) AndAlso _currentUser.AccessLevel >= level
        If Not res Then
            _msgsvc.PublishNewAlarm("Permissions to low", ErrorLevel.Alert)
        End If
        Return res
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
            End If
        End If
        disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
    End Sub


#End Region

End Class
