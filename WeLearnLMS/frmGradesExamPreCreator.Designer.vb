<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradesExamPreCreator
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpGrade = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGradeFullScore = New System.Windows.Forms.TextBox()
        Me.txtGradeNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpQuiz = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExamName = New System.Windows.Forms.TextBox()
        Me.txtExamID = New System.Windows.Forms.TextBox()
        Me.grpGrade.SuspendLayout()
        Me.grpQuiz.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Label5"
        '
        'grpGrade
        '
        Me.grpGrade.Controls.Add(Me.Label3)
        Me.grpGrade.Controls.Add(Me.txtGradeFullScore)
        Me.grpGrade.Controls.Add(Me.txtGradeNumber)
        Me.grpGrade.Controls.Add(Me.Label4)
        Me.grpGrade.Location = New System.Drawing.Point(218, 12)
        Me.grpGrade.Name = "grpGrade"
        Me.grpGrade.Size = New System.Drawing.Size(200, 75)
        Me.grpGrade.TabIndex = 8
        Me.grpGrade.TabStop = False
        Me.grpGrade.Text = "Grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Full Score"
        '
        'txtGradeFullScore
        '
        Me.txtGradeFullScore.Location = New System.Drawing.Point(94, 19)
        Me.txtGradeFullScore.Name = "txtGradeFullScore"
        Me.txtGradeFullScore.ReadOnly = True
        Me.txtGradeFullScore.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeFullScore.TabIndex = 4
        '
        'txtGradeNumber
        '
        Me.txtGradeNumber.Location = New System.Drawing.Point(94, 45)
        Me.txtGradeNumber.Name = "txtGradeNumber"
        Me.txtGradeNumber.ReadOnly = True
        Me.txtGradeNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeNumber.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Average Number"
        '
        'grpQuiz
        '
        Me.grpQuiz.Controls.Add(Me.Label2)
        Me.grpQuiz.Controls.Add(Me.Label1)
        Me.grpQuiz.Controls.Add(Me.txtExamName)
        Me.grpQuiz.Controls.Add(Me.txtExamID)
        Me.grpQuiz.Location = New System.Drawing.Point(12, 12)
        Me.grpQuiz.Name = "grpQuiz"
        Me.grpQuiz.Size = New System.Drawing.Size(200, 75)
        Me.grpQuiz.TabIndex = 7
        Me.grpQuiz.TabStop = False
        Me.grpQuiz.Text = "Exam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Exam Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Exam ID"
        '
        'txtExamName
        '
        Me.txtExamName.Location = New System.Drawing.Point(94, 46)
        Me.txtExamName.Name = "txtExamName"
        Me.txtExamName.ReadOnly = True
        Me.txtExamName.Size = New System.Drawing.Size(100, 20)
        Me.txtExamName.TabIndex = 1
        '
        'txtExamID
        '
        Me.txtExamID.Location = New System.Drawing.Point(94, 19)
        Me.txtExamID.Name = "txtExamID"
        Me.txtExamID.ReadOnly = True
        Me.txtExamID.Size = New System.Drawing.Size(100, 20)
        Me.txtExamID.TabIndex = 0
        '
        'frmGradesExamPreCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 143)
        Me.Controls.Add(Me.grpGrade)
        Me.Controls.Add(Me.grpQuiz)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmGradesExamPreCreator"
        Me.Text = "frmGradesExamFinalizer"
        Me.grpGrade.ResumeLayout(False)
        Me.grpGrade.PerformLayout()
        Me.grpQuiz.ResumeLayout(False)
        Me.grpQuiz.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grpGrade As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGradeFullScore As System.Windows.Forms.TextBox
    Friend WithEvents txtGradeNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpQuiz As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtExamName As System.Windows.Forms.TextBox
    Friend WithEvents txtExamID As System.Windows.Forms.TextBox
End Class
