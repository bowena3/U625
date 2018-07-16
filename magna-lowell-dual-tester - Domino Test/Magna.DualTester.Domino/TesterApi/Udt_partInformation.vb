Imports Magna.DualTester.Plc.Core.PlcStrings

Namespace TesterApi

    Public Class Udt_PartInformation
        Public Pn As New PlcString_82
        Public SvcPn As New PlcString_82
        Public Cpn As New PlcString_82
        Public Desc1 As New PlcString_82
        Public Desc2 As New PlcString_82
        Public PartsPerTote As Integer
        Public Static_Label As New PlcString_82
        Public partColor As New PlcString_82
        Public Pcode As New PlcString_82
        Public ColorId As Integer
        Public SpecialCode As New PlcString_8
        Public Suffix As New PlcString_8
        Public BodyStyleName As New PlcString_82
        Public BodyStyleId As Integer
        Public ContainerType As Integer
        Public LH As Boolean
        Public RH As Boolean
        Public Service As Boolean
        Public RHD As Boolean
        Public ShipWithPFIn As Boolean
        Public PartsPerHourPerPerson As Single

        ' Public DominoPartLoaded As Integer
        'renamed PartOptions
        'Public PartOptions As New Udt_PartOptions
        'Added GlassOptions
        'Public GlassOptions As New Udt_GlassOptions
    End Class

    'Public Class Model_PartInformation
    '    Public Pn As String
    '    Public SvcPn As String
    '    Public Cpn As String
    '    Public Desc1 As String
    '    Public Desc2 As String
    '    Public PartsPerTote As Integer
    '    Public Static_Label As String
    '    Public partColor As String
    '    Public Pcode As String
    '    Public ColorId As Integer
    '    Public SpecialCode As String
    '    Public Suffix As String
    '    Public BodyStyleName As String
    '    Public BodyStyleId As Integer
    '    Public ContainerType As Integer
    '    Public LH As Boolean
    '    Public RH As Boolean
    '    Public Service As Boolean
    '    Public RHD As Boolean
    '    Public ShipWithPFIn As Boolean
    '    Public PartsPerHourPerPerson As Single
    '    Public PartOptions As New Model_PartOptions
    '    Public GlassOptions As New Model_GlassOptions
    'End Class
End Namespace