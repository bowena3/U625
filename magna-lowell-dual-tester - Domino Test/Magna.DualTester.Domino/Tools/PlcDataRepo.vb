Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data.Enums
Imports Magna.DualTester.Domino.TesterApi

Public Interface IPlcFullRepo
    Inherits IPlcDataRepo

    Event TesterContextChanged As Action(Of Udt_tester)

    ReadOnly Property TesterData As Udt_tester

End Interface

Public Class PlcDataRepo
    Implements IPlcFullRepo

    Private ReadOnly _plc As IPlc(Of Udt_tester)

    'Private ReadOnly _testerTranslate As ITranslate(Of Udt_tester, Model_tester)
    Public Event TesterChanged As Action Implements IPlcDataRepo.TesterChanged

    Public Event TesterContextChanged As Action(Of Udt_tester) Implements IPlcFullRepo.TesterContextChanged

    Private Property _cachedTester As Udt_tester

    Public Sub New(plc As IPlc(Of Udt_tester))
        _plc = plc
        '_testerTranslate = testerTranslate
        AddHandler _plc.TesterChanged, AddressOf OnTesterChanged

    End Sub

    Private Sub OnTesterChanged(obj As Udt_tester)
        _cachedTester = obj '_testerTranslate.Translate(_plc.TesterData)
        RaiseEvent TesterContextChanged(_cachedTester)
        RaiseEvent TesterChanged()
    End Sub

    Public ReadOnly Property TesterData As Udt_tester Implements IPlcFullRepo.TesterData
        Get
            Return _cachedTester
        End Get
    End Property

    'Public ReadOnly Property GetPartNumberNest1 As String Implements IPlcDataRepo.GetPartNumberNest1
    '    Get
    '        Return _plc.TesterData.Nest1.PartInfo.Pn.ToString()
    '    End Get
    'End Property
    'Public ReadOnly Property GetPartNumberNest2 As String Implements IPlcDataRepo.GetPartNumberNest2
    '    Get
    '        Return _plc.TesterData.Nest2.PartInfo.Pn.ToString()
    '    End Get
    'End Property

    Public ReadOnly Property GetToteTarget As Integer Implements IPlcDataRepo.GetToteTarget
        Get
            Return _plc.TesterData.Counts.ToteTarget
        End Get
    End Property

    'Public ReadOnly Property GetIsServicePartNest1 As Boolean Implements IPlcDataRepo.GetIsServicePartNest1
    '    Get
    '        Return _plc.TesterData.Nest1.PartInfo.Service
    '    End Get
    'End Property
    'Public ReadOnly Property GetIsServicePartNest2 As Boolean Implements IPlcDataRepo.GetIsServicePartNest2
    '    Get
    '        Return _plc.TesterData.Nest2.PartInfo.Service
    '    End Get
    'End Property

    'Public ReadOnly Property PrnStringReplacementsNest1 As IDictionary(Of String, String) Implements IPlcDataRepo.PrnStringReplacementsNest1
    '    Get
    '        Return New Dictionary(Of String, String) From {{"$PN$", _plc.TesterData.Nest1.PartInfo.Pn.ToString()},
    '                                                                 {"$CPN$", _plc.TesterData.Nest1.PartInfo.Cpn.ToString()},
    '                                                                 {"$SPN$", _plc.TesterData.Nest1.PartInfo.SvcPn.ToString()},
    '                                                                 {"$DESC1$", _plc.TesterData.Nest1.PartInfo.Desc1.ToString()},
    '                                                                 {"$DESC2$", _plc.TesterData.Nest1.PartInfo.Desc2.ToString()},
    '                                                                  {"MM-DD-YY", DateTime.Now.ToString("MM-dd-yy")},
    '                                                                  {"HH:MM:SS", DateTime.Now.ToString("HH:mm:ss")},
    '                                                                  {"YYMMDD", DateTime.Now.ToString("yyMMdd")},
    '                                                                  {"$SHIFT$", _plc.TesterData.ShiftValue.ToString()},
    '                                                                  {"$SHIFTCOUNT$", _plc.TesterData.Counts.ShiftPassCount.ToString()},
    '                                                                  {"$PACKER$", _plc.TesterData.User.ClockNumber.ToString()}}
    '    End Get
    'End Property
    'Public ReadOnly Property PrnStringReplacementsNest2 As IDictionary(Of String, String) Implements IPlcDataRepo.PrnStringReplacementsNest2
    '    Get
    '        Return New Dictionary(Of String, String) From {{"$PN$", _plc.TesterData.Nest2.PartInfo.Pn.ToString()},
    '                                                                 {"$CPN$", _plc.TesterData.Nest2.PartInfo.Cpn.ToString()},
    '                                                                 {"$SPN$", _plc.TesterData.Nest2.PartInfo.SvcPn.ToString()},
    '                                                                 {"$DESC1$", _plc.TesterData.Nest2.PartInfo.Desc1.ToString()},
    '                                                                 {"$DESC2$", _plc.TesterData.Nest2.PartInfo.Desc2.ToString()},
    '                                                                  {"MM-DD-YY", DateTime.Now.ToString("MM-dd-yy")},
    '                                                                  {"HH:MM:SS", DateTime.Now.ToString("HH:mm:ss")},
    '                                                                  {"YYMMDD", DateTime.Now.ToString("yyMMdd")},
    '                                                                  {"$SHIFT$", _plc.TesterData.ShiftValue.ToString()},
    '                                                                  {"$SHIFTCOUNT$", _plc.TesterData.Counts.ShiftPassCount.ToString()},
    '                                                                  {"$PACKER$", _plc.TesterData.User.ClockNumber.ToString()}}
    '    End Get
    'End Property

    Public ReadOnly Property Nest1SequenceStep As Integer Implements IPlcDataRepo.Nest1SequenceStep
        Get
            Return _plc.TesterData.Nest1.SeqVal
        End Get
    End Property

    Public ReadOnly Property Nest2SequenceStep As Integer Implements IPlcDataRepo.Nest2SequenceStep
        Get
            Return _plc.TesterData.Nest2.SeqVal
        End Get
    End Property

    Public ReadOnly Property User As User Implements IPlcDataRepo.User
        Get
            '_plc.TesterData.User
            Dim usr = _plc.TesterData.User
            Dim u = New User() With {.BadgeNumber = usr.BadgeNumber,
                                    .ClockNumber = usr.ClockNumber,
                                    .Username = usr.Username.ToString(),
                                    .LogOutRequest = usr.LogOutRequest,
                                    .State = usr.State,
                                    .StationNumber = usr.StationNumber,
                                    .RemainingQualityAlerts = usr.RemainingQualityAlerts,
                                    .reamaingTrainingItems = usr.ReamaingTrainingItems,
                                    .reamaingTrainingHours = usr.ReamaingTrainingHours,
                                    .RemainingErgoHours = usr.RemainingErgoHours,
                                    .AccessLevel = IntToAccessLevel(usr.AccessLevel)}
            Return u
        End Get
    End Property

    Public ReadOnly Property ToteCount As Integer Implements IPlcDataRepo.ToteCount
        Get
            Return _plc.TesterData.Counts.ToteCount
        End Get
    End Property

    Public ReadOnly Property ToteTarget As Integer Implements IPlcDataRepo.ToteTarget
        Get
            Return _plc.TesterData.Counts.ToteTarget
        End Get
    End Property

    Public ReadOnly Property Nest1ResultCode As Integer Implements IPlcDataRepo.Nest1ResultCode
        Get
            Return _plc.TesterData.Nest1.Logitems.ResultCode
        End Get
    End Property

    Public ReadOnly Property Nest2ResultCode As Integer Implements IPlcDataRepo.Nest2ResultCode
        Get
            Return _plc.TesterData.Nest2.Logitems.ResultCode
        End Get
    End Property

    Public ReadOnly Property Nest1ModeStatus As NestModeStatus Implements IPlcDataRepo.Nest1ModeStatus
        Get
            Return DirectCast(_plc.TesterData.Nest1.ModeStatus, NestModeStatus)
        End Get
    End Property

    Public ReadOnly Property Nest2ModeStatus As NestModeStatus Implements IPlcDataRepo.Nest2ModeStatus
        Get
            Return DirectCast(_plc.TesterData.Nest2.ModeStatus, NestModeStatus)
        End Get
    End Property

    Public ReadOnly Property GetPartNumber As String Implements IPlcDataRepo.GetPartNumber
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property GetIsServicePart As Boolean Implements IPlcDataRepo.GetIsServicePart
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property PrnStringReplacements As IDictionary(Of String, String) Implements IPlcDataRepo.PrnStringReplacements
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private Shared Function IntToAccessLevel(usr As Integer) As AccessLevel
        If usr < AccessLevel.[Operator] Then
            Return AccessLevel.None
        ElseIf usr < AccessLevel.Supervisor Then
            Return AccessLevel.[Operator]
        ElseIf usr < AccessLevel.Tech Then
            Return AccessLevel.Supervisor
        ElseIf usr < AccessLevel.Engineer Then
            Return AccessLevel.Tech
        ElseIf usr < AccessLevel.Admin Then
            Return AccessLevel.Engineer
        End If
        Return AccessLevel.Admin
    End Function

