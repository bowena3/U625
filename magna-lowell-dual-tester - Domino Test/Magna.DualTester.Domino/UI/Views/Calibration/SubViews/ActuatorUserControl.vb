Imports Magna.DualTester.Core
Imports Magna.DualTester.Plc.Core

Namespace UI.Views.Calibration.SubViews

    Public Class ActuatorUserControl
        Implements IView(Of ActuatorViewModel)

        Const CargoLamp = "CargoLamp"
        Const CameraItems = "CameraItems"
        Const MirrrorActuator = "MirrrorActuator"
        Const Pfold = "Pfold"

        Const Ec = "EC"
        Const Gi = "Gi"
        Const Oats = "OATS"
        Private vm As ActuatorViewModel
        Private _plc As IPlc
        Public WriteOnly Property SetPlc As IPlc
            Set(value As IPlc)
                _plc = value
            End Set
        End Property

        Private ReadOnly _actuatorButtons As New List(Of Button)

        'Public Sub New()
        '    'MyBase.New(AccessLevel.Operator)
        '    InitializeComponent()
        'End Sub

#Region "Actuator Control"
        Private Sub BtnUp_MouseDown(sender As Object, e As EventArgs) Handles BtnUp.MouseDown, BtnIB.MouseDown, BtnOB.MouseDown, BtnCenter.MouseDown, BtnDown.MouseDown
            Dim val = CInt(DirectCast(sender, Button).Tag)
            WriteData(MirrrorActuator, val) 'up  = 1 'dwn = 2 'ib  = 4 'ob  = 8 'center = 16
        End Sub

        Private Sub BtnUp_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnUp.MouseUp, BtnIB.MouseUp, BtnOB.MouseUp, BtnCenter.MouseUp, BtnDown.MouseUp
            WriteData(MirrrorActuator, 0)
        End Sub

#End Region

#Region "Manual Toggle Options"
        Private Sub BtnDefog_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDefog.MouseClick
            Dim val = If(ChkDefog.Checked, 1, 0)
            If val <> vm.Nest.ManualOps.Defog Then
                WriteData("Defog", If(ChkDefog.Checked, 1, 0))
            End If
        End Sub

        Private Sub BtnTs_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTs.MouseClick
            Dim val = If(ChkTs.Checked, 1, 0)
            If val <> vm.Nest.ManualOps.TurnSignal Then
                WriteData("TurnSignal", val)
            End If
        End Sub

#Region "Pfold"
        Private Sub BtnPFIn_CheckedChanged(sender As Object, e As EventArgs) Handles BtnPfOut.MouseDown, BtnPfIn.MouseDown
            If sender Is BtnPfOut Then
                WriteData(Pfold, 2)
            ElseIf sender Is BtnPfIn Then
                WriteData(Pfold, 1)
            End If
        End Sub

        Private Sub BtnPf_MouseUp(sender As Object, e As EventArgs) Handles BtnPfOut.MouseUp, BtnPfIn.MouseUp
            WriteData(Pfold, 0)
        End Sub
#End Region

        'Private Sub BtnGi_CheckedChanged(sender As Object, e As EventArgs) Handles BtnGi.MouseClick
        '    Dim val = If(BtnGi.Checked, 1, 0)
        '    If BtnGi.Checked Then
        '        BtnGi.ImageIndex = 1
        '    Else
        '        BtnGi.ImageIndex = 0
        '    End If
        '    If val <> Nest.ManualOps.Gi Then
        '        WriteData("Gi", val)
        '    End If
        'End Sub

        Private Sub BtnBzi_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBzi.MouseClick
            Dim val = Math.Abs(CInt(ChkBzi.Checked))
            WriteData("BZI", val)
        End Sub
        Private Sub BtnCameraLed_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGreenLed.MouseClick
            If (vm.Nest.ManualOps.CameraItems And 2) = 0 Then
                WriteData(CameraItems, vm.Nest.ManualOps.CameraItems Or 2)
            Else
                WriteData(CameraItems, vm.Nest.ManualOps.CameraItems And Not 2)
            End If
        End Sub

        Private Sub BtnFlatLight_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFlatLight.MouseClick
            'Dim tmp As Integer = Nest.ManualOps.CameraItems
            'If ((tmp And 1) = 1) <> BtnFlatLight.Checked Then 'if the value does not match the checkbox
            If (vm.Nest.ManualOps.CameraItems And 1) = 0 Then
                WriteData(CameraItems, vm.Nest.ManualOps.CameraItems Or 1)
            Else
                WriteData(CameraItems, vm.Nest.ManualOps.CameraItems And Not 1)
            End If
            'End If
        End Sub

        'Private Sub BtnCheck_MouseClick(sender As Object, e As EventArgs) Handles BtnGroundCheck.MouseClick, BtnMemPower.MouseClick
        '    If sender Is BtnGroundCheck Then
        '        WriteData("GroundCheck", Math.Abs(CInt(BtnGroundCheck.Checked)))
        '    ElseIf sender Is BtnMemPower Then
        '        WriteData("MemoryCr", Math.Abs(CInt(BtnMemPower.Checked)))
        '    End If
        'End Sub


        Private Sub WriteData(itemName As String, data As Object)
            Debug.Print(itemName + " " + data.ToString)
            _plc.ManualWrite(New SaveEventArgs(PlcConstants.TesterAddress + $".Nest{vm.NestId}.ManualOps.{itemName}", data))
        End Sub


