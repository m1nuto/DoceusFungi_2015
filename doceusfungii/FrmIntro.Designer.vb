Imports System.ComponentModel
Imports Mbutton
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmIntro
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()> _
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
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIntro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnScore = New Mbutton.Mushbutton()
        Me.BtnFree = New Mbutton.Mushbutton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnSound = New System.Windows.Forms.PictureBox()
        Me.SoundYN = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.R180 = New System.Windows.Forms.RadioButton()
        Me.R30 = New System.Windows.Forms.RadioButton()
        Me.LblAutoDetails = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BtnSound,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!)
        Me.Label1.Location = New System.Drawing.Point(692, 478)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 7)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "v1.0.2.1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.DoceusFungi.My.Resources.Resources.BannerSmall
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 221)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(725, 265)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = false
        '
        'BtnScore
        '
        Me.BtnScore.BackColor = System.Drawing.Color.Transparent
        Me.BtnScore.BackgroundImage = CType(resources.GetObject("BtnScore.BackgroundImage"),System.Drawing.Image)
        Me.BtnScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnScore.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnScore.FlatAppearance.BorderSize = 0
        Me.BtnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnScore.Font = New System.Drawing.Font("Tahoma", 48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnScore.Location = New System.Drawing.Point(12, 12)
        Me.BtnScore.Name = "BtnScore"
        Me.BtnScore.Size = New System.Drawing.Size(337, 182)
        Me.BtnScore.TabIndex = 6
        Me.BtnScore.Text = "Keep Score!"
        Me.BtnScore.UseVisualStyleBackColor = true
        '
        'BtnFree
        '
        Me.BtnFree.BackColor = System.Drawing.Color.Transparent
        Me.BtnFree.BackgroundImage = CType(resources.GetObject("BtnFree.BackgroundImage"),System.Drawing.Image)
        Me.BtnFree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFree.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BtnFree.FlatAppearance.BorderSize = 0
        Me.BtnFree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnFree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnFree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFree.Font = New System.Drawing.Font("Tahoma", 48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnFree.Location = New System.Drawing.Point(374, 12)
        Me.BtnFree.Name = "BtnFree"
        Me.BtnFree.Size = New System.Drawing.Size(337, 182)
        Me.BtnFree.TabIndex = 7
        Me.BtnFree.Text = "Free Play!"
        Me.BtnFree.UseVisualStyleBackColor = true
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = true
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(588, 249)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(123, 16)
        Me.LinkLabel1.TabIndex = 20
        Me.LinkLabel1.TabStop = true
        Me.LinkLabel1.Text = "Add Mushrooms!"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'BtnSound
        '
        Me.BtnSound.Image = Global.DoceusFungi.My.Resources.Resources.SoundOn
        Me.BtnSound.Location = New System.Drawing.Point(699, 4)
        Me.BtnSound.Name = "BtnSound"
        Me.BtnSound.Size = New System.Drawing.Size(19, 18)
        Me.BtnSound.TabIndex = 21
        Me.BtnSound.TabStop = false
        '
        'SoundYN
        '
        Me.SoundYN.AutoSize = true
        Me.SoundYN.Location = New System.Drawing.Point(12, 205)
        Me.SoundYN.Name = "SoundYN"
        Me.SoundYN.Size = New System.Drawing.Size(14, 13)
        Me.SoundYN.TabIndex = 22
        Me.SoundYN.Text = "Y"
        Me.SoundYN.Visible = false
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.R180)
        Me.Panel1.Controls.Add(Me.R30)
        Me.Panel1.Location = New System.Drawing.Point(581, 213)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(130, 22)
        Me.Panel1.TabIndex = 25
        '
        'R180
        '
        Me.R180.Checked = true
        Me.R180.Location = New System.Drawing.Point(60, 0)
        Me.R180.Name = "R180"
        Me.R180.Size = New System.Drawing.Size(68, 16)
        Me.R180.TabIndex = 26
        Me.R180.TabStop = true
        Me.R180.Text = "180 sec"
        Me.R180.UseVisualStyleBackColor = true
        '
        'R30
        '
        Me.R30.Location = New System.Drawing.Point(3, 0)
        Me.R30.Name = "R30"
        Me.R30.Size = New System.Drawing.Size(57, 17)
        Me.R30.TabIndex = 25
        Me.R30.Text = "30 sec"
        Me.R30.UseVisualStyleBackColor = true
        '
        'LblAutoDetails
        '
        Me.LblAutoDetails.AutoSize = true
        Me.LblAutoDetails.Location = New System.Drawing.Point(12, 228)
        Me.LblAutoDetails.Name = "LblAutoDetails"
        Me.LblAutoDetails.Size = New System.Drawing.Size(15, 13)
        Me.LblAutoDetails.TabIndex = 26
        Me.LblAutoDetails.Text = "N"
        Me.LblAutoDetails.Visible = false
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = true
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(612, 265)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(97, 16)
        Me.LinkLabel2.TabIndex = 27
        Me.LinkLabel2.TabStop = true
        Me.LinkLabel2.Text = "High Scores!"
        '
        'FrmIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(724, 493)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LblAutoDetails)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SoundYN)
        Me.Controls.Add(Me.BtnSound)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BtnFree)
        Me.Controls.Add(Me.BtnScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrmIntro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DoceusFungi - How would you like to play?"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BtnSound,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnScore As Mushbutton
    Friend WithEvents BtnFree As Mushbutton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents BtnSound As PictureBox
    Friend WithEvents SoundYN As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents R180 As RadioButton
    Friend WithEvents R30 As RadioButton
    Friend WithEvents LblAutoDetails As Label
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
