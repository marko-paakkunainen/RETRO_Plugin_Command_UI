<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmbPlugin = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCommand = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lstArguments = New System.Windows.Forms.ListView()
        Me.Argument = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.butCopy = New System.Windows.Forms.Button()
        Me.butCredits = New System.Windows.Forms.Button()
        Me.butProject = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbPlugin
        '
        Me.cmbPlugin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlugin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPlugin.FormattingEnabled = True
        Me.cmbPlugin.Location = New System.Drawing.Point(12, 25)
        Me.cmbPlugin.Name = "cmbPlugin"
        Me.cmbPlugin.Size = New System.Drawing.Size(277, 21)
        Me.cmbPlugin.Sorted = True
        Me.cmbPlugin.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Plugin"
        '
        'cmbCommand
        '
        Me.cmbCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCommand.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCommand.FormattingEnabled = True
        Me.cmbCommand.Location = New System.Drawing.Point(295, 25)
        Me.cmbCommand.Name = "cmbCommand"
        Me.cmbCommand.Size = New System.Drawing.Size(277, 21)
        Me.cmbCommand.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Command"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Arguments"
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.SystemColors.Control
        Me.txtDesc.Enabled = False
        Me.txtDesc.Location = New System.Drawing.Point(12, 52)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(560, 55)
        Me.txtDesc.TabIndex = 6
        Me.txtDesc.Text = "[Please select plugin]"
        '
        'lstArguments
        '
        Me.lstArguments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Argument, Me.Type, Me.Value})
        Me.lstArguments.FullRowSelect = True
        Me.lstArguments.GridLines = True
        Me.lstArguments.HideSelection = False
        Me.lstArguments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lstArguments.Location = New System.Drawing.Point(12, 126)
        Me.lstArguments.MultiSelect = False
        Me.lstArguments.Name = "lstArguments"
        Me.lstArguments.Size = New System.Drawing.Size(560, 234)
        Me.lstArguments.TabIndex = 7
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
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(12, 389)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(427, 20)
        Me.txtResult.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "RETRO'ed plugin command"
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(0, 415)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(584, 26)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "© 2021 OcRam - This software is made for RETRO plugin made by Drakkonis (RPG Make" &
    "r MZ plugins in MV)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'butCopy
        '
        Me.butCopy.Location = New System.Drawing.Point(445, 373)
        Me.butCopy.Name = "butCopy"
        Me.butCopy.Size = New System.Drawing.Size(127, 36)
        Me.butCopy.TabIndex = 11
        Me.butCopy.Text = "Copy to clipboard"
        Me.butCopy.UseVisualStyleBackColor = True
        '
        'butCredits
        '
        Me.butCredits.Location = New System.Drawing.Point(493, 82)
        Me.butCredits.Name = "butCredits"
        Me.butCredits.Size = New System.Drawing.Size(78, 24)
        Me.butCredits.TabIndex = 12
        Me.butCredits.Text = "Credits"
        Me.butCredits.UseVisualStyleBackColor = True
        '
        'butProject
        '
        Me.butProject.Location = New System.Drawing.Point(345, 82)
        Me.butProject.Name = "butProject"
        Me.butProject.Size = New System.Drawing.Size(149, 24)
        Me.butProject.TabIndex = 13
        Me.butProject.Text = "Change project ..."
        Me.butProject.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 441)
        Me.Controls.Add(Me.butProject)
        Me.Controls.Add(Me.butCredits)
        Me.Controls.Add(Me.butCopy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lstArguments)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCommand)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbPlugin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 480)
        Me.MinimumSize = New System.Drawing.Size(600, 480)
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RETRO Plugin Command UI v1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbPlugin As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCommand As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents lstArguments As ListView
    Friend WithEvents Argument As ColumnHeader
    Friend WithEvents Type As ColumnHeader
    Friend WithEvents Value As ColumnHeader
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents butCopy As Button
    Friend WithEvents butCredits As Button
    Friend WithEvents butProject As Button
End Class
