Imports System
Imports System.IO
Imports System.Collections
Imports System.IO.File
Imports DoceusFungi.My.Resources


Public Class FrmMain

    'Program Variables
    Dim _mywidth As String = My.Computer.Screen.WorkingArea.Width
    Dim _myheight As String = My.Computer.Screen.WorkingArea.Height
    Dim ReadOnly _h As String = AppDomain.CurrentDomain.BaseDirectory.ToString
    Dim ReadOnly _flist As String = ReadAllText(_h & "flist.txt")
    Dim ReadOnly _priArray() As String = _flist.Split(Environment.NewLine)
    Dim ReadOnly _ad As String = AppDomain.CurrentDomain.BaseDirectory
    Dim _thefile1 As String
    Dim _thefile2 As String
    Dim _thefile3 As String
    Dim _spore As String
    Dim _ispore As Boolean
    Dim _score As String = 0
    Dim _time As Integer = 180
    Dim _pushpass As Integer = 0

    'highscores
    Dim ReadOnly _highscore1 As String = _apd & "h1.dat"
    Dim _ismissed As String = 0
    'Mushroom Variables
    Dim _chose As String = Nothing

    Public Sub Tryans()
        If LstAns.SelectedIndex > -1 Then
            If LstAns.SelectedItem.ToString.Trim() = LblAns.Text.Trim() Then
                If _ismissed = 0 And BtnFinalAns.Enabled = True Then
                    If FrmIntro.R30.Checked = True Then
                        _score = _score + 10 * 6
                    Else
                        _score = _score + 10
                    End If
                Else
                    If FrmIntro.R30.Checked = True Then
                        _score = _score + 4 * 6
                    Else
                        _score = _score + 4
                    End If
                End If
                scorcol()
                If FrmIntro.SoundYN.Text = "Y" Then
                    My.Computer.Audio.Play(_ad & "Music\right.wav", AudioPlayMode.Background)
                End If
                LblScore.Text = _score
                Dim curline As String = ReadAllLines(_ad & "flist.txt").FirstOrDefault(Function(x) x.Contains(_chose.Trim()))
                Dim chArray As String() = curline.Split("|")
                Dim spr = ""
                Dim myint As Integer = chArray.Length
                Dim curin = 0
                Do Until myint = 0
                    Try
                        spr &= chArray(curin) & Environment.NewLine
                    Catch ex As Exception

                    End Try
                    curin = curin + 1
                    myint = myint - 1
                Loop
                TmrTime.Stop()
                LblInfo.Text = spr
                LstAns.Text = chArray(1)
                Visible = False
                FrmDetails.Visible = True
                'MsgBox(spr, MsgBoxStyle.Information, "GREAT JOB!!") 'chArray(0) & " " & chArray(1))
            Else
                _ismissed = 1
                BtnFinalAns.Enabled = False
                If FrmIntro.R30.Checked = True Then
                    _score = _score - 7 * 6
                Else
                    _score = _score - 7
                End If

                scorcol()
                If FrmIntro.SoundYN.Text = "Y" Then
                    My.Computer.Audio.Play(_ad & "Music\wrong.wav", AudioPlayMode.Background)
                End If
                LblScore.Text = _score
                For i = 0 To LstAns.SelectedIndices.Count - 1
                    LstAns.Items.RemoveAt(LstAns.SelectedIndex)
                Next
            End If
        End If

    End Sub
    Public Sub Geton()
        _ismissed = 0
        Visible = True
        FindMush()
        If IsTimed.Text = True Then
            TmrTime.Start()
        End If
    End Sub
    Public Sub Scorcol()
        If _score > 0 Then
            LblScore.ForeColor = Color.Green
        ElseIf _score < 0 Then
            LblScore.ForeColor = Color.Crimson
        ElseIf _score = 0 Then
            LblScore.ForeColor = Color.Black
        End If
    End Sub
    'Functions
    Dim _canapp As Boolean = True
    Dim ReadOnly _apd As String = Environment.ExpandEnvironmentVariables("%appdata%\DoceusFungi\")

    Private Sub FrmMain_Leave(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        If FrmHighScore.Visible = False Then
            FrmIntro.Opacity = 1
            FrmIntro.Show()
            FrmIntro.Focus()
        End If
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        If FrmIntro.R30.Checked = True Then
            _time = 30
            LblClock.Text = 30
        Else
            _time = 180
            LblClock.Text = 180
        End If
        If FrmIntro.SoundYN.Text = "Y" Then
            My.Computer.Audio.Play(_ad & "Music\start.wav", AudioPlayMode.Background)
        Else
            BtnSound.Image = SoundOff
        End If
        Try
            If Directory.Exists(_apd) = False Then
                Try
                    Directory.CreateDirectory(_apd)
                    WriteAllText(_highscore1, "35,Chad;20,Tiffany;10,Jonathan")
                Catch ex As Exception

                End Try
            End If
            _canapp = True
        Catch ex As Exception
            _canapp = False
        End Try

        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
        LblAns.Hide()
        CenterToScreen()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        FindMush()
        If IsTimed.Text = "True" Then
            TmrTime.Enabled = True
            PicInfinity.Visible = False
        Else
            TmrTime.Enabled = False
            PicInfinity.Visible = True
        End If
        Focus()

    End Sub


    Public Function GetAllMush() As String()
        Dim priArray() As String = (ReadAllText(_h & "flist.txt")).Split(Environment.NewLine)
        return priArray
    End Function

    Public Function ReturnSelection(latName As String) As String()
        dim mymush() as String
        Dim curList() as String = GetAllMush()
        For each str as String in CurList
            if Str.ToLower.Contains(LatName.ToLower)
                mymush = Str.Split("|"c)
                return mymush
            End If
        Next
    End Function

    Public Sub FindMush()
        BtnFinalAns.Enabled = True
        Try
            PictureBox1.Image.Dispose()
            PictureBox2.Image.Dispose()
            PictureBox3.Image.Dispose()
        Catch ex As Exception

        End Try

        Dim T = 0
        Dim list As New ArrayList
        Dim used = ""
        Dim pic = 0
        Dim rand1 As New Random()
        _chose = Nothing

        Do Until T = 5
            Dim index1 As Integer = Rand1.Next(0, _priArray.Length - 1)
            Dim gethere() As String = _priArray(Index1).Split(Environment.NewLine)
            Dim nocommon() As String = gethere(0).Split("|")
            Dim mname as String = nocommon(0).Trim.Replace(vbLf,"")
            If used.Contains(mname) = False Then
                list.Add(mname)
                used &= mname & "|"
                T = T + 1
                pic = pic + 1
            End If
        Loop

        Dim posans() As String = used.Split("|")
        Dim randChoose As New Random()
        Dim myPic As Integer = RandChoose.Next(0, posans.Length - 1)
        LblAns.Text = posans(MyPic).Trim
        _chose = LblAns.Text

        LstAns.Items.Clear()
        LstAns.Items.Add(list(0).ToString.Trim.Replace(vbLf,""))
        LstAns.Items.Add(list(1).ToString.Trim.Replace(vbLf,""))
        LstAns.Items.Add(list(2).ToString.Trim.Replace(vbLf,""))
        LstAns.Items.Add(list(3).ToString.Trim.Replace(vbLf,""))
        LstAns.Items.Add(list(4).ToString.Trim.Replace(vbLf,""))

        If _ispore = True Then
            _thefile1 = _ad & LblAns.Text.Trim() & "\mush1.jpg"
            _thefile2 = _ad & LblAns.Text.Trim() & "\mush2.jpg"
        Else
            _thefile1 = _ad & LblAns.Text.Trim() & "\mush2.jpg"
            _thefile2 = _ad & LblAns.Text.Trim() & "\mush1.jpg"
        End If
        _thefile3 = _ad & LblAns.Text.Trim() & "\mush3.jpg"
        _spore = _ad & LblAns.Text.Trim() & "\spore1.jpg"
        If Exists(_thefile1) = True Then
            Try
                PictureBox1.Image = Bitmap.FromFile(_thefile1.ToString.Trim)
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
            Try
                PictureBox2.Image = Bitmap.FromFile(_thefile2.ToString.Trim)
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
            If Exists(_spore) = True Then
                _ispore = True
                Try
                    PictureBox3.Image = Bitmap.FromFile(_spore.Trim)
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try

            Else
                Try
                    PictureBox3.Image = Bitmap.FromFile(_thefile3.Trim)
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
                _ispore = False
            End If
        Else
            PictureBox1.Image = Bitmap.FromFile(_ad & "notdone.jpg")
        End If
    End Sub
    Private Sub BtnPick_Click(sender As Object, e As EventArgs) Handles BtnPick.Click
        _pushpass = _pushpass + 1
        _score = _score - 2 * _pushpass
        LblScore.Text = _score
        If FrmIntro.SoundYN.Text = "Y" Then
            My.Computer.Audio.Play(_ad & "Music\death.wav", AudioPlayMode.Background)
        End If
        FindMush()
    End Sub
    Private Sub BtnPick_Over(sender As Object, e As EventArgs) Handles BtnPick.MouseEnter
        BtnPick.BackColor = Color.Black
        BtnPick.ForeColor = Color.DarkOrange
    End Sub
    Private Sub BtnPick_Exit(sender As Object, e As EventArgs) Handles BtnPick.MouseLeave
        BtnPick.BackColor = Color.DarkOrange
        BtnPick.ForeColor = Color.Black
    End Sub
    Private Sub BtnFinalAns_Click(sender As Object, e As EventArgs) Handles BtnFinalAns.Click
        My.Computer.Audio.Play(_ad & "Music\right.wav", AudioPlayMode.Background)
        BtnFinalAns.Enabled = False
        Dim t = 0
        Dim i = 0
        Do Until t = 2
            If LstAns.Items(i).ToString.Trim() <> LblAns.Text.Trim() Then
                'MsgBox(LstAns.Items(i).ToString)
                LstAns.Items.Remove(LstAns.Items(i).ToString)
                t = t + 1
                If i <> 0 Then
                    i = i - 1
                End If
            End If
            i = i + 1
        Loop
        _score = _score - 3
        LblScore.Text = _score
        Dim an1 As String = LstAns.Items(0).ToString
        Dim an2 As String = LstAns.Items(1).ToString
        Dim an3 As String = LstAns.Items(2).ToString
        LstAns.Items.Clear()
        LstAns.Items.Add(an2)
        LstAns.Items.Add(an3)
        LstAns.Items.Add(an1)
    End Sub
    Private Sub BtnFinalAns_Over(sender As Object, e As EventArgs) Handles BtnFinalAns.MouseEnter
        BtnFinalAns.BackColor = Color.Black
        BtnFinalAns.ForeColor = Color.DarkOrange
    End Sub
    Private Sub BtnFinalAns_Exit(sender As Object, e As EventArgs) Handles BtnFinalAns.MouseLeave
        BtnFinalAns.BackColor = Color.DarkOrange
        BtnFinalAns.ForeColor = Color.Black
    End Sub
    Private Sub LstAns_DoubleClicked(sender As Object, e As EventArgs) Handles LstAns.DoubleClick
        tryans()
    End Sub
    Private Sub BtnCancel_Over(sender As Object, e As EventArgs) Handles BtnCancel.MouseEnter
        BtnCancel.BackColor = Color.Black
        BtnCancel.ForeColor = Color.DarkOrange
    End Sub
    Private Sub BtnCancel_Exit(sender As Object, e As EventArgs) Handles BtnCancel.MouseLeave
        BtnCancel.BackColor = Color.DarkOrange
        BtnCancel.ForeColor = Color.Black
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim todo As String = Chr(34) & "C:\Program Files\Windows Photo Viewer\PhotoViewer.dll" & Chr(34) & "," & Chr(34) & _thefile1 & Chr(34)
        Clipboard.SetText(todo)
        Process.Start("C:\Windows\explorer.exe", _thefile1)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("C:\Windows\explorer.exe", _thefile2)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If _ispore = True Then
            Process.Start("C:\Windows\explorer.exe", _spore)
        Else
            Process.Start("C:\Windows\explorer.exe", _thefile3)
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FindMush()
        Timer1.Enabled = False
    End Sub

    Public Sub Clock()
        Dim curtime As Integer = _time - 1
        TmrCloseIntro.Enabled = True
        If curtime = 0 Then
            If FrmIntro.SoundYN.Text = "Y" Then
                My.Computer.Audio.Play(_ad & "Music\begin.wav", AudioPlayMode.Background)
            End If
            TmrTime.Stop()
            TmrCloseIntro.Enabled = False
            LblClock.Text = curtime.ToString

            highscore()
            FrmHighScore.Show()
            FrmHighScore.Focus()
            Close()
        Else
            If curtime < 10 Then
                LblClock.ForeColor = Color.Crimson
            End If
            LblClock.Text = curtime.ToString
        End If
        _time = _time - 1
    End Sub

    Private Sub TmrTime_Tick(sender As Object, e As EventArgs) Handles TmrTime.Tick
        FrmIntro.Hide()
        clock()
    End Sub
    Public Sub Highscore()
        Try
            Dim t1 = ""
            Dim tn1 = ""
            Dim t2 = ""
            Dim tn2 = ""
            Dim t3 = ""
            Dim tn3 = ""

            Dim s1() As String = ReadAllText(_highscore1).Split(";")

            For Each entry As String In s1
                Dim en() As String = entry.Split(",")
                If t1 = "" Then
                    t1 = en(0)
                    tn1 = en(1)
                ElseIf t2 = "" Then
                    t2 = en(0)
                    tn2 = en(1)
                ElseIf t3 = "" Then
                    t3 = en(0)
                    tn3 = en(1)
                End If
            Next



            If _score > tn1 Or tn1 = "" Then
                    Dim message, title, defaultValue As String
                    Dim myValue As Object
                    message = "You have the highest score with " & _score & " points!" & Environment.NewLine & "Please enter your name:"
                    title = "HIGH SCORE!!!"
                    defaultValue = "Unknown"
                    myValue = InputBox(message, title, defaultValue)
                    If myValue Is "" Then myValue = defaultValue

                    WriteAllText(_highscore1, myValue & "," & _score & ";" &
                                                     t1 & "," & tn1 & ";" & t2 & "," & tn2)
                ElseIf _score > tn2 Or tn2 = "" Then
                    Dim message, title, defaultValue As String
                    Dim myValue As Object
                    message = "You have the 2nd highest score with " & _score & " points!" & Environment.NewLine & "Please enter your name:"
                    title = "HIGH SCORE!!!"
                    defaultValue = "Unknown"
                    myValue = InputBox(message, title, defaultValue)
                    If myValue Is "" Then myValue = defaultValue

                    WriteAllText(_highscore1, t1 & "," & tn1 & ";" & myValue & "," & _score &
                                      ";" & t2 & "," & tn2)

                ElseIf _score > tn3 Or tn3 = "" Then
                    Dim message, title, defaultValue As String
                    Dim myValue As Object
                    message = "You have the 3rd highest score with " & _score & " points!" & Environment.NewLine & "Please enter your name:"
                    title = "HIGH SCORE!!!"
                    defaultValue = "Unknown"
                    myValue = InputBox(message, title, defaultValue)
                    If myValue Is "" Then myValue = defaultValue

                    WriteAllText(_highscore1, t1 & "," & tn1 & ";" & t2 & "," & tn2 &
                                          ";" & myValue & "," & _score)
                End If

        Catch ex As Exception

        End Try


    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        FrmIntro.Opacity = 1
        FrmIntro.Show()
        If FrmIntro.SoundYN.Text = "Y" Then
            My.Computer.Audio.Play(_ad & "Music\beginning.wav", AudioPlayMode.Background)
        End If
        Close()
    End Sub

    Private Sub BtnSound_Click(sender As Object, e As EventArgs) Handles BtnSound.Click
        If FrmIntro.SoundYN.Text = "Y" Then
            FrmIntro.SoundYN.Text = "N"
            BtnSound.Image = SoundOff
            FrmIntro.BtnSound.Image = SoundOff
            Try
                My.Computer.Audio.Stop()
            Catch ex As Exception

            End Try
        Else
            FrmIntro.SoundYN.Text = "Y"
            BtnSound.Image = SoundOn
            FrmIntro.BtnSound.Image = SoundOn
        End If

    End Sub

    Private Sub TmrCloseIntro_Tick(sender As Object, e As EventArgs) Handles TmrCloseIntro.Tick
        FrmIntro.Hide()
    End Sub

End Class
