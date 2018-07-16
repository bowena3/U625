Public Interface IPlcDataRepo
    Event TesterChanged As Action
    ReadOnly Property GetPartNumber As String
    ReadOnly Property GetToteTarget As Integer
    ReadOnly Property GetIsServicePart As Boolean
    ReadOnly Property PrnStringReplacements As IDictionary(Of String, String)
    ReadOnly Property Nest1SequenceStep As Integer
    ReadOnly Property Nest2SequenceStep As Integer
    ReadOnly Property User As User
    ReadOnly Property ToteCount As Integer
    ReadOnly Property ToteTarget As Integer
    ReadOnly Property Nest1ResultCode As Integer
    ReadOnly Property Nest2ResultCode As Integer
    ReadOnly Property Nest1ModeStatus As NestModeStatus
    ReadOnly Property Nest2ModeStatus As NestModeStatus
End Interface