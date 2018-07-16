<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadingDialog))
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblPlcStatus = New System.Windows.Forms.Label()
        Me.LblBarcodeStat = New System.Windows.Forms.Label()
        Me.PicBarcode = New System.Windows.Forms.PictureBox()
        Me.PicPlc = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PicBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPlc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Location = New System.Drawing.Point(3, 69)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(506, 62)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LblPlcStatus, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LblBarcodeStat, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PicBarcode, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PicPlc, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(506, 60)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(30, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PLC Connection:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(30, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Barcode Scanner:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPlcStatus
        '
        Me.LblPlcStatus.AutoSize = True
        Me.LblPlcStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPlcStatus.Location = New System.Drawing.Point(126, 0)
        Me.LblPlcStatus.Name = "LblPlcStatus"
        Me.LblPlcStatus.Size = New System.Drawing.Size(377, 30)
        Me.LblPlcStatus.TabIndex = 7
        Me.LblPlcStatus.Text = " "
        Me.LblPlcStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblBarcodeStat
        '
        Me.LblBarcodeStat.AutoSize = True
        Me.LblBarcodeStat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblBarcodeStat.Location = New System.Drawing.Point(126, 30)
        Me.LblBarcodeStat.Name = "LblBarcodeStat"
        Me.LblBarcodeStat.Size = New System.Drawing.Size(377, 30)
        Me.LblBarcodeStat.TabIndex = 8
        Me.LblBarcodeStat.Text = " "
        Me.LblBarcodeStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PicBarcode
        '
        Me.PicBarcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicBarcode.Image = CType(resources.GetObject("PicBarcode.Image"), System.Drawing.Image)
        Me.PicBarcode.InitialImage = CType(resources.GetObject("PicBarcode.InitialImage"), System.Drawing.Image)
        Me.PicBarcode.Location = New System.Drawing.Point(3, 33)
        Me.PicBarcode.Name = "PicBarcode"
        Me.PicBarcode.Size = New System.Drawing.Size(21, 24)
        Me.PicBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicBarcode.TabIndex = 11
        Me.PicBarcode.TabStop = False
        '
        'PicPlc
        '
        Me.PicPlc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicPlc.Image = CType(resources.GetObject("PicPlc.Image"), System.Drawing.Image)
        Me.PicPlc.InitialImage = CType(resources.GetObject("PicPlc.InitialImage"), System.Drawing.Image)
        Me.PicPlc.Location = New System.Drawing.Point(3, 3)
        Me.PicPlc.Name = "PicPlc"
        Me.PicPlc.Size = New System.Drawing.Size(21, 24)
        Me.PicPlc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicPlc.TabIndex = 12
        Me.PicPlc.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "bullet_white.png")
        Me.ImageList1.Images.SetKeyName(1, "bullet_green.png")
        Me.ImageList1.Images.SetKeyName(2, "bullet_red.png")
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(512, 134)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'LoadingDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 134)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoadingDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LoadingDialog"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PicBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPlc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblPlcStatus As Label
    Friend WithEvents LblBarcodeStat As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PicBarcode As PictureBox
    Friend WithEvents PicPlc As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
