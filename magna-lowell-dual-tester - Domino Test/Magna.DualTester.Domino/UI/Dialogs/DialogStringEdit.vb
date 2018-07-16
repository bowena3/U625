Namespace UI.Dialogs

    Public Class DialogStringEdit

        Private Property Title As String
        Public Property Value As String

        Public Sub New(title As String, value As String)
            InitializeComponent()
            TxtValue.Focus()
            Me.Title = title
            Me.Text = title
            Me.Value = value
            Me.TxtValue.Text = Me.Value
        End Sub

        Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Value = TxtValue.Text
        End Sub

        Private Sub BtnCancle_Click(sender As Object, e As EventArgs) Handles BtnCancle.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Sub

        Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            TxtValue.Select()
        End Sub

    End Class

End Namespace