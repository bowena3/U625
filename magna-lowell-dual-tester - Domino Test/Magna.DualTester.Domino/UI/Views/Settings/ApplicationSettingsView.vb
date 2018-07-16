Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data.Enums

Namespace UI.Views.Settings

    ''' <summary>
    ''' This is a parent user control that holds the <c>ViewShiftSetup</c> and <c>ViewApplicaionParameters</c> in a set of tabs.
    ''' </summary>
    ''' <remarks>This class shouldn't handle any user data it only controls a few user controls.</remarks>
    Public Class ApplicationSettingsView
        Implements IViewTask

        Private ReadOnly _cfg As ICfgDomino
        Private ReadOnly _plc As IPlc
        Private ReadOnly _userWatch As IUserWatch
        Private ReadOnly _msgsvc As IMessageAlertService

        Public Sub New(cfg As ICfgDomino, plc As IPlc, userWatch As IUserWatch, msgsvc As IMessageAlertService)
            MyBase.New()
            _cfg = cfg
            _userWatch = userWatch
            _msgsvc = msgsvc
            _plc = plc
            InitializeComponent()

            NewUser(_userWatch.CurrentValue)
            AddHandler _userWatch.ValueChanged, AddressOf NewUser
        End Sub

        Public Property RunningTask As Task Implements IViewTask.RunningTask

        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            If TabControl1.SelectedTab Is TabAppParams Then
                Dim newcfg = ViewApplicationParameters1.Save()
                _cfg.WriteConfig(newcfg.Cfg)
                _plc.WriteColors(newcfg.Colors)
            ElseIf TabControl1.SelectedTab Is TabShift Then
                Dim newcfg = ShiftSetup1.Save()
                newcfg.CfgSet = True
                _cfg.WriteConfig(newcfg)
                _msgsvc.PublishNewAlarm("Shift Setup Saved", ErrorLevel.Message)
            End If
        End Sub

        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            UpdateViewModels()
            _msgsvc.PublishNewAlarm("Canceled", ErrorLevel.Message)
        End Sub

        Private Async Sub UpdateViewModels()
            Me.Enabled = False
            If RunningTask IsNot Nothing Then
                Await RunningTask
            End If
            RunningTask = Task.Factory.StartNew(Sub()
                                                    ShiftSetup1.UpdateViewModel(New ViewShiftSetupViewModel(_cfg.ReadConfig()))
                                                    ViewApplicationParameters1.UpdateViewModel(New ViewApplicationParametersViewModel(_plc.Colors, _cfg.ReadConfig()))
                                                End Sub)
            Await RunningTask
            Me.Enabled = True
        End Sub

        Private Sub NewUser(user As User)

            Dim cfg = _cfg.ReadConfig()
            Dim cantlogin = Not cfg.CfgSet OrElse String.IsNullOrEmpty(cfg.DevicePlcIp) 'OrElse (String.IsNullOrEmpty(cfg.DeviceBarcodeScannerPort))

            Dim isAdmin = _userWatch.CheckCurrentUserPermission(AccessLevel.Admin)

            Me.Enabled = If(cantlogin, True, isAdmin)
            ShiftSetup1.Enabled = If(cantlogin, True, isAdmin)
            ViewApplicationParameters1.Enabled = If(cantlogin, False, isAdmin)
        End Sub

        Public Async Function BeginClose() As Task Implements IViewTask.BeginClose
            RemoveHandler _userWatch.ValueChanged, AddressOf NewUser
            If RunningTask IsNot Nothing Then
                Await RunningTask
            End If
        End Function

        Private Sub IViewTask_Load() Implements IViewTask.Load
            UpdateViewModels()
        End Sub

    End Class

End Namespace