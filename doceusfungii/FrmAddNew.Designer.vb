Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmAddNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddNew))
        Me.TxtLatin = New System.Windows.Forms.TextBox()
        Me.TxtCommon = New System.Windows.Forms.TextBox()
        Me.TxtImg1 = New System.Windows.Forms.TextBox()
        Me.TxtImg2 = New System.Windows.Forms.TextBox()
        Me.TxtImg3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtLink = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtSummary = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtEdibility = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.LstShrooms = New System.Windows.Forms.ListBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TxtLatin
        '
        Me.TxtLatin.BackColor = System.Drawing.Color.DimGray
        Me.TxtLatin.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtLatin.Location = New System.Drawing.Point(120, 30)
        Me.TxtLatin.Name = "TxtLatin"
        Me.TxtLatin.Size = New System.Drawing.Size(619, 20)
        Me.TxtLatin.TabIndex = 1
        '
        'TxtCommon
        '
        Me.TxtCommon.BackColor = System.Drawing.Color.DimGray
        Me.TxtCommon.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtCommon.Location = New System.Drawing.Point(120, 62)
        Me.TxtCommon.Name = "TxtCommon"
        Me.TxtCommon.Size = New System.Drawing.Size(619, 20)
        Me.TxtCommon.TabIndex = 2
        '
        'TxtImg1
        '
        Me.TxtImg1.AllowDrop = true
        Me.TxtImg1.BackColor = System.Drawing.Color.DimGray
        Me.TxtImg1.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtImg1.Location = New System.Drawing.Point(12, 51)
        Me.TxtImg1.Name = "TxtImg1"
        Me.TxtImg1.Size = New System.Drawing.Size(731, 20)
        Me.TxtImg1.TabIndex = 6
        '
        'TxtImg2
        '
        Me.TxtImg2.BackColor = System.Drawing.Color.DimGray
        Me.TxtImg2.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtImg2.Location = New System.Drawing.Point(10, 114)
        Me.TxtImg2.Name = "TxtImg2"
        Me.TxtImg2.Size = New System.Drawing.Size(729, 20)
        Me.TxtImg2.TabIndex = 7
        '
        'TxtImg3
        '
        Me.TxtImg3.BackColor = System.Drawing.Color.DimGray
        Me.TxtImg3.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtImg3.Location = New System.Drawing.Point(10, 181)
        Me.TxtImg3.Name = "TxtImg3"
        Me.TxtImg3.Size = New System.Drawing.Size(729, 20)
        Me.TxtImg3.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(7, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Latin Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(8, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Common Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(7, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Img1"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(7, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Img2"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(7, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Img3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtImg1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtImg2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtImg3)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 320)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 229)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Web Links"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(702, 181)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = false
        Me.PictureBox3.Visible = false
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(706, 114)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = false
        Me.PictureBox2.Visible = false
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(706, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = false
        Me.PictureBox1.Visible = false
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtLink)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtSummary)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtEdibility)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtLatin)
        Me.GroupBox2.Controls.Add(Me.TxtCommon)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(749, 263)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Information"
        '
        'TxtLink
        '
        Me.TxtLink.BackColor = System.Drawing.Color.DimGray
        Me.TxtLink.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtLink.Location = New System.Drawing.Point(120, 225)
        Me.TxtLink.Name = "TxtLink"
        Me.TxtLink.Size = New System.Drawing.Size(619, 20)
        Me.TxtLink.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(8, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Link"
        '
        'TxtSummary
        '
        Me.TxtSummary.BackColor = System.Drawing.Color.DimGray
        Me.TxtSummary.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtSummary.Location = New System.Drawing.Point(120, 126)
        Me.TxtSummary.Multiline = true
        Me.TxtSummary.Name = "TxtSummary"
        Me.TxtSummary.Size = New System.Drawing.Size(619, 88)
        Me.TxtSummary.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(8, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Summary"
        '
        'TxtEdibility
        '
        Me.TxtEdibility.BackColor = System.Drawing.Color.DimGray
        Me.TxtEdibility.ForeColor = System.Drawing.Color.OrangeRed
        Me.TxtEdibility.Location = New System.Drawing.Point(120, 95)
        Me.TxtEdibility.Name = "TxtEdibility"
        Me.TxtEdibility.Size = New System.Drawing.Size(619, 20)
        Me.TxtEdibility.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(8, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Edibility"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(637, 272)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(105, 38)
        Me.BtnAdd.TabIndex = 100
        Me.BtnAdd.Text = "Add/Update"
        Me.BtnAdd.UseVisualStyleBackColor = true
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.DarkOrange
        Me.LinkLabel1.AutoSize = true
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Gray
        Me.LinkLabel1.Location = New System.Drawing.Point(7, 272)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(53, 13)
        Me.LinkLabel1.TabIndex = 102
        Me.LinkLabel1.TabStop = true
        Me.LinkLabel1.Text = "Full Edit"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.DoceusFungi.My.Resources.Resources.bannerInvert
        Me.PictureBox4.Location = New System.Drawing.Point(1, 573)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(749, 165)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = false
        '
        'LstShrooms
        '
        Me.LstShrooms.BackColor = System.Drawing.Color.Gray
        Me.LstShrooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.LstShrooms.ForeColor = System.Drawing.Color.DarkOrange
        Me.LstShrooms.FormattingEnabled = true
        Me.LstShrooms.ItemHeight = 17
        Me.LstShrooms.Location = New System.Drawing.Point(766, 12)
        Me.LstShrooms.Name = "LstShrooms"
        Me.LstShrooms.Size = New System.Drawing.Size(407, 701)
        Me.LstShrooms.TabIndex = 11
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(526, 272)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(105, 38)
        Me.BtnClear.TabIndex = 101
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = true
        '
        'FrmAddNew
        '
        Me.AllowDrop = true
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1185, 735)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.LstShrooms)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ForeColor = System.Drawing.Color.DarkOrange
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrmAddNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DoceusFungi - Add New Mushroom"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents TxtLatin As TextBox
    Friend WithEvents TxtCommon As TextBox
    Friend WithEvents TxtImg1 As TextBox
    Friend WithEvents TxtImg2 As TextBox
    Friend WithEvents TxtImg3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtSummary As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtEdibility As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtLink As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LstShrooms As ListBox
    Friend WithEvents BtnClear As Button
End Class
