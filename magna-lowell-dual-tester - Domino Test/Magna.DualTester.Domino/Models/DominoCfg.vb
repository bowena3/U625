Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data

Public Class DominoCfg
    Inherits CfgSettings

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(defaults As IStringDefaults)
        MyBase.New(defaults)
    End Sub

    Public Property ShiftSetup1StStart As String = String.Empty
    Public Property ShiftSetup2NdStart As String = String.Empty
    Public Property ShiftSetup3RdStart As String = String.Empty
    Public Property DevicePartLabelPort As String = String.Empty
    Public Property AutoLabelRequestPath As String = String.Empty
    Public Property ToteLabelPrinterId As String = String.Empty
    Public Property AutoToteLabel As Boolean = False

End Class