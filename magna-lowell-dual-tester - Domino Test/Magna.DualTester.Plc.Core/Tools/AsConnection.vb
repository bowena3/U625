Imports System.Threading
Imports System.Threading.Tasks
Imports AutomatedSolutions.Win.Comm.AB.Logix
Imports Magna.DualTester.Core
Imports Magna.DualTester.Plc.Core.PlcStrings
Imports NLog

Namespace Tools


    ''' <summary>
    ''' Created to make an easy to use interface for accessing the plc.
    ''' </summary>
    Public Class AsConnection(Of TUdtTester As {New, Class})
        Implements IDisposable, IPlc(Of TUdtTester)

        Public Event UdtTesterChanged As Action(Of TUdtTester) Implements IPlc(Of TUdtTester).TesterChanged
        Public Event StartupResult As EventHandler(Of StartupEventResult) Implements IStartupService.StartupResult
        Public Property StartupStatus As StartupEventResult Implements IStartupService.Status

        Private Const ColorsAddress = "Colors"

        Private Property Dev As New Device
        Private Property MyChannel As Net.Channel
        Private Property MyGroup As Group
        Private Property TesterItem As Item
        Private Property ColorsItem As Item
        'Dim _connectionSet As Boolean

        Private Property DeviceErrored As Boolean

        'Private Property AreRead As New AutoResetEvent(True)
        'Private Property AreWrite As New AutoResetEvent(True)
        'Private Property AreWriteSingle As New AutoResetEvent(True)
        'Public Property InitStat As TesterResult Implements IPlc(Of TUdtTester).InitStat

        Private Property _currentTester As TUdtTester
        Public Property CurrentTester As TUdtTester Implements IPlc(Of TUdtTester).TesterData
            Get
                If _currentTester Is Nothing Then
                    Dim result = Read(Of TUdtTester)(_cfg.GetCfg.TesterAddress)
                    _currentTester = result.Value
                End If

                Return _currentTester
            End Get
            Set(value As TUdtTester)
                _currentTester = value
            End Set
        End Property


        Private _rawColors As New Udt_Colors
        Public Property Colors As ColorsModel Implements IPlc(Of TUdtTester).Colors


        Public ReadOnly Property ServiceName As String Implements IStartupService.ServiceName
            Get
                Return "PLC"
            End Get
        End Property

        Private ReadOnly _cfg As IPlcCfgFactory
        Private ReadOnly _messageAlert As IPlcAlertService
        Private ReadOnly _astest As IAsTest
        Dim logger As NLog.Logger = LogManager.GetCurrentClassLogger()

        ''' <summary>
        ''' This sub initializes all the main components for reading the plc.
        ''' </summary>
        Public Sub New(cfg As IPlcCfgFactory, msgserv As IPlcAlertService, astest As IAsTest)
            Colors = New ColorsModel()
            _cfg = cfg
            _astest = astest
            _messageAlert = msgserv
            Task.Run(AddressOf Initalize)
        End Sub

        Private Async Function Initalize() As Task
            Dim settings = _cfg.GetCfg()
            If _cfg IsNot Nothing AndAlso settings.DevicePlcIp <> String.Empty Then

                If My.Computer.Network.Ping(settings.DevicePlcIp, 1000) Then
                    Dev = New Device(settings.DevicePlcIp, Model.ControlLogix, 2000, 3000) '"10.205.60.170"
                    ' Dev.Simulate = True
                    MyChannel = New Net.Channel()
                    MyChannel.Devices.Add(Dev)
                    MyGroup = New Group(True, 1000)
                    Dev.Groups.Add(MyGroup)
                    TesterItem = New Item(settings.TesterAddress)
                    ColorsItem = New Item(ColorsAddress, 32)
                    MyGroup.Items.Add(TesterItem)
                    MyGroup.Items.Add(ColorsItem)
                    TesterItem.Active = True
                    ColorsItem.Active = True
                    MyGroup.Active = True
                    Dim testResults = Await _astest.TestAsync(Me)
                    If testResults.Any(Function(x) x.Success = False) Then
                        StartupStatus = New StartupEventResult(False, "The UDT did not match")
                    Else
                        AddHandler TesterItem.DataChanged, AddressOf Item_DataChangedEventHandler
                        AddHandler ColorsItem.DataChanged, AddressOf ColorsItem_DataChangedEventHandler
                        AddHandler Dev.Error, AddressOf OnDeviceError
                        StartupStatus = New StartupEventResult(True)
                        '_connectionSet = True
                    End If
                Else
                    StartupStatus = New StartupEventResult(False, "The PLC IP address timed out. Please check the config file.")
                End If
            Else
                StartupStatus = New StartupEventResult(False, "The PLC IP address is missing or something is wrong with the config file. Please close this program and modify it.")
            End If
            If StartupStatus Is Nothing Then
                Throw New Exception("Plc stat not set")
            End If
            RaiseEvent StartupResult(Me, StartupStatus)
        End Function


        Public Async Function TestUdtAsync() As Task(Of IEnumerable(Of IUdtTest)) Implements IPlc(Of TUdtTester).TestUdtAsync
            Return Await _astest.TestAsync(Me)
        End Function
        Public Function TestUdt() As IEnumerable(Of IUdtTest) Implements IPlc(Of TUdtTester).TestUdt
            Return _astest.Test(Me)
        End Function


        Public Async Function WriteColors(colors As ColorsModel) As Task Implements IPlc(Of TUdtTester).WriteColors
            Dim udtcolors = New Udt_Colors()
            For Each clr In colors.Data
                udtcolors.Data(clr.Index) = New Udt_Color() With {.Name = New PlcString_82(clr.Name), .Pcode = New PlcString_82(clr.Pcode)}
            Next
            Await ManualWriteAsync(New SaveEventArgs(ColorsAddress, udtcolors.Data, 32))
        End Function

