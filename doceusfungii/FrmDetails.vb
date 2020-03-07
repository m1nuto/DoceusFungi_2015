Public Class FrmDetails
    Dim ReadOnly _ad As String = AppDomain.CurrentDomain.BaseDirectory
    Dim _link As String = ""

    Private Sub FrmDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        TopMost = True
        LnkHTTP.Visible = False
        'FrmMain.Enabled = False
        placeinfo(FrmMain.LblInfo.Text, FrmMain.LstAns.SelectedItem.ToString)
    End Sub
    Private Sub FrmDetails_Enter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        If FrmIntro.LblAutoDetails.Text = "Y" Then
            ChkAuto.Checked = True
            Timer1.Enabled = True
        Else
            ChkAuto.Checked = False
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub FrmDetails_Leave(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        FrmMain.Show()
        FrmMain.geton()
        'TxtInfo.Clear()
        'FrmMain.Enabled = True
        'FrmMain.Visible = True
        'FrmMain.TmrTime.Start()
    End Sub
    Public Sub Placeinfo(content As String, latin As String)
        If content.Contains("http") Then
            Dim final As String = Nothing
            Dim allcon() As String = content.Split(Environment.NewLine)
            For Each ary As String In allcon
                If ary.Contains("http") Then
                    _link = ary.ToString.Trim()
                    LnkHTTP.Visible = True
                Else
                    final &= ary & Environment.NewLine
                End If
            Next
            TxtInfo.Text = final.Trim()
        Else
            TxtInfo.Text = content.Trim()
        End If
        LblLatin.Text = latin.Trim()
        Dim pic As String = _ad & latin.Trim() & "\mush1.jpg"
        Try
            PictureBox1.Image = Bitmap.FromFile(pic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Mushbutton1_Click(sender As Object, e As EventArgs) Handles Mushbutton1.Click
        back()
    End Sub
    Public Sub Back()
        FrmMain.geton()
        Close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TopMost = False
        Dim pic As String = _ad & LblLatin.Text & "\mush1.jpg"
        Process.Start("C:\Windows\explorer.exe", pic)
    End Sub

    Private Sub LnkHTTP_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkHTTP.LinkClicked
        TopMost = False
        Process.Start(_link)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        back()
    End Sub

    Private Sub ChkAuto_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAuto.CheckedChanged
        If ChkAuto.Checked = True Then
            FrmIntro.LblAutoDetails.Text = "Y"
            Timer1.Enabled = True
        Else
            FrmIntro.LblAutoDetails.Text = "N"
            Timer1.Enabled = False
        End If
    End Sub
End Class