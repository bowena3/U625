
Imports Magna.DualTester.Domino.UI.Views.Calibration.SubViews

Namespace UI.Views.Calibration

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ViewCalibration
        Inherits UserControl



        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.LblAlarm = New System.Windows.Forms.Label()
            Me.LblStep = New System.Windows.Forms.Label()
            Me.TlpNestSelect = New System.Windows.Forms.TableLayoutPanel()
            Me.BtnNest1 = New System.Windows.Forms.Button()
            Me.BtnNest2 = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.MainControlPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.ActuatorUserControl1 = New Magna.DualTester.Domino.UI.Views.Calibration.SubViews.ActuatorUserControl()
            Me.TesterDevicesUserControl1 = New Magna.DualTester.Domino.UI.Views.Calibration.SubViews.TesterDevicesUserControl()
            Me.CalibrationSubUserControl1 = New Magna.DualTester.Domino.UI.Views.Calibration.SubViews.CalibrationSubUserControl()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TlpNestSelect.SuspendLayout()
            Me.MainControlPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.LblAlarm, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.LblStep, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.TlpNestSelect, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.MainControlPanel, 0, 4)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 5
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(1262, 863)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'LblAlarm
            '
            Me.LblAlarm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LblAlarm.AutoSize = True
            Me.LblAlarm.BackColor = System.Drawing.Color.Black
            Me.LblAlarm.ForeColor = System.Drawing.Color.Red
            Me.LblAlarm.Location = New System.Drawing.Point(3, 72)
            Me.LblAlarm.Name = "LblAlarm"
            Me.LblAlarm.Size = New System.Drawing.Size(1256, 13)
            Me.LblAlarm.TabIndex = 0
            Me.LblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblStep
            '
            Me.LblStep.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LblStep.AutoSize = True
            Me.LblStep.BackColor = System.Drawing.Color.Black
            Me.LblStep.ForeColor = System.Drawing.Color.White
            Me.LblStep.Location = New System.Drawing.Point(3, 52)
            Me.LblStep.Name = "LblStep"
            Me.LblStep.Size = New System.Drawing.Size(1256, 13)
            Me.LblStep.TabIndex = 1
            Me.LblStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TlpNestSelect
            '
            Me.TlpNestSelect.AutoSize = True
            Me.TlpNestSelect.ColumnCount = 2
            Me.TlpNestSelect.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TlpNestSelect.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TlpNestSelect.Controls.Add(Me.BtnNest1, 0, 0)
            Me.TlpNestSelect.Controls.Add(Me.BtnNest2, 1, 0)
            Me.TlpNestSelect.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TlpNestSelect.Location = New System.Drawing.Point(0, 0)
            Me.TlpNestSelect.Margin = New System.Windows.Forms.Padding(0)
            Me.TlpNestSelect.Name = "TlpNestSelect"
            Me.TlpNestSelect.RowCount = 1
            Me.TlpNestSelect.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TlpNestSelect.Size = New System.Drawing.Size(1262, 29)
            Me.TlpNestSelect.TabIndex = 2
            '
            'BtnNest1
            '
            Me.BtnNest1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnNest1.Location = New System.Drawing.Point(3, 3)
            Me.BtnNest1.Name = "BtnNest1"
            Me.BtnNest1.Size = New System.Drawing.Size(625, 23)
            Me.BtnNest1.TabIndex = 0
            Me.BtnNest1.Text = "Left Nest"
            Me.BtnNest1.UseVisualStyleBackColor = True
            '
            'BtnNest2
            '
            Me.BtnNest2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnNest2.Location = New System.Drawing.Point(634, 3)
            Me.BtnNest2.Name = "BtnNest2"
            Me.BtnNest2.Size = New System.Drawing.Size(625, 23)
            Me.BtnNest2.TabIndex = 1
            Me.BtnNest2.Text = "Right Nest"
            Me.BtnNest2.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 29)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(1256, 20)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Tech or higher to set nest modes"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'MainControlPanel
            '
            Me.MainControlPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
            Me.MainControlPanel.ColumnCount = 3
            Me.MainControlPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.MainControlPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.MainControlPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.MainControlPanel.Controls.Add(Me.ActuatorUserControl1, 0, 0)
            Me.MainControlPanel.Controls.Add(Me.TesterDevicesUserControl1, 2, 0)
            Me.MainControlPanel.Controls.Add(Me.CalibrationSubUserControl1, 1, 0)
            Me.MainControlPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MainControlPanel.Location = New System.Drawing.Point(3, 92)
            Me.MainControlPanel.Name = "MainControlPanel"
            Me.MainControlPanel.RowCount = 1
            Me.MainControlPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.MainControlPanel.Size = New System.Drawing.Size(1256, 768)
            Me.MainControlPanel.TabIndex = 3
            '
            'ActuatorUserControl1
            '
            Me.ActuatorUserControl1.AutoSize = True
            Me.ActuatorUserControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ActuatorUserControl1.Location = New System.Drawing.Point(4, 4)
            Me.ActuatorUserControl1.Name = "ActuatorUserControl1"
            Me.ActuatorUserControl1.Size = New System.Drawing.Size(411, 760)
            Me.ActuatorUserControl1.TabIndex = 0
            '
            'TesterDevicesUserControl1
            '
            Me.TesterDevicesUserControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TesterDevicesUserControl1.Location = New System.Drawing.Point(840, 4)
            Me.TesterDevicesUserControl1.Name = "TesterDevicesUserControl1"
            Me.TesterDevicesUserControl1.Size = New System.Drawing.Size(412, 760)
            Me.TesterDevicesUserControl1.TabIndex = 1
            '
            'CalibrationSubUserControl1
            '
            Me.CalibrationSubUserControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CalibrationSubUserControl1.Location = New System.Drawing.Point(422, 4)
            Me.CalibrationSubUserControl1.Name = "CalibrationSubUserControl1"
            Me.CalibrationSubUserControl1.Size = New System.Drawing.Size(411, 760)
            Me.CalibrationSubUserControl1.TabIndex = 2
            '
            'ViewCalibration
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Name = "ViewCalibration"
            Me.Size = New System.Drawing.Size(1262, 863)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.TlpNestSelect.ResumeLayout(False)
            Me.MainControlPanel.ResumeLayout(False)
            Me.MainControlPanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents LblAlarm As System.Windows.Forms.Label
        Friend WithEvents LblStep As System.Windows.Forms.Label
        Friend WithEvents TlpNestSelect As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents BtnNest1 As System.Windows.Forms.Button
        Friend WithEvents BtnNest2 As System.Windows.Forms.Button
        Friend WithEvents MainControlPanel As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents ActuatorUserControl1 As ActuatorUserControl
        Friend WithEvents TesterDevicesUserControl1 As TesterDevicesUserControl
        Friend WithEvents CalibrationSubUserControl1 As CalibrationSubUserControl
        Friend WithEvents Label1 As System.Windows.Forms.Label

    End Class
End Namespace