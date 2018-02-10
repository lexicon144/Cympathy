<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnGrades = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnRanking = New System.Windows.Forms.Button()
        Me.grpStartStudying = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClassroomHub = New System.Windows.Forms.Button()
        Me.btnTimeManagement = New System.Windows.Forms.Button()
        Me.btnLessonList = New System.Windows.Forms.Button()
        Me.btnSetMySession = New System.Windows.Forms.Button()
        Me.PanelProfessorsOnly = New System.Windows.Forms.GroupBox()
        Me.paneltable4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCreateClassroom = New System.Windows.Forms.Button()
        Me.btnCreateQuestionnaire = New System.Windows.Forms.Button()
        Me.btnCreateExam = New System.Windows.Forms.Button()
        Me.btnCreateArticles = New System.Windows.Forms.Button()
        Me.btnCreateMaterials = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblPrevClass = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripCLASSROOMID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripCLASSNAME = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlstrpSECONDS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlstrpMINUTES = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlstrpHOURS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCheatDetector = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timerSession = New System.Windows.Forms.Timer(Me.components)
        Me.grpMisc = New System.Windows.Forms.GroupBox()
        Me.mainpanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChangeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoreSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHappyGreeting = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrMessageAggregator = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel3.SuspendLayout()
        Me.grpStartStudying.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelProfessorsOnly.SuspendLayout()
        Me.paneltable4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.grpMisc.SuspendLayout()
        Me.mainpanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.02703!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.97297!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnGrades, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFeedback, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnRanking, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(2, 15)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(332, 159)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'btnGrades
        '
        Me.btnGrades.AutoEllipsis = True
        Me.btnGrades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGrades.Location = New System.Drawing.Point(3, 3)
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.Size = New System.Drawing.Size(166, 73)
        Me.btnGrades.TabIndex = 29
        Me.btnGrades.Text = "Grades"
        Me.btnGrades.UseVisualStyleBackColor = True
        '
        'btnFeedback
        '
        Me.btnFeedback.AutoEllipsis = True
        Me.btnFeedback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFeedback.Location = New System.Drawing.Point(175, 3)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(154, 73)
        Me.btnFeedback.TabIndex = 2
        Me.btnFeedback.Text = "Feedback"
        Me.btnFeedback.UseVisualStyleBackColor = True
        '
        'btnRanking
        '
        Me.btnRanking.AutoEllipsis = True
        Me.btnRanking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRanking.Location = New System.Drawing.Point(3, 82)
        Me.btnRanking.Name = "btnRanking"
        Me.btnRanking.Size = New System.Drawing.Size(166, 74)
        Me.btnRanking.TabIndex = 28
        Me.btnRanking.Text = "Ranking"
        Me.btnRanking.UseVisualStyleBackColor = True
        '
        'grpStartStudying
        '
        Me.grpStartStudying.Controls.Add(Me.TableLayoutPanel1)
        Me.grpStartStudying.Location = New System.Drawing.Point(2, 2)
        Me.grpStartStudying.Margin = New System.Windows.Forms.Padding(2)
        Me.grpStartStudying.Name = "grpStartStudying"
        Me.grpStartStudying.Padding = New System.Windows.Forms.Padding(2)
        Me.grpStartStudying.Size = New System.Drawing.Size(358, 176)
        Me.grpStartStudying.TabIndex = 32
        Me.grpStartStudying.TabStop = False
        Me.grpStartStudying.Text = "Start Studying"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnClassroomHub, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnTimeManagement, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLessonList, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSetMySession, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 15)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(354, 159)
        Me.TableLayoutPanel1.TabIndex = 31
        '
        'btnClassroomHub
        '
        Me.btnClassroomHub.AutoEllipsis = True
        Me.btnClassroomHub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClassroomHub.Location = New System.Drawing.Point(3, 3)
        Me.btnClassroomHub.Name = "btnClassroomHub"
        Me.btnClassroomHub.Size = New System.Drawing.Size(171, 73)
        Me.btnClassroomHub.TabIndex = 0
        Me.btnClassroomHub.Text = "Classroom"
        Me.btnClassroomHub.UseVisualStyleBackColor = True
        '
        'btnTimeManagement
        '
        Me.btnTimeManagement.AutoEllipsis = True
        Me.btnTimeManagement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTimeManagement.Location = New System.Drawing.Point(3, 82)
        Me.btnTimeManagement.Name = "btnTimeManagement"
        Me.btnTimeManagement.Size = New System.Drawing.Size(171, 74)
        Me.btnTimeManagement.TabIndex = 1
        Me.btnTimeManagement.Text = "Time Management"
        Me.btnTimeManagement.UseVisualStyleBackColor = True
        '
        'btnLessonList
        '
        Me.btnLessonList.AutoEllipsis = True
        Me.btnLessonList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLessonList.Location = New System.Drawing.Point(180, 3)
        Me.btnLessonList.Name = "btnLessonList"
        Me.btnLessonList.Size = New System.Drawing.Size(171, 73)
        Me.btnLessonList.TabIndex = 27
        Me.btnLessonList.Text = "Lesson List"
        Me.btnLessonList.UseVisualStyleBackColor = True
        '
        'btnSetMySession
        '
        Me.btnSetMySession.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSetMySession.Location = New System.Drawing.Point(180, 82)
        Me.btnSetMySession.Name = "btnSetMySession"
        Me.btnSetMySession.Size = New System.Drawing.Size(171, 74)
        Me.btnSetMySession.TabIndex = 28
        Me.btnSetMySession.Text = "Set My Classroom As..."
        Me.btnSetMySession.UseVisualStyleBackColor = True
        '
        'PanelProfessorsOnly
        '
        Me.PanelProfessorsOnly.Controls.Add(Me.paneltable4)
        Me.PanelProfessorsOnly.Location = New System.Drawing.Point(704, 2)
        Me.PanelProfessorsOnly.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelProfessorsOnly.Name = "PanelProfessorsOnly"
        Me.PanelProfessorsOnly.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelProfessorsOnly.Size = New System.Drawing.Size(358, 176)
        Me.PanelProfessorsOnly.TabIndex = 33
        Me.PanelProfessorsOnly.TabStop = False
        Me.PanelProfessorsOnly.Text = "Create..!"
        '
        'paneltable4
        '
        Me.paneltable4.ColumnCount = 2
        Me.paneltable4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.paneltable4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.paneltable4.Controls.Add(Me.btnCreateClassroom, 0, 0)
        Me.paneltable4.Controls.Add(Me.btnCreateQuestionnaire, 1, 0)
        Me.paneltable4.Controls.Add(Me.btnCreateExam, 0, 1)
        Me.paneltable4.Controls.Add(Me.btnCreateArticles, 1, 1)
        Me.paneltable4.Controls.Add(Me.btnCreateMaterials, 0, 2)
        Me.paneltable4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.paneltable4.Location = New System.Drawing.Point(2, 15)
        Me.paneltable4.Name = "paneltable4"
        Me.paneltable4.RowCount = 3
        Me.paneltable4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.paneltable4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.paneltable4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.paneltable4.Size = New System.Drawing.Size(354, 159)
        Me.paneltable4.TabIndex = 0
        '
        'btnCreateClassroom
        '
        Me.btnCreateClassroom.AutoSize = True
        Me.btnCreateClassroom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreateClassroom.Location = New System.Drawing.Point(3, 3)
        Me.btnCreateClassroom.Name = "btnCreateClassroom"
        Me.btnCreateClassroom.Size = New System.Drawing.Size(171, 47)
        Me.btnCreateClassroom.TabIndex = 27
        Me.btnCreateClassroom.Text = "Create Classroom"
        Me.btnCreateClassroom.UseVisualStyleBackColor = True
        '
        'btnCreateQuestionnaire
        '
        Me.btnCreateQuestionnaire.AutoSize = True
        Me.btnCreateQuestionnaire.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreateQuestionnaire.Location = New System.Drawing.Point(180, 3)
        Me.btnCreateQuestionnaire.Name = "btnCreateQuestionnaire"
        Me.btnCreateQuestionnaire.Size = New System.Drawing.Size(171, 47)
        Me.btnCreateQuestionnaire.TabIndex = 23
        Me.btnCreateQuestionnaire.Text = "Create Quiz"
        Me.btnCreateQuestionnaire.UseVisualStyleBackColor = True
        '
        'btnCreateExam
        '
        Me.btnCreateExam.AutoSize = True
        Me.btnCreateExam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreateExam.Location = New System.Drawing.Point(3, 56)
        Me.btnCreateExam.Name = "btnCreateExam"
        Me.btnCreateExam.Size = New System.Drawing.Size(171, 47)
        Me.btnCreateExam.TabIndex = 26
        Me.btnCreateExam.Text = "Create Exam"
        Me.btnCreateExam.UseVisualStyleBackColor = True
        '
        'btnCreateArticles
        '
        Me.btnCreateArticles.AutoSize = True
        Me.btnCreateArticles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreateArticles.Location = New System.Drawing.Point(180, 56)
        Me.btnCreateArticles.Name = "btnCreateArticles"
        Me.btnCreateArticles.Size = New System.Drawing.Size(171, 47)
        Me.btnCreateArticles.TabIndex = 24
        Me.btnCreateArticles.Text = "Create Articles"
        Me.btnCreateArticles.UseVisualStyleBackColor = True
        '
        'btnCreateMaterials
        '
        Me.btnCreateMaterials.AutoSize = True
        Me.btnCreateMaterials.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreateMaterials.Location = New System.Drawing.Point(3, 109)
        Me.btnCreateMaterials.Name = "btnCreateMaterials"
        Me.btnCreateMaterials.Size = New System.Drawing.Size(171, 47)
        Me.btnCreateMaterials.TabIndex = 25
        Me.btnCreateMaterials.Text = "Create Materials"
        Me.btnCreateMaterials.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblPrevClass, Me.toolstripCLASSROOMID, Me.toolstripCLASSNAME, Me.lblHappyGreeting, Me.ToolStripStatusLabel1, Me.tlstrpSECONDS, Me.tlstrpMINUTES, Me.tlstrpHOURS, Me.lblCheatDetector})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 421)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1093, 22)
        Me.StatusStrip1.TabIndex = 34
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblPrevClass
        '
        Me.lblPrevClass.Name = "lblPrevClass"
        Me.lblPrevClass.Size = New System.Drawing.Size(108, 17)
        Me.lblPrevClass.Text = "Session Classroom:"
        '
        'toolstripCLASSROOMID
        '
        Me.toolstripCLASSROOMID.Name = "toolstripCLASSROOMID"
        Me.toolstripCLASSROOMID.Size = New System.Drawing.Size(15, 17)
        Me.toolstripCLASSROOMID.Text = "[]"
        '
        'toolstripCLASSNAME
        '
        Me.toolstripCLASSNAME.Name = "toolstripCLASSNAME"
        Me.toolstripCLASSNAME.Size = New System.Drawing.Size(15, 17)
        Me.toolstripCLASSNAME.Text = "[]"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(73, 17)
        Me.ToolStripStatusLabel1.Text = "Your Session"
        '
        'tlstrpSECONDS
        '
        Me.tlstrpSECONDS.Name = "tlstrpSECONDS"
        Me.tlstrpSECONDS.Size = New System.Drawing.Size(15, 17)
        Me.tlstrpSECONDS.Text = "[]"
        '
        'tlstrpMINUTES
        '
        Me.tlstrpMINUTES.Name = "tlstrpMINUTES"
        Me.tlstrpMINUTES.Size = New System.Drawing.Size(15, 17)
        Me.tlstrpMINUTES.Text = "[]"
        '
        'tlstrpHOURS
        '
        Me.tlstrpHOURS.Name = "tlstrpHOURS"
        Me.tlstrpHOURS.Size = New System.Drawing.Size(15, 17)
        Me.tlstrpHOURS.Text = "[]"
        '
        'lblCheatDetector
        '
        Me.lblCheatDetector.Name = "lblCheatDetector"
        Me.lblCheatDetector.Size = New System.Drawing.Size(15, 17)
        Me.lblCheatDetector.Text = "{}"
        Me.lblCheatDetector.ToolTipText = "You are given one of, if not, the simplest methods of studying... and yet you cho" & _
    "ose to do this." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Really now?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R E A L L Y ?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ＣＡＮ　ＹＯＵ　ＤＯＮ＇Ｔ　隠づ英" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "That's just not " & _
    "cool man."
        '
        'timerSession
        '
        Me.timerSession.Interval = 50
        '
        'grpMisc
        '
        Me.grpMisc.Controls.Add(Me.TableLayoutPanel3)
        Me.grpMisc.Location = New System.Drawing.Point(364, 2)
        Me.grpMisc.Margin = New System.Windows.Forms.Padding(2)
        Me.grpMisc.Name = "grpMisc"
        Me.grpMisc.Padding = New System.Windows.Forms.Padding(2)
        Me.grpMisc.Size = New System.Drawing.Size(336, 176)
        Me.grpMisc.TabIndex = 34
        Me.grpMisc.TabStop = False
        Me.grpMisc.Text = "Others..."
        '
        'mainpanel
        '
        Me.mainpanel.Controls.Add(Me.grpStartStudying)
        Me.mainpanel.Controls.Add(Me.grpMisc)
        Me.mainpanel.Controls.Add(Me.PanelProfessorsOnly)
        Me.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainpanel.Location = New System.Drawing.Point(0, 24)
        Me.mainpanel.Margin = New System.Windows.Forms.Padding(2)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(1093, 397)
        Me.mainpanel.TabIndex = 35
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        Me.ColorDialog1.FullOpen = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeColorToolStripMenuItem, Me.ChangeSettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1093, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChangeColorToolStripMenuItem
        '
        Me.ChangeColorToolStripMenuItem.Name = "ChangeColorToolStripMenuItem"
        Me.ChangeColorToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ChangeColorToolStripMenuItem.Text = "Change Color"
        '
        'ChangeSettingsToolStripMenuItem
        '
        Me.ChangeSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.MoreSettingsToolStripMenuItem})
        Me.ChangeSettingsToolStripMenuItem.Name = "ChangeSettingsToolStripMenuItem"
        Me.ChangeSettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ChangeSettingsToolStripMenuItem.Text = "Settings"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'MoreSettingsToolStripMenuItem
        '
        Me.MoreSettingsToolStripMenuItem.Name = "MoreSettingsToolStripMenuItem"
        Me.MoreSettingsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.MoreSettingsToolStripMenuItem.Text = "More Settings"
        '
        'lblHappyGreeting
        '
        Me.lblHappyGreeting.Name = "lblHappyGreeting"
        Me.lblHappyGreeting.Size = New System.Drawing.Size(807, 17)
        Me.lblHappyGreeting.Spring = True
        Me.lblHappyGreeting.Text = "WE LEARN !!"
        '
        'tmrMessageAggregator
        '
        Me.tmrMessageAggregator.Interval = 5000
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.WeLearnLMS.My.MySettings.Default.MenuBGC
        Me.ClientSize = New System.Drawing.Size(1093, 443)
        Me.Controls.Add(Me.mainpanel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.WeLearnLMS.My.MySettings.Default, "MenuBGC", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenu"
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.grpStartStudying.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanelProfessorsOnly.ResumeLayout(False)
        Me.paneltable4.ResumeLayout(False)
        Me.paneltable4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grpMisc.ResumeLayout(False)
        Me.mainpanel.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClassroomHub As System.Windows.Forms.Button
    Friend WithEvents btnTimeManagement As System.Windows.Forms.Button
    Friend WithEvents btnLessonList As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnGrades As System.Windows.Forms.Button
    Friend WithEvents btnFeedback As System.Windows.Forms.Button
    Friend WithEvents btnRanking As System.Windows.Forms.Button
    Friend WithEvents paneltable4 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents btnCreateArticles As System.Windows.Forms.Button
    Private WithEvents btnCreateMaterials As System.Windows.Forms.Button
    Friend WithEvents btnCreateExam As System.Windows.Forms.Button
    Private WithEvents btnCreateQuestionnaire As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblPrevClass As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolstripCLASSROOMID As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolstripCLASSNAME As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tlstrpSECONDS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents timerSession As System.Windows.Forms.Timer
    Friend WithEvents tlstrpMINUTES As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tlstrpHOURS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCheatDetector As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnCreateClassroom As System.Windows.Forms.Button
    Friend WithEvents grpStartStudying As System.Windows.Forms.GroupBox
    Friend WithEvents PanelProfessorsOnly As System.Windows.Forms.GroupBox
    Friend WithEvents grpMisc As System.Windows.Forms.GroupBox
    Friend WithEvents mainpanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ChangeColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoreSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSetMySession As System.Windows.Forms.Button
    Friend WithEvents lblHappyGreeting As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrMessageAggregator As System.Windows.Forms.Timer
End Class
