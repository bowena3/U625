Public Class DialogGetStr
    Public Value As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OK_Button.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Value = TextBox1.Text
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DialogGetInt_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        TextBox1.Focus()
    End Sub

End Class