End Class

Public Interface ITranslate(Of TIn As {New, Class}, TOut As {New, Class})

    Function Translate(item As TIn) As TOut

End Interface

'Public Class TesterTranslate
'    Implements ITranslate(Of Udt_tester, Model_tester)

'    Private ReadOnly _countsTrans As ITranslate(Of Udt_Tester_Counts, Model_Tester_Counts)
'    Private ReadOnly _partinfoTrans As ITranslate(Of Udt_PartInformation, Model_PartInformation)
'    Private ReadOnly _setpointsTrans As ITranslate(Of Udt_Setpoints, Model_Setpoints)
'    Private ReadOnly _nestTrans As ITranslate(Of Udt_Nest, Model_Nest)
'    Private ReadOnly _daqTrans As ITranslate(Of Udt_HeartBeat, Model_HeartBeat)

'    Public Sub New(countsTrans As CountsTranslate,
'                   partinfoTrans As PartinfoTranslate,
'                   setpointsTrans As SetpointsTranslate,
'                   nestTrans As NestTranslate,
'                   daqTrans As HeartBeatTranslate)
'        _countsTrans = countsTrans
'        _partinfoTrans = partinfoTrans
'        _setpointsTrans = setpointsTrans
'        _nestTrans = nestTrans
'        _daqTrans = daqTrans
'    End Sub

