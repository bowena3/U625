Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data.Enums
Imports Magna.DualTester.Domino.TesterApi
Imports Magna.DualTester.Domino.UI.Views.Calibration
Imports Magna.DualTester.Domino.UI.Views.MainView
Imports Magna.DualTester.Domino.UI.Views.Setpoints
Imports Magna.DualTester.Domino.UI.Views.Settings
Imports Ninject
Imports NLog

Public Class Form1
    Public Shared StartArg As String = ""

    Const PrnFile = "PartLabel.prn"
    Private Property _errorDisplayTime As Integer = 1000
    Private Property _errorTimeCount As Integer = 0
    Private Property _currentAlarmColor As Color
    Private Property _currentmessage As EventErrorArgs
    Private ReadOnly _logger As NLog.Logger = LogManager.GetCurrentClassLogger()
    'Private ReadOnly _msgwait As New AutoResetEvent(False)

    Private ReadOnly kernel As IKernel
    Private ReadOnly _cfg As ICfgDomino
    Private ReadOnly _plc As IPlc
    Private ReadOnly _plcrepo As IPlcFullRepo
    Private ReadOnly _uWatch As IUserWatch
    Private ReadOnly _lWatch As ILanguageWatch
    Private ReadOnly _messageAlert As IMessageAlertService

    Private ReadOnly _barcodeService As BarcodeService
    'Private Property _barcodeScanner As BarCodeScanner

    'expendable - yellow
    'returnable - green
    'service
    Private ReadOnly _cheatlogin() As Keys = {Keys.Up, Keys.Up, Keys.Down, Keys.Down, Keys.ControlKey, Keys.Enter}
    Private ReadOnly _cheatlogin1() As Keys = {Keys.Alt, Keys.C}

    Private _cheatIndex As Integer = 0
    Private Property CurrentView As UserControl

    Private ReadOnly Property CurrentViewTask As IViewTask
        Get
            Return TryCast(CurrentView, IViewTask)
        End Get
    End Property

    Private ReadOnly Property Cfg() As DominoCfg
        Get
            Return _cfg.ReadConfig()
        End Get
    End Property

    Public Sub New()
        kernel = New Ninject.StandardKernel(New Bindings())
        _cfg = kernel.Get(Of ICfgDomino)
        _plc = kernel.Get(Of IPlc)
        _plcrepo = kernel.Get(Of IPlcFullRepo)
        _uWatch = kernel.Get(Of IUserWatch)
        _lWatch = kernel.Get(Of ILanguageWatch)
        _messageAlert = kernel.Get(Of IMessageAlertService)

        InitializeComponent()
        Dim _dig = kernel.Get(Of LoadingDialog)
        '        _dig.Show(Me)
    End Sub

    Private Async Sub ChangeViews(Of T As {UserControl, IViewTask})(Optional forceuser As Boolean = False)
        TableLayoutPanel1.Enabled = False
        If CurrentView?.GetType() = GetType(ViewCalibration) Then
            _plc.ManualWrite(New SaveEventArgs(PlcConstants.TesterAddress + ".Nest1.ModeRequest", NestModeStatus.Auto))
            _plc.ManualWrite(New SaveEventArgs(PlcConstants.TesterAddress + ".Nest2.ModeRequest", NestModeStatus.Auto))
        End If

        If CurrentViewTask IsNot Nothing Then
            Await CurrentViewTask?.BeginClose()
            If CurrentViewTask?.RunningTask IsNot Nothing Then
                Await CurrentViewTask.RunningTask
            End If
        End If

        If CurrentView?.GetType() IsNot GetType(T) Then
            MainPanel.SuspendLayout()
            MainPanel.Controls.Clear()

            If CurrentView IsNot Nothing Then
                Me.CurrentView.Dispose()
                Me.CurrentView = Nothing
            End If
            Dim newview = kernel.Get(Of T)
            CurrentView = newview
            CurrentViewTask.Load()
            newview.Dock = DockStyle.Fill
            MainPanel.Controls.Add(CType(CurrentView, Control))
            MainPanel.ResumeLayout()
            If CurrentViewTask?.RunningTask IsNot Nothing Then
                Await CurrentViewTask.RunningTask
            End If
        End If
        TableLayoutPanel1.Enabled = True
    End Sub

    Private Sub UserChanged(user As User)
        Dim run = Sub(usr As User)
                      Dim usrNothing = user Is Nothing
                      TxtUser.Text = If(usrNothing, String.Empty, usr.Username)
                      TxtAccessLvl.Text = If(usrNothing, String.Empty, user.AccessLevel.ToString())
                      'If usr IsNot Nothing Then
                      'Else
                      '    TxtUser.Text = String.Empty
                      '    TxtAccessLvl.Text = String.Empty
                      'End If
                      'DirectCast(CurrentView, IUserControl).NewUser(usr)
                  End Sub
        If Me.InvokeRequired Then Me.BeginInvoke(run, {user}) Else run(user)
    End Sub

    Private Sub OnPlcChange(tester As Udt_tester)
        Dim run = Sub()
                      Dim serviceNest1 As Boolean = tester.Nest1.PartInfo.Service
                      Dim serviceNest2 As Boolean = tester.Nest2.PartInfo.Service
                      BtnServiceNest1.BackColor = If(Not serviceNest1, Color.LimeGreen, Color.Yellow)
                      BtnServiceNest1.Text = If(Not serviceNest1, "Returnable", "Expendable")
                      BtnServiceNest2.BackColor = If(Not serviceNest2, Color.LimeGreen, Color.Yellow)
                      BtnServiceNest2.Text = If(Not serviceNest2, "Returnable", "Expendable")
                  End Sub
        If Me.InvokeRequired Then Me.BeginInvoke(run) Else run()

    End Sub

