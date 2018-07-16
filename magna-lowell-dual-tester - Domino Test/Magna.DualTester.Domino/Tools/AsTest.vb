Imports System.Reflection
Imports Magna.DualTester.Core
Imports Magna.DualTester.Domino.TesterApi
Imports Magna.DualTester.Plc.Core

Public Class AsTest
    Implements IAsTest
    Private ReadOnly _msgsvc As IMessageAlertService

    Public Sub New(msgsvc As IMessageAlertService)
        _msgsvc = msgsvc
    End Sub

    Public Function Test(asc As IPlc) As IEnumerable(Of IUdtTest) Implements IAsTest.Test
        Dim sw = Stopwatch.StartNew()

        Dim classesToTest = Assembly.GetAssembly(GetType(Udt_tester)).GetTypes().Where(Function(x) x.Namespace = "UdtData.TesterApi").ToList()

        Dim results = New List(Of UdtTest)()

        results.Add(SendRead(Of Udt_Color)(TagUdt_Color, asc))
        results.Add(SendRead(Of Udt_Colors)("Colors", asc, 32))

        results.Add(SendRead(Of Udt_AlgItem)(TagUdt_AlgItem, asc))
        results.Add(SendRead(Of Udt_AnalogItems)(TagUdt_AnalogItems, asc))

        results.Add(SendRead(Of Udt_Mcal)(TagUdt_Mcal, asc))
        results.Add(SendRead(Of Udt_PartOptions)(TagUdt_PartTestOptions, asc))
        results.Add(SendRead(Of Udt_Logvalues)(TagUdt_Logvalues, asc))
        results.Add(SendRead(Of Udt_Manual_Operators)(TagUdt_ManualOp, asc))
        results.Add(SendRead(Of Udt_Scale)(TagUdt_Scale, asc))
        results.Add(SendRead(Of Udt_Opt_Item)(TagUdt_Opt_Item, asc))
        results.Add(SendRead(Of Udt_LogItem)(TagUdt_LogItem, asc))
        results.Add(SendRead(Of Udt_Nest)(TagUdt_Nest, asc))

        results.Add(SendRead(Of Udt_HeartBeat)(TagUdt_HeartBeat, asc))
        results.Add(SendRead(Of Udt_LgBuffCntrl)(TagUdt_LgBuffCntrl, asc))
        results.Add(SendRead(Of Udt_GlassOptions)(Combine(TagUdt_Nest, "GlassOptions"), asc))
        results.Add(SendRead(Of Udt_PartInformation)(Combine(TagUdt_Nest, "PartInfo"), asc))
        results.Add(SendRead(Of Udt_MinMax)(TagUdt_minMax, asc))
        results.Add(SendRead(Of Udt_Setpoints)(TagUdt_Setpoints, asc))
        results.Add(SendRead(Of Udt_Tester_Counts)(TagUdt_Tester_Counts, asc))
        results.Add(SendRead(Of Udt_LogReq)(TagUdt_LogReq, asc))
        results.Add(SendRead(Of Udt_UserStatus)(TagUdt_User_Status, asc))
        results.Add(SendRead(Of Udt_User)(TagUdt_User, asc))

        results.Add(SendRead(Of Udt_Activity)(Combine(Tester, "ActivityLogQueItem"), asc))
        results.Add(SendRead(Of Udt_tester)(Tester, asc))

        If classesToTest.Count > results.Count Then

            Dim testedTypes = results.Select(Function(y)
                                                 Dim ytype = y.GetType()
                                                 Return ytype.GenericTypeArguments.First
                                             End Function).ToList()

            Dim z = classesToTest.Where(Function(x)
                                            For Each t In testedTypes
                                                If t = x Then
                                                    Return False
                                                End If
                                            Next
                                            Return True
                                        End Function)

            For Each r In z
                Debug.Print(r.ToString())
            Next

            Throw New Exception("Did not test all udts")
        End If

        If results.All(Function(x) x.Success) Then
            _msgsvc.PublishNewAlarm("UDT TEST PASSED", ErrorLevel.Message)
        End If
        sw.Stop()
        Debug.Print($"UDT Test {sw.ElapsedMilliseconds} ms")
        Return results
    End Function

    Public Async Function TestAsync(asc As IPlc) As Task(Of IEnumerable(Of IUdtTest)) Implements IAsTest.TestAsync

        Dim sw = Stopwatch.StartNew()
        Dim classesToTest = Assembly.GetAssembly(GetType(Udt_Colors)).GetTypes().Where(Function(x) x.Namespace = "UdtData.TesterApi").ToList()

        Dim results = New List(Of Task(Of IUdtTest))() From {SendReadAsync(Of Udt_Color)(TagUdt_Color, asc),
                                                                SendReadAsync(Of Udt_Colors)("Colors", asc, 32),
                                                                SendReadAsync(Of Udt_AlgItem)(TagUdt_AlgItem, asc),
                                                                SendReadAsync(Of Udt_AnalogItems)(TagUdt_AnalogItems, asc),
                                                                SendReadAsync(Of Udt_Mcal)(TagUdt_Mcal, asc),
                                                                SendReadAsync(Of Udt_PartOptions)(TagUdt_PartTestOptions, asc),
                                                                SendReadAsync(Of Udt_Logvalues)(TagUdt_Logvalues, asc),
                                                                SendReadAsync(Of Udt_Manual_Operators)(TagUdt_ManualOp, asc),
                                                                SendReadAsync(Of Udt_Scale)(TagUdt_Scale, asc),
                                                                SendReadAsync(Of Udt_Opt_Item)(TagUdt_Opt_Item, asc),
                                                                SendReadAsync(Of Udt_LogItem)(TagUdt_LogItem, asc),
                                                                SendReadAsync(Of Udt_Nest)(TagUdt_Nest, asc),
                                                                SendReadAsync(Of Udt_HeartBeat)(TagUdt_HeartBeat, asc),
                                                                SendReadAsync(Of Udt_LgBuffCntrl)(TagUdt_LgBuffCntrl, asc),
                                                                SendReadAsync(Of Udt_GlassOptions)(Combine(TagUdt_Nest, "GlassOptions"), asc),
                                                                SendReadAsync(Of Udt_PartInformation)(TagUdt_partInformation, asc),
                                                                SendReadAsync(Of Udt_MinMax)(TagUdt_minMax, asc),
                                                                SendReadAsync(Of Udt_Setpoints)(TagUdt_Setpoints, asc),
                                                                SendReadAsync(Of Udt_Tester_Counts)(TagUdt_Tester_Counts, asc),
                                                                SendReadAsync(Of Udt_LogReq)(TagUdt_LogReq, asc),
                                                                SendReadAsync(Of Udt_UserStatus)(TagUdt_User_Status, asc),
                                                                SendReadAsync(Of Udt_User)(TagUdt_User, asc),
                                                                SendReadAsync(Of Udt_Activity)(Combine(Tester, "ActivityLogQueItem"), asc),
                                                                SendReadAsync(Of Udt_tester)(Tester, asc)}

        Await Task.WhenAll(results)
        Dim passed = results.Where(Function(x) x.Result.Success).ToList()
        Dim failed = results.Where(Function(x) Not x.Result.Success).ToList()
        Dim finalResults = results.Select(Function(x) x.Result)

        'If classesToTest.Count <> finalResults.Count Then

        '    Dim testedTypes = finalResults.Select(Function(y) y.GetType().GenericTypeArguments.First).ToList()

        '    Dim z = classesToTest.Where(Function(x)
        '                                    For Each t In testedTypes
        '                                        If t = x Then
        '                                            Return False
        '                                        End If
        '                                    Next
        '                                    Return True
        '                                End Function)

        '    For Each r In z
        '        Debug.Print(r.ToString())
        '    Next

        '    Throw New Exception("Did not test all udts")
        'End If

        If finalResults.All(Function(x) x.Success) Then
            _msgsvc.PublishNewAlarm("UDT TEST PASSED", ErrorLevel.Message)
        End If
        sw.Stop()
        Debug.Print($"UDT Test Async {sw.ElapsedMilliseconds}ms")
        Return finalResults
    End Function

    Private Shared Function Combine(ParamArray addresses As String()) As String
        Return String.Join(".", addresses)
    End Function

    Const Nest = "Nest1"
    Const CalibrationChange = "CalibrationChange"
    Const Mcal = "CurrentMirrorCal"
    Const PartOptions = "PartOptions"
    Const LogValues = "Logitems"
    Const SetPoints = "SetPoints"
    ReadOnly Tester As String = PlcConstants.TesterAddress

    '----------------------------------------------------------------------------
    ReadOnly TagUdt_Nest As String = Combine(Tester, Nest)

    ReadOnly TagUdt_AnalogItems As String = Combine(Tester, CalibrationChange)

    '----------------------------------------------------------------------------
    ReadOnly TagUdt_Mcal As String = Combine(Tester, Nest, Mcal)

    ReadOnly TagUdt_PartTestOptions As String = Combine(Tester, Nest, PartOptions)
    ReadOnly TagUdt_Logvalues As String = Combine(Tester, Nest, LogValues)
    ReadOnly TagUdt_ManualOp As String = Combine(Tester, Nest, "ManualOps")

    '----------------------------------------------------------------------------
    ReadOnly TagUdt_AlgItem As String = Combine(Tester, CalibrationChange, "VertAmp")

    '----------------------------------------------------------------------------
    ReadOnly TagUdt_Scale As String = Combine(Tester, Nest, Mcal, "H")

    ReadOnly TagUdt_Opt_Item As String = Combine(Tester, Nest, PartOptions, "Zebra")
    ReadOnly TagUdt_LogItem As String = Combine(Tester, Nest, LogValues, "MirrorMemAtUp")

    '----------------------------------------------------------------------------
    ReadOnly TagUdt_HeartBeat As String = Combine(Tester, "Daq_Hb")

    ReadOnly TagUdt_LgBuffCntrl As String = Combine(Tester, "LogBuffer")
    ReadOnly TagUdt_partInformation As String = Combine(Tester, Nest, "PartInfo")
    ReadOnly TagUdt_Setpoints As String = Combine(Tester, SetPoints)
    ReadOnly TagUdt_Tester_Counts As String = Combine(Tester, "Counts")
    ReadOnly TagUdt_User As String = Combine(Tester, "User")
    ReadOnly TagUdt_User_Status As String = Combine(Tester, "User", "Status")
    ReadOnly TagUdt_LogReq As String = Combine(Tester, "LogSetpointChange")
    ReadOnly TagUdt_Activity As String = Combine(Tester, "ActivityToBuffer")

    '----------------------------------------------------------------------------
    ReadOnly TagUdt_minMax As String = Combine(Tester, SetPoints, "ActuatorAmps")

    '----------------------------------------------------------------------------

    ReadOnly TagUdt_Color As String = "Colors[0]"

    Private Function SendRead(Of T As {Class, New})(tag As String, asc As IPlc, Optional length As Integer = 1) As UdtTest(Of T)
        Try
            Dim result As TesterResult(Of T) = asc.Read(Of T)(tag, length)
            'result.Message = $"{tag} - {result.Message}"
            Return New UdtTest(Of T)(tag, GetType(T).Name, result)
        Catch ex As Exception
            Return New UdtTest(Of T)(tag, GetType(T).Name, False, "Bad Read")
        End Try
    End Function

    'Shared count As Integer = 0
    Private Async Function SendReadAsync(Of T As {Class, New})(tag As String, asc As IPlc, Optional length As Integer = 1) As Task(Of IUdtTest)
        'count += 1
        'Dim c = count
        Try
            Dim result = Await asc.ReadAsync(Of T)(tag, length)
            Return New UdtTest(Of T)(tag, GetType(T).Name, result)
        Catch ex As Exception
            Return New UdtTest(Of T)(tag, GetType(T).Name, False, "Bad Read")
        End Try
    End Function

End Class

'Public Class UdtTest
'    Inherits TesterResult
'    Public Sub New(address As String, typeName As String, success As Boolean, message As String)
'        MyBase.New(success, message)
'        Me.Address = address
'        Me.TypeName = typeName
'    End Sub
'    Public Sub New(address As String, typeName As String, res As TesterResult)
'        MyBase.New(res.Success, res.Message)
'        Me.Address = address
'        Me.TypeName = typeName
'    End Sub

'    Public Property Address As String
'    Public Property TypeName As String

'End Class