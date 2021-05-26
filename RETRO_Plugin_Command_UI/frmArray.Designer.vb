<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArray
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
        Me.butOK = New System.Windows.Forms.Button()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.lstArguments = New System.Windows.Forms.ListView()
        Me.Argument = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'butOK
        '
        Me.butOK.Location = New System.Drawing.Point(441, 313)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(133, 37)
        Me.butOK.TabIndex = 16
        Me.butOK.Text = "OK"
        Me.butOK.UseVisualStyleBackColor = True
        '
        'butCancel
        '
        Me.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancel.Location = New System.Drawing.Point(12, 313)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(133, 37)
        Me.butCancel.TabIndex = 17
        Me.butCancel.Text = "Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'lstArguments
        '
        Me.lstArguments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Argument, Me.Type, Me.Value})
        Me.lstArguments.FullRowSelect = True
        Me.lstArguments.GridLines = True
        Me.lstArguments.HideSelection = False
        Me.lstArguments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lstArguments.Location = New System.Drawing.Point(15, 73)
        Me.lstArguments.MultiSelect = False
        Me.lstArguments.Name = "lstArguments"
        Me.lstArguments.Size = New System.Drawing.Size(560, 234)
        Me.lstArguments.TabIndex = 15
        Me.lstArguments.UseCompatibleStateImageBehavior = False
        Me.lstArguments.View = System.Windows.Forms.View.Details
        '
        'Argument
        '
        Me.Argument.Text = "Index"
        Me.Argument.Width = 140
        '
        'Type
        '
        Me.Type.Text = "Type"
        Me.Type.Width = 0
        '
        'Value
        '
        Me.Value.Text = "Value"
        Me.Value.Width = 388
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.SystemColors.Control
        Me.txtDesc.Enabled = False
        Me.txtDesc.Location = New System.Drawing.Point(15, 12)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(559, 55)
        Me.txtDesc.TabIndex = 18
        '
        'frmArray
        '
        Me.AcceptButton = Me.butOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.butCancel
        Me.ClientSize = New System.Drawing.Size(586, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.lstArguments)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArray"
        Me.Text = "frmArray"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents butOK As Button
    Friend WithEvents butCancel As Button
    Friend WithEvents lstArguments As ListView
    Friend WithEvents Argument As ColumnHeader
    Friend WithEvents Type As ColumnHeader
    Friend WithEvents Value As ColumnHeader
    Friend WithEvents txtDesc As TextBox
End Class
