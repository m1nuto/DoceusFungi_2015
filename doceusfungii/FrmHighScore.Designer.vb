Imports System.ComponentModel
Imports DoceusFungi.My.Resources
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmHighScore
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
        Me.components = New Container()
        Me.Label1 = New Label()
        Me.Label2 = New Label()
        Me.Label3 = New Label()
        Me.LblFirst = New Label()
        Me.LblSecond = New Label()
        Me.PictureBox1 = New PictureBox()
        Me.LblThird = New Label()
        Me.TmrClose = New Timer(Me.components)
        CType(Me.PictureBox1, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = Color.Black
        Me.Label1.Font = New Font("Microsoft Sans Serif", 35.25!)
        Me.Label1.ForeColor = Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Label1.Location = New Point(24, 288)
        Me.Label1.Margin = New Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(170, 107)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1st"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New Font("Microsoft Sans Serif", 20.25!)
        Me.Label2.ForeColor = Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label2.Location = New Point(52, 431)
        Me.Label2.Margin = New Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(117, 63)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2nd"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New Font("Microsoft Sans Serif", 15.25!)
        Me.Label3.ForeColor = Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label3.Location = New Point(54, 548)
        Me.Label3.Margin = New Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(80, 47)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "3rd"
        '
        'LblFirst
        '
        Me.LblFirst.AutoSize = True
        Me.LblFirst.BackColor = Color.Black
        Me.LblFirst.Font = New Font("Microsoft Sans Serif", 35.25!)
        Me.LblFirst.ForeColor = Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.LblFirst.Location = New Point(212, 288)
        Me.LblFirst.Margin = New Padding(6, 0, 6, 0)
        Me.LblFirst.Name = "LblFirst"
        Me.LblFirst.Size = New Size(462, 107)
        Me.LblFirst.TabIndex = 3
        Me.LblFirst.Text = "FirstPlace"
        '
        'LblSecond
        '
        Me.LblSecond.AutoSize = True
        Me.LblSecond.Font = New Font("Microsoft Sans Serif", 20.25!)
        Me.LblSecond.ForeColor = Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.LblSecond.Location = New Point(212, 431)
        Me.LblSecond.Margin = New Padding(6, 0, 6, 0)
        Me.LblSecond.Name = "LblSecond"
        Me.LblSecond.Size = New Size(346, 63)
        Me.LblSecond.TabIndex = 4
        Me.LblSecond.Text = "SecondPlace"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = bannerInvert
        Me.PictureBox1.Location = New Point(26, 25)
        Me.PictureBox1.Margin = New Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(852, 238)
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'LblThird
        '
        Me.LblThird.AutoSize = True
        Me.LblThird.Font = New Font("Microsoft Sans Serif", 15.25!)
        Me.LblThird.ForeColor = Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.LblThird.Location = New Point(214, 548)
        Me.LblThird.Margin = New Padding(6, 0, 6, 0)
        Me.LblThird.Name = "LblThird"
        Me.LblThird.Size = New Size(219, 47)
        Me.LblThird.TabIndex = 5
        Me.LblThird.Text = "ThirdPlace"
        '
        'TmrClose
        '
        Me.TmrClose.Enabled = True
        Me.TmrClose.Interval = 5100
        '
        'FrmHighScore
        '
        Me.AutoScaleDimensions = New SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.Black
        Me.ClientSize = New Size(902, 648)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblThird)
        Me.Controls.Add(Me.LblSecond)
        Me.Controls.Add(Me.LblFirst)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.Margin = New Padding(6)
        Me.Name = "FrmHighScore"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "DoceusFungi - High Scores"
        Me.TopMost = True
        CType(Me.PictureBox1, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblFirst As Label
    Friend WithEvents LblSecond As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblThird As Label
    Friend WithEvents TmrClose As Timer
End Class
