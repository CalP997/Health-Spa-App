<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnViewHelp = New System.Windows.Forms.Button()
        Me.BtnViewHome = New System.Windows.Forms.Button()
        Me.BtnSilver = New System.Windows.Forms.Button()
        Me.BtnBronze = New System.Windows.Forms.Button()
        Me.BtnNone = New System.Windows.Forms.Button()
        Me.BtnGold = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1281, 96)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "View Prices"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(1061, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 72)
        Me.Label2.TabIndex = 5
        '
        'BtnViewHelp
        '
        Me.BtnViewHelp.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnViewHelp.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewHelp.ForeColor = System.Drawing.Color.White
        Me.BtnViewHelp.Location = New System.Drawing.Point(28, 65)
        Me.BtnViewHelp.Name = "BtnViewHelp"
        Me.BtnViewHelp.Size = New System.Drawing.Size(32, 28)
        Me.BtnViewHelp.TabIndex = 7
        Me.BtnViewHelp.Text = "?"
        Me.BtnViewHelp.UseVisualStyleBackColor = False
        '
        'BtnViewHome
        '
        Me.BtnViewHome.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnViewHome.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewHome.ForeColor = System.Drawing.Color.White
        Me.BtnViewHome.Location = New System.Drawing.Point(28, 12)
        Me.BtnViewHome.Name = "BtnViewHome"
        Me.BtnViewHome.Size = New System.Drawing.Size(93, 28)
        Me.BtnViewHome.TabIndex = 9
        Me.BtnViewHome.Text = "Home"
        Me.BtnViewHome.UseVisualStyleBackColor = False
        '
        'BtnSilver
        '
        Me.BtnSilver.BackColor = System.Drawing.Color.White
        Me.BtnSilver.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSilver.ForeColor = System.Drawing.Color.Black
        Me.BtnSilver.Location = New System.Drawing.Point(666, 212)
        Me.BtnSilver.Name = "BtnSilver"
        Me.BtnSilver.Size = New System.Drawing.Size(251, 75)
        Me.BtnSilver.TabIndex = 39
        Me.BtnSilver.Text = "Silver"
        Me.BtnSilver.UseVisualStyleBackColor = False
        '
        'BtnBronze
        '
        Me.BtnBronze.BackColor = System.Drawing.Color.White
        Me.BtnBronze.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBronze.ForeColor = System.Drawing.Color.Black
        Me.BtnBronze.Location = New System.Drawing.Point(266, 348)
        Me.BtnBronze.Name = "BtnBronze"
        Me.BtnBronze.Size = New System.Drawing.Size(251, 75)
        Me.BtnBronze.TabIndex = 40
        Me.BtnBronze.Text = "Bronze"
        Me.BtnBronze.UseVisualStyleBackColor = False
        '
        'BtnNone
        '
        Me.BtnNone.BackColor = System.Drawing.Color.White
        Me.BtnNone.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNone.ForeColor = System.Drawing.Color.Black
        Me.BtnNone.Location = New System.Drawing.Point(266, 212)
        Me.BtnNone.Name = "BtnNone"
        Me.BtnNone.Size = New System.Drawing.Size(251, 75)
        Me.BtnNone.TabIndex = 41
        Me.BtnNone.Text = "No Discount"
        Me.BtnNone.UseVisualStyleBackColor = False
        '
        'BtnGold
        '
        Me.BtnGold.BackColor = System.Drawing.Color.White
        Me.BtnGold.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGold.ForeColor = System.Drawing.Color.Black
        Me.BtnGold.Location = New System.Drawing.Point(666, 348)
        Me.BtnGold.Name = "BtnGold"
        Me.BtnGold.Size = New System.Drawing.Size(251, 75)
        Me.BtnGold.TabIndex = 42
        Me.BtnGold.Text = "Gold"
        Me.BtnGold.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1315, 733)
        Me.Controls.Add(Me.BtnGold)
        Me.Controls.Add(Me.BtnNone)
        Me.Controls.Add(Me.BtnBronze)
        Me.Controls.Add(Me.BtnSilver)
        Me.Controls.Add(Me.BtnViewHome)
        Me.Controls.Add(Me.BtnViewHelp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnViewHelp As System.Windows.Forms.Button
    Friend WithEvents BtnViewHome As System.Windows.Forms.Button
    Friend WithEvents BtnSilver As Button
    Friend WithEvents BtnBronze As Button
    Friend WithEvents BtnNone As Button
    Friend WithEvents BtnGold As Button
End Class
