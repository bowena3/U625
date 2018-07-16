Namespace TesterApi

    Public Class Udt_Nest
        Public NestIdx As Integer
        Public SeqVal As Integer
        Public AlarmVal As Integer
        Public Logitems As New Udt_Logvalues

        'changed to partoptions
        Public PartInfo As New Udt_PartInformation

        Public PartOptions As New Udt_PartOptions

        'added glass options
        Public GlassOptions As New Udt_GlassOptions

        Public AlgFeatures As New Udt_AnalogItems
        Public ModeRequest As Integer
        Public ModeStatus As Integer
        Public ManualOps As New Udt_Manual_Operators
        Public CalibrationChangeId As Integer
        Public TargetColor As Integer
        Public DetectedColor As Integer
        Public AlarmBits() As Boolean = New Boolean(127) {}
        Public PartFltBits() As Boolean = New Boolean(127) {}
        Public Py_Status As Integer
        Public CurrentMirrorCal As New Udt_Mcal
        Public CalEdit As New Udt_Mcal
        Public SetAngleCal As Integer
        Public CurrentGlassType As Integer '1 = left 2=right
    End Class

    'Public Class Model_Nest
    '    Public NestIdx As Integer
    '    Public SeqVal As Integer
    '    Public AlarmVal As Integer
    '    Public Logitems As New Model_Logvalues
    '    Public PartOptions As New Model_PartOptions
    '    Public GlassOptions As New Model_GlassOptions
    '    Public AlgFeatures As New Model_AnalogItems
    '    Public ModeRequest As Integer
    '    Public ModeStatus As Integer
    '    Public ManualOps As New Model_Manual_Operators
    '    Public CalibrationChangeId As Integer
    '    Public TargetColor As Integer
    '    Public DetectedColor As Integer
    '    Public AlarmBits() As Boolean = New Boolean(127) {}
    '    Public PartFltBits() As Boolean = New Boolean(127) {}
    '    Public Py_Status As Integer
    '    Public CurrentMirrorCal As New Model_Mcal
    '    Public CalEdit As New Model_Mcal
    '    Public SetAngleCal As Integer
    '    Public CurrentGlassType As Integer '1 = left 2=right
    'End Class
End Namespace