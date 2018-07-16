<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NestPartOptions
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowPanelPartOptions = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowPanelGlassOptions = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowPanelPartOptions, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowPanelGlassOptions, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(343, 310)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Glass Options"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Part Options"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowPanelPartOptions
        '
        Me.FlowPanelPartOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowPanelPartOptions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowPanelPartOptions.Location = New System.Drawing.Point(4, 29)
        Me.FlowPanelPartOptions.Name = "FlowPanelPartOptions"
        Me.FlowPanelPartOptions.Size = New System.Drawing.Size(164, 277)
        Me.FlowPanelPartOptions.TabIndex = 2
        '
        'FlowPanelGlassOptions
        '
        Me.FlowPanelGlassOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowPanelGlassOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowPanelGlassOptions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowPanelGlassOptions.Location = New System.Drawing.Point(175, 29)
        Me.FlowPanelGlassOptions.Name = "FlowPanelGlassOptions"
        Me.FlowPanelGlassOptions.Size = New System.Drawing.Size(164, 277)
        Me.FlowPanelGlassOptions.TabIndex = 3
        '
        'NestPartOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "NestPartOptions"
        Me.Size = New System.Drawing.Size(343, 310)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowPanelPartOptions As FlowLayoutPanel
    Friend WithEvents FlowPanelGlassOptions As FlowLayoutPanel
End Class
