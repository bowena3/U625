Imports Magna.DualTester.Core
Imports Magna.DualTester.Plc.Core

Namespace UI.Dialogs

    Public Class DialogColorSelector

        Private ReadOnly _colors As ColorsModel
        Public SelectedColor As Udt_Color
        Public SelectedColorIndex As Integer

        Public Sub New(colors As ColorsModel)
            InitializeComponent()
            StartPosition = FormStartPosition.CenterParent
            _colors = colors
            ComboColors.DataSource = _colors.Data.ToList()
        End Sub

        Private Sub ComboColors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboColors.SelectedIndexChanged
            SelectedColor = DirectCast(ComboColors.SelectedItem, Udt_Color)
        End Sub

        Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
            DialogResult = Windows.Forms.DialogResult.OK

            SelectedColor = DirectCast(ComboColors.SelectedItem, Udt_Color)
            For x As Integer = 0 To _colors.Data.Count - 1
                If SelectedColor.Equals(_colors.Data(x)) Then
                    SelectedColorIndex = x
                    Exit For
                End If
            Next

        End Sub

        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            DialogResult = Windows.Forms.DialogResult.Cancel
        End Sub

    End Class

End Namespace