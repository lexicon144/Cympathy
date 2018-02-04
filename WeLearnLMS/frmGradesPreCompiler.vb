Public Class frmGradesPreCompiler

    Private _QuizCompiledGrades As Double
    Private _ExamCompiledGrades As Double
    Private _Attendance As Double

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnCompilePreGradeExams_Click(sender As Object, e As EventArgs) Handles btnCompilePreGradeExams.Click
        Dim ExamComputer As New frmGradeExamComputer()
        If ExamComputer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me._ExamCompiledGrades = ExamComputer.FullAverage
        End If

    End Sub

    Friend Function CompileAllGrades(ByVal QuizCompiledGrades As Double, ByVal ExamCompiledGrades As Double, ByVal Attendance As Double) As Double

        Return ((QuizCompiledGrades * 0.4) + (ExamCompiledGrades * 0.5) + (Attendance * 0.1))

    End Function

    Friend Function CompileAllGrades() As Double
        Return ((Me._QuizCompiledGrades * 0.4) + (Me._ExamCompiledGrades * 0.5) + (Me._Attendance * 0.1))

    End Function

    Private Sub btnCompilePreQuizGrades_Click(sender As Object, e As EventArgs) Handles btnCompilePreQuizGrades.Click
        Dim QuizComputer As New frmGradesQuizComputer()
        If QuizComputer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me._QuizCompiledGrades = QuizComputer.FullAverage
        End If
    End Sub
End Class