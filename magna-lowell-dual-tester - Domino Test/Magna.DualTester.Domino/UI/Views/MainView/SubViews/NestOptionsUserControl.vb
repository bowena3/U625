Imports Magna.DualTester.Core

Namespace UI.Views.MainView.SubViews

    Public Class NestOptionsUserControl
        Implements IView(Of NestDataControlViewModel)

        'ReadOnly ModeRequest As String = TesterAddress + ".Nest{0}.ModeRequest"
        ReadOnly Property ModeRequestAddress As String
            Get
                Return $"{PlcConstants.TesterAddress}.Nest{vm.NestId}.ModeRequest"
            End Get
        End Property

        'Private _nest As Udt_Nest
        'Public Property NestId As Integer 'Implements INestDataControl.NestId

        Private _modeStatus As Integer

        Private _plc As IPlc

        Public WriteOnly Property SetPlc As IPlc
            Set(value As IPlc)
                _plc = value
            End Set
        End Property

        Dim vm As NestDataControlViewModel

        Public Sub UpdateViewModel(data As NestDataControlViewModel) Implements IView(Of NestDataControlViewModel).UpdateViewModel
            vm = data
            If vm.NestId < 1 Then
                Throw New Exception("Nest id not set")
            End If
            ModeStatus = vm.ModeStatus
        End Sub

        Private Property ModeStatus As Integer
            Get
                Return _modeStatus
            End Get
            Set(value As Integer)
                Dim run = Sub()

                              _modeStatus = value
                              BtnAuto.BackColor = SystemColors.Control
                              LblInCycle.Text = String.Empty

                              Select Case _modeStatus
                                  Case NestModeStatus.Auto 'auto mode
                                      BtnAuto.BackColor = Color.LimeGreen
                                      LblInCycle.Text = "Auto"
                                  Case NestModeStatus.Manual 'manual
                                      LblInCycle.Text = "Manual"
                                  Case NestModeStatus.Pokayoke 'py mode
                                      LblInCycle.Text = "PY Mode"
                                  Case NestModeStatus.Incycle And NestModeStatus.Auto
                                      LblInCycle.Text = "Auto Cycle"
                                  Case NestModeStatus.Pokayoke And NestModeStatus.Incycle 'in cycle mode
                                      LblInCycle.Text = "PY Cycle"
                              End Select
                          End Sub
                If Me.InvokeRequired Then
                    Me.BeginInvoke(run)
                    'BUG: Null exception
                Else
                    run()
                End If
            End Set
        End Property

        Public Sub New()
            'MyBase.New(AccessLevel.None)
            InitializeComponent()
        End Sub

        Private Sub BtnAuto_Click(sender As Object, e As EventArgs) Handles BtnAuto.Click
            Me.RaiseSaved(ModeRequestAddress, CObj(NestModeStatus.Auto))
        End Sub

        Private Sub RaiseSaved(address As String, obj As Object)
            _plc.ManualWrite(New SaveEventArgs(address, obj))
        End Sub

    End Class

End Namespace