Imports Magna.DualTester.Core
Imports Magna.DualTester.Domino.TesterApi
Imports Magna.DualTester.Plc.Core

Public Class TesterDevicesViewModel

    Public Sub New(nestid As Integer, nest As Udt_Nest, colors As ColorsModel)
        Me.NestId = nestid
        ManualOps = nest.ManualOps
        TargetColor = New ColorMap(nest.TargetColor, colors)
        Me.Colors = colors
    End Sub

    Public Property NestId As Integer
    Public Property ManualOps As Udt_Manual_Operators
    Public Property TargetColor As ColorMap
    Public Property Colors As ColorsModel
End Class