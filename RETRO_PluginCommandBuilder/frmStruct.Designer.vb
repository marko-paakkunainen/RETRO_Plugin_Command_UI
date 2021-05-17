<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStruct
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
        Me.lstArguments = New System.Windows.Forms.ListView()
        Me.Argument = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.butOK = New System.Windows.Forms.Button()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstArguments
        '
        Me.lstArguments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Argument, Me.Type, Me.Value})
        Me.lstArguments.FullRowSelect = True
        Me.lstArguments.GridLines = True
        Me.lstArguments.HideSelection = False
        Me.lstArguments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lstArguments.Location = New System.Drawing.Point(12, 23)
        Me.lstArguments.MultiSelect = False
        Me.lstArguments.Name = "lstArguments"
        Me.lstArguments.Size = New System.Drawing.Size(560, 234)
        Me.lstArguments.TabIndex = 9
        Me.lstArguments.UseCompatibleStateImageBehavior = False
        Me.lstArguments.View = System.Windows.Forms.View.Details
        '
        'Argument
        '
        Me.Argument.Text = "Argument"
        Me.Argument.Width = 140
        '
        'Type
        '
        Me.Type.Text = "Type"
        Me.Type.Width = 100
        '
        'Value
        '
        Me.Value.Text = "Value"
        Me.Value.Width = 288
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Arguments"
        '
        'butOK
        '
        Me.butOK.Location = New System.Drawing.Point(439, 263)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(133, 37)
        Me.butOK.TabIndex = 12
        Me.butOK.Text = "OK"
        Me.butOK.UseVisualStyleBackColor = True
        '
        'butCancel
        '
        Me.butCancel.Location = New System.Drawing.Point(12, 263)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(133, 37)
        Me.butCancel.TabIndex = 13
        Me.butCancel.Text = "Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'frmStruct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.lstArguments)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStruct"
        Me.Text = "frmStruct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstArguments As ListView
    Friend WithEvents Argument As ColumnHeader
    Friend WithEvents Type As ColumnHeader
    Friend WithEvents Value As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents butOK As Button
    Friend WithEvents butCancel As Button
End Class
