<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnMemberHelp = New System.Windows.Forms.Button()
        Me.BtnMemberHome = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtStartMembership = New System.Windows.Forms.Button()
        Me.BtnEditMembership = New System.Windows.Forms.Button()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1281, 96)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Member Options"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(1053, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 72)
        Me.Label2.TabIndex = 5
        '
        'BtnMemberHelp
        '
        Me.BtnMemberHelp.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnMemberHelp.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMemberHelp.ForeColor = System.Drawing.Color.White
        Me.BtnMemberHelp.Location = New System.Drawing.Point(22, 65)
        Me.BtnMemberHelp.Name = "BtnMemberHelp"
        Me.BtnMemberHelp.Size = New System.Drawing.Size(32, 28)
        Me.BtnMemberHelp.TabIndex = 7
        Me.BtnMemberHelp.Text = "?"
        Me.BtnMemberHelp.UseVisualStyleBackColor = False
        '
        'BtnMemberHome
        '
        Me.BtnMemberHome.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnMemberHome.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMemberHome.ForeColor = System.Drawing.Color.White
        Me.BtnMemberHome.Location = New System.Drawing.Point(22, 12)
        Me.BtnMemberHome.Name = "BtnMemberHome"
        Me.BtnMemberHome.Size = New System.Drawing.Size(93, 28)
        Me.BtnMemberHome.TabIndex = 9
        Me.BtnMemberHome.Text = "Home"
        Me.BtnMemberHome.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1282, 31)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "From this page you can access your membership options"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtStartMembership
        '
        Me.BtStartMembership.BackColor = System.Drawing.Color.White
        Me.BtStartMembership.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtStartMembership.Location = New System.Drawing.Point(263, 292)
        Me.BtStartMembership.Name = "BtStartMembership"
        Me.BtStartMembership.Size = New System.Drawing.Size(251, 203)
        Me.BtStartMembership.TabIndex = 17
        Me.BtStartMembership.Text = "Start A New Membership"
        Me.BtStartMembership.UseVisualStyleBackColor = False
        '
        'BtnEditMembership
        '
        Me.BtnEditMembership.BackColor = System.Drawing.Color.White
        Me.BtnEditMembership.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditMembership.Location = New System.Drawing.Point(576, 292)
        Me.BtnEditMembership.Name = "BtnEditMembership"
        Me.BtnEditMembership.Size = New System.Drawing.Size(251, 203)
        Me.BtnEditMembership.TabIndex = 18
        Me.BtnEditMembership.Text = "Edit Membership"
        Me.BtnEditMembership.UseVisualStyleBackColor = False
        '
        'BtnView
        '
        Me.BtnView.BackColor = System.Drawing.Color.White
        Me.BtnView.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnView.Location = New System.Drawing.Point(874, 292)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(251, 203)
        Me.BtnView.TabIndex = 19
        Me.BtnView.Text = "View Members"
        Me.BtnView.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1309, 821)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.BtnEditMembership)
        Me.Controls.Add(Me.BtStartMembership)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnMemberHome)
        Me.Controls.Add(Me.BtnMemberHelp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnMemberHelp As System.Windows.Forms.Button
    Friend WithEvents BtnMemberHome As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtStartMembership As System.Windows.Forms.Button
    Friend WithEvents BtnEditMembership As System.Windows.Forms.Button
    Friend WithEvents BtnView As System.Windows.Forms.Button
End Class
