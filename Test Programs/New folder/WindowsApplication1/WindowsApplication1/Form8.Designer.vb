<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.LstOutput = New System.Windows.Forms.ListBox()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnMemberHome = New System.Windows.Forms.Button()
        Me.BtnMemberHelp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstOutput
        '
        Me.LstOutput.FormattingEnabled = True
        Me.LstOutput.Location = New System.Drawing.Point(25, 144)
        Me.LstOutput.Name = "LstOutput"
        Me.LstOutput.Size = New System.Drawing.Size(1275, 316)
        Me.LstOutput.TabIndex = 22
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.White
        Me.BtnNext.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.ForeColor = System.Drawing.Color.Black
        Me.BtnNext.Location = New System.Drawing.Point(538, 477)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(251, 75)
        Me.BtnNext.TabIndex = 43
        Me.BtnNext.Text = "Display"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1281, 96)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Member Options"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnMemberHome
        '
        Me.BtnMemberHome.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnMemberHome.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMemberHome.ForeColor = System.Drawing.Color.White
        Me.BtnMemberHome.Location = New System.Drawing.Point(25, 12)
        Me.BtnMemberHome.Name = "BtnMemberHome"
        Me.BtnMemberHome.Size = New System.Drawing.Size(93, 28)
        Me.BtnMemberHome.TabIndex = 19
        Me.BtnMemberHome.Text = "Home"
        Me.BtnMemberHome.UseVisualStyleBackColor = False
        '
        'BtnMemberHelp
        '
        Me.BtnMemberHelp.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnMemberHelp.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMemberHelp.ForeColor = System.Drawing.Color.White
        Me.BtnMemberHelp.Location = New System.Drawing.Point(25, 48)
        Me.BtnMemberHelp.Name = "BtnMemberHelp"
        Me.BtnMemberHelp.Size = New System.Drawing.Size(32, 28)
        Me.BtnMemberHelp.TabIndex = 20
        Me.BtnMemberHelp.Text = "?"
        Me.BtnMemberHelp.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(1066, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 72)
        Me.Label2.TabIndex = 21
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1312, 824)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.LstOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnMemberHelp)
        Me.Controls.Add(Me.BtnMemberHome)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form8"
        Me.Text = "Form8"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnMemberHome As System.Windows.Forms.Button
    Friend WithEvents BtnMemberHelp As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LstOutput As System.Windows.Forms.ListBox
End Class
