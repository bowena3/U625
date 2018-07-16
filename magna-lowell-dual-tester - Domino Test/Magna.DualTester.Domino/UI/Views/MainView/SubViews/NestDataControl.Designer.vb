Imports Magna.DualTester.Domino.UI.Views

Namespace UI.Views.MainView.SubViews

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class NestDataControl
        Inherits UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.GridOptionsTesting = New FlexCell.Grid()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.TxtMessage = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TxtStep = New System.Windows.Forms.TextBox()
            Me.TxtAlarm = New System.Windows.Forms.TextBox()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.LblDetectedColor = New System.Windows.Forms.Label()
            Me.LblTargetColor = New System.Windows.Forms.Label()
            Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.NestPartOptions1 = New Magna.DualTester.Domino.NestPartOptions()
            Me.NestOptionsUserControl1 = New Magna.DualTester.Domino.UI.Views.MainView.SubViews.NestOptionsUserControl()
            Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.AmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.TravelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.RateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MemoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MirrorMotionItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.TableLayoutPanel3.SuspendLayout()
            Me.TableLayoutPanel4.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MirrorMotionItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'GridOptionsTesting
            '
            Me.GridOptionsTesting.AutoSize = True
            Me.GridOptionsTesting.BorderColor = System.Drawing.Color.Red
            Me.GridOptionsTesting.CellBorderColor = System.Drawing.Color.White
            Me.GridOptionsTesting.CheckedImage = Nothing
            Me.GridOptionsTesting.Cols = 7
            Me.GridOptionsTesting.CommentIndicatorColor = System.Drawing.Color.Black
            Me.GridOptionsTesting.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridOptionsTesting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GridOptionsTesting.GridColor = System.Drawing.Color.Transparent
            Me.GridOptionsTesting.HideGridLines = True
            Me.GridOptionsTesting.Location = New System.Drawing.Point(0, 325)
            Me.GridOptionsTesting.Margin = New System.Windows.Forms.Padding(0)
            Me.GridOptionsTesting.Name = "GridOptionsTesting"
            Me.GridOptionsTesting.Rows = 5
            Me.GridOptionsTesting.ScrollBars = FlexCell.ScrollBarsEnum.None
            Me.GridOptionsTesting.Size = New System.Drawing.Size(555, 80)
            Me.GridOptionsTesting.TabIndex = 0
            Me.GridOptionsTesting.UncheckedImage = Nothing
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.AutoSize = True
            Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.GridOptionsTesting, 0, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.TxtMessage, 0, 9)
            Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.TxtStep, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TxtAlarm, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 8)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 10
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(555, 645)
            Me.TableLayoutPanel1.TabIndex = 12
            '
            'TxtMessage
            '
            Me.TxtMessage.BackColor = System.Drawing.Color.Black
            Me.TxtMessage.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TxtMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtMessage.ForeColor = System.Drawing.Color.Lime
            Me.TxtMessage.Location = New System.Drawing.Point(0, 545)
            Me.TxtMessage.Margin = New System.Windows.Forms.Padding(0)
            Me.TxtMessage.Multiline = True
            Me.TxtMessage.Name = "TxtMessage"
            Me.TxtMessage.ReadOnly = True
            Me.TxtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtMessage.Size = New System.Drawing.Size(555, 100)
            Me.TxtMessage.TabIndex = 7
            Me.TxtMessage.Text = "PASSED"
            Me.TxtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Black
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(3, 305)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(549, 20)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Options Testing"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Black
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.White
            Me.Label2.Location = New System.Drawing.Point(3, 405)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(549, 20)
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "Mirror Motion"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TxtStep
            '
            Me.TxtStep.BackColor = System.Drawing.Color.Black
            Me.TxtStep.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TxtStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtStep.ForeColor = System.Drawing.Color.White
            Me.TxtStep.Location = New System.Drawing.Point(0, 0)
            Me.TxtStep.Margin = New System.Windows.Forms.Padding(0)
            Me.TxtStep.Name = "TxtStep"
            Me.TxtStep.ReadOnly = True
            Me.TxtStep.Size = New System.Drawing.Size(555, 24)
            Me.TxtStep.TabIndex = 12
            Me.TxtStep.Text = "Status"
            Me.TxtStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TxtAlarm
            '
            Me.TxtAlarm.BackColor = System.Drawing.Color.Black
            Me.TxtAlarm.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TxtAlarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtAlarm.ForeColor = System.Drawing.Color.Red
            Me.TxtAlarm.Location = New System.Drawing.Point(0, 24)
            Me.TxtAlarm.Margin = New System.Windows.Forms.Padding(0)
            Me.TxtAlarm.Name = "TxtAlarm"
            Me.TxtAlarm.ReadOnly = True
            Me.TxtAlarm.Size = New System.Drawing.Size(555, 24)
            Me.TxtAlarm.TabIndex = 13
            Me.TxtAlarm.Text = "No Alarms To Report"
            Me.TxtAlarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.AutoSize = True
            Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel2.ColumnCount = 1
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.NestPartOptions1, 0, 0)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 51)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(549, 231)
            Me.TableLayoutPanel2.TabIndex = 28
            '
            'TableLayoutPanel3
            '
            Me.TableLayoutPanel3.AutoSize = True
            Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel3.ColumnCount = 2
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel3.Controls.Add(Me.LblDetectedColor, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.LblTargetColor, 0, 0)
            Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 285)
            Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 1
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel3.Size = New System.Drawing.Size(555, 20)
            Me.TableLayoutPanel3.TabIndex = 29
            '
            'LblDetectedColor
            '
            Me.LblDetectedColor.AutoSize = True
            Me.LblDetectedColor.BackColor = System.Drawing.Color.Red
            Me.LblDetectedColor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblDetectedColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblDetectedColor.Location = New System.Drawing.Point(279, 2)
            Me.LblDetectedColor.Margin = New System.Windows.Forms.Padding(2)
            Me.LblDetectedColor.Name = "LblDetectedColor"
            Me.LblDetectedColor.Size = New System.Drawing.Size(274, 16)
            Me.LblDetectedColor.TabIndex = 3
            Me.LblDetectedColor.Text = "Detected Color: "
            Me.LblDetectedColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LblTargetColor
            '
            Me.LblTargetColor.AutoSize = True
            Me.LblTargetColor.BackColor = System.Drawing.SystemColors.Control
            Me.LblTargetColor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblTargetColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblTargetColor.Location = New System.Drawing.Point(3, 0)
            Me.LblTargetColor.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
            Me.LblTargetColor.Name = "LblTargetColor"
            Me.LblTargetColor.Size = New System.Drawing.Size(274, 20)
            Me.LblTargetColor.TabIndex = 4
            Me.LblTargetColor.Text = "TargetColor: "
            Me.LblTargetColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TableLayoutPanel4
            '
            Me.TableLayoutPanel4.ColumnCount = 2
            Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
            Me.TableLayoutPanel4.Controls.Add(Me.NestOptionsUserControl1, 1, 0)
            Me.TableLayoutPanel4.Controls.Add(Me.DataGridView1, 0, 0)
            Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 428)
            Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
            Me.TableLayoutPanel4.RowCount = 1
            Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel4.Size = New System.Drawing.Size(549, 114)
            Me.TableLayoutPanel4.TabIndex = 30
            '
            'DataGridView1
            '
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            Me.DataGridView1.AutoGenerateColumns = False
            Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TitleDataGridViewTextBoxColumn, Me.AmpDataGridViewTextBoxColumn, Me.TravelDataGridViewTextBoxColumn, Me.RateDataGridViewTextBoxColumn, Me.MemoryDataGridViewTextBoxColumn})
            Me.DataGridView1.DataSource = Me.MirrorMotionItemBindingSource
            Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.ReadOnly = True
            Me.DataGridView1.RowHeadersVisible = False
            Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.DataGridView1.Size = New System.Drawing.Size(461, 108)
            Me.DataGridView1.TabIndex = 31
            '
            'NestPartOptions1
            '
            Me.NestPartOptions1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.NestPartOptions1.Location = New System.Drawing.Point(3, 3)
            Me.NestPartOptions1.Name = "NestPartOptions1"
            Me.NestPartOptions1.Size = New System.Drawing.Size(543, 225)
            Me.NestPartOptions1.TabIndex = 13
            '
            'NestOptionsUserControl1
            '
            Me.NestOptionsUserControl1.AutoSize = True
            Me.NestOptionsUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.NestOptionsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.NestOptionsUserControl1.Location = New System.Drawing.Point(467, 0)
            Me.NestOptionsUserControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.NestOptionsUserControl1.Name = "NestOptionsUserControl1"
            Me.NestOptionsUserControl1.Size = New System.Drawing.Size(82, 114)
            Me.NestOptionsUserControl1.TabIndex = 12
            '
            'TitleDataGridViewTextBoxColumn
            '
            Me.TitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
            Me.TitleDataGridViewTextBoxColumn.HeaderText = "Direction"
            Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
            Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
            '
            'AmpDataGridViewTextBoxColumn
            '
            Me.AmpDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.AmpDataGridViewTextBoxColumn.DataPropertyName = "Amp"
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.AmpDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
            Me.AmpDataGridViewTextBoxColumn.HeaderText = "Amp"
            Me.AmpDataGridViewTextBoxColumn.Name = "AmpDataGridViewTextBoxColumn"
            Me.AmpDataGridViewTextBoxColumn.ReadOnly = True
            '
            'TravelDataGridViewTextBoxColumn
            '
            Me.TravelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.TravelDataGridViewTextBoxColumn.DataPropertyName = "Travel"
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.TravelDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
            Me.TravelDataGridViewTextBoxColumn.HeaderText = "Travel"
            Me.TravelDataGridViewTextBoxColumn.Name = "TravelDataGridViewTextBoxColumn"
            Me.TravelDataGridViewTextBoxColumn.ReadOnly = True
            '
            'RateDataGridViewTextBoxColumn
            '
            Me.RateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.RateDataGridViewTextBoxColumn.DataPropertyName = "Rate"
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.RateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
            Me.RateDataGridViewTextBoxColumn.HeaderText = "Rate"
            Me.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn"
            Me.RateDataGridViewTextBoxColumn.ReadOnly = True
            '
            'MemoryDataGridViewTextBoxColumn
            '
            Me.MemoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.MemoryDataGridViewTextBoxColumn.DataPropertyName = "Memory"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.MemoryDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
            Me.MemoryDataGridViewTextBoxColumn.HeaderText = "Memory"
            Me.MemoryDataGridViewTextBoxColumn.Name = "MemoryDataGridViewTextBoxColumn"
            Me.MemoryDataGridViewTextBoxColumn.ReadOnly = True
            '
            'MirrorMotionItemBindingSource
            '
            Me.MirrorMotionItemBindingSource.DataSource = GetType(Magna.DualTester.Domino.UI.Views.MainView.SubViews.MirrorMotionItem)
            '
            'NestDataControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Name = ""
            Me.Size = New System.Drawing.Size(555, 645)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.TableLayoutPanel3.PerformLayout()
            Me.TableLayoutPanel4.ResumeLayout(False)
            Me.TableLayoutPanel4.PerformLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MirrorMotionItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Nest1DataControl As FlexCell.Grid
        Friend WithEvents Nest2DataControl As FlexCell.Grid
        Friend WithEvents GridOptionsTesting As FlexCell.Grid
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TxtMessage As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TxtStep As System.Windows.Forms.TextBox
        Friend WithEvents TxtAlarm As System.Windows.Forms.TextBox
        Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents NestOptionsUserControl1 As NestOptionsUserControl
        Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents LblDetectedColor As System.Windows.Forms.Label
        Friend WithEvents LblTargetColor As System.Windows.Forms.Label
        Friend WithEvents NestPartOptions1 As NestPartOptions
        Friend WithEvents MirrorMotionItemBindingSource As BindingSource
        Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
        Friend WithEvents DataGridView1 As DataGridView
        Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents AmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents TravelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents RateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents MemoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    End Class
End Namespace