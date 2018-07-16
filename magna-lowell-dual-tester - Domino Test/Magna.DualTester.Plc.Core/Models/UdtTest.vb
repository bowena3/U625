Imports Magna.DualTester.Core
Imports Magna.DualTester.Plc.Core

Public Class UdtTest
    Inherits TesterResult
    Implements IUdtTest

    Public Sub New(address As String, typeName As String, success As Boolean, message As String)
        MyBase.New(success, message)
        Me.Address = address
        Me.TypeName = typeName
    End Sub
    Public Sub New(address As String, typeName As String, res As TesterResult)
        MyBase.New(res.Success, res.Message)
        Me.Address = address
        Me.TypeName = typeName
    End Sub

    Public Property Address As String Implements IUdtTest.Address
    Public Property TypeName As String Implements IUdtTest.TypeName

    Private Property IUdtTest_Success As Boolean Implements IUdtTest.Success
        Get
            Return Success
        End Get
        Set(value As Boolean)
            Success = value
        End Set
    End Property
    Private Property IUdtTest_Message As String Implements IUdtTest.Message
        Get
            Return Message
        End Get
        Set(value As String)
            Message = value
        End Set
    End Property
End Class

Public Class UdtTest(Of T)
    Inherits UdtTest
    Implements IUdtTest
    Public Sub New(address As String, typeName As String, success As Boolean, message As String)
        MyBase.New(address, typeName, success, message)
        Me.Address = address
        Me.TypeName = typeName
    End Sub
    Public Sub New(address As String, typeName As String, res As TesterResult)
        MyBase.New(address, typeName, res)
    End Sub

End Class

