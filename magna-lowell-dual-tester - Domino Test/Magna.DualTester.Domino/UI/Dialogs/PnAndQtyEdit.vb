Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data.Enums

Public Class PnAndQtyEdit
    Const MinAccessLevel As AccessLevel = AccessLevel.Tech
    Public Property PnNest1 As String
    Public Property PnNest2 As String
    Public Property Value As Integer
    Public Property ToteAccum As Integer
    Public Property PrintToteLabel As Boolean
    Public Property EndTote As Boolean
    Private Property Title As String
    ReadOnly isMinOrBetter As Boolean

    Private ReadOnly _msgsvc As IMessageAlertService

    ''' <summary>
    '''
    ''' </summary>
    ''' <param name="title">Concatenated into the title of the dialog box to look like "Editing [title]"</param>
    ''' <param name="Pn">Part Number Line is Tester is currently Running</param>
    ''' <param name="currentValue"></param>
    ''' <remarks></remarks>
    Public Sub New(title As String, currentValue As Integer, user As User, PnNest1 As String, PnNest2 As String, msgsvc As IMessageAlertService)
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Title = "Editing " + title
        Me.Value = currentValue
        PartQty.Value = currentValue
        Me.PnNest1 = PnNest1
        Me.PnNest2 = PnNest2
        Me.PrintToteLabel = False
        Me.EndTote = False

        PartNumbereditNest1.Text = Me.PnNest1
        PartNumbereditNest2.Text = Me.PnNest2
        PartNumbereditNest1.Focus()
        isMinOrBetter = CBool(user?.AccessLevel >= MinAccessLevel)
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If isMinOrBetter Then
            Me.Value = CInt(PartQty.Value) ' CSng(PartNumberedit.Text.Replace(" ", CStr(0)).Trim({ChrW(0)}))
            Me.PnNest1 = PartNumbereditNest1.Text
            Me.PnNest2 = PartNumbereditNest2.Text
            If Me.Value > 0 AndAlso Me.PnNest1.Length > 0 AndAlso Me.PnNest2.Length > 0 Then
                DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Else
            _msgsvc.PublishNewAlarm("You must be Tech or higher", ErrorLevel.Error)
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    ''' <summary>
    ''' This function checks for valid keyboard inputs.
    ''' </summary>
    ''' <remarks><c>e.Handled</c> makes it so the character is not placed in the textbox.</remarks>
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PartNumbereditNest1.KeyPress
        'If e.KeyChar = CChar(".") Then
        '    If PartNumberedit.Text.IndexOf(CChar(".")) <> -1 Then
        '        e.Handled = True
        '        Return
        '    End If
        '    Return
        'End If
        'If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Char.ConvertFromUtf32(8) Then
        '    e.Handled = True
        '    Return
        'End If
    End Sub

    Private Sub ValueDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Title
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        PartNumbereditNest1.Select()
    End Sub

    Private Sub PartNumberedit_TextChanged(sender As Object, e As EventArgs) Handles PartNumbereditNest1.TextChanged
        ValidateEntries()
    End Sub

    Private Sub BtnEndTote_Click(sender As Object, e As EventArgs) Handles btnEndTote.Click
        EndTote = True
        DialogResult = DialogResult.Abort
    End Sub

    Private Sub BtnPrintToteLabel_Click(sender As Object, e As EventArgs) Handles btnPrintToteLabel.Click
        PrintToteLabel = True
        DialogResult = DialogResult.Abort
    End Sub

    Private Sub PartNumbereditNest1_DoubleClick(sender As Object, e As EventArgs) Handles PartNumbereditNest1.DoubleClick, LblBaseUnits.DoubleClick
        PartNumbereditNest1.Text = PnNest1
    End Sub

    Private Sub PartNumbereditNest2_DoubleClick(sender As Object, e As EventArgs) Handles PartNumbereditNest2.DoubleClick, Label3.DoubleClick
        PartNumbereditNest1.Text = PnNest2
    End Sub

    Private Sub PartQty_ValueChanged(sender As Object, e As EventArgs) Handles PartQty.ValueChanged
        ValidateEntries()
    End Sub

    Private Sub ValidateEntries()
        If PnNest1 <> PartNumbereditNest1.Text AndAlso ToteAccum > 0 AndAlso PnNest1.Length > 1 AndAlso PnNest2 <> PartNumbereditNest2.Text AndAlso PnNest2.Length > 1 Then
            btnPrintToteLabel.Visible = True
            btnEndTote.Visible = True
            BtnOk.Enabled = False
            lblUnHandledToteParts.Visible = True
        Else
            btnPrintToteLabel.Visible = False
            btnEndTote.Visible = False
            BtnOk.Enabled = PartNumbereditNest1.Text.Length > 1
            lblUnHandledToteParts.Visible = False
        End If

        If BtnOk.Enabled Then
            BtnOk.Enabled = PartQty.Value > 0
        End If
    End Sub

End Class