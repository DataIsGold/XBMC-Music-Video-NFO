'2014-10-24
'This is a modification of the XBMC Music Video .NFO maker
'original program writtend by jacksonliam
' http://forum.xbmc.org/showthread.php?tid=103954
' Modifications:
' Album Name
'   * Album name from Directory
' Faster thumbnails
'   * The code to generate the thumbnail is more efficient
'   * I'm also using a more recent version of ffmpeg so any optimizations done by the ffmpeg group carry over of course
'   * I fill as many fields of the XBMC Music Video NFO file as possible
'   * I get duration from the video file using Windows Media Player
' File Copying:
'   * I've disabled File Copying in the GUI
'Notes:
' In Visual Studio 2013 there is a warning for WMPLib
' However, duration is still extracted. 


Imports System.IO
Imports System.Threading
Imports System.ComponentModel
Imports WMPLib
Imports System.Text.RegularExpressions


Public Class Form1
    Dim extentionarray As New ArrayList
    Dim fileCount As Integer = 0
    Dim mainDir As String

    'Private WithEvents backgroundWorker1 As System.ComponentModel.BackgroundWorker

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click


        'disable all the buttons
        For Each ctl As Control In Controls
            ctl.Enabled = False
        Next

        'set the filename to something blank if no copying
        If rdbFileNone.Checked = True Then
            txtFileDestination.Text = "*"
        End If
        lstErrors.Items.Clear()

        If rdbFileAllRoot.Checked = True Or rdbFileArtistAndTitle.Checked = True Or rdbFileArtistTitle.Checked = True Then
            If Directory.Exists(txtFileDestination.Text) = False Then
                Try
                    Directory.CreateDirectory(txtFileDestination.Text)
                Catch ex As Exception
                    MessageBox.Show("Couldn't create route directory")
                    'lstErrors.Items.Add(ex.ToString)
                    ErrorListAdd(ex.ToString)
                End Try
            Else
                If MsgBox("Target Directory Exists, Copy Anyway?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    rdbFileNone.Checked = True
                    rdbFileArtistTitle.Checked = False
                    rdbFileArtistAndTitle.Checked = False
                    rdbFileAllRoot.Checked = False
                End If
            End If
        End If

        ProgressBar1.Value = 0
        fileCount = 0


        For Each Item In lstExt.Items
            extentionarray.Add(Item)
        Next
        If txtMainDir.Text = "" Then
            MessageBox.Show("Please set directory")
        Else
            'try setting the maindir count
            Try
                ProgressBar1.Maximum = Directory.EnumerateDirectories(txtMainDir.Text).Count
            Catch ex As Exception
                'do nothing
            End Try

            If BackgroundWorker1.IsBusy <> True Then
                'Start the asynchronous operation.
                mainDir = txtMainDir.Text
                BackgroundWorker1.RunWorkerAsync()
            Else
                MsgBox("Could not start Process!", MsgBoxStyle.OkOnly, "Error starting!")
            End If
        End If
      

    End Sub

    'threadded stuff
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub backgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles backgroundWorker1.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        If Directory.Exists(mainDir) Then
            For Each subdir As String In Directory.GetDirectories(mainDir)
                If (subdir IsNot Nothing) And (subdir.Contains(txtFileDestination.Text) = False) Then
                    searchForVideo(subdir)
                    If chkRecursive.Checked = True Then
                        searchSubDirectorys(subdir)
                    End If
                End If
                worker.ReportProgress(1)
            Next
            searchForVideo(mainDir)
            worker.ReportProgress(1)
        End If

    End Sub

    Private Sub backgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As ProgressChangedEventArgs) Handles backgroundWorker1.ProgressChanged
        ProgressBar1.Increment(e.ProgressPercentage)
    End Sub

    Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles backgroundWorker1.RunWorkerCompleted
        Dim tStart = System.DateTime.Now()
        Dim tEnd = System.DateTime.Now()
        Me.Focus()

        'enable all the buttons
        For Each ctl As Control In Controls
            ctl.Enabled = True
        Next
        'check the enabled thing on the groupbox
        If rdbFileNone.Checked = True Then
            grpFileCopyOpts.Enabled = False
        Else
            grpFileCopyOpts.Enabled = True
        End If

        lblCreated.Text = fileCount.ToString

        If fileCount = 0 Then
            tEnd = System.DateTime.Now()
            MessageBox.Show("No files created, check directory and settings")
        Else
            tEnd = System.DateTime.Now()
            MessageBox.Show("Done!")
        End If



        MessageBox.Show(tEnd.Subtract(tStart).ToString())

    End Sub


    Private Sub searchSubDirectorys(ByVal mainDir As String)
        If Directory.Exists(mainDir) Then
            For Each subdir As String In Directory.GetDirectories(mainDir)
                If (subdir IsNot Nothing) And (subdir.Contains(txtFileDestination.Text) = False) Then
                    searchForVideo(subdir)
                    If chkRecursive.Checked = True Then
                        searchSubDirectorys(subdir)
                    End If
                End If
            Next
        End If
    End Sub

    '2013-08-06 
    'Added a way to grab media duration
    'This relies on Windows Media Player
    'Would be nice to use VLC libvlc to do this.

    Public Function MediaDuration(strFile As String)
        Dim strDuration As String = 0
        Try
            Dim player As WindowsMediaPlayer = New WindowsMediaPlayer


            Dim clip = player.newMedia(strFile)
            strDuration = TimeSpan.FromSeconds(clip.duration).ToString()

        Catch ex As Exception
            'No Windows MEdia Player? No problem. Just fail gracefully.
        End Try

       

            Return strDuration


    End Function

    Private Sub searchForVideo(ByVal dir As String)
        Dim musicTitle As String = ""
        Dim musicArtist As String = ""
        Dim filename As String
        Dim fileext As String
        Dim dashCheck As String


        For Each filepath As String In Directory.GetFiles(dir)
            Try
                fileext = filepath.Substring(filepath.LastIndexOf(".") + 1)
                If extentionarray.Contains(fileext) Then
                    filename = filepath

                    If chkUnderscore.Checked = True Then
                        filename = filename.Replace("_", " ")
                    End If

                    filename = filename.Substring(filename.LastIndexOf("\") + 1)

                    If chkDots.Checked = True Then
                        If (Len(filename.Substring(0, filename.LastIndexOf("."))) - Len((filename.Substring(0, filename.LastIndexOf("."))).Replace(".", ""))) >= CInt(txtDots.Text) Then
                            filename = filename.Substring(0, filename.LastIndexOf(".")).Replace(".", " ") + filename.Substring(filename.LastIndexOf("."))
                        End If
                    End If

                    If filename.Contains("-") = True Then
                        If chkTrackNo.Checked = True Then
                            If IsNumeric(filename.Substring(0, (filename.Replace(" ", "")).IndexOf("-"))) = True Then
                                filename = filename.Substring(filename.IndexOf("-") + 1)
                            End If

                            If chkTrackNoExtra.Checked = True Then
                                If IsNumeric((filename.Replace(" ", "")).Substring(0, 3)) = True Then
                                    filename = filename.Substring(3)
                                End If
                            End If
                            If filename.Substring(0, 1) = "." Then
                                filename = filename.Substring(1)
                            End If
                            If filename.Substring(0, 1) = " " Then
                                filename = filename.Substring(1)
                            End If
                        End If

                        If chkHyphen.Checked = True Then
                            If chkFallbackArtist.Checked = True Then
                                If filename.Contains(" - ") Then
                                    dashCheck = " - "
                                Else
                                    dashCheck = "-"
                                End If
                            Else
                                dashCheck = " - "
                            End If
                        Else
                            dashCheck = "-"
                        End If

                        musicArtist = filename.Substring(0, filename.IndexOf(dashCheck))

                        If musicArtist.Substring(musicArtist.Length - 1) = " " Then
                            musicArtist = musicArtist.Substring(0, musicArtist.Length - 1)
                        End If
                        If musicArtist.Substring(0, 1) = " " Then
                            musicArtist = musicArtist.Substring(1)
                        End If

                        musicTitle = filename.Substring(filename.IndexOf(dashCheck) + 1)

                        musicTitle = musicTitle.Substring(0, musicTitle.LastIndexOf("."))
                        If dashCheck = " - " Then
                            musicTitle = musicTitle.Substring(1)
                        End If
                        If musicTitle.Substring(0, 1) = " " Then
                            musicTitle = musicTitle.Substring(1)
                        End If
                        If musicTitle.Contains("-") Then
                            musicTitle = musicTitle.Substring(0, musicTitle.IndexOf("-"))
                        End If
                        If musicTitle.Substring(musicTitle.Length - 1) = " " Then
                            musicTitle = musicTitle.Substring(0, musicTitle.Length - 1)
                        End If
                        If chkCaseArtists.Checked = True Then
                            musicArtist = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(musicArtist)
                        End If
                        If chkCaseTitles.Checked = True Then
                            musicTitle = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(musicTitle)
                        End If
                    Else
                        If chkDashless.Checked = True Then
                            musicTitle = filename.Substring(0, filename.LastIndexOf("."))
                            musicArtist = "Unknown"
                            ' lstErrors.Items.Add("Added " + musicArtist + " - " + musicTitle + " As couldn't find An Artist")
                            ErrorListAdd("Added " + musicArtist + " - " + musicTitle + " As couldn't find An Artist")
                        End If
                    End If

                    Dim strTmp = musicArtist.Split("@")
                    musicArtist = strTmp(strTmp.GetUpperBound(0))

                    createNFO(filepath, musicTitle, musicArtist)
                Else
                    If lstErrors.Items.Contains("Ignored Filetype " + fileext) = False Then
                        If chkFileTypes.Checked = True Then
                            ' lstErrors.Items.Add("Ignored Filetype " + fileext)
                            ErrorListAdd("Ignored Filetype " + fileext)
                        End If
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
                ErrorListAdd(filepath)

            End Try
        Next
    End Sub

    Private Sub ErrorListAdd(msg As String)

        Dim action As Action = Function() lstErrors.Items.Add(msg)
        Me.Invoke(action)
    End Sub

    

    Private Sub createNFO(ByVal filename As String, ByVal songTitle As String, ByVal songArtist As String)
        ' Dim fileobj, MyFile
        Dim shouldCreate As Boolean = True

        If rdbFileAllRoot.Checked = True Or rdbFileArtistAndTitle.Checked = True Or rdbFileArtistTitle.Checked = True Then
            filename = copy_new_files(filename, songTitle, songArtist)
        End If

        If File.Exists(filename.Substring(0, filename.LastIndexOf(".")) + ".nfo") Then
            If chkNFOdelete.Checked = True Then
                File.Delete(filename.Substring(0, filename.LastIndexOf(".")) + ".nfo")
            ElseIf chkNFOrename.Checked = True Then
                File.Copy(filename.Substring(0, filename.LastIndexOf(".")) + ".nfo", filename.Substring(0, filename.LastIndexOf(".")) + " - " + Format(Now, "yyyymmddhhmmss") + " backup.nfo", False)
                File.Delete(filename.Substring(0, filename.LastIndexOf(".")) + ".nfo")
            ElseIf chkNFOskip.Checked = True Then
                shouldCreate = False
            End If
        End If

        If shouldCreate = True Then
            If chkDebug.Checked = True Then
                'lstErrors.Items.Add(songArtist + " - " + songTitle)
                ErrorListAdd(songArtist + " - " + songTitle)
            End If


            Dim appendMode As Boolean = False ' This overwrites the entire file.

            '2013-08-06
            Dim strDuration As String

            strDuration = MediaDuration(filename)

            If strDuration.StartsWith("00:") Then
                strDuration = strDuration.Substring(3)
            End If



            'is it faster to create the string in memory then write once to disk?

            Dim strXML As StringWriter = New StringWriter()


            ' sw.WriteLine("<musicvideo>")
            'sw.WriteLine(vbTab + "<title>" + songTitle + "</title>")
            'sw.WriteLine(vbTab + "<artist>" + songArtist + "</artist>")

            strXML.WriteLine("<musicvideo>")

            '     If (songTitle.Contains("- YouTube ")) Then
            ' Dim strTMp = songTitle.Split("- YouTube")
            'songTitle = strTMp(0) 'The song will be in the first portion.
            'End If

            If (songTitle.Contains("(Album ")) Then
                Dim strTMp = songTitle.Split("(Album")
                songTitle = strTMp(0) 'The song will be in the first portion.

            End If


            strXML.WriteLine(vbTab + "<title>" + songTitle.Trim() + "</title>")
            strXML.WriteLine(vbTab + "<artist>" + songArtist.Trim() + "</artist>")

            Dim strYear As Integer = 0
            If chkArtistAlbum.Checked = True Then

                Dim strFolderNames() As String
                strFolderNames = filename.Split("\")
                'Get the information from the Array OneLevel up from the last.
                'The last being the File Name, OneUp being the DIrectory it is in.
                Dim strName = strFolderNames(strFolderNames.GetUpperBound(0) - 1)

                'if there is a year
                Dim strNameYear() = strName.Split("(")

                strName = strNameYear(0).Trim() 'If there isn't a year it will be the same

                'IF there is a Year then the Array will have an index higher than Zero

                If strNameYear.GetUpperBound(0) > 0 Then
                    Try
                        strYear = Convert.ToInt32((strNameYear(strNameYear.GetUpperBound(0))).Replace(")", ""))
                    Catch ex As Exception
                        'The Directory probably contains (<content>) which is not the year: not an integer
                        'Die silently and move on.
                        ErrorListAdd(strName + " :" + ex.ToString())
                    End Try

                End If

                ' MyFile.WriteLine("<album>" + songArtist + "</album>")
                ' sw.WriteLine(vbTab + "<album>" + songArtist + "</album>")
                strXML.WriteLine(vbTab + "<album>" + strName.Trim() + "</album>")
            End If

            If chkGenre.Checked = True Then
                ' MyFile.WriteLine("<genre>" + txtGenre.Text + "</genre>")
                strXML.WriteLine(vbTab + "<genre>" + txtGenre.Text + "</genre>")
            End If

            'sw.WriteLine(vbTab + "<runtime>" + strDuration + "</runtime>")
            'sw.WriteLine(vbTab + "<plot></plot>")
            'sw.WriteLine(vbTab + "<year></year>")
            'sw.WriteLine("</musicvideo>")


            strXML.WriteLine(vbTab + "<runtime>" + strDuration + "</runtime>")
            strXML.WriteLine(vbTab + "<plot></plot>")
            If strYear > 0 Then
                strXML.WriteLine(vbTab + "<year>" + strYear.ToString() + "</year>")
            Else
                strXML.WriteLine(vbTab + "<year></year>")
            End If

            'experimental 
            Dim pattern = "\[(.*?)\]"
            Dim matches = Regex.Matches(filename, pattern)
            'For Each ctl As Control In Controls
            For Each m As Match In matches
                strXML.WriteLine(vbTab + "<resolution>" + m.Groups(1).ToString() + "</resolution>")
            Next



            'var pattern = @"\[(.*?)\]";
            'var query = "H1-receptor antagonist [HSA:3269] [PATH:hsa04080(3269)]";
            'var matches = Regex.Matches(query, pattern);




            strXML.WriteLine("</musicvideo>")


            'Dim strNewFileName As String
            'strNewFileName = songArtist.Trim() + "-" + songTitle.Trim() + filename.Substring(filename.LastIndexOf("."))
            ''            File.Move(filename, strNewFileName)

            'If filename = strNewFileName Then
            '    'don't do anything
            'Else
            '    If File.Exists(strNewFileName) Then
            '        'don't do anything
            '    Else
            '        My.Computer.FileSystem.RenameFile(filename, strNewFileName)
            '    End If

            'End If



            '2013-08-06
            'open the File for writing in UTF-8 mode
            'This will prevent errors if you have Foreign name artists/tracks (
            'One IO operation. Less writes to disk the better.

            Dim sw As New StreamWriter(filename.Substring(0, filename.LastIndexOf(".")) + ".nfo", appendMode, System.Text.Encoding.UTF8)
            sw.WriteLine(strXML.ToString())
            sw.Close()
            strXML.Close()

            'Garbage Collection
            sw.Dispose()
            strXML.Dispose()

            

            'MyFile.WriteLine("</musicvideo>")
            'MyFile.Close()

            fileCount = fileCount + 1
        Else
            If chkOutputSkipped.Checked = True Then
                'lstErrors.Items.Add("Skipped existing NFO " + songArtist + " - " + songTitle)
                ErrorListAdd("Skipped existing NFO " + songArtist + " - " + songTitle)
            End If
        End If

        'generate thumbnail if option checked
        If chkGetThumbnail.Checked = True Then
            'if overwirte is disabled, generate thumbnail if the file doesn't exist
            If chkThumnailDelete.Checked = False Then
                'no longer using tbn using .jpg
                If File.Exists(filename.Substring(0, filename.LastIndexOf(".")) + ".jpg") = False Then
                    generate_thumbnail(filename)
                End If
            Else
                'if overwrite is ticked, make thumnail anyway!
                generate_thumbnail(filename)
            End If
        End If

    End Sub

    Private Sub generate_thumbnail(ByVal filename As String)
        'Create image with ffmpeg
        ' Shell("ffmpeg.exe " + "-y -itsoffset -" + numVideoDur.Value.ToString + "  -i " + Chr(34) + filename + Chr(34) + " -vcodec mjpeg -vframes 1 -an -f rawvideo " + Chr(34) + filename.Substring(0, filename.LastIndexOf(".")) + ".tbn" + Chr(34), AppWinStyle.Hide, True, 60000)


        '2013-08-06 Faster Frame Extraction: The above command seems take take about 1-3 seconds. The one below appears to be very close to Zero in creating thumbnails.
        ' i5-2400 @ 3.10GHz
        '8 GB RAM  Windows 7pro x64Bit
        'no more TBN thumbnail extension, using JPG instead
        Shell("ffmpeg.exe " + "-y -ss " + numVideoDur.Value.ToString + "  -i " + Chr(34) + filename + Chr(34) + " -t 00:00:00.01 -f image2 " + Chr(34) + filename.Substring(0, filename.LastIndexOf(".")) + ".jpg" + Chr(34), AppWinStyle.Hide, True, 60000)

        'Dim myProcess As New Process
        'Dim myProcessStartInfo As New ProcessStartInfo
        'myProcessStartInfo.FileName = "ffmpeg"
        ''myProcessStartInfo.Arguments = "-i " + Chr(34) + filename + Chr(34) + " -f mjpeg -t 0.001 -ss " + numVideoDur.Value.ToString + " -y " + Chr(34) + filename.Substring(0, filename.LastIndexOf(".")) + ".tbn" + Chr(34)
        'myProcessStartInfo.Arguments = "-y -itsoffset -" + numVideoDur.Value.ToString + "  -i " + Chr(34) + filename + Chr(34) + " -vcodec mjpeg -vframes 1 -an -f rawvideo " + Chr(34) + filename.Substring(0, filename.LastIndexOf(".")) + ".tbn" + Chr(34)
        'myProcessStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        'myProcessStartInfo.RedirectStandardOutput = True
        'myProcessStartInfo.UseShellExecute = False
        'myProcess.StartInfo = myProcessStartInfo
        'myProcess.Start()
        'Dim myStreamReader As StreamReader = myProcess.StandardOutput
        '' Read the standard output of the spawned process.
        'Dim myString As String = myStreamReader.ReadToEnd()
        'myProcess.Close()

    End Sub

    Private Function copy_new_files(ByVal filename As String, ByVal songTitle As String, ByVal songArtist As String) As String
        'main folder created at start

        Dim filepath As String = filename
        'dir does not have \ at end
        Dim filedir As String = filename.Substring(0, filename.LastIndexOf("\"))
        'name(doesn) 't include \ or .
        Dim filejustname As String = filename.Substring(filename.LastIndexOf("\") + 1)
        'fileext in this string includes leading dot
        Dim fileextention As String = filename.Substring(filename.LastIndexOf("."))
        filejustname = filejustname.Substring(0, filejustname.LastIndexOf("."))
        'this name doesn't include an extention or dor
        Dim filefinalname As String = ""

        'check for \ that could error
        If txtFileDestination.Text.Substring(txtFileDestination.Text.Length - 1) = "\" Then
            txtFileDestination.Text = txtFileDestination.Text.Substring(1)
        End If

        If rdbFileAllRoot.Checked = True Then
            'all songs in one folder
            filefinalname = txtFileDestination.Text + "\" + filejustname
        End If

        If rdbFileArtistAndTitle.Checked = True Then
            'own artist and song folder
            If Directory.Exists(txtFileDestination.Text + "\" + songArtist) = False Then
                Directory.CreateDirectory(txtFileDestination.Text + "\" + songArtist)
            End If
            Directory.CreateDirectory(txtFileDestination.Text + "\" + songArtist + "\" + songTitle)

            filefinalname = txtFileDestination.Text + "\" + songArtist + "\" + songTitle + "\" + filejustname
        End If

        If rdbFileArtistTitle.Checked = True Then
            Directory.CreateDirectory(txtFileDestination.Text + "\" + songArtist + " " + songTitle)
            filefinalname = txtFileDestination.Text + "\" + songArtist + " " + songTitle + "\" + filejustname
        End If

        Try
            If rdbMoveFileNfoOnly.Checked = True Then
                If File.Exists(filedir + "\" + filejustname + ".nfo") Then
                    File.Copy(filedir + "\" + filejustname + ".nfo", filefinalname + ".nfo", chkOverWrite.Checked)
                End If
            End If

            If rdbMoveFiletypes.Checked = True Then
                Dim templst As New ArrayList({".jpg", ".png", ".tbn", ".txt", ".xml", ".nfo"})
                For Each tempfile As String In Directory.GetFiles(filedir)
                    If templst.Contains(tempfile.Substring(tempfile.LastIndexOf(".")).ToLower) Then
                        File.Copy(tempfile, filefinalname.Substring(0, filefinalname.LastIndexOf("\")) + tempfile.Substring(tempfile.LastIndexOf("\")), chkOverWrite.Checked)
                    End If
                Next
            End If

            ' moves similarly named files
            If rdbMoveNonVideo.Checked = True Then
                For Each tempfile As String In Directory.GetFiles(filedir)
                    If tempfile.Substring(tempfile.LastIndexOf("\") + 1, (tempfile.LastIndexOf(".") - tempfile.LastIndexOf("\")) - 1) = filejustname Then
                        If extentionarray.Contains(tempfile.Substring(tempfile.LastIndexOf(".") + 1)) = False Then
                            File.Copy(tempfile, filefinalname + tempfile.Substring(tempfile.LastIndexOf(".")), chkOverWrite.Checked)
                        End If
                    End If
                Next
            End If

            If rdbMoveAllFiles.Checked = True Then
                For Each tempfile As String In Directory.GetFiles(filedir)
                    If extentionarray.Contains(tempfile.Substring(tempfile.LastIndexOf(".") + 1)) = False Then
                        File.Copy(tempfile, filefinalname.Substring(0, filefinalname.LastIndexOf("\")) + tempfile.Substring(tempfile.LastIndexOf("\")), chkOverWrite.Checked)
                    End If
                Next
            End If

            File.Copy(filename, filefinalname + fileextention, chkOverWrite.Checked)
        Catch ex As Exception
            lstErrors.Items.Add("Did not overwrite " + filefinalname + fileextention)
            ErrorListAdd("Did not overwrite " + filefinalname + fileextention)

        End Try

        filepath = filefinalname + fileextention
        Return filepath
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtAdd.Text <> "" Then
            If txtAdd.Text.Substring(0, 1) = "." Then
                txtAdd.Text = txtAdd.Text.Substring(1)
            End If
            lstExt.Items.Add(txtAdd.Text)
            txtAdd.Text = ""
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        lstExt.Items.Remove(lstExt.SelectedItem)
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath IsNot Nothing Then
            txtMainDir.Text = FolderBrowserDialog1.SelectedPath.ToString
            If (txtFileDestination.Text = "") And (txtMainDir.Text <> "") Then
                txtFileDestination.Text = txtMainDir.Text + "\Music Videos " + Format(Now, "yyyy-mm-dd hh-mm-ss")
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRecursive.MouseEnter
        ToolTip1.Show("Tick this if folder structures are deeper than 2 levels", Me, chkRecursive.Bottom, chkRecursive.Right, 2000)
    End Sub

    Private Sub btnFileDestination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileDestination.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath IsNot Nothing Then
            txtFileDestination.Text = FolderBrowserDialog1.SelectedPath.ToString
            If txtFileDestination.Text = txtMainDir.Text Then
                MessageBox.Show("Outputting to input directory not recommended!")
            End If
            If Directory.Exists(txtFileDestination.Text) Then
                If MsgBox("Directory Exists, Use Anyway?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                    txtFileDestination.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub rdbFileNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbFileNone.CheckedChanged
        If rdbFileNone.Checked = True Then
            grpFileCopyOpts.Enabled = False
        Else
            grpFileCopyOpts.Enabled = True
        End If
    End Sub
    Private Function GotData(sendingProcess As Object, outLine As DataReceivedEventArgs) As String
        If Not String.IsNullOrEmpty(outLine.Data) Then
            Return (outLine.Data)
        Else
            Return vbNullString
        End If
    End Function


     
    Public FFMPEGisWorking As Boolean = False
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGetThumbnail.CheckedChanged
        If chkGetThumbnail.Checked = True Then
            Try
                MessageBox.Show("Checking FFMpeg Works, Click OK and Wait for Success/Fail Message")
                Dim myProcess As New Process()
                Dim myProcessStartInfo As New ProcessStartInfo("ffmpeg.exe")
                ' myProcessStartInfo.Arguments = "- version"
                'myProcessStartInfo.WindowStyle = ProcessWindowStyle.Hidden
                myProcessStartInfo.UseShellExecute = False
                myProcessStartInfo.RedirectStandardOutput = True
                myProcessStartInfo.RedirectStandardError = True

                myProcess.StartInfo = myProcessStartInfo
                myProcess.EnableRaisingEvents = True
                ' AddHandler myProcess.OutputDataReceived, AddressOf GotData
                myProcess.Start()
                'myProcess.BeginOutputReadLine()

                'Dim myStreamReader As StreamReader = myProcess.StandardOutput
                'Read the standard output of the spawned process.
                'Dim myString As String = myStreamReader.ReadToEnd()
                ' myProcess.Close()

                Dim sOutput As String
                ' Using oStreamReader As System.IO.StreamReader = myProcess.StandardOutput
                'sOutput = oStreamReader.ReadToEnd()
                'End Using

                '2013-08-07 : Capture the Output directly to the String
                ' If StandardOutput doesn't give anything
                ' check the StandardError.  new version of ffmpeg returns error when called without input?

                sOutput = myProcess.StandardOutput.ReadToEnd
                If (sOutput.Length < 1) Then
                    sOutput = myProcess.StandardError.ReadToEnd
                End If

                '2013-08-06  Changed this part for x64 systems and to future proof FFMPEG check
                If sOutput.Contains("Hyper fast Audio and Video encoder") Then
                    MessageBox.Show("Done! FFMpeg is working." + vbNewLine + "FFMpeg takes 3-10 seconds per video")
                Else
                    MsgBox("FFmpeg Appears to not be working or the wrong version ERROR:FF1")
                    'chkGetThumbnail.Checked = False
                End If
            Catch ex As Exception
                MsgBox("FFmpeg Could not be found or is not working ERROR:FF2")
                MessageBox.Show(ex.ToString)

                ' chkGetThumbnail.Checked = False
            End Try
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Enabled = False Then
            If MsgBox("Really Exit and Stop Whatever is happening?", MsgBoxStyle.YesNo, "Really Exit?") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                If BackgroundWorker1.WorkerSupportsCancellation = True Then
                    'Cancel the asynchronous operation.
                    BackgroundWorker1.CancelAsync()
                Else
                    MsgBox("Could not cancel", vbOKOnly, "Error")
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MI As MediaInfo = New MediaInfo()
        Dim ToDisplay As String
        ToDisplay = MI.Inform()
        ToDisplay += MI.Get_(0, 0, "FileSize")
        MessageBox.Show(ToDisplay)


    End Sub
End Class
