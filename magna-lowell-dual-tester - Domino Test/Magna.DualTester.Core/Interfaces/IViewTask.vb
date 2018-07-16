Imports System.Threading.Tasks

Public Interface IViewTask
    ReadOnly Property RunningTask As Task
    Function BeginClose() As Task
    Sub Load()
End Interface
