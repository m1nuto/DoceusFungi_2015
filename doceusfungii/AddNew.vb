Imports System
Imports System.IO
Imports System.Collections
Imports System.IO.File
Imports System.Text.RegularExpressions
Imports System.Drawing


Public Class AddNew
    Dim h As String = AppDomain.CurrentDomain.BaseDirectory
    Dim dfile As String = h & "flist.txt"
    Dim flist As String = File.ReadAllText(dfile)
    Dim ad As String = AppDomain.CurrentDomain.BaseDirectory


    Public Sub doupdate()
        If TxtCommon.Text <> "" And TxtEdibility.Text <> "" And TxtSummary.Text <> "" And TxtLink.Text <> "" And TxtLatin.Text <> "" And TxtImg1.Text <> "" And TxtImg2.Text <> "" And TxtImg3.Text <> "" Then
            Dim flist As String = File.ReadAllText(dfile)
            Dim pcdir As String = h & TxtLatin.Text & "\"
            If flist.Contains(TxtLatin.Text) Then
                Dim result As Integer = MessageBox.Show("This mushroom added, overwrite?", "Overwrite", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    MessageBox.Show("Not entered at user request.", "Overwrite Canceled")
                ElseIf result = DialogResult.Yes Then
                    File.Delete(pcdir & "mush1.jpg")
                    File.Delete(pcdir & "mush2.jpg")
                    File.Delete(pcdir & "mush3.jpg")
                    Dim newresult As String
                    Dim t As Integer = 0
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
                    File.WriteAllText(dfile, newresult)
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
                File.WriteAllText(dfile, flist)
                Try
                    File.Delete(pcdir & "mush1.jpg")
                    File.Delete(pcdir & "mush2.jpg")
                    File.Delete(pcdir & "mush3.jpg")
                Catch ex As Exception

                End Try
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
            MsgBox("Please fill out all the fields.", MsgBoxStyle.Information, "Most Effective with All Info")
        End If
    End Sub

    Private Sub clearall()
        TxtCommon.Clear()
        TxtLatin.Clear()
        TxtEdibility.Clear()
        TxtSummary.Clear()
        TxtLink.Clear()
        TxtImg1.Clear()
        TxtImg2.Clear()
        TxtImg3.Clear()
    End Sub

    Private Sub AddNew_FormClose(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        FrmIntro.Opacity = 1
        FrmIntro.Show()
        FrmIntro.Focus()
        My.Computer.Audio.Play(ad & "Music\beginning.wav", AudioPlayMode.Background)
    End Sub

    Private Sub AddNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        PictureBox1.AllowDrop = True
        Me.TopMost = True
        'Me.Opacity = 0.75
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        doupdate()
    End Sub
    Private Sub BtnAdd_Over(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.MouseEnter
        BtnAdd.ForeColor = Color.Black
        BtnAdd.BackColor = Color.DarkOrange
    End Sub
    Private Sub BtnAdd_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.MouseLeave
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
    Private Sub TxtImg1_Drop(ByVal sender As Object, ByVal e As DragEventArgs) Handles Me.DragDrop
        If e.Data.GetDataPresent("HTML Format") Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub myControl_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
        Dim clipboardHtml As String = DirectCast(e.Data.GetData("HTML Format"), String)
        Dim htmlFragment As String = getHtmlFragment(clipboardHtml)
        Dim imageSrc As String = parseImageSrc(htmlFragment)
        Dim baseURL As String = parseBaseURL(clipboardHtml)

        If imageSrc.ToUpper().IndexOf("HTTP://") = 0 Then
            TxtImg1.Text = imageSrc
        Else
            MessageBox.Show(baseURL & imageSrc.Substring(1))
        End If
    End Sub

    Private Function getHtmlFragment(ByVal clipboardHtml As String) As String
        Dim fragStartPos As Integer = Integer.Parse(Regex.Match(clipboardHtml, "^StartFragment:(\d+)", RegexOptions.Multiline).Groups(1).Value)
        Dim fragEndPos As Integer = Integer.Parse(Regex.Match(clipboardHtml, "^EndFragment:(\d+)", RegexOptions.Multiline).Groups(1).Value)
        Return clipboardHtml.Substring(fragStartPos, fragEndPos - fragStartPos)
    End Function

    Private Function parseImageSrc(ByVal html As String) As String
        Return Regex.Match(html, "<img.*?src=[""'](.*?)[""'].*>", RegexOptions.IgnoreCase Or RegexOptions.Singleline).Groups(1).Value
    End Function

    Private Function parseBaseURL(ByVal html As String) As String
        '.*?/, 
        'Return Regex.Match(html, http:=RegexOptions.IgnoreCase).Groups(0).Value
    End Function
    Private Sub PictureBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox1.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) Then

            Dim strFile() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

            Dim fi As New System.IO.FileInfo(strFile(0))

            If fi.Extension = ".gif" Or fi.Extension = ".bmp" Or
            fi.Extension = ".jpg" Or fi.Extension = ".jpeg" Then

                e.Effect = DragDropEffects.Copy

            End If

        End If

    End Sub
#End Region
#Region "DoubleClick / TextChanged"
    Private Sub TxtImg1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImg1.DoubleClick
        If TxtImg1.Text = "" Then
            TxtImg1.Text = Windows.Forms.Clipboard.GetText
        End If
    End Sub
    Private Sub TxtImg2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImg2.DoubleClick
        If TxtImg2.Text = "" Then
            TxtImg2.Text = Windows.Forms.Clipboard.GetText
        End If
    End Sub
    Private Sub TxtImg3_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImg3.DoubleClick
        If TxtImg3.Text = "" Then
            TxtImg3.Text = Windows.Forms.Clipboard.GetText
        End If
    End Sub
    Private Sub TxtCommon_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCommon.DoubleClick
        If TxtCommon.Text = "" Then
            TxtCommon.Text = Windows.Forms.Clipboard.GetText
        End If
    End Sub
    Private Sub TxtLatin_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLatin.DoubleClick
        If TxtLatin.Text = "" Then
            TxtLatin.Text = Windows.Forms.Clipboard.GetText
        End If
    End Sub
    Private Sub TxtEdibility_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEdibility.DoubleClick
        If TxtEdibility.Text = "" Then
            TxtEdibility.Text = Windows.Forms.Clipboard.GetText
        End If
    End Sub
    Private Sub TxtSummary_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSummary.DoubleClick
        If TxtSummary.Text = "" Then
            TxtSummary.Text = Windows.Forms.Clipboard.GetText
        End If
    End Sub
    Private Sub TxtLink_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLink.DoubleClick
        If TxtLink.Text = "" Then
            TxtLink.Text = Windows.Forms.Clipboard.GetText
        End If
    End Sub
    Private Sub TxtSummary_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSummary.TextChanged
        Dim charactersDisallowed As String = "|"
        Dim theText As String = TxtSummary.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TxtSummary.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TxtSummary.Text.Length - 1
            Letter = TxtSummary.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TxtSummary.Text = theText
    End Sub
    Private Sub TxtEdibility_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEdibility.TextChanged
        Dim charactersDisallowed As String = "|"
        Dim theText As String = TxtEdibility.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TxtEdibility.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TxtEdibility.Text.Length - 1
            Letter = TxtEdibility.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TxtEdibility.Text = theText
    End Sub
    Private Sub TxtCommon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCommon.TextChanged
        Dim charactersDisallowed As String = "|"
        Dim theText As String = TxtCommon.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TxtCommon.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TxtCommon.Text.Length - 1
            Letter = TxtCommon.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TxtCommon.Text = theText
    End Sub
    Private Sub TxtLatin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLatin.TextChanged
        Dim charactersDisallowed As String = "|"
        Dim theText As String = TxtLatin.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TxtLatin.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TxtLatin.Text.Length - 1
            Letter = TxtLatin.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TxtLatin.Text = theText
    End Sub
    Private Sub TxtLink_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLink.TextChanged
        Dim charactersDisallowed As String = "|"
        Dim theText As String = TxtLink.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TxtLink.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TxtLink.Text.Length - 1
            Letter = TxtLink.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TxtLink.Text = theText
    End Sub
    Private Sub TxtImg1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImg1.TextChanged
        Dim charactersDisallowed As String = "|"
        Dim theText As String = TxtImg1.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TxtImg1.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TxtImg1.Text.Length - 1
            Letter = TxtImg1.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TxtImg1.Text = theText
    End Sub
    Private Sub TxtImg2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImg2.TextChanged
        Dim charactersDisallowed As String = "|"
        Dim theText As String = TxtImg2.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TxtImg2.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TxtImg2.Text.Length - 1
            Letter = TxtImg2.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TxtImg2.Text = theText
    End Sub
    Private Sub TxtImg3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImg3.TextChanged
        Dim charactersDisallowed As String = "|"
        Dim theText As String = TxtImg3.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TxtImg3.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TxtImg3.Text.Length - 1
            Letter = TxtImg3.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TxtImg3.Text = theText
    End Sub
#End Region

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("notepad.exe", dfile)
    End Sub

End Class