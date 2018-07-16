
Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data
Imports Magna.DualTester.Plc.Core

Public Class PlcCfgFactory
    Implements IPlcCfgFactory

    Private ReadOnly _cfg As ICfg

    Public Sub New(cfg As ICfg)
        _cfg = cfg
    End Sub

    Public Function GetCfg() As IPlcCfg Implements IPlcCfgFactory.GetCfg
        Dim c = _cfg.ReadConfig()

        Return New PlcCfg(c.DevicePlcIp, PlcConstants.TesterAddress, PlcConstants.Activity_To_Buffer_Event_Message)
    End Function

    Public Class PlcCfg
        Implements IPlcCfg

        Public Sub New(ip As String, testerAddress As String, ActivityToBufferAddress As String)
            Me.DevicePlcIp = ip
            Me.TesterAddress = testerAddress
            Me.Activity_To_Buffer_Event_Message = ActivityToBufferAddress
        End Sub

        Public ReadOnly Property DevicePlcIp As String Implements IPlcCfg.DevicePlcIp

        Public ReadOnly Property TesterAddress As String Implements IPlcCfg.TesterAddress

        Public ReadOnly Property Activity_To_Buffer_Event_Message As String Implements IPlcCfg.Activity_To_Buffer_Event_Message
    End Class
End Class
