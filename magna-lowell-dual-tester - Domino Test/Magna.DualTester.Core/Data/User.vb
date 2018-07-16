Imports Magna.DualTester.Core.Data.Enums

Public Class User
    Public Sub New()

    End Sub
    'Public Sub New(usr As Udt_User)
    '    Me.BadgeNumber = usr.BadgeNumber
    '    Me.ClockNumber = usr.ClockNumber
    '    Me.Username = usr.Username.ToString()
    '    Me.LogOutRequest = usr.LogOutRequest
    '    Me.State = usr.State
    '    Me.StationNumber = usr.StationNumber
    '    'Me.Status = usr.Status
    '    Me.RemainingQualityAlerts = usr.RemainingQualityAlerts
    '    Me.reamaingTrainingItems = usr.ReamaingTrainingItems
    '    Me.reamaingTrainingHours = usr.ReamaingTrainingHours
    '    Me.RemainingErgoHours = usr.RemainingErgoHours

    '    If usr.AccessLevel < AccessLevel.[Operator] Then
    '        AccessLevel = AccessLevel.None
    '    ElseIf usr.AccessLevel < AccessLevel.Supervisor Then
    '        AccessLevel = AccessLevel.[Operator]
    '    ElseIf usr.AccessLevel < AccessLevel.Tech Then
    '        AccessLevel = AccessLevel.Supervisor
    '    ElseIf usr.AccessLevel < AccessLevel.Engineer Then
    '        AccessLevel = AccessLevel.Tech
    '    ElseIf usr.AccessLevel < AccessLevel.Admin Then
    '        AccessLevel = AccessLevel.Engineer
    '    Else
    '        AccessLevel = AccessLevel.Admin
    '    End If
    'End Sub


    Public BadgeNumber As Integer
    Public ClockNumber As Integer
    Public Username As String
    Public AccessLevel As AccessLevel
    Public LogOutRequest As Short

    Public State As Integer
    Public StationNumber As Short
    'Public Property Status As Udt_UserStatus
    Public RemainingQualityAlerts As Short
    Public reamaingTrainingItems As Short
    Public reamaingTrainingHours As Single
    Public RemainingErgoHours As Single
End Class
