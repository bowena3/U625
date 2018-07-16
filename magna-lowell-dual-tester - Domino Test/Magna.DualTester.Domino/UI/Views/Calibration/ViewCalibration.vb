Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data
Imports Magna.DualTester.Core.Data.Enums
Imports Magna.DualTester.Domino.TesterApi
Imports NLog

Namespace UI.Views.Calibration

    Public Class ViewCalibration
        Implements IViewTask

        ReadOnly _logger As Logger = NLog.LogManager.GetCurrentClassLogger

        ReadOnly Property _isTechOrBetter As Boolean
            Get
                Return _userWatch.CheckCurrentUserPermission(AccessLevel.Tech)
            End Get
        End Property

        Dim _selectedNestId As Integer = -1 'This is just so that when the form starts it has a value to change from
        Private _screenUnlocked As Boolean = False
        Private _tester As Udt_tester

        Private Property SelectedNestId As Integer
            Get
                Return _selectedNestId
            End Get
            Set(value As Integer)
                Dim run = Sub()
                              Dim setbtns = Sub(activBtn As Button, notactive As Button)
                                                activBtn.BackColor = Color.LimeGreen
                                                notactive.BackColor = SystemColors.Control
                                                activBtn.Enabled = _isTechOrBetter
                                                notactive.Enabled = False
                                            End Sub
                              Select Case _selectedNestId
                                  Case 0
                                      BtnNest1.BackColor = SystemColors.Control
                                      BtnNest2.BackColor = SystemColors.Control
                                      BtnNest1.Enabled = _isTechOrBetter
                                      BtnNest2.Enabled = _isTechOrBetter
                                  Case 1
                                      setbtns(BtnNest1, BtnNest2)
                                  Case 2
                                      setbtns(BtnNest2, BtnNest1)
                              End Select
                              ScreenUnlocked = _isTechOrBetter AndAlso ({1, 2}.Contains(_selectedNestId))

                          End Sub
                If value <> _selectedNestId Then
                    _selectedNestId = value
                    If InvokeRequired Then BeginInvoke(run) Else run()
                End If
            End Set
        End Property

        Public Property RunningTask As Task Implements IViewTask.RunningTask

        Private ReadOnly _langWatch As ILanguageWatch
        Private ReadOnly _userWatch As IUserWatch
        Private ReadOnly _plc As IPlc
        Private ReadOnly _cfg As ICfgDomino
        Private ReadOnly _msgsvc As IMessageAlertService
        Private ReadOnly _plcrepo As IPlcFullRepo

        Public Sub New(langWatch As ILanguageWatch, cfg As ICfgDomino, userWatch As IUserWatch, plc As IPlc, msgsvc As IMessageAlertService, plcrepo As IPlcFullRepo)
            _langWatch = langWatch
            _userWatch = userWatch
            _plc = plc
            _cfg = cfg
            _plcrepo = plcrepo
            _msgsvc = msgsvc
            InitializeComponent()
            ActuatorUserControl1.SetPlc = _plc
            CalibrationSubUserControl1.SetPlc = _plc
            TesterDevicesUserControl1.SetPlc = _plc
            CalibrationSubUserControl1.SetMessageService = msgsvc
        End Sub

        Private Sub IViewTask_Load() Implements IViewTask.Load
            NewUser(_userWatch.CurrentValue)
            LoadData(_plcrepo.TesterData)
            AddHandler _userWatch.ValueChanged, AddressOf NewUser
            AddHandler _plcrepo.TesterContextChanged, AddressOf LoadData
        End Sub

        Private Shared Function NestAddress(nestid As Integer) As String
            Return $"{PlcConstants.TesterAddress}.Nest{nestid}"
        End Function

