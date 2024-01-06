<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class toTitleCase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCheck = New System.Windows.Forms.Button
        Me.txtString = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(151, 50)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(145, 35)
        Me.btnCheck.TabIndex = 20
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(151, 12)
        Me.txtString.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(145, 30)
        Me.txtString.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Enter String"
        '
        'toTitleCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 94)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "toTitleCase"
        Me.Text = "toTitleCase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents txtString As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
