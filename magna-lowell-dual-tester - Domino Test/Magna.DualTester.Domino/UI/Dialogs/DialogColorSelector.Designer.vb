Namespace UI.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class DialogColorSelector
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
            Me.ComboColors = New System.Windows.Forms.ComboBox()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.BtnCancel = New System.Windows.Forms.Button()
            Me.BtnOk = New System.Windows.Forms.Button()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.ComboColors, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(287, 71)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'ComboColors
            '
            Me.ComboColors.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboColors.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ComboColors.FormattingEnabled = True
            Me.ComboColors.Location = New System.Drawing.Point(3, 3)
            Me.ComboColors.Name = "ComboColors"
            Me.ComboColors.Size = New System.Drawing.Size(281, 28)
            Me.ComboColors.TabIndex = 0
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.AutoSize = True
            Me.TableLayoutPanel2.ColumnCount = 2
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.BtnCancel, 0, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.BtnOk, 1, 0)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 34)
            Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(287, 37)
            Me.TableLayoutPanel2.TabIndex = 1
            '
            'BtnCancel
            '
            Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnCancel.Location = New System.Drawing.Point(3, 3)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(137, 31)
            Me.BtnCancel.TabIndex = 0
            Me.BtnCancel.Text = "Cancel"
            Me.BtnCancel.UseVisualStyleBackColor = True
            '
            'BtnOk
            '
            Me.BtnOk.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnOk.Location = New System.Drawing.Point(146, 3)
            Me.BtnOk.Name = "BtnOk"
            Me.BtnOk.Size = New System.Drawing.Size(138, 31)
            Me.BtnOk.TabIndex = 1
            Me.BtnOk.Text = "Ok"
            Me.BtnOk.UseVisualStyleBackColor = True
            '
            'DialogColorSelector
            '
            Me.AcceptButton = Me.BtnOk
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnCancel
            Me.ClientSize = New System.Drawing.Size(287, 71)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "DialogColorSelector"
            Me.Text = "Color Selector"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents ComboColors As System.Windows.Forms.ComboBox
        Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents BtnCancel As System.Windows.Forms.Button
        Friend WithEvents BtnOk As System.Windows.Forms.Button
    End Class
End Namespace