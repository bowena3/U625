Imports Magna.DualTester.Core

Namespace UI.Views.Settings.SubViews

    Public Class ViewApplicationParameters
        Implements IView(Of ViewApplicationParametersViewModel)
        Implements ISaveView(Of ViewApplicationParametersViewModel)

        Public Sub New()
            'MyBase.New(AccessLevel.Engineer)
            InitializeComponent()
        End Sub

        Public Function Save() As ViewApplicationParametersViewModel Implements ISaveView(Of ViewApplicationParametersViewModel).Save
            Return New ViewApplicationParametersViewModel(_vm.Colors, _vm.Cfg)
        End Function

        Private _vm As ViewApplicationParametersViewModel

        Public Sub UpdateViewModel(data As ViewApplicationParametersViewModel) Implements IView(Of ViewApplicationParametersViewModel).UpdateViewModel
            If InvokeRequired Then
                Invoke(Sub() UpdateViewModel(data))
                Return
            End If
            _vm = data
            AlarmBindingSource.DataSource = _vm.Cfg.MachineAlarms
            PartFaultBindingSource.DataSource = _vm.Cfg.PartAlarms
            SequeceBindingSource.DataSource = _vm.Cfg.SequenceStrings
            ColorModelBindingSource.DataSource = _vm?.Colors?.Data

            AlarmBindingSource.ResetBindings(True)
            PartFaultBindingSource.ResetBindings(True)
            SequeceBindingSource.ResetBindings(True)
            ColorModelBindingSource.ResetBindings(True)
        End Sub

    End Class

End Namespace