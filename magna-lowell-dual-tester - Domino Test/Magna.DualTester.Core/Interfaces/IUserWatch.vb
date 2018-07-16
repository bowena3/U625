Imports Magna.DualTester.Core.Data.Enums

Public Interface IUserWatch
    Inherits IWatch(Of User)
    Inherits IDisposable
    Sub DebugLogin(user As User)
    Function CheckCurrentUserPermission(level As AccessLevel) As Boolean
    Sub LogOut()
    Sub LogIn(badgeNumber As String)
End Interface


Public Interface IWatch(Of T)
    Event ValueChanged As Action(Of T)
    ReadOnly Property CurrentValue As T
End Interface