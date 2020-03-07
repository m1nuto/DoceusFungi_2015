Imports System
Imports System.IO.File

Public Class FrmHighScore
    Dim ReadOnly _ap As String = AppDomain.CurrentDomain.BaseDirectory
    Dim _apd As String = Environment.ExpandEnvironmentVariables("%appdata%\DoceusFungi\")
    Dim ReadOnly _highscore1 As String = _ap & "h1.dat" 'apd & "h1.dat"
    Private Sub FrmHighScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FrmIntro.SoundYN.Text = "Y" Then
            My.Computer.Audio.Play(_ap & "Music\opening.wav", AudioPlayMode.Background)
        End If
        getscore()
    End Sub

    Public Sub Getscore()
        Dim t1 = ""
        Dim tn1 = ""
        Dim t2 = ""
        Dim tn2 = ""
        Dim t3 = ""
        Dim tn3 = ""

        Dim s1() As String = ReadAllText(_highscore1).Split(";"c)

        For Each s As String In s1
            Dim q() As String = s.Split(","c)
            If t1 = "" Then
                t1 = q(0)
                'MsgBox(q(0))
                tn1 = q(1)
            ElseIf t2 = "" Then
                t2 = q(0)
                tn2 = q(1)
            ElseIf t3 = "" Then
                t3 = q(0)
                tn3 = q(1)
            End If
        Next
        LblFirst.Text = t1 & " - " & tn1
        LblSecond.Text = t2 & " - " & tn2
        LblThird.Text = t3 & " - " & tn3

    End Sub



#Region "Close Window Arguments"
    Private Sub TmrClose_Tick(sender As Object, e As EventArgs) Handles TmrClose.Tick
        closeit()
    End Sub

    Private Sub Closeit()
        TmrClose.Enabled = False
        FrmIntro.Opacity = 1
        FrmIntro.Show()
        Close()
    End Sub

    Private Sub FrmHighScore_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        closeit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        closeit()
    End Sub

    Private Sub LblFirst_Click(sender As Object, e As EventArgs) Handles LblFirst.Click
        closeit()
    End Sub

    Private Sub LblSecond_Click(sender As Object, e As EventArgs) Handles LblSecond.Click
        closeit()
    End Sub

    Private Sub LblThird_Click(sender As Object, e As EventArgs) Handles LblThird.Click
        closeit()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        closeit()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        closeit()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        closeit()
    End Sub
#End Region

End Class