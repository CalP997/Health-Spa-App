<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEditHelp = New System.Windows.Forms.Button()
        Me.BtnEditHome = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GbxEdit = New System.Windows.Forms.GroupBox()
        Me.TxtEnd = New System.Windows.Forms.TextBox()
        Me.TxtStart = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtEditNotes = New System.Windows.Forms.TextBox()
        Me.TxtEditType = New System.Windows.Forms.TextBox()
        Me.TxtEditMemberID = New System.Windows.Forms.TextBox()
        Me.TxtEditEmail = New System.Windows.Forms.TextBox()
        Me.TxtEditPostcode = New System.Windows.Forms.TextBox()
        Me.TxtEditAdLine3 = New System.Windows.Forms.TextBox()
        Me.TxtEditAdLine2 = New System.Windows.Forms.TextBox()
        Me.TxtEditAdLine1 = New System.Windows.Forms.TextBox()
        Me.TxtEditName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.GbxEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1281, 96)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Edit Current Membership"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(1055, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 72)
        Me.Label2.TabIndex = 5
        '
        'BtnEditHelp
        '
        Me.BtnEditHelp.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnEditHelp.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditHelp.ForeColor = System.Drawing.Color.White
        Me.BtnEditHelp.Location = New System.Drawing.Point(24, 65)
        Me.BtnEditHelp.Name = "BtnEditHelp"
        Me.BtnEditHelp.Size = New System.Drawing.Size(32, 28)
        Me.BtnEditHelp.TabIndex = 7
        Me.BtnEditHelp.Text = "?"
        Me.BtnEditHelp.UseVisualStyleBackColor = False
        '
        'BtnEditHome
        '
        Me.BtnEditHome.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnEditHome.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditHome.ForeColor = System.Drawing.Color.White
        Me.BtnEditHome.Location = New System.Drawing.Point(24, 12)
        Me.BtnEditHome.Name = "BtnEditHome"
        Me.BtnEditHome.Size = New System.Drawing.Size(93, 28)
        Me.BtnEditHome.TabIndex = 9
        Me.BtnEditHome.Text = "Home"
        Me.BtnEditHome.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(19, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1282, 31)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Edit the details of your current membership"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GbxEdit
        '
        Me.GbxEdit.BackColor = System.Drawing.Color.White
        Me.GbxEdit.Controls.Add(Me.TxtEnd)
        Me.GbxEdit.Controls.Add(Me.TxtStart)
        Me.GbxEdit.Controls.Add(Me.BtnSave)
        Me.GbxEdit.Controls.Add(Me.TxtEditNotes)
        Me.GbxEdit.Controls.Add(Me.TxtEditType)
        Me.GbxEdit.Controls.Add(Me.TxtEditMemberID)
        Me.GbxEdit.Controls.Add(Me.TxtEditEmail)
        Me.GbxEdit.Controls.Add(Me.TxtEditPostcode)
        Me.GbxEdit.Controls.Add(Me.TxtEditAdLine3)
        Me.GbxEdit.Controls.Add(Me.TxtEditAdLine2)
        Me.GbxEdit.Controls.Add(Me.TxtEditAdLine1)
        Me.GbxEdit.Controls.Add(Me.TxtEditName)
        Me.GbxEdit.Controls.Add(Me.Label14)
        Me.GbxEdit.Controls.Add(Me.Label13)
        Me.GbxEdit.Controls.Add(Me.Label12)
        Me.GbxEdit.Controls.Add(Me.Label11)
        Me.GbxEdit.Controls.Add(Me.Label10)
        Me.GbxEdit.Controls.Add(Me.Label9)
        Me.GbxEdit.Controls.Add(Me.Label4)
        Me.GbxEdit.Controls.Add(Me.Label3)
        Me.GbxEdit.Controls.Add(Me.Label5)
        Me.GbxEdit.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxEdit.Location = New System.Drawing.Point(275, 262)
        Me.GbxEdit.Name = "GbxEdit"
        Me.GbxEdit.Size = New System.Drawing.Size(831, 521)
        Me.GbxEdit.TabIndex = 17
        Me.GbxEdit.TabStop = False
        Me.GbxEdit.Text = "Edit Membership"
        Me.GbxEdit.Visible = False
        '
        'TxtEnd
        '
        Me.TxtEnd.Location = New System.Drawing.Point(552, 85)
        Me.TxtEnd.Name = "TxtEnd"
        Me.TxtEnd.Size = New System.Drawing.Size(217, 28)
        Me.TxtEnd.TabIndex = 39
        '
        'TxtStart
        '
        Me.TxtStart.Location = New System.Drawing.Point(552, 45)
        Me.TxtStart.Name = "TxtStart"
        Me.TxtStart.Size = New System.Drawing.Size(217, 28)
        Me.TxtStart.TabIndex = 38
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnSave.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(281, 402)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(251, 75)
        Me.BtnSave.TabIndex = 37
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TxtEditNotes
        '
        Me.TxtEditNotes.Location = New System.Drawing.Point(52, 307)
        Me.TxtEditNotes.Name = "TxtEditNotes"
        Me.TxtEditNotes.Size = New System.Drawing.Size(712, 28)
        Me.TxtEditNotes.TabIndex = 36
        '
        'TxtEditType
        '
        Me.TxtEditType.Location = New System.Drawing.Point(552, 153)
        Me.TxtEditType.Name = "TxtEditType"
        Me.TxtEditType.Size = New System.Drawing.Size(217, 28)
        Me.TxtEditType.TabIndex = 35
        '
        'TxtEditMemberID
        '
        Me.TxtEditMemberID.Location = New System.Drawing.Point(552, 119)
        Me.TxtEditMemberID.Name = "TxtEditMemberID"
        Me.TxtEditMemberID.ReadOnly = True
        Me.TxtEditMemberID.Size = New System.Drawing.Size(217, 28)
        Me.TxtEditMemberID.TabIndex = 34
        '
        'TxtEditEmail
        '
        Me.TxtEditEmail.Location = New System.Drawing.Point(140, 223)
        Me.TxtEditEmail.Name = "TxtEditEmail"
        Me.TxtEditEmail.Size = New System.Drawing.Size(217, 28)
        Me.TxtEditEmail.TabIndex = 33
        '
        'TxtEditPostcode
        '
        Me.TxtEditPostcode.Location = New System.Drawing.Point(140, 189)
        Me.TxtEditPostcode.Name = "TxtEditPostcode"
        Me.TxtEditPostcode.Size = New System.Drawing.Size(217, 28)
        Me.TxtEditPostcode.TabIndex = 32
        '
        'TxtEditAdLine3
        '
        Me.TxtEditAdLine3.Location = New System.Drawing.Point(140, 153)
        Me.TxtEditAdLine3.Name = "TxtEditAdLine3"
        Me.TxtEditAdLine3.Size = New System.Drawing.Size(217, 28)
        Me.TxtEditAdLine3.TabIndex = 31
        '
        'TxtEditAdLine2
        '
        Me.TxtEditAdLine2.Location = New System.Drawing.Point(140, 119)
        Me.TxtEditAdLine2.Name = "TxtEditAdLine2"
        Me.TxtEditAdLine2.Size = New System.Drawing.Size(217, 28)
        Me.TxtEditAdLine2.TabIndex = 30
        '
        'TxtEditAdLine1
        '
        Me.TxtEditAdLine1.Location = New System.Drawing.Point(140, 85)
        Me.TxtEditAdLine1.Name = "TxtEditAdLine1"
        Me.TxtEditAdLine1.Size = New System.Drawing.Size(217, 28)
        Me.TxtEditAdLine1.TabIndex = 29
        '
        'TxtEditName
        '
        Me.TxtEditName.Location = New System.Drawing.Point(140, 45)
        Me.TxtEditName.Name = "TxtEditName"
        Me.TxtEditName.Size = New System.Drawing.Size(217, 28)
        Me.TxtEditName.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(6, 260)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 45)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Member Notes:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(415, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 45)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Member Type:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(415, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 45)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Member ID:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(415, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 45)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "End Date:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(415, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 45)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Start Date:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 45)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Email:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 45)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Postcode:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 34)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Adress:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 45)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnShow
        '
        Me.BtnShow.BackColor = System.Drawing.Color.White
        Me.BtnShow.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShow.ForeColor = System.Drawing.Color.Black
        Me.BtnShow.Location = New System.Drawing.Point(556, 170)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(251, 75)
        Me.BtnShow.TabIndex = 38
        Me.BtnShow.Text = "Edit Details"
        Me.BtnShow.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1311, 828)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.GbxEdit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnEditHome)
        Me.Controls.Add(Me.BtnEditHelp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.GbxEdit.ResumeLayout(False)
        Me.GbxEdit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnEditHelp As System.Windows.Forms.Button
    Friend WithEvents BtnEditHome As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GbxEdit As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TxtEditNotes As System.Windows.Forms.TextBox
    Friend WithEvents TxtEditType As System.Windows.Forms.TextBox
    Friend WithEvents TxtEditMemberID As System.Windows.Forms.TextBox
    Friend WithEvents TxtEditEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtEditPostcode As System.Windows.Forms.TextBox
    Friend WithEvents TxtEditAdLine3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtEditAdLine2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtEditAdLine1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtEditName As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnShow As System.Windows.Forms.Button
    Friend WithEvents TxtEnd As System.Windows.Forms.TextBox
    Friend WithEvents TxtStart As System.Windows.Forms.TextBox
End Class
