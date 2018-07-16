
Public Class ColorModel
    Inherits PlcColor
    Public Sub New()

    End Sub
    Public Sub New(index As Integer, pcode As String, name As String)
        Me.Index = index
        Me.Pcode = pcode
        Me.Name = name
    End Sub
    Public Sub New(index As Integer, color As PlcColor)
        Me.Index = index
        Me.Pcode = color.Pcode
        Me.Name = color.Name
    End Sub

    Public Property Index As Integer

End Class

Public Class PlcColor
    Public Property Pcode As String = String.Empty
    Public Property Name As String = String.Empty
End Class


Public Class ColorsModel
    Private Const ColorCount = 32
    Public ReadOnly Data(ColorCount - 1) As ColorModel
    Public Sub New()
        Dim count = 0
        For i = 0 To ColorCount - 1
            Data(count) = New ColorModel(i, New PlcColor())
            count += 1
        Next
    End Sub
    Public Sub New(colors As PlcColor())
        Dim count = 0
        For Each c In colors
            Data(count) = New ColorModel(count, c)
            count += 1
        Next
    End Sub
End Class
