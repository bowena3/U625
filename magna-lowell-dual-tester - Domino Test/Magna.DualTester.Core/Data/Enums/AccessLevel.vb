Namespace Data.Enums
    ''' <summary>
    ''' This class represents the user levels listed in the plc.
    ''' </summary>
    Public Enum AccessLevel
        None = 0
        [Operator] = 1
        Supervisor = 20
        Tech = 30
        Engineer = 40
        Admin = 50

    End Enum
End Namespace