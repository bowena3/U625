Namespace UI.Dialogs

    Public Class DialogCountEdit

        Public Property Value As Integer

        Public Sub New(title As String, val As Integer, Optional minValue As Integer = 0, Optional maxValue As Integer = Integer.MaxValue)
            InitializeComponent()
            Me.StartPosition = FormStartPosition.CenterParent

            Value = val
            If Value <= 0 Then
                Value = minValue
                BtnDec.Enabled = False
            ElseIf Value >= maxValue Then
                Value = maxValue
                BtnInc.Enabled = False
            End If
            LblValue.Text = CStr(val)
            Me.Text = title
        End Sub

        Private Sub BtnInc_Click(sender As Object, e As EventArgs) Handles BtnInc.Click
            Value += 1
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub BtnDec_Click(sender As Object, e As EventArgs) Handles BtnDec.Click
            Value -= 1
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

    End Class

End Namespace