#Region "safe function"

        ''' <summary>
        ''' This property controls whether or not the 3 user controls are locked or not. Setting this to false will lock the user controls,
        ''' and will unlock the controls if set to true.
        ''' </summary>
        Private Property ScreenUnlocked As Boolean
            Get
                Return _screenUnlocked
            End Get
            Set(value As Boolean)
                _screenUnlocked = value
                Dim run = Sub()
                              MainControlPanel.Enabled = _screenUnlocked
                          End Sub
                If InvokeRequired Then BeginInvoke(run) Else run()
            End Set
        End Property

        Private Sub UpdateViews(nest As Udt_Nest)

            Dim run = Sub()

                          TesterDevicesUserControl1.UpdateViewModel(New TesterDevicesViewModel(SelectedNestId, nest, _plc.Colors()))
                          ActuatorUserControl1.UpdateViewModel(New ActuatorViewModel(SelectedNestId, nest))
                          CalibrationSubUserControl1.UpdateViewModel(New CalibrationSubViewModel(SelectedNestId, nest))
                          TesterDevicesUserControl1.UpdateViewModel(New TesterDevicesViewModel(SelectedNestId, nest, _plc.Colors()))
                      End Sub
            If InvokeRequired Then BeginInvoke(run) Else run()
        End Sub

        Private Function CheckNest(nest As Udt_Nest, nid As Integer) As Boolean
            If nest Is Nothing Then
                _logger.Error("Nest is null CheckNest() @viewCalibration")
                Return False
            End If

            Dim passed As Boolean = True
            passed = Not CBool(nest.ManualOps.Defog) AndAlso passed
            passed = Not CBool(nest.ManualOps.TurnSignal) AndAlso passed
            passed = Not CBool(nest.ManualOps.Gi) AndAlso passed
            passed = Not CBool(nest.ManualOps.BZI) AndAlso passed
            passed = Not CBool(nest.ManualOps.CameraItems) AndAlso passed
            passed = Not CBool(nest.ManualOps.GroundCheck) AndAlso passed
            passed = Not CBool(nest.ManualOps.MemoryCr) AndAlso passed
            passed = Not CBool(nest.ManualOps.MirrrorActuator) AndAlso passed
            passed = Not CBool(nest.ManualOps.Pfold) AndAlso passed
            If Not passed Then
                _msgsvc.PublishNewAlarm(String.Format("All toggles must be off before setting NEST {0} to auto", nid), ErrorLevel.Alert)
            End If
            Return passed
        End Function

        Public Sub Reset()
            Dim run = Sub()
                          LblAlarm.Text = String.Empty
                          LblStep.Text = String.Empty
                          'ScreenUnlocked = False
                          'SelectedNestId = 0
                          SetNestToAuto(1)
                          SetNestToAuto(2)
                      End Sub
            If InvokeRequired Then BeginInvoke(run) Else run()
        End Sub

#End Region

#Region "form events"

        Private Sub BtnNest_Click(sender As Object, e As EventArgs) Handles BtnNest1.Click, BtnNest2.Click
            If _tester Is Nothing Then
                Exit Sub
            End If
            Dim btn As Button = TryCast(sender, Button)
            If sender Is BtnNest1 Then
                NestClickCheck(_tester.Nest1, 1, btn)
            ElseIf sender Is BtnNest2 Then
                NestClickCheck(_tester.Nest2, 2, btn)
            End If
        End Sub

