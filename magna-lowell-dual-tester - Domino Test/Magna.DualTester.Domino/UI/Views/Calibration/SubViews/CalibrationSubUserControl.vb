Imports NLog
Imports Magna.DualTester.Domino.UI.Dialogs
Imports Magna.DualTester.Domino.TesterApi
Imports Magna.DualTester.Plc.Core
Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data.Enums

Namespace UI.Views.Calibration.SubViews

    Public Class CalibrationSubUserControl
        Implements IView(Of CalibrationSubViewModel)

        Private Const MirrrorActuator = "MirrrorActuator"
        Private Const Pfold = "Pfold"
        Private Const HorzAngle = "HorzAngle"
        Private Const VertAngle = "VertAngle"
        Private ReadOnly Property _isEngieOrBetter As Boolean
            Get
                Return CBool(_tmpuser?.AccessLevel >= AccessLevel.Engineer)
            End Get
        End Property
        Private ReadOnly Property _isAdminOrBetter As Boolean
            Get
                Return CBool(_tmpuser?.AccessLevel >= AccessLevel.Admin)
            End Get
        End Property
        Private Property _vm As CalibrationSubViewModel
        Private Property _tmpuser As User
        Dim _logger As Logger = LogManager.GetCurrentClassLogger()
        Private Property Textboxes As New List(Of TextBox)
        'Private Property QueForRefresh As Boolean

        Private _plc As IPlc
        Public WriteOnly Property SetPlc As IPlc
            Set(value As IPlc)
                _plc = value
            End Set
        End Property



        'Dim _LastGlassType As Integer
        'Public Property GlassType As Integer
        '    Get
        '        Return _LastGlassType
        '    End Get
        '    Set(value As Integer)
        '        If _LastGlassType <> value Then

        '        End If
        '        _LastGlassType = value
        '    End Set
        'End Property
        Private _msgsvc As IMessageAlertService
        Public Sub New()
            'MyBase.New(AccessLevel.Engineer)
            InitializeComponent()
            GetTextBoxes(TableLayoutPanel5)
        End Sub

        Public WriteOnly Property SetMessageService As IMessageAlertService
            Set(value As IMessageAlertService)
                _msgsvc = value
            End Set
        End Property

        'Private Sub BtnZero_Click(sender As Object, e As EventArgs)
        '    WriteAlgFeatures(HorzAngle, 0)
        '    WriteAlgFeatures(VertAngle, 0)
        'End Sub

        Private Sub LaunchDialog(val As Udt_AlgItem, label As String)
            If val Is Nothing Then
                _msgsvc.PublishNewAlarm("Could not open dialog algItem is null", ErrorLevel.Error, 2)
                _logger.Error("Val is null LaunchDialog() @CalibrationSubUserControl")
                Return
            End If

            If val.AnalogInDint >= val.MinRawCalDeflect Then
                Dim dilg As New ValueDialog(label, ValueDialog.Units.A, val.Value, _tmpuser, _msgsvc)
                If dilg.ShowDialog(Me) = DialogResult.OK AndAlso Not dilg.Value.Equals(val.Value) Then
                    'val.Value = Math.Abs(dilg.Value)
                    'WriteData(label, dilg.Value)
                    val.CalValue = Math.Abs(dilg.Value) 'val.Value '/ val.AnalogInDint
                    WriteAlgFeatures(label, val)


                    Me.RaiseSaved(String.Format(PlcConstants.TesterAddress + ".Nest{0}.CalibrationChangeId", _vm.NestId), CObj(1))
                    'after changing eng val add testapi.nest#.calibrationchangeId = 1
                End If
            End If
        End Sub

        Sub RaiseSaved(address As String, obj As Object, Optional msg As String = "")
            _plc.ManualWrite(New SaveEventArgs(address, obj, message:=msg))
        End Sub

        Private Sub GetTextBoxes(node As TableLayoutPanel)
            For Each item In node.Controls
                If item.GetType() = GetType(TableLayoutPanel) Then
                    GetTextBoxes(DirectCast(item, TableLayoutPanel))
                ElseIf item.GetType() = GetType(TextBox) Then
                    Textboxes.Add(DirectCast(item, TextBox))
                End If
            Next
        End Sub

        Public Sub Reset()
            For Each Item In Textboxes
                Item.Text = "0.0"
            Next
        End Sub

        'Public Sub LoadData(data As Object)

        'End Sub

        'Public Sub MovingInManual(GlassType As GlassTypeEnum, Motion As Quadrant)
        '    Dim CameraVal As Integer = 0
        '    Select Case Motion
        '        Case Quadrant.IB
        '        '    CameraVal =
        '        Case Quadrant.OB
        '        Case Quadrant.Down
        '        Case Quadrant.Up
        '    End Select
        'End Sub



        Private Sub WriteAlgFeatures(itemName As String, data As Object, Optional message As String = Nothing)
            Me.RaiseSaved($"{GetNestAddress(_vm.NestId)}.AlgFeatures.{itemName}", data, message)
        End Sub

        Private Sub WriteManualOps(itemName As String, data As Object, Optional message As String = Nothing)
            Me.RaiseSaved($"{GetNestAddress(_vm.NestId)}.ManualOps.{itemName}", data, message)
        End Sub

