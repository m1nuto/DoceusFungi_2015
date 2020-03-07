Imports System.ComponentModel
Imports Mbutton
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDetails))
        Me.LblLatin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblInformation = New System.Windows.Forms.Label()
        Me.Mushbutton1 = New Mbutton.Mushbutton()
        Me.TxtInfo = New System.Windows.Forms.TextBox()
        Me.LnkHTTP = New System.Windows.Forms.LinkLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ChkAuto = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'LblLatin
        '
        Me.LblLatin.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.25!, System.Drawing.FontStyle.Bold)
        Me.LblLatin.Location = New System.Drawing.Point(6, 9)
        Me.LblLatin.Name = "LblLatin"
        Me.LblLatin.Size = New System.Drawing.Size(540, 35)
        Me.LblLatin.TabIndex = 0
        Me.LblLatin.Text = "Garcinia cambrosia"
        Me.LblLatin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 294)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(532, 391)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = false
        '
        'LblInformation
        '
        Me.LblInformation.AutoSize = true
        Me.LblInformation.BackColor = System.Drawing.Color.Transparent
        Me.LblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LblInformation.ForeColor = System.Drawing.Color.Gray
        Me.LblInformation.Location = New System.Drawing.Point(12, 60)
        Me.LblInformation.Name = "LblInformation"
        Me.LblInformation.Size = New System.Drawing.Size(84, 16)
        Me.LblInformation.TabIndex = 2
        Me.LblInformation.Text = "Information"
        '
        'Mushbutton1
        '
        Me.Mushbutton1.BackColor = System.Drawing.Color.Transparent
        Me.Mushbutton1.BackgroundImage = CType(resources.GetObject("Mushbutton1.BackgroundImage"),System.Drawing.Image)
        Me.Mushbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Mushbutton1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Mushbutton1.FlatAppearance.BorderSize = 0
        Me.Mushbutton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Mushbutton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Mushbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mushbutton1.Font = New System.Drawing.Font("Tahoma", 9.01!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Mushbutton1.Location = New System.Drawing.Point(12, 692)
        Me.Mushbutton1.Name = "Mushbutton1"
        Me.Mushbutton1.Size = New System.Drawing.Size(84, 40)
        Me.Mushbutton1.TabIndex = 4
        Me.Mushbutton1.Text = "Continue"
        Me.Mushbutton1.UseVisualStyleBackColor = true
        '
        'TxtInfo
        '
        Me.TxtInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.TxtInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TxtInfo.ForeColor = System.Drawing.Color.DarkOrange
        Me.TxtInfo.Location = New System.Drawing.Point(12, 79)
        Me.TxtInfo.Multiline = true
        Me.TxtInfo.Name = "TxtInfo"
        Me.TxtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtInfo.Size = New System.Drawing.Size(534, 209)
        Me.TxtInfo.TabIndex = 5
        Me.TxtInfo.Text = "Text"
        '
        'LnkHTTP
        '
        Me.LnkHTTP.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.LnkHTTP.AutoSize = true
        Me.LnkHTTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.LnkHTTP.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.LnkHTTP.Location = New System.Drawing.Point(338, 59)
        Me.LnkHTTP.Name = "LnkHTTP"
        Me.LnkHTTP.Size = New System.Drawing.Size(208, 16)
        Me.LnkHTTP.TabIndex = 6
        Me.LnkHTTP.TabStop = true
        Me.LnkHTTP.Text = "View More Information Online"
        Me.LnkHTTP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LnkHTTP.Visible = false
        '
        'Timer1
        '
        Me.Timer1.Interval = 2500
        '
        'ChkAuto
        '
        Me.ChkAuto.AutoSize = true
        Me.ChkAuto.Location = New System.Drawing.Point(454, 706)
        Me.ChkAuto.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkAuto.Name = "ChkAuto"
        Me.ChkAuto.Size = New System.Drawing.Size(93, 17)
        Me.ChkAuto.TabIndex = 7
        Me.ChkAuto.Text = "Auto Continue"
        Me.ChkAuto.UseVisualStyleBackColor = true
        '
        'FrmDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(558, 742)
        Me.Controls.Add(Me.ChkAuto)
        Me.Controls.Add(Me.LnkHTTP)
        Me.Controls.Add(Me.TxtInfo)
        Me.Controls.Add(Me.Mushbutton1)
        Me.Controls.Add(Me.LblInformation)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblLatin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrmDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DoceusFungi - Current specimen information..."
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents LblLatin As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblInformation As Label
    Friend WithEvents Mushbutton1 As Mushbutton
    Friend WithEvents TxtInfo As TextBox
    Friend WithEvents LnkHTTP As LinkLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ChkAuto As CheckBox
End Class
