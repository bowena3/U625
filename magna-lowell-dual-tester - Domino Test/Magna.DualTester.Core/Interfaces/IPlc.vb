Imports System.Threading.Tasks


Public Interface IPlc(Of TUdtTester As {New, Class})
    Inherits IPlc
    Event TesterChanged As Action(Of TUdtTester)
    ReadOnly Property TesterData As TUdtTester
End Interface

Public Interface IPlc
    Inherits IDisposable, IStartupService
    ReadOnly Property Colors As ColorsModel
    Function TestUdtAsync() As Task(Of IEnumerable(Of IUdtTest))
    Function TestUdt() As IEnumerable(Of IUdtTest)
    ' Property InitStat As TesterResult
    Function Read(Of T As {New, Class})(address As String, Optional length As Integer = 1) As TesterResult(Of T)
    Function ReadAsync(Of T As {New, Class})(address As String, Optional length As Integer = 1) As Task(Of TesterResult(Of T))
    Function ManualWrite(address As String, obj As Object, Optional length As Integer = 1, Optional message As String = Nothing) As TesterResult
    Function ManualWriteString82(address As String, val As String) As TesterResult
    Function ManualWrite(e As SaveEventArgs) As TesterResult
    Function ManualWriteAsync(e As SaveEventArgs) As Task(Of TesterResult)

    Function WriteColors(colors As ColorsModel) As Task
End Interface
