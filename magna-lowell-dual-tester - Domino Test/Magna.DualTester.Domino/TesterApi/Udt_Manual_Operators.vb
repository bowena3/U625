Imports Magna.DualTester.Plc.Core.PlcStrings

Namespace TesterApi

    Public Class Udt_Manual_Operators
        Public Clamps As Integer 'Bit 0=Fixture Release1,Bit 1=FixtureLock2,Bit 2=Bezel Clamp Adv3,Bit 3=Bezel Clamp Ret4,Bit 4=Connector5 Release,Bit 5=Connector6 Lock ,Bit 6=Part Vacuum On,Bit 7=Connector10 Release,Bit 8=Connector10 Lock
        Public Tooling As Integer
        Public Defog As Integer '	Decimal	Bit0=on	Read/Write	4	0
        Public MirrrorActuator As Integer '	Decimal	Bit0=Up,Bit1=Down,Bit2=Inboard,Bit3=Outboard	Read/Write	5	0
        Public TurnSignal As Integer '	Decimal	Bit0=on	Read/Write	6	0
        Public Gi As Integer '	Decimal	Bit0=on	Read/Write	7	0
        Public Pfold As Integer '	Decimal	Biit0= extend,Bit1=Retract	Read/Write	8	0
        Public MemoryCr As Integer '	Decimal	Bit0=on	Read/Write	9	0
        Public CameraItems As Integer '	Decimal	Bit0=on	Read/Write	10	0
        Public GlassPull As Integer '	Decimal	Bit0=on	Read/Write	11	0
        Public ColorCmds As Integer '	Decimal	Bit0=on	Read/Write	12	0
        Public BZI As Integer       '	Decimal	Bit0=on	Read/Write	13	0
        Public GroundCheck As Integer   '	Decimal	Bit0=on	Read/Write	14	0
        Public Pcode As New PlcString_82 '	Decimal	Bit0=on	Read/Write	15	0
        Public JoyStick As Integer
        Public PullTest As Integer
        Public TrapDoorProbe As Integer
        Public Ec As Integer
        Public CargoLamp As Integer
        Public Oats As Integer
    End Class

    'Public Class Model_Manual_Operators
    '    Public Clamps As Integer 'Bit 0=Fixture Release,Bit 1=FixtureLock,Bit 2=Bezel Clamp Adv,Bit 3=Bezel Clamp Ret,Bit 4=Connector6 Release,Bit 5=Connector6 Lock ,Bit 6=Part Vacuum On,Bit 7=Connector10 Release,Bit 8=Connector10 Lock
    '    Public Tooling As Integer
    '    Public Defog As Integer '	Decimal	Bit0=on	Read/Write	4	0
    '    Public MirrrorActuator As Integer '	Decimal	Bit0=Up,Bit1=Down,Bit2=Inboard,Bit3=Outboard	Read/Write	5	0
    '    Public TurnSignal As Integer '	Decimal	Bit0=on	Read/Write	6	0
    '    Public Gi As Integer '	Decimal	Bit0=on	Read/Write	7	0
    '    Public Pfold As Integer '	Decimal	Biit0= extend,Bit1=Retract	Read/Write	8	0
    '    Public MemoryCr As Integer '	Decimal	Bit0=on	Read/Write	9	0
    '    Public CameraItems As Integer '	Decimal	Bit0=on	Read/Write	11	0
    '    Public GlassPull As Integer '	Decimal	Bit0=on	Read/Write	11	0
    '    Public ColorCmds As Integer '	Decimal	Bit0=on	Read/Write	11	0
    '    Public BZI As Integer
    '    Public GroundCheck As Integer
    '    Public Pcode As String '	Decimal	Bit0=on	Read/Write	11	0
    '    Public JoyStick As Integer
    '    Public PullTest As Integer
    '    Public TrapDoorProbe As Integer
    '    Public Ec As Integer
    '    Public CargoLamp As Integer
    '    Public Oats As Integer
    'End Class
End Namespace