#Region "Click Events"

        Private Sub Btn_Click(sender As Object, e As EventArgs) Handles BtnPFold.Click,
                                                                        BtnTurnSig.Click,
                                                                        BtnHeater.Click,
                                                                        BtnHorzAmp.Click,
                                                                        BtnVertAmp.Click,
                                                                        BtnBzi.Click,
                                                                        BtnEc.Click,
                                                                        BtnGi.Click,
                                                                        BtnCargoLamp.Click,
                                                                        BtnOats.Click
            If _vm Is Nothing Then
                _logger.Error("Nest is null Btn_click() @CalibrationSubUserControl")
                _msgsvc.PublishNewAlarm("Nest is null can't launch Edit Dialog", ErrorLevel.Error, 3)
                Return
            End If


            Try
                If sender Is BtnPFold Then
                    LaunchDialog(_vm.AlgFeatures.Pf_Amp, "Pf_Amp")
                    'ElseIf sender Is BtnGi Then
                    '    LaunchDialog(Nest.AlgFeatures.Gi_Amp, "Gi_Amp")
                ElseIf sender Is BtnTurnSig Then
                    LaunchDialog(_vm.AlgFeatures.Ts_Amp, "Ts_Amp")
                ElseIf sender Is BtnHeater Then
                    LaunchDialog(_vm.AlgFeatures.DefogAmp, "DefogAmp")
                ElseIf sender Is BtnHorzAmp Then
                    LaunchDialog(_vm.AlgFeatures.HorzAmp, "HorzAmp")
                ElseIf sender Is BtnVertAmp Then
                    LaunchDialog(_vm.AlgFeatures.VertAmp, "VertAmp")
                ElseIf sender Is BtnBzi Then
                    LaunchDialog(_vm.AlgFeatures.Bzi_Amp, "Bzi_Amp")
                ElseIf sender Is BtnEc Then
                    LaunchDialog(_vm.AlgFeatures.Ec_Amp, "EC_Amp")
                ElseIf sender Is BtnGi Then
                    LaunchDialog(_vm.AlgFeatures.Gi_Amp, "Gi_Amp")
                ElseIf sender Is BtnCargoLamp Then
                    LaunchDialog(_vm.AlgFeatures.CargoLamp_Amp, "CargoLamp_Amp")
                ElseIf sender Is BtnOats Then
                    LaunchDialog(_vm.AlgFeatures.Oats_Amp, "OATS_Amp")
                End If
            Catch ex As NullReferenceException
                _logger.Error("null exception Btn_click() @CalibrationSubUserControl:: " + ex.ToString())
                _msgsvc.PublishNewAlarm("null exception can't launch Edit Dialog", ErrorLevel.Error, 3)
            End Try
        End Sub

        Private Sub PowerToggle_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVerAmpPower.MouseClick,
                                                                                        ChkHorizPwr.MouseClick,
                                                                                        ChkPfoldPower.MouseClick
            If sender Is ChkVerAmpPower Then
                WriteManualOps(MirrrorActuator, If(ChkVerAmpPower.Checked, 1, 0))
            ElseIf sender Is ChkHorizPwr Then
                WriteManualOps(MirrrorActuator, If(ChkHorizPwr.Checked, 4, 0))
            ElseIf sender Is ChkPfoldPower Then
                WriteManualOps(Pfold, If(ChkPfoldPower.Checked, 1, 0))
            End If
        End Sub

