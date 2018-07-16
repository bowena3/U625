Imports System.Threading
Imports System.Threading.Tasks
Imports DualTester
Imports DualTester.Data
Imports DualTester.Tools
Imports Magna.DualTester.Plc.Core
Imports Magna.DualTester.Plc.Core.Tools

Public Class Form1
    Implements ICfg

    'Dim asc As IPlc

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnClosing(e As System.ComponentModel.CancelEventArgs)
        'Asc.Dispose()
        MyBase.OnClosing(e)
    End Sub

    Private Async Sub BtnReadAsync_Click(sender As Object, e As EventArgs) Handles BtnReadAsync.Click
        Using asc = New AsConnection(Me)
            UpdateGridview(Await asc.TestUdtAsync())
        End Using
    End Sub
    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
        Using Asc = New AsConnection(Me)
            UpdateGridview(Asc.TestUdt())
        End Using
    End Sub



    Private Sub UpdateGridview(results As IEnumerable(Of UdtTest))
        If InvokeRequired Then
            Invoke(Sub() UpdateGridview(results))
            Return
        End If
        ResultBindingSource.DataSource = results.ToList()
        ResultBindingSource.ResetBindings(False)
    End Sub

    Public Function ReadConfig() As CfgSettings Implements ICfg.ReadConfig
        Return New CfgSettings(True) With {.DevicePlcIp = TxtIp.Text}
    End Function

    Public Function WriteConfig(cfg As CfgSettings) As Boolean Implements ICfg.WriteConfig
        Throw New NotImplementedException()
    End Function


End Class
