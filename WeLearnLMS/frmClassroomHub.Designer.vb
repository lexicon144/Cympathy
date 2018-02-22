<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassroomHub
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
        Me.btnLinkExamHere = New System.Windows.Forms.Button()
        Me.btnLinkQuizHere = New System.Windows.Forms.Button()
        Me.btnLinkMaterialHere = New System.Windows.Forms.Button()
        Me.btnLinkArticleHere = New System.Windows.Forms.Button()
        Me.btnLinkStudentToClassroom = New System.Windows.Forms.Button()
        Me.btnViewMaterials = New System.Windows.Forms.Button()
        Me.btnViewArticles = New System.Windows.Forms.Button()
        Me.btnOpenQuestionnaire = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClassType = New System.Windows.Forms.TextBox()
        Me.txtClassId = New System.Windows.Forms.TextBox()
        Me.txtClassDescription = New System.Windows.Forms.TextBox()
        Me.txtClassName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnViewLessonlist = New System.Windows.Forms.Button()
        Me.btnViewExams = New System.Windows.Forms.Button()
        Me.frmViewGrades = New System.Windows.Forms.Button()
        Me.btnViewExamGrades = New System.Windows.Forms.Button()
        Me.PanelProfessorsOnly = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpViewing = New System.Windows.Forms.GroupBox()
        Me.tablelayoutViewing = New System.Windows.Forms.TableLayoutPanel()
        Me.grpMisc = New System.Windows.Forms.GroupBox()
        Me.tablelayoutMisc = New System.Windows.Forms.TableLayoutPanel()
        Me.btnViewClassGrades = New System.Windows.Forms.Button()
        Me.grpGrades = New System.Windows.Forms.GroupBox()
        Me.tablelayoutGrades = New System.Windows.Forms.TableLayoutPanel()
        Me.mainpanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.grpClassDATA = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChangeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchedulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassStandingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PanelProfessorsOnly.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grpViewing.SuspendLayout()
        Me.tablelayoutViewing.SuspendLayout()
        Me.grpMisc.SuspendLayout()
        Me.tablelayoutMisc.SuspendLayout()
        Me.grpGrades.SuspendLayout()
        Me.tablelayoutGrades.SuspendLayout()
        Me.mainpanel.SuspendLayout()
        Me.grpClassDATA.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLinkExamHere
        '
        Me.btnLinkExamHere.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.btnLinkExamHere, "Link an Exam to this classroom")
        Me.btnLinkExamHere.Location = New System.Drawing.Point(3, 62)
        Me.btnLinkExamHere.Name = "btnLinkExamHere"
        Me.HelpProvider1.SetShowHelp(Me.btnLinkExamHere, True)
        Me.btnLinkExamHere.Size = New System.Drawing.Size(128, 53)
        Me.btnLinkExamHere.TabIndex = 21
        Me.btnLinkExamHere.Text = "Link Exam Here"
        Me.btnLinkExamHere.UseVisualStyleBackColor = True
        '
        'btnLinkQuizHere
        '
        Me.btnLinkQuizHere.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.btnLinkQuizHere, "Link a Quiz to this classroom")
        Me.btnLinkQuizHere.Location = New System.Drawing.Point(3, 3)
        Me.btnLinkQuizHere.Name = "btnLinkQuizHere"
        Me.HelpProvider1.SetShowHelp(Me.btnLinkQuizHere, True)
        Me.btnLinkQuizHere.Size = New System.Drawing.Size(128, 53)
        Me.btnLinkQuizHere.TabIndex = 20
        Me.btnLinkQuizHere.Text = "Link Quiz Here"
        Me.btnLinkQuizHere.UseVisualStyleBackColor = True
        '
        'btnLinkMaterialHere
        '
        Me.btnLinkMaterialHere.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.btnLinkMaterialHere, "Link a material to this classroom")
        Me.btnLinkMaterialHere.Location = New System.Drawing.Point(3, 180)
        Me.btnLinkMaterialHere.Name = "btnLinkMaterialHere"
        Me.HelpProvider1.SetShowHelp(Me.btnLinkMaterialHere, True)
        Me.btnLinkMaterialHere.Size = New System.Drawing.Size(128, 53)
        Me.btnLinkMaterialHere.TabIndex = 19
        Me.btnLinkMaterialHere.Text = "Link Material Here"
        Me.btnLinkMaterialHere.UseVisualStyleBackColor = True
        '
        'btnLinkArticleHere
        '
        Me.btnLinkArticleHere.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.btnLinkArticleHere, "Link an Article to this classroom")
        Me.btnLinkArticleHere.Location = New System.Drawing.Point(3, 121)
        Me.btnLinkArticleHere.Name = "btnLinkArticleHere"
        Me.HelpProvider1.SetShowHelp(Me.btnLinkArticleHere, True)
        Me.btnLinkArticleHere.Size = New System.Drawing.Size(128, 53)
        Me.btnLinkArticleHere.TabIndex = 18
        Me.btnLinkArticleHere.Text = "Link Article Here"
        Me.btnLinkArticleHere.UseVisualStyleBackColor = True
        '
        'btnLinkStudentToClassroom
        '
        Me.btnLinkStudentToClassroom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.btnLinkStudentToClassroom, "Link a student to this classroom")
        Me.btnLinkStudentToClassroom.Location = New System.Drawing.Point(3, 239)
        Me.btnLinkStudentToClassroom.Name = "btnLinkStudentToClassroom"
        Me.HelpProvider1.SetShowHelp(Me.btnLinkStudentToClassroom, True)
        Me.btnLinkStudentToClassroom.Size = New System.Drawing.Size(128, 53)
        Me.btnLinkStudentToClassroom.TabIndex = 17
        Me.btnLinkStudentToClassroom.Text = "Link User Here"
        Me.btnLinkStudentToClassroom.UseVisualStyleBackColor = True
        '
        'btnViewMaterials
        '
        Me.btnViewMaterials.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.btnViewMaterials, "View Materials in thie classroom")
        Me.btnViewMaterials.Location = New System.Drawing.Point(3, 55)
        Me.btnViewMaterials.Name = "btnViewMaterials"
        Me.HelpProvider1.SetShowHelp(Me.btnViewMaterials, True)
        Me.btnViewMaterials.Size = New System.Drawing.Size(151, 46)
        Me.btnViewMaterials.TabIndex = 15
        Me.btnViewMaterials.Text = "View Materials"
        Me.btnViewMaterials.UseVisualStyleBackColor = True
        '
        'btnViewArticles
        '
        Me.btnViewArticles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.btnViewArticles, "View the Articles in thie classroom")
        Me.btnViewArticles.Location = New System.Drawing.Point(3, 3)
        Me.btnViewArticles.Name = "btnViewArticles"
        Me.HelpProvider1.SetShowHelp(Me.btnViewArticles, True)
        Me.btnViewArticles.Size = New System.Drawing.Size(151, 46)
        Me.btnViewArticles.TabIndex = 13
        Me.btnViewArticles.Text = "View Articles"
        Me.btnViewArticles.UseVisualStyleBackColor = True
        '
        'btnOpenQuestionnaire
        '
        Me.btnOpenQuestionnaire.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.btnOpenQuestionnaire, "View the quizes present in this classroom")
        Me.btnOpenQuestionnaire.Location = New System.Drawing.Point(3, 3)
        Me.btnOpenQuestionnaire.Name = "btnOpenQuestionnaire"
        Me.HelpProvider1.SetShowHelp(Me.btnOpenQuestionnaire, True)
        Me.btnOpenQuestionnaire.Size = New System.Drawing.Size(145, 69)
        Me.btnOpenQuestionnaire.TabIndex = 11
        Me.btnOpenQuestionnaire.Text = "View Quizes"
        Me.btnOpenQuestionnaire.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Type"
        '
        'txtClassType
        '
        Me.txtClassType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtClassType.Location = New System.Drawing.Point(89, 118)
        Me.txtClassType.Margin = New System.Windows.Forms.Padding(1)
        Me.txtClassType.Name = "txtClassType"
        Me.txtClassType.ReadOnly = True
        Me.txtClassType.Size = New System.Drawing.Size(237, 20)
        Me.txtClassType.TabIndex = 10
        '
        'txtClassId
        '
        Me.txtClassId.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtClassId.Location = New System.Drawing.Point(89, 40)
        Me.txtClassId.Margin = New System.Windows.Forms.Padding(1)
        Me.txtClassId.Name = "txtClassId"
        Me.txtClassId.ReadOnly = True
        Me.txtClassId.Size = New System.Drawing.Size(237, 20)
        Me.txtClassId.TabIndex = 7
        '
        'txtClassDescription
        '
        Me.txtClassDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtClassDescription.Location = New System.Drawing.Point(89, 79)
        Me.txtClassDescription.Margin = New System.Windows.Forms.Padding(1)
        Me.txtClassDescription.Name = "txtClassDescription"
        Me.txtClassDescription.ReadOnly = True
        Me.txtClassDescription.Size = New System.Drawing.Size(237, 20)
        Me.txtClassDescription.TabIndex = 6
        '
        'txtClassName
        '
        Me.txtClassName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtClassName.Location = New System.Drawing.Point(89, 1)
        Me.txtClassName.Margin = New System.Windows.Forms.Padding(1)
        Me.txtClassName.Name = "txtClassName"
        Me.txtClassName.ReadOnly = True
        Me.txtClassName.Size = New System.Drawing.Size(237, 20)
        Me.txtClassName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 39)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnViewLessonlist
        '
        Me.btnViewLessonlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.btnViewLessonlist, "View Everything Related in thie classroom")
        Me.btnViewLessonlist.Location = New System.Drawing.Point(3, 107)
        Me.btnViewLessonlist.Name = "btnViewLessonlist"
        Me.HelpProvider1.SetShowHelp(Me.btnViewLessonlist, True)
        Me.btnViewLessonlist.Size = New System.Drawing.Size(151, 46)
        Me.btnViewLessonlist.TabIndex = 28
        Me.btnViewLessonlist.Text = "View Lesson List"
        Me.btnViewLessonlist.UseVisualStyleBackColor = True
        '
        'btnViewExams
        '
        Me.btnViewExams.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.btnViewExams, "View the Exams present in this classroom")
        Me.btnViewExams.Location = New System.Drawing.Point(3, 78)
        Me.btnViewExams.Name = "btnViewExams"
        Me.HelpProvider1.SetShowHelp(Me.btnViewExams, True)
        Me.btnViewExams.Size = New System.Drawing.Size(145, 70)
        Me.btnViewExams.TabIndex = 29
        Me.btnViewExams.Text = "View Exams"
        Me.btnViewExams.UseVisualStyleBackColor = True
        '
        'frmViewGrades
        '
        Me.frmViewGrades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.frmViewGrades, "View the quiz grades  in thie classroom")
        Me.frmViewGrades.Location = New System.Drawing.Point(3, 3)
        Me.frmViewGrades.Name = "frmViewGrades"
        Me.HelpProvider1.SetShowHelp(Me.frmViewGrades, True)
        Me.frmViewGrades.Size = New System.Drawing.Size(149, 46)
        Me.frmViewGrades.TabIndex = 30
        Me.frmViewGrades.Text = "View Quiz Grades"
        Me.frmViewGrades.UseVisualStyleBackColor = True
        '
        'btnViewExamGrades
        '
        Me.btnViewExamGrades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.btnViewExamGrades, "View the Exam Grades in thie classroom")
        Me.btnViewExamGrades.Location = New System.Drawing.Point(3, 55)
        Me.btnViewExamGrades.Name = "btnViewExamGrades"
        Me.HelpProvider1.SetShowHelp(Me.btnViewExamGrades, True)
        Me.btnViewExamGrades.Size = New System.Drawing.Size(149, 46)
        Me.btnViewExamGrades.TabIndex = 31
        Me.btnViewExamGrades.Text = "View Exam Grades"
        Me.btnViewExamGrades.UseVisualStyleBackColor = True
        '
        'PanelProfessorsOnly
        '
        Me.PanelProfessorsOnly.Controls.Add(Me.Panel1)
        Me.PanelProfessorsOnly.Location = New System.Drawing.Point(170, 364)
        Me.PanelProfessorsOnly.Name = "PanelProfessorsOnly"
        Me.PanelProfessorsOnly.Size = New System.Drawing.Size(160, 175)
        Me.PanelProfessorsOnly.TabIndex = 32
        Me.PanelProfessorsOnly.TabStop = False
        Me.PanelProfessorsOnly.Text = "Linking"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(154, 156)
        Me.Panel1.TabIndex = 40
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoScroll = True
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnLinkQuizHere, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnLinkStudentToClassroom, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btnLinkExamHere, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnLinkMaterialHere, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnLinkArticleHere, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(134, 356)
        Me.TableLayoutPanel2.TabIndex = 23
        '
        'grpViewing
        '
        Me.grpViewing.Controls.Add(Me.tablelayoutViewing)
        Me.grpViewing.Location = New System.Drawing.Point(3, 183)
        Me.grpViewing.Name = "grpViewing"
        Me.grpViewing.Size = New System.Drawing.Size(161, 175)
        Me.grpViewing.TabIndex = 33
        Me.grpViewing.TabStop = False
        Me.grpViewing.Text = "Viewing"
        '
        'tablelayoutViewing
        '
        Me.tablelayoutViewing.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tablelayoutViewing.ColumnCount = 1
        Me.tablelayoutViewing.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutViewing.Controls.Add(Me.btnViewExams, 0, 1)
        Me.tablelayoutViewing.Controls.Add(Me.btnOpenQuestionnaire, 0, 0)
        Me.tablelayoutViewing.Location = New System.Drawing.Point(5, 18)
        Me.tablelayoutViewing.Margin = New System.Windows.Forms.Padding(2)
        Me.tablelayoutViewing.Name = "tablelayoutViewing"
        Me.tablelayoutViewing.RowCount = 2
        Me.tablelayoutViewing.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutViewing.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelayoutViewing.Size = New System.Drawing.Size(151, 151)
        Me.tablelayoutViewing.TabIndex = 39
        '
        'grpMisc
        '
        Me.grpMisc.Controls.Add(Me.tablelayoutMisc)
        Me.grpMisc.Location = New System.Drawing.Point(170, 183)
        Me.grpMisc.Name = "grpMisc"
        Me.grpMisc.Size = New System.Drawing.Size(163, 175)
        Me.grpMisc.TabIndex = 34
        Me.grpMisc.TabStop = False
        Me.grpMisc.Text = "Misc"
        '
        'tablelayoutMisc
        '
        Me.tablelayoutMisc.ColumnCount = 1
        Me.tablelayoutMisc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutMisc.Controls.Add(Me.btnViewLessonlist, 0, 2)
        Me.tablelayoutMisc.Controls.Add(Me.btnViewMaterials, 0, 1)
        Me.tablelayoutMisc.Controls.Add(Me.btnViewArticles, 0, 0)
        Me.tablelayoutMisc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutMisc.Location = New System.Drawing.Point(3, 16)
        Me.tablelayoutMisc.Margin = New System.Windows.Forms.Padding(2)
        Me.tablelayoutMisc.Name = "tablelayoutMisc"
        Me.tablelayoutMisc.RowCount = 3
        Me.tablelayoutMisc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tablelayoutMisc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tablelayoutMisc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tablelayoutMisc.Size = New System.Drawing.Size(157, 156)
        Me.tablelayoutMisc.TabIndex = 39
        '
        'btnViewClassGrades
        '
        Me.btnViewClassGrades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.btnViewClassGrades, "View the Classroom Grades")
        Me.btnViewClassGrades.Location = New System.Drawing.Point(3, 107)
        Me.btnViewClassGrades.Name = "btnViewClassGrades"
        Me.HelpProvider1.SetShowHelp(Me.btnViewClassGrades, True)
        Me.btnViewClassGrades.Size = New System.Drawing.Size(149, 46)
        Me.btnViewClassGrades.TabIndex = 34
        Me.btnViewClassGrades.Text = "View Class Grades"
        Me.btnViewClassGrades.UseVisualStyleBackColor = True
        '
        'grpGrades
        '
        Me.grpGrades.Controls.Add(Me.tablelayoutGrades)
        Me.grpGrades.Location = New System.Drawing.Point(3, 364)
        Me.grpGrades.Name = "grpGrades"
        Me.grpGrades.Size = New System.Drawing.Size(161, 175)
        Me.grpGrades.TabIndex = 35
        Me.grpGrades.TabStop = False
        Me.grpGrades.Text = "View Grades"
        '
        'tablelayoutGrades
        '
        Me.tablelayoutGrades.AllowDrop = True
        Me.tablelayoutGrades.ColumnCount = 1
        Me.tablelayoutGrades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutGrades.Controls.Add(Me.btnViewClassGrades, 0, 2)
        Me.tablelayoutGrades.Controls.Add(Me.frmViewGrades, 0, 0)
        Me.tablelayoutGrades.Controls.Add(Me.btnViewExamGrades, 0, 1)
        Me.tablelayoutGrades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutGrades.Location = New System.Drawing.Point(3, 16)
        Me.tablelayoutGrades.Margin = New System.Windows.Forms.Padding(2)
        Me.tablelayoutGrades.Name = "tablelayoutGrades"
        Me.tablelayoutGrades.RowCount = 3
        Me.tablelayoutGrades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tablelayoutGrades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tablelayoutGrades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tablelayoutGrades.Size = New System.Drawing.Size(155, 156)
        Me.tablelayoutGrades.TabIndex = 39
        '
        'mainpanel
        '
        Me.mainpanel.Controls.Add(Me.grpClassDATA)
        Me.mainpanel.Controls.Add(Me.grpViewing)
        Me.mainpanel.Controls.Add(Me.grpMisc)
        Me.mainpanel.Controls.Add(Me.grpGrades)
        Me.mainpanel.Controls.Add(Me.PanelProfessorsOnly)
        Me.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainpanel.Location = New System.Drawing.Point(0, 24)
        Me.mainpanel.Margin = New System.Windows.Forms.Padding(2)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(339, 558)
        Me.mainpanel.TabIndex = 38
        '
        'grpClassDATA
        '
        Me.grpClassDATA.Controls.Add(Me.TableLayoutPanel1)
        Me.grpClassDATA.Location = New System.Drawing.Point(2, 2)
        Me.grpClassDATA.Margin = New System.Windows.Forms.Padding(2)
        Me.grpClassDATA.Name = "grpClassDATA"
        Me.grpClassDATA.Padding = New System.Windows.Forms.Padding(2)
        Me.grpClassDATA.Size = New System.Drawing.Size(331, 176)
        Me.grpClassDATA.TabIndex = 39
        Me.grpClassDATA.TabStop = False
        Me.grpClassDATA.Text = "This Classroom"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.21712!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.78288!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtClassType, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtClassDescription, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtClassName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtClassId, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.TableLayoutPanel1, "These are the details of this classroom")
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 15)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.HelpProvider1.SetShowHelp(Me.TableLayoutPanel1, True)
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(327, 159)
        Me.TableLayoutPanel1.TabIndex = 39
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeColorToolStripMenuItem, Me.ScheduleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(339, 24)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChangeColorToolStripMenuItem
        '
        Me.ChangeColorToolStripMenuItem.Name = "ChangeColorToolStripMenuItem"
        Me.ChangeColorToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ChangeColorToolStripMenuItem.Text = "Change Color"
        '
        'ScheduleToolStripMenuItem
        '
        Me.ScheduleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SchedulesToolStripMenuItem, Me.ClassStandingToolStripMenuItem})
        Me.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem"
        Me.ScheduleToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ScheduleToolStripMenuItem.Text = "More Data..."
        '
        'SchedulesToolStripMenuItem
        '
        Me.SchedulesToolStripMenuItem.Name = "SchedulesToolStripMenuItem"
        Me.SchedulesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SchedulesToolStripMenuItem.Text = "Schedules"
        '
        'ClassStandingToolStripMenuItem
        '
        Me.ClassStandingToolStripMenuItem.Name = "ClassStandingToolStripMenuItem"
        Me.ClassStandingToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ClassStandingToolStripMenuItem.Text = "Class Standing"
        '
        'frmClassroomHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.WeLearnLMS.My.MySettings.Default.ClassroomHubBGC
        Me.ClientSize = New System.Drawing.Size(339, 582)
        Me.Controls.Add(Me.mainpanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.WeLearnLMS.My.MySettings.Default, "ClassroomHubBGC", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
        Me.HelpProvider1.SetHelpString(Me, "This is where the Classroom Can be Fully Functional")
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmClassroomHub"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClassroomHub"
        Me.PanelProfessorsOnly.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.grpViewing.ResumeLayout(False)
        Me.tablelayoutViewing.ResumeLayout(False)
        Me.grpMisc.ResumeLayout(False)
        Me.tablelayoutMisc.ResumeLayout(False)
        Me.grpGrades.ResumeLayout(False)
        Me.tablelayoutGrades.ResumeLayout(False)
        Me.mainpanel.ResumeLayout(False)
        Me.grpClassDATA.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnLinkExamHere As System.Windows.Forms.Button
    Private WithEvents btnLinkQuizHere As System.Windows.Forms.Button
    Private WithEvents btnLinkMaterialHere As System.Windows.Forms.Button
    Private WithEvents btnLinkArticleHere As System.Windows.Forms.Button
    Private WithEvents btnLinkStudentToClassroom As System.Windows.Forms.Button
    Private WithEvents btnViewMaterials As System.Windows.Forms.Button
    Private WithEvents btnViewArticles As System.Windows.Forms.Button
    Private WithEvents btnOpenQuestionnaire As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtClassType As System.Windows.Forms.TextBox
    Friend WithEvents txtClassId As System.Windows.Forms.TextBox
    Friend WithEvents txtClassDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtClassName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnViewLessonlist As System.Windows.Forms.Button
    Friend WithEvents btnViewExams As System.Windows.Forms.Button
    Friend WithEvents frmViewGrades As System.Windows.Forms.Button
    Friend WithEvents btnViewExamGrades As System.Windows.Forms.Button
    Friend WithEvents PanelProfessorsOnly As System.Windows.Forms.GroupBox
    Friend WithEvents grpViewing As System.Windows.Forms.GroupBox
    Friend WithEvents grpMisc As System.Windows.Forms.GroupBox
    Friend WithEvents btnViewClassGrades As System.Windows.Forms.Button
    Friend WithEvents grpGrades As System.Windows.Forms.GroupBox
    Friend WithEvents tablelayoutViewing As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tablelayoutMisc As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tablelayoutGrades As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents mainpanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents grpClassDATA As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ChangeColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchedulesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassStandingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
