Imports System.Windows.Forms
Imports System.Drawing
Imports DoceusFungi.My.Resources

Public Class FrmIntro

    Dim ReadOnly _ad As String = AppDomain.CurrentDomain.BaseDirectory

    Private Sub Intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnScore.ForeColor = Color.Cornsilk
        BtnFree.ForeColor = Color.Cornsilk
        If SoundYN.Text = "Y" Then
            My.Computer.Audio.Play(_ad & "Music\beginning.wav", AudioPlayMode.Background)
        End If
    End Sub

    Private Sub BtnFree_Click(sender As Object, e As EventArgs) Handles BtnFree.Click
        BtnFree.ForeColor = Color.Red
        FrmMain.IsTimed.Text = "False"
        
        FrmMain.Show()
        Hide()
    End Sub
    Private Sub BtnFree_Over(sender As Object, e As EventArgs) Handles BtnFree.MouseEnter
        BtnFree.ForeColor = Color.Yellow
    End Sub
    Private Sub BtnFree_Exit(sender As Object, e As EventArgs) Handles BtnFree.MouseLeave
        BtnFree.ForeColor = Color.Cornsilk
    End Sub
    Private Sub BtnScore_Down(sender As Object, e As EventArgs) Handles BtnScore.MouseDown
        BtnScore.ForeColor = Color.Black
    End Sub
    Private Sub BtnFree_Down(sender As Object, e As EventArgs) Handles BtnFree.MouseDown
        BtnFree.ForeColor = Color.Black
    End Sub
    Private Sub BtnScore_Click(sender As Object, e As EventArgs) Handles BtnScore.Click
        Opacity = 0
        BtnScore.ForeColor = Color.White
        FrmMain.IsTimed.Text = "True"
        FrmMain.Show()
        Hide()
    End Sub
    Private Sub BtnScore_Over(sender As Object, e As EventArgs) Handles BtnScore.MouseEnter
        BtnScore.ForeColor = Color.Yellow
    End Sub
    Private Sub BtnScore_Exit(sender As Object, e As EventArgs) Handles BtnScore.MouseLeave
        BtnScore.ForeColor = Color.Cornsilk
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If SoundYN.Text = "Y" Then
            My.Computer.Audio.Stop()
        End If
        FrmAddNew.Show()
        Close()
    End Sub

    Private Sub BtnSound_Click(sender As Object, e As EventArgs) Handles BtnSound.Click
        If SoundYN.Text = "Y" Then
            SoundYN.Text = "N"
            BtnSound.Image = SoundOff
            Try
                My.Computer.Audio.Stop()
            Catch ex As Exception

            End Try
        Else
            SoundYN.Text = "Y"
            BtnSound.Image = SoundOn
        End If

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        FrmHighScore.Show()
    End Sub

    
End Class