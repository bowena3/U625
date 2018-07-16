
Imports Magna.DualTester.Core
Imports Magna.DualTester.Plc.Core

Public Class ColorMap
    Inherits IndexMap(Of String)
    Public Sub New(index As Integer, colors As ColorsModel)
        Me.Index = index

        If index > colors.Data.Count() Then
            IndexOutOfRange = True
        Else
            Value = colors.Data(index).Name.ToString()
        End If
    End Sub
End Class