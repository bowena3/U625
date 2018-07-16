Namespace TesterApi

    Public Class Udt_UserStatus
        Public Temp_1st As Boolean
        Public Temp_3rd As Boolean
        Public Operator_1st As Boolean
        Public Operator_3rd As Boolean

        Public Supervisor As Boolean
        Public Maint As Boolean
        Public Engineer As Boolean
        Public Admin As Boolean

        Public TrainingDocumentsNeeded As Boolean
        Public QualityItemNeeded As Boolean
        Public LoggedIn As Boolean
        Public ErgoTimedOut As Boolean

        Public TrainingHoursNeeded As Boolean
        Public TrainingComplete As Boolean
        Public ErgoByPassedAndActive As Boolean
        Public TrainingByPassedAndActive As Boolean
    End Class

End Namespace