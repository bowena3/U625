Imports System.Runtime.InteropServices
Imports Magna.DualTester.Plc.Core.PlcStrings

<StructLayout(LayoutKind.Sequential)>
Public Class Udt_Color
    Public Pcode As New PlcString_82
    Public Name As New PlcString_82

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim tmpcolor As Udt_Color = TryCast(obj, Udt_Color)
        If Not IsNothing(tmpcolor) Then
            If tmpcolor.Name.ToString() <> Me.Name.ToString() OrElse tmpcolor.Pcode.ToString() <> Me.Pcode.ToString() Then
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0}-{1}", Me.Pcode.ToString(), Me.Name.ToString())
    End Function
End Class