#Region "Events"

#Region "Btn Click events"

    Private Sub MenuButtons_click(sender As Object, e As EventArgs) Handles BtnReprintPartLabelNest1.Click, BtnReprintPartToteLabel.Click, PrintTestPrintPartLabel.Click

        If sender Is BtnReprintPartLabelNest1 Then
            'If _uWatch.CurrentValue IsNot Nothing AndAlso _uWatch.CurrentValue.AccessLevel >= AccessLevel.Supervisor Then
            '    _printServ.RePrintPartLabel()
            'Else
            '    _messageAlert.PublishNewAlarm("Permissions to low to reprint part label", ErrorLevel.Alert)
            'End If
        ElseIf sender Is BtnReprintPartToteLabel Then
            'If MainFormData.GlobalUser IsNot Nothing AndAlso MainFormData.GlobalUser.AccessLevel >= AccessLevel.Supervisor Then
            '    ReprintToteLabel()
            'Else
            '    MessageAlert.PublishNewAlarm("Permissions to low to reprint tote label", ErrorLevel.Alert)
            'End If
            'ElseIf sender Is PrintTestPrintPartLabel Then
            '    _printServ.PrintPartLabel(True)
        End If

    End Sub

    Private Sub PrintToteLabel()
        '_printServ.PrintToteLabel()
    End Sub

    Private Sub Btn_click(sender As Object, e As EventArgs) Handles BtnReqLabel.Click, BtnSetPoints.Click, BtnAppSettings.Click,
                                                                BtnCalibrate.Click, BtnLogOut.Click, BtnServiceNest2.Click, BtnServiceNest1.Click,
                                                                BtnMain.Click, PrintToolStripMenuItem.Click, BtnDbgLogin.Click
        Dim btn As Button = TryCast(sender, Button)
        If btn Is Nothing OrElse Not btn.Visible Then
            Exit Sub
        End If
        If btn Is BtnReqLabel Then
            If _uWatch.CheckCurrentUserPermission(AccessLevel.Operator) Then
                PrintToteLabel()
            End If
        ElseIf btn Is BtnSetPoints Then
            ChangeViews(Of ViewTesterSetpoints)()
        ElseIf btn Is BtnAppSettings Then
            ChangeViews(Of ApplicationSettingsView)()
        ElseIf btn Is BtnCalibrate Then
            ChangeViews(Of ViewCalibration)()
        ElseIf btn Is BtnLogOut Then
            _uWatch.LogOut()
        ElseIf btn Is BtnMain Then
            ChangeViews(Of ViewMainUserOverView)()
        ElseIf btn Is BtnServiceNest1 Then
            BtnServiceNest1.Enabled = False
            _plc.ManualWrite(PlcConstants.TestApi_PartInfo_Servce, CObj(Not _plcrepo.TesterData.Nest1.PartInfo.Service))
            BtnServiceNest1.Enabled = True
        ElseIf btn Is BtnServiceNest2 Then
            BtnServiceNest2.Enabled = False
            _plc.ManualWrite(PlcConstants.TestApi_PartInfo_Servce, CObj(Not _plcrepo.TesterData.Nest2.PartInfo.Service))
            BtnServiceNest2.Enabled = True
        ElseIf btn Is BtnDbgLogin Then
            '_formData.loginUser("002489A") ' op
            '_formData.loginUser("102626A") ' sup
            '_formData.loginUser("104002A") ' tech
            _uWatch.DebugLogin(New User() With {.AccessLevel = AccessLevel.Admin, .BadgeNumber = 654321, .ClockNumber = 123456, .Username = "fakename"})
            '_formData.LoginUser("7162") ' eng
            '_formData.loginUser("176823") ' admin
        End If

    End Sub

