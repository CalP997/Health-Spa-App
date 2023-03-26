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
        Me.TxtStart = New System.Windows.Forms.TextBox()
        Me.TxtEnd = New System.Windows.Forms.TextBox()
        Me.LstOutput = New System.Windows.Forms.ListBox()
        Me.BtnGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start at"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "End at"
        '
        'TxtStart
        '
        Me.TxtStart.Location = New System.Drawing.Point(111, 14)
        Me.TxtStart.Name = "TxtStart"
        Me.TxtStart.Size = New System.Drawing.Size(84, 20)
        Me.TxtStart.TabIndex = 2
        '
        'TxtEnd
        '
        Me.TxtEnd.Location = New System.Drawing.Point(112, 54)
        Me.TxtEnd.Name = "TxtEnd"
        Me.TxtEnd.Size = New System.Drawing.Size(83, 20)
        Me.TxtEnd.TabIndex = 3
        '
        'LstOutput
        '
        Me.LstOutput.FormattingEnabled = True
        Me.LstOutput.Location = New System.Drawing.Point(8, 102)
        Me.LstOutput.Name = "LstOutput"
        Me.LstOutput.Size = New System.Drawing.Size(311, 212)
        Me.LstOutput.TabIndex = 4
        '
        'BtnGo
        '
        Me.BtnGo.Location = New System.Drawing.Point(222, 17)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(97, 57)
        Me.BtnGo.TabIndex = 5
        Me.BtnGo.Text = "Go"
        Me.BtnGo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 326)
        Me.Controls.Add(Me.BtnGo)
        Me.Controls.Add(Me.LstOutput)
        Me.Controls.Add(Me.TxtEnd)
        Me.Controls.Add(Me.TxtStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtStart As System.Windows.Forms.TextBox
    Friend WithEvents TxtEnd As System.Windows.Forms.TextBox
    Friend WithEvents LstOutput As System.Windows.Forms.ListBox
    Friend WithEvents BtnGo As System.Windows.Forms.Button

End Class