'    Public Function Translate(item As Udt_tester) As Model_tester Implements ITranslate(Of Udt_tester, Model_tester).Translate
'        Dim t = New Model_tester()
'        t.StationId = item.StationId
'        t.Counts = _countsTrans.Translate(item.Counts)
'        t.PartInfo = _partinfoTrans.Translate(item.PartInfo)
'        t.SetPoints = _setpointsTrans.Translate(item.SetPoints)
'        t.Nest1 = _nestTrans.Translate(item.Nest1)
'        t.Nest2 = _nestTrans.Translate(item.Nest2)
'        t.User = item.User
'        t.Daq_Hb = _daqTrans.Translate(item.Daq_Hb)
'        't.LogBuffer = item.LogBuffer
'        't.LogCalibrationEvent = item.LogCalibrationEvent
'        't.LogSetpointChange = item.LogSetpointChange
'        t.ShiftValue = item.ShiftValue
'        t.LastShift = item.LastShift
'        t.RequestLogOut = item.RequestLogOut
'        't.CalibrationChange = item.CalibrationChange
'        't.FindPartReq = item.FindPartReq
'        't.ActivityToBuffer = item.ActivityToBuffer
'        't.LogActivityRequest = item.LogActivityRequest
'        't.ActivityLogQueItem = item.ActivityLogQueItem
'        t.PnToFind = item.PnToFind.ToString()
'        Return t
'    End Function
'End Class

'Public Class CountsTranslate
'    Implements ITranslate(Of Udt_Tester_Counts, Model_Tester_Counts)
'    Public Function Translate(item As Udt_Tester_Counts) As Model_Tester_Counts Implements ITranslate(Of Udt_Tester_Counts, Model_Tester_Counts).Translate
'        Dim t As New Model_Tester_Counts
'        t.ShiftPassCount = item.ShiftPassCount
'        t.ShiftFailCount = item.ShiftFailCount
'        t.BatchCountDown = item.BatchCountDown
'        t.ToteTarget = item.ToteTarget
'        t.ToteCount = item.ToteCount
'        Return t
'    End Function
'End Class
'Public Class PartinfoTranslate
'    Implements ITranslate(Of Udt_PartInformation, Model_PartInformation)

'    Private ReadOnly _partOptionsTrans As ITranslate(Of Udt_PartOptions, Model_PartOptions)
'    Private ReadOnly _glassOptionsTrans As ITranslate(Of Udt_GlassOptions, Model_GlassOptions)
'    Public Sub New(partOptionsTrans As PartOptionsTranslate,
'                   glassOptionsTrans As GlassOptionsTranslate)
'        _partOptionsTrans = partOptionsTrans
'        _glassOptionsTrans = glassOptionsTrans
'    End Sub

