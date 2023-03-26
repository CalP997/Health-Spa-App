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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLoginHelp = New System.Windows.Forms.Button()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblHeader
        '
        Me.LblHeader.BackColor = System.Drawing.Color.YellowGreen
        Me.LblHeader.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.Color.White
        Me.LblHeader.Location = New System.Drawing.Point(12, 9)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(1281, 96)
        Me.LblHeader.TabIndex = 0
        Me.LblHeader.Text = "Bank Health Spa"
        Me.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.White
        Me.BtnLogin.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(944, 509)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(234, 97)
        Me.BtnLogin.TabIndex = 1
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnExit.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(18, 12)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(32, 28)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(1053, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 72)
        Me.Label2.TabIndex = 5
        '
        'BtnLoginHelp
        '
        Me.BtnLoginHelp.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnLoginHelp.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoginHelp.ForeColor = System.Drawing.Color.White
        Me.BtnLoginHelp.Location = New System.Drawing.Point(56, 12)
        Me.BtnLoginHelp.Name = "BtnLoginHelp"
        Me.BtnLoginHelp.Size = New System.Drawing.Size(32, 28)
        Me.BtnLoginHelp.TabIndex = 6
        Me.BtnLoginHelp.Text = "?"
        Me.BtnLoginHelp.UseVisualStyleBackColor = False
        '
        'LblInfo
        '
        Me.LblInfo.BackColor = System.Drawing.Color.Transparent
        Me.LblInfo.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.ForeColor = System.Drawing.Color.Black
        Me.LblInfo.Location = New System.Drawing.Point(12, 142)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(1281, 45)
        Me.LblInfo.TabIndex = 7
        Me.LblInfo.Text = "Enter your username and password to gain access to the system"
        Me.LblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPassword
        '
        Me.LblPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblPassword.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.Color.Black
        Me.LblPassword.Location = New System.Drawing.Point(796, 387)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(142, 45)
        Me.LblPassword.TabIndex = 8
        Me.LblPassword.Text = "Password:"
        Me.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUser
        '
        Me.LblUser.BackColor = System.Drawing.Color.Transparent
        Me.LblUser.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.ForeColor = System.Drawing.Color.Black
        Me.LblUser.Location = New System.Drawing.Point(796, 262)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(142, 45)
        Me.LblUser.TabIndex = 9
        Me.LblUser.Text = "Username:"
        Me.LblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtUsername
        '
        Me.TxtUsername.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(944, 272)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(332, 31)
        Me.TxtUsername.TabIndex = 10
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(944, 397)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(332, 31)
        Me.TxtPassword.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1305, 816)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.BtnLoginHelp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.LblHeader)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblHeader As System.Windows.Forms.Label
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnLoginHelp As System.Windows.Forms.Button
    Friend WithEvents LblInfo As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents LblUser As System.Windows.Forms.Label
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox

End Class
