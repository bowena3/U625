<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uc_Coordinate
    Inherits System.Windows.Forms.UserControl

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
        Me.V_Sample_RawMax = New System.Windows.Forms.Button()
        Me.V_EuMax = New System.Windows.Forms.NumericUpDown()
        Me.lblRaw = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.V_RawMax = New System.Windows.Forms.Label()
        Me.V_Sample_RawMin = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.V_RawMin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.V_EuMin = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.H_Sample_RawMin = New System.Windows.Forms.Button()
        Me.H_Sample_RawMax = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.H_RawMin = New System.Windows.Forms.Label()
        Me.H_EuMin = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.H_RawMax = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.H_EuMax = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PartTypeName = New System.Windows.Forms.Label()
        Me.btnSaveAngleCal = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.V_EuMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.V_EuMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.H_EuMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.H_EuMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'V_Sample_RawMax
        '
        Me.V_Sample_RawMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.V_Sample_RawMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.V_Sample_RawMax.Enabled = False
        Me.V_Sample_RawMax.Location = New System.Drawing.Point(14, 3)
        Me.V_Sample_RawMax.Name = "V_Sample_RawMax"
        Me.V_Sample_RawMax.Size = New System.Drawing.Size(118, 28)
        Me.V_Sample_RawMax.TabIndex = 0
        Me.V_Sample_RawMax.Text = "Sample Raw UP"
        Me.V_Sample_RawMax.UseVisualStyleBackColor = False
        '
        'V_EuMax
        '
        Me.V_EuMax.DecimalPlaces = 1
        Me.V_EuMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_EuMax.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.V_EuMax.Location = New System.Drawing.Point(40, 42)
        Me.V_EuMax.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.V_EuMax.Name = "V_EuMax"
        Me.V_EuMax.Size = New System.Drawing.Size(69, 26)
        Me.V_EuMax.TabIndex = 2
        Me.V_EuMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRaw
        '
        Me.lblRaw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaw.Location = New System.Drawing.Point(1, 12)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Size = New System.Drawing.Size(53, 18)
        Me.lblRaw.TabIndex = 3
        Me.lblRaw.Text = "Raw"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pos. °"
        '
        'GroupBox
        '
        Me.GroupBox.AutoSize = True
        Me.GroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox.Controls.Add(Me.V_RawMax)
        Me.GroupBox.Controls.Add(Me.lblRaw)
        Me.GroupBox.Controls.Add(Me.V_EuMax)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox.Location = New System.Drawing.Point(3, 37)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(140, 87)
        Me.GroupBox.TabIndex = 5
        Me.GroupBox.TabStop = False
        '
        'V_RawMax
        '
        Me.V_RawMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.V_RawMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.V_RawMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_RawMax.Location = New System.Drawing.Point(40, 12)
        Me.V_RawMax.Name = "V_RawMax"
        Me.V_RawMax.Size = New System.Drawing.Size(69, 23)
        Me.V_RawMax.TabIndex = 7
        Me.V_RawMax.Text = "0"
        Me.V_RawMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'V_Sample_RawMin
        '
        Me.V_Sample_RawMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.V_Sample_RawMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.V_Sample_RawMin.Enabled = False
        Me.V_Sample_RawMin.Location = New System.Drawing.Point(14, 96)
        Me.V_Sample_RawMin.Name = "V_Sample_RawMin"
        Me.V_Sample_RawMin.Size = New System.Drawing.Size(118, 30)
        Me.V_Sample_RawMin.TabIndex = 6
        Me.V_Sample_RawMin.Text = "Sample Raw Down"
        Me.V_Sample_RawMin.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.V_RawMin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.V_EuMin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 87)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'V_RawMin
        '
        Me.V_RawMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.V_RawMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.V_RawMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_RawMin.Location = New System.Drawing.Point(40, 12)
        Me.V_RawMin.Name = "V_RawMin"
        Me.V_RawMin.Size = New System.Drawing.Size(69, 23)
        Me.V_RawMin.TabIndex = 8
        Me.V_RawMin.Text = "0"
        Me.V_RawMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Raw"
        '
        'V_EuMin
        '
        Me.V_EuMin.DecimalPlaces = 1
        Me.V_EuMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_EuMin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.V_EuMin.Location = New System.Drawing.Point(40, 42)
        Me.V_EuMin.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.V_EuMin.Minimum = New Decimal(New Integer() {12, 0, 0, -2147483648})
        Me.V_EuMin.Name = "V_EuMin"
        Me.V_EuMin.Size = New System.Drawing.Size(69, 26)
        Me.V_EuMin.TabIndex = 2
        Me.V_EuMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.V_EuMin.Value = New Decimal(New Integer() {100, 0, 0, -2147418112})
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pos. °"
        '
        'H_Sample_RawMin
        '
        Me.H_Sample_RawMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.H_Sample_RawMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.H_Sample_RawMin.Enabled = False
        Me.H_Sample_RawMin.Location = New System.Drawing.Point(3, 27)
        Me.H_Sample_RawMin.Name = "H_Sample_RawMin"
        Me.H_Sample_RawMin.Size = New System.Drawing.Size(51, 72)
        Me.H_Sample_RawMin.TabIndex = 8
        Me.H_Sample_RawMin.Text = "Sample Raw IB"
        Me.H_Sample_RawMin.UseVisualStyleBackColor = False
        '
        'H_Sample_RawMax
        '
        Me.H_Sample_RawMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.H_Sample_RawMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.H_Sample_RawMax.Enabled = False
        Me.H_Sample_RawMax.Location = New System.Drawing.Point(124, 27)
        Me.H_Sample_RawMax.Name = "H_Sample_RawMax"
        Me.H_Sample_RawMax.Size = New System.Drawing.Size(71, 72)
        Me.H_Sample_RawMax.TabIndex = 9
        Me.H_Sample_RawMax.Text = "Sample Raw OB"
        Me.H_Sample_RawMax.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.H_RawMin)
        Me.GroupBox2.Controls.Add(Me.H_EuMin)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(60, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 121)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pos. °"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Raw"
        '
        'H_RawMin
        '
        Me.H_RawMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.H_RawMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.H_RawMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H_RawMin.Location = New System.Drawing.Point(59, 8)
        Me.H_RawMin.Name = "H_RawMin"
        Me.H_RawMin.Size = New System.Drawing.Size(69, 23)
        Me.H_RawMin.TabIndex = 6
        Me.H_RawMin.Text = "0"
        Me.H_RawMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'H_EuMin
        '
        Me.H_EuMin.DecimalPlaces = 1
        Me.H_EuMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H_EuMin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.H_EuMin.Location = New System.Drawing.Point(59, 47)
        Me.H_EuMin.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.H_EuMin.Minimum = New Decimal(New Integer() {12, 0, 0, -2147483648})
        Me.H_EuMin.Name = "H_EuMin"
        Me.H_EuMin.Size = New System.Drawing.Size(69, 26)
        Me.H_EuMin.TabIndex = 2
        Me.H_EuMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.AutoSize = True
        Me.TableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 4
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(0, 0)
        Me.TableLayoutPanel7.TabIndex = 20
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.H_RawMax)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.H_EuMax)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(115, 121)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'H_RawMax
        '
        Me.H_RawMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.H_RawMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.H_RawMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H_RawMax.Location = New System.Drawing.Point(40, 10)
        Me.H_RawMax.Name = "H_RawMax"
        Me.H_RawMax.Size = New System.Drawing.Size(69, 23)
        Me.H_RawMax.TabIndex = 5
        Me.H_RawMax.Text = "0"
        Me.H_RawMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Raw"
        '
        'H_EuMax
        '
        Me.H_EuMax.DecimalPlaces = 1
        Me.H_EuMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H_EuMax.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.H_EuMax.Location = New System.Drawing.Point(40, 42)
        Me.H_EuMax.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.H_EuMax.Name = "H_EuMax"
        Me.H_EuMax.Size = New System.Drawing.Size(69, 26)
        Me.H_EuMax.TabIndex = 2
        Me.H_EuMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Pos. °"
        '
        'PartTypeName
        '
        Me.PartTypeName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PartTypeName.BackColor = System.Drawing.Color.White
        Me.PartTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PartTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartTypeName.Location = New System.Drawing.Point(3, 0)
        Me.PartTypeName.Name = "PartTypeName"
        Me.PartTypeName.Size = New System.Drawing.Size(559, 23)
        Me.PartTypeName.TabIndex = 12
        Me.PartTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSaveAngleCal
        '
        Me.btnSaveAngleCal.AutoSize = True
        Me.btnSaveAngleCal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveAngleCal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSaveAngleCal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveAngleCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAngleCal.Location = New System.Drawing.Point(358, 269)
        Me.btnSaveAngleCal.Name = "btnSaveAngleCal"
        Me.btnSaveAngleCal.Size = New System.Drawing.Size(198, 129)
        Me.btnSaveAngleCal.TabIndex = 13
        Me.btnSaveAngleCal.Text = "Save Angle Cal Values"
        Me.btnSaveAngleCal.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 129)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Get Current Calibration"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInstruction.Location = New System.Drawing.Point(206, 133)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(146, 133)
        Me.lblInstruction.TabIndex = 15
        Me.lblInstruction.Text = "You will need to supply the achived angles for each quadrant"
        Me.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PartTypeName, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(565, 430)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoScroll = True
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel6, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblInstruction, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSaveAngleCal, 2, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 26)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(559, 401)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = True
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.H_Sample_RawMin, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 136)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(197, 127)
        Me.TableLayoutPanel5.TabIndex = 18
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.AutoSize = True
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBox3, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.H_Sample_RawMax, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(358, 136)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(198, 127)
        Me.TableLayoutPanel6.TabIndex = 19
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.V_Sample_RawMin, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(206, 269)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(146, 129)
        Me.TableLayoutPanel4.TabIndex = 19
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.V_Sample_RawMax, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(206, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(146, 127)
        Me.TableLayoutPanel3.TabIndex = 18
        '
        'Uc_Coordinate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Uc_Coordinate"
        Me.Size = New System.Drawing.Size(565, 430)
        CType(Me.V_EuMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.V_EuMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.H_EuMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.H_EuMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents V_Sample_RawMax As Button
    Private WithEvents V_EuMax As NumericUpDown
    Private WithEvents lblRaw As Label
    Private WithEvents Label1 As Label
    Private WithEvents GroupBox As GroupBox
    Private WithEvents V_Sample_RawMin As Button
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents Label2 As Label
    Private WithEvents V_EuMin As NumericUpDown
    Private WithEvents Label3 As Label
    Private WithEvents H_Sample_RawMin As Button
    Private WithEvents H_Sample_RawMax As Button
    Private WithEvents GroupBox2 As GroupBox
    Private WithEvents Label4 As Label
    Private WithEvents H_EuMin As NumericUpDown
    Private WithEvents Label5 As Label
    Private WithEvents GroupBox3 As GroupBox
    Private WithEvents Label6 As Label
    Private WithEvents H_EuMax As NumericUpDown
    Private WithEvents Label7 As Label
    Private WithEvents PartTypeName As Label
    Private WithEvents btnSaveAngleCal As Button
    Private WithEvents V_RawMax As Label
    Private WithEvents V_RawMin As Label
    Private WithEvents H_RawMin As Label
    Private WithEvents H_RawMax As Label
    Private WithEvents Button1 As Button
    Private WithEvents lblInstruction As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
End Class
