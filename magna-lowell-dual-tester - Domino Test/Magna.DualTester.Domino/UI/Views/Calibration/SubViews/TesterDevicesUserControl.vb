Imports Magna.DualTester.Core

Namespace UI.Views.Calibration.SubViews

    Public Class TesterDevicesUserControl
        Implements IView(Of TesterDevicesViewModel)

        'Private Const GlassPull As String = "GlassPull"
        Private Const Clamps As String = "Clamps"

        Private Const Pcode As String = "Pcode"
        Private Const ColorCmds As String = "ColorCmds"
        Const Pulltest = "PullTest"
        Const JoyStick = "Joystick"
        Const TrapDoor = "TrapDoorProbe"
        'Private Const Tooling As String = "Tooling"
        'Private Const CameraItems As String = "CameraItems"
        'Private Const MirrrorActuator As String = "MirrrorActuator"

        'Private Property ClampsVal As Integer
        'Private Property GlassPullVal As Integer
        'Private Property ToolingVal As Integer
        'Private Property CameraVal As Integer
        'Private Property ColorVal As Integer

        'Public JoyStick As Integer
        'Public PullTest As Integer
        'Public TrapDoorProbe As Integer

        Private _plc As IPlc

        Public WriteOnly Property SetPlc As IPlc
            Set(value As IPlc)
                _plc = value
            End Set
        End Property

        Public Sub New()
            'MyBase.New(AccessLevel.Operator)
            InitializeComponent()
        End Sub

        Private ReadOnly Property NestAddr As String
            Get
                Return $"{PlcConstants.TesterAddress}.Nest{_data.NestId}"
            End Get
        End Property

        Private Function GetManualAddr(name As String) As String
            Return $"{NestAddr}.ManualOps.{name}"
        End Function

#Region "Other"

        'Private Sub ChkPartVac_MouseClick(sender As Object, e As MouseEventArgs) Handles ChkPartVac.MouseClick
        '    If (_data.ManualOps.Clamps And 32) = 0 Then
        '        WriteData(Clamps, _data.ManualOps.Clamps Or 32)
        '    Else
        '        WriteData(Clamps, _data.ManualOps.Clamps And Not 32)
        '    End If
        'End Sub

        Private Sub Btn_MouseDown(sender As Object, e As EventArgs) Handles BtnNestCls.MouseDown, BtnNestOpen.MouseDown, BtnGi.MouseDown
            If sender Is BtnNestOpen Then
                RaiseSaved(GetManualAddr("Clamps"), (_data.ManualOps.Clamps Or 2))
            ElseIf sender Is BtnNestCls Then
                RaiseSaved(GetManualAddr("Clamps"), (_data.ManualOps.Clamps Or 1))
            ElseIf sender Is BtnGi Then
                RaiseSaved(GetManualAddr("Gi"), (_data.ManualOps.Gi Or 2))

            End If
        End Sub

        Private Sub Btn_MouseUp(sender As Object, e As EventArgs) Handles BtnNestCls.MouseUp, BtnNestOpen.MouseUp, BtnGi.MouseUp
            If sender Is BtnNestOpen Then
                RaiseSaved(GetManualAddr("Clamps"), (_data.ManualOps.Clamps And Not 2))
            ElseIf sender Is BtnNestCls Then
                RaiseSaved(GetManualAddr("Clamps"), (_data.ManualOps.Clamps And Not 1))
            ElseIf sender Is BtnGi Then
                RaiseSaved(GetManualAddr("Gi"), (_data.ManualOps.Gi And Not 2))
            End If
        End Sub

        Private Sub BtnOther_MouseDown(sender As Object, e As EventArgs) Handles BtnColorTriggerSample.MouseDown
            RaiseSaved(GetManualAddr(ColorCmds), (_data.ManualOps.ColorCmds Or 1))
        End Sub

        Private Sub BtnOther_MouseUp(sender As Object, e As EventArgs) Handles BtnColorTriggerSample.MouseUp
            RaiseSaved(GetManualAddr(ColorCmds), (_data.ManualOps.ColorCmds And Not 1))
        End Sub

        'Private Sub BtnColorTriggerGalaxy_Click(sender As Object, e As EventArgs)
        '    'Set pcode in manual ops
        '    'Set target color in nest
        '    'Dim dialog As DialogColorSelector = New DialogColorSelector(_data.Colors)
        '    dialog.ShowDialog(Me)
        '    If dialog.DialogResult = DialogResult.OK Then
        '        RaiseSaved(GetManualAddr(Pcode), dialog.SelectedColor.Pcode)
        '        Me.RaiseSaved($"{NestAddr}.TargetColor", dialog.SelectedColorIndex)
        '    End If

        'End Sub

#End Region