'    Public Function Translate(item As Udt_PartInformation) As Model_PartInformation Implements ITranslate(Of Udt_PartInformation, Model_PartInformation).Translate
'        Dim t = New Model_PartInformation()
'        t.Pn = item.Pn.ToString()
'        t.SvcPn = item.SvcPn.ToString()
'        t.Cpn = item.Cpn.ToString()
'        t.Desc1 = item.Desc1.ToString()
'        t.Desc2 = item.Desc2.ToString()
'        t.PartsPerTote = item.PartsPerTote
'        t.Static_Label = item.Static_Label.ToString()
'        t.partColor = item.partColor.ToString()
'        t.Pcode = item.Pcode.ToString()
'        t.ColorId = item.ColorId
'        t.SpecialCode = item.SpecialCode.ToString()
'        t.Suffix = item.Suffix.ToString()
'        t.BodyStyleName = item.BodyStyleName.ToString()
'        t.BodyStyleId = item.BodyStyleId
'        t.ContainerType = item.ContainerType
'        t.LH = item.LH
'        t.RH = item.RH
'        t.Service = item.Service
'        t.RHD = item.RHD
'        t.ShipWithPFIn = item.ShipWithPFIn
'        t.PartsPerHourPerPerson = item.PartsPerHourPerPerson
'        t.PartOptions = _partOptionsTrans.Translate(item.PartOptions)
'        t.GlassOptions = _glassOptionsTrans.Translate(item.GlassOptions)
'        Return t
'    End Function
'End Class

'Public Class PartOptionsTranslate
'    Implements ITranslate(Of Udt_PartOptions, Model_PartOptions)
'    Private ReadOnly _optitemTrans As ITranslate(Of Udt_Opt_Item, Model_Opt_Item)
'    Public Sub New(optitemTrans As OptItemTranslate)
'        _optitemTrans = optitemTrans
'    End Sub
'    Public Function Translate(item As Udt_PartOptions) As Model_PartOptions Implements ITranslate(Of Udt_PartOptions, Model_PartOptions).Translate
'        Dim t As New Model_PartOptions
'        t.Electric = _optitemTrans.Translate(item.Electric)
'        t.Memory = _optitemTrans.Translate(item.Memory)
'        t.Defog = _optitemTrans.Translate(item.Defog)
'        t.Turn_Signal = _optitemTrans.Translate(item.Turn_Signal)
'        t.ChromeFeature = _optitemTrans.Translate(item.ChromeFeature)
'        t.Gasket = _optitemTrans.Translate(item.Gasket)
'        t.Gimp_Seal = _optitemTrans.Translate(item.Gimp_Seal)
'        t.Bzi = _optitemTrans.Translate(item.Bzi)
'        t.GI = _optitemTrans.Translate(item.GI)
'        t.Logo_Lamp = _optitemTrans.Translate(item.Logo_Lamp)
'        t.Ec_Glass = _optitemTrans.Translate(item.Ec_Glass)
'        t.TrapDoor = _optitemTrans.Translate(item.TrapDoor)
'        t.PullTest = _optitemTrans.Translate(item.PullTest)
'        t.PowerFold = _optitemTrans.Translate(item.PowerFold)
'        t.GroundCheck = _optitemTrans.Translate(item.GroundCheck)
'        t.PowerExt = _optitemTrans.Translate(item.PowerExt)
'        t.Zebra = _optitemTrans.Translate(item.Zebra)
'        t.Color = _optitemTrans.Translate(item.Color)
'        t.Camera_Vision = _optitemTrans.Translate(item.Camera_Vision)
'        t.JoyStick = _optitemTrans.Translate(item.JoyStick)
'        t.Oats = _optitemTrans.Translate(item.Oats)
'        t.CargoLamp = _optitemTrans.Translate(item.CargoLamp)
'        t.GPS = _optitemTrans.Translate(item.GPS)
'        t.CellularAntenna = _optitemTrans.Translate(item.CellularAntenna)
'        Return t
'    End Function
'End Class
'Public Class GlassOptionsTranslate
'    Implements ITranslate(Of Udt_GlassOptions, Model_GlassOptions)
'    Private ReadOnly _optitemTrans As ITranslate(Of Udt_Opt_Item, Model_Opt_Item)
'    Public Sub New(optitemTrans As OptItemTranslate)
'        _optitemTrans = optitemTrans
'    End Sub
'    Public Function Translate(item As Udt_GlassOptions) As Model_GlassOptions Implements ITranslate(Of Udt_GlassOptions, Model_GlassOptions).Translate
'        Dim t = New Model_GlassOptions
'        t.Convex = _optitemTrans.Translate(item.Convex)
'        t.Flat = _optitemTrans.Translate(item.Flat)
'        t.Aspheric = _optitemTrans.Translate(item.Aspheric)
'        t.BziSymbol = _optitemTrans.Translate(item.BziSymbol)
'        t.TurnSignal = _optitemTrans.Translate(item.TurnSignal)
'        t.DefogSymbol = _optitemTrans.Translate(item.DefogSymbol)
'        t.JeepSymbol = _optitemTrans.Translate(item.JeepSymbol)
'        t.English = _optitemTrans.Translate(item.English)
'        t.Arabic = _optitemTrans.Translate(item.Arabic)
'        t.Korean = _optitemTrans.Translate(item.Korean)
'        t.PowerFoldSymbol = _optitemTrans.Translate(item.PowerFoldSymbol)
'        t.CoPlaner = _optitemTrans.Translate(item.CoPlaner)
'        Return t
'    End Function
'End Class
'Public Class OptItemTranslate
'    Implements ITranslate(Of Udt_Opt_Item, Model_Opt_Item)

