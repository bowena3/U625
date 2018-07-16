Public Interface IPlcCfgFactory
    Function GetCfg() As IPlcCfg
End Interface

Public Interface IPlcCfg
    ReadOnly Property DevicePlcIp As String
    ReadOnly Property TesterAddress As String
    ReadOnly Property Activity_To_Buffer_Event_Message As String
End Interface
