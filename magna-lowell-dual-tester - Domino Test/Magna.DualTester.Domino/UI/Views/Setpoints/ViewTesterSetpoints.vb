Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data.Enums
Imports Magna.DualTester.Domino.TesterApi

Namespace UI.Views.Setpoints

    Public Class ViewTesterSetpoints
        Implements IViewTask

        Private _setpoints As Udt_Setpoints
        ReadOnly _minmaxCells As New Dictionary(Of String, MinMaxCells)()

        Private ReadOnly _msgsvc As IMessageAlertService
        Private ReadOnly _userWatch As IUserWatch
        Private ReadOnly _plc As IPlc
        Private ReadOnly _plcrepo As IPlcFullRepo
        Private ReadOnly MotionTargets As String() = New String() {"UpAngle", "DwnAngle", "InBoardAngle", "OutBoardAngle"}
        Private ReadOnly MemoryTargets As String() = New String() {"MemAtUp", "MemAtDwn", "MemAtInBoard", "MemAtOutBoard"}

        Public Property RunningTask As Task Implements IViewTask.RunningTask

        Public Sub New(userWatch As IUserWatch, plc As IPlc, plcrepo As IPlcFullRepo, msgsvc As IMessageAlertService)
            _plc = plc
            _plcrepo = plcrepo
            _userWatch = userWatch
            _msgsvc = msgsvc
            NewUser(_userWatch.CurrentValue)
            AddHandler _userWatch.ValueChanged, AddressOf NewUser
            InitializeComponent()
        End Sub

#Region "Set tables"

        Private Sub SetRightTable()
            Dim amp = "Amps"
            Dim degSec = "Deg/Sec"
            Dim sec = "Sec"
            Dim propsMotion = GetType(Udt_Setpoints).GetFields().Where(Function(x) Not MemoryTargets.Union(MotionTargets).Contains(x.Name))
            RightGrid.Rows = propsMotion.Count + 1

            RightGrid.HorizontalScroll.Enabled = False

            Dim gridWidth = RightGrid.Width - 5
            Dim twoCenterColumns = RightGrid.Range(1, 2, RightGrid.Rows - 1, 3)
            Dim leftColumn = RightGrid.Range(1, 1, RightGrid.Rows - 1, 1)

            twoCenterColumns.Borders(FlexCell.EdgeEnum.Inside Or FlexCell.EdgeEnum.Outside) = FlexCell.LineStyleEnum.Thin
            twoCenterColumns.BackColor = Color.Black
            twoCenterColumns.ForeColor = Color.White

            leftColumn.Locked = True

            RightGrid.Column(2).DecimalLength = 2
            RightGrid.Column(3).DecimalLength = 2
            twoCenterColumns.Mask = FlexCell.MaskEnum.Numeric

            RightGrid.Column(0).Width = 0
            RightGrid.Column(1).Width = CShort(gridWidth * 1 / 3)
            RightGrid.Column(2).Width = CShort(gridWidth * 1 / 3)
            RightGrid.Column(3).Width = CShort(gridWidth * 1 / 3)

            RightGrid.Column(1).Alignment = FlexCell.AlignmentEnum.RightGeneral

            Dim count = 1
            For Each p In propsMotion
                RightGrid.Cell(count, 1).Text = p.Name
                _minmaxCells.Add(p.Name, New MinMaxCells(RightGrid.Cell(count, 2), RightGrid.Cell(count, 3)))
                count += 1
            Next
            RightGrid.Cell(0, 2).Text = "Min"
            RightGrid.Cell(0, 3).Text = "Max"
        End Sub

        Private Sub SetTargetsTable()
            Dim gridWidth = MotionTargetsGrid.Width - 2
            MotionTargetsGrid.Column(1).Width = CShort(gridWidth * (0.2))
            MotionTargetsGrid.Column(2).Width = CShort(gridWidth * (0.175))
            MotionTargetsGrid.Column(3).Width = CShort(gridWidth * (0.175))
            MotionTargetsGrid.Column(4).Width = CShort(gridWidth * (0.175))
            MotionTargetsGrid.Column(5).Width = CShort(gridWidth * (0.175))
            MotionTargetsGrid.Column(6).Width = CShort(gridWidth * (0.1))
            Dim colCount = 1
            Dim numberFields = MotionTargetsGrid.Range(1, 2, 3, 5)
            numberFields.Borders(FlexCell.EdgeEnum.Inside Or FlexCell.EdgeEnum.Outside) = FlexCell.LineStyleEnum.Thin
            numberFields.BackColor = Color.Black
            numberFields.ForeColor = Color.White
            MotionTargetsGrid.Column(2).DecimalLength = 2
            MotionTargetsGrid.Column(3).DecimalLength = 2
            MotionTargetsGrid.Column(4).DecimalLength = 2
            MotionTargetsGrid.Column(5).DecimalLength = 2
            numberFields.Mask = FlexCell.MaskEnum.Numeric
            numberFields.Alignment = FlexCell.AlignmentEnum.CenterGeneral

            Dim propsMotion = GetType(Udt_Setpoints).GetFields().Where(Function(x) MotionTargets.Contains(x.Name))
            Dim propsMemory = GetType(Udt_Setpoints).GetFields().Where(Function(x) MemoryTargets.Contains(x.Name))

            MotionTargetsGrid.Column(0).Width = 0
            MotionTargetsGrid.Cell(1, colCount).Text = "Motion Targets"
            MotionTargetsGrid.Cell(2, colCount).Text = "Memory Range Min"
            MotionTargetsGrid.Cell(3, colCount).Text = "Memory Range Max"

            colCount += 1
            MotionTargetsGrid.Cell(0, colCount).Text = "Up"
            _minmaxCells.Add("UpAngle", New MinMaxCells(MotionTargetsGrid.Cell(1, colCount)))
            _minmaxCells.Add("MemAtUp", New MinMaxCells(MotionTargetsGrid.Cell(2, colCount), MotionTargetsGrid.Cell(3, colCount)))

            colCount += 1
            MotionTargetsGrid.Cell(0, colCount).Text = "Down"
            _minmaxCells.Add("DwnAngle", New MinMaxCells(MotionTargetsGrid.Cell(1, colCount)))
            _minmaxCells.Add("MemAtDwn", New MinMaxCells(MotionTargetsGrid.Cell(2, colCount), MotionTargetsGrid.Cell(3, colCount)))

            colCount += 1
            MotionTargetsGrid.Cell(0, colCount).Text = "InBoard"
            _minmaxCells.Add("InBoardAngle", New MinMaxCells(MotionTargetsGrid.Cell(1, colCount)))
            _minmaxCells.Add("MemAtInBoard", New MinMaxCells(MotionTargetsGrid.Cell(2, colCount), MotionTargetsGrid.Cell(3, colCount)))

            colCount += 1
            MotionTargetsGrid.Cell(0, colCount).Text = "OutBoard"
            _minmaxCells.Add("OutBoardAngle", New MinMaxCells(MotionTargetsGrid.Cell(1, colCount)))
            _minmaxCells.Add("MemAtOutBoard", New MinMaxCells(MotionTargetsGrid.Cell(2, colCount), MotionTargetsGrid.Cell(3, colCount)))
            colCount += 1

        End Sub

