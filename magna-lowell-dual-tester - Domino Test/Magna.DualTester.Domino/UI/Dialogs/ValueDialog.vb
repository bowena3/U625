Imports Magna.DualTester.Core
Imports Magna.DualTester.Core.Data.Enums

Namespace UI.Dialogs

    ''' <summary>
    ''' This is a popup numeric edit box used on the <c>CalibrationSubUserControl</c>
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ValueDialog
        Const MinAccessLevel As AccessLevel = AccessLevel.Tech
        Public Value As Single
        Private Property Title As String
        Dim isMinOrBetter As Boolean

        Private ReadOnly _msgsvc As IMessageAlertService

        ''' <summary>
        '''
        ''' </summary>
        ''' <param name="title">Concatenated into the title of the dialog box to look like "Editing [title]"</param>
        ''' <param name="unit">Of the type units, this determines what will display next to the input.</param>
        ''' <param name="currentValue"></param>
        ''' <remarks></remarks>
        Public Sub New(title As String, unit As Units, currentValue As Single, user As User, msgsvc As IMessageAlertService)
            Me.New(title, If(unit <> Units.Deg, unit.ToString(), "°"), currentValue, user, msgsvc)
            'InitializeComponent()
            'Me.StartPosition = FormStartPosition.CenterParent
            'Me.Title = "Editing " + title
            'Me.Value = currentValue
            ''If the selected unit is Units.deg then place the ° character
            'LblBaseUnits.Text = If(unit <> Units.Deg, unit.ToString(), "°")
            'TextBox1.Text = CStr(Me.Value)
            'TextBox1.Focus()
            'isMinOrBetter = CBool(user?.AccessLevel >= MinAccessLevel)
        End Sub

        Public Sub New(title As String, unit As String, currentValue As Single, user As User, msgsvc As IMessageAlertService)
            InitializeComponent()
            _msgsvc = msgsvc
            Me.StartPosition = FormStartPosition.CenterParent
            Me.Title = "Editing " + title
            Me.Value = currentValue
            LblBaseUnits.Text = unit
            TextBox1.Text = CStr(Me.Value)
            TextBox1.Focus()
            isMinOrBetter = CBool(user?.AccessLevel >= MinAccessLevel)
        End Sub

        Public Enum Units
            A
            V
            Mm
            Deg
        End Enum

        Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
            If isMinOrBetter Then
                DialogResult = Windows.Forms.DialogResult.OK
                Me.Value = CSng(TextBox1.Text.Replace(" ", CStr(0)).Trim({ChrW(0)}))
                Me.Close()
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
        Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
            If e.KeyChar = CChar(".") Then
                If TextBox1.Text.IndexOf(CChar(".")) <> -1 Then
                    e.Handled = True
                    Return
                End If
                Return
            End If
            If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Char.ConvertFromUtf32(8) Then
                e.Handled = True
                Return
            End If
        End Sub

        Private Sub ValueDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.Text = Title
        End Sub

        Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            TextBox1.Select()
        End Sub

    End Class

End Namespace