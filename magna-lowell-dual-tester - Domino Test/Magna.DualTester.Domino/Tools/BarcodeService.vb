Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data.Enums
Imports Magna.DualTester.Core.Tools

Public Class BarcodeService

    Private ReadOnly _scanner As IBarcodeScanner
    Private ReadOnly _uwatch As IUserWatch
    Private ReadOnly _plc As IPlc
    Private ReadOnly _msgsvc As IMessageAlertService
    Private ReadOnly _plcrepo As IPlcDataRepo

    Public Sub New(scanner As IBarcodeScanner,
                   uwatch As IUserWatch,
                   plc As IPlc,
                   msgsvc As IMessageAlertService,
                   plcrepo As IPlcDataRepo)
        _scanner = scanner
        _uwatch = uwatch
        _plc = plc
        _plcrepo = plcrepo
        _msgsvc = msgsvc
        AddHandler _scanner.NewScan, AddressOf NewScan

    End Sub

    Private Sub NewScan(sender As Object, scan As BarCodeScanResults)
        Const minValForPartScan = 20
        If scan.LowerScanValue.StartsWith("sldta-") Then
            _plc.ManualWriteString82("TestApi.", scan.ScanValue)
        ElseIf scan.LowerScanValue.StartsWith("op") Then
            _uwatch.LogIn(scan.ScanValue.Substring(2)) '.TrimStart("OP"))
        Else
            If _uwatch.CheckCurrentUserPermission(AccessLevel.Supervisor) Then
                If _plcrepo.Nest1SequenceStep <= minValForPartScan AndAlso _plcrepo.Nest2SequenceStep <= minValForPartScan Then
                    _plc.ManualWriteString82(PlcConstants.Pn_To_Find, scan.ScanValue)
                Else
                    Dim str As String = If(_plcrepo.Nest1SequenceStep > minValForPartScan, "Nest1", String.Empty)
                    str += If(_plcrepo.Nest2SequenceStep > minValForPartScan, "Nest2", String.Empty)
                    _msgsvc.PublishNewAlarm(str + " SeqVal Is above " + minValForPartScan.ToString(), ErrorLevel.Alert)
                End If
            Else
                _msgsvc.PublishNewAlarm("User Access Level Is To low", ErrorLevel.Alert)
            End If
        End If
    End Sub

End Class