#Region "DataChangedEventHandler"
        ''' <summary>
        ''' This sub will attempt to read the plc. If it cannot however it will attempt to rerun <c>Init</c>.
        ''' </summary>
        ''' <remarks>It might be a bad idea to rerun <c>Init</c> from here.</remarks>
        Private Sub Item_DataChangedEventHandler(ByVal sender As Object, ByVal evargs As EventArgs)
            Try
                Dim T As Item = CType(sender, Item)
                Dim tmpTester As New TUdtTester()
                T.GetStructuredValues(CObj(tmpTester))
                CurrentTester = tmpTester
                RaiseEvent UdtTesterChanged(CurrentTester)
            Catch ex As Exception
                _messageAlert.PublishNewAlarm($"Could not load Tester Changes. {ex.Message}", PlcAlertType.Error)
            End Try
        End Sub
        Private Sub ColorsItem_DataChangedEventHandler(sender As Object, evArgs As EventArgs)
            Try
                Dim T As Item = CType(sender, Item)
                Dim tmpColors As New Udt_Colors()
                T.GetStructuredValues(CObj(tmpColors))
                _rawColors = tmpColors

                Dim i = 0
                For Each c In _rawColors.Data
                    With Colors.Data(i)
                        .Index = i
                        .Name = c.Name.ToString()
                        .Pcode = c.Pcode.ToString()
                    End With
                    i += 1
                Next
                RaiseEvent UdtTesterChanged(CurrentTester)
            Catch ex As Exception
                _messageAlert.PublishNewAlarm($"Could not load color Changes. {ex.Message}", PlcAlertType.Error)
            End Try
        End Sub
#End Region

