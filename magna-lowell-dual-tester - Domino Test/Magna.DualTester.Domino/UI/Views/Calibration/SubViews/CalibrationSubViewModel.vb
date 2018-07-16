Imports Magna.DualTester.Core
Imports Magna.DualTester.Domino.TesterApi

Public Class CalibrationSubViewModel

    Public Sub New(nestid As Integer, nest As Udt_Nest)
        Me.NestId = nestid
        AlgFeatures = nest.AlgFeatures
        CurrentGlassType = CType(nest.CurrentGlassType, GlassTypeEnum)
        Me.ManualOps = nest.ManualOps
        Me.CurrentMirrorCal = nest.CurrentMirrorCal
    End Sub

    Public Property NestId As Integer
    Public Property AlgFeatures As Udt_AnalogItems
    Public Property CurrentGlassType As GlassTypeEnum
    Public Property ManualOps As Udt_Manual_Operators
    Public Property CurrentMirrorCal As Udt_Mcal

End Class