'    Public Function Translate(item As Udt_Opt_Item) As Model_Opt_Item Implements ITranslate(Of Udt_Opt_Item, Model_Opt_Item).Translate
'        Dim t As New Model_Opt_Item
'        t.Status = item.Status
'        t.Config = item.Config
'        Return t
'    End Function
'End Class

'Public Class SetpointsTranslate
'    Implements ITranslate(Of Udt_Setpoints, Model_Setpoints)

'    Private ReadOnly _minmaxTrans As ITranslate(Of Udt_MinMax, Model_MinMax)
'    Public Sub New(minmaxTrans As MinMaxTanslate)
'        _minmaxTrans = minmaxTrans
'    End Sub

'    Public Function Translate(item As Udt_Setpoints) As Model_Setpoints Implements ITranslate(Of Udt_Setpoints, Model_Setpoints).Translate
'        Dim t = New Model_Setpoints()
'        t.ActuatorAmps = _minmaxTrans.Translate(item.ActuatorAmps)
'        t.ActuatorRate = _minmaxTrans.Translate(item.ActuatorRate)
'        t.UpAngle = _minmaxTrans.Translate(item.UpAngle)
'        t.DwnAngle = _minmaxTrans.Translate(item.DwnAngle)
'        t.InBoardAngle = _minmaxTrans.Translate(item.InBoardAngle)
'        t.OutBoardAngle = _minmaxTrans.Translate(item.OutBoardAngle)
'        t.MemAtUp = _minmaxTrans.Translate(item.MemAtUp)
'        t.MemAtDwn = _minmaxTrans.Translate(item.MemAtDwn)
'        t.MemAtInBoard = _minmaxTrans.Translate(item.MemAtInBoard)
'        t.MemAtOutBoard = _minmaxTrans.Translate(item.MemAtOutBoard)
'        t.Defog_Inrush = _minmaxTrans.Translate(item.Defog_Inrush)
'        t.defogAmps = _minmaxTrans.Translate(item.defogAmps)
'        t.Gi_Amps = _minmaxTrans.Translate(item.Gi_Amps)
'        t.LogoLamp_Amps = _minmaxTrans.Translate(item.LogoLamp_Amps)
'        t.Ts_Amps = _minmaxTrans.Translate(item.Ts_Amps)
'        t.Bzi_Amps = _minmaxTrans.Translate(item.Bzi_Amps)
'        t.Pfold_Amps = _minmaxTrans.Translate(item.Pfold_Amps)
'        t.Pfold_TravTime = _minmaxTrans.Translate(item.Pfold_TravTime)
'        t.MemoryVoltsPerDeg = _minmaxTrans.Translate(item.MemoryVoltsPerDeg)
'        t.EcAmps = _minmaxTrans.Translate(item.EcAmps)
'        t.Cargo_Lamp_Amps = _minmaxTrans.Translate(item.Cargo_Lamp_Amps)
'        t.Oats_Amps = _minmaxTrans.Translate(item.Oats_Amps)
'        t.PowerExt_Amps = _minmaxTrans.Translate(item.PowerExt_Amps)
'        t.PowerExt_TravTime = _minmaxTrans.Translate(item.PowerExt_TravTime)
'        t.Gps_Amps = _minmaxTrans.Translate(item.Gps_Amps)
'        t.Ca_Amps = _minmaxTrans.Translate(item.Ca_Amps)
'        Return t
'    End Function
'End Class
'Public Class MinMaxTanslate
'    Implements ITranslate(Of Udt_MinMax, Model_MinMax)

