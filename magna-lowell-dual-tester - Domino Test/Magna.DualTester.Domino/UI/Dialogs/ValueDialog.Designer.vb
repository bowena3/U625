Namespace UI.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ValueDialog
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
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.BtnCancel = New System.Windows.Forms.Button()
            Me.BtnOk = New System.Windows.Forms.Button()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.LblBaseUnits = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.TableLayoutPanel3.SuspendLayout()
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
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(305, 72)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.ColumnCount = 2
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.BtnCancel, 0, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.BtnOk, 1, 0)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 37)
            Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(305, 35)
            Me.TableLayoutPanel2.TabIndex = 1
            '
            'BtnCancel
            '
            Me.BtnCancel.AutoSize = True
            Me.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnCancel.Location = New System.Drawing.Point(3, 3)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(146, 29)
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
            Me.BtnOk.Location = New System.Drawing.Point(155, 3)
            Me.BtnOk.Name = "BtnOk"
            Me.BtnOk.Size = New System.Drawing.Size(147, 29)
            Me.BtnOk.TabIndex = 1
            Me.BtnOk.Text = "Ok"
            Me.BtnOk.UseVisualStyleBackColor = True
            '
            'TableLayoutPanel3
            '
            Me.TableLayoutPanel3.ColumnCount = 2
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.19732!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.80268!))
            Me.TableLayoutPanel3.Controls.Add(Me.LblBaseUnits, 1, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.TextBox1, 0, 0)
            Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 1
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel3.Size = New System.Drawing.Size(305, 37)
            Me.TableLayoutPanel3.TabIndex = 0
            '
            'LblBaseUnits
            '
            Me.LblBaseUnits.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.LblBaseUnits.AutoSize = True
            Me.LblBaseUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblBaseUnits.Location = New System.Drawing.Point(183, 8)
            Me.LblBaseUnits.Margin = New System.Windows.Forms.Padding(3)
            Me.LblBaseUnits.Name = "LblBaseUnits"
            Me.LblBaseUnits.Size = New System.Drawing.Size(57, 20)
            Me.LblBaseUnits.TabIndex = 1
            Me.LblBaseUnits.Text = "Label1"
            Me.LblBaseUnits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TextBox1
            '
            Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.Location = New System.Drawing.Point(3, 5)
            Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(177, 26)
            Me.TextBox1.TabIndex = 0
            Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'ValueDialog
            '
            Me.AcceptButton = Me.BtnOk
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnCancel
            Me.ClientSize = New System.Drawing.Size(305, 72)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "ValueDialog"
            Me.Text = "Edit Value"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel2.PerformLayout()
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.TableLayoutPanel3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents BtnCancel As System.Windows.Forms.Button
        Friend WithEvents BtnOk As System.Windows.Forms.Button
        Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents LblBaseUnits As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    End Class
End Namespace