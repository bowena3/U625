Imports Magna.DualTester.Core.Data.Enums
Public Class LanguageWatch
    Implements ILanguageWatch

    Private Property _currentLanguage As LanguageEnum

    Public ReadOnly Property CurrentLanguage As LanguageEnum Implements ILanguageWatch.CurrentValue
        Get
            Return _currentLanguage
        End Get
    End Property

    Public WriteOnly Property SetValue As LanguageEnum Implements ILanguageWatch.SetValue
        Set(value As LanguageEnum)
            _currentLanguage = value
        End Set
    End Property

    Public Event LanguageChange As Action(Of LanguageEnum) Implements ILanguageWatch.ValueChanged
End Class
