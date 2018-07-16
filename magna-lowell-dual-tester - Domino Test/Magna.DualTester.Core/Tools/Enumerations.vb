Public Enum Quadrant
    None
    Up
    Down
    IB
    OB
End Enum

Public Enum GlassTypeEnum
    none
    LH_FLAT
    RH_FLAT
    LH_CVX
    RH_CVX
End Enum

<Flags()>
Public Enum MactFlags
    None = 0
    Up = 1
    Down = 2
    Inboard = 4
    OutBoard = 8
    Center = 16
End Enum
