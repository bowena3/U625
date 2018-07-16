
''' <summary>
''' This is used when the event <c>BaseView.Saved</c> is called. It stores the Plc address and the Udt item to write. 
''' </summary>
Public Class SaveEventArgs

    Public ReadOnly Value As Object 'holds data
    Public ReadOnly Address As String
    Public ReadOnly Message As String
    Public ReadOnly Length As Integer = 1

    Public Sub New(address As String, value As Object, Optional length As Integer = 1, Optional message As String = Nothing)
        Me.Address = address
        Me.Value = value
        Me.Message = message
        Me.Length = length
        'If value.GetType Is GetType(AutomatedSolutions.Win.Comm.AB.Logix.Item) Then
        '    Throw New Exception("Logix item in the wrong parameter")
        'End If
    End Sub
End Class