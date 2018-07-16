Namespace Data

    ''' <summary>
    ''' This is the source file for the applications config file. There is no error handling in this file it should 
    ''' be taken care of on the form.
    ''' </summary>
    <Serializable()>
    Public MustInherit Class CfgSettings

        Public Sub New()

        End Sub
        Public Sub New(stringdefaults As IStringDefaults)
            Const max = 127
            SequenceStrings.AddRange(BuildStringPairList(stringdefaults.DefaultSequenceStrings, "Step", max))
            MachineAlarms.AddRange(BuildStringPairList(stringdefaults.DefaultMachineAlarms, "Alarm", max))
            PartAlarms.AddRange(BuildStringPairList(stringdefaults.DefaultPartAlarms, "PartAlarm", max))
        End Sub

        'Public Property IdName As String = String.Empty
        'Public Property IdAssetNumber As String = String.Empty


        Public Property DeviceBarcodeScannerPort As String = "COM1"
        Public Property DevicePlcIp As String = "10.69.108.254"
        Public Property MachineAlarms As New List(Of EnglishSpanishMap)
        Public Property PartAlarms As New List(Of EnglishSpanishMap)
        Public Property SequenceStrings As New List(Of EnglishSpanishMap)

        Public Property CfgSet As Boolean = False

        Protected Shared Function BuildStringPairList(input As Dictionary(Of Integer, String), defaultPrefix As String, maxEntries As Integer) As IEnumerable(Of EnglishSpanishMap)
            Dim output As New List(Of EnglishSpanishMap)
            For x As Integer = 0 To maxEntries
                If (input.ContainsKey(x)) Then
                    Dim ss = input(x)
                    output.Add(New EnglishSpanishMap(x, ss, ss))
                Else
                    output.Add(New EnglishSpanishMap(x, $"({defaultPrefix}) {x}", $"({defaultPrefix}) {x}"))
                End If
            Next
            Return output
        End Function

    End Class
End Namespace
