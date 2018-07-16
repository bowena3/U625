Imports Magna.DualTester.Core
Imports Magna.DualTester.Domino.TesterApi

Public Class UcCoordinateViewModel

    Public Sub New(data As CalibrationSubViewModel)
        NestId = data.NestId
        GlassType = data.CurrentGlassType
        VertRawIn = data.AlgFeatures.VertAngle.AnalogInDint
        HorzRawIn = data.AlgFeatures.HorzAngle.AnalogInDint
        ManualBits = CType(data.ManualOps.MirrrorActuator, MactFlags)
        CalData = data.CurrentMirrorCal
    End Sub

    Public Property NestId As Integer
    Public Property GlassType As GlassTypeEnum
    Public Property VertRawIn As Integer
    Public Property HorzRawIn As Integer
    Public Property ManualBits As MactFlags
    Public Property CalData As Udt_Mcal
End Class