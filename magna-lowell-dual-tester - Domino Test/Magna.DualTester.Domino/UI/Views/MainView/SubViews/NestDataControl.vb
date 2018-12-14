Imports System.Reflection
Imports System.Text
Imports Magna.DualTester.Core
Imports Magna.DualTester.Domino.TesterApi

Namespace UI.Views.MainView.SubViews

    Public Class NestDataControl
        Implements IView(Of NestDataControlViewModel)

        Dim vm As NestDataControlViewModel
        Private Const DetectedColorString As String = "Detected Color: {0}"
        Private Const TargetColorString As String = "TargetColor: {0}"
        Const colGroups = 3

        Public WriteOnly Property SetPlc As IPlc
            Set(value As IPlc)
                NestOptionsUserControl1.SetPlc = value
            End Set
        End Property

        Private ReadOnly NameColumns As Integer() = {1, 5, 9, 13}
        Private ReadOnly SpacerColumns As Integer() = {4, 8, 12}
        Private ReadOnly DataTypeColumns As Integer() = {3, 7, 11, 15}
        Private ReadOnly ValueColumns As Integer() = {2, 6, 10, 14}
        Private ReadOnly ValueRows As Integer() = {1, 2, 3, 4}

        Private ReadOnly CellMaps As New Dictionary(Of String, LogItemCellMap)

        Private _msgsvc As IMessageAlertService

        Public Sub New()
            InitializeComponent()
        End Sub

        Public WriteOnly Property SetMessageService As IMessageAlertService
            Set(value As IMessageAlertService)
                _msgsvc = value
            End Set
        End Property

        Private Sub NestDataControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.SuspendLayout()
            '*********************************************Setting up the left side**********************************************
            Dim rows = GridOptionsTesting.Rows - 1
            For x = 0 To colGroups - 1
                Dim baseIndex = 4 * x
                Dim titleColIdx = baseIndex + 1
                Dim valueColIdx = baseIndex + 2
                Dim typeColIdx = baseIndex + 3
                Dim spacerColIdx = baseIndex + 4
                Dim titleCol = GridOptionsTesting.Column(titleColIdx)
                Dim valueCol = GridOptionsTesting.Column(valueColIdx)
                Dim typeCol = GridOptionsTesting.Column(typeColIdx)
                Dim spaceCol = GridOptionsTesting.Column(spacerColIdx)

                titleCol.Locked = True
                valueCol.Locked = True
                typeCol.Locked = True
                spaceCol.Locked = True

                typeCol.DecimalLength = 3
                typeCol.Mask = FlexCell.MaskEnum.Numeric

                titleCol.Alignment = FlexCell.AlignmentEnum.RightGeneral
                valueCol.Alignment = FlexCell.AlignmentEnum.CenterGeneral
                typeCol.Alignment = FlexCell.AlignmentEnum.LeftGeneral

                Dim valSelection = GridOptionsTesting.Range(0, valueColIdx, rows, valueColIdx)
                Dim spacerSelection = GridOptionsTesting.Range(0, spacerColIdx, rows, spacerColIdx)
                spacerSelection.BackColor = Color.DarkSlateGray
                valSelection.Borders(FlexCell.EdgeEnum.Inside Or FlexCell.EdgeEnum.Outside) = FlexCell.LineStyleEnum.Thin
                valSelection.BackColor = Color.Black
                valSelection.ForeColor = Color.Yellow
            Next
            GridOptionsTesting.Row(0).Height = 0
            GridOptionsTesting.Column(0).Width = 0

            Dim fieldinfos = GetType(Udt_Logvalues).GetFields()
            Dim defog = fieldinfos.Single(Function(x) x.Name = "Defog")
            Dim Ts_Amp = fieldinfos.Single(Function(x) x.Name.Contains("Ts_Amp"))
            Dim Gi_Amp = fieldinfos.Single(Function(x) x.Name.Contains("Gi_Amp"))
            Dim LogoLamp_Amp = fieldinfos.Single(Function(x) x.Name.Contains("LogoLamp_Amp"))
            Dim BZI_Amp = fieldinfos.Single(Function(x) x.Name.Contains("Bzi_Amp"))
            Dim EC_Amp = fieldinfos.Single(Function(x) x.Name.Contains("Ec_Amp"))
            Dim Pf_Amp = fieldinfos.Single(Function(x) x.Name.Contains("Pf_Amp"))
            Dim Pf_Trav_Time = fieldinfos.Single(Function(x) x.Name.Contains("Pf_Trav_Time"))
            'Dim CargoLamp_Amp = fieldinfos.Single(Function(x) x.Name.Contains("CargoLamp_Amp"))
            'Dim PowerExt_Amp = fieldinfos.Single(Function(x) x.Name.Contains("PowerExt_Amp"))
            Dim PrevCycle = fieldinfos.Single(Function(x) x.Name.Contains("Prev_Cycle"))
            Dim CurCycle = fieldinfos.Single(Function(x) x.Name.Contains("Cur_Cycle"))
            Dim Police = fieldinfos.Single(Function(x) x.Name.Equals("Police_Wire"))
            'Dim Pol_Sync = fieldinfos.Single(Function(x) x.Name.Equals("Pol_Sync"))
            CellMaps.Add(defog.Name, New LogItemCellMap("Defog", defog, UnitType.Amps, GridOptionsTesting.Cell(1, 2)))
            CellMaps.Add(Ts_Amp.Name, New LogItemCellMap("Turn Signal", Ts_Amp, UnitType.Amps, GridOptionsTesting.Cell(2, 2)))
            CellMaps.Add(Gi_Amp.Name, New LogItemCellMap("GI", Gi_Amp, UnitType.Amps, GridOptionsTesting.Cell(3, 2)))
            CellMaps.Add(LogoLamp_Amp.Name, New LogItemCellMap("Logo Lamp", LogoLamp_Amp, UnitType.Amps, GridOptionsTesting.Cell(4, 2)))
            CellMaps.Add(BZI_Amp.Name, New LogItemCellMap("BZI", BZI_Amp, UnitType.Amps, GridOptionsTesting.Cell(1, 6)))
            CellMaps.Add(EC_Amp.Name, New LogItemCellMap("EC", EC_Amp, UnitType.Amps, GridOptionsTesting.Cell(2, 6)))
            CellMaps.Add(Pf_Amp.Name, New LogItemCellMap("Power Fold", Pf_Amp, UnitType.Amps, GridOptionsTesting.Cell(3, 6)))
            CellMaps.Add(Pf_Trav_Time.Name, New LogItemCellMap("Power Fold", Pf_Trav_Time, UnitType.Seconds, GridOptionsTesting.Cell(4, 6)))
            CellMaps.Add(Police.Name, New LogItemCellMap("Police Wire", Police, UnitType.Volts, GridOptionsTesting.Cell(1, 10)))
            'CellMaps.Add(Pol_Sync.Name, New LogItemCellMap("Police Sync", Police, UnitType.Volts, GridOptionsTesting.Cell(2, 10)))
            'CellMaps.Add(CargoLamp_Amp.Name, New LogItemCellMap("Cargo Lamp", CargoLamp_Amp, UnitType.Amps, GridOptionsTesting.Cell(1, 10)))
            'CellMaps.Add(PowerExt_Amp.Name, New LogItemCellMap("Power Extend", PowerExt_Amp, UnitType.Amps, GridOptionsTesting.Cell(3, 10)))
            CellMaps.Add(CurCycle.Name, New LogItemCellMap("Current Cycle", CurCycle, UnitType.Seconds, GridOptionsTesting.Cell(3, 10)))
            CellMaps.Add(PrevCycle.Name, New LogItemCellMap("Previous Cycle", PrevCycle, UnitType.Seconds, GridOptionsTesting.Cell(4, 10)))
            '****************************************************************************************************************
            ResizeGrid()
            Me.ResumeLayout()
        End Sub

        Private Sub NestDataControl_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
            ResizeGrid()
        End Sub

        Private Sub ResizeGrid()
            GridOptionsTesting.SuspendLayout()
            GridOptionsTesting.Cols = (4 * colGroups) + 1
            Dim rows = GridOptionsTesting.Rows - 1
            Dim colGroupWidth = (GridOptionsTesting.Width - (colGroups - 1) - 4) / colGroups
            For x = 0 To colGroups - 1
                Dim baseIndex = 4 * x
                Dim titleColIdx = baseIndex + 1
                Dim valueColIdx = baseIndex + 2
                Dim typeColIdx = baseIndex + 3
                Dim spacerColIdx = baseIndex + 4
                'Debug.Print($"titleCol:{titleCol}, valueCol:{valueCol}, valTypeCol:{valTypeCol}, spacerCol:{spacerCol}")

                Const div = 3.0
                Dim colWidth = CShort(colGroupWidth / div)
                GridOptionsTesting.Column(titleColIdx).Width = colWidth   'Title
                GridOptionsTesting.Column(valueColIdx).Width = colWidth   'value
                GridOptionsTesting.Column(typeColIdx).Width = colWidth    'val type
                GridOptionsTesting.Column(spacerColIdx).Width = CShort(If(x = (colGroups - 1), 0, 1))      'spacer
            Next
            GridOptionsTesting.Row(0).Height = 0
            GridOptionsTesting.Column(0).Width = 0
            GridOptionsTesting.ResumeLayout()
        End Sub

        Private Sub SetAlarms(nest As NestDataControlViewModel)
            If InvokeRequired Then
                Me.Invoke(Sub() SetAlarms(nest))
                Exit Sub
            End If

            Dim fontSize As Single = 8.0!
            Dim fontColor As Color = Color.Red
            Dim alrmMsg As String = String.Empty
            Select Case (nest.LogItems.ResultCode)
                Case >= 3
                    Dim alrmstring As New StringBuilder()
                    Dim count As Integer = 0
                    For Each item In nest.LogItems.FltBits
                        If item Then
                            Dim found = nest.PartAlarms.Single(Function(x) x.Index = count)
                            alrmstring.Append(found.Value.GetString(nest.Language))
                            alrmstring.Append(vbNewLine)
                        End If
                        count += 1
                    Next
                    alrmMsg = alrmstring.ToString()
                Case 2
                    fontSize = 48.0!
                    alrmMsg = "Passed"
                    fontColor = Color.Lime
            End Select
            TxtMessage.Font = New Font("Microsoft Sans Serif", fontSize, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            TxtMessage.ForeColor = fontColor
            TxtMessage.Text = alrmMsg

            TxtAlarm.ForeColor = If(nest.AlarmVal.Index = 0, Color.LimeGreen, Color.Red)

            Dim alarmState = String.IsNullOrWhiteSpace(nest.AlarmVal.Value) OrElse nest.AlarmVal.IndexOutOfRange
            Dim stepState = String.IsNullOrWhiteSpace(nest.SeqVal.Value) OrElse nest.SeqVal.IndexOutOfRange

            TxtAlarm.Text = If(alarmState, $"Alram {nest.AlarmVal.Index} not set", nest.AlarmVal.Value)
            TxtStep.Text = If(stepState, $"Step {nest.SeqVal.Index} not set", nest.SeqVal.Value)

            Dim detectedColor = nest.DetectedColor
            Dim targetColor = nest.TargetColor
            Dim colorDifferent = Not detectedColor.Equals(targetColor) 'AndAlso detectedColor.Index > 0 AndAlso targetColor.Index > 0
            LblDetectedColor.BackColor = If(colorDifferent, Color.Red, SystemColors.Control)

            If detectedColor.IndexOutOfRange Then
                _msgsvc.PublishNewAlarm("Detected Color out of range see ADMIN", ErrorLevel.Error)
            End If

            If targetColor.IndexOutOfRange Then
                _msgsvc.PublishNewAlarm("Target Color out of range see ADMIN", ErrorLevel.Error)
            End If

            LblTargetColor.Text = $"TargetColor: {targetColor.Value}"
            LblDetectedColor.Text = $"Detected Color: {detectedColor.Value}"
        End Sub

        Public Sub UpdateViewModel(data As NestDataControlViewModel) Implements IView(Of NestDataControlViewModel).UpdateViewModel
            If InvokeRequired Then
                Invoke(Sub() UpdateViewModel(data))
                Return
            End If

            vm = data
            If vm.NestId < 1 Then
                Throw New Exception("Nestid not set")
            End If

            NestPartOptions1.UpdateViewModel(data)
            NestOptionsUserControl1.UpdateViewModel(data)

            With data.LogItems
                Dim mirrorMotions = New List(Of MirrorMotionItem) From {
                    New MirrorMotionItem(MirrorDirection.Up, .MirrorMemAtUp, .MirrorUpAmp, .MirrorUpTravel, .MirrorUpRate),
                    New MirrorMotionItem(MirrorDirection.Down, .MirrorMemAtDwn, .MirrorDwnAmp, .MirrorDwnTravel, .MirrorDwnRate),
                    New MirrorMotionItem(MirrorDirection.InBoard, .MirrorMemAtInBoard, .MirrorInBoardAmp, .MirrorInBoardTravel, .MirrorInBoardRate),
                    New MirrorMotionItem(MirrorDirection.OutBoard, .MirrorMemAtOutBoard, .MirrorOutBoardAmp, .MirrorOutBoardTravel, .MirrorOutBoardRate)
                    }
                MirrorMotionItemBindingSource.DataSource = mirrorMotions
                MirrorMotionItemBindingSource.ResetBindings(False)
            End With

            Dim fieldinfos = GetType(Udt_Logvalues).GetFields()
            For Each f In fieldinfos
                If CellMaps.ContainsKey(f.Name) Then
                    Dim map = CellMaps(f.Name)
                    Dim val = DirectCast(f.GetValue(data.LogItems), Udt_LogItem)
                    map.Cell.Text = val.Value.ToString()
                    GridOptionsTesting.Cell(map.Cell.Row, map.Cell.Col - 1).Text = map.Title
                    GridOptionsTesting.Cell(map.Cell.Row, map.Cell.Col + 1).Text = map.UnitType.ToString()
                End If
            Next
            SetAlarms(data)
        End Sub

    End Class

    Friend Class LogItemCellMap

        Public Sub New(title As String, field As FieldInfo, unit As UnitType, cell As FlexCell.Cell)
            Me.Title = title
            Me.FieldInfo = field
            Me.UnitType = unit
            Me.Cell = cell
        End Sub

        Public Property Title As String
        Public Property FieldInfo As FieldInfo
        Public Property UnitType As UnitType
        Public Property Cell As FlexCell.Cell

    End Class

    Public Enum UnitType
        Undefined
        Amps
        Seconds
        Volts
    End Enum

    Public Class MirrorMotionItem

        Public Sub New()

        End Sub

        Public Sub New(title As MirrorDirection, mem As Udt_LogItem, amp As Udt_LogItem, travel As Udt_LogItem, rate As Udt_LogItem)
            Me.Title = title
            Me.Memory = mem.Value
            Me.Amp = amp.Value
            Me.Travel = travel.Value
            Me.Rate = rate.Value
        End Sub

        Public Property Title As MirrorDirection
        Public Property Memory As Single
        Public Property Amp As Single
        Public Property Travel As Single
        Public Property Rate As Single

    End Class

    Public Enum MirrorDirection
        Up
        Down
        InBoard
        OutBoard
    End Enum

End Namespace