Imports Magna.DualTester.Domino.TesterApi

Public Class PartNumberStatus

    Public Sub UpdateData(partinfo As Udt_PartInformation)
        If InvokeRequired Then
            Me.Invoke(Sub() UpdateData(partinfo))
            Return
        End If

        Select Case (partinfo.DominoPartLoaded)
            Case 0
                Label1.Text = "--"
                TableLayoutPanel1.BackColor = SystemColors.Control
            Case 1
                Label1.Text = "Current Part"
                TableLayoutPanel1.BackColor = Color.PaleGreen
            Case 2
                Label1.Text = "Next Part"
                TableLayoutPanel1.BackColor = Color.PaleGoldenrod
        End Select
    End Sub

End Class