#Region "Read Write"
        Public Function Read(Of T As {New, Class})(address As String, Optional length As Integer = 1) As TesterResult(Of T) Implements IPlc(Of TUdtTester).Read
            Dim res As AutomatedSolutions.Win.Comm.Result = Nothing
            Try
                Dim item As New Item(address, length)
                'If _connectionSet Then
                If Not Me._disposedValue Then
                    Dev.Read(item, res)
                End If
                If res.IsOK Then
                    Dim val = New T()
                    item.GetStructuredValues(CObj(val))
                    Return New TesterResult(Of T)(val)
                Else
                    Return New TesterResult(Of T)(False, $"The read result was marked as not ok. Address:""{address}""")
                End If
                'End If
                'Return New TesterResult(Of T)(False, $"The connection is not set. Address:""{address}""")
            Catch ex As Exception
                _messageAlert.PublishNewAlarm("PLC not connected", PlcAlertType.Error)
                Return New TesterResult(Of T)(False, $" Plc.Read address:""{address}"" " + ex.Message)
            End Try
        End Function

        Public Async Function ReadAsync(Of T As {Class, New})(address As String, Optional length As Integer = 1) As Task(Of TesterResult(Of T)) Implements IPlc(Of TUdtTester).ReadAsync
            Return Await Task(Of TesterResult(Of T)).Factory.StartNew(Function()
                                                                          Dim item As New Item(address, length)
                                                                          'If _connectionSet Then
                                                                          If Not Me._disposedValue Then
                                                                              Dim res As AutomatedSolutions.Win.Comm.Result = Nothing
                                                                              Dev.Read(item, res)
                                                                              If res.IsOK AndAlso item.Quality = AutomatedSolutions.Win.Comm.Quality.GOOD Then
                                                                                  Dim val = New T()
                                                                                  item.GetStructuredValues(CObj(val))
                                                                                  Return New TesterResult(Of T)(val)
                                                                              Else
                                                                                  Return New TesterResult(Of T)(False, $"The read result was marked as not ok. Address:""{address}""")
                                                                              End If
                                                                          End If
                                                                          'End If
                                                                          Return Nothing
                                                                      End Function)
        End Function

        Public Function ManualWrite(address As String, obj As Object, Optional length As Integer = 1, Optional message As String = Nothing) As TesterResult Implements IPlc(Of TUdtTester).ManualWrite
            Dim res = Write(address, obj, length)
            If res.Success AndAlso Not String.IsNullOrWhiteSpace(message) Then
                Dim res2 = Write(_cfg.GetCfg.Activity_To_Buffer_Event_Message, New PlcString_82(message))
                If res2.Success Then
                    Return res2 'I only return res2 since res must pass for res2 to exist 
                End If
                Throw New Exception("Could not write to activity buffer. " + res2.Message)
            End If
            Return res 'Here I only return res because res2 never happend
        End Function

        Public Function ManualWrite(e As SaveEventArgs) As TesterResult Implements IPlc(Of TUdtTester).ManualWrite
            Return ManualWrite(e.Address, e.Value, length:=e.Length, message:=e.Message)
        End Function

        Public Async Function ManualWriteAsync(e As SaveEventArgs) As Task(Of TesterResult) Implements IPlc(Of TUdtTester).ManualWriteAsync
            Dim res = Await WriteAsync(e.Address, e.Value, e.Length)
            If res.Success AndAlso Not String.IsNullOrWhiteSpace(e.Message) Then
                Dim res2 = Await WriteAsync(_cfg.GetCfg.Activity_To_Buffer_Event_Message, New PlcString_82(e.Message))
                If res2.Success Then
                    Return res2 'I only return res2 since res must pass for res2 to exist 
                End If
                Throw New Exception("Could not write to activity buffer. " + res2.Message)
            End If
            Return res 'Here I only return res because res2 never happend
        End Function

        Public Function ManualWriteString82(address As String, val As String) As TesterResult Implements IPlc(Of TUdtTester).ManualWriteString82
            Return ManualWrite(address, New PlcString_82(val))
        End Function
        Private Function Write(address As String, x As Object, Optional length As Integer = 1) As TesterResult
            If x.GetType() = GetType(String) Then
                Throw New ArgumentException($"The object being written to the plc is a string not a plcString. addr:{address} value:{CStr(x)}")
            End If

            Try
                'If _connectionSet Then
                'AreWrite.WaitOne(2000)
                'AreWrite.Reset()
                If Not Me._disposedValue Then
                    Debug.Print(String.Format("Tagname={0} value={1} type=={2}", address, x.ToString(), x.GetType().Name))
                    Dim res As AutomatedSolutions.Win.Comm.Result = Nothing
                    Dim item = New Item(address, length) With {.HWTagType = TagType.AUTO}
                    Dev.BeginWrite(item, x, res, AddressOf WriteCompleteSingle, item)
                End If
                'AreWrite.Set()
                Return New TesterResult(True)
                'Else
                '    Return New TesterResult(False, "The connection was not set @ Write.")
                'End If
            Catch ex As Exception
                _messageAlert.PublishNewAlarm("PLC not connected", PlcAlertType.Error)
                Return New TesterResult(ex)
            End Try
        End Function

        Private Async Function WriteAsync(address As String, x As Object, Optional length As Integer = 1) As Task(Of TesterResult)
            If x.GetType() = GetType(String) Then
                Throw New ArgumentException($"The object being written to the plc is a string not a plcString. addr:{address} value:{CStr(x)}")
            End If

            Try
                'If _connectionSet Then
                If Not Me._disposedValue Then
                    Debug.Print(String.Format("Tagname={0} value={1} type=={2}", address, x.ToString(), x.GetType().Name))
                    Dim res As AutomatedSolutions.Win.Comm.Result = Nothing
                    Dim item = New Item(address, length) With {.HWTagType = TagType.AUTO}
                    Dim result As AutomatedSolutions.Win.Comm.Result = Nothing
                    Await Task.Factory.FromAsync(Dev.BeginWrite(item, x, res, Nothing, item), AddressOf WriteCompleteSingle)
                    If result IsNot Nothing AndAlso result.IsOK Then
                        Return New TesterResult(True)
                    Else
                        Return New TesterResult(False, "Write result is not ok")
                    End If
                End If
                'Else
                '    Return New TesterResult(False, "The connection was not set @ Write.")
                'End If
            Catch ex As Exception
                _messageAlert.PublishNewAlarm("PLC not connected", PlcAlertType.Error)
                Return New TesterResult(ex)
            End Try
            Return New TesterResult(False)
        End Function

        Private Sub WriteCompleteSingle(ByVal ar As IAsyncResult)
            'If _connectionSet Then
            'AreWriteSingle.WaitOne(2000)
            'AreWriteSingle.Reset()
            If Not Me._disposedValue Then
                Dim res As AutomatedSolutions.Win.Comm.Result = Nothing
                Dim tag As Item = TryCast(ar.AsyncState, Item)
                Try
                    Dim d As Device = Dev 'CType(ar.AsyncState, Device)
                    d.EndWrite(res, ar)
                Catch ex As Exception
                    _messageAlert.PublishNewAlarm("PLC not connected", PlcAlertType.Error)
                    '_connectionSet = False
                End Try

                If res Is Nothing OrElse Not res.IsOK Then
                    If res Is Nothing Then
                        logger.Error("Plc not connected")
                    ElseIf tag IsNot Nothing Then
                        logger.Error("Problem writing to " + tag.HWTagName)
                        _messageAlert.PublishNewAlarm("Problem writing to " + tag.HWTagName, PlcAlertType.Error, 5)
                    Else
                        _messageAlert.PublishNewAlarm(res.EvArgs.Message.ToString, PlcAlertType.Error)
                    End If
                Else
                    _messageAlert.PublishNewAlarm("Saved to plc", PlcAlertType.Message)
                End If
            End If
            'AreWriteSingle.Set()
            'End If
        End Sub

#End Region


#Region "IDisposable Support"
        Private _disposedValue As Boolean 'To detect redundant calls

        Private Sub Dispose(disposing As Boolean)
            'AreWrite.WaitOne(2000)
            'AreWrite.Reset()
            'AreWriteSingle.WaitOne(2000)
            'AreWriteSingle.Reset()
            If Not Me._disposedValue Then
                If disposing Then
                    MyChannel?.Dispose()
                    Dev?.Dispose()
                    MyGroup?.Dispose()
                    'TesterItem?.Dispose()
                End If
            End If
            Me._disposedValue = True
            'AreWriteSingle.Set()
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

        Private Sub OnDeviceError(sender As Object, evArgs As AutomatedSolutions.Win.Comm.DeviceEventArgs)
            ' MessageAlert.PublishNewAlarm(evArgs.Message, ErrorLevel.Error)
        End Sub
    End Class
End Namespace