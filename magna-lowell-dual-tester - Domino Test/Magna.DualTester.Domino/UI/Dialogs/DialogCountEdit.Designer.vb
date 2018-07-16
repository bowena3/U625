Namespace UI.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class DialogCountEdit
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
            Me.LblValue = New System.Windows.Forms.Label()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.BtnInc = New System.Windows.Forms.Button()
            Me.BtnDec = New System.Windows.Forms.Button()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.LblValue, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(389, 166)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'LblValue
            '
            Me.LblValue.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.LblValue.AutoSize = True
            Me.LblValue.BackColor = System.Drawing.Color.White
            Me.LblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.LblValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblValue.Location = New System.Drawing.Point(64, 70)
            Me.LblValue.Name = "LblValue"
            Me.LblValue.Size = New System.Drawing.Size(66, 26)
            Me.LblValue.TabIndex = 0
            Me.LblValue.Text = "Value"
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.ColumnCount = 1
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.BtnInc, 0, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.BtnDec, 0, 1)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(197, 3)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 2
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(189, 160)
            Me.TableLayoutPanel2.TabIndex = 1
            '
            'BtnInc
            '
            Me.BtnInc.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnInc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnInc.Location = New System.Drawing.Point(3, 3)
            Me.BtnInc.Name = "BtnInc"
            Me.BtnInc.Size = New System.Drawing.Size(183, 74)
            Me.BtnInc.TabIndex = 0
            Me.BtnInc.Text = "+ Increment"
            Me.BtnInc.UseVisualStyleBackColor = True
            '
            'BtnDec
            '
            Me.BtnDec.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnDec.Location = New System.Drawing.Point(3, 83)
            Me.BtnDec.Name = "BtnDec"
            Me.BtnDec.Size = New System.Drawing.Size(183, 74)
            Me.BtnDec.TabIndex = 1
            Me.BtnDec.Text = "- Decrement"
            Me.BtnDec.UseVisualStyleBackColor = True
            '
            'DialogCountEdit
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(389, 166)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "DialogCountEdit"
            Me.Text = "DialogCountEdit"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents LblValue As System.Windows.Forms.Label
        Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents BtnInc As System.Windows.Forms.Button
        Friend WithEvents BtnDec As System.Windows.Forms.Button
    End Class
End Namespace