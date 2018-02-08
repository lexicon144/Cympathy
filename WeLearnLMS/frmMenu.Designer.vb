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
        Me.mainpanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClassroomHub = New System.Windows.Forms.Button()
        Me.btnTimeManagement = New System.Windows.Forms.Button()
        Me.btnLessonList = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnGrades = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnRanking = New System.Windows.Forms.Button()
        Me.PanelProfessorsOnly = New System.Windows.Forms.TableLayoutPanel()
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
        Me.mainpanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.PanelProfessorsOnly.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainpanel
        '
        Me.mainpanel.ColumnCount = 3
        Me.mainpanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.90291!))
        Me.mainpanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.09709!))
        Me.mainpanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 279.0!))
        Me.mainpanel.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.mainpanel.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.mainpanel.Controls.Add(Me.PanelProfessorsOnly, 0, 1)
        Me.mainpanel.Location = New System.Drawing.Point(16, 15)
        Me.mainpanel.Margin = New System.Windows.Forms.Padding(4)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.RowCount = 2
        Me.mainpanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainpanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainpanel.Size = New System.Drawing.Size(929, 383)
        Me.mainpanel.TabIndex = 33
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnClassroomHub, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnTimeManagement, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLessonList, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(316, 183)
        Me.TableLayoutPanel1.TabIndex = 31
        '
        'btnClassroomHub
        '
        Me.btnClassroomHub.Location = New System.Drawing.Point(4, 4)
        Me.btnClassroomHub.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClassroomHub.Name = "btnClassroomHub"
        Me.btnClassroomHub.Size = New System.Drawing.Size(150, 28)
        Me.btnClassroomHub.TabIndex = 0
        Me.btnClassroomHub.Text = "Classroom"
        Me.btnClassroomHub.UseVisualStyleBackColor = True
        '
        'btnTimeManagement
        '
        Me.btnTimeManagement.Location = New System.Drawing.Point(4, 95)
        Me.btnTimeManagement.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTimeManagement.Name = "btnTimeManagement"
        Me.btnTimeManagement.Size = New System.Drawing.Size(150, 28)
        Me.btnTimeManagement.TabIndex = 1
        Me.btnTimeManagement.Text = "Time Management"
        Me.btnTimeManagement.UseVisualStyleBackColor = True
        '
        'btnLessonList
        '
        Me.btnLessonList.Location = New System.Drawing.Point(162, 4)
        Me.btnLessonList.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLessonList.Name = "btnLessonList"
        Me.btnLessonList.Size = New System.Drawing.Size(150, 28)
        Me.btnLessonList.TabIndex = 27
        Me.btnLessonList.Text = "Lesson List"
        Me.btnLessonList.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnGrades, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFeedback, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnRanking, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(328, 4)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(317, 183)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'btnGrades
        '
        Me.btnGrades.Location = New System.Drawing.Point(4, 4)
        Me.btnGrades.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.Size = New System.Drawing.Size(150, 28)
        Me.btnGrades.TabIndex = 29
        Me.btnGrades.Text = "Grades"
        Me.btnGrades.UseVisualStyleBackColor = True
        '
        'btnFeedback
        '
        Me.btnFeedback.Location = New System.Drawing.Point(162, 4)
        Me.btnFeedback.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(151, 28)
        Me.btnFeedback.TabIndex = 2
        Me.btnFeedback.Text = "Feedback"
        Me.btnFeedback.UseVisualStyleBackColor = True
        '
        'btnRanking
        '
        Me.btnRanking.Location = New System.Drawing.Point(4, 95)
        Me.btnRanking.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRanking.Name = "btnRanking"
        Me.btnRanking.Size = New System.Drawing.Size(150, 28)
        Me.btnRanking.TabIndex = 28
        Me.btnRanking.Text = "Ranking"
        Me.btnRanking.UseVisualStyleBackColor = True
        '
        'PanelProfessorsOnly
        '
        Me.PanelProfessorsOnly.ColumnCount = 2
        Me.PanelProfessorsOnly.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PanelProfessorsOnly.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PanelProfessorsOnly.Controls.Add(Me.btnCreateClassroom, 0, 0)
        Me.PanelProfessorsOnly.Controls.Add(Me.btnCreateQuestionnaire, 1, 0)
        Me.PanelProfessorsOnly.Controls.Add(Me.btnCreateExam, 0, 1)
        Me.PanelProfessorsOnly.Controls.Add(Me.btnCreateArticles, 1, 1)
        Me.PanelProfessorsOnly.Controls.Add(Me.btnCreateMaterials, 0, 2)
        Me.PanelProfessorsOnly.Location = New System.Drawing.Point(4, 195)
        Me.PanelProfessorsOnly.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelProfessorsOnly.Name = "PanelProfessorsOnly"
        Me.PanelProfessorsOnly.RowCount = 3
        Me.PanelProfessorsOnly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.PanelProfessorsOnly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.PanelProfessorsOnly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.PanelProfessorsOnly.Size = New System.Drawing.Size(316, 184)
        Me.PanelProfessorsOnly.TabIndex = 0
        '
        'btnCreateClassroom
        '
        Me.btnCreateClassroom.Location = New System.Drawing.Point(4, 4)
        Me.btnCreateClassroom.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateClassroom.Name = "btnCreateClassroom"
        Me.btnCreateClassroom.Size = New System.Drawing.Size(150, 28)
        Me.btnCreateClassroom.TabIndex = 27
        Me.btnCreateClassroom.Text = "Create Classroom"
        Me.btnCreateClassroom.UseVisualStyleBackColor = True
        '
        'btnCreateQuestionnaire
        '
        Me.btnCreateQuestionnaire.Location = New System.Drawing.Point(162, 4)
        Me.btnCreateQuestionnaire.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateQuestionnaire.Name = "btnCreateQuestionnaire"
        Me.btnCreateQuestionnaire.Size = New System.Drawing.Size(150, 28)
        Me.btnCreateQuestionnaire.TabIndex = 23
        Me.btnCreateQuestionnaire.Text = "Create Quiz"
        Me.btnCreateQuestionnaire.UseVisualStyleBackColor = True
        '
        'btnCreateExam
        '
        Me.btnCreateExam.Location = New System.Drawing.Point(4, 65)
        Me.btnCreateExam.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateExam.Name = "btnCreateExam"
        Me.btnCreateExam.Size = New System.Drawing.Size(150, 28)
        Me.btnCreateExam.TabIndex = 26
        Me.btnCreateExam.Text = "Create Exam"
        Me.btnCreateExam.UseVisualStyleBackColor = True
        '
        'btnCreateArticles
        '
        Me.btnCreateArticles.Location = New System.Drawing.Point(162, 65)
        Me.btnCreateArticles.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateArticles.Name = "btnCreateArticles"
        Me.btnCreateArticles.Size = New System.Drawing.Size(150, 28)
        Me.btnCreateArticles.TabIndex = 24
        Me.btnCreateArticles.Text = "Create Articles"
        Me.btnCreateArticles.UseVisualStyleBackColor = True
        '
        'btnCreateMaterials
        '
        Me.btnCreateMaterials.Location = New System.Drawing.Point(4, 126)
        Me.btnCreateMaterials.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateMaterials.Name = "btnCreateMaterials"
        Me.btnCreateMaterials.Size = New System.Drawing.Size(150, 28)
        Me.btnCreateMaterials.TabIndex = 25
        Me.btnCreateMaterials.Text = "Create Materials"
        Me.btnCreateMaterials.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblPrevClass, Me.toolstripCLASSROOMID, Me.toolstripCLASSNAME, Me.ToolStripStatusLabel1, Me.tlstrpSECONDS, Me.tlstrpMINUTES, Me.tlstrpHOURS, Me.lblCheatDetector})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(961, 25)
        Me.StatusStrip1.TabIndex = 34
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblPrevClass
        '
        Me.lblPrevClass.Name = "lblPrevClass"
        Me.lblPrevClass.Size = New System.Drawing.Size(77, 20)
        Me.lblPrevClass.Text = "Prev Class:"
        '
        'toolstripCLASSROOMID
        '
        Me.toolstripCLASSROOMID.Name = "toolstripCLASSROOMID"
        Me.toolstripCLASSROOMID.Size = New System.Drawing.Size(19, 20)
        Me.toolstripCLASSROOMID.Text = "[]"
        '
        'toolstripCLASSNAME
        '
        Me.toolstripCLASSNAME.Name = "toolstripCLASSNAME"
        Me.toolstripCLASSNAME.Size = New System.Drawing.Size(19, 20)
        Me.toolstripCLASSNAME.Text = "[]"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(91, 20)
        Me.ToolStripStatusLabel1.Text = "Your Session"
        '
        'tlstrpSECONDS
        '
        Me.tlstrpSECONDS.Name = "tlstrpSECONDS"
        Me.tlstrpSECONDS.Size = New System.Drawing.Size(19, 20)
        Me.tlstrpSECONDS.Text = "[]"
        '
        'tlstrpMINUTES
        '
        Me.tlstrpMINUTES.Name = "tlstrpMINUTES"
        Me.tlstrpMINUTES.Size = New System.Drawing.Size(19, 20)
        Me.tlstrpMINUTES.Text = "[]"
        '
        'tlstrpHOURS
        '
        Me.tlstrpHOURS.Name = "tlstrpHOURS"
        Me.tlstrpHOURS.Size = New System.Drawing.Size(19, 20)
        Me.tlstrpHOURS.Text = "[]"
        '
        'lblCheatDetector
        '
        Me.lblCheatDetector.Name = "lblCheatDetector"
        Me.lblCheatDetector.Size = New System.Drawing.Size(19, 20)
        Me.lblCheatDetector.Text = "{}"
        Me.lblCheatDetector.ToolTipText = "You are given one of, if not, the simplest methods of studying... and yet you cho" & _
    "ose to do this." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Really now?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R E A L L Y ?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ＣＡＮ　ＹＯＵ　ＤＯＮ＇Ｔ　隠づ英" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "That's just not " & _
    "cool man."
        '
        'timerSession
        '
        Me.timerSession.Interval = 50
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 453)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mainpanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenu"
        Me.mainpanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.PanelProfessorsOnly.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainpanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClassroomHub As System.Windows.Forms.Button
    Friend WithEvents btnTimeManagement As System.Windows.Forms.Button
    Friend WithEvents btnLessonList As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnGrades As System.Windows.Forms.Button
    Friend WithEvents btnFeedback As System.Windows.Forms.Button
    Friend WithEvents btnRanking As System.Windows.Forms.Button
    Friend WithEvents PanelProfessorsOnly As System.Windows.Forms.TableLayoutPanel
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
End Class