#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _logger.Debug("Application Start")
        Me.Text += Application.ProductVersion
        AddHandler _messageAlert.NewAlert, AddressOf TryDisplayMessage
        If Cfg Is Nothing Then
            MessageBox.Show("The configuration file is missing or empty.")
        End If
        AddHandler _uWatch.ValueChanged, AddressOf UserChanged
        AddHandler _plcrepo.TesterContextChanged, AddressOf OnPlcChange

        DisplayTimer(Nothing, EventArgs.Empty)
        If StartArg = "-setcfg" Then
            ChangeViews(Of ApplicationSettingsView)(True)
            StartArg = String.Empty
        Else
            ChangeViews(Of ViewMainUserOverView)()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '_closeWindowIsUp = True
        Dim result As DialogResult = MessageBox.Show("Do you wish to close?", "Closing", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            _uWatch.LogOut()
            _plc.Dispose()
        Else
            e.Cancel = True
            '_closeWindowIsUp = False
        End If
    End Sub

    Private Sub DisplayTimer(sender As Object, e As EventArgs) Handles TimerDisplayShift.Tick
        'Dim now = DateTime.Now()
        Dim currentShift As String = "Invalid shift cfg"
        Dim currentShiftInt As Integer = -1

        Dim shift1 As Date
        Dim shift2 As Date
        Dim shift3 As Date

        Dim s1Res = Date.TryParse(Cfg.ShiftSetup1StStart, shift1)
        Dim s2Res = Date.TryParse(Cfg.ShiftSetup2NdStart, shift2)
        Dim s3Res = Date.TryParse(Cfg.ShiftSetup3RdStart, shift3)

        If s1Res AndAlso s2Res AndAlso s3Res Then
            Dim shift1Tod As TimeSpan = shift1.TimeOfDay
            Dim shift2Tod As TimeSpan = shift2.TimeOfDay
            Dim shift3Tod As TimeSpan = shift3.TimeOfDay
            Dim nowTimeOfDay = Date.Now.TimeOfDay
            If nowTimeOfDay < shift1Tod AndAlso nowTimeOfDay >= shift3Tod Then
                currentShiftInt = 3
                currentShift = "3rd"
            ElseIf nowTimeOfDay >= shift1Tod And nowTimeOfDay < shift2Tod Then
                currentShiftInt = 1
                currentShift = "1st"
            ElseIf nowTimeOfDay >= shift2Tod AndAlso nowTimeOfDay < shift3Tod Then
                currentShiftInt = 2
                currentShift = "2nd"
            Else
                currentShiftInt = -1
                currentShift = "ERROR"
            End If
            If _plcrepo.TesterData IsNot Nothing AndAlso _plcrepo.TesterData.ShiftValue <> currentShiftInt Then
                _plc.ManualWrite(PlcConstants.Shift_Value, currentShiftInt)
            End If
        End If
        LblTime.Text = String.Format("{0}{3}{1}{2}{3}", currentShift, vbNewLine, Now.ToString("HH:mm"), vbTab)
    End Sub

    Private Sub Language_CheckedChanged(sender As Object, e As EventArgs) Handles RadEnglish.CheckedChanged, RadSpanish.CheckedChanged
        _lWatch.SetValue = If(RadEnglish.Checked, LanguageEnum.English, LanguageEnum.Spanish)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F8 Then
            PrintToteLabel()
        End If
        If e.Alt AndAlso e.KeyCode = _cheatlogin(_cheatIndex) Then
            _cheatIndex += 1
            If _cheatIndex = _cheatlogin.Length() Then
                Dim dilg = New DialogGetStr()
                If dilg.ShowDialog(Me) = DialogResult.OK Then
                    _uWatch.LogIn(dilg.Value.ToString())
                End If
                _cheatIndex = 0
            End If
        Else
            _cheatIndex = 0
        End If
        If e.Control And e.Alt AndAlso CBool(Keys.C) Then
            _uWatch.LogIn("123456") ' admin quick cheat for tester repair
        End If
    End Sub

#End Region

#Region "Error Display"

    Private Sub TryDisplayMessage()

        If _currentmessage Is Nothing AndAlso Not LabelDim.Enabled AndAlso _messageAlert.Errors.Any() Then
            _currentmessage = _messageAlert.Errors.Dequeue()
            Dim run = Sub()
                          _errorDisplayTime = If(_currentmessage.Seconds >= 1, _currentmessage.Seconds * 1000, 1000)
                          LblError.Text = _currentmessage.Message
                          Dim setColor As Color
                          Select Case _currentmessage.AlertLevel
                              Case ErrorLevel.Alert
                                  setColor = Color.Yellow
                              Case ErrorLevel.Error
                                  setColor = Color.Red
                              Case ErrorLevel.Message
                                  setColor = Color.Green
                          End Select
                          LblError.BackColor = setColor
                          _currentAlarmColor = setColor
                          LabelDim.Start()
                      End Sub
            If Me.InvokeRequired Then Me.BeginInvoke(run) Else run()
        End If
    End Sub

    Private Sub LabelDim_Tick(sender As Object, e As EventArgs) Handles LabelDim.Tick
        _errorTimeCount += LabelDim.Interval

        Dim red = SetColor(SystemColors.Control.R, _currentAlarmColor.R, _errorDisplayTime, _errorTimeCount)
        Dim green = SetColor(SystemColors.Control.G, _currentAlarmColor.G, _errorDisplayTime, _errorTimeCount)
        Dim blue = SetColor(SystemColors.Control.B, _currentAlarmColor.B, _errorDisplayTime, _errorTimeCount)

        LblError.BackColor = Color.FromArgb(255, red, green, blue)
        If _errorTimeCount >= _errorDisplayTime Then
            LblError.BackColor = SystemColors.Control
            LblError.Text = String.Empty
            LabelDim.Stop()
            _errorTimeCount = 0
            _currentmessage = Nothing
            TryDisplayMessage()
        End If
    End Sub

    Private Shared Function SetColor(ToColorChannel As Byte, fromColorChannel As Byte, displayTime As Integer, timeDisplayed As Integer) As Integer
        Dim diff = (CInt(ToColorChannel) - CInt(fromColorChannel))
        Dim diffPerTimeIncrement = (diff / displayTime)
        Dim final As Integer = CInt((diffPerTimeIncrement * timeDisplayed) + fromColorChannel)
        If final > 255 Then
            Debug.Print($"Diff:{diff} , DiffPerTime:{diffPerTimeIncrement}, Final:{final}")
        End If
        Return If(final > 255, 255, final)
    End Function

#End Region

End Class