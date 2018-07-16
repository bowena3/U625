<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtIp = New System.Windows.Forms.TextBox()
        Me.BtnReadAsync = New System.Windows.Forms.Button()
        Me.LblOut = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnRead = New System.Windows.Forms.Button()
        Me.Success = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TypeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MessageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtIp
        '
        Me.TxtIp.Location = New System.Drawing.Point(12, 17)
        Me.TxtIp.Name = "TxtIp"
        Me.TxtIp.Size = New System.Drawing.Size(100, 20)
        Me.TxtIp.TabIndex = 1
        Me.TxtIp.Text = "10.205.60.169"
        '
        'BtnReadAsync
        '
        Me.BtnReadAsync.Location = New System.Drawing.Point(118, 8)
        Me.BtnReadAsync.Name = "BtnReadAsync"
        Me.BtnReadAsync.Size = New System.Drawing.Size(98, 36)
        Me.BtnReadAsync.TabIndex = 2
        Me.BtnReadAsync.Text = "Read Async"
        Me.BtnReadAsync.UseVisualStyleBackColor = True
        '
        'LblOut
        '
        Me.LblOut.AutoSize = True
        Me.LblOut.Location = New System.Drawing.Point(428, 24)
        Me.LblOut.Name = "LblOut"
        Me.LblOut.Size = New System.Drawing.Size(39, 13)
        Me.LblOut.TabIndex = 4
        Me.LblOut.Text = "Label1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Success, Me.TypeName, Me.Address, Me.MessageDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ResultBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(974, 440)
        Me.DataGridView1.TabIndex = 5
        '
        'ResultBindingSource
        '
        Me.ResultBindingSource.DataSource = GetType(DualTester.UdtTest)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.24031!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.75969!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(980, 502)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnRead)
        Me.Panel1.Controls.Add(Me.TxtIp)
        Me.Panel1.Controls.Add(Me.LblOut)
        Me.Panel1.Controls.Add(Me.BtnReadAsync)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 50)
        Me.Panel1.TabIndex = 6
        '
        'BtnRead
        '
        Me.BtnRead.Location = New System.Drawing.Point(222, 8)
        Me.BtnRead.Name = "BtnRead"
        Me.BtnRead.Size = New System.Drawing.Size(98, 36)
        Me.BtnRead.TabIndex = 5
        Me.BtnRead.Text = "Read"
        Me.BtnRead.UseVisualStyleBackColor = True
        '
        'Success
        '
        Me.Success.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Success.DataPropertyName = "Success"
        Me.Success.HeaderText = "Success"
        Me.Success.Name = "Success"
        Me.Success.ReadOnly = True
        Me.Success.Width = 54
        '
        'TypeName
        '
        Me.TypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TypeName.DataPropertyName = "TypeName"
        Me.TypeName.HeaderText = "TypeName"
        Me.TypeName.Name = "TypeName"
        Me.TypeName.ReadOnly = True
        Me.TypeName.Width = 84
        '
        'Address
        '
        Me.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Address.DataPropertyName = "Address"
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 70
        '
        'MessageDataGridViewTextBoxColumn
        '
        Me.MessageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MessageDataGridViewTextBoxColumn.DataPropertyName = "Message"
        Me.MessageDataGridViewTextBoxColumn.HeaderText = "Message"
        Me.MessageDataGridViewTextBoxColumn.Name = "MessageDataGridViewTextBoxColumn"
        Me.MessageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 502)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtIp As System.Windows.Forms.TextBox
    Friend WithEvents BtnReadAsync As System.Windows.Forms.Button
    Friend WithEvents LblOut As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ResDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ResultBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnRead As Button
    Friend WithEvents Success As DataGridViewCheckBoxColumn
    Friend WithEvents TypeName As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents MessageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
