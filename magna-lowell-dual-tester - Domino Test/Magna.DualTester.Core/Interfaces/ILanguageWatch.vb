Imports Magna.DualTester.Core.Data.Enums

Public Interface ILanguageWatch
    Inherits IWatch(Of LanguageEnum)

    WriteOnly Property SetValue As LanguageEnum
End Interface
