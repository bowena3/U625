Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential)>
Public Class Udt_Colors

    Private Const ColorCount = 32
    Public ReadOnly Data(ColorCount - 1) As Udt_Color

    Public Sub New()
        For x As Integer = 0 To Data.Count - 1
            Data(x) = New Udt_Color()
        Next
    End Sub
End Class
