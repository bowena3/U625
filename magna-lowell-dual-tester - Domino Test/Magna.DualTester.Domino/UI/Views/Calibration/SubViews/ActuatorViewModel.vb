Imports Magna.DualTester.Domino.TesterApi

Public Class ActuatorViewModel

    Public Sub New(nestid As Integer, nest As Udt_Nest)
        If nest Is Nothing Then
            Throw New ArgumentNullException(NameOf(nest))
        End If
        If Not {1, 2}.Contains(nestid) Then
            Throw New Exception("nest id not set")
        End If
        Me.NestId = nestid
        Me.Nest = nest
    End Sub

    Public Property NestId As Integer
    Public Property Nest As Udt_Nest

End Class