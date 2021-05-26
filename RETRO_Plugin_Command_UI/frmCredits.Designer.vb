<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCredits
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
        Me.butOK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRETRO = New System.Windows.Forms.Label()
        Me.lblOcRam = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.White
        Me.txtDesc.Enabled = False
        Me.txtDesc.Location = New System.Drawing.Point(9, 12)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(428, 234)
        Me.txtDesc.TabIndex = 8
        Me.txtDesc.Text = "Pretty much all the ideas are from Drakkonis the creator of RETRO plugin!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This s" &
    "oftware is created by OcRam based on those ideas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Drakkonis has also particip" &
    "ated in early stage development tests."
        '
        'butOK
        '
        Me.butOK.Location = New System.Drawing.Point(9, 301)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(428, 37)
        Me.butOK.TabIndex = 11
        Me.butOK.Text = "OK"
        Me.butOK.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(6, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Latest version of this tool at:"
        '
        'lblRETRO
        '
        Me.lblRETRO.AutoSize = True
        Me.lblRETRO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRETRO.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblRETRO.Location = New System.Drawing.Point(116, 277)
        Me.lblRETRO.Name = "lblRETRO"
        Me.lblRETRO.Size = New System.Drawing.Size(321, 13)
        Me.lblRETRO.TabIndex = 14
        Me.lblRETRO.Text = "https://forums.rpgmakerweb.com/index.php?threads/retro.135715"
        '
        'lblOcRam
        '
        Me.lblOcRam.AutoSize = True
        Me.lblOcRam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOcRam.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblOcRam.Location = New System.Drawing.Point(315, 255)
        Me.lblOcRam.Name = "lblOcRam"
        Me.lblOcRam.Size = New System.Drawing.Size(122, 13)
        Me.lblOcRam.TabIndex = 15
        Me.lblOcRam.Text = "https://ocram-codes.net"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(6, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "RETRO thread:"
        '
        'frmCredits
        '
        Me.AcceptButton = Me.butOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.butOK
        Me.ClientSize = New System.Drawing.Size(449, 348)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOcRam)
        Me.Controls.Add(Me.lblRETRO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.txtDesc)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCredits"
        Me.Text = "Credits - All who have contributed making of this software"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDesc As TextBox
    Friend WithEvents butOK As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRETRO As Label
    Friend WithEvents lblOcRam As Label
    Friend WithEvents Label1 As Label
End Class
