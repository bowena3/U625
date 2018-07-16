Imports System.IO.Ports
Imports System.Text

'Imports Magna.DualTester.Plc.Core

Namespace Tools
    Public Interface IBarcodeScanner
        Event NewScan As EventHandler(Of BarCodeScanResults)
    End Interface
    Public Class BarCodeScanResults
        Public Property ScanValue As String
        Public ReadOnly Property LowerScanValue As String
            Get
                Return ScanValue.ToLowerInvariant()
            End Get
        End Property

        Public Sub New(val As String)
            Me.ScanValue = val
        End Sub

    End Class

    Public Class BarCodeScanner
        Implements IBarcodeScanner, IStartupService

        Public Event NewScan As EventHandler(Of BarCodeScanResults) Implements IBarcodeScanner.NewScan
        Public Event StartupResult As EventHandler(Of StartupEventResult) Implements IStartupService.StartupResult
        Private Property Connected As Boolean

        Public ReadOnly Property ServiceName As String Implements IStartupService.ServiceName
            Get
                Return "Barcode Scanner"
            End Get
        End Property

        Public Property Status As StartupEventResult Implements IStartupService.Status

        Private _portBarcode As SerialPort
        Private _cfg As ICfg


        Public Sub New(cfg As ICfg)
            _cfg = cfg
            Task.Run(AddressOf Startup)
        End Sub

        Private Sub Startup()
            Try
                If My.Computer.Ports.SerialPortNames.Contains(_cfg.ReadConfig().DeviceBarcodeScannerPort) Then
                    _portBarcode = New SerialPort(_cfg.ReadConfig().DeviceBarcodeScannerPort, 9600, Parity.None, 8, StopBits.One) With {.NewLine = ControlChars.Cr,
                                                                                                                                        .ReadTimeout = 1000}
                    _portBarcode.Open()
                    AddHandler _portBarcode.DataReceived, AddressOf OnDataRecieved
                    Connected = _portBarcode.IsOpen()
                    Status = New StartupEventResult(True)
                Else
                    Status = New StartupEventResult(False, $"Serial Port ""{_cfg.ReadConfig().DeviceBarcodeScannerPort}"" was not found for the barcode")
                End If
            Catch ex As IO.IOException
                Status = New StartupEventResult(False, "IOException Could not open serial port")
            Catch ex As System.ComponentModel.Win32Exception
                Status = New StartupEventResult(False, "Could not find serial port")
            Catch ex As Exception
                Status = New StartupEventResult(False, "Barcode Scanner Port Not Set")
            End Try
            RaiseEvent StartupResult(Me, Status)
        End Sub

        ''' <summary>
        ''' This function is called when the barcode scanner receives data.
        ''' </summary>   
        Private Sub OnDataRecieved(sender As Object, e As SerialDataReceivedEventArgs)
            Dim finalScan = String.Empty
            Dim buffer As New StringBuilder()

            Dim SW As New Stopwatch()
            SW.Start()
            While SW.Elapsed.Milliseconds <= 75
                buffer.Append(_portBarcode.ReadExisting())
                Debug.Print(buffer.ToString())
            End While
            SW.Stop()
            finalScan = buffer.ToString()


            If finalScan <> String.Empty Then
                'if first char is a z then its a part #
                'otherwise it might be a badge number
                'Dim IsUserIdScan = Not finalScan.ToLowerInvariant()(0) = CChar("z")
                RaiseEvent NewScan(Me, New BarCodeScanResults(finalScan))
            End If
        End Sub

    End Class
End Namespace