<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtMainDir = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lstErrors = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkUnderscore = New System.Windows.Forms.CheckBox()
        Me.chkDots = New System.Windows.Forms.CheckBox()
        Me.txtDots = New System.Windows.Forms.TextBox()
        Me.chkTrackNo = New System.Windows.Forms.CheckBox()
        Me.chkDebug = New System.Windows.Forms.CheckBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.chkRecursive = New System.Windows.Forms.CheckBox()
        Me.lstExt = New System.Windows.Forms.ListBox()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.chkCaseArtists = New System.Windows.Forms.CheckBox()
        Me.chkCaseTitles = New System.Windows.Forms.CheckBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCreated = New System.Windows.Forms.Label()
        Me.chkTrackNoExtra = New System.Windows.Forms.CheckBox()
        Me.chkGenre = New System.Windows.Forms.CheckBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.chkFileTypes = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkDashless = New System.Windows.Forms.CheckBox()
        Me.chkFallbackArtist = New System.Windows.Forms.CheckBox()
        Me.chkHyphen = New System.Windows.Forms.CheckBox()
        Me.chkArtistAlbum = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkGetThumbnail = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkOutputSkipped = New System.Windows.Forms.CheckBox()
        Me.chkNFOskip = New System.Windows.Forms.RadioButton()
        Me.chkNFOdelete = New System.Windows.Forms.RadioButton()
        Me.chkNFOrename = New System.Windows.Forms.RadioButton()
        Me.grpFileCopying = New System.Windows.Forms.GroupBox()
        Me.chkOverWrite = New System.Windows.Forms.CheckBox()
        Me.rdbFileAllRoot = New System.Windows.Forms.RadioButton()
        Me.grpFileCopyOpts = New System.Windows.Forms.GroupBox()
        Me.rdbMoveNothing = New System.Windows.Forms.RadioButton()
        Me.rdbMoveFileNfoOnly = New System.Windows.Forms.RadioButton()
        Me.rdbMoveAllFiles = New System.Windows.Forms.RadioButton()
        Me.rdbMoveNonVideo = New System.Windows.Forms.RadioButton()
        Me.rdbMoveFiletypes = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnFileDestination = New System.Windows.Forms.Button()
        Me.txtFileDestination = New System.Windows.Forms.TextBox()
        Me.rdbFileArtistAndTitle = New System.Windows.Forms.RadioButton()
        Me.rdbFileArtistTitle = New System.Windows.Forms.RadioButton()
        Me.rdbFileNone = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.numVideoDur = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkThumnailDelete = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpFileCopying.SuspendLayout()
        Me.grpFileCopyOpts.SuspendLayout()
        CType(Me.numVideoDur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMainDir
        '
        Me.txtMainDir.Location = New System.Drawing.Point(9, 29)
        Me.txtMainDir.Name = "txtMainDir"
        Me.txtMainDir.Size = New System.Drawing.Size(251, 20)
        Me.txtMainDir.TabIndex = 0
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(266, 77)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lstErrors
        '
        Me.lstErrors.FormattingEnabled = True
        Me.lstErrors.Location = New System.Drawing.Point(9, 313)
        Me.lstErrors.Name = "lstErrors"
        Me.lstErrors.ScrollAlwaysVisible = True
        Me.lstErrors.Size = New System.Drawing.Size(773, 251)
        Me.lstErrors.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Files With Errors:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Input Directory"
        '
        'chkUnderscore
        '
        Me.chkUnderscore.AutoSize = True
        Me.chkUnderscore.Checked = True
        Me.chkUnderscore.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUnderscore.Location = New System.Drawing.Point(6, 18)
        Me.chkUnderscore.Name = "chkUnderscore"
        Me.chkUnderscore.Size = New System.Drawing.Size(177, 17)
        Me.chkUnderscore.TabIndex = 5
        Me.chkUnderscore.Text = "Change Underscores to Spaces"
        Me.chkUnderscore.UseVisualStyleBackColor = True
        '
        'chkDots
        '
        Me.chkDots.AutoSize = True
        Me.chkDots.Checked = True
        Me.chkDots.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDots.Location = New System.Drawing.Point(6, 72)
        Me.chkDots.Name = "chkDots"
        Me.chkDots.Size = New System.Drawing.Size(137, 17)
        Me.chkDots.TabIndex = 6
        Me.chkDots.Text = "Change Dots to spaces"
        Me.chkDots.UseVisualStyleBackColor = True
        '
        'txtDots
        '
        Me.txtDots.Location = New System.Drawing.Point(168, 90)
        Me.txtDots.Name = "txtDots"
        Me.txtDots.Size = New System.Drawing.Size(30, 20)
        Me.txtDots.TabIndex = 7
        Me.txtDots.Text = "2"
        '
        'chkTrackNo
        '
        Me.chkTrackNo.AutoSize = True
        Me.chkTrackNo.Checked = True
        Me.chkTrackNo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTrackNo.Location = New System.Drawing.Point(6, 36)
        Me.chkTrackNo.Name = "chkTrackNo"
        Me.chkTrackNo.Size = New System.Drawing.Size(183, 17)
        Me.chkTrackNo.TabIndex = 8
        Me.chkTrackNo.Text = "Remove Leading Track Numbers"
        Me.chkTrackNo.UseVisualStyleBackColor = True
        '
        'chkDebug
        '
        Me.chkDebug.AutoSize = True
        Me.chkDebug.Location = New System.Drawing.Point(9, 278)
        Me.chkDebug.Name = "chkDebug"
        Me.chkDebug.Size = New System.Drawing.Size(197, 17)
        Me.chkDebug.TabIndex = 9
        Me.chkDebug.Text = "Output All Artist-Tracknames To Box"
        Me.chkDebug.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(266, 28)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 10
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 77)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(251, 22)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 11
        '
        'chkRecursive
        '
        Me.chkRecursive.AutoSize = True
        Me.chkRecursive.Location = New System.Drawing.Point(9, 55)
        Me.chkRecursive.Name = "chkRecursive"
        Me.chkRecursive.Size = New System.Drawing.Size(118, 17)
        Me.chkRecursive.TabIndex = 12
        Me.chkRecursive.Text = "Search Recursively"
        Me.chkRecursive.UseVisualStyleBackColor = True
        '
        'lstExt
        '
        Me.lstExt.FormattingEnabled = True
        Me.lstExt.Items.AddRange(New Object() {"avi", "AVI", "mkv", "MKV", "vob", "VOB", "wmv", "WMV", "m4v", "M4V", "mp4", "MP4", "TS", "ts", "m2v", "M2V", "MPG", "mpg", "MPEG", "mpeg", "iso", "ISO", "bin", "BIN", "cue", "CUE", "xvid", "XVID", "divx", "DIVX", "webm", "WEBM"})
        Me.lstExt.Location = New System.Drawing.Point(6, 21)
        Me.lstExt.Name = "lstExt"
        Me.lstExt.Size = New System.Drawing.Size(203, 69)
        Me.lstExt.TabIndex = 14
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(6, 93)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(60, 20)
        Me.txtAdd.TabIndex = 15
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(67, 91)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(65, 23)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(132, 91)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(77, 23)
        Me.btnRemove.TabIndex = 17
        Me.btnRemove.Text = "Remove Selected"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'chkCaseArtists
        '
        Me.chkCaseArtists.AutoSize = True
        Me.chkCaseArtists.Checked = True
        Me.chkCaseArtists.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCaseArtists.Location = New System.Drawing.Point(6, 107)
        Me.chkCaseArtists.Name = "chkCaseArtists"
        Me.chkCaseArtists.Size = New System.Drawing.Size(104, 17)
        Me.chkCaseArtists.TabIndex = 19
        Me.chkCaseArtists.Text = "Title Case Artists"
        Me.chkCaseArtists.UseVisualStyleBackColor = True
        '
        'chkCaseTitles
        '
        Me.chkCaseTitles.AutoSize = True
        Me.chkCaseTitles.Checked = True
        Me.chkCaseTitles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCaseTitles.Location = New System.Drawing.Point(6, 126)
        Me.chkCaseTitles.Name = "chkCaseTitles"
        Me.chkCaseTitles.Size = New System.Drawing.Size(129, 17)
        Me.chkCaseTitles.TabIndex = 20
        Me.chkCaseTitles.Text = "Title Case Song Titles"
        Me.chkCaseTitles.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(459, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Files Created:"
        '
        'lblCreated
        '
        Me.lblCreated.AutoSize = True
        Me.lblCreated.Location = New System.Drawing.Point(535, 297)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(13, 13)
        Me.lblCreated.TabIndex = 22
        Me.lblCreated.Text = "0"
        '
        'chkTrackNoExtra
        '
        Me.chkTrackNoExtra.AutoSize = True
        Me.chkTrackNoExtra.Checked = True
        Me.chkTrackNoExtra.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTrackNoExtra.Location = New System.Drawing.Point(91, 55)
        Me.chkTrackNoExtra.Name = "chkTrackNoExtra"
        Me.chkTrackNoExtra.Size = New System.Drawing.Size(100, 17)
        Me.chkTrackNoExtra.TabIndex = 23
        Me.chkTrackNoExtra.Text = "Even if no dash"
        Me.chkTrackNoExtra.UseVisualStyleBackColor = True
        '
        'chkGenre
        '
        Me.chkGenre.AutoSize = True
        Me.chkGenre.Location = New System.Drawing.Point(6, 225)
        Me.chkGenre.Name = "chkGenre"
        Me.chkGenre.Size = New System.Drawing.Size(77, 17)
        Me.chkGenre.TabIndex = 24
        Me.chkGenre.Text = "Add Genre"
        Me.chkGenre.UseVisualStyleBackColor = True
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(82, 222)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(117, 20)
        Me.txtGenre.TabIndex = 25
        Me.txtGenre.Text = "Pop"
        '
        'chkFileTypes
        '
        Me.chkFileTypes.AutoSize = True
        Me.chkFileTypes.Location = New System.Drawing.Point(9, 261)
        Me.chkFileTypes.Name = "chkFileTypes"
        Me.chkFileTypes.Size = New System.Drawing.Size(185, 17)
        Me.chkFileTypes.TabIndex = 26
        Me.chkFileTypes.Text = "Ouput Unknown Filetypes To Box"
        Me.chkFileTypes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.txtAdd)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.lstExt)
        Me.GroupBox1.Location = New System.Drawing.Point(557, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 121)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Types"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkDashless)
        Me.GroupBox2.Controls.Add(Me.chkFallbackArtist)
        Me.GroupBox2.Controls.Add(Me.chkHyphen)
        Me.GroupBox2.Controls.Add(Me.chkArtistAlbum)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtGenre)
        Me.GroupBox2.Controls.Add(Me.chkUnderscore)
        Me.GroupBox2.Controls.Add(Me.chkGenre)
        Me.GroupBox2.Controls.Add(Me.chkTrackNo)
        Me.GroupBox2.Controls.Add(Me.chkTrackNoExtra)
        Me.GroupBox2.Controls.Add(Me.chkDots)
        Me.GroupBox2.Controls.Add(Me.txtDots)
        Me.GroupBox2.Controls.Add(Me.chkCaseTitles)
        Me.GroupBox2.Controls.Add(Me.chkCaseArtists)
        Me.GroupBox2.Location = New System.Drawing.Point(347, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(204, 247)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "XML Tags"
        '
        'chkDashless
        '
        Me.chkDashless.AutoSize = True
        Me.chkDashless.Checked = True
        Me.chkDashless.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDashless.Location = New System.Drawing.Point(6, 205)
        Me.chkDashless.Name = "chkDashless"
        Me.chkDashless.Size = New System.Drawing.Size(152, 17)
        Me.chkDashless.TabIndex = 32
        Me.chkDashless.Text = "Use Dashless Files as Title"
        Me.chkDashless.UseVisualStyleBackColor = True
        '
        'chkFallbackArtist
        '
        Me.chkFallbackArtist.AutoSize = True
        Me.chkFallbackArtist.Checked = True
        Me.chkFallbackArtist.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFallbackArtist.Location = New System.Drawing.Point(53, 183)
        Me.chkFallbackArtist.Name = "chkFallbackArtist"
        Me.chkFallbackArtist.Size = New System.Drawing.Size(146, 17)
        Me.chkFallbackArtist.TabIndex = 31
        Me.chkFallbackArtist.Text = "Fall back to not checking"
        Me.chkFallbackArtist.UseVisualStyleBackColor = True
        '
        'chkHyphen
        '
        Me.chkHyphen.AutoSize = True
        Me.chkHyphen.Checked = True
        Me.chkHyphen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHyphen.Location = New System.Drawing.Point(6, 164)
        Me.chkHyphen.Name = "chkHyphen"
        Me.chkHyphen.Size = New System.Drawing.Size(185, 17)
        Me.chkHyphen.TabIndex = 30
        Me.chkHyphen.Text = "Check for Hyphen in Artists Name"
        Me.chkHyphen.UseVisualStyleBackColor = True
        '
        'chkArtistAlbum
        '
        Me.chkArtistAlbum.AutoSize = True
        Me.chkArtistAlbum.Checked = True
        Me.chkArtistAlbum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkArtistAlbum.Location = New System.Drawing.Point(6, 145)
        Me.chkArtistAlbum.Name = "chkArtistAlbum"
        Me.chkArtistAlbum.Size = New System.Drawing.Size(197, 17)
        Me.chkArtistAlbum.TabIndex = 25
        Me.chkArtistAlbum.Text = "Add Album Tag with Directory Name"
        Me.chkArtistAlbum.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "If there are more than"
        '
        'chkGetThumbnail
        '
        Me.chkGetThumbnail.AutoSize = True
        Me.chkGetThumbnail.Location = New System.Drawing.Point(9, 20)
        Me.chkGetThumbnail.Name = "chkGetThumbnail"
        Me.chkGetThumbnail.Size = New System.Drawing.Size(166, 17)
        Me.chkGetThumbnail.TabIndex = 33
        Me.chkGetThumbnail.Text = "Get Thumbnail Using FFmpeg"
        Me.chkGetThumbnail.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkOutputSkipped)
        Me.GroupBox3.Controls.Add(Me.chkNFOskip)
        Me.GroupBox3.Controls.Add(Me.chkNFOdelete)
        Me.GroupBox3.Controls.Add(Me.chkNFOrename)
        Me.GroupBox3.Location = New System.Drawing.Point(558, 131)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 89)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Existing NFO"
        '
        'chkOutputSkipped
        '
        Me.chkOutputSkipped.AutoSize = True
        Me.chkOutputSkipped.Location = New System.Drawing.Point(7, 68)
        Me.chkOutputSkipped.Name = "chkOutputSkipped"
        Me.chkOutputSkipped.Size = New System.Drawing.Size(154, 17)
        Me.chkOutputSkipped.TabIndex = 3
        Me.chkOutputSkipped.Text = "Ouput skipped items to box"
        Me.chkOutputSkipped.UseVisualStyleBackColor = True
        '
        'chkNFOskip
        '
        Me.chkNFOskip.AutoSize = True
        Me.chkNFOskip.Location = New System.Drawing.Point(6, 49)
        Me.chkNFOskip.Name = "chkNFOskip"
        Me.chkNFOskip.Size = New System.Drawing.Size(124, 17)
        Me.chkNFOskip.TabIndex = 2
        Me.chkNFOskip.Text = "Skip file if NFO exists"
        Me.chkNFOskip.UseVisualStyleBackColor = True
        '
        'chkNFOdelete
        '
        Me.chkNFOdelete.AutoSize = True
        Me.chkNFOdelete.Checked = True
        Me.chkNFOdelete.Location = New System.Drawing.Point(6, 33)
        Me.chkNFOdelete.Name = "chkNFOdelete"
        Me.chkNFOdelete.Size = New System.Drawing.Size(100, 17)
        Me.chkNFOdelete.TabIndex = 1
        Me.chkNFOdelete.TabStop = True
        Me.chkNFOdelete.Text = "Delete Old NFO"
        Me.chkNFOdelete.UseVisualStyleBackColor = True
        '
        'chkNFOrename
        '
        Me.chkNFOrename.AutoSize = True
        Me.chkNFOrename.Location = New System.Drawing.Point(6, 17)
        Me.chkNFOrename.Name = "chkNFOrename"
        Me.chkNFOrename.Size = New System.Drawing.Size(161, 17)
        Me.chkNFOrename.TabIndex = 0
        Me.chkNFOrename.Text = "Rename Old NFO to Backup"
        Me.chkNFOrename.UseVisualStyleBackColor = True
        '
        'grpFileCopying
        '
        Me.grpFileCopying.Controls.Add(Me.chkOverWrite)
        Me.grpFileCopying.Controls.Add(Me.rdbFileAllRoot)
        Me.grpFileCopying.Controls.Add(Me.grpFileCopyOpts)
        Me.grpFileCopying.Controls.Add(Me.Label6)
        Me.grpFileCopying.Controls.Add(Me.Label5)
        Me.grpFileCopying.Controls.Add(Me.btnFileDestination)
        Me.grpFileCopying.Controls.Add(Me.txtFileDestination)
        Me.grpFileCopying.Controls.Add(Me.rdbFileArtistAndTitle)
        Me.grpFileCopying.Controls.Add(Me.rdbFileArtistTitle)
        Me.grpFileCopying.Controls.Add(Me.rdbFileNone)
        Me.grpFileCopying.Location = New System.Drawing.Point(9, 105)
        Me.grpFileCopying.Name = "grpFileCopying"
        Me.grpFileCopying.Size = New System.Drawing.Size(332, 151)
        Me.grpFileCopying.TabIndex = 30
        Me.grpFileCopying.TabStop = False
        Me.grpFileCopying.Text = "File Copying"
        '
        'chkOverWrite
        '
        Me.chkOverWrite.AutoSize = True
        Me.chkOverWrite.Enabled = False
        Me.chkOverWrite.Location = New System.Drawing.Point(8, 87)
        Me.chkOverWrite.Name = "chkOverWrite"
        Me.chkOverWrite.Size = New System.Drawing.Size(77, 17)
        Me.chkOverWrite.TabIndex = 16
        Me.chkOverWrite.Text = "Overwrite?"
        Me.chkOverWrite.UseVisualStyleBackColor = True
        '
        'rdbFileAllRoot
        '
        Me.rdbFileAllRoot.AutoSize = True
        Me.rdbFileAllRoot.Enabled = False
        Me.rdbFileAllRoot.Location = New System.Drawing.Point(8, 32)
        Me.rdbFileAllRoot.Name = "rdbFileAllRoot"
        Me.rdbFileAllRoot.Size = New System.Drawing.Size(130, 17)
        Me.rdbFileAllRoot.TabIndex = 15
        Me.rdbFileAllRoot.TabStop = True
        Me.rdbFileAllRoot.Text = "Copy all to Destination"
        Me.rdbFileAllRoot.UseVisualStyleBackColor = True
        '
        'grpFileCopyOpts
        '
        Me.grpFileCopyOpts.Controls.Add(Me.rdbMoveNothing)
        Me.grpFileCopyOpts.Controls.Add(Me.rdbMoveFileNfoOnly)
        Me.grpFileCopyOpts.Controls.Add(Me.rdbMoveAllFiles)
        Me.grpFileCopyOpts.Controls.Add(Me.rdbMoveNonVideo)
        Me.grpFileCopyOpts.Controls.Add(Me.rdbMoveFiletypes)
        Me.grpFileCopyOpts.Enabled = False
        Me.grpFileCopyOpts.Location = New System.Drawing.Point(172, 8)
        Me.grpFileCopyOpts.Name = "grpFileCopyOpts"
        Me.grpFileCopyOpts.Size = New System.Drawing.Size(154, 109)
        Me.grpFileCopyOpts.TabIndex = 14
        Me.grpFileCopyOpts.TabStop = False
        Me.grpFileCopyOpts.Text = "Copy With Video"
        '
        'rdbMoveNothing
        '
        Me.rdbMoveNothing.AutoSize = True
        Me.rdbMoveNothing.Location = New System.Drawing.Point(6, 17)
        Me.rdbMoveNothing.Name = "rdbMoveNothing"
        Me.rdbMoveNothing.Size = New System.Drawing.Size(62, 17)
        Me.rdbMoveNothing.TabIndex = 4
        Me.rdbMoveNothing.TabStop = True
        Me.rdbMoveNothing.Text = "Nothing"
        Me.rdbMoveNothing.UseVisualStyleBackColor = True
        '
        'rdbMoveFileNfoOnly
        '
        Me.rdbMoveFileNfoOnly.AutoSize = True
        Me.rdbMoveFileNfoOnly.Location = New System.Drawing.Point(6, 34)
        Me.rdbMoveFileNfoOnly.Name = "rdbMoveFileNfoOnly"
        Me.rdbMoveFileNfoOnly.Size = New System.Drawing.Size(71, 17)
        Me.rdbMoveFileNfoOnly.TabIndex = 3
        Me.rdbMoveFileNfoOnly.TabStop = True
        Me.rdbMoveFileNfoOnly.Text = "NFO Only"
        Me.rdbMoveFileNfoOnly.UseVisualStyleBackColor = True
        '
        'rdbMoveAllFiles
        '
        Me.rdbMoveAllFiles.AutoSize = True
        Me.rdbMoveAllFiles.Location = New System.Drawing.Point(6, 87)
        Me.rdbMoveAllFiles.Name = "rdbMoveAllFiles"
        Me.rdbMoveAllFiles.Size = New System.Drawing.Size(140, 17)
        Me.rdbMoveAllFiles.TabIndex = 2
        Me.rdbMoveAllFiles.Text = "All Files in Video's Folder"
        Me.rdbMoveAllFiles.UseVisualStyleBackColor = True
        '
        'rdbMoveNonVideo
        '
        Me.rdbMoveNonVideo.AutoSize = True
        Me.rdbMoveNonVideo.Location = New System.Drawing.Point(6, 69)
        Me.rdbMoveNonVideo.Name = "rdbMoveNonVideo"
        Me.rdbMoveNonVideo.Size = New System.Drawing.Size(137, 17)
        Me.rdbMoveNonVideo.TabIndex = 1
        Me.rdbMoveNonVideo.Text = "All Similarly Named Files"
        Me.rdbMoveNonVideo.UseVisualStyleBackColor = True
        '
        'rdbMoveFiletypes
        '
        Me.rdbMoveFiletypes.AutoSize = True
        Me.rdbMoveFiletypes.Checked = True
        Me.rdbMoveFiletypes.Location = New System.Drawing.Point(6, 51)
        Me.rdbMoveFiletypes.Name = "rdbMoveFiletypes"
        Me.rdbMoveFiletypes.Size = New System.Drawing.Size(128, 17)
        Me.rdbMoveFiletypes.TabIndex = 0
        Me.rdbMoveFiletypes.TabStop = True
        Me.rdbMoveFiletypes.Text = "jpg,png,tbn,txt,xml,nfo"
        Me.rdbMoveFiletypes.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Destination Folder"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(181, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "(Only for 1 video per folder)"
        '
        'btnFileDestination
        '
        Me.btnFileDestination.Location = New System.Drawing.Point(251, 122)
        Me.btnFileDestination.Name = "btnFileDestination"
        Me.btnFileDestination.Size = New System.Drawing.Size(75, 23)
        Me.btnFileDestination.TabIndex = 9
        Me.btnFileDestination.Text = "Browse"
        Me.btnFileDestination.UseVisualStyleBackColor = True
        '
        'txtFileDestination
        '
        Me.txtFileDestination.Location = New System.Drawing.Point(8, 125)
        Me.txtFileDestination.Name = "txtFileDestination"
        Me.txtFileDestination.Size = New System.Drawing.Size(239, 20)
        Me.txtFileDestination.TabIndex = 8
        '
        'rdbFileArtistAndTitle
        '
        Me.rdbFileArtistAndTitle.AutoSize = True
        Me.rdbFileArtistAndTitle.Enabled = False
        Me.rdbFileArtistAndTitle.Location = New System.Drawing.Point(8, 68)
        Me.rdbFileArtistAndTitle.Name = "rdbFileArtistAndTitle"
        Me.rdbFileArtistAndTitle.Size = New System.Drawing.Size(136, 17)
        Me.rdbFileArtistAndTitle.TabIndex = 2
        Me.rdbFileArtistAndTitle.TabStop = True
        Me.rdbFileArtistAndTitle.Text = """Artist"" / ""Title"" Folders"
        Me.rdbFileArtistAndTitle.UseVisualStyleBackColor = True
        '
        'rdbFileArtistTitle
        '
        Me.rdbFileArtistTitle.AutoSize = True
        Me.rdbFileArtistTitle.Enabled = False
        Me.rdbFileArtistTitle.Location = New System.Drawing.Point(8, 50)
        Me.rdbFileArtistTitle.Name = "rdbFileArtistTitle"
        Me.rdbFileArtistTitle.Size = New System.Drawing.Size(118, 17)
        Me.rdbFileArtistTitle.TabIndex = 1
        Me.rdbFileArtistTitle.TabStop = True
        Me.rdbFileArtistTitle.Text = """Artist Title"" Folders"
        Me.rdbFileArtistTitle.UseVisualStyleBackColor = True
        '
        'rdbFileNone
        '
        Me.rdbFileNone.AutoSize = True
        Me.rdbFileNone.Checked = True
        Me.rdbFileNone.Location = New System.Drawing.Point(8, 15)
        Me.rdbFileNone.Name = "rdbFileNone"
        Me.rdbFileNone.Size = New System.Drawing.Size(51, 17)
        Me.rdbFileNone.TabIndex = 0
        Me.rdbFileNone.TabStop = True
        Me.rdbFileNone.Text = "None"
        Me.rdbFileNone.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(75, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "seconds into video"
        '
        'numVideoDur
        '
        Me.numVideoDur.Location = New System.Drawing.Point(9, 38)
        Me.numVideoDur.Name = "numVideoDur"
        Me.numVideoDur.Size = New System.Drawing.Size(60, 20)
        Me.numVideoDur.TabIndex = 36
        Me.numVideoDur.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkThumnailDelete)
        Me.GroupBox4.Controls.Add(Me.numVideoDur)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.chkGetThumbnail)
        Me.GroupBox4.Location = New System.Drawing.Point(557, 226)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(214, 81)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Video Thumbnail"
        '
        'chkThumnailDelete
        '
        Me.chkThumnailDelete.AutoSize = True
        Me.chkThumnailDelete.Location = New System.Drawing.Point(9, 60)
        Me.chkThumnailDelete.Name = "chkThumnailDelete"
        Me.chkThumnailDelete.Size = New System.Drawing.Size(159, 17)
        Me.chkThumnailDelete.TabIndex = 37
        Me.chkThumnailDelete.Text = "Overwrite Exising Thumbnail"
        Me.chkThumnailDelete.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(239, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grpFileCopying)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkFileTypes)
        Me.Controls.Add(Me.lblCreated)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkRecursive)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.chkDebug)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstErrors)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtMainDir)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Form1"
        Me.Text = "XBMC Music Video XML Creator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpFileCopying.ResumeLayout(False)
        Me.grpFileCopying.PerformLayout()
        Me.grpFileCopyOpts.ResumeLayout(False)
        Me.grpFileCopyOpts.PerformLayout()
        CType(Me.numVideoDur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMainDir As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lstErrors As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkUnderscore As System.Windows.Forms.CheckBox
    Friend WithEvents chkDots As System.Windows.Forms.CheckBox
    Friend WithEvents txtDots As System.Windows.Forms.TextBox
    Friend WithEvents chkTrackNo As System.Windows.Forms.CheckBox
    Friend WithEvents chkDebug As System.Windows.Forms.CheckBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents chkRecursive As System.Windows.Forms.CheckBox
    Friend WithEvents lstExt As System.Windows.Forms.ListBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents chkCaseArtists As System.Windows.Forms.CheckBox
    Friend WithEvents chkCaseTitles As System.Windows.Forms.CheckBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCreated As System.Windows.Forms.Label
    Friend WithEvents chkTrackNoExtra As System.Windows.Forms.CheckBox
    Friend WithEvents chkGenre As System.Windows.Forms.CheckBox
    Friend WithEvents txtGenre As System.Windows.Forms.TextBox
    Friend WithEvents chkFileTypes As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkArtistAlbum As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkNFOskip As System.Windows.Forms.RadioButton
    Friend WithEvents chkNFOdelete As System.Windows.Forms.RadioButton
    Friend WithEvents chkNFOrename As System.Windows.Forms.RadioButton
    Friend WithEvents chkOutputSkipped As System.Windows.Forms.CheckBox
    Friend WithEvents chkHyphen As System.Windows.Forms.CheckBox
    Friend WithEvents chkFallbackArtist As System.Windows.Forms.CheckBox
    Friend WithEvents chkDashless As System.Windows.Forms.CheckBox
    Friend WithEvents grpFileCopying As System.Windows.Forms.GroupBox
    Friend WithEvents rdbFileArtistAndTitle As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFileArtistTitle As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFileNone As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnFileDestination As System.Windows.Forms.Button
    Friend WithEvents txtFileDestination As System.Windows.Forms.TextBox
    Friend WithEvents grpFileCopyOpts As System.Windows.Forms.GroupBox
    Friend WithEvents rdbMoveAllFiles As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMoveNonVideo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMoveFiletypes As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdbFileAllRoot As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMoveFileNfoOnly As System.Windows.Forms.RadioButton
    Friend WithEvents chkGetThumbnail As System.Windows.Forms.CheckBox
    Friend WithEvents rdbMoveNothing As System.Windows.Forms.RadioButton
    Friend WithEvents chkOverWrite As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents numVideoDur As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkThumnailDelete As System.Windows.Forms.CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
