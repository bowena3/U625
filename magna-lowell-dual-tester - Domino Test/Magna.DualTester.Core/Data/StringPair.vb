Imports System.Xml.Serialization
Imports Magna.DualTester.Core.Data.Enums

Namespace Data
    ''' <summary>
    ''' This was created to fulfill the need to keep track of colors, sequenceStrings, alarm strings, and part faults.
    ''' </summary>
    ''' <remarks>This isn't very explicit so it should be used with caution</remarks>
    Public Class EnglishSpanishMap
        Inherits IndexMap(Of EnglishSpanish)

        Public Sub New()

        End Sub

        Public Sub New(Id As Integer, Eng As String, Spanish As String)
            Index = Id
            Value = New EnglishSpanish(Eng, Spanish)
        End Sub


        ''' <summary>
        ''' This property is exposed for the datagridview in the settings view
        ''' </summary>
        <XmlIgnore()>
        Public Property English As String
            Get
                Return Value.EnglishString
            End Get
            Set(value As String)
                Me.Value.EnglishString = value
            End Set
        End Property

        ''' <summary>
        ''' This property is exposed for the datagridview in the settings view
        ''' </summary>
        <XmlIgnore()>
        Public Property Spanish As String
            Get
                Return Value.SpanishString
            End Get
            Set(value As String)
                Me.Value.SpanishString = value
            End Set
        End Property

        Public Class EnglishSpanish
            Public Sub New()

            End Sub
            Public Sub New(en As String, spanish As String)
                EnglishString = en
                SpanishString = spanish
            End Sub

            Public Function GetString(lang As LanguageEnum) As String
                Return If(lang = LanguageEnum.English, EnglishString, SpanishString)
            End Function

            ''' <summary>
            ''' <c>Left string is used for the English string in all except <c>Colors</c> where it is <c>Pcode</c></c>
            ''' </summary>
            Public Property EnglishString As String

            ''' <summary>
            ''' <c>RightString</c> is used for the Spanish string in all cases except <c>Colors</c> where it is <c>Color</c>
            ''' </summary>
            Public Property SpanishString As String
        End Class
    End Class
End Namespace