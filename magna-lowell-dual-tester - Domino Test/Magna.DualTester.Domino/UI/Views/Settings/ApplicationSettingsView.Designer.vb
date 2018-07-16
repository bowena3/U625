
Imports Magna.DualTester.Domino.UI.Views.Settings.SubViews

Namespace UI.Views.Settings

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ApplicationSettingsView
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
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabShift = New System.Windows.Forms.TabPage()
            Me.ShiftSetup1 = New Magna.DualTester.Domino.UI.Views.Settings.SubViews.ViewShiftSetup()
            Me.TabAppParams = New System.Windows.Forms.TabPage()
            Me.ViewApplicationParameters1 = New Magna.DualTester.Domino.UI.Views.Settings.SubViews.ViewApplicationParameters()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.BtnCancel = New System.Windows.Forms.Button()
            Me.BtnSave = New System.Windows.Forms.Button()
            Me.TabControl1.SuspendLayout()
            Me.TabShift.SuspendLayout()
            Me.TabAppParams.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabControl1
            '
            Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
            Me.TabControl1.Controls.Add(Me.TabShift)
            Me.TabControl1.Controls.Add(Me.TabAppParams)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(3, 3)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1256, 822)
            Me.TabControl1.TabIndex = 0
            '
            'TabShift
            '
            Me.TabShift.Controls.Add(Me.ShiftSetup1)
            Me.TabShift.Location = New System.Drawing.Point(4, 25)
            Me.TabShift.Name = "TabShift"
            Me.TabShift.Size = New System.Drawing.Size(1248, 793)
            Me.TabShift.TabIndex = 5
            Me.TabShift.Text = "Shift Setup"
            Me.TabShift.UseVisualStyleBackColor = True
            '
            'ShiftSetup1
            '
            Me.ShiftSetup1.AutoSize = True
            Me.ShiftSetup1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ShiftSetup1.Location = New System.Drawing.Point(0, 0)
            Me.ShiftSetup1.Name = "ShiftSetup1"
            Me.ShiftSetup1.Size = New System.Drawing.Size(1248, 793)
            Me.ShiftSetup1.TabIndex = 0
            '
            'TabAppParams
            '
            Me.TabAppParams.Controls.Add(Me.ViewApplicationParameters1)
            Me.TabAppParams.Location = New System.Drawing.Point(4, 25)
            Me.TabAppParams.Name = "TabAppParams"
            Me.TabAppParams.Padding = New System.Windows.Forms.Padding(3)
            Me.TabAppParams.Size = New System.Drawing.Size(1248, 793)
            Me.TabAppParams.TabIndex = 0
            Me.TabAppParams.Text = "Application Parameters"
            Me.TabAppParams.UseVisualStyleBackColor = True
            '
            'ViewApplicationParameters1
            '
            Me.ViewApplicationParameters1.AutoSize = True
            Me.ViewApplicationParameters1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ViewApplicationParameters1.Location = New System.Drawing.Point(3, 3)
            Me.ViewApplicationParameters1.Name = "ViewApplicationParameters1"
            Me.ViewApplicationParameters1.Size = New System.Drawing.Size(1242, 787)
            Me.ViewApplicationParameters1.TabIndex = 0
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(1262, 863)
            Me.TableLayoutPanel1.TabIndex = 1
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.AutoSize = True
            Me.TableLayoutPanel2.ColumnCount = 2
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.BtnCancel, 0, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.BtnSave, 1, 0)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 831)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(1256, 29)
            Me.TableLayoutPanel2.TabIndex = 1
            '
            'BtnCancel
            '
            Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnCancel.Location = New System.Drawing.Point(550, 3)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
            Me.BtnCancel.TabIndex = 0
            Me.BtnCancel.Text = "Cancel"
            Me.BtnCancel.UseVisualStyleBackColor = True
            '
            'BtnSave
            '
            Me.BtnSave.Location = New System.Drawing.Point(631, 3)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New System.Drawing.Size(75, 23)
            Me.BtnSave.TabIndex = 1
            Me.BtnSave.Text = "Save"
            Me.BtnSave.UseVisualStyleBackColor = True
            '
            'ApplicationSettingsView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Name = "ApplicationSettingsView"
            Me.Size = New System.Drawing.Size(1262, 863)
            Me.TabControl1.ResumeLayout(False)
            Me.TabShift.ResumeLayout(False)
            Me.TabShift.PerformLayout()
            Me.TabAppParams.ResumeLayout(False)
            Me.TabAppParams.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabAppParams As System.Windows.Forms.TabPage
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents BtnCancel As System.Windows.Forms.Button
        Friend WithEvents BtnSave As System.Windows.Forms.Button
        Friend WithEvents TabShift As System.Windows.Forms.TabPage
        Friend WithEvents ShiftSetup1 As ViewShiftSetup
        Friend WithEvents ViewApplicationParameters1 As ViewApplicationParameters
    End Class
End Namespace