<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjects
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
        Me.cmbProject = New System.Windows.Forms.ComboBox()
        Me.butNew = New System.Windows.Forms.Button()
        Me.butRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'butOK
        '
        Me.butOK.Location = New System.Drawing.Point(290, 74)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(133, 37)
        Me.butOK.TabIndex = 11
        Me.butOK.Text = "OK"
        Me.butOK.UseVisualStyleBackColor = True
        '
        'butCancel
        '
        Me.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancel.Location = New System.Drawing.Point(12, 74)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(133, 37)
        Me.butCancel.TabIndex = 12
        Me.butCancel.Text = "Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'cmbProject
        '
        Me.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbProject.FormattingEnabled = True
        Me.cmbProject.Location = New System.Drawing.Point(12, 12)
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.Size = New System.Drawing.Size(411, 21)
        Me.cmbProject.TabIndex = 13
        '
        'butNew
        '
        Me.butNew.Location = New System.Drawing.Point(227, 40)
        Me.butNew.Name = "butNew"
        Me.butNew.Size = New System.Drawing.Size(196, 28)
        Me.butNew.TabIndex = 14
        Me.butNew.Text = "Add new project"
        Me.butNew.UseVisualStyleBackColor = True
        '
        'butRemove
        '
        Me.butRemove.Location = New System.Drawing.Point(12, 39)
        Me.butRemove.Name = "butRemove"
        Me.butRemove.Size = New System.Drawing.Size(196, 29)
        Me.butRemove.TabIndex = 15
        Me.butRemove.Text = "Remove selected project"
        Me.butRemove.UseVisualStyleBackColor = True
        '
        'frmProjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 123)
        Me.ControlBox = False
        Me.Controls.Add(Me.butRemove)
        Me.Controls.Add(Me.butNew)
        Me.Controls.Add(Me.cmbProject)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.butOK)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProjects"
        Me.Text = "My projects"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents butOK As Button
    Friend WithEvents butCancel As Button
    Friend WithEvents cmbProject As ComboBox
    Friend WithEvents butNew As Button
    Friend WithEvents butRemove As Button
End Class
