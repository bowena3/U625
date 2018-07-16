Imports Magna.DualTester.Core

Public Interface IAsTest
    Function Test(asc As IPlc) As IEnumerable(Of IUdtTest)
    Function TestAsync(asc As IPlc) As Task(Of IEnumerable(Of IUdtTest))
End Interface