Public Class frmGradesPreCompiler

    Private _QuizCompiledGrades As Double
    Private _ExamCompiledGrades As Double
    Private _Attendance As Double

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Friend ReadOnly Property GetQuizCompiledGrades As Double
        Get
            Return Me._QuizCompiledGrades
        End Get
    End Property

    Friend ReadOnly Property GetExamCompiledGrades As Double
        Get
            Return Me._ExamCompiledGrades
        End Get
    End Property

    Private Sub btnCompilePreGradeExams_Click(sender As Object, e As EventArgs) Handles btnCompilePreGradeExams.Click
        Dim ExamComputer As New frmGradeExamComputer()
        If ExamComputer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me._ExamCompiledGrades = ExamComputer.FullAverage
        End If
        WriteOut()
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
        WriteOut()
    End Sub

    Private Sub frmGradesPreCompiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub WriteOut()
        With Me
            .txtExamsAverage.Text = ._ExamCompiledGrades
            .txtQuizesAverage.Text = ._QuizCompiledGrades
            .txtAttendance.Text = ._Attendance
        End With
    End Sub

    Private Sub frmGradesPreCompiler_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub txtAttendance_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAttendance.Validating
        If Not _SharedValidator.Verify(VMethodology.Numbers, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid Number")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub txtAttendance_Validated(sender As Object, e As EventArgs) Handles txtAttendance.Validated
        Me._Attendance = Convert.ToDouble(txtAttendance.Text)
    End Sub
End Class