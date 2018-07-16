Imports Magna.DualTester.Core.Data.Enums

Imports Magna.DualTester.Core
Imports Magna.DualTester.Plc.Core
Imports Magna.DualTester.Core.Data

Public Class UserWatch
    Implements IUserWatch

    Public Event UserChanged As Action(Of User) Implements IUserWatch.ValueChanged

    Private _currentUser As User
    Public Property CurrentUser As User Implements IUserWatch.CurrentValue
        Get
            Return _currentUser
        End Get
        Private Set(value As User)
            _currentUser = value
        End Set
    End Property

    Private ReadOnly _cfg As ICfg
    Private ReadOnly _plc As IPlc
    Private ReadOnly _msgsvc As IMessageAlertService
    Private ReadOnly _plcrepo As IPlcDataRepo
    Public Sub New(cfg As ICfg, plc As IPlc, msgsvc As IMessageAlertService, plcrepo As IPlcDataRepo)
        _cfg = cfg
        _plc = plc
        _msgsvc = msgsvc
        _plcrepo = plcrepo
        AddHandler _plcrepo.TesterChanged, AddressOf OnTesterChanged
    End Sub

    Private Sub OnTesterChanged()
        NewUser(_plcrepo.User)
    End Sub

    Private Sub NewUser(nuser As User)
        Dim cuserIsNull = _currentUser Is Nothing
        Dim nuserIsNull = nuser Is Nothing
        Dim userNotBlank = Not String.IsNullOrEmpty(nuser.Username) AndAlso
                               nuser.BadgeNumber <> 0 AndAlso
                            nuser.ClockNumber <> 0 AndAlso
                            nuser.AccessLevel > AccessLevel.None
        If Not userNotBlank Then
            If _currentUser IsNot Nothing Then
                _currentUser = Nothing
                RaiseEvent UserChanged(_currentUser)
            End If
            Return
        End If

        Dim oldClockNumber = If(CurrentUser Is Nothing, 0, _currentUser.ClockNumber)
        Dim newClockNumber = If(nuser Is Nothing, 0, nuser.ClockNumber)

        If oldClockNumber <> newClockNumber Then
            _currentUser = nuser
            RaiseEvent UserChanged(_currentUser)
        End If
    End Sub

    Public Sub DebugLogin(user As User) Implements IUserWatch.DebugLogin
        NewUser(user)
    End Sub

    Public Function CheckCurrentUserPermission(level As AccessLevel) As Boolean Implements IUserWatch.CheckCurrentUserPermission
        Dim res = CurrentUser?.AccessLevel >= level
        If Not res.HasValue OrElse Not res.Value Then
            _msgsvc.PublishNewAlarm("Permissions to low", ErrorLevel.Alert)
            Return False
        End If
        Return CBool(res)
    End Function
    Public Sub LogOut() Implements IUserWatch.LogOut
        _plc.ManualWrite(PlcConstants.Request_Log_Out, 1)
    End Sub

    Public Sub LogIn(badgeNumber As String) Implements IUserWatch.LogIn
        Dim result As Integer = -1
        If (Integer.TryParse(badgeNumber, result)) Then
            _plc.ManualWrite(PlcConstants.User_Badge_Number, result)
        Else
            _plc.ManualWrite(PlcConstants.User_Badge_Number, -1)
        End If
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                'RemoveHandler _plc.TesterChanged, AddressOf OnTesterChanged
            End If
        End If
        disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
    End Sub




#End Region
End Class
