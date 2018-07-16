Imports System.Reflection
Imports Magna.DualTester.Core
Imports Magna.DualTester.Domino.TesterApi

Public Class NestPartOptions
    Implements IView(Of NestPartOptionsViewModel)

    Private partOptions As New Dictionary(Of String, Control)
    Private glassOptions As New Dictionary(Of String, Control)

    Public Sub New()
        InitializeComponent()

        Dim run = Sub(item As FieldInfo, dict As Dictionary(Of String, Control), panel As FlowLayoutPanel)
                      Dim finder = New IconFinder()
                      'TryCast(My.Resources.ResourceManager.GetObject(item.Name), Bitmap)
                      Dim btn = New Button() With {.Text = item.Name,
                                                    .Margin = New Padding(1),
                                                    .AutoSize = True,
                                                    .Image = finder.GetImage(item.Name),
                                                    .ImageAlign = ContentAlignment.MiddleRight,
                                                    .TextImageRelation = TextImageRelation.ImageBeforeText,
                                                    .Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold, GraphicsUnit.Point)}
                      dict.Add(item.Name, btn)
                      panel.Controls.Add(btn)
                  End Sub

        For Each item In GetProperties(Of Udt_PartOptions)()
            run(item, partOptions, FlowPanelPartOptions)
        Next

        For Each item In GetProperties(Of Udt_GlassOptions)()
            run(item, glassOptions, FlowPanelGlassOptions)
        Next

        Dim glassW = glassOptions.Select(Function(x) x.Value).Max(Function(x) x.Width)
        Dim partW = partOptions.Select(Function(x) x.Value).Max(Function(x) x.Width)

        For Each g In glassOptions
            g.Value.Width = glassW
        Next
        For Each g In partOptions
            g.Value.Width = partW
        Next

    End Sub

    Public Sub UpdateViewModel(data As NestPartOptionsViewModel) Implements IView(Of NestPartOptionsViewModel).UpdateViewModel
        If InvokeRequired Then
            Invoke(Sub() UpdateViewModel(data))
            Return
        End If

        For Each item In GetProperties(Of Udt_GlassOptions)()
            SetControl(item, data.GlassOptions, glassOptions)
        Next
        For Each item In GetProperties(Of Udt_PartOptions)()
            SetControl(item, data.PartOptions, partOptions)
        Next
    End Sub

    Shared count As Integer = 0

    Private Shared Sub SetControl(field As FieldInfo, item As Object, ctrls As Dictionary(Of String, Control))
        Dim ctrl = ctrls(field.Name)
        Dim value = DirectCast(field.GetValue(item), Udt_Opt_Item)

        'ctrl.Visible = value.Status > 0
        ctrl.Visible = value.Config > 0
        Select Case (value.Status)
            Case 0
                ctrl.BackColor = SystemColors.Control
            Case 1
                ctrl.BackColor = Color.Yellow
            Case 2
                ctrl.BackColor = Color.PaleGreen
            Case 3
                ctrl.BackColor = Color.PaleVioletRed
            Case 4
                ctrl.BackColor = Color.PaleTurquoise
        End Select
    End Sub

    Private Shared Function GetProperties(Of T As Class)() As IEnumerable(Of FieldInfo)
        Return GetType(T).GetFields '.Where(Function(x) x.MemberType = Reflection.MemberTypes.Field)
    End Function

End Class

Public Class NestPartOptionsViewModel

    Public Sub New(partoptions As Udt_PartOptions, glassOptions As Udt_GlassOptions)
        Me.PartOptions = partoptions
        Me.GlassOptions = glassOptions
    End Sub

    Public Property PartOptions As Udt_PartOptions
    Public Property GlassOptions As Udt_GlassOptions
End Class