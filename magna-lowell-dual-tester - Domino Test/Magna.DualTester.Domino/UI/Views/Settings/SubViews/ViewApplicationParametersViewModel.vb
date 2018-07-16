Imports Magna.DualTester.Core

Public Class ViewApplicationParametersViewModel

    Public Sub New(colors As ColorsModel, cfg As DominoCfg)
        Me.Colors = colors
        Me.Cfg = cfg
    End Sub

    Public Property Colors As ColorsModel
    Public Property Cfg As DominoCfg
End Class