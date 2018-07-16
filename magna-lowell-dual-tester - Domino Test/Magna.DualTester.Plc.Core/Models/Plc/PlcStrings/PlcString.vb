Imports System.Runtime.InteropServices
Imports System.Text

Namespace PlcStrings

    <StructLayout(LayoutKind.Sequential)>
    Public MustInherit Class PlcString
        Public len As Int32

        Public data As [Byte]()

        Public Sub New(byteLenth As Integer)
            If byteLenth < 0 Then
                Throw New ArgumentException("The byte length must be greater than or equal to 1. (""byteLenth"" >= 1)")
            End If
            data = New [Byte](byteLenth - 1) {}
        End Sub
        Public Sub New(value As String)
            Me.SetString(value)
        End Sub

        Public Overloads Function ToString() As [String]
            Return ASCIIEncoding.ASCII.GetString(data, 0, len)
        End Function

        Public Sub SetString(s As [String])
            If s Is Nothing Then
                s = ""
            End If
            If s.Length > data.Length Then
                Throw New ArgumentOutOfRangeException("s", "Maximum allowable string length is " & data.Length.ToString() & " bytes")
            End If
            Buffer.BlockCopy(ASCIIEncoding.ASCII.GetBytes(s), 0, data, 0, s.Length)
            len = s.Length
        End Sub
    End Class
End Namespace