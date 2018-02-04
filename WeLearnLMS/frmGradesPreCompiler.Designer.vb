<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradesPreCompiler
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
        Me.btnCompilePreQuizGrades = New System.Windows.Forms.Button()
        Me.btnCompilePreGradeExams = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCompilePreQuizGrades
        '
        Me.btnCompilePreQuizGrades.Location = New System.Drawing.Point(12, 12)
        Me.btnCompilePreQuizGrades.Name = "btnCompilePreQuizGrades"
        Me.btnCompilePreQuizGrades.Size = New System.Drawing.Size(104, 23)
        Me.btnCompilePreQuizGrades.TabIndex = 0
        Me.btnCompilePreQuizGrades.Text = "Quiz Grades"
        Me.btnCompilePreQuizGrades.UseVisualStyleBackColor = True
        '
        'btnCompilePreGradeExams
        '
        Me.btnCompilePreGradeExams.Location = New System.Drawing.Point(12, 61)
        Me.btnCompilePreGradeExams.Name = "btnCompilePreGradeExams"
        Me.btnCompilePreGradeExams.Size = New System.Drawing.Size(104, 23)
        Me.btnCompilePreGradeExams.TabIndex = 1
        Me.btnCompilePreGradeExams.Text = "Exam Grades"
        Me.btnCompilePreGradeExams.UseVisualStyleBackColor = True
        '
        'frmGradesPreCompiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCompilePreGradeExams)
        Me.Controls.Add(Me.btnCompilePreQuizGrades)
        Me.Name = "frmGradesPreCompiler"
        Me.Text = "frmGradesPreCompiler"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCompilePreQuizGrades As System.Windows.Forms.Button
    Friend WithEvents btnCompilePreGradeExams As System.Windows.Forms.Button
End Class