#End Region

        Private Sub NestClickCheck(nest As Udt_Nest, nid As Integer, btn As Button) ', nestBtn As Button, otherNest As Udt_Nest, otherNid As Integer, otherNestBtn As Button)
            If _isTechOrBetter Then
                If nid = SelectedNestId Then 'set nest to auto
                    If CheckNest(nest, nid) Then
                        SetNestToAuto(nid)
                    End If
                ElseIf SelectedNestId = 0 Then 'set nest to manual
                    btn.BackColor = Color.Yellow
                    RaiseSaved($"{NestAddress(nid)}.ModeRequest", NestModeStatus.Manual)
                End If
            Else
                _msgsvc.PublishNewAlarm("You need Tech or higher access level", ErrorLevel.Alert)
            End If
        End Sub

        Private Sub RaiseSaved(address As String, obj As Object, Optional msg As String = "")
            _plc.ManualWrite(address, obj, message:=msg)
        End Sub

        Private Sub SetUi()

            Try
                If _tester IsNot Nothing Then
                    If _tester.Nest1.ModeStatus = NestModeStatus.Manual OrElse _tester.Nest2.ModeStatus = NestModeStatus.Manual Then
                        If _tester.Nest1.ModeStatus = NestModeStatus.Manual AndAlso _tester.Nest2.ModeStatus = NestModeStatus.Manual Then
                            _msgsvc.PublishNewAlarm("Both nests are in manual, setting nests to auto", ErrorLevel.Alert)
                            SelectedNestId = -1
                            SetNestToAuto(1)
                            SetNestToAuto(2)
                        ElseIf _tester.Nest1.ModeStatus = NestModeStatus.Manual Then
                            SelectedNestId = 1
                        ElseIf _tester.Nest2.ModeStatus = NestModeStatus.Manual Then
                            SelectedNestId = 2
                        End If
                    Else
                        SelectedNestId = 0
                    End If

                    Dim nest As Udt_Nest = Nothing
                    Dim stepPair As EnglishSpanishMap = Nothing
                    Dim alarmPair As EnglishSpanishMap = Nothing
                    If {1, 2}.Contains(SelectedNestId) Then
                        nest = If(SelectedNestId = 1, _tester.Nest1, _tester.Nest2)
                        UpdateViews(nest)
                        Dim alrmVal As UInteger = 0
                        If nest.AlarmVal <> 0 Then
                            For x As UInteger = 0 To 31
                                Dim tmpPos As UInteger = CUInt(Math.Pow(2, x))
                                If CBool(nest.AlarmVal And tmpPos) Then
                                    alrmVal = x
                                End If
                            Next
                            alrmVal = CUInt(alrmVal + 1)
                        End If
                        Dim cfg = _cfg.ReadConfig()
                        stepPair = cfg.SequenceStrings.Single(Function(x) x.Index = nest.SeqVal)
                        alarmPair = cfg.MachineAlarms.Single(Function(z) z.Index = alrmVal)
                    End If
                    Dim updateLabels = Sub(alrmMap As EnglishSpanishMap, stepMap As EnglishSpanishMap)
                                           LblStep.Text = stepMap?.Value.GetString(_langWatch.CurrentValue) ' If(_langWatch.CurrentValue = LanguageEnum.English, stepMap?.EnglishString, stepMap?.SpanishString)
                                           LblAlarm.Text = alrmMap?.Value.GetString(_langWatch.CurrentValue) ' If(_langWatch.CurrentValue = LanguageEnum.English, alrmMap?.EnglishString, alrmMap?.SpanishString)
                                       End Sub
                    If LblStep.InvokeRequired OrElse LblAlarm.InvokeRequired Then
                        Invoke(Sub() updateLabels(alarmPair, stepPair))
                    Else
                        updateLabels(alarmPair, stepPair)
                    End If
                Else
                    _logger.Error("tester is null LoadData() @ViewCalibration:: ")
                End If
            Catch ex As NullReferenceException
                _msgsvc.PublishNewAlarm("NullReferenceException LoadData() @ViewCalibration", ErrorLevel.Error, 2)
                _logger.Error("NullReferenceException LoadData() @ViewCalibration:: " + ex.ToString())
            End Try
        End Sub

        Private Sub LoadData(data As Udt_tester)
            _tester = data
            RunningTask = Task.Factory.StartNew(AddressOf SetUi)

        End Sub

#Region "set nest mode status"

        Private Sub SetNestToAuto(nid As Integer)
            SelectedNestId = 0
            RaiseSaved($"{NestAddress(nid)}.ModeRequest", NestModeStatus.Auto)
        End Sub

        Private Sub NewUser(user As User)

            If InvokeRequired Then
                Invoke(Sub() NewUser(user))
                Return
            End If

            ScreenUnlocked = _isTechOrBetter AndAlso {1, 2}.Contains(SelectedNestId)
            BtnNest1.Enabled = _isTechOrBetter
            BtnNest2.Enabled = _isTechOrBetter
            CalibrationSubUserControl1.NewUser(user)
            Me.Enabled = _userWatch.CheckCurrentUserPermission(AccessLevel.Tech)
        End Sub

        Public Async Function BeginClose() As Task Implements IViewTask.BeginClose
            RemoveHandler _plcrepo.TesterContextChanged, AddressOf LoadData
            RemoveHandler _userWatch.ValueChanged, AddressOf NewUser
            If RunningTask IsNot Nothing Then
                Await RunningTask
            End If
        End Function

#End Region

    End Class

End Namespace