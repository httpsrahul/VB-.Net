<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class greeting
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
        Me.radioMale = New System.Windows.Forms.RadioButton
        Me.radioFemale = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(235, 104)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(145, 35)
        Me.btnCheck.TabIndex = 23
        Me.btnCheck.Text = "Okay"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(146, 9)
        Me.txtString.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(234, 30)
        Me.txtString.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Enter Name"
        '
        'radioMale
        '
        Me.radioMale.AutoSize = True
        Me.radioMale.Location = New System.Drawing.Point(180, 58)
        Me.radioMale.Name = "radioMale"
        Me.radioMale.Size = New System.Drawing.Size(84, 29)
        Me.radioMale.TabIndex = 24
        Me.radioMale.TabStop = True
        Me.radioMale.Text = "Male"
        Me.radioMale.UseVisualStyleBackColor = True
        '
        'radioFemale
        '
        Me.radioFemale.AutoSize = True
        Me.radioFemale.Location = New System.Drawing.Point(272, 58)
        Me.radioFemale.Name = "radioFemale"
        Me.radioFemale.Size = New System.Drawing.Size(108, 29)
        Me.radioFemale.TabIndex = 25
        Me.radioFemale.TabStop = True
        Me.radioFemale.Text = "Female"
        Me.radioFemale.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Select Gender"
        '
        'greeting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 155)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.radioFemale)
        Me.Controls.Add(Me.radioMale)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "greeting"
        Me.Text = "greeting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents txtString As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radioMale As System.Windows.Forms.RadioButton
    Friend WithEvents radioFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
