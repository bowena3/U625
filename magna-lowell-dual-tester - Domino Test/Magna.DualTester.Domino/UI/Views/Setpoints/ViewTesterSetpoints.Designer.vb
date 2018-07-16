
Namespace UI.Views.Setpoints

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ViewTesterSetpoints
        Inherits UserControl

        'UserControl overrides dispose to clean up the component list.
        '<System.Diagnostics.DebuggerNonUserCode()> _
        'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        '    Try
        '        If disposing AndAlso components IsNot Nothing Then
        '            components.Dispose()
        '        End If
        '    Finally
        '        MyBase.Dispose(disposing)
        '    End Try
        'End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.MotionTargetsGrid = New FlexCell.Grid()
            Me.RightGrid = New FlexCell.Grid()
            Me.BtnLoad = New System.Windows.Forms.Button()
            Me.BtnSave = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.TableLayoutPanel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'MotionTargetsGrid
            '
            Me.MotionTargetsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.MotionTargetsGrid.CellBorderColor = System.Drawing.Color.White
            Me.MotionTargetsGrid.CheckedImage = Nothing
            Me.MotionTargetsGrid.Cols = 7
            Me.MotionTargetsGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MotionTargetsGrid.GridColor = System.Drawing.Color.Transparent
            Me.MotionTargetsGrid.Location = New System.Drawing.Point(49, 3)
            Me.MotionTargetsGrid.Name = "MotionTargetsGrid"
            Me.MotionTargetsGrid.Rows = 4
            Me.MotionTargetsGrid.Size = New System.Drawing.Size(524, 517)
            Me.MotionTargetsGrid.TabIndex = 0
            Me.MotionTargetsGrid.UncheckedImage = Nothing
            '
            'RightGrid
            '
            Me.RightGrid.CellBorderColor = System.Drawing.Color.White
            Me.RightGrid.CheckedImage = Nothing
            Me.RightGrid.Cols = 4
            Me.RightGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RightGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RightGrid.GridColor = System.Drawing.Color.Transparent
            Me.RightGrid.Location = New System.Drawing.Point(579, 3)
            Me.RightGrid.Name = "RightGrid"
            Me.RightGrid.Rows = 11
            Me.RightGrid.Size = New System.Drawing.Size(364, 517)
            Me.RightGrid.TabIndex = 1
            Me.RightGrid.UncheckedImage = Nothing
            '
            'BtnLoad
            '
            Me.BtnLoad.Dock = System.Windows.Forms.DockStyle.Top
            Me.BtnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnLoad.Location = New System.Drawing.Point(3, 3)
            Me.BtnLoad.Name = "BtnLoad"
            Me.BtnLoad.Size = New System.Drawing.Size(483, 97)
            Me.BtnLoad.TabIndex = 2
            Me.BtnLoad.Text = "Load From PLC"
            Me.BtnLoad.UseVisualStyleBackColor = True
            '
            'BtnSave
            '
            Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Top
            Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSave.Location = New System.Drawing.Point(492, 3)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New System.Drawing.Size(483, 97)
            Me.BtnSave.TabIndex = 3
            Me.BtnSave.Text = "Save Settings"
            Me.BtnSave.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(3, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(978, 25)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Tester Setpoints"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 3
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(984, 663)
            Me.TableLayoutPanel1.TabIndex = 5
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.AutoSize = True
            Me.TableLayoutPanel2.ColumnCount = 4
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.12658!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.87342!))
            Me.TableLayoutPanel2.Controls.Add(Me.RightGrid, 2, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.MotionTargetsGrid, 1, 0)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 28)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(978, 523)
            Me.TableLayoutPanel2.TabIndex = 5
            '
            'TableLayoutPanel3
            '
            Me.TableLayoutPanel3.AutoSize = True
            Me.TableLayoutPanel3.ColumnCount = 2
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel3.Controls.Add(Me.BtnSave, 1, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.BtnLoad, 0, 0)
            Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 557)
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 1
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel3.Size = New System.Drawing.Size(978, 103)
            Me.TableLayoutPanel3.TabIndex = 6
            '
            'ViewTesterSetpoints
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Name = "ViewTesterSetpoints"
            Me.Size = New System.Drawing.Size(984, 663)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents MotionTargetsGrid As FlexCell.Grid
        Friend WithEvents RightGrid As FlexCell.Grid
        Friend WithEvents BtnLoad As System.Windows.Forms.Button
        Friend WithEvents BtnSave As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel

    End Class
End Namespace