'    Public Function Translate(item As Udt_MinMax) As Model_MinMax Implements ITranslate(Of Udt_MinMax, Model_MinMax).Translate
'        Dim t = New Model_MinMax
'        t.Max = item.Max
'        t.Min = item.Min
'        Return t
'    End Function
'End Class

'Public Class NestTranslate
'    Implements ITranslate(Of Udt_Nest, Model_Nest)

'    Private ReadOnly _partoptionsTrans As ITranslate(Of Udt_PartOptions, Model_PartOptions)
'    Private ReadOnly _glassoptionsTrans As ITranslate(Of Udt_GlassOptions, Model_GlassOptions)
'    Private ReadOnly _logValuesTrans As ITranslate(Of Udt_Logvalues, Model_Logvalues)
'    Private ReadOnly _analogitemsTrans As ITranslate(Of Udt_AnalogItems, Model_AnalogItems)
'    Private ReadOnly _manualoperatorsTrans As ITranslate(Of Udt_Manual_Operators, Model_Manual_Operators)
'    Private ReadOnly _mcaltrans As ITranslate(Of Udt_Mcal, Model_Mcal)
'    Public Sub New(partoptionsTrans As PartOptionsTranslate,
'                   glassoptionsTrans As GlassOptionsTranslate,
'                   logValuesTrans As LogValuesTranslate,
'                   analogitemsTrans As AnalogItemsTranslate,
'                   manualoperatorsTrans As ManualOperatorsTranslate,
'                   mcaltrans As McalTranslate)
'        _partoptionsTrans = partoptionsTrans
'        _glassoptionsTrans = glassoptionsTrans
'        _logValuesTrans = logValuesTrans
'        _analogitemsTrans = analogitemsTrans
'        _manualoperatorsTrans = manualoperatorsTrans
'        _mcaltrans = mcaltrans
'    End Sub

'    Public Function Translate(item As Udt_Nest) As Model_Nest Implements ITranslate(Of Udt_Nest, Model_Nest).Translate
'        Dim t As New Model_Nest
'        t.NestIdx = item.NestIdx
'        t.SeqVal = item.SeqVal
'        t.AlarmVal = item.AlarmVal
'        t.Logitems = _logValuesTrans.Translate(item.Logitems)
'        t.PartOptions = _partoptionsTrans.Translate(item.PartOptions)
'        t.GlassOptions = _glassoptionsTrans.Translate(item.GlassOptions)
'        t.AlgFeatures = _analogitemsTrans.Translate(item.AlgFeatures)
'        t.ModeRequest = item.ModeRequest
'        t.ModeStatus = item.ModeStatus
'        t.ManualOps = _manualoperatorsTrans.Translate(item.ManualOps)
'        t.CalibrationChangeId = item.CalibrationChangeId
'        t.TargetColor = item.TargetColor
'        t.DetectedColor = item.DetectedColor
'        t.AlarmBits = item.AlarmBits
'        t.PartFltBits = item.PartFltBits
'        t.Py_Status = item.Py_Status
'        t.CurrentMirrorCal = _mcaltrans.Translate(item.CurrentMirrorCal)
'        t.CalEdit = _mcaltrans.Translate(item.CalEdit)
'        t.SetAngleCal = item.SetAngleCal
'        t.CurrentGlassType = item.CurrentGlassType
'        Return t
'    End Function
'End Class
'Public Class LogValuesTranslate
'    Implements ITranslate(Of Udt_Logvalues, Model_Logvalues)

'    Private ReadOnly _logitemTrans As ITranslate(Of Udt_LogItem, Model_LogItem)
'    Public Sub New(logitemTrans As LogItemTranslate)
'        _logitemTrans = logitemTrans
'    End Sub

