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
        Me.btnClassroomHub = New System.Windows.Forms.Button()
        Me.btnTimeManagement = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnCreateExam = New System.Windows.Forms.Button()
        Me.btnCreateMaterials = New System.Windows.Forms.Button()
        Me.btnCreateArticles = New System.Windows.Forms.Button()
        Me.btnCreateQuestionnaire = New System.Windows.Forms.Button()
        Me.btnLessonList = New System.Windows.Forms.Button()
        Me.btnRanking = New System.Windows.Forms.Button()
        Me.btnGrades = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClassroomHub
        '
        Me.btnClassroomHub.Location = New System.Drawing.Point(12, 12)
        Me.btnClassroomHub.Name = "btnClassroomHub"
        Me.btnClassroomHub.Size = New System.Drawing.Size(138, 23)
        Me.btnClassroomHub.TabIndex = 0
        Me.btnClassroomHub.Text = "Classroom"
        Me.btnClassroomHub.UseVisualStyleBackColor = True
        '
        'btnTimeManagement
        '
        Me.btnTimeManagement.Location = New System.Drawing.Point(12, 41)
        Me.btnTimeManagement.Name = "btnTimeManagement"
        Me.btnTimeManagement.Size = New System.Drawing.Size(138, 23)
        Me.btnTimeManagement.TabIndex = 1
        Me.btnTimeManagement.Text = "Time Management"
        Me.btnTimeManagement.UseVisualStyleBackColor = True
        '
        'btnFeedback
        '
        Me.btnFeedback.Location = New System.Drawing.Point(12, 70)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(138, 23)
        Me.btnFeedback.TabIndex = 2
        Me.btnFeedback.Text = "Feedback"
        Me.btnFeedback.UseVisualStyleBackColor = True
        '
        'btnCreateExam
        '
        Me.btnCreateExam.Location = New System.Drawing.Point(12, 226)
        Me.btnCreateExam.Name = "btnCreateExam"
        Me.btnCreateExam.Size = New System.Drawing.Size(138, 23)
        Me.btnCreateExam.TabIndex = 26
        Me.btnCreateExam.Text = "Create Exam"
        Me.btnCreateExam.UseVisualStyleBackColor = True
        '
        'btnCreateMaterials
        '
        Me.btnCreateMaterials.Location = New System.Drawing.Point(12, 197)
        Me.btnCreateMaterials.Name = "btnCreateMaterials"
        Me.btnCreateMaterials.Size = New System.Drawing.Size(138, 23)
        Me.btnCreateMaterials.TabIndex = 25
        Me.btnCreateMaterials.Text = "Create Materials"
        Me.btnCreateMaterials.UseVisualStyleBackColor = True
        '
        'btnCreateArticles
        '
        Me.btnCreateArticles.Location = New System.Drawing.Point(12, 168)
        Me.btnCreateArticles.Name = "btnCreateArticles"
        Me.btnCreateArticles.Size = New System.Drawing.Size(138, 23)
        Me.btnCreateArticles.TabIndex = 24
        Me.btnCreateArticles.Text = "Create Articles"
        Me.btnCreateArticles.UseVisualStyleBackColor = True
        '
        'btnCreateQuestionnaire
        '
        Me.btnCreateQuestionnaire.Location = New System.Drawing.Point(12, 139)
        Me.btnCreateQuestionnaire.Name = "btnCreateQuestionnaire"
        Me.btnCreateQuestionnaire.Size = New System.Drawing.Size(138, 23)
        Me.btnCreateQuestionnaire.TabIndex = 23
        Me.btnCreateQuestionnaire.Text = "Create Questionnaire"
        Me.btnCreateQuestionnaire.UseVisualStyleBackColor = True
        '
        'btnLessonList
        '
        Me.btnLessonList.Location = New System.Drawing.Point(156, 12)
        Me.btnLessonList.Name = "btnLessonList"
        Me.btnLessonList.Size = New System.Drawing.Size(137, 23)
        Me.btnLessonList.TabIndex = 27
        Me.btnLessonList.Text = "Lesson List"
        Me.btnLessonList.UseVisualStyleBackColor = True
        '
        'btnRanking
        '
        Me.btnRanking.Location = New System.Drawing.Point(253, 300)
        Me.btnRanking.Name = "btnRanking"
        Me.btnRanking.Size = New System.Drawing.Size(137, 23)
        Me.btnRanking.TabIndex = 28
        Me.btnRanking.Text = "Ranking"
        Me.btnRanking.UseVisualStyleBackColor = True
        '
        'btnGrades
        '
        Me.btnGrades.Location = New System.Drawing.Point(253, 271)
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.Size = New System.Drawing.Size(137, 23)
        Me.btnGrades.TabIndex = 29
        Me.btnGrades.Text = "Grades"
        Me.btnGrades.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 335)
        Me.Controls.Add(Me.btnGrades)
        Me.Controls.Add(Me.btnRanking)
        Me.Controls.Add(Me.btnLessonList)
        Me.Controls.Add(Me.btnCreateExam)
        Me.Controls.Add(Me.btnCreateMaterials)
        Me.Controls.Add(Me.btnCreateArticles)
        Me.Controls.Add(Me.btnCreateQuestionnaire)
        Me.Controls.Add(Me.btnFeedback)
        Me.Controls.Add(Me.btnTimeManagement)
        Me.Controls.Add(Me.btnClassroomHub)
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClassroomHub As System.Windows.Forms.Button
    Friend WithEvents btnTimeManagement As System.Windows.Forms.Button
    Friend WithEvents btnFeedback As System.Windows.Forms.Button
    Friend WithEvents btnCreateExam As System.Windows.Forms.Button
    Private WithEvents btnCreateMaterials As System.Windows.Forms.Button
    Private WithEvents btnCreateArticles As System.Windows.Forms.Button
    Private WithEvents btnCreateQuestionnaire As System.Windows.Forms.Button
    Friend WithEvents btnLessonList As System.Windows.Forms.Button
    Friend WithEvents btnRanking As System.Windows.Forms.Button
    Friend WithEvents btnGrades As System.Windows.Forms.Button
End Class
