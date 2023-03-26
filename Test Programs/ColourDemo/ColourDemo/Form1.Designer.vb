<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Txt1 = New System.Windows.Forms.RichTextBox()
        Me.Txt2 = New System.Windows.Forms.RichTextBox()
        Me.Chk1 = New System.Windows.Forms.CheckBox()
        Me.Chk2 = New System.Windows.Forms.CheckBox()
        Me.RadRed = New System.Windows.Forms.RadioButton()
        Me.RadBlue = New System.Windows.Forms.RadioButton()
        Me.RadGreen = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(12, 12)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(105, 84)
        Me.Txt1.TabIndex = 1
        Me.Txt1.Text = ""
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(167, 12)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(105, 84)
        Me.Txt2.TabIndex = 2
        Me.Txt2.Text = ""
        '
        'Chk1
        '
        Me.Chk1.AutoSize = True
        Me.Chk1.Location = New System.Drawing.Point(31, 103)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(32, 17)
        Me.Chk1.TabIndex = 3
        Me.Chk1.Text = "1"
        Me.Chk1.UseVisualStyleBackColor = True
        '
        'Chk2
        '
        Me.Chk2.AutoSize = True
        Me.Chk2.Location = New System.Drawing.Point(167, 103)
        Me.Chk2.Name = "Chk2"
        Me.Chk2.Size = New System.Drawing.Size(32, 17)
        Me.Chk2.TabIndex = 4
        Me.Chk2.Text = "2"
        Me.Chk2.UseVisualStyleBackColor = True
        '
        'RadRed
        '
        Me.RadRed.AutoSize = True
        Me.RadRed.Location = New System.Drawing.Point(31, 138)
        Me.RadRed.Name = "RadRed"
        Me.RadRed.Size = New System.Drawing.Size(45, 17)
        Me.RadRed.TabIndex = 5
        Me.RadRed.TabStop = True
        Me.RadRed.Text = "Red"
        Me.RadRed.UseVisualStyleBackColor = True
        '
        'RadBlue
        '
        Me.RadBlue.AutoSize = True
        Me.RadBlue.Location = New System.Drawing.Point(27, 161)
        Me.RadBlue.Name = "RadBlue"
        Me.RadBlue.Size = New System.Drawing.Size(46, 17)
        Me.RadBlue.TabIndex = 6
        Me.RadBlue.TabStop = True
        Me.RadBlue.Text = "Blue"
        Me.RadBlue.UseVisualStyleBackColor = True
        '
        'RadGreen
        '
        Me.RadGreen.AutoSize = True
        Me.RadGreen.Location = New System.Drawing.Point(22, 184)
        Me.RadGreen.Name = "RadGreen"
        Me.RadGreen.Size = New System.Drawing.Size(54, 17)
        Me.RadGreen.TabIndex = 7
        Me.RadGreen.TabStop = True
        Me.RadGreen.Text = "Green"
        Me.RadGreen.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(145, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 43)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadGreen)
        Me.Controls.Add(Me.RadBlue)
        Me.Controls.Add(Me.RadRed)
        Me.Controls.Add(Me.Chk2)
        Me.Controls.Add(Me.Chk1)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Txt2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents RadRed As System.Windows.Forms.RadioButton
    Friend WithEvents RadBlue As System.Windows.Forms.RadioButton
    Friend WithEvents RadGreen As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
