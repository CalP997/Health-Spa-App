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
        Me.BtnIf = New System.Windows.Forms.Button()
        Me.BtnCase = New System.Windows.Forms.Button()
        Me.TxtMark = New System.Windows.Forms.TextBox()
        Me.TxtResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnIf
        '
        Me.BtnIf.Location = New System.Drawing.Point(41, 188)
        Me.BtnIf.Name = "BtnIf"
        Me.BtnIf.Size = New System.Drawing.Size(89, 28)
        Me.BtnIf.TabIndex = 0
        Me.BtnIf.Text = "If"
        Me.BtnIf.UseVisualStyleBackColor = True
        '
        'BtnCase
        '
        Me.BtnCase.Location = New System.Drawing.Point(158, 190)
        Me.BtnCase.Name = "BtnCase"
        Me.BtnCase.Size = New System.Drawing.Size(90, 25)
        Me.BtnCase.TabIndex = 1
        Me.BtnCase.Text = "Case"
        Me.BtnCase.UseVisualStyleBackColor = True
        '
        'TxtMark
        '
        Me.TxtMark.Location = New System.Drawing.Point(148, 31)
        Me.TxtMark.Name = "TxtMark"
        Me.TxtMark.Size = New System.Drawing.Size(99, 20)
        Me.TxtMark.TabIndex = 2
        '
        'TxtResult
        '
        Me.TxtResult.Location = New System.Drawing.Point(148, 81)
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(99, 20)
        Me.TxtResult.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mark"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtResult)
        Me.Controls.Add(Me.TxtMark)
        Me.Controls.Add(Me.BtnCase)
        Me.Controls.Add(Me.BtnIf)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnIf As System.Windows.Forms.Button
    Friend WithEvents BtnCase As System.Windows.Forms.Button
    Friend WithEvents TxtMark As System.Windows.Forms.TextBox
    Friend WithEvents TxtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
