Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.BtnPick = New System.Windows.Forms.Button()
        Me.LstAns = New System.Windows.Forms.ListBox()
        Me.BtnFinalAns = New System.Windows.Forms.Button()
        Me.LblAns = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblScore = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblClock = New System.Windows.Forms.Label()
        Me.TmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.IsTimed = New System.Windows.Forms.Label()
        Me.PicInfinity = New System.Windows.Forms.PictureBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.BtnSound = New System.Windows.Forms.PictureBox()
        Me.TmrCloseIntro = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicInfinity,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BtnSound,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'BtnPick
        '
        Me.BtnPick.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnPick.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnPick.Location = New System.Drawing.Point(29, 198)
        Me.BtnPick.Name = "BtnPick"
        Me.BtnPick.Size = New System.Drawing.Size(75, 23)
        Me.BtnPick.TabIndex = 13
        Me.BtnPick.Text = "Pass"
        Me.BtnPick.UseVisualStyleBackColor = true
        '
        'LstAns
        '
        Me.LstAns.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LstAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold)
        Me.LstAns.ForeColor = System.Drawing.Color.Black
        Me.LstAns.FormattingEnabled = true
        Me.LstAns.ItemHeight = 29
        Me.LstAns.Location = New System.Drawing.Point(29, 484)
        Me.LstAns.Name = "LstAns"
        Me.LstAns.Size = New System.Drawing.Size(532, 149)
        Me.LstAns.TabIndex = 14
        '
        'BtnFinalAns
        '
        Me.BtnFinalAns.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFinalAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFinalAns.Location = New System.Drawing.Point(579, 653)
        Me.BtnFinalAns.Name = "BtnFinalAns"
        Me.BtnFinalAns.Size = New System.Drawing.Size(91, 23)
        Me.BtnFinalAns.TabIndex = 15
        Me.BtnFinalAns.Text = "HELP!"
        Me.BtnFinalAns.UseVisualStyleBackColor = true
        '
        'LblAns
        '
        Me.LblAns.AutoSize = true
        Me.LblAns.Location = New System.Drawing.Point(121, 203)
        Me.LblAns.Name = "LblAns"
        Me.LblAns.Size = New System.Drawing.Size(58, 13)
        Me.LblAns.TabIndex = 16
        Me.LblAns.Text = "My answer"
        Me.LblAns.Visible = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(608, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 31)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "SCORE:"
        '
        'LblScore
        '
        Me.LblScore.AutoSize = true
        Me.LblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 35!)
        Me.LblScore.Location = New System.Drawing.Point(779, 26)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(49, 54)
        Me.LblScore.TabIndex = 18
        Me.LblScore.Text = "0"
        Me.LblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Interval = 3800
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Location = New System.Drawing.Point(304, 227)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(258, 249)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = false
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Location = New System.Drawing.Point(579, 227)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(348, 420)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = false
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(29, 227)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 249)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = false
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.DoceusFungi.My.Resources.Resources.BannerSmall
        Me.PictureBox4.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(485, 179)
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = false
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(608, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 31)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "TIME:"
        '
        'LblClock
        '
        Me.LblClock.AutoSize = true
        Me.LblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!)
        Me.LblClock.Location = New System.Drawing.Point(701, 105)
        Me.LblClock.Name = "LblClock"
        Me.LblClock.Size = New System.Drawing.Size(99, 76)
        Me.LblClock.TabIndex = 22
        Me.LblClock.Text = "---"
        '
        'TmrTime
        '
        Me.TmrTime.Interval = 1000
        '
        'IsTimed
        '
        Me.IsTimed.AutoSize = true
        Me.IsTimed.Location = New System.Drawing.Point(590, 198)
        Me.IsTimed.Name = "IsTimed"
        Me.IsTimed.Size = New System.Drawing.Size(32, 13)
        Me.IsTimed.TabIndex = 23
        Me.IsTimed.Text = "False"
        Me.IsTimed.Visible = false
        '
        'PicInfinity
        '
        Me.PicInfinity.Image = Global.DoceusFungi.My.Resources.Resources.Inifinity1
        Me.PicInfinity.Location = New System.Drawing.Point(702, 105)
        Me.PicInfinity.Name = "PicInfinity"
        Me.PicInfinity.Size = New System.Drawing.Size(126, 80)
        Me.PicInfinity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicInfinity.TabIndex = 24
        Me.PicInfinity.TabStop = false
        Me.PicInfinity.Visible = false
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCancel.Location = New System.Drawing.Point(836, 653)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(91, 23)
        Me.BtnCancel.TabIndex = 25
        Me.BtnCancel.Text = "Exit Round"
        Me.BtnCancel.UseVisualStyleBackColor = true
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = true
        Me.LblInfo.Location = New System.Drawing.Point(247, 203)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(25, 13)
        Me.LblInfo.TabIndex = 26
        Me.LblInfo.Text = "Info"
        Me.LblInfo.Visible = false
        '
        'BtnSound
        '
        Me.BtnSound.Image = Global.DoceusFungi.My.Resources.Resources.SoundOn
        Me.BtnSound.Location = New System.Drawing.Point(906, 12)
        Me.BtnSound.Name = "BtnSound"
        Me.BtnSound.Size = New System.Drawing.Size(19, 18)
        Me.BtnSound.TabIndex = 27
        Me.BtnSound.TabStop = false
        '
        'TmrCloseIntro
        '
        Me.TmrCloseIntro.Interval = 1
        '
        'FrmMain
        '
        Me.AcceptButton = Me.BtnFinalAns
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.CancelButton = Me.BtnPick
        Me.ClientSize = New System.Drawing.Size(950, 688)
        Me.Controls.Add(Me.BtnSound)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.IsTimed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.LblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblAns)
        Me.Controls.Add(Me.BtnFinalAns)
        Me.Controls.Add(Me.LstAns)
        Me.Controls.Add(Me.BtnPick)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicInfinity)
        Me.Controls.Add(Me.LblClock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DoceusFungi - What could it be?"
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicInfinity,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BtnSound,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnPick As Button
    Friend WithEvents LstAns As ListBox
    Friend WithEvents BtnFinalAns As Button
    Friend WithEvents LblAns As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblScore As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblClock As Label
    Friend WithEvents TmrTime As Timer
    Friend WithEvents IsTimed As Label
    Friend WithEvents PicInfinity As PictureBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents LblInfo As Label
    Friend WithEvents BtnSound As PictureBox
    Friend WithEvents TmrCloseIntro As Timer
End Class
