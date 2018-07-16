Namespace UI.Views.Settings.SubViews
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ViewShiftSetup
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GrpAutoLabel = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtLabelRequestPath = New System.Windows.Forms.TextBox()
        Me.TxtPrinterId = New System.Windows.Forms.TextBox()
        Me.ChkAutoTote = New System.Windows.Forms.CheckBox()
        Me.BtnFileDialog = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
            Me.ComboBarCodeScannerCom = New System.Windows.Forms.ComboBox()
            Me.ComboPartLabelCom = New System.Windows.Forms.ComboBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.TxtPlcIp = New System.Windows.Forms.TextBox()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.GrpShift = New System.Windows.Forms.GroupBox()
            Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Txt1stStart = New System.Windows.Forms.TextBox()
            Me.Txt2ndStart = New System.Windows.Forms.TextBox()
            Me.Txt3rdStart = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
            Me.TxtAssetNumber = New System.Windows.Forms.TextBox()
            Me.TxtName = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.TableLayoutPanel1.SuspendLayout()
            Me.GrpAutoLabel.SuspendLayout()
            Me.TableLayoutPanel6.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.TableLayoutPanel10.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.GrpShift.SuspendLayout()
            Me.TableLayoutPanel4.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.TableLayoutPanel7.SuspendLayout()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.AutoSize = True
            Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel1.ColumnCount = 3
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.GrpAutoLabel, 1, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 1, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 5
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(1340, 336)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'GrpAutoLabel
            '
            Me.GrpAutoLabel.AutoSize = True
            Me.GrpAutoLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.GrpAutoLabel.Controls.Add(Me.TableLayoutPanel6)
            Me.GrpAutoLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GrpAutoLabel.Location = New System.Drawing.Point(70, 219)
            Me.GrpAutoLabel.Name = "GrpAutoLabel"
            Me.GrpAutoLabel.Size = New System.Drawing.Size(1200, 73)
            Me.GrpAutoLabel.TabIndex = 2
            Me.GrpAutoLabel.TabStop = False
            Me.GrpAutoLabel.Text = "Auto Label Lite"
            Me.GrpAutoLabel.Visible = False
            '
            'TableLayoutPanel6
            '
            Me.TableLayoutPanel6.AutoSize = True
            Me.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel6.ColumnCount = 5
            Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.96206!))
            Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.96206!))
            Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.832574!))
            Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.2433!))
            Me.TableLayoutPanel6.Controls.Add(Me.Label12, 0, 0)
            Me.TableLayoutPanel6.Controls.Add(Me.Label13, 0, 1)
            Me.TableLayoutPanel6.Controls.Add(Me.TxtLabelRequestPath, 1, 0)
            Me.TableLayoutPanel6.Controls.Add(Me.TxtPrinterId, 1, 1)
            Me.TableLayoutPanel6.Controls.Add(Me.ChkAutoTote, 4, 0)
            Me.TableLayoutPanel6.Controls.Add(Me.BtnFileDialog, 2, 0)
            Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 16)
            Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
            Me.TableLayoutPanel6.RowCount = 2
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel6.Size = New System.Drawing.Size(1194, 54)
            Me.TableLayoutPanel6.TabIndex = 0
            '
            'Label12
            '
            Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(3, 7)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(284, 13)
            Me.Label12.TabIndex = 0
            Me.Label12.Text = "Auto Label Lite Request Path"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label13
            '
            Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(3, 34)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(284, 13)
            Me.Label13.TabIndex = 1
            Me.Label13.Text = "Tote Label Printer ID"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtLabelRequestPath
            '
            Me.TxtLabelRequestPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtLabelRequestPath.Location = New System.Drawing.Point(293, 4)
            Me.TxtLabelRequestPath.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
            Me.TxtLabelRequestPath.Name = "TxtLabelRequestPath"
            Me.TxtLabelRequestPath.Size = New System.Drawing.Size(287, 20)
            Me.TxtLabelRequestPath.TabIndex = 2
            '
            'TxtPrinterId
            '
            Me.TxtPrinterId.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtPrinterId.Location = New System.Drawing.Point(293, 31)
            Me.TxtPrinterId.Name = "TxtPrinterId"
            Me.TxtPrinterId.Size = New System.Drawing.Size(284, 20)
            Me.TxtPrinterId.TabIndex = 3
            '
            'ChkAutoTote
            '
            Me.ChkAutoTote.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ChkAutoTote.AutoSize = True
            Me.ChkAutoTote.Location = New System.Drawing.Point(645, 5)
            Me.ChkAutoTote.Name = "ChkAutoTote"
            Me.ChkAutoTote.Size = New System.Drawing.Size(546, 17)
            Me.ChkAutoTote.TabIndex = 4
            Me.ChkAutoTote.Text = "Auto Tote Label Request When Tote Is Done"
            Me.ChkAutoTote.UseVisualStyleBackColor = True
            '
            'BtnFileDialog
            '
            Me.BtnFileDialog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnFileDialog.Location = New System.Drawing.Point(580, 3)
            Me.BtnFileDialog.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
            Me.BtnFileDialog.Name = "BtnFileDialog"
            Me.BtnFileDialog.Size = New System.Drawing.Size(30, 22)
            Me.BtnFileDialog.TabIndex = 5
            Me.BtnFileDialog.Text = "..."
            Me.BtnFileDialog.UseVisualStyleBackColor = True
            '
            'GroupBox3
            '
            Me.GroupBox3.AutoSize = True
            Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.GroupBox3.Controls.Add(Me.TableLayoutPanel10)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox3.Location = New System.Drawing.Point(70, 127)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(1200, 86)
            Me.GroupBox3.TabIndex = 1
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Device Connections"
            '
            'TableLayoutPanel10
            '
            Me.TableLayoutPanel10.AutoSize = True
            Me.TableLayoutPanel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel10.ColumnCount = 5
            Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.83249!))
            Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.56345!))
            Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.98985!))
            Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.85279!))
            Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.76143!))
            Me.TableLayoutPanel10.Controls.Add(Me.Label6, 0, 1)
            Me.TableLayoutPanel10.Controls.Add(Me.Label7, 0, 2)
            Me.TableLayoutPanel10.Controls.Add(Me.Label8, 2, 1)
            Me.TableLayoutPanel10.Controls.Add(Me.ComboBarCodeScannerCom, 1, 1)
            Me.TableLayoutPanel10.Controls.Add(Me.ComboPartLabelCom, 1, 2)
            Me.TableLayoutPanel10.Controls.Add(Me.Label11, 1, 0)
            Me.TableLayoutPanel10.Controls.Add(Me.TxtPlcIp, 3, 1)
            Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 16)
            Me.TableLayoutPanel10.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
            Me.TableLayoutPanel10.RowCount = 4
            Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel10.Size = New System.Drawing.Size(1194, 67)
            Me.TableLayoutPanel10.TabIndex = 1
            '
            'Label6
            '
            Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(3, 20)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(338, 13)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Bar Code Scanner"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label7
            '
            Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(3, 47)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(338, 13)
            Me.Label7.TabIndex = 1
            Me.Label7.Text = "Part Label"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label7.Visible = False
            '
            'Label8
            '
            Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(556, 20)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(304, 13)
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "Plc Ip Address"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'ComboBarCodeScannerCom
            '
            Me.ComboBarCodeScannerCom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ComboBarCodeScannerCom.FormattingEnabled = True
            Me.ComboBarCodeScannerCom.Location = New System.Drawing.Point(347, 16)
            Me.ComboBarCodeScannerCom.Name = "ComboBarCodeScannerCom"
            Me.ComboBarCodeScannerCom.Size = New System.Drawing.Size(203, 21)
            Me.ComboBarCodeScannerCom.TabIndex = 5
            '
            'ComboPartLabelCom
            '
            Me.ComboPartLabelCom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ComboPartLabelCom.FormattingEnabled = True
            Me.ComboPartLabelCom.Location = New System.Drawing.Point(347, 43)
            Me.ComboPartLabelCom.Name = "ComboPartLabelCom"
            Me.ComboPartLabelCom.Size = New System.Drawing.Size(203, 21)
            Me.ComboPartLabelCom.TabIndex = 6
            Me.ComboPartLabelCom.Visible = False
            '
            'Label11
            '
            Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(347, 0)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(203, 13)
            Me.Label11.TabIndex = 10
            Me.Label11.Text = "RS232 Comm Ports"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'TxtPlcIp
            '
            Me.TxtPlcIp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtPlcIp.Location = New System.Drawing.Point(866, 16)
            Me.TxtPlcIp.Name = "TxtPlcIp"
            Me.TxtPlcIp.Size = New System.Drawing.Size(195, 20)
            Me.TxtPlcIp.TabIndex = 7
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.AutoSize = True
            Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel2.ColumnCount = 2
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.GrpShift, 1, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(70, 44)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(1200, 77)
            Me.TableLayoutPanel2.TabIndex = 0
            '
            'GrpShift
            '
            Me.GrpShift.AutoSize = True
            Me.GrpShift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.GrpShift.Controls.Add(Me.TableLayoutPanel4)
            Me.GrpShift.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GrpShift.Location = New System.Drawing.Point(603, 3)
            Me.GrpShift.Name = "GrpShift"
            Me.GrpShift.Size = New System.Drawing.Size(594, 71)
            Me.GrpShift.TabIndex = 1
            Me.GrpShift.TabStop = False
            Me.GrpShift.Text = "Shift Setup"
            '
            'TableLayoutPanel4
            '
            Me.TableLayoutPanel4.AutoSize = True
            Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel4.ColumnCount = 3
            Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
            Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
            Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 0)
            Me.TableLayoutPanel4.Controls.Add(Me.Label4, 1, 0)
            Me.TableLayoutPanel4.Controls.Add(Me.Label5, 2, 0)
            Me.TableLayoutPanel4.Controls.Add(Me.Txt1stStart, 0, 1)
            Me.TableLayoutPanel4.Controls.Add(Me.Txt2ndStart, 1, 1)
            Me.TableLayoutPanel4.Controls.Add(Me.Txt3rdStart, 2, 1)
            Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 16)
            Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
            Me.TableLayoutPanel4.RowCount = 2
            Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.0625!))
            Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.9375!))
            Me.TableLayoutPanel4.Size = New System.Drawing.Size(588, 52)
            Me.TableLayoutPanel4.TabIndex = 0
            '
            'Label3
            '
            Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(3, 7)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(189, 13)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "1st Start"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(198, 7)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(190, 13)
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "2nd Start"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label5
            '
            Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(394, 7)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(191, 13)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = "3rd Start"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Txt1stStart
            '
            Me.Txt1stStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Txt1stStart.Location = New System.Drawing.Point(3, 23)
            Me.Txt1stStart.Name = "Txt1stStart"
            Me.Txt1stStart.Size = New System.Drawing.Size(189, 20)
            Me.Txt1stStart.TabIndex = 3
            '
            'Txt2ndStart
            '
            Me.Txt2ndStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Txt2ndStart.Location = New System.Drawing.Point(198, 23)
            Me.Txt2ndStart.Name = "Txt2ndStart"
            Me.Txt2ndStart.Size = New System.Drawing.Size(190, 20)
            Me.Txt2ndStart.TabIndex = 4
            '
            'Txt3rdStart
            '
            Me.Txt3rdStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Txt3rdStart.Location = New System.Drawing.Point(394, 23)
            Me.Txt3rdStart.Name = "Txt3rdStart"
            Me.Txt3rdStart.Size = New System.Drawing.Size(191, 20)
            Me.Txt3rdStart.TabIndex = 5
            '
            'GroupBox1
            '
            Me.GroupBox1.AutoSize = True
            Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.GroupBox1.BackColor = System.Drawing.Color.LightCoral
            Me.GroupBox1.Controls.Add(Me.TableLayoutPanel7)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(594, 71)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Identification"
            Me.GroupBox1.Visible = False
            '
            'TableLayoutPanel7
            '
            Me.TableLayoutPanel7.AutoSize = True
            Me.TableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel7.ColumnCount = 2
            Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel7.Controls.Add(Me.TxtAssetNumber, 1, 1)
            Me.TableLayoutPanel7.Controls.Add(Me.TxtName, 1, 0)
            Me.TableLayoutPanel7.Controls.Add(Me.Label1, 0, 1)
            Me.TableLayoutPanel7.Controls.Add(Me.Label2, 0, 0)
            Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 16)
            Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
            Me.TableLayoutPanel7.RowCount = 2
            Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel7.Size = New System.Drawing.Size(588, 52)
            Me.TableLayoutPanel7.TabIndex = 5
            '
            'TxtAssetNumber
            '
            Me.TxtAssetNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtAssetNumber.Location = New System.Drawing.Point(297, 29)
            Me.TxtAssetNumber.Name = "TxtAssetNumber"
            Me.TxtAssetNumber.Size = New System.Drawing.Size(288, 20)
            Me.TxtAssetNumber.TabIndex = 2
            '
            'TxtName
            '
            Me.TxtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtName.Location = New System.Drawing.Point(297, 3)
            Me.TxtName.Name = "TxtName"
            Me.TxtName.Size = New System.Drawing.Size(288, 20)
            Me.TxtName.TabIndex = 2
            '
            'Label1
            '
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(218, 32)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(73, 13)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Asset Number"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(256, 6)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(35, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Name"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'ErrorProvider1
            '
            Me.ErrorProvider1.ContainerControl = Me
            '
            'SaveFileDialog1
            '
            Me.SaveFileDialog1.FileName = "requestfile"
            Me.SaveFileDialog1.Filter = "REQ File|*.req"
            '
            'ViewShiftSetup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Name = "ViewShiftSetup"
            Me.Size = New System.Drawing.Size(1340, 336)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.GrpAutoLabel.ResumeLayout(False)
            Me.GrpAutoLabel.PerformLayout
        Me.TableLayoutPanel6.ResumeLayout(false)
        Me.TableLayoutPanel6.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.TableLayoutPanel10.ResumeLayout(false)
        Me.TableLayoutPanel10.PerformLayout
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.GrpShift.ResumeLayout(false)
        Me.GrpShift.PerformLayout
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.TableLayoutPanel4.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.TableLayoutPanel7.ResumeLayout(false)
        Me.TableLayoutPanel7.PerformLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents GrpAutoLabel As System.Windows.Forms.GroupBox
        Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents GrpShift As System.Windows.Forms.GroupBox
        Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents TxtLabelRequestPath As System.Windows.Forms.TextBox
        Friend WithEvents TxtPrinterId As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Txt1stStart As System.Windows.Forms.TextBox
        Friend WithEvents Txt2ndStart As System.Windows.Forms.TextBox
        Friend WithEvents Txt3rdStart As System.Windows.Forms.TextBox
        Friend WithEvents ChkAutoTote As System.Windows.Forms.CheckBox
        Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents ComboBarCodeScannerCom As System.Windows.Forms.ComboBox
        Friend WithEvents ComboPartLabelCom As System.Windows.Forms.ComboBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TxtAssetNumber As System.Windows.Forms.TextBox
        Friend WithEvents TxtName As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents BtnFileDialog As System.Windows.Forms.Button
        Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
        Friend WithEvents TxtPlcIp As System.Windows.Forms.TextBox
        Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
        Friend WithEvents ToolTip1 As ToolTip
    End Class
End Namespace