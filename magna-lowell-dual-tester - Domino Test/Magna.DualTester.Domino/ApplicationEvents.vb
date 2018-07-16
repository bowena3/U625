Namespace My

    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active.
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Public Const SetCfgArg As String = "-setcfg"

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            If e.CommandLine.Count > 0 Then
                'MessageBox.Show(String.Join(",", e.CommandLine))
                If e.CommandLine.Contains("-waitforremote") Then
                    While (Not System.Diagnostics.Debugger.IsAttached)
                        System.Threading.Thread.Sleep(100)
                    End While
                End If
                If e.CommandLine.Contains(SetCfgArg) Then
                    Form1.StartArg = SetCfgArg
                End If
            End If
        End Sub

    End Class

End Namespace