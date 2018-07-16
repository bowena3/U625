Imports Magna.DualTester.Domino.UI.Views

Namespace UI.Views.MainView.SubViews

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class NestOptionsUserControl
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
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.LblInCycle = New System.Windows.Forms.Label()
            Me.BtnAuto = New System.Windows.Forms.Button()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.AutoSize = True
            Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TableLayoutPanel1.Controls.Add(Me.LblInCycle, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.BtnAuto, 0, 2)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 4
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.603448!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.86207!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.603448!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(53, 57)
            Me.TableLayoutPanel1.TabIndex = 11
            '
            'LblInCycle
            '
            Me.LblInCycle.AutoSize = True
            Me.LblInCycle.BackColor = System.Drawing.Color.Black
            Me.LblInCycle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblInCycle.ForeColor = System.Drawing.Color.Yellow
            Me.LblInCycle.Location = New System.Drawing.Point(1, 1)
            Me.LblInCycle.Margin = New System.Windows.Forms.Padding(1)
            Me.LblInCycle.Name = "LblInCycle"
            Me.LblInCycle.Padding = New System.Windows.Forms.Padding(3)
            Me.LblInCycle.Size = New System.Drawing.Size(51, 19)
            Me.LblInCycle.TabIndex = 9
            Me.LblInCycle.Text = "Label10"
            Me.LblInCycle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'BtnAuto
            '
            Me.BtnAuto.AutoSize = True
            Me.BtnAuto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.BtnAuto.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnAuto.Location = New System.Drawing.Point(0, 26)
            Me.BtnAuto.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnAuto.Name = "BtnAuto"
            Me.BtnAuto.Size = New System.Drawing.Size(53, 25)
            Me.BtnAuto.TabIndex = 10
            Me.BtnAuto.Text = "Auto"
            Me.BtnAuto.UseVisualStyleBackColor = True
            '
            'NestOptionsUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Name = "NestOptionsUserControl"
            Me.Size = New System.Drawing.Size(53, 57)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents LblInCycle As System.Windows.Forms.Label
        Friend WithEvents BtnAuto As System.Windows.Forms.Button

    End Class
End Namespace