#Region "Pull Test"

        Private Sub ChkGlassVacuum_CheckedChanged_1(sender As Object, e As EventArgs) Handles ChkGlassVacuum.CheckedChanged
            ChkGlassVacuum.Text = If(ChkGlassVacuum.Checked, "ON", "OFF")
        End Sub

        Private Sub ChkGlassVacuum_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGlassVacuum.MouseClick
            If ChkGlassVacuum.Checked Then
                RaiseSaved(GetManualAddr(Pulltest), _data.ManualOps.PullTest Or 64)
            Else
                RaiseSaved(GetManualAddr(Pulltest), _data.ManualOps.PullTest And Not 64)
            End If
        End Sub

        Private Sub PullTest_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnRotateIn.MouseDown, BtnRotateOut.MouseDown,
                                                                                       BtnVacCylDown.MouseDown, BtnVacCylUp.MouseDown,
                                                                                       BtnClampDown.MouseDown, BtnClampUp.MouseDown
            If sender Is BtnRotateIn Then
                RaiseSaved(GetManualAddr(Pulltest), _data.ManualOps.PullTest Or 1)
            ElseIf sender Is BtnRotateOut Then
                RaiseSaved(GetManualAddr(Pulltest), _data.ManualOps.PullTest Or 2)
            ElseIf sender Is BtnVacCylDown Then
                RaiseSaved(GetManualAddr(Pulltest), _data.ManualOps.PullTest Or 4)
            ElseIf sender Is BtnVacCylUp Then
                RaiseSaved(GetManualAddr(Pulltest), _data.ManualOps.PullTest Or 8)
            ElseIf sender Is BtnClampDown Then
                RaiseSaved(GetManualAddr(Pulltest), _data.ManualOps.PullTest Or 16)
            ElseIf sender Is BtnClampUp Then
                RaiseSaved(GetManualAddr(Pulltest), _data.ManualOps.PullTest Or 32)
            End If
        End Sub

        Private Sub PullTest_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnRotateIn.MouseUp, BtnRotateOut.MouseUp,
                                                                                     BtnVacCylDown.MouseUp, BtnVacCylUp.MouseUp,
                                                                                     BtnClampDown.MouseUp, BtnClampUp.MouseUp
            If sender Is BtnRotateIn Then
                RaiseSaved(GetManualAddr(Pulltest), _data.ManualOps.PullTest And Not 1)
            ElseIf sender Is BtnRotateOut Then
                RaiseSaved(GetManualAddr(Pulltest), _data.ManualOps.PullTest And Not 2)
            ElseIf sender Is BtnVacCylDown Then
                RaiseSaved(GetManualAddr(Pulltest), _data.ManualOps.PullTest And Not 4)
            ElseIf sender Is BtnVacCylUp Then
                RaiseSaved(GetManualAddr(Pulltest), _data.ManualOps.PullTest And Not 8)
            ElseIf sender Is BtnClampDown Then
                RaiseSaved(GetManualAddr(Pulltest), _data.ManualOps.PullTest And Not 16)
            ElseIf sender Is BtnClampUp Then
                RaiseSaved(GetManualAddr(Pulltest), _data.ManualOps.PullTest And Not 32)
            End If
        End Sub

#End Region

#Region "Joy Stick"

        Private Sub BtnJoyStickExtend_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnJoyStickExtend.MouseDown
            RaiseSaved(GetManualAddr(JoyStick), _data.ManualOps.JoyStick Or 1)
        End Sub

        Private Sub BtnJoyStickExtend_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnJoyStickExtend.MouseUp
            RaiseSaved(GetManualAddr(JoyStick), _data.ManualOps.JoyStick And Not 1)
        End Sub

#End Region

#Region "TrapDoor"

        Private Sub BtnTrapDoorExtend_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnTrapDoorExtend.MouseDown
            RaiseSaved(GetManualAddr(TrapDoor), _data.ManualOps.TrapDoorProbe Or 1)
        End Sub

        Private Sub BtnTrapDoorExtend_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnTrapDoorExtend.MouseUp
            RaiseSaved(GetManualAddr(TrapDoor), _data.ManualOps.TrapDoorProbe And Not 1)
        End Sub

#End Region

        Private Sub RaiseSaved(address As String, obj As Object, Optional msg As String = "")
            _plc.ManualWrite(New SaveEventArgs(address, obj, message:=msg))
        End Sub

        Private Sub ChkGlassVacuum_CheckedChanged(sender As Object, e As MouseEventArgs) Handles ChkGlassVacuum.MouseClick
        End Sub

        Private Sub BtnOther_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnColorTriggerSample.MouseDown

        End Sub

        Private Sub BtnOther_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnColorTriggerSample.MouseUp

        End Sub

        Private Property _data As TesterDevicesViewModel

        Public Sub UpdateViewModel(data As TesterDevicesViewModel) Implements IView(Of TesterDevicesViewModel).UpdateViewModel
            _data = data
            'Me.NestId = _data.NestId
            If _data.NestId < 1 Then
                Throw New Exception("NestId not set")
            End If
            'Me.Nest = obj 'If(NestId = 1, obj.Nest1, obj.Nest2)
            ChkGlassVacuum.Checked = CBool((data.ManualOps.PullTest And 64))
            ' ChkPartVac.Checked = CBool(_data.ManualOps.Clamps And 32)
            BtnColorTriggerGalaxy.Text = data.TargetColor.Value 'MainFormData.Colors.Data(_data.TargetColor).Name.ToString()
        End Sub


    End Class

End Namespace