'    Public Function Translate(item As Udt_Logvalues) As Model_Logvalues Implements ITranslate(Of Udt_Logvalues, Model_Logvalues).Translate
'        Dim t As New Model_Logvalues
'        t.partNumber = item.partNumber.ToString()
'        t.StationId = item.StationId
'        t.Nest = item.Nest
'        t.ClockNumber = item.ClockNumber.ToString()
'        t.MirrorUpTravel = _logitemTrans.Translate(item.MirrorUpTravel)
'        t.MirrorUpRate = _logitemTrans.Translate(item.MirrorUpRate)
'        t.MirrorUpAmp = _logitemTrans.Translate(item.MirrorUpAmp)
'        t.MirrorMemAtUp = _logitemTrans.Translate(item.MirrorMemAtUp)
'        t.MirrorDwnTravel = _logitemTrans.Translate(item.MirrorDwnTravel)
'        t.MirrorDwnRate = _logitemTrans.Translate(item.MirrorDwnRate)
'        t.MirrorDwnAmp = _logitemTrans.Translate(item.MirrorDwnAmp)
'        t.MirrorMemAtDwn = _logitemTrans.Translate(item.MirrorMemAtDwn)
'        t.MirrorInBoardTravel = _logitemTrans.Translate(item.MirrorInBoardTravel)
'        t.MirrorInBoardRate = _logitemTrans.Translate(item.MirrorInBoardRate)
'        t.MirrorInBoardAmp = _logitemTrans.Translate(item.MirrorInBoardAmp)
'        t.MirrorMemAtInBoard = _logitemTrans.Translate(item.MirrorMemAtInBoard)
'        t.MirrorOutBoardTravel = _logitemTrans.Translate(item.MirrorOutBoardTravel)
'        t.MirrorOutBoardRate = _logitemTrans.Translate(item.MirrorOutBoardRate)
'        t.MirrorOutBoardAmp = _logitemTrans.Translate(item.MirrorOutBoardAmp)
'        t.MirrorMemAtOutBoard = _logitemTrans.Translate(item.MirrorMemAtOutBoard)
'        t.Defog = _logitemTrans.Translate(item.Defog)
'        t.Defog_InRush = _logitemTrans.Translate(item.Defog_InRush)
'        t.GlassPull = _logitemTrans.Translate(item.GlassPull)
'        t.Ec_Amp = _logitemTrans.Translate(item.Ec_Amp)
'        t.Ts_Amp = _logitemTrans.Translate(item.Ts_Amp)
'        t.Gi_Amp = _logitemTrans.Translate(item.Gi_Amp)
'        t.LogoLamp_Amp = _logitemTrans.Translate(item.LogoLamp_Amp)
'        t.Bzi_Amp = _logitemTrans.Translate(item.Bzi_Amp)
'        t.Pf_Amp = _logitemTrans.Translate(item.Pf_Amp)
'        t.Pf_Trav_Time = _logitemTrans.Translate(item.Pf_Trav_Time)
'        t.PowerExt_Amp = _logitemTrans.Translate(item.PowerExt_Amp)
'        t.PowerExt_Trav_Time = _logitemTrans.Translate(item.PowerExt_Trav_Time)
'        t.Oats_Amp = _logitemTrans.Translate(item.Oats_Amp)
'        t.CargoLamp_Amp = _logitemTrans.Translate(item.CargoLamp_Amp)
'        t.Gps_Amp = _logitemTrans.Translate(item.Gps_Amp)
'        t.Ca_Amp = _logitemTrans.Translate(item.Ca_Amp)
'        t.ResultCode = item.ResultCode
'        t.FltBits = item.FltBits
'        Return t
'    End Function
'End Class
'Public Class LogItemTranslate
'    Implements ITranslate(Of Udt_LogItem, Model_LogItem)

'    Public Function Translate(item As Udt_LogItem) As Model_LogItem Implements ITranslate(Of Udt_LogItem, Model_LogItem).Translate
'        Dim t = New Model_LogItem
'        t.Result = item.Result
'        t.Value = item.Value
'        Return t
'    End Function
'End Class
'Public Class AnalogItemsTranslate
'    Implements ITranslate(Of Udt_AnalogItems, Model_AnalogItems)
'    Private ReadOnly _algitemTrans As ITranslate(Of Udt_AlgItem, Model_AlgItem)
'    Public Sub New(algitemTrans As AlgItemTranslate)
'        _algitemTrans = algitemTrans
'    End Sub
'    Public Function Translate(item As Udt_AnalogItems) As Model_AnalogItems Implements ITranslate(Of Udt_AnalogItems, Model_AnalogItems).Translate
'        Dim t = New Model_AnalogItems
'        t.VertAmp = _algitemTrans.Translate(item.VertAmp)
'        t.HorzAmp = _algitemTrans.Translate(item.HorzAmp)
'        t.VertAngle = _algitemTrans.Translate(item.VertAngle)
'        t.HorzAngle = _algitemTrans.Translate(item.HorzAngle)
'        t.Vert_Mem = _algitemTrans.Translate(item.Vert_Mem)
'        t.Horz_Mem = _algitemTrans.Translate(item.Horz_Mem)
'        t.DefogAmp = _algitemTrans.Translate(item.DefogAmp)
'        t.Gi_Amp = _algitemTrans.Translate(item.Gi_Amp)
'        t.Bzi_Amp = _algitemTrans.Translate(item.Bzi_Amp)
'        t.Ts_Amp = _algitemTrans.Translate(item.Ts_Amp)
'        t.Pf_Amp = _algitemTrans.Translate(item.Pf_Amp)
'        t.GlassPull = _algitemTrans.Translate(item.GlassPull)
'        t.Ec_Amp = _algitemTrans.Translate(item.Ec_Amp)
'        t.CargoLamp_Amp = _algitemTrans.Translate(item.CargoLamp_Amp)
'        t.Oats_Amp = _algitemTrans.Translate(item.Oats_Amp)
'        t.Nest = item.Nest
'        Return t
'    End Function
'End Class
'Public Class AlgItemTranslate
'    Implements ITranslate(Of Udt_AlgItem, Model_AlgItem)

'    Public Function Translate(item As Udt_AlgItem) As Model_AlgItem Implements ITranslate(Of Udt_AlgItem, Model_AlgItem).Translate
'        Dim t = New Model_AlgItem
'        t.AnalogInDint = item.AnalogInDint
'        t.CalValue = item.CalValue
'        t.Value = item.Value
'        t.Offset = item.Offset
'        t.MinRawCalDeflect = item.MinRawCalDeflect
'        Return t
'    End Function
'End Class
'Public Class ManualOperatorsTranslate
'    Implements ITranslate(Of Udt_Manual_Operators, Model_Manual_Operators)

'    Public Function Translate(item As Udt_Manual_Operators) As Model_Manual_Operators Implements ITranslate(Of Udt_Manual_Operators, Model_Manual_Operators).Translate
'        Dim t As New Model_Manual_Operators
'        t.Clamps = item.Clamps
'        t.Tooling = item.Tooling
'        t.Defog = item.Defog
'        t.MirrrorActuator = item.MirrrorActuator
'        t.TurnSignal = item.TurnSignal
'        t.Gi = item.Gi
'        t.Pfold = item.Pfold
'        t.MemoryCr = item.MemoryCr
'        t.CameraItems = item.CameraItems
'        t.GlassPull = item.GlassPull
'        t.ColorCmds = item.ColorCmds
'        t.BZI = item.BZI
'        t.GroundCheck = item.GroundCheck
'        t.Pcode = item.Pcode.ToString()
'        t.JoyStick = item.JoyStick
'        t.PullTest = item.PullTest
'        t.TrapDoorProbe = item.TrapDoorProbe
'        t.Ec = item.Ec
'        t.CargoLamp = item.CargoLamp
'        t.Oats = item.Oats
'        Return t
'    End Function
'End Class

'Public Class McalTranslate
'    Implements ITranslate(Of Udt_Mcal, Model_Mcal)

'    Private ReadOnly _modelscaleTrans As ITranslate(Of Udt_Scale, Model_Scale)
'    Public Sub New(modelscaleTrans As ModelScaleTranslate)
'        _modelscaleTrans = modelscaleTrans
'    End Sub

'    Public Function Translate(item As Udt_Mcal) As Model_Mcal Implements ITranslate(Of Udt_Mcal, Model_Mcal).Translate
'        Dim t As New Model_Mcal
'        t.H = _modelscaleTrans.Translate(item.H)
'        t.V = _modelscaleTrans.Translate(item.V)
'        Return t
'    End Function
'End Class
'Public Class ModelScaleTranslate
'    Implements ITranslate(Of Udt_Scale, Model_Scale)

'    Public Function Translate(item As Udt_Scale) As Model_Scale Implements ITranslate(Of Udt_Scale, Model_Scale).Translate
'        Dim t = New Model_Scale
'        t.RawMin = item.RawMin
'        t.EuMin = item.EuMin
'        t.RawMax = item.RawMax
'        t.EuMax = item.EuMax
'        t.Value = item.Value
'        t.RawIn = item.RawIn
'        t.MinDeflect = item.MinDeflect
'        Return t
'    End Function
'End Class
'Public Class HeartBeatTranslate
'    Implements ITranslate(Of Udt_HeartBeat, Model_HeartBeat)

'    Public Function Translate(item As Udt_HeartBeat) As Model_HeartBeat Implements ITranslate(Of Udt_HeartBeat, Model_HeartBeat).Translate
'        Dim t = New Model_HeartBeat
'        t.Status = item.Status
'        t.Value = item.Value
'        Return t
'    End Function
'End Class