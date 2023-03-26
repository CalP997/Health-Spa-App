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
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.BtnLetters = New System.Windows.Forms.Button()
        Me.Lblletters = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtNum
        '
        Me.TxtNum.Location = New System.Drawing.Point(37, 36)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(80, 20)
        Me.TxtNum.TabIndex = 0
        '
        'BtnLetters
        '
        Me.BtnLetters.Location = New System.Drawing.Point(203, 43)
        Me.BtnLetters.Name = "BtnLetters"
        Me.BtnLetters.Size = New System.Drawing.Size(146, 68)
        Me.BtnLetters.TabIndex = 1
        Me.BtnLetters.Text = "Letters"
        Me.BtnLetters.UseVisualStyleBackColor = True
        '
        'Lblletters
        '
        Me.Lblletters.AutoSize = True
        Me.Lblletters.Location = New System.Drawing.Point(47, 82)
        Me.Lblletters.Name = "Lblletters"
        Me.Lblletters.Size = New System.Drawing.Size(39, 13)
        Me.Lblletters.TabIndex = 2
        Me.Lblletters.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 261)
        Me.Controls.Add(Me.Lblletters)
        Me.Controls.Add(Me.BtnLetters)
        Me.Controls.Add(Me.TxtNum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNum As System.Windows.Forms.TextBox
    Friend WithEvents BtnLetters As System.Windows.Forms.Button
    Friend WithEvents Lblletters As System.Windows.Forms.Label

End Class
