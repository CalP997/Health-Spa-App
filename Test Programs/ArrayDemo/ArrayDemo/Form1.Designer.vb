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
        Me.BtnInitialise = New System.Windows.Forms.Button()
        Me.BtnSetVal = New System.Windows.Forms.Button()
        Me.BtnChange = New System.Windows.Forms.Button()
        Me.BtnSort = New System.Windows.Forms.Button()
        Me.BtnList = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnInitialise
        '
        Me.BtnInitialise.Location = New System.Drawing.Point(36, 27)
        Me.BtnInitialise.Name = "BtnInitialise"
        Me.BtnInitialise.Size = New System.Drawing.Size(119, 33)
        Me.BtnInitialise.TabIndex = 0
        Me.BtnInitialise.Text = "Initialise"
        Me.BtnInitialise.UseVisualStyleBackColor = True
        '
        'BtnSetVal
        '
        Me.BtnSetVal.Location = New System.Drawing.Point(36, 66)
        Me.BtnSetVal.Name = "BtnSetVal"
        Me.BtnSetVal.Size = New System.Drawing.Size(119, 33)
        Me.BtnSetVal.TabIndex = 1
        Me.BtnSetVal.Text = "Set values"
        Me.BtnSetVal.UseVisualStyleBackColor = True
        '
        'BtnChange
        '
        Me.BtnChange.Location = New System.Drawing.Point(36, 105)
        Me.BtnChange.Name = "BtnChange"
        Me.BtnChange.Size = New System.Drawing.Size(119, 33)
        Me.BtnChange.TabIndex = 2
        Me.BtnChange.Text = "Change"
        Me.BtnChange.UseVisualStyleBackColor = True
        '
        'BtnSort
        '
        Me.BtnSort.Location = New System.Drawing.Point(36, 144)
        Me.BtnSort.Name = "BtnSort"
        Me.BtnSort.Size = New System.Drawing.Size(119, 33)
        Me.BtnSort.TabIndex = 3
        Me.BtnSort.Text = "Sort"
        Me.BtnSort.UseVisualStyleBackColor = True
        '
        'BtnList
        '
        Me.BtnList.Location = New System.Drawing.Point(36, 183)
        Me.BtnList.Name = "BtnList"
        Me.BtnList.Size = New System.Drawing.Size(119, 33)
        Me.BtnList.TabIndex = 4
        Me.BtnList.Text = "List Array"
        Me.BtnList.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(236, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Element"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(342, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Value"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(231, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(60, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(331, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(60, 20)
        Me.TextBox2.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 329)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnList)
        Me.Controls.Add(Me.BtnSort)
        Me.Controls.Add(Me.BtnChange)
        Me.Controls.Add(Me.BtnSetVal)
        Me.Controls.Add(Me.BtnInitialise)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnInitialise As System.Windows.Forms.Button
    Friend WithEvents BtnSetVal As System.Windows.Forms.Button
    Friend WithEvents BtnChange As System.Windows.Forms.Button
    Friend WithEvents BtnSort As System.Windows.Forms.Button
    Friend WithEvents BtnList As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
