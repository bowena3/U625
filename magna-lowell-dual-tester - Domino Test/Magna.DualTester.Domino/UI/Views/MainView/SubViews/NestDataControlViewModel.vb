Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data
Imports Magna.DualTester.Core.Data.Enums
Imports Magna.DualTester.Domino.TesterApi
Imports Magna.DualTester.Plc.Core

Public Class NestDataControlViewModel
    Inherits NestPartOptionsViewModel

    Public Sub New(nestId As Integer, nest As Udt_Nest, lang As LanguageEnum, cfg As CfgSettings, colors As ColorsModel)
        MyBase.New(nest.PartOptions, nest.GlassOptions)
        Me.NestId = nestId
        Language = lang
        LogItems = nest.Logitems
        ModeStatus = nest.ModeStatus
        SeqVal = New StringMap(nest.SeqVal, lang, cfg.SequenceStrings)
        AlarmVal = New StringMap(nest.AlarmVal, lang, cfg.MachineAlarms)
        TargetColor = New ColorMap(nest.TargetColor, colors)
        DetectedColor = New ColorMap(nest.DetectedColor, colors)
        PartAlarms = New List(Of EnglishSpanishMap)(cfg.PartAlarms)

        If nestId <> 1 AndAlso nestId <> 2 Then
            Throw New Exception("Nestid was not set to 1 or 2")
        End If

        'CameraIp = If(nestId = 1, cfg.DeviceNest1CameraIp, cfg.Devicenest2CameraIp)

    End Sub

    Public Property NestId As Integer

    'Public Property CameraIp As String
    Public Property Language As LanguageEnum

    Public Property LogItems As Udt_Logvalues
    Public Property ModeStatus As Integer

    'Public Property NestIdx As Integer
    Public Property SeqVal As StringMap

    Public Property AlarmVal As StringMap
    Public Property TargetColor As ColorMap
    Public Property DetectedColor As ColorMap

    Public Property PartAlarms As List(Of EnglishSpanishMap)

End Class