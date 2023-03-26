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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtnum1 = New System.Windows.Forms.TextBox()
        Me.Txtnum2 = New System.Windows.Forms.TextBox()
        Me.TxtDisplay = New System.Windows.Forms.TextBox()
        Me.BtnNumber = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Num 2"
        '
        'Txtnum1
        '
        Me.Txtnum1.Location = New System.Drawing.Point(117, 14)
        Me.Txtnum1.Name = "Txtnum1"
        Me.Txtnum1.Size = New System.Drawing.Size(75, 20)
        Me.Txtnum1.TabIndex = 2
        '
        'Txtnum2
        '
        Me.Txtnum2.Location = New System.Drawing.Point(117, 56)
        Me.Txtnum2.Name = "Txtnum2"
        Me.Txtnum2.Size = New System.Drawing.Size(75, 20)
        Me.Txtnum2.TabIndex = 3
        '
        'TxtDisplay
        '
        Me.TxtDisplay.Location = New System.Drawing.Point(12, 170)
        Me.TxtDisplay.Name = "TxtDisplay"
        Me.TxtDisplay.Size = New System.Drawing.Size(260, 20)
        Me.TxtDisplay.TabIndex = 4
        '
        'BtnNumber
        '
        Me.BtnNumber.Location = New System.Drawing.Point(91, 107)
        Me.BtnNumber.Name = "BtnNumber"
        Me.BtnNumber.Size = New System.Drawing.Size(100, 37)
        Me.BtnNumber.TabIndex = 5
        Me.BtnNumber.Text = "Find largest number"
        Me.BtnNumber.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtnNumber)
        Me.Controls.Add(Me.TxtDisplay)
        Me.Controls.Add(Me.Txtnum2)
        Me.Controls.Add(Me.Txtnum1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtnum1 As System.Windows.Forms.TextBox
    Friend WithEvents Txtnum2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents BtnNumber As System.Windows.Forms.Button

End Class
