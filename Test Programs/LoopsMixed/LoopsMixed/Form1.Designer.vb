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
        Me.LstOutput = New System.Windows.Forms.ListBox()
        Me.BtnFor = New System.Windows.Forms.Button()
        Me.BtnWhile = New System.Windows.Forms.Button()
        Me.BtnDo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstOutput
        '
        Me.LstOutput.FormattingEnabled = True
        Me.LstOutput.Location = New System.Drawing.Point(31, 49)
        Me.LstOutput.Name = "LstOutput"
        Me.LstOutput.Size = New System.Drawing.Size(154, 368)
        Me.LstOutput.TabIndex = 0
        '
        'BtnFor
        '
        Me.BtnFor.Location = New System.Drawing.Point(207, 60)
        Me.BtnFor.Name = "BtnFor"
        Me.BtnFor.Size = New System.Drawing.Size(86, 51)
        Me.BtnFor.TabIndex = 1
        Me.BtnFor.Text = "For"
        Me.BtnFor.UseVisualStyleBackColor = True
        '
        'BtnWhile
        '
        Me.BtnWhile.Location = New System.Drawing.Point(207, 274)
        Me.BtnWhile.Name = "BtnWhile"
        Me.BtnWhile.Size = New System.Drawing.Size(86, 51)
        Me.BtnWhile.TabIndex = 2
        Me.BtnWhile.Text = "While"
        Me.BtnWhile.UseVisualStyleBackColor = True
        '
        'BtnDo
        '
        Me.BtnDo.Location = New System.Drawing.Point(207, 160)
        Me.BtnDo.Name = "BtnDo"
        Me.BtnDo.Size = New System.Drawing.Size(86, 51)
        Me.BtnDo.TabIndex = 3
        Me.BtnDo.Text = "Do"
        Me.BtnDo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 454)
        Me.Controls.Add(Me.BtnDo)
        Me.Controls.Add(Me.BtnWhile)
        Me.Controls.Add(Me.BtnFor)
        Me.Controls.Add(Me.LstOutput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LstOutput As System.Windows.Forms.ListBox
    Friend WithEvents BtnFor As System.Windows.Forms.Button
    Friend WithEvents BtnWhile As System.Windows.Forms.Button
    Friend WithEvents BtnDo As System.Windows.Forms.Button

End Class
