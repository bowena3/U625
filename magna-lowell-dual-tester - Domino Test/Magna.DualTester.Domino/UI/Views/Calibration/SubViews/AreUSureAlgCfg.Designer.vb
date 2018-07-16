<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AreUSureAlgCfg
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
        Me.BtnYes = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.MsgText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn
        '
        Me.BtnYes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnYes.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnYes.Location = New System.Drawing.Point(252, 126)
        Me.BtnYes.Name = "btn"
        Me.BtnYes.Size = New System.Drawing.Size(115, 44)
        Me.BtnYes.TabIndex = 0
        Me.BtnYes.Text = "YES"
        Me.BtnYes.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.BackColor = System.Drawing.Color.Yellow
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(12, 126)
        Me.BtnCancel.Name = "Button1"
        Me.BtnCancel.Size = New System.Drawing.Size(115, 44)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'MsgText
        '
        Me.MsgText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MsgText.BackColor = System.Drawing.Color.Black
        Me.MsgText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MsgText.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgText.ForeColor = System.Drawing.Color.Yellow
        Me.MsgText.Location = New System.Drawing.Point(12, 9)
        Me.MsgText.Name = "MsgText"
        Me.MsgText.Size = New System.Drawing.Size(355, 105)
        Me.MsgText.TabIndex = 2
        Me.MsgText.Tag = "Are Your Sure{2}You Would Like to Over Write{2}The Existing Angle Calibration{2}F" &
    "or {0} In Nest_{1}?"
        Me.MsgText.Text = "Are Your Sure You Would Like to Iver Write the Existing Angle Calibration For {0}" &
    " In Nest {1}?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.MsgText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AreUSureAlgCfg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(379, 182)
        Me.ControlBox = False
        Me.Controls.Add(Me.MsgText)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnYes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AreUSureAlgCfg"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Confirm Glass Angle Calibration Download"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents BtnYes As Button
    Private WithEvents BtnCancel As Button
    Private WithEvents MsgText As Label
End Class
