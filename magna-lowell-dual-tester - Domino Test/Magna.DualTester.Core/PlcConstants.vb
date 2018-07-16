Public Class PlcConstants

    'Public Shared ReadOnly Property _OFF As String
    '    Get
    '        Return TesterAddress + "OFF"
    '    End Get
    'End Property
    'Public Shared ReadOnly Property _ON As String
    '    Get
    '        Return TesterAddress + "ON"
    '    End Get
    'End Property
    'Public Shared ReadOnly Property Counts_Batch_Count_Down As String
    '    Get
    '        Return TesterAddress + ".Counts.BatchCountDown"
    '    End Get
    'End Property
    'Public Shared ReadOnly Property Counts_Shift_Pass_Count As String
    '    Get
    '        Return TesterAddress + ".Counts.ShiftPassCount"
    '    End Get
    'End Property
    'Public Shared ReadOnly Property Counts_Tote_Count As String
    '    Get
    '        Return TesterAddress + ".Counts.ToteCount"
    '    End Get
    'End Property
    'Public Shared ReadOnly Property Counts_Tote_Target As String
    '    Get
    '        Return TesterAddress + ".Counts.ToteTarget"
    '    End Get
    'End Property
    'Public Shared ReadOnly Property TestApi_Counts_ToteCount As String
    '    Get
    '        Return TesterAddress + ".Counts.ToteCount"
    '    End Get
    'End Property
    Public Shared ReadOnly Property Activity_To_Buffer_Event_Message As String
        Get
            Return TesterAddress + ".ActivityToBuffer.EventMessage"
        End Get
    End Property
    Public Shared ReadOnly Property Counts As String
        Get
            Return TesterAddress + ".Counts"
        End Get
    End Property
    Public Shared ReadOnly Property Log_Setpoint_Change_Trigger As String
        Get
            Return TesterAddress + ".LogSetpointChange.trigger"
        End Get
    End Property
    Public Shared ReadOnly Property Pn_To_Find As String
        Get
            Return TesterAddress + ".PnToFind"
        End Get
    End Property
    Public Shared ReadOnly Property Request_Log_Out As String
        Get
            Return TesterAddress + ".RequestLogOut"
        End Get
    End Property
    Public Shared ReadOnly Property Set_Points As String
        Get
            Return TesterAddress + ".SetPoints"
        End Get
    End Property
    Public Shared ReadOnly Property Shift_Value As String
        Get
            Return TesterAddress + ".ShiftValue"
        End Get
    End Property
    Public Shared ReadOnly Property TestApi_PartInfo_Servce As String
        Get
            Return TesterAddress + ".PartInfo.Servce"
        End Get
    End Property
    Public Shared ReadOnly Property TesterAddress As String
        Get
            Return "TestApi"
        End Get
    End Property
    Public Shared ReadOnly Property User_Badge_Number As String
        Get
            Return TesterAddress + ".User.BadgeNumber"
        End Get
    End Property

End Class
