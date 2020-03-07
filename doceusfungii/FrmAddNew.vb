Imports System
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Drawing


Public Class FrmAddNew
    Dim ReadOnly _h As String = AppDomain.CurrentDomain.BaseDirectory
    Dim ReadOnly _dfile As String = _h & "flist.txt"
    Dim _flist As String = File.ReadAllText(_dfile)
    Dim ReadOnly _ad As String = AppDomain.CurrentDomain.BaseDirectory
    Dim _isChanged as Boolean = false
    Dim _curMush as String = ""
    Dim ReadOnly _nl as String = Environment.NewLine
   

    Public Function GetAllMush() As String()
        Dim priArray() As String = (File.ReadAllText(_dfile)).Split(Environment.NewLine)
        Dim t As Integer = PriArray.Count()
        Dim i = 0
        Do Until i = t
            PriArray(i) = PriArray(i).Trim.Replace(vbLf,"")
            i =i + 1
        Loop
     
        return priArray
    End Function
     
    Public Function ReturnSelection(latName As String, Optional returnLine As Boolean = False) As String()
        _isChanged = false
        dim mymush() as String = nothing
        Dim curList() as String = GetAllMush()
        For each str as String in CurList
            if Str.ToLower.Contains(LatName.ToLower)
                dim ttlStr as String = Str.Trim.Replace(vblf,"").Trim
                
                if ReturnLine = True
                   ' dim tmpS() as String = ttlStr.Split("|"c)
                        ttlStr= ttlStr & "^"

                       mymush = ttlstr.Split("^"c)
                    
                    else

                        mymush = ttlStr.Split("|"c)
               
                End If
                 return mymush
            End If
            
        Next
    End Function

    Public Sub UpdateMush()
        Dim newList as String = Nothing
        dim curList() as String = ReturnSelection(_curMush,True)

        For Each st as string in GetAllMush()
            dim curSt as String = st.Trim.Replace(vbLf,"")
            dim chos as String
            if curSt.Contains(CurList(0)) = True

                chos = ReturnCurFieldsStr()
              else
                chos = st

            End If

            if newList = Nothing
               newList = chos.Trim.Replace(vbLf,"")
                else
                newList &= _nl & chos.Trim.Replace(vbLf,"")
            End If

        Next
        ImgUpdate(TxtImg1,1)
        ImgUpdate(TxtImg2,2)
        ImgUpdate(TxtImg3,3)
        'MsgBox(newList)
        File.WriteAllText(_dfile,newList)
        _curMush = ""
        ListAll()

    End Sub

    Public Function ReturnCurFields() As String()
        Return ReturnCurFieldsStr.Split("|"c)
    End Function

    Public Function ReturnCurFieldsStr() As String
        dim wh as String = TxtLatin.Text.Trim & "|" & TxtCommon.Text.Trim & "|" & TxtEdibility.Text.Trim & "|" & TxtSummary.Text.Trim & "|" & _
                           TxtLink.Text.Trim
        Return wh
    End Function


    Public Function TestChange(pickShroom) As Boolean
         _isChanged = false

        dim msh() As String = ReturnSelection(PickShroom)
        Dim cMsh() as String = ReturnCurFields()
        Dim i = 0

        for each str as String in Msh
            if Msh(i).Trim <> CMsh(i).Trim
                _isChanged = true
            End If
            i = i + 1
        Next

        Return _isChanged
    End Function

    Public Function ReturnShroomInfo(pickShroom, neededValue) As string
        On Error Resume Next
        dim mush() as String = ReturnSelection(PickShroom)
        Select neededValue
            Case "Latin"
                Return mush(0).Trim
            Case "Common"
                Return mush(1).Trim
            Case "Edibility"
                Return mush(2).Trim
            Case "Summary"
                Return mush(3).Trim
            Case "Link"
                 Return mush(4).Trim
            Case "all"
                if _curMush <> ""
                    if TestChange(_curMush) = False
                    Goto UpdateMush
                       Else 
                           'MsgBox("Save Data First")
                           UpdateMush()
                           
                           'LstShrooms.SelectedItem = CurMush
                           Exit Function

                    End If

                    Else

                    Goto UpdateMush
                    

                End If
                UpdateMush:
                TxtLatin.Text = mush(0).Trim
                TxtCommon.Text = mush(1).Trim
                TxtEdibility.Text = mush(2).Trim
                TxtSummary.Text = mush(3).Trim
                TxtLink.Text = mush(4).Trim
                _curMush = mush(0).Trim
                ImgPaths(_curMush)
                Exit Function
                'Case "Img1"
                '     Return mush(5)
                ' Case "Img2"
                '      Return mush(6)
                ' Case "Img3"
                '      Return mush(7)
        End Select
    End Function

    Public Sub ListAll()
        ClearAll()
        Dim allMush() as String = getallmush()

        Array.Sort(AllMush)

        for each str As String in AllMush
            dim sname() as string = str.Split("|"c)
            LstShrooms.Items.Add(sname(0).Trim)
        Next
        'Dim flist As String = File.ReadAllText(dfile)
        'Dim pcdir As String = h & TxtLatin.Text & "\"
        
    End Sub


    'Public Sub SelectMush()
    '    LstShrooms.Text
    'End Sub



    Public Sub ImgPaths(curMush)
        dim i = 1
        dim mDir = _ad & CurMush & "\" 
        

        Do until i = 4
            dim curimg = mDir & "mush" & i & ".jpg"
            dim sporimg = mDir & "spore" & ".jpg"
             If File.Exists(curimg)
                 dim curTxt = "TxtImg" & i
                Dim ctrl As Object = Controls.Find(curTxt, True).FirstOrDefault()
                
                'dim Ctrl as TextBox = CType(Controls(CurTxt), Control)'CType(Me.Controls(Curtxt), TextBox)
                 If Ctrl IsNot Nothing
                     Ctrl.Text = curimg
                  end If
             ElseIf i = 3 andAlso File.Exists(SporIMg)
                dim ctrl = CType(Controls("TxtImg" & i), TextBox)
                Ctrl.Text = sporimg
            End If
            i = i + 1
        Loop
    end Sub


    Public Sub Doupdate()
        If TxtCommon.Text <> "" And TxtEdibility.Text <> "" And TxtSummary.Text <> "" And TxtLink.Text <> "" And TxtLatin.Text <> "" And TxtImg1.Text <> "" And TxtImg2.Text <> "" And TxtImg3.Text <> "" Then
            Dim flist As String = File.ReadAllText(_dfile)
            Dim pcdir As String = _h & TxtLatin.Text & "\"
            If flist.Contains(TxtLatin.Text) Then
                Dim result As Integer = MessageBox.Show("This mushroom added, overwrite?", "Overwrite", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    MessageBox.Show("Not entered at user request.", "Overwrite Canceled")
                ElseIf result = DialogResult.Yes Then
                    File.Delete(pcdir & "mush1.jpg")
                    File.Delete(pcdir & "mush2.jpg")
                    File.Delete(pcdir & "mush3.jpg")
                    Dim newresult As String
                    Dim t = 0
                    For Each deal As String In flist.Split(Environment.NewLine)
                        If deal.Contains(TxtLatin.Text) Then
                        Else
                            Dim tr As String = deal.Trim
                            If t = 0 Then
                                newresult = tr
                                t = 1
                            Else
                                newresult &= Environment.NewLine & tr
                            End If
                        End If
                    Next
                    newresult &= Environment.NewLine & TxtLatin.Text & "|" & TxtCommon.Text & "|" & TxtEdibility.Text & "|" & TxtSummary.Text & "|" & TxtLink.Text
                    File.WriteAllText(_dfile, newresult)
                    Try
                        My.Computer.Network.DownloadFile(TxtImg1.Text, pcdir & "mush1.jpg")
                    Catch ex As Exception
                    End Try
                    Try
                        My.Computer.Network.DownloadFile(TxtImg2.Text, pcdir & "mush2.jpg")
                    Catch ex As Exception
                    End Try
                    Try
                        My.Computer.Network.DownloadFile(TxtImg3.Text, pcdir & "mush3.jpg")
                    Catch ex As Exception
                    End Try
                    clearall()
                End If
            Else
                If Directory.Exists(pcdir) = False Then
                    Directory.CreateDirectory(pcdir)
                End If
                flist &= Environment.NewLine & TxtLatin.Text & "|" & TxtCommon.Text & "|" & TxtEdibility.Text & "|" & TxtSummary.Text & "|" & TxtLink.Text
                File.WriteAllText(_dfile, flist)

                ImgUpdate(TxtImg1,1)
                ImgUpdate(TxtImg2,2)
                ImgUpdate(TxtImg3,3)
                'Try
                '    File.Delete(pcdir & "mush1.jpg")
                '    File.Delete(pcdir & "mush2.jpg")
                '    File.Delete(pcdir & "mush3.jpg")
                'Catch ex As Exception

                'End Try
                'Try
                '    My.Computer.Network.DownloadFile(TxtImg1.Text, pcdir & "mush1.jpg")
                'Catch ex As Exception
                'End Try
                'Try
                '    My.Computer.Network.DownloadFile(TxtImg2.Text, pcdir & "mush2.jpg")
                'Catch ex As Exception
                'End Try
                'Try
                '    My.Computer.Network.DownloadFile(TxtImg3.Text, pcdir & "mush3.jpg")
                'Catch ex As Exception
                'End Try
                clearall()
            End If
        Else
            MsgBox("Please fill out all the fields.", MsgBoxStyle.Information, "Most Effective with All Info")
        End If
    End Sub

    Public Sub ImgUpdate(ctrl As Textbox, num As Integer)
        
        if Ctrl.Text.Contains("\") = false
            Dim pcdir As String = _h & TxtLatin.Text & "\"
            Dim locpic as String = pcdir & "mush" & num.ToString & ".jpg"
            try
                if file.Exists(locpic)
                    file.Delete(locpic)
                End If
            Catch ex As Exception

            End Try
            try
                 My.Computer.Network.DownloadFile(Ctrl.Text, locpic)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub DisPics(iPic As Integer, optional vis As Boolean = False)
      try
          Dim ctrl As Object = Controls.Find("Picturebox" & iPic.ToString, True).FirstOrDefault()
        Ctrl.visible = vis
          catch
          end try


    End Sub

    Private Sub Clearall()
        dim i = 1
        Do until i = 4
            DisPics(i)
            i = i + 1
        Loop
        LstShrooms.Items.Clear()
        LstShrooms.SelectedIndex = -1
        TxtCommon.Clear()
        TxtLatin.Clear()
        TxtEdibility.Clear()
        TxtSummary.Clear()
        TxtLink.Clear()
        TxtImg1.Clear()
        TxtImg2.Clear()
        TxtImg3.Clear()
    End Sub

    Private Sub AddNew_FormClose(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        FrmIntro.Opacity = 1
        FrmIntro.Show()
        FrmIntro.Focus()
        My.Computer.Audio.Play(_ad & "Music\beginning.wav", AudioPlayMode.Background)
    End Sub

    Private Sub AddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        PictureBox1.AllowDrop = True
        TopMost = False
        'Me.Opacity = 0.75
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        ListAll()
        TxtLatin.Select()
        TxtLatin.Focus()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        doupdate()
    End Sub
    Private Sub BtnAdd_Over(sender As Object, e As EventArgs) Handles BtnAdd.MouseEnter
        BtnAdd.ForeColor = Color.Black
        BtnAdd.BackColor = Color.DarkOrange
    End Sub
    Private Sub BtnAdd_Leave(sender As Object, e As EventArgs) Handles BtnAdd.MouseLeave
        BtnAdd.ForeColor = Color.DarkOrange
        BtnAdd.BackColor = Color.Black
    End Sub

    'Private Sub TxtImg1_DubClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImg1.DoubleClick
    '    TxtImg1.Text = Windows.Forms.Clipboard.GetText
    'End Sub

    'Private Sub TxtImg2_DubClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImg2.DoubleClick
    '    TxtImg2.Text = Windows.Forms.Clipboard.GetText
    'End Sub

    'Private Sub TxtImg3_DubClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImg3.DoubleClick
    '    TxtImg3.Text = Windows.Forms.Clipboard.GetText
    'End Sub

    'Private Sub TxtLatin_DubClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLatin.DoubleClick
    '    TxtLatin.Text = Windows.Forms.Clipboard.GetText
    'End Sub
    'Private Sub TxtCommon_DubClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCommon.DoubleClick
    '    TxtCommon.Text = Windows.Forms.Clipboard.GetText
    'End Sub
    'Private Sub TxtEdibility_DubClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEdibility.DoubleClick
    '    TxtEdibility.Text = Windows.Forms.Clipboard.GetText
    'End Sub
    'Private Sub TxtSummary_DubClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSummary.DoubleClick
    '    TxtSummary.Text = Windows.Forms.Clipboard.GetText
    'End Sub
    'Private Sub TxtLink_DubClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLink.DoubleClick
    '    TxtLink.Text = Windows.Forms.Clipboard.GetText
    'End Sub

#Region "Drag Drop"
    'Img1 Drop
    Private Shared Sub TxtImg1_Drop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        If e.Data.GetDataPresent("HTML Format") Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub myControl_DragDrop(e As DragEventArgs)
        Dim clipboardHtml = DirectCast(e.Data.GetData("HTML Format"), String)
        Dim htmlFragment As String = GetHtmlFragment(clipboardHtml)
        Dim imageSrc As String = ParseImageSrc(htmlFragment)
        Dim baseUrl As String = ParseBaseUrl(clipboardHtml)

        If imageSrc.ToUpper().IndexOf("HTTP://", StringComparison.Ordinal) = 0 Then
            TxtImg1.Text = imageSrc
        Else
            MessageBox.Show(baseURL & imageSrc.Substring(1))
        End If
    End Sub

    Private Shared Function GetHtmlFragment(clipboardHtml As String) As String
        Dim fragStartPos As Integer = Integer.Parse(Regex.Match(clipboardHtml, "^StartFragment:(\d+)", RegexOptions.Multiline).Groups(1).Value)
        Dim fragEndPos As Integer = Integer.Parse(Regex.Match(clipboardHtml, "^EndFragment:(\d+)", RegexOptions.Multiline).Groups(1).Value)
        Return clipboardHtml.Substring(fragStartPos, fragEndPos - fragStartPos)
    End Function

    Private Shared Function ParseImageSrc(html As String) As String
        Return Regex.Match(html, "<img.*?src=[""'](.*?)[""'].*>", RegexOptions.IgnoreCase Or RegexOptions.Singleline).Groups(1).Value
    End Function

    Private Shared Function ParseBaseUrl(html As String) As String
        '.*?/, 
        'Return Regex.Match(html, http:=RegexOptions.IgnoreCase).Groups(0).Value
    End Function

    Private Shared Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) Then

            Dim strFile = CType(e.Data.GetData(DataFormats.FileDrop), String())

            Dim fi As New FileInfo(strFile(0))

            If fi.Extension = ".gif" Or fi.Extension = ".bmp" Or
            fi.Extension = ".jpg" Or fi.Extension = ".jpeg" Then

                e.Effect = DragDropEffects.Copy

            End If

        End If

    End Sub
#End Region
#Region "DoubleClick / TextChanged"
    Private Sub TxtImg1_DoubleClick(sender As Object, e As EventArgs) Handles TxtImg1.DoubleClick
        If TxtImg1.Text = "" Then
            TxtImg1.Text = Clipboard.GetText
        End If
    End Sub
    Private Sub TxtImg2_DoubleClick(sender As Object, e As EventArgs) Handles TxtImg2.DoubleClick
        If TxtImg2.Text = "" Then
            TxtImg2.Text = Clipboard.GetText
        End If
    End Sub
    Private Sub TxtImg3_DoubleClick(sender As Object, e As EventArgs) Handles TxtImg3.DoubleClick
        If TxtImg3.Text = "" Then
            TxtImg3.Text = Clipboard.GetText
        End If
    End Sub
    Private Sub TxtCommon_DoubleClick(sender As Object, e As EventArgs) Handles TxtCommon.DoubleClick
        If TxtCommon.Text = "" Then
            TxtCommon.Text = Clipboard.GetText
        End If
    End Sub
    Private Sub TxtLatin_DoubleClick(sender As Object, e As EventArgs) Handles TxtLatin.DoubleClick
        If TxtLatin.Text = "" Then
            TxtLatin.Text = Clipboard.GetText
        End If
    End Sub
    Private Sub TxtEdibility_DoubleClick(sender As Object, e As EventArgs) Handles TxtEdibility.DoubleClick
        If TxtEdibility.Text = "" Then
            TxtEdibility.Text = Clipboard.GetText
        End If
    End Sub
    Private Sub TxtSummary_DoubleClick(sender As Object, e As EventArgs) Handles TxtSummary.DoubleClick
        If TxtSummary.Text = "" Then
            TxtSummary.Text = Clipboard.GetText
        End If
    End Sub
    Private Sub TxtLink_DoubleClick(sender As Object, e As EventArgs) Handles TxtLink.DoubleClick
        If TxtLink.Text = "" Then
            TxtLink.Text = Clipboard.GetText
        End If
    End Sub
    Private Sub TxtSummary_TextChanged(sender As Object, e As EventArgs) Handles TxtSummary.TextChanged
        Const charactersDisallowed = "|"
        Dim theText As String = TxtSummary.Text
        Dim letter As String
        'Dim selectionIndex As Integer = TxtSummary.SelectionStart

        For x = 0 To TxtSummary.Text.Length - 1
            Letter = TxtSummary.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
            End If
        Next
        TxtSummary.Text = theText
    End Sub
    Private Sub TxtEdibility_TextChanged(sender As Object, e As EventArgs) Handles TxtEdibility.TextChanged
        Const charactersDisallowed = "|"
        Dim theText As String = TxtEdibility.Text
        Dim letter As String
        'Dim selectionIndex As Integer = TxtEdibility.SelectionStart

        For x = 0 To TxtEdibility.Text.Length - 1
            Letter = TxtEdibility.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
            End If
        Next
        TxtEdibility.Text = theText
    End Sub
    Private Sub TxtCommon_TextChanged(sender As Object, e As EventArgs) Handles TxtCommon.TextChanged
        Const charactersDisallowed = "|"
        Dim theText As String = TxtCommon.Text
        Dim letter As String
        Dim change As Integer

        For x = 0 To TxtCommon.Text.Length - 1
            Letter = TxtCommon.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TxtCommon.Text = theText
    End Sub
    Private Sub TxtLatin_TextChanged(sender As Object, e As EventArgs) Handles TxtLatin.TextChanged
        Const charactersDisallowed = "|"
        Dim theText As String = TxtLatin.Text
        Dim letter As String
        'Dim selectionIndex As Integer = TxtLatin.SelectionStart
        Dim change As Integer

        For x = 0 To TxtLatin.Text.Length - 1
            Letter = TxtLatin.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TxtLatin.Text = theText
    End Sub
    Private Sub TxtLink_TextChanged(sender As Object, e As EventArgs) Handles TxtLink.TextChanged
        Const charactersDisallowed = "|"
        Dim theText As String = TxtLink.Text
        Dim letter As String
        'Dim selectionIndex As Integer = TxtLink.SelectionStart
        Dim change As Integer

        For x = 0 To TxtLink.Text.Length - 1
            Letter = TxtLink.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TxtLink.Text = theText
    End Sub
    Private Sub TxtImg1_TextChanged(sender As Object, e As EventArgs) Handles TxtImg1.TextChanged
        Const charactersDisallowed = "|"
        Dim theText As String = TxtImg1.Text
        Dim letter As String
        'Dim selectionIndex As Integer = TxtImg1.SelectionStart
        Dim change As Integer

        For x = 0 To TxtImg1.Text.Length - 1
            Letter = TxtImg1.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TxtImg1.Text = theText
        If theText.Contains("\")
            PictureBox1.ImageLocation = theText
            PictureBox1.Visible = True
            else
             PictureBox1.Visible = False
        End If
    End Sub
    Private Sub TxtImg2_TextChanged(sender As Object, e As EventArgs) Handles TxtImg2.TextChanged
        Const charactersDisallowed = "|"
        Dim theText As String = TxtImg2.Text
        Dim letter As String
        Dim selectionIndex As Integer = TxtImg2.SelectionStart

        For x = 0 To TxtImg2.Text.Length - 1
            Letter = TxtImg2.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
            End If
        Next
        TxtImg2.Text = theText
        If theText.Contains("\")
            PictureBox2.ImageLocation = theText
            PictureBox2.Visible = True
        else
            PictureBox2.Visible = False
        End If
    End Sub
    Private Sub TxtImg3_TextChanged(sender As Object, e As EventArgs) Handles TxtImg3.TextChanged
        Const charactersDisallowed = "|"
        Dim theText As String = TxtImg3.Text
        Dim letter As String
        Dim change As Integer

        For x = 0 To TxtImg3.Text.Length - 1
            Letter = TxtImg3.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TxtImg3.Text = theText
        If theText.Contains("\")
            PictureBox3.ImageLocation = theText
            PictureBox3.Visible = True
        else
            PictureBox3.Visible = False
        End If
    End Sub

    Private Sub LstShrooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstShrooms.SelectedIndexChanged
        if LstShrooms.SelectedIndex <> -1
            if LstShrooms.SelectedItem.ToString.Trim <> _curMush.Trim
            ReturnShroomINFO(LstShrooms.SelectedItem.ToString.Trim,"all")
            end If
        End If
    End Sub
#End Region

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("notepad.exe", _dfile)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
       Pic(TxtIMg1,PictureBox1)
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Pic(TxtIMg2,PictureBox2)
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
       Pic(TxtIMg3,PictureBox3)
    End Sub

    Public Sub Pic(ctrl As Textbox, p as Picturebox)
         Process.Start("C:\Windows\explorer.exe", Chr(34) & ctrl.Text & Chr(34))
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        _curMush = ""
        ListAll()
    End Sub
End Class