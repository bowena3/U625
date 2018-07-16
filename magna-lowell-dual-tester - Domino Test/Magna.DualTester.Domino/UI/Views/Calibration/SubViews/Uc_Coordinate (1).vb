Imports Magna.DualTester.Domino.TesterApi
Imports Magna.DualTester.Core

Public Class Uc_Coordinate
    Implements IView(Of UcCoordinateViewModel)

    Dim _CalData As New Udt_Mcal
    Public Event SendAngleCalDataRequest(CalData As Udt_Mcal)
    'Public Event RequestingCurrentCalData()
    Dim _GlassType As GlassTypeEnum
    Dim _ManualBits As MactFlags
    Dim VertRawUp As Integer = 0
    Dim VertRawDown As Integer = 0
    Dim HorzRawIb As Integer = 0
    Dim HorzRawOb As Integer = 0

    Private Property _horzRawIn As Integer
    Private Property _vertRawIn As Integer
    Private Property _nest As Integer

    Public Sub CalEventComplete()
        btnSaveAngleCal.Enabled = True
    End Sub






    Private Sub UpdateRawvaluesRefernce()
        If _ManualBits <> MactFlags.None Then
            VertRawUp = 0
            VertRawDown = 0
            HorzRawIb = 0
            HorzRawOb = 0
        End If
        Select Case _ManualBits
            Case MactFlags.Up
                VertRawUp = If(_vertRawIn > 0, _vertRawIn, 0)
            Case MactFlags.Down
                VertRawDown = If(_vertRawIn > 0, _vertRawIn, 0)
            Case MactFlags.Inboard
                HorzRawIb = _horzRawIn
            Case MactFlags.OutBoard
                HorzRawOb = _horzRawIn
        End Select

        If _GlassType = GlassTypeEnum.LH_CVX OrElse _GlassType = GlassTypeEnum.LH_FLAT Then
            V_Sample_RawMax.Enabled = True ' VertRawUp > 250 AndAlso VertRawUp <> 0
            V_Sample_RawMin.Enabled = True ' VertRawDown < 200 AndAlso VertRawDown <> 0
        ElseIf _GlassType = GlassTypeEnum.RH_CVX OrElse _GlassType = GlassTypeEnum.RH_FLAT Then
            V_Sample_RawMax.Enabled = True
            'V_Sample_RawMax.Enabled = VertRawUp < 120 AndAlso VertRawUp <> 0
            V_Sample_RawMin.Enabled = True
            'V_Sample_RawMin.Enabled = VertRawDown > 250 AndAlso VertRawDown <> 0
        End If

        H_Sample_RawMin.Enabled = True
        'H_Sample_RawMin.Enabled = HorzRawIb > 350 AndAlso HorzRawIb <> 0
        H_Sample_RawMax.Enabled = True
        'H_Sample_RawMax.Enabled = HorzRawOb < 280 AndAlso HorzRawOb <> 0
    End Sub


    Private Sub UpdateItems()
        With _CalData
            H_EuMax.Value = CDec(.H.EuMax)
            H_RawMax.Text = .H.RawMax.ToString()
            H_EuMin.Value = CDec(.H.EuMin)
            H_RawMin.Text = .H.RawMin.ToString()

            V_EuMax.Value = CDec(.V.EuMax)
            V_RawMax.Text = .V.RawMax.ToString()
            V_EuMin.Value = CDec(.V.EuMin)
            V_RawMin.Text = .V.RawMin.ToString()
        End With
    End Sub

    Private Function GetValues() As Udt_Mcal
        Dim mC As New Udt_Mcal
        With mC
            .H.EuMax = H_EuMax.Value
            .H.RawMax = CInt(Val(H_RawMax.Text))
            .H.EuMin = H_EuMin.Value
            .H.RawMin = CInt(Val(H_RawMin.Text))

            .V.EuMax = V_EuMax.Value
            .V.RawMax = CInt(Val(V_RawMax.Text))
            .V.EuMin = V_EuMin.Value
            .V.RawMin = CInt(Val(V_RawMin.Text))
        End With
        Return mC
    End Function

    Private Sub ResetCalData()
        H_EuMax.Value = 0
        H_RawMax.Text = "0"
        H_EuMin.Value = 0
        H_RawMin.Text = "0"

        V_EuMax.Value = 0
        V_RawMax.Text = "0"
        V_EuMin.Value = 0
        V_RawMin.Text = "0"
    End Sub


    'Public ReadOnly Property BtnProperty As Button
    '    Get
    '        Return V_Sample_RawMax
    '    End Get
    'End Property

    Public Property MaxVal As Single
        Get
            Return CSng(V_EuMax.Maximum)
        End Get
        Set(value As Single)
            V_EuMax.Maximum = CDec(value)
        End Set
    End Property

    Public Property MinVal As Single
        Get
            Return CSng(V_EuMax.Minimum)
        End Get
        Set(value As Single)
            V_EuMax.Minimum = CDec(value)
        End Set
    End Property

    'Private Property RawVal As Integer = 0
    'Private Property EngVal As Single = 0

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles V_Sample_RawMax.Click
        If VertRawUp <> 0 Then
            V_RawMax.Text = VertRawUp.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles V_Sample_RawMin.Click
        If VertRawDown <> 0 Then
            V_RawMin.Text = VertRawDown.ToString
        End If
    End Sub

    Private Sub H_Sample_RawMin_Click(sender As Object, e As EventArgs) Handles H_Sample_RawMin.Click
        If HorzRawIb <> 0 Then
            H_RawMin.Text = HorzRawIb.ToString
        End If
    End Sub

    Private Sub H_Sample_RawMax_Click(sender As Object, e As EventArgs) Handles H_Sample_RawMax.Click
        If HorzRawOb <> 0 Then
            H_RawMax.Text = HorzRawOb.ToString
        End If
    End Sub



    Private Function ValidateData() As Udt_Mcal
        Dim Mc = GetValues()
        With Mc
            If Math.Abs(Mc.H.EuMax - Mc.H.EuMin) > 8 AndAlso Math.Abs(Mc.V.EuMax - Mc.V.EuMin) > 8 Then
                If (Mc.H.RawMin - Mc.H.RawMax) > 100 Then
                    If (Mc.V.RawMax - Mc.V.RawMin) > 75 OrElse (Mc.V.RawMin - Mc.V.RawMax) > 75 Then
                        Return Mc
                    End If
                End If
            End If
        End With
        Return Nothing
    End Function

    Private Sub BtnSaveAngleCal_Click(sender As Object, e As EventArgs) Handles btnSaveAngleCal.Click

        Dim Mc = GetValues()
        If Mc IsNot Nothing Then
            Using RUSure As New AreUSureAlgCfg(_nest, _GlassType)

                Dim p = Me.PointToScreen(PartTypeName.Location)
                RUSure.Location = New Point(p.X, p.Y)

                RUSure.Width = Me.Width
                RUSure.Height = Me.Height

                If RUSure.ShowDialog() = DialogResult.Yes Then
                    btnSaveAngleCal.Enabled = False
                    RaiseEvent SendAngleCalDataRequest(Mc)
                End If
            End Using
        End If


    End Sub

    'Private Sub H_RawMax_Click(sender As Object, e As EventArgs) Handles H_RawMax.Click

    'End Sub

    Private Sub H_RawMax_TextChanged(sender As Object, e As EventArgs) Handles H_RawMax.TextChanged, H_RawMin.TextChanged, V_RawMax.TextChanged, V_RawMin.TextChanged
        Dim data = ValidateData()
        Dim Enab = data IsNot Nothing
        btnSaveAngleCal.Enabled = Enab AndAlso PartTypeName.Text <> "?"
    End Sub

    'Public Sub RefreshCurrentcalData()
    '    UpdateItems()
    'End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateItems()
        ' RaiseEvent RequestingCurrentCalData()
    End Sub

    Private WriteOnly Property GlassType As GlassTypeEnum
        Set(value As GlassTypeEnum)
            If _GlassType <> value Then
                ResetCalData()
            End If

            _GlassType = value
            Dim stringVal As String
            Select Case value
                Case GlassTypeEnum.none
                    stringVal = "?"
                Case GlassTypeEnum.LH_FLAT
                    stringVal = "LH_Flat"
                Case GlassTypeEnum.RH_FLAT
                    stringVal = "RH_Flat"
                Case GlassTypeEnum.LH_CVX
                    stringVal = "LH_Convex"
                Case GlassTypeEnum.RH_CVX
                    stringVal = "RH_Convex"
                Case Else
                    stringVal = "?"
            End Select
            PartTypeName.Text = stringVal
        End Set
    End Property

    Public Sub UpdateViewModel(data As UcCoordinateViewModel) Implements IView(Of UcCoordinateViewModel).UpdateViewModel
        GlassType = data.GlassType
        _nest = data.NestId
        _vertRawIn = data.VertRawIn
        _horzRawIn = data.HorzRawIn
        _ManualBits = data.ManualBits
        UpdateRawvaluesRefernce()
        _CalData = data.CalData
    End Sub

    Private Sub lblInstruction_Click(sender As Object, e As EventArgs) Handles lblInstruction.Click

    End Sub
End Class


