<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AsComm1 = New AutomatedSolutions.Win.Comm.ASComm()
        Me.Channel1 = New AutomatedSolutions.Win.Comm.AB.Legacy.Net.Channel()
        Me.SuspendLayout()
        '
        'AsComm1
        '
        Me.AsComm1.Channels.AddRange(New AutomatedSolutions.Win.Comm.Channel() {Me.Channel1})
        '
        'Channel1
        '
        Me.Channel1.Description = "AB.Legacy.Net.Channel"
        Me.Channel1.Label = "channel1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AsComm1 As AutomatedSolutions.Win.Comm.ASComm
    Friend WithEvents Channel1 As AutomatedSolutions.Win.Comm.AB.Legacy.Net.Channel
End Class
