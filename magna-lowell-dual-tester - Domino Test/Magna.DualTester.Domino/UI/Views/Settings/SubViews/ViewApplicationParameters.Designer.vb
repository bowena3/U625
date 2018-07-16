
Namespace UI.Views.Settings.SubViews

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ViewApplicationParameters
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabSequenceStrings = New System.Windows.Forms.TabPage()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GridSequenceStrings = New System.Windows.Forms.DataGridView()
            Me.SequeceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.TabAlarmStrings = New System.Windows.Forms.TabPage()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GridAlarms = New System.Windows.Forms.DataGridView()
            Me.AlarmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.TabPartFaults = New System.Windows.Forms.TabPage()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.GridPartFaults = New System.Windows.Forms.DataGridView()
            Me.PartFaultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.TabColors = New System.Windows.Forms.TabPage()
            Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.GridColors = New System.Windows.Forms.DataGridView()
            Me.IndexDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ColorModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.IndexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.English = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Spanish = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IndexDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IndexDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.TabControl1.SuspendLayout()
            Me.TabSequenceStrings.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.GridSequenceStrings, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SequeceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabAlarmStrings.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            CType(Me.GridAlarms, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AlarmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPartFaults.SuspendLayout()
            Me.TableLayoutPanel3.SuspendLayout()
            CType(Me.GridPartFaults, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PartFaultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabColors.SuspendLayout()
            Me.TableLayoutPanel4.SuspendLayout()
            CType(Me.GridColors, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ColorModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabSequenceStrings)
            Me.TabControl1.Controls.Add(Me.TabAlarmStrings)
            Me.TabControl1.Controls.Add(Me.TabPartFaults)
            Me.TabControl1.Controls.Add(Me.TabColors)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(763, 540)
            Me.TabControl1.TabIndex = 0
            '
            'TabSequenceStrings
            '
            Me.TabSequenceStrings.Controls.Add(Me.TableLayoutPanel1)
            Me.TabSequenceStrings.Location = New System.Drawing.Point(4, 22)
            Me.TabSequenceStrings.Name = "TabSequenceStrings"
            Me.TabSequenceStrings.Padding = New System.Windows.Forms.Padding(3)
            Me.TabSequenceStrings.Size = New System.Drawing.Size(755, 514)
            Me.TabSequenceStrings.TabIndex = 0
            Me.TabSequenceStrings.Text = "Sequence Strings"
            Me.TabSequenceStrings.UseVisualStyleBackColor = True
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.GridSequenceStrings, 0, 1)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(749, 508)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(743, 25)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Sequence Strings"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'GridSequenceStrings
            '
            Me.GridSequenceStrings.AllowUserToAddRows = False
            Me.GridSequenceStrings.AllowUserToDeleteRows = False
            Me.GridSequenceStrings.AutoGenerateColumns = False
            Me.GridSequenceStrings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.GridSequenceStrings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IndexDataGridViewTextBoxColumn, Me.English, Me.Spanish})
            Me.GridSequenceStrings.DataSource = Me.SequeceBindingSource
            Me.GridSequenceStrings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridSequenceStrings.Location = New System.Drawing.Point(3, 28)
            Me.GridSequenceStrings.Name = "GridSequenceStrings"
            Me.GridSequenceStrings.Size = New System.Drawing.Size(743, 477)
            Me.GridSequenceStrings.TabIndex = 1
            '
            'SequeceBindingSource
            '
            Me.SequeceBindingSource.DataSource = GetType(Magna.DualTester.Core.Data.EnglishSpanishMap)
            '
            'TabAlarmStrings
            '
            Me.TabAlarmStrings.Controls.Add(Me.TableLayoutPanel2)
            Me.TabAlarmStrings.Location = New System.Drawing.Point(4, 22)
            Me.TabAlarmStrings.Name = "TabAlarmStrings"
            Me.TabAlarmStrings.Padding = New System.Windows.Forms.Padding(3)
            Me.TabAlarmStrings.Size = New System.Drawing.Size(755, 514)
            Me.TabAlarmStrings.TabIndex = 1
            Me.TabAlarmStrings.Text = "Alarm Strings"
            Me.TabAlarmStrings.UseVisualStyleBackColor = True
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.ColumnCount = 1
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.GridAlarms, 0, 1)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 2
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(749, 508)
            Me.TableLayoutPanel2.TabIndex = 1
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(3, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(743, 25)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Alarm Strings"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'GridAlarms
            '
            Me.GridAlarms.AllowUserToAddRows = False
            Me.GridAlarms.AllowUserToDeleteRows = False
            Me.GridAlarms.AutoGenerateColumns = False
            Me.GridAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.GridAlarms.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IndexDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
            Me.GridAlarms.DataSource = Me.AlarmBindingSource
            Me.GridAlarms.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridAlarms.Location = New System.Drawing.Point(3, 28)
            Me.GridAlarms.Name = "GridAlarms"
            Me.GridAlarms.Size = New System.Drawing.Size(743, 477)
            Me.GridAlarms.TabIndex = 1
            '
            'AlarmBindingSource
            '
            Me.AlarmBindingSource.DataSource = GetType(Magna.DualTester.Core.Data.EnglishSpanishMap)
            '
            'TabPartFaults
            '
            Me.TabPartFaults.Controls.Add(Me.TableLayoutPanel3)
            Me.TabPartFaults.Location = New System.Drawing.Point(4, 22)
            Me.TabPartFaults.Name = "TabPartFaults"
            Me.TabPartFaults.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPartFaults.Size = New System.Drawing.Size(755, 514)
            Me.TabPartFaults.TabIndex = 2
            Me.TabPartFaults.Text = "Part Faults"
            Me.TabPartFaults.UseVisualStyleBackColor = True
            '
            'TableLayoutPanel3
            '
            Me.TableLayoutPanel3.ColumnCount = 1
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.GridPartFaults, 0, 1)
            Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 2
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel3.Size = New System.Drawing.Size(749, 508)
            Me.TableLayoutPanel3.TabIndex = 1
            '
            'Label3
            '
            Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(3, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(743, 25)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Part Faults"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'GridPartFaults
            '
            Me.GridPartFaults.AllowUserToAddRows = False
            Me.GridPartFaults.AllowUserToDeleteRows = False
            Me.GridPartFaults.AutoGenerateColumns = False
            Me.GridPartFaults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.GridPartFaults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IndexDataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
            Me.GridPartFaults.DataSource = Me.PartFaultBindingSource
            Me.GridPartFaults.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridPartFaults.Location = New System.Drawing.Point(3, 28)
            Me.GridPartFaults.Name = "GridPartFaults"
            Me.GridPartFaults.Size = New System.Drawing.Size(743, 477)
            Me.GridPartFaults.TabIndex = 1
            '
            'PartFaultBindingSource
            '
            Me.PartFaultBindingSource.DataSource = GetType(Magna.DualTester.Core.Data.EnglishSpanishMap)
            '
            'TabColors
            '
            Me.TabColors.Controls.Add(Me.TableLayoutPanel4)
            Me.TabColors.Location = New System.Drawing.Point(4, 22)
            Me.TabColors.Name = "TabColors"
            Me.TabColors.Padding = New System.Windows.Forms.Padding(3)
            Me.TabColors.Size = New System.Drawing.Size(755, 514)
            Me.TabColors.TabIndex = 3
            Me.TabColors.Text = "Colors"
            Me.TabColors.UseVisualStyleBackColor = True
            '
            'TableLayoutPanel4
            '
            Me.TableLayoutPanel4.ColumnCount = 1
            Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 0)
            Me.TableLayoutPanel4.Controls.Add(Me.GridColors, 0, 1)
            Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
            Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
            Me.TableLayoutPanel4.RowCount = 2
            Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel4.Size = New System.Drawing.Size(749, 508)
            Me.TableLayoutPanel4.TabIndex = 1
            '
            'Label4
            '
            Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(3, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(743, 25)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Colors"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'GridColors
            '
            Me.GridColors.AllowUserToAddRows = False
            Me.GridColors.AllowUserToDeleteRows = False
            Me.GridColors.AutoGenerateColumns = False
            Me.GridColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.GridColors.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IndexDataGridViewTextBoxColumn3, Me.PcodeDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn})
            Me.GridColors.DataSource = Me.ColorModelBindingSource
            Me.GridColors.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridColors.Location = New System.Drawing.Point(3, 28)
            Me.GridColors.Name = "GridColors"
            Me.GridColors.Size = New System.Drawing.Size(743, 477)
            Me.GridColors.TabIndex = 1
            '
            'IndexDataGridViewTextBoxColumn3
            '
            Me.IndexDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.IndexDataGridViewTextBoxColumn3.DataPropertyName = "Index"
            Me.IndexDataGridViewTextBoxColumn3.HeaderText = "Index"
            Me.IndexDataGridViewTextBoxColumn3.Name = "IndexDataGridViewTextBoxColumn3"
            Me.IndexDataGridViewTextBoxColumn3.Width = 58
            '
            'PcodeDataGridViewTextBoxColumn
            '
            Me.PcodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.PcodeDataGridViewTextBoxColumn.DataPropertyName = "Pcode"
            Me.PcodeDataGridViewTextBoxColumn.FillWeight = 50.0!
            Me.PcodeDataGridViewTextBoxColumn.HeaderText = "Pcode"
            Me.PcodeDataGridViewTextBoxColumn.Name = "PcodeDataGridViewTextBoxColumn"
            '
            'NameDataGridViewTextBoxColumn
            '
            Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
            Me.NameDataGridViewTextBoxColumn.FillWeight = 50.0!
            Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
            Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
            '
            'ColorModelBindingSource
            '
            Me.ColorModelBindingSource.DataSource = GetType(Magna.DualTester.Core.ColorModel)
            '
            'IndexDataGridViewTextBoxColumn
            '
            Me.IndexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.IndexDataGridViewTextBoxColumn.DataPropertyName = "Index"
            Me.IndexDataGridViewTextBoxColumn.HeaderText = "Index"
            Me.IndexDataGridViewTextBoxColumn.Name = "IndexDataGridViewTextBoxColumn"
            Me.IndexDataGridViewTextBoxColumn.Width = 58
            '
            'English
            '
            Me.English.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.English.DataPropertyName = "English"
            Me.English.FillWeight = 50.0!
            Me.English.HeaderText = "English"
            Me.English.Name = "English"
            '
            'Spanish
            '
            Me.Spanish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.Spanish.DataPropertyName = "Spanish"
            Me.Spanish.FillWeight = 50.0!
            Me.Spanish.HeaderText = "Spanish"
            Me.Spanish.Name = "Spanish"
            '
            'IndexDataGridViewTextBoxColumn1
            '
            Me.IndexDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.IndexDataGridViewTextBoxColumn1.DataPropertyName = "Index"
            Me.IndexDataGridViewTextBoxColumn1.HeaderText = "Index"
            Me.IndexDataGridViewTextBoxColumn1.Name = "IndexDataGridViewTextBoxColumn1"
            Me.IndexDataGridViewTextBoxColumn1.Width = 58
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "English"
            Me.DataGridViewTextBoxColumn3.FillWeight = 50.0!
            Me.DataGridViewTextBoxColumn3.HeaderText = "English"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "Spanish"
            Me.DataGridViewTextBoxColumn4.FillWeight = 50.0!
            Me.DataGridViewTextBoxColumn4.HeaderText = "Spanish"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            '
            'IndexDataGridViewTextBoxColumn2
            '
            Me.IndexDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.IndexDataGridViewTextBoxColumn2.DataPropertyName = "Index"
            Me.IndexDataGridViewTextBoxColumn2.HeaderText = "Index"
            Me.IndexDataGridViewTextBoxColumn2.Name = "IndexDataGridViewTextBoxColumn2"
            Me.IndexDataGridViewTextBoxColumn2.Width = 58
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "English"
            Me.DataGridViewTextBoxColumn1.FillWeight = 50.0!
            Me.DataGridViewTextBoxColumn1.HeaderText = "English"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.DataGridViewTextBoxColumn2.DataPropertyName = "Spanish"
            Me.DataGridViewTextBoxColumn2.FillWeight = 50.0!
            Me.DataGridViewTextBoxColumn2.HeaderText = "Spanish"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            '
            'ViewApplicationParameters
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.Controls.Add(Me.TabControl1)
            Me.Name = "ViewApplicationParameters"
            Me.Size = New System.Drawing.Size(763, 540)
            Me.TabControl1.ResumeLayout(False)
            Me.TabSequenceStrings.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            CType(Me.GridSequenceStrings, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SequeceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabAlarmStrings.ResumeLayout(False)
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel2.PerformLayout()
            CType(Me.GridAlarms, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AlarmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPartFaults.ResumeLayout(False)
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.TableLayoutPanel3.PerformLayout()
            CType(Me.GridPartFaults, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PartFaultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabColors.ResumeLayout(False)
            Me.TableLayoutPanel4.ResumeLayout(False)
            Me.TableLayoutPanel4.PerformLayout()
            CType(Me.GridColors, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ColorModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabSequenceStrings As System.Windows.Forms.TabPage
        Friend WithEvents TabAlarmStrings As System.Windows.Forms.TabPage
        Friend WithEvents TabPartFaults As System.Windows.Forms.TabPage
        Friend WithEvents TabColors As System.Windows.Forms.TabPage
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents Label1 As Label
        Friend WithEvents GridSequenceStrings As DataGridView
        Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
        Friend WithEvents Label2 As Label
        Friend WithEvents GridAlarms As DataGridView
        Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
        Friend WithEvents Label3 As Label
        Friend WithEvents GridPartFaults As DataGridView
        Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
        Friend WithEvents Label4 As Label
        Friend WithEvents GridColors As DataGridView
        Friend WithEvents EnglishStringDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents SpanishStringDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents SequeceBindingSource As BindingSource
        Friend WithEvents EnglishStringDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents SpanishStringDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents AlarmBindingSource As BindingSource
        Friend WithEvents EnglishStringDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents SpanishStringDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents PartFaultBindingSource As BindingSource
        Friend WithEvents IndexDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents PcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ColorModelBindingSource As BindingSource
        Friend WithEvents IndexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents English As DataGridViewTextBoxColumn
        Friend WithEvents Spanish As DataGridViewTextBoxColumn
        Friend WithEvents IndexDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents IndexDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    End Class
End NameSpace