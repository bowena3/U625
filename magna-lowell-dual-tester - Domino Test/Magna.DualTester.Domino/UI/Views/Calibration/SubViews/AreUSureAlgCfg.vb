Imports Magna.DualTester.Core

Public Class AreUSureAlgCfg

    Public Sub New(Nest As Integer, GlassType As GlassTypeEnum)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MsgText.Text = String.Format(MsgText.Tag.ToString(), GlassType.ToString(), Nest, ControlChars.CrLf)
    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        DialogResult = DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class