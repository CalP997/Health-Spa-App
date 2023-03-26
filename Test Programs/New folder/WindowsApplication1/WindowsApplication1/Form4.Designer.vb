<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnStartHelp = New System.Windows.Forms.Button()
        Me.BtnStartHome = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbxType = New System.Windows.Forms.ComboBox()
        Me.TxtMobile = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.TxtMemberID = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtPostcode = New System.Windows.Forms.TextBox()
        Me.TxtAdLine3 = New System.Windows.Forms.TextBox()
        Me.TxtAdLine2 = New System.Windows.Forms.TextBox()
        Me.TxtAdLine1 = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
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
        Me.Label1.Text = "Start New Membership"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(1054, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 72)
        Me.Label2.TabIndex = 5
        '
        'BtnStartHelp
        '
        Me.BtnStartHelp.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnStartHelp.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStartHelp.ForeColor = System.Drawing.Color.White
        Me.BtnStartHelp.Location = New System.Drawing.Point(22, 66)
        Me.BtnStartHelp.Name = "BtnStartHelp"
        Me.BtnStartHelp.Size = New System.Drawing.Size(32, 28)
        Me.BtnStartHelp.TabIndex = 7
        Me.BtnStartHelp.Text = "?"
        Me.BtnStartHelp.UseVisualStyleBackColor = False
        '
        'BtnStartHome
        '
        Me.BtnStartHome.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnStartHome.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStartHome.ForeColor = System.Drawing.Color.White
        Me.BtnStartHome.Location = New System.Drawing.Point(22, 12)
        Me.BtnStartHome.Name = "BtnStartHome"
        Me.BtnStartHome.Size = New System.Drawing.Size(93, 28)
        Me.BtnStartHome.TabIndex = 9
        Me.BtnStartHome.Text = "Home"
        Me.BtnStartHome.UseVisualStyleBackColor = False
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
        Me.Label7.Text = "Enter your credentials in the boxes below to set up a membership"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.CbxType)
        Me.GroupBox1.Controls.Add(Me.TxtMobile)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.EndDate)
        Me.GroupBox1.Controls.Add(Me.StartDate)
        Me.GroupBox1.Controls.Add(Me.BtnCreate)
        Me.GroupBox1.Controls.Add(Me.TxtNotes)
        Me.GroupBox1.Controls.Add(Me.TxtMemberID)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.TxtPostcode)
        Me.GroupBox1.Controls.Add(Me.TxtAdLine3)
        Me.GroupBox1.Controls.Add(Me.TxtAdLine2)
        Me.GroupBox1.Controls.Add(Me.TxtAdLine1)
        Me.GroupBox1.Controls.Add(Me.TxtName)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(293, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 521)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Start Membership"
        '
        'CbxType
        '
        Me.CbxType.FormattingEnabled = True
        Me.CbxType.Items.AddRange(New Object() {"Gold", "Silver", "Bronze"})
        Me.CbxType.Location = New System.Drawing.Point(549, 156)
        Me.CbxType.Name = "CbxType"
        Me.CbxType.Size = New System.Drawing.Size(220, 29)
        Me.CbxType.TabIndex = 42
        '
        'TxtMobile
        '
        Me.TxtMobile.Location = New System.Drawing.Point(552, 189)
        Me.TxtMobile.Name = "TxtMobile"
        Me.TxtMobile.Size = New System.Drawing.Size(217, 28)
        Me.TxtMobile.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(415, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 45)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Mobile:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EndDate
        '
        Me.EndDate.Location = New System.Drawing.Point(549, 85)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(220, 28)
        Me.EndDate.TabIndex = 39
        '
        'StartDate
        '
        Me.StartDate.Location = New System.Drawing.Point(549, 45)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(220, 28)
        Me.StartDate.TabIndex = 38
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnCreate.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.ForeColor = System.Drawing.Color.White
        Me.BtnCreate.Location = New System.Drawing.Point(281, 402)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(251, 75)
        Me.BtnCreate.TabIndex = 37
        Me.BtnCreate.Text = "Start Membership"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'TxtNotes
        '
        Me.TxtNotes.Location = New System.Drawing.Point(52, 307)
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(712, 28)
        Me.TxtNotes.TabIndex = 36
        '
        'TxtMemberID
        '
        Me.TxtMemberID.Location = New System.Drawing.Point(552, 119)
        Me.TxtMemberID.Name = "TxtMemberID"
        Me.TxtMemberID.Size = New System.Drawing.Size(217, 28)
        Me.TxtMemberID.TabIndex = 34
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(140, 223)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(217, 28)
        Me.TxtEmail.TabIndex = 33
        '
        'TxtPostcode
        '
        Me.TxtPostcode.Location = New System.Drawing.Point(140, 189)
        Me.TxtPostcode.Name = "TxtPostcode"
        Me.TxtPostcode.Size = New System.Drawing.Size(217, 28)
        Me.TxtPostcode.TabIndex = 32
        '
        'TxtAdLine3
        '
        Me.TxtAdLine3.Location = New System.Drawing.Point(140, 153)
        Me.TxtAdLine3.Name = "TxtAdLine3"
        Me.TxtAdLine3.Size = New System.Drawing.Size(217, 28)
        Me.TxtAdLine3.TabIndex = 31
        '
        'TxtAdLine2
        '
        Me.TxtAdLine2.Location = New System.Drawing.Point(140, 119)
        Me.TxtAdLine2.Name = "TxtAdLine2"
        Me.TxtAdLine2.Size = New System.Drawing.Size(217, 28)
        Me.TxtAdLine2.TabIndex = 30
        '
        'TxtAdLine1
        '
        Me.TxtAdLine1.Location = New System.Drawing.Point(140, 85)
        Me.TxtAdLine1.Name = "TxtAdLine1"
        Me.TxtAdLine1.Size = New System.Drawing.Size(217, 28)
        Me.TxtAdLine1.TabIndex = 29
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(140, 45)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(217, 28)
        Me.TxtName.TabIndex = 28
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
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1309, 833)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnStartHome)
        Me.Controls.Add(Me.BtnStartHelp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnStartHelp As System.Windows.Forms.Button
    Friend WithEvents BtnStartHome As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNotes As System.Windows.Forms.TextBox
    Friend WithEvents TxtMemberID As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents TxtAdLine3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtAdLine2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtAdLine1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnCreate As System.Windows.Forms.Button
    Friend WithEvents EndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CbxType As System.Windows.Forms.ComboBox
End Class
