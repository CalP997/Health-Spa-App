<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnHelpHome = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnMember = New System.Windows.Forms.Button()
        Me.BtnPrices = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1281, 96)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Homepage"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(1070, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 72)
        Me.Label2.TabIndex = 5
        '
        'BtnHelpHome
        '
        Me.BtnHelpHome.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnHelpHome.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHelpHome.ForeColor = System.Drawing.Color.White
        Me.BtnHelpHome.Location = New System.Drawing.Point(37, 65)
        Me.BtnHelpHome.Name = "BtnHelpHome"
        Me.BtnHelpHome.Size = New System.Drawing.Size(32, 28)
        Me.BtnHelpHome.TabIndex = 7
        Me.BtnHelpHome.Text = "?"
        Me.BtnHelpHome.UseVisualStyleBackColor = False
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnLogout.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Location = New System.Drawing.Point(37, 12)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(93, 28)
        Me.BtnLogout.TabIndex = 8
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(30, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1282, 31)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Welcome to the Bank Health Spa member system" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnMember
        '
        Me.BtnMember.BackColor = System.Drawing.Color.White
        Me.BtnMember.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMember.Location = New System.Drawing.Point(369, 280)
        Me.BtnMember.Name = "BtnMember"
        Me.BtnMember.Size = New System.Drawing.Size(251, 203)
        Me.BtnMember.TabIndex = 15
        Me.BtnMember.Text = "Member Options"
        Me.BtnMember.UseVisualStyleBackColor = False
        '
        'BtnPrices
        '
        Me.BtnPrices.BackColor = System.Drawing.Color.White
        Me.BtnPrices.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrices.Location = New System.Drawing.Point(743, 280)
        Me.BtnPrices.Name = "BtnPrices"
        Me.BtnPrices.Size = New System.Drawing.Size(251, 203)
        Me.BtnPrices.TabIndex = 16
        Me.BtnPrices.Text = "List Prices"
        Me.BtnPrices.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1324, 829)
        Me.Controls.Add(Me.BtnPrices)
        Me.Controls.Add(Me.BtnMember)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnHelpHome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnHelpHome As System.Windows.Forms.Button
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnMember As System.Windows.Forms.Button
    Friend WithEvents BtnPrices As System.Windows.Forms.Button
End Class
