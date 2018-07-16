
Namespace UI.Views.Calibration.SubViews

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ActuatorUserControl
        Inherits UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActuatorUserControl))
            Me.BtnUp = New System.Windows.Forms.Button()
            Me.BtnIB = New System.Windows.Forms.Button()
            Me.BtnOB = New System.Windows.Forms.Button()
            Me.BtnDown = New System.Windows.Forms.Button()
            Me.BtnCenter = New System.Windows.Forms.Button()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.ChkDefog = New System.Windows.Forms.CheckBox()
            Me.ChkTs = New System.Windows.Forms.CheckBox()
            Me.ChkBzi = New System.Windows.Forms.CheckBox()
            Me.BtnPfIn = New System.Windows.Forms.Button()
            Me.BtnPfOut = New System.Windows.Forms.Button()
            Me.ChkEc = New System.Windows.Forms.CheckBox()
            Me.ChkGi = New System.Windows.Forms.CheckBox()
            Me.ChkCargoLamp = New System.Windows.Forms.CheckBox()
            Me.ChkGreenLed = New System.Windows.Forms.CheckBox()
            Me.ChkFlatLight = New System.Windows.Forms.CheckBox()
            Me.ChkOats = New System.Windows.Forms.CheckBox()
            Me.OnOffLight = New System.Windows.Forms.ImageList(Me.components)
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.TableLayoutPanel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'BtnUp
            '
            Me.BtnUp.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnUp.FlatAppearance.BorderColor = System.Drawing.Color.Blue
            Me.BtnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnUp.Location = New System.Drawing.Point(84, 3)
            Me.BtnUp.Name = "BtnUp"
            Me.BtnUp.Size = New System.Drawing.Size(75, 58)
            Me.BtnUp.TabIndex = 0
            Me.BtnUp.Tag = "1"
            Me.BtnUp.Text = "Up"
            Me.BtnUp.UseVisualStyleBackColor = True
            '
            'BtnIB
            '
            Me.BtnIB.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnIB.FlatAppearance.BorderColor = System.Drawing.Color.Blue
            Me.BtnIB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnIB.Location = New System.Drawing.Point(3, 67)
            Me.BtnIB.Name = "BtnIB"
            Me.BtnIB.Size = New System.Drawing.Size(75, 58)
            Me.BtnIB.TabIndex = 1
            Me.BtnIB.Tag = "4"
            Me.BtnIB.Text = "IB"
            Me.BtnIB.UseVisualStyleBackColor = True
            '
            'BtnOB
            '
            Me.BtnOB.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnOB.FlatAppearance.BorderColor = System.Drawing.Color.Blue
            Me.BtnOB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnOB.Location = New System.Drawing.Point(165, 67)
            Me.BtnOB.Name = "BtnOB"
            Me.BtnOB.Size = New System.Drawing.Size(77, 58)
            Me.BtnOB.TabIndex = 2
            Me.BtnOB.Tag = "8"
            Me.BtnOB.Text = "OB"
            Me.BtnOB.UseVisualStyleBackColor = True
            '
            'BtnDown
            '
            Me.BtnDown.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnDown.FlatAppearance.BorderColor = System.Drawing.Color.Blue
            Me.BtnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnDown.Location = New System.Drawing.Point(84, 131)
            Me.BtnDown.Name = "BtnDown"
            Me.BtnDown.Size = New System.Drawing.Size(75, 60)
            Me.BtnDown.TabIndex = 3
            Me.BtnDown.Tag = "2"
            Me.BtnDown.Text = "Down"
            Me.BtnDown.UseVisualStyleBackColor = True
            '
            'BtnCenter
            '
            Me.BtnCenter.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnCenter.FlatAppearance.BorderColor = System.Drawing.Color.Blue
            Me.BtnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnCenter.Location = New System.Drawing.Point(84, 67)
            Me.BtnCenter.Name = "BtnCenter"
            Me.BtnCenter.Size = New System.Drawing.Size(75, 58)
            Me.BtnCenter.TabIndex = 4
            Me.BtnCenter.Tag = "16"
            Me.BtnCenter.Text = "Center"
            Me.BtnCenter.UseVisualStyleBackColor = True
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 3
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.Controls.Add(Me.BtnUp, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.BtnIB, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.BtnOB, 2, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.BtnDown, 1, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.BtnCenter, 1, 1)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 3
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(245, 194)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.ColumnCount = 4
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.75!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.75!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
            Me.TableLayoutPanel2.Controls.Add(Me.ChkDefog, 1, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.ChkTs, 2, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.ChkBzi, 2, 2)
            Me.TableLayoutPanel2.Controls.Add(Me.BtnPfIn, 2, 1)
            Me.TableLayoutPanel2.Controls.Add(Me.BtnPfOut, 1, 1)
            Me.TableLayoutPanel2.Controls.Add(Me.ChkOats, 1, 5)
            Me.TableLayoutPanel2.Controls.Add(Me.ChkCargoLamp, 2, 5)
            Me.TableLayoutPanel2.Controls.Add(Me.ChkGi, 1, 2)
            Me.TableLayoutPanel2.Controls.Add(Me.ChkGreenLed, 1, 3)
            Me.TableLayoutPanel2.Controls.Add(Me.ChkEc, 1, 4)
            Me.TableLayoutPanel2.Controls.Add(Me.ChkFlatLight, 2, 3)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 259)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 6
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(245, 346)
            Me.TableLayoutPanel2.TabIndex = 3
            '
            'ChkDefog
            '
            Me.ChkDefog.Appearance = System.Windows.Forms.Appearance.Button
            Me.ChkDefog.AutoEllipsis = True
            Me.ChkDefog.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ChkDefog.FlatAppearance.BorderColor = System.Drawing.Color.Blue
            Me.ChkDefog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ChkDefog.Image = Global.Magna.DualTester.Domino.My.Resources.Resources.defog
            Me.ChkDefog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ChkDefog.Location = New System.Drawing.Point(18, 3)
            Me.ChkDefog.Name = "ChkDefog"
            Me.ChkDefog.Size = New System.Drawing.Size(101, 51)
            Me.ChkDefog.TabIndex = 0
            Me.ChkDefog.Text = "Defog"
            Me.ChkDefog.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.ChkDefog.UseVisualStyleBackColor = True
            '
            'ChkTs
            '
            Me.ChkTs.Appearance = System.Windows.Forms.Appearance.Button
            Me.ChkTs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ChkTs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ChkTs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ChkTs.Image = Global.Magna.DualTester.Domino.My.Resources.Resources.Turn_Signal
            Me.ChkTs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ChkTs.Location = New System.Drawing.Point(125, 3)
            Me.ChkTs.Name = "ChkTs"
            Me.ChkTs.Size = New System.Drawing.Size(101, 51)
            Me.ChkTs.TabIndex = 1
            Me.ChkTs.Text = "TS"
            Me.ChkTs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.ChkTs.UseVisualStyleBackColor = True
            '
            'ChkBzi
            '
            Me.ChkBzi.Appearance = System.Windows.Forms.Appearance.Button
            Me.ChkBzi.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ChkBzi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ChkBzi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ChkBzi.Image = Global.Magna.DualTester.Domino.My.Resources.Resources.Bzi
            Me.ChkBzi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ChkBzi.Location = New System.Drawing.Point(125, 117)
            Me.ChkBzi.Name = "ChkBzi"
            Me.ChkBzi.Size = New System.Drawing.Size(101, 51)
            Me.ChkBzi.TabIndex = 5
            Me.ChkBzi.Text = "BZI"
            Me.ChkBzi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.ChkBzi.UseVisualStyleBackColor = True
            '
            'BtnPfIn
            '
            Me.BtnPfIn.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnPfIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.BtnPfIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnPfIn.Image = CType(resources.GetObject("BtnPfIn.Image"), System.Drawing.Image)
            Me.BtnPfIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.BtnPfIn.Location = New System.Drawing.Point(125, 60)
            Me.BtnPfIn.Name = "BtnPfIn"
            Me.BtnPfIn.Size = New System.Drawing.Size(101, 51)
            Me.BtnPfIn.TabIndex = 11
            Me.BtnPfIn.Text = "Pfold In"
            Me.BtnPfIn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.BtnPfIn.UseVisualStyleBackColor = True
            '
            'BtnPfOut
            '
            Me.BtnPfOut.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnPfOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.BtnPfOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnPfOut.Image = CType(resources.GetObject("BtnPfOut.Image"), System.Drawing.Image)
            Me.BtnPfOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.BtnPfOut.Location = New System.Drawing.Point(18, 60)
            Me.BtnPfOut.Name = "BtnPfOut"
            Me.BtnPfOut.Size = New System.Drawing.Size(101, 51)
            Me.BtnPfOut.TabIndex = 10
            Me.BtnPfOut.Text = "Pfold Out"
            Me.BtnPfOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.BtnPfOut.UseVisualStyleBackColor = True
            '
            'ChkEc
            '
            Me.ChkEc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ChkEc.Appearance = System.Windows.Forms.Appearance.Button
            Me.ChkEc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ChkEc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ChkEc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ChkEc.Location = New System.Drawing.Point(18, 231)
            Me.ChkEc.Name = "ChkEc"
            Me.ChkEc.Size = New System.Drawing.Size(101, 51)
            Me.ChkEc.TabIndex = 12
            Me.ChkEc.Text = "EC"
            Me.ChkEc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.ChkEc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.ChkEc.UseVisualStyleBackColor = True
            '
            'ChkGi
            '
            Me.ChkGi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ChkGi.Appearance = System.Windows.Forms.Appearance.Button
            Me.ChkGi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ChkGi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ChkGi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ChkGi.Location = New System.Drawing.Point(18, 117)
            Me.ChkGi.Name = "ChkGi"
            Me.ChkGi.Size = New System.Drawing.Size(101, 51)
            Me.ChkGi.TabIndex = 13
            Me.ChkGi.Text = "GI"
            Me.ChkGi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.ChkGi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.ChkGi.UseVisualStyleBackColor = True
            '
            'ChkCargoLamp
            '
            Me.ChkCargoLamp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ChkCargoLamp.Appearance = System.Windows.Forms.Appearance.Button
            Me.ChkCargoLamp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ChkCargoLamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ChkCargoLamp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ChkCargoLamp.Location = New System.Drawing.Point(125, 288)
            Me.ChkCargoLamp.Name = "ChkCargoLamp"
            Me.ChkCargoLamp.Size = New System.Drawing.Size(101, 55)
            Me.ChkCargoLamp.TabIndex = 14
            Me.ChkCargoLamp.Text = "Cargo Lamp"
            Me.ChkCargoLamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.ChkCargoLamp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.ChkCargoLamp.UseVisualStyleBackColor = True
            Me.ChkCargoLamp.Visible = False
            '
            'ChkGreenLed
            '
            Me.ChkGreenLed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ChkGreenLed.Appearance = System.Windows.Forms.Appearance.Button
            Me.ChkGreenLed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ChkGreenLed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ChkGreenLed.Image = CType(resources.GetObject("ChkGreenLed.Image"), System.Drawing.Image)
            Me.ChkGreenLed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ChkGreenLed.Location = New System.Drawing.Point(18, 174)
            Me.ChkGreenLed.Name = "ChkGreenLed"
            Me.ChkGreenLed.Size = New System.Drawing.Size(101, 51)
            Me.ChkGreenLed.TabIndex = 6
            Me.ChkGreenLed.Text = "Green LED"
            Me.ChkGreenLed.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.ChkGreenLed.UseVisualStyleBackColor = True
            '
            'ChkFlatLight
            '
            Me.ChkFlatLight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ChkFlatLight.Appearance = System.Windows.Forms.Appearance.Button
            Me.ChkFlatLight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ChkFlatLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ChkFlatLight.Image = Global.Magna.DualTester.Domino.My.Resources.Resources.Light
            Me.ChkFlatLight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ChkFlatLight.Location = New System.Drawing.Point(125, 174)
            Me.ChkFlatLight.Name = "ChkFlatLight"
            Me.ChkFlatLight.Size = New System.Drawing.Size(101, 51)
            Me.ChkFlatLight.TabIndex = 7
            Me.ChkFlatLight.Text = "Flat Light"
            Me.ChkFlatLight.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.ChkFlatLight.UseVisualStyleBackColor = True
            '
            'ChkOats
            '
            Me.ChkOats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ChkOats.Appearance = System.Windows.Forms.Appearance.Button
            Me.ChkOats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ChkOats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ChkOats.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ChkOats.Location = New System.Drawing.Point(18, 288)
            Me.ChkOats.Name = "ChkOats"
            Me.ChkOats.Size = New System.Drawing.Size(101, 55)
            Me.ChkOats.TabIndex = 15
            Me.ChkOats.Text = "Oats"
            Me.ChkOats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.ChkOats.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.ChkOats.UseVisualStyleBackColor = True
            Me.ChkOats.Visible = False
            '
            'OnOffLight
            '
            Me.OnOffLight.ImageStream = CType(resources.GetObject("OnOffLight.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.OnOffLight.TransparentColor = System.Drawing.Color.Transparent
            Me.OnOffLight.Images.SetKeyName(0, "lightoff.ico")
            Me.OnOffLight.Images.SetKeyName(1, "lighton.ico")
            '
            'TableLayoutPanel3
            '
            Me.TableLayoutPanel3.ColumnCount = 1
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 2)
            Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 4)
            Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
            Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 6
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889!))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel3.Size = New System.Drawing.Size(251, 629)
            Me.TableLayoutPanel3.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(3, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(245, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Actuator"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ImageList1
            '
            Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            '
            'ActuatorUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.Controls.Add(Me.TableLayoutPanel3)
            Me.Name = "ActuatorUserControl"
            Me.Size = New System.Drawing.Size(251, 629)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.TableLayoutPanel3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents BtnUp As System.Windows.Forms.Button
        Friend WithEvents BtnIB As System.Windows.Forms.Button
        Friend WithEvents BtnOB As System.Windows.Forms.Button
        Friend WithEvents BtnDown As System.Windows.Forms.Button
        Friend WithEvents BtnCenter As System.Windows.Forms.Button
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents ChkDefog As System.Windows.Forms.CheckBox
        Friend WithEvents ChkTs As System.Windows.Forms.CheckBox
        Friend WithEvents ChkBzi As System.Windows.Forms.CheckBox
        Friend WithEvents ChkGreenLed As System.Windows.Forms.CheckBox
        Friend WithEvents ChkFlatLight As System.Windows.Forms.CheckBox
        Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents OnOffLight As System.Windows.Forms.ImageList
        Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
        Friend WithEvents BtnPfIn As System.Windows.Forms.Button
        Friend WithEvents BtnPfOut As System.Windows.Forms.Button
        Friend WithEvents ChkEc As CheckBox
        Friend WithEvents ChkGi As CheckBox
        Friend WithEvents ChkCargoLamp As CheckBox
        Friend WithEvents ChkOats As CheckBox
    End Class
End Namespace