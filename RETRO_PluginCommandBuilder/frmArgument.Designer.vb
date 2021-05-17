<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArgument
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
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.butOK = New System.Windows.Forms.Button()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.cmbValue = New System.Windows.Forms.ComboBox()
        Me.chkOFF = New System.Windows.Forms.CheckBox()
        Me.chkON = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.SystemColors.Control
        Me.txtDesc.Enabled = False
        Me.txtDesc.Location = New System.Drawing.Point(12, 12)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(428, 55)
        Me.txtDesc.TabIndex = 7
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(12, 73)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(428, 20)
        Me.txtValue.TabIndex = 9
        '
        'butOK
        '
        Me.butOK.Location = New System.Drawing.Point(307, 99)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(133, 37)
        Me.butOK.TabIndex = 10
        Me.butOK.Text = "OK"
        Me.butOK.UseVisualStyleBackColor = True
        '
        'butCancel
        '
        Me.butCancel.Location = New System.Drawing.Point(12, 99)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(133, 37)
        Me.butCancel.TabIndex = 11
        Me.butCancel.Text = "Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'cmbValue
        '
        Me.cmbValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbValue.FormattingEnabled = True
        Me.cmbValue.Location = New System.Drawing.Point(12, 99)
        Me.cmbValue.Name = "cmbValue"
        Me.cmbValue.Size = New System.Drawing.Size(428, 21)
        Me.cmbValue.TabIndex = 12
        Me.cmbValue.Visible = False
        '
        'chkOFF
        '
        Me.chkOFF.AutoSize = True
        Me.chkOFF.Location = New System.Drawing.Point(12, 126)
        Me.chkOFF.Name = "chkOFF"
        Me.chkOFF.Size = New System.Drawing.Size(77, 17)
        Me.chkOFF.TabIndex = 13
        Me.chkOFF.Text = "OFF (false)"
        Me.chkOFF.UseVisualStyleBackColor = True
        Me.chkOFF.Visible = False
        '
        'chkON
        '
        Me.chkON.AutoSize = True
        Me.chkON.Location = New System.Drawing.Point(232, 126)
        Me.chkON.Name = "chkON"
        Me.chkON.Size = New System.Drawing.Size(69, 17)
        Me.chkON.TabIndex = 14
        Me.chkON.Text = "ON (true)"
        Me.chkON.UseVisualStyleBackColor = True
        Me.chkON.Visible = False
        '
        'frmArgument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 150)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkON)
        Me.Controls.Add(Me.chkOFF)
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.cmbValue)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.txtDesc)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(468, 189)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(468, 189)
        Me.Name = "frmArgument"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmArgument"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents butOK As Button
    Friend WithEvents butCancel As Button
    Friend WithEvents cmbValue As ComboBox
    Friend WithEvents chkOFF As CheckBox
    Friend WithEvents chkON As CheckBox
End Class
