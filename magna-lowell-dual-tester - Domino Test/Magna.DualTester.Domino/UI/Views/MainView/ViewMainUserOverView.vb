Imports System.Reflection
Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data.Enums
Imports Magna.DualTester.Core.Tools
Imports Magna.DualTester.Domino.TesterApi
Imports Magna.DualTester.Domino.UI.Dialogs
Imports Magna.DualTester.Plc.Core.PlcStrings
Imports NLog
Imports FlexCell


Namespace UI.Views.MainView

    Public Class ViewMainUserOverView
        Implements IViewTask
        Private ReadOnly _cfg As ICfgDomino

        Private ReadOnly _langWatch As ILanguageWatch
        Private ReadOnly _msgsvc As IMessageAlertService
        Private ReadOnly _plc As IPlc
        Private ReadOnly _plcrepo As IPlcFullRepo
        Private ReadOnly _userWatch As IUserWatch
        Private loading As Boolean = False

        Dim logger As Logger = LogManager.GetCurrentClassLogger()

        Public Sub New(cfg As ICfgDomino, langWatch As ILanguageWatch, userWatch As IUserWatch, plc As IPlc, plcrepo As IPlcFullRepo, msgsvc As IMessageAlertService)
            'MyBase.New(AccessLevel.Engineer)
            'MyBase.New(AccessLevel.None)
            _langWatch = langWatch
            _userWatch = userWatch
            _plcrepo = plcrepo
            _msgsvc = msgsvc
            _cfg = cfg
            _plc = plc
            InitializeComponent()
            'SetupMidTopGrid()
            'SetupMidBottomGrid()
            'SetupGlassOptionsGrid()

            SetupGrid(Of Udt_PartInformation)(GridPartData, _cellDictPartData, {"Options"})
            SetupGrid(Of Udt_PartOptions)(GridPartOptions, _cellDictPartOptions, {})
            SetupGrid(Of Udt_GlassOptions)(GridGlassOptions, _cellDictGlassOptions, {})


            PendingToteCountAtZero = False
            Me.Nest1DataControl.SetPlc = _plc
            Me.Nest2DataControl.SetPlc = _plc
            Nest1DataControl.SetMessageService = msgsvc
            Nest2DataControl.SetMessageService = msgsvc
        End Sub

        Public Property RunningTask As Task Implements IViewTask.RunningTask

        Private ReadOnly Property _cellDictGlassOptions As New Dictionary(Of String, NestPair(Of FlexCell.Cell))()

        ''' <summary>
        ''' the key will be a field name in a class and the value will be its corresponding cell
        ''' </summary>
        Private ReadOnly Property _cellDictPartData As New Dictionary(Of String, NestPair(Of FlexCell.Cell))()

        ''' <summary>
        ''' the key will be a field name in a class and the value will be its corresponding cell
        ''' </summary>
        Private ReadOnly Property _cellDictPartOptions As New Dictionary(Of String, NestPair(Of FlexCell.Cell))()

        ReadOnly Property _isUserEnieOrBetter As Boolean
            Get
                Return _userWatch.CheckCurrentUserPermission(AccessLevel.Engineer)
            End Get
        End Property

        ReadOnly Property _isUserSupervisorOrBetter As Boolean
            Get
                Return _userWatch.CheckCurrentUserPermission(AccessLevel.Supervisor)
            End Get
        End Property

        ''' <summary>
        ''' This will hold the data every time the udt data structure is reloaded.
        ''' </summary>
        ''' <remarks></remarks>
        Private Property _tester As Udt_tester
        Private Property PendingToteCountAtZero As Boolean

        Public Shared Sub SetupGrid(Of T)(grid As FlexCell.Grid, celldict As Dictionary(Of String, NestPair(Of FlexCell.Cell)), ignores As IEnumerable(Of String))
            Dim GName As String = grid.Name
            SetUpGridCommon(grid)
            With grid
                Dim properties() As FieldInfo = GetType(T).GetFields() 'this contains a list of fields inside the model_partTestOptions
                Dim count = 0
                .Rows = properties.Count + 1
                For Each item As FieldInfo In properties
                    If Not ignores.Contains(item.Name) Then
                        .Cell(count + 1, 2).Text = item.Name
                        celldict.Add(item.Name, New NestPair(Of FlexCell.Cell)(.Cell(count + 1, 1), .Cell(count + 1, 3)))
                        count += 1
                    End If
                Next
            End With
        End Sub

        Private Shared Sub SetUpGridCommon(grid As FlexCell.Grid)
            Dim GName As String = grid.Name
            With grid
                If GName = NameOf(GridPartData) Then
                    .Cols = 4
                    .Range(0, 0, .Rows - 1, 1).Locked = True
                    .Row(0).Height = 0
                    .Column(0).Visible = False
                    .Column(0).Width = 0
                    .Column(1).Width = CShort((.Width - 2) * 0.4)
                    .Column(2).Width = CShort((.Width - 2) * 0.25)
                    .Column(3).Width = CShort((.Width - 2) * 0.4)
                    Dim center = .Range(1, 2, .Rows - 1, 2)
                    center.Alignment = FlexCell.AlignmentEnum.CenterCenter
                    center.BackColor = Color.LightGray
                    center.Locked = True
                    Exit Sub
                ElseIf GName = NameOf(GridPartOptions) Then
                    .Cols = 5
                    .Range(0, 0, .Rows - 1, 1).Locked = True
                    .Row(0).Height = 0
                    .Column(0).Visible = True
                    .Column(0).Width = 50
                    .Column(1).Width = CShort((.Width - 2) * 0.1)
                    .Column(2).Width = CShort((.Width - 2) * 0.35)
                    .Column(3).Width = CShort((.Width - 2) * 0.1)
                    .Column(4).Visible = True
                    .Column(4).Width = 75
                    Dim center = .Range(1, 2, .Rows - 1, 2)
                    center.Alignment = FlexCell.AlignmentEnum.CenterCenter
                    center.BackColor = Color.LightGray
                    center.Locked = True
                    Exit Sub
                ElseIf GName = NameOf(GridGlassOptions) Then
                    .Cols = 5
                    .Range(0, 0, .Rows - 1, 1).Locked = True
                    .Row(0).Height = 0
                    .Column(0).Visible = True
                    .Column(0).Width = 50
                    .Column(1).Width = CShort((.Width - 2) * 0.1)
                    .Column(2).Width = CShort((.Width - 2) * 0.35)
                    .Column(3).Width = CShort((.Width - 2) * 0.1)
                    .Column(4).Visible = True
                    .Column(4).Width = 75

                    Dim center = .Range(1, 2, .Rows - 1, 2)
                    center.Alignment = FlexCell.AlignmentEnum.CenterCenter
                    center.BackColor = Color.LightGray
                    center.Locked = True
                End If
            End With

        End Sub

        Public Async Function BeginClose() As Task Implements IViewTask.BeginClose
            RemoveHandler _plcrepo.TesterContextChanged, AddressOf LoadData
            If RunningTask IsNot Nothing Then
                Await RunningTask
            End If
        End Function

        ''' <summary>
        ''' If any values under tester count are less than zero then the value will be set to zero.
        ''' </summary>
        Private Async Function FixCounts() As Task
            Dim cnts = _tester.Counts
            Dim failed = New List(Of String)
            Dim props = GetType(Udt_Tester_Counts).GetFields()
            For Each p In props
                If p.Name <> "BatchCountDown" Then
                    Dim i As Integer = CInt(p.GetValue(cnts))
                    If i < 0 Then
                        p.SetValue(cnts, 0)
                        failed.Add(p.Name)
                    End If
                End If
            Next
            If failed.Count > 0 Then
                Await WriteToPlcAsync(PlcConstants.Counts, cnts, $"Value/s < 0 in counts {String.Join(",", failed)} set to 0")
            End If
        End Function

        Private Sub IViewTask_Load() Implements IViewTask.Load
            LoadData(_plcrepo.TesterData)
            AddHandler _plcrepo.TesterContextChanged, AddressOf LoadData
        End Sub

#Region "Label event handlers"

        Private Sub Lbl_dblClick(sender As Object, e As EventArgs) Handles LblFailValue.DoubleClick,
                                                                             LblPassValue.DoubleClick, GridPartData.DoubleClick

            Dim showEdit = Sub(title As String, val As Integer, address As String)
                               Dim d As New DialogCountEdit(title, val)
                               d.ShowDialog(Me)
                               If d.DialogResult = DialogResult.OK Then
                                   Dim incdec As String = If(val > d.Value, "Decremented", "Incremented")
                                   If d.Value >= 0 Then
                                       _plc.ManualWrite(address, d.Value, message:=String.Format("{0} was {1} to {2}", title, incdec, d.Value))
                                   Else
                                       _msgsvc.PublishNewAlarm("Count cannot be bellow 0", ErrorLevel.Alert)
                                   End If
                               End If
                           End Sub

            If _isUserSupervisorOrBetter Then
                If sender Is LblFailValue Then
                    showEdit("Shift Fail Count", _tester.Counts.ShiftFailCount, PlcConstants.TesterAddress + ".Counts.ShiftFailCount")
                    'ElseIf sender Is LblToteTargetValue Then
                    '    showEdit("Tote Target Count", _tester.Counts.ToteTarget, PlcConstants.Counts_Tote_Target)
                    'ElseIf sender Is LblToteDownValue Then
                    '    showEdit("Tote Part Count", _tester.Counts.ToteCount, PlcConstants.Counts_Tote_Count)
                    'ElseIf sender Is LblPassValue Then
                    '    showEdit("Shift Pass Count", _tester.Counts.ShiftPassCount, PlcConstants.Counts_Shift_Pass_Count)
                    'ElseIf sender Is LblBatchCount Then
                    '    Dim dilg As New ValueDialog("Batch Count", "Count", _tester.Counts.BatchCountDown, _userWatch.CurrentValue, _msgsvc)
                    '    dilg.ShowDialog(Me)
                    '    If dilg.DialogResult = DialogResult.OK Then
                    '        _plc.ManualWrite(PlcConstants.Counts_Batch_Count_Down, dilg.Value, message:=String.Format("BatchCountDown changed from {0} to {1}", _tester.Counts.BatchCountDown, dilg.Value.ToString()))
                    '    End If
                ElseIf sender Is GridPartData Then
                    _msgsvc.PublishNewAlarm("Domino version cannot change PN", ErrorLevel.Alert)
                    'If _tester.Nest1.SeqVal >= 15 Then
                    '    _msgsvc.PublishNewAlarm("Left side Tester in Sequence, Pn Change Not available", ErrorLevel.Alert)
                    '    Exit Sub
                    'End If
                    'If _tester.Nest2.SeqVal >= 15 Then
                    '    _msgsvc.PublishNewAlarm("Right side Tester in Sequence, Pn Change Not available", ErrorLevel.Alert)
                    '    Exit Sub
                    'End If
                    'If _tester.Counts.ToteCount > 0 Then
                    '    _msgsvc.PublishNewAlarm("Tote Accum must be 0 to Change part Number", ErrorLevel.Alert)
                    '    Exit Sub
                    'End If

                    'Dim dilg As New DialogStringEdit("Edit Part Number", _tester.PartInfo.Pn.ToString())
                    'dilg.ShowDialog(Me)
                    'If dilg.DialogResult = DialogResult.OK Then
                    '    _plc.ManualWriteString82(PlcConstants.Pn_To_Find, dilg.Value.ToUpperInvariant().TrimStart(CChar("Z")))
                    '    Dim batchDialog As New ValueDialog("Batch Count", "Count", _tester.Counts.BatchCountDown, _userWatch.CurrentValue, _msgsvc)
                    '    batchDialog.ShowDialog(Me)
                    '    _tester.Counts.BatchCountDown = CInt(batchDialog.Value)
                    '    _plc.ManualWrite(PlcConstants.Counts, CObj(_tester.Counts))
                    'End If

                End If
            Else
                _msgsvc.PublishNewAlarm(MessageAlertService.PermissionAlert, ErrorLevel.Alert)
            End If
        End Sub

        Private Sub LoadData(data As Udt_tester)
            If data Is Nothing Then
                _msgsvc.PublishNewAlarm("_tester is null", ErrorLevel.Alert)
                'Throw New ArgumentNullException("The tester udt is null in the LoadData method")
            Else
                _tester = data
                If RunningTask Is Nothing OrElse RunningTask.IsCompleted Then
                    RunningTask = LoadView()
                End If
            End If
        End Sub

        Private Async Function LoadView() As Task
            UpdateSubViews(_tester)
            If loading Then
                Return
            End If
            loading = True

            '-----------------------------------------Set the counts to zero if they are less than zero----------------------
            Await FixCounts()

            '-----------------------------------------------adjust batchCount if 0------------------------------------------
            'If _tester.Counts.BatchCountDown <= 0 Then
            '    If _isUserEnieOrBetter Then
            '        PendingToteCountAtZero = Not (PendingToteCountAtZero AndAlso _tester.Counts.ToteCount = 0)
            'If Not PendingToteCountAtZero Then
            '    Dim t1 = Task.Factory.StartNew(Sub()
            '                                       Dim runIt = Async Sub()
            '                                                       Dim NewPnQty = New PnAndQtyEdit("Part Number and Batch Qty", _tester.Counts.BatchCountDown, _userWatch.CurrentValue, _tester.Nest1.PartInfo.Pn.ToString(), _tester.Nest2.PartInfo.Pn.ToString(), _msgsvc)

            '                                                       If _tester.Counts.ToteCount > 0 AndAlso (_tester.Nest1.PartInfo.Pn.ToString().Count() < 2 OrElse _tester.Nest2.PartInfo.Pn.ToString().Count() < 2) Then
            '                                                           Await WriteToPlcAsync(PlcConstants.Counts_Tote_Count, 0)
            '                                                           NewPnQty.ToteAccum = 0
            '                                                       Else
            '                                                           NewPnQty.ToteAccum = _tester.Counts.ToteCount
            '                                                       End If
            '                                                       Dim Dr = NewPnQty.ShowDialog(Me)
            '                                                       If Dr = DialogResult.OK Then
            '                                                           _plc.ManualWriteString82(PlcConstants.Pn_To_Find, NewPnQty.Pn.ToUpperInvariant().TrimStart(CChar("Z")))
            '                                                           _plc.ManualWrite(PlcConstants.Counts_Batch_Count_Down, NewPnQty.Value)
            '                                                       ElseIf Dr = DialogResult.Abort Then
            '                                                           If NewPnQty.PrintToteLabel Then
            '                                                               PendingToteCountAtZero = True
            '                                                               _printServ.PrintToteLabel()
            '                                                           End If
            '                                                           If NewPnQty.EndTote Then
            '                                                               _plc.ManualWrite(PlcConstants.Counts_Tote_Count, 0)
            '                                                               PendingToteCountAtZero = True
            '                                                           End If
            '                                                       End If

            '                                                       NewPnQty = Nothing
            '                                                   End Sub
            '                                       Me.Invoke(runIt)
            '                                   End Sub)

            '    Await t1
            'Debug.Print("Done running update view")
            'End If
            'Else
            '    _msgsvc.PublishNewAlarm("Login as Engineer or better to adjust counts", ErrorLevel.Alert)
            'End If
            'End If

            '-----------------------------------------------update ui-------------------------------------------------------
            Dim run = Sub()
                          Try
                              Select Case (_tester.Daq_Hb.Status)
                                  Case 1
                                      LblDaq.BackColor = Color.LimeGreen
                                  Case 2
                                      LblDaq.BackColor = Color.Yellow
                                  Case > 2
                                      LblDaq.BackColor = Color.Red
                              End Select

                              LblFailValue.Text = _tester.Counts.ShiftFailCount.ToString()
                              LblPassValue.Text = _tester.Counts.ShiftPassCount.ToString()
                              'LblToteDownValue.Text = _tester.Counts.ToteCount.ToString()
                              'LblToteTargetValue.Text = _tester.Counts.ToteTarget.ToString()
                              '----------------------------------------------Sets the Batch count label color-------------------------------------------------
                              Dim needsData = _tester.Counts.BatchCountDown <= 0 AndAlso (String.IsNullOrEmpty(_tester.Nest1.PartInfo.Pn.ToString()) OrElse String.IsNullOrEmpty(_tester.Nest2.PartInfo.Pn.ToString()))
                              'LblBatchCount.BackColor = If(needsData, Color.Salmon, Color.Black)
                              'LblBatchCount.ForeColor = If(needsData, Color.Black, Color.White)
                              'LblBatchCount.Text = _tester.Counts.BatchCountDown.ToString()

                              '\/ top grid write -------------------------------------------------------------------
                              Dim objN1 As Udt_PartInformation = _tester.Nest1.PartInfo         'grabbing what is needed from tester
                              Dim objN2 As Udt_PartInformation = _tester.Nest2.PartInfo         'grabbing what is needed from tester
                              For Each item As FieldInfo In GetType(Udt_PartInformation).GetFields() ' objN1.GetType().GetFields()   'iterating thru the structs
                                  If item.FieldType Is GetType(PlcString_82) Then
                                      _cellDictPartData(item.Name).Nest1.Text = DirectCast(item.GetValue(objN1), PlcString_82).ToString()
                                      _cellDictPartData(item.Name).Nest2.Text = DirectCast(item.GetValue(objN2), PlcString_82).ToString()
                                  ElseIf item.FieldType Is GetType(PlcString_8) Then
                                      _cellDictPartData(item.Name).Nest1.Text = DirectCast(item.GetValue(objN1), PlcString_8).ToString()
                                      _cellDictPartData(item.Name).Nest2.Text = DirectCast(item.GetValue(objN2), PlcString_8).ToString()
                                  ElseIf item.FieldType IsNot GetType(Udt_PartOptions) Then
                                      _cellDictPartData(item.Name).Nest1.Text = item.GetValue(objN1).ToString() 'DirectCast(item.GetValue(obj), Boolean).ToString()
                                      _cellDictPartData(item.Name).Nest2.Text = item.GetValue(objN2).ToString() 'DirectCast(item.GetValue(obj), Boolean).ToString()
                                  End If
                              Next

                              '\/------------------------------bottom grid write -----------------------------------
                              Dim tmpN1 As Udt_PartOptions = _tester.Nest1.PartOptions     'grabbing what is needed from tester
                              Dim tmpN2 As Udt_PartOptions = _tester.Nest2.PartOptions     'grabbing what is needed from tester
                              For Each item As FieldInfo In GetType(Udt_PartOptions).GetFields() ' tmp.GetType().GetFields()       'iterating thru the structs
                                  _cellDictPartOptions(item.Name).Nest1.Text = DirectCast(item.GetValue(tmpN1), Udt_Opt_Item).Config.ToString()
                                  _cellDictPartOptions(item.Name).Nest2.Text = DirectCast(item.GetValue(tmpN2), Udt_Opt_Item).Config.ToString()
                              Next

                              Dim tmpG1 As Udt_GlassOptions = _tester.Nest1.GlassOptions
                              Dim tmpG2 As Udt_GlassOptions = _tester.Nest2.GlassOptions
                              For Each item As FieldInfo In GetType(Udt_GlassOptions).GetFields()
                                  _cellDictGlassOptions(item.Name).Nest1.Text = DirectCast(item.GetValue(tmpG1), Udt_Opt_Item).Config.ToString()
                                  _cellDictGlassOptions(item.Name).Nest2.Text = DirectCast(item.GetValue(tmpG2), Udt_Opt_Item).Config.ToString()
                              Next

                              '_prevPn = _tester..PartInfo.Pn.ToString()
                          Catch ex As Exception
                              logger.Error(ex.Message)
                              _msgsvc.PublishNewAlarm(ex.Message, ErrorLevel.Error)
                          End Try
                      End Sub
            If Me.InvokeRequired Then Me.BeginInvoke(run) Else run()
            loading = False
        End Function

        ''  <summary>
        ''  Using reflection this function will implicitly fill out the grid based on the class its set up with
        ''  </summary>
        'Private Sub SetupMidTopGrid() ', celldict As Dictionary(Of String, NestPair(Of FlexCell.Cell)), ignores As IEnumerable(Of String))
        '    With GridPartData
        '        Dim properties() As FieldInfo = GetType(Udt_PartInformation).GetFields() 'this contains a list of fields inside the model_partInformation
        '        'SetUpGridCommon(GridPartData)
        '        .Cols = 4
        '        .Range(0, 0, .Rows - 1, 1).Locked = True
        '        .Row(0).Height = 0
        '        .Column(0).Visible = False
        '        .Column(0).Width = 0
        '        .Column(1).Width = CShort((.Width - 2) * 0.5)
        '        .Column(2).Width = CShort((.Width - 2) * 0.35)
        '        .Column(3).Width = CShort((.Width - 2) * 0.5)
        '        Dim center = .Range(1, 2, .Rows - 1, 2)
        '        center.Alignment = FlexCell.AlignmentEnum.CenterCenter
        '        center.BackColor = Color.LightGray
        '        center.Locked = True
        '        Dim count = 0
        '        For Each item As FieldInfo In properties
        '            'Dim index = count + 1
        '            If item.Name <> "Options" Then
        '                'Dim cell = .Cell(index, 2)
        '                If .Cell(count + 1, 2).Text IsNot Nothing Then
        '                    '    cell.Text = item.Name                    'using the name of the field to name the row header
        '                    '    _cellDictPartData.Add(item.Name, New NestPair(Of FlexCell.Cell)(.Cell(index, 1), .Cell(index, 3)))    'using the name of the field to name the key in the dictionary
        '                    '    count += 1
        '                    'Else
        '                    '    Throw New IndexOutOfRangeException()
        '                    ' End If
        '                    .Cell(count + 1, 2).Text = item.Name
        '                    _cellDictPartData.Add(item.Name, New NestPair(Of FlexCell.Cell)(.Cell(count + 1, 1), .Cell(count + 1, 3)))    'using the name of the field to name the key in the dictionary
        '                    count += 1
        '                Else
        '                    Throw New IndexOutOfRangeException()
        '                End If
        '            End If
        '        Next
        '    End With
        'End Sub

        ''  <summary>
        ''  Using reflection this function will implicitly fill out the grid based on the class its set up with
        ''  </summary>
        'Private Sub SetupMidBottomGrid() ', celldict As Dictionary(Of String, NestPair(Of FlexCell.Cell)), ignores As IEnumerable(Of String))
        '    With GridPartOptions
        '        ' SetUpGridCommon(GridPartOptions)
        '        .Cols = 4
        '        .Range(0, 0, .Rows - 1, 1).Locked = True
        '        .Row(0).Height = 0
        '        .Column(0).Visible = False
        '        .Column(0).Width = 0
        '        .Column(1).Width = CShort((.Width - 2) * 0.5)
        '        .Column(2).Width = CShort((.Width - 2) * 0.35)
        '        .Column(3).Width = CShort((.Width - 2) * 0.5)
        '        Dim center = .Range(1, 2, .Rows - 1, 2)
        '        center.Alignment = FlexCell.AlignmentEnum.CenterCenter
        '        center.BackColor = Color.LightGray
        '        center.Locked = True
        '        Dim properties() As FieldInfo = GetType(Udt_PartOptions).GetFields() 'this contains a list of fields inside the model_partTestOptions
        '        .Rows = properties.Count + 1
        '        Dim count = 0
        '        For Each item As FieldInfo In properties
        '            .Cell(count + 1, 2).Text = item.Name
        '            _cellDictPartOptions.Add(item.Name, New NestPair(Of FlexCell.Cell)(.Cell(count + 1, 1), .Cell(count + 1, 3)))
        '            count += 1
        '        Next
        '    End With
        'End Sub
        'Private Sub SetupGlassOptionsGrid() ', celldict As Dictionary(Of String, NestPair(Of FlexCell.Cell)), ignores As IEnumerable(Of String))
        '    'SetUpGridCommon(GridGlassOptions)
        '    With GridGlassOptions
        '        .Cols = 4
        '        .Range(0, 0, .Rows - 1, 1).Locked = True
        '        .Row(0).Height = 0
        '        .Column(0).Visible = False
        '        .Column(0).Width = 0
        '        .Column(1).Width = CShort((.Width - 2) * 0.5)
        '        .Column(2).Width = CShort((.Width - 2) * 0.35)
        '        .Column(3).Width = CShort((.Width - 2) * 0.5)
        '        Dim center = .Range(1, 2, .Rows - 1, 2)
        '        center.Alignment = FlexCell.AlignmentEnum.CenterCenter
        '        center.BackColor = Color.LightGray
        '        center.Locked = True
        '        Dim properties() As FieldInfo = GetType(Udt_GlassOptions).GetFields() 'this contains a list of fields inside the model_partTestOptions
        '        .Rows = properties.Count + 1
        '        Dim count = 0
        '        For Each item As FieldInfo In properties
        '            .Cell(count + 1, 2).Text = item.Name
        '            _cellDictGlassOptions.Add(item.Name, New NestPair(Of FlexCell.Cell)(.Cell(count + 1, 1), .Cell(count + 1, 3)))
        '            count += 1
        '        Next
        '    End With
        'End Sub

        Private Sub UpdateSubViews(data As Udt_tester)
            Dim c = _cfg.ReadConfig()
            Dim colors = _plc.Colors
            Dim n1Vm = New NestDataControlViewModel(1, data.Nest1, _langWatch.CurrentValue, c, colors)
            Dim n2Vm = New NestDataControlViewModel(2, data.Nest2, _langWatch.CurrentValue, c, colors)
            Nest1DataControl.UpdateViewModel(n1Vm)
            Nest2DataControl.UpdateViewModel(n2Vm)
            PartNumberStatusNest1.UpdateData(data.Nest1.PartInfo)
            PartNumberStatusNest2.UpdateData(data.Nest2.PartInfo)
        End Sub

        Private Async Function WriteToPlcAsync(address As String, obj As Object, Optional message As String = Nothing) As Task
            Await _plc.ManualWriteAsync(New SaveEventArgs(address, obj, message:=message))
        End Function

#End Region

    End Class

    Public Class NestPair(Of T)

        Public Sub New(nest1 As T, nest2 As T)
            Me.Nest1 = nest1
            Me.Nest2 = nest2
        End Sub

        Public Property Nest1 As T
        Public Property Nest2 As T

    End Class

End Namespace