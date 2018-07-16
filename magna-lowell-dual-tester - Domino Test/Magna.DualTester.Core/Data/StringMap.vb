Imports Magna.DualTester.Core.Data
Imports Magna.DualTester.Core.Data.Enums

Public Class StringMap
    Inherits IndexMap(Of String)
    Public Sub New(index As Integer, lang As LanguageEnum, stringPairs As IList(Of EnglishSpanishMap))
        Me.Index = index

        If index > stringPairs.Count() Or stringPairs.Count = 0 Then
            IndexOutOfRange = True
        Else
            Dim item = stringPairs(index)
            Value = item.Value.GetString(lang)
        End If
    End Sub
End Class