#End Region
        Private Sub OnChkClick(sender As Object, e As EventArgs) Handles ChkCargoLamp.MouseClick, ChkEc.MouseClick, ChkGi.MouseClick, ChkOats.MouseClick
            If sender Is ChkCargoLamp Then
                If (vm.Nest.ManualOps.CargoLamp And 1) = 0 Then
                    WriteData(CargoLamp, vm.Nest.ManualOps.CargoLamp Or 1)
                Else
                    WriteData(CargoLamp, vm.Nest.ManualOps.CargoLamp And Not 1)
                End If
            ElseIf sender Is ChkEc Then
                If (vm.Nest.ManualOps.Ec And 1) = 0 Then
                    WriteData(Ec, vm.Nest.ManualOps.Ec Or 1)
                Else
                    WriteData(Ec, vm.Nest.ManualOps.Ec And Not 1)
                End If

            ElseIf sender Is ChkGi Then
                If (vm.Nest.ManualOps.Gi And 1) = 0 Then
                    WriteData(Gi, vm.Nest.ManualOps.Gi Or 1)
                Else
                    WriteData(Gi, vm.Nest.ManualOps.Gi And Not 1)
                End If

            ElseIf sender Is ChkOats Then
                If (vm.Nest.ManualOps.Oats And 1) = 0 Then
                    WriteData(Oats, vm.Nest.ManualOps.Oats Or 1)
                Else
                    WriteData(Oats, vm.Nest.ManualOps.Oats And Not 1)
                End If
            Else
                Throw New NotImplementedException("This button is not being handled")
            End If

        End Sub



        Private Sub ActuatorUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            _actuatorButtons.Add(BtnUp)          '0
            _actuatorButtons.Add(BtnDown)        '1
            _actuatorButtons.Add(BtnIB)          '2
            _actuatorButtons.Add(BtnOB)          '3
            _actuatorButtons.Add(BtnCenter)      '4
        End Sub
        Public Sub UpdateViewModel(data As ActuatorViewModel) Implements IView(Of ActuatorViewModel).UpdateViewModel
            vm = data

            With vm.Nest.ManualOps
                ChkDefog.Checked = CBool(.Defog And 1)
                ChkTs.Checked = CBool(.TurnSignal And 1)
                ChkBzi.Checked = CBool(.BZI And 1)
                ChkGreenLed.Checked = CBool(.CameraItems And 2)
                ChkFlatLight.Checked = CBool(.CameraItems And 1)

                ChkCargoLamp.Checked = CBool(.CargoLamp And 1)
                ChkEc.Checked = CBool(.Ec And 1)
                ChkGi.Checked = CBool(.Gi And 1)
                ChkOats.Checked = CBool(.Oats And 1)
            End With

            ChkDefog.BackColor = If(ChkDefog.Checked, Color.Green, SystemColors.Control)
            ChkTs.BackColor = If(ChkTs.Checked, Color.Green, SystemColors.Control)
            ChkBzi.BackColor = If(ChkBzi.Checked, Color.Green, SystemColors.Control)
            ChkGreenLed.BackColor = If(ChkGreenLed.Checked, Color.Green, SystemColors.Control)
            ChkFlatLight.BackColor = If(ChkFlatLight.Checked, Color.Green, SystemColors.Control)
            ChkCargoLamp.BackColor = If(ChkCargoLamp.Checked, Color.Green, SystemColors.Control)
            ChkEc.BackColor = If(ChkEc.Checked, Color.Green, SystemColors.Control)
            ChkGi.BackColor = If(ChkGi.Checked, Color.Green, SystemColors.Control)
            ChkOats.BackColor = If(ChkOats.Checked, Color.Green, SystemColors.Control)
            'End If
        End Sub
    End Class
End Namespace