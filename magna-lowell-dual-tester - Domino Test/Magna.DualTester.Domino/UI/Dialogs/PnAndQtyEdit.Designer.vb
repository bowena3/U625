<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PnAndQtyEdit
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.btnEndTote = New System.Windows.Forms.Button()
        Me.btnPrintToteLabel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblBaseUnits = New System.Windows.Forms.Label()
        Me.PartNumbereditNest1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PartQty = New System.Windows.Forms.NumericUpDown()
        Me.lblUnHandledToteParts = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PartNumbereditNest2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PartQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.38889!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.61111!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(435, 292)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnCancel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnOk, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnEndTote, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnPrintToteLabel, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 150)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(435, 142)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'BtnCancel
        '
        Me.BtnCancel.AutoSize = True
        Me.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(3, 74)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(211, 65)
        Me.BtnCancel.TabIndex = 0
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.AutoSize = True
        Me.BtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnOk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(220, 74)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(212, 65)
        Me.BtnOk.TabIndex = 1
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'btnEndTote
        '
        Me.btnEndTote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEndTote.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndTote.ForeColor = System.Drawing.Color.Red
        Me.btnEndTote.Location = New System.Drawing.Point(3, 3)
        Me.btnEndTote.Name = "btnEndTote"
        Me.btnEndTote.Size = New System.Drawing.Size(211, 65)
        Me.btnEndTote.TabIndex = 2
        Me.btnEndTote.Text = "End Tote"
        Me.ToolTip.SetToolTip(Me.btnEndTote, "Will Write 0 to Current Unhandled Tote Count")
        Me.btnEndTote.UseVisualStyleBackColor = True
        Me.btnEndTote.Visible = False
        '
        'btnPrintToteLabel
        '
        Me.btnPrintToteLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPrintToteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintToteLabel.ForeColor = System.Drawing.Color.Red
        Me.btnPrintToteLabel.Location = New System.Drawing.Point(220, 3)
        Me.btnPrintToteLabel.Name = "btnPrintToteLabel"
        Me.btnPrintToteLabel.Size = New System.Drawing.Size(212, 65)
        Me.btnPrintToteLabel.TabIndex = 3
        Me.btnPrintToteLabel.Text = "Print Tote Label"
        Me.ToolTip.SetToolTip(Me.btnPrintToteLabel, "Willl Request a Tote Label")
        Me.btnPrintToteLabel.UseVisualStyleBackColor = True
        Me.btnPrintToteLabel.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.79822!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.20178!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.PartNumbereditNest2, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.LblBaseUnits, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.PartNumbereditNest1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.PartQty, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lblUnHandledToteParts, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(435, 150)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'LblBaseUnits
        '
        Me.LblBaseUnits.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblBaseUnits.AutoSize = True
        Me.LblBaseUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBaseUnits.Location = New System.Drawing.Point(280, 31)
        Me.LblBaseUnits.Margin = New System.Windows.Forms.Padding(3)
        Me.LblBaseUnits.Name = "LblBaseUnits"
        Me.LblBaseUnits.Size = New System.Drawing.Size(152, 20)
        Me.LblBaseUnits.TabIndex = 1
        Me.LblBaseUnits.Text = "Part Number Nest1"
        Me.LblBaseUnits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PartNumbereditNest1
        '
        Me.PartNumbereditNest1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PartNumbereditNest1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PartNumbereditNest1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartNumbereditNest1.Location = New System.Drawing.Point(3, 26)
        Me.PartNumbereditNest1.Name = "PartNumbereditNest1"
        Me.PartNumbereditNest1.Size = New System.Drawing.Size(271, 31)
        Me.PartNumbereditNest1.TabIndex = 0
        Me.PartNumbereditNest1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.PartNumbereditNest1, "Part Number you wich To Run")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Part Qty"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PartQty
        '
        Me.PartQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PartQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartQty.Location = New System.Drawing.Point(3, 109)
        Me.PartQty.Name = "PartQty"
        Me.PartQty.Size = New System.Drawing.Size(271, 38)
        Me.PartQty.TabIndex = 4
        Me.PartQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.PartQty, "Edit Number then Press Enter")
        '
        'lblUnHandledToteParts
        '
        Me.lblUnHandledToteParts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUnHandledToteParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnHandledToteParts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUnHandledToteParts.Location = New System.Drawing.Point(3, 0)
        Me.lblUnHandledToteParts.Name = "lblUnHandledToteParts"
        Me.lblUnHandledToteParts.Size = New System.Drawing.Size(271, 20)
        Me.lblUnHandledToteParts.TabIndex = 5
        Me.lblUnHandledToteParts.Text = "UnHandled Tote Parts"
        Me.ToolTip.SetToolTip(Me.lblUnHandledToteParts, "There are un handled parts from a different  part number")
        Me.lblUnHandledToteParts.Visible = False
        '
        'PartNumbereditNest2
        '
        Me.PartNumbereditNest2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PartNumbereditNest2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PartNumbereditNest2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartNumbereditNest2.Location = New System.Drawing.Point(3, 69)
        Me.PartNumbereditNest2.Name = "PartNumbereditNest2"
        Me.PartNumbereditNest2.Size = New System.Drawing.Size(271, 31)
        Me.PartNumbereditNest2.TabIndex = 2
        Me.PartNumbereditNest2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.PartNumbereditNest2, "Part Number you wich To Run")
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Part Number Nest2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnAndQtyEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 292)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "PnAndQtyEdit"
        Me.Text = "PnAndQtyEdit"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.PartQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnCancel As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LblBaseUnits As Label
    Friend WithEvents PartNumbereditNest1 As TextBox
    Friend WithEvents Label1 As Label
    Private WithEvents PartQty As NumericUpDown
    Friend WithEvents BtnOk As Button
    Private WithEvents btnEndTote As Button
    Private WithEvents btnPrintToteLabel As Button
    Private WithEvents lblUnHandledToteParts As Label
    Private WithEvents ToolTip As ToolTip
    Friend WithEvents Label3 As Label
    Friend WithEvents PartNumbereditNest2 As TextBox
End Class