#End Region

        Private Sub RaiseSaved(address As String, obj As Object, Optional msg As String = "")
            _plc.ManualWrite(address, obj, message:=msg)
        End Sub

        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Dim props = GetType(Udt_Setpoints).GetFields()
            For Each p In props
                p.SetValue(_setpoints, _minmaxCells(p.Name).ToUdtMinMax)
            Next
            Me.RaiseSaved(PlcConstants.Set_Points, _setpoints)
            Me.RaiseSaved(PlcConstants.Log_Setpoint_Change_Trigger, 1)
            _msgsvc.PublishNewAlarm("Setpoints Saved", ErrorLevel.Message)
        End Sub

        Protected Overrides Sub Dispose(disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
            RemoveHandler _userWatch.ValueChanged, AddressOf NewUser
        End Sub

        Private Sub NewUser(user As User)
            Me.Enabled = _userWatch.CheckCurrentUserPermission(AccessLevel.Engineer)
        End Sub

        Public Async Function BeginClose() As Task Implements IViewTask.BeginClose
            RemoveHandler _userWatch.ValueChanged, AddressOf NewUser
            If RunningTask IsNot Nothing Then
                Await RunningTask
            End If
        End Function

#Region "Loading"

        Private Async Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
            BtnLoad.Enabled = False
            BtnSave.Enabled = False
            Await LoadData()
            Await RunningTask
            _msgsvc.PublishNewAlarm("Setpoints Loaded From PLC", ErrorLevel.Message)
            BtnSave.Enabled = True
            BtnLoad.Enabled = True
        End Sub

        Private Async Function LoadData() As Task
            If RunningTask Is Nothing OrElse RunningTask.IsCompleted Then
                RunningTask = Task.Factory.StartNew(Sub() SetData(_plcrepo.TesterData))
                Await RunningTask
            End If
        End Function

        Private Sub SetData(data As Udt_tester)
            If InvokeRequired Then
                Invoke(Sub() SetData(data))
                Return
            End If
            If _minmaxCells.Count > 8 Then
                _setpoints = data.SetPoints
                If _setpoints IsNot Nothing Then
                    Dim props = GetType(Udt_Setpoints).GetFields()
                    For Each p In props
                        _minmaxCells(p.Name).SetValues(DirectCast(p.GetValue(_setpoints), Udt_MinMax))
                    Next
                End If
            End If
            _msgsvc.PublishNewAlarm("Setpoints Loaded From PLC", ErrorLevel.Message)
        End Sub

        Private Async Sub IViewTask_Load() Implements IViewTask.Load
            SetRightTable()
            SetTargetsTable()
            Await LoadData()
        End Sub

#End Region

    End Class

    Friend Class MinMaxCells

        Public Sub New(min As FlexCell.Cell)
            If min Is Nothing Then
                Throw New ArgumentNullException()
            End If
            _minCell = min
            _maxCell = Nothing
        End Sub

        Public Sub New(min As FlexCell.Cell, max As FlexCell.Cell)
            If min Is Nothing Or max Is Nothing Then
                Throw New ArgumentNullException()
            End If
            _minCell = min
            _maxCell = max
        End Sub

        Public Sub SetValues(udtmm As Udt_MinMax)
            If _maxCell IsNot Nothing Then
                Me._maxCell.Text = udtmm.Max.ToString()
            End If
            Me._minCell.Text = udtmm.Min.ToString()
        End Sub

        Public ReadOnly Property ToUdtMinMax As Udt_MinMax
            Get
                Return New Udt_MinMax() With {.Max = If(IsNothing(_maxCell), 0, _maxCell.SingleValue), .Min = _minCell.SingleValue}
            End Get
        End Property

        Private ReadOnly _maxCell As FlexCell.Cell
        Private ReadOnly _minCell As FlexCell.Cell
    End Class

End Namespace