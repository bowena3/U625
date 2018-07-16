Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Tools

Public Class LoadingDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        TryClose(True)
    End Sub

    'Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    '    Me.Close()
    'End Sub

    Dim _scannerStat As StartupEventResult
    Dim _plcStat As StartupEventResult

    'Dim _t3 As Boolean = False
    Public Sub New(scanner As BarCodeScanner, plc As IPlc)
        InitializeComponent()
        'SetBarcodeStatus(scanner.Status)
        ' SetPlcStatus(plc.Status)
    End Sub

    Private Sub SetBarcodeStatus(str As StartupEventResult)
        Dim run = Sub()
                      _scannerStat = str
                      LblBarcodeStat.Text = _scannerStat.Message
                      PicBarcode.Image = ImageList1.Images(If(str.Ok, 1, 2))
                      TryClose()

                  End Sub
        If Me.InvokeRequired Then
            Invoke(run)
        Else
            run()
        End If
        Timer1.Enabled = True
        start = Now
    End Sub

    Private Sub SetPlcStatus(str As StartupEventResult)
        Dim run = Sub()
                      _plcStat = str
                      LblPlcStatus.Text = _plcStat.Message 'str.Message
                      PicPlc.Image = ImageList1.Images(If(_plcStat.Ok, 1, 2))
                      TryClose()
                  End Sub
        If Me.InvokeRequired Then
            Invoke(run)
        Else
            run()
        End If
        Timer1.Enabled = True
        start = Now
    End Sub

    'Public Sub SetOtherStatus(str As String)
    '    Dim run = Sub()
    '                  LblOther.Text = str
    '                  PicOther.Image = ImageList1.Images(Check(str))
    '                  _t3 = (Check(str) = 1)
    '                  TryClose()
    '              End Sub
    '    If Me.InvokeRequired Then
    '        Invoke(run)
    '    Else
    '        run()
    '    End If
    '    Timer1.Enabled = True
    '    start = Now
    'End Sub

    ''' <summary>
    ''' If the string is null or empty then it gets the green bullet picture. If the string is somthing else return the
    ''' red bullet picture.
    ''' </summary>
    ''' <remarks>This could be made fancier but I don't feel the need to dive into it.</remarks>
    Private Function Check(str As String) As Integer
        Return If(String.IsNullOrWhiteSpace(str), 1, 2) 'ImageList1.Images(If(t, 1, 2))
    End Function

    Private Sub TryClose(Optional ignore As Boolean = False)
        If _scannerStat.Ok AndAlso _plcStat.Ok OrElse ignore Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Dim start As DateTime

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Now - start) > New TimeSpan(0, 0, 10) Then
            Me.Close()
        End If
    End Sub

End Class