#End Region

        Public Sub NewUser(user As User)
            _tmpuser = user
        End Sub


        'Private Sub MirrorTraining_RequestingCurrentCalData() Handles MirrorTraining.RequestingCurrentCalData
        '    QueForRefresh = True
        'End Sub

        Private Sub MirrorTraining_SendAngleCalDataRequest(CalData As Udt_Mcal) Handles MirrorTraining.SendAngleCalDataRequest
            Dim nestAddress = GetNestAddress(_vm.NestId)
            Me.RaiseSaved($"{nestAddress}.CalEdit", CalData, "Angle calibration sent to PLC")
            Me.RaiseSaved($"{nestAddress}.SetAngleCal", 1, "Angle calibration sent to PLC")
            MirrorTraining.CalEventComplete()
        End Sub



        Private Shared Function GetNestAddress(nid As Integer) As String
            Return $"{PlcConstants.TesterAddress}.Nest{nid}"
        End Function
        Public Sub UpdateViewModel(data As CalibrationSubViewModel) Implements IView(Of CalibrationSubViewModel).UpdateViewModel

            If InvokeRequired Then
                Invoke(Sub() UpdateViewModel(data))
                Return
            End If

            Dim compair = Function(analogVal As Integer, mincal As Integer) As Boolean
                              Dim minrawcal = Math.Abs(mincal)
                              Return Math.Abs(analogVal) >= minrawcal AndAlso minrawcal > 0 'so both are above zero and analog is greater than or eqaul to minrawcal
                          End Function
            If data.NestId < 1 Then
                Throw New Exception("nest id not set")
            End If
            Try
                _vm = data
                'Nest = obj 'If(NestId = 1, obj.Nest1, obj.Nest2)
                If _vm IsNot Nothing Then
                    With _vm.AlgFeatures
                        LblMirrorAngleHorizValue.Text = .HorzAngle.Value.ToString() + " °"
                        LblMirrorAngleVertValue.Text = .VertAngle.Value.ToString() + " °"
                        LblMirrorAngleHorizRaw.Text = .HorzAngle.AnalogInDint.ToString()
                        LblMirrorAngleVertRaw.Text = .VertAngle.AnalogInDint.ToString()
                        LblHorzValue.Text = .HorzAmp.Value.ToString() + " A"
                        LblHorzRaw.Text = .HorzAmp.AnalogInDint.ToString()
                        LblVertValue.Text = .VertAmp.Value.ToString() + " A"
                        LblVertRaw.Text = .VertAmp.AnalogInDint.ToString()
                        LblHeaterValue.Text = .DefogAmp.Value.ToString() + " A"
                        LblHeaterRaw.Text = .DefogAmp.AnalogInDint.ToString()
                        LblTurnSigValue.Text = .Ts_Amp.Value.ToString() + " A"
                        LblTurnSigRaw.Text = .Ts_Amp.AnalogInDint.ToString()
                        'LblGiValue.Text = .Gi_Amp.Value.ToString() + " A"
                        'LblGiRaw.Text = .Gi_Amp.AnalogInDint.ToString()
                        LblPfoldValue.Text = .Pf_Amp.Value.ToString() + " A"
                        LblPfoldRaw.Text = .Pf_Amp.AnalogInDint.ToString()



                        LblBziVal.Text = .Bzi_Amp.Value.ToString()
                        LblBziRaw.Text = .Bzi_Amp.AnalogInDint.ToString()

                        LblEcValue.Text = .Ec_Amp.Value.ToString()
                        LblEcRaw.Text = .Ec_Amp.AnalogInDint.ToString()

                        LblGiValue.Text = .Gi_Amp.Value.ToString()
                        LblGiRaw.Text = .Gi_Amp.AnalogInDint.ToString()

                        LblCargoLampValue.Text = .CargoLamp_Amp.Value.ToString()
                        LblCargoLampRaw.Text = .CargoLamp_Amp.AnalogInDint.ToString()

                        LblOatsValue.Text = .Oats_Amp.Value.ToString()
                        LblOatsRaw.Text = .Oats_Amp.AnalogInDint.ToString()

                        'LblBziValue.Text = .Bzi_Amp.Value.ToString() + " A"
                        'LblBziRaw.Text = .Bzi_Amp.AnalogInDint.ToString()
                        ' LblPullValue.Text = .GlassPull.Value.ToString() + " mm"
                        ' LblPullRaw.Text = .GlassPull.AnalogInDint.ToString()
                        LblVmemValue.Text = .Vert_Mem.Value.ToString() + " V"
                        LblHmemValue.Text = .Horz_Mem.Value.ToString() + " V"

                        'BtnMirrorAngle.Enabled = _isAdminOrBetter ' compair(alg.HorzAngle.AnalogInDint, alg.HorzAngle.MinRawCalDeflect)
                        'BtnZero.Enabled = _isAdminOrBetter ' compair(alg.HorzAngle.AnalogInDint, alg.HorzAngle.MinRawCalDeflect)
                        'BtnHorzAmp.Enabled = compair(.HorzAmp.AnalogInDint, .HorzAmp.MinRawCalDeflect)
                        'BtnVertAmp.Enabled = compair(.VertAmp.AnalogInDint, .VertAmp.MinRawCalDeflect)

                        BtnHeater.Enabled = _isAdminOrBetter 'compair(.DefogAmp.AnalogInDint, .DefogAmp.MinRawCalDeflect) AndAlso _isEngieOrBetter
                        BtnTurnSig.Enabled = _isAdminOrBetter 'compair(.Ts_Amp.AnalogInDint, .Ts_Amp.MinRawCalDeflect) AndAlso _isEngieOrBetter
                        BtnGi.Enabled = _isAdminOrBetter 'compair(.Gi_Amp.AnalogInDint, .Gi_Amp.MinRawCalDeflect) AndAlso _isEngieOrBetter
                        BtnPFold.Enabled = _isAdminOrBetter 'compair(.Pf_Amp.AnalogInDint, .Pf_Amp.MinRawCalDeflect) AndAlso _isEngieOrBetter
                        BtnBzi.Enabled = _isAdminOrBetter 'compair(.Bzi_Amp.AnalogInDint, .Bzi_Amp.MinRawCalDeflect) AndAlso _isEngieOrBetter
                        'BtnPullPosition.Enabled = compair(.GlassPull.AnalogInDint, .GlassPull.MinRawCalDeflect) AndAlso _isEngieOrBetter
                        'BtnPullPosition.Enabled = .GlassPull.AnalogInDint >= .GlassPull.MinRawCalDeflect AndAlso .GlassPull.MinRawCalDeflect > 0 AndAlso lvlEngie

                        MirrorTraining.UpdateViewModel(New UcCoordinateViewModel(_vm))

                    End With
                    BtnHorzAmp.Enabled = _isAdminOrBetter
                    BtnVertAmp.Enabled = _isAdminOrBetter
                    ChkPfoldPower.Enabled = _isAdminOrBetter
                    ChkHorizPwr.Enabled = _isAdminOrBetter
                    ChkVerAmpPower.Enabled = _isAdminOrBetter
                    ChkPfoldPower.Checked = CBool(_vm.ManualOps.Pfold And 1)
                    ChkHorizPwr.Checked = CBool(_vm.ManualOps.MirrrorActuator And 4)
                    ChkVerAmpPower.Checked = CBool(_vm.ManualOps.MirrrorActuator And 1)
                Else
                    Reset()
                    _msgsvc.PublishNewAlarm("Nest data is null at LoadData @CalibrationSubUserControl", ErrorLevel.Error, 2)
                End If
            Catch ex As NullReferenceException
                _logger.Error("Null ref LoadData() @CalibrationSubUserControl:: " + ex.ToString())
            End Try
        End Sub

        Private Sub MirrorTraining_Load(sender As Object, e As EventArgs) Handles MirrorTraining.Load

        End Sub

        Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

        End Sub
    End Class
End Namespace


'do we want to shut off buttons after editing engval from screen

'can only enter engineering values if testerapi.nest#.algfeatures.horzmap.minrawcalDefect < rawValue
'both values have to be above zero
'and if user is engineer or higher
'

'scalefactor = eng val/rawinput
'get raw from plc
'get engval from screen
'push scale factor to plc


'after changing eng val add testapi.nest#.calibrationchangeId = 1