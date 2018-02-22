Public Class frmGradesPreCompiler

    Private _QuizCompiledGrades As Double
    Private _ExamCompiledGrades As Double
    Private _Attendance As Double

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "Properties"
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
#End Region

    Friend Function CompileAllGrades(ByVal QuizCompiledGrades As Double, ByVal ExamCompiledGrades As Double, ByVal Attendance As Double) As Double

        Return ((QuizCompiledGrades * 0.4) + (ExamCompiledGrades * 0.5) + (Attendance * 0.1))

    End Function

    Friend Function CompileAllGrades() As Double
        Return ((Me._QuizCompiledGrades * 0.4) + (Me._ExamCompiledGrades * 0.5) + (Me._Attendance * 0.1))

    End Function

    Private Sub frmGradesPreCompiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
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

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me._ExamCompiledGrades = ExamComputer()
        BackgroundWorker1.ReportProgress(50)

        Me._QuizCompiledGrades = QuizComputer()
        BackgroundWorker1.ReportProgress(100)
    End Sub

    Friend Function QuizComputer() As Double
        Using Computer As New frmGradesQuizComputer
            With Computer
                Return .ReturnFullAverage
            End With
        End Using
    End Function

    Friend Function ExamComputer() As Double
        Using Computer As New frmGradeExamComputer
            With Computer
                Return .ReturnFullAverage
            End With
        End Using
    End Function


    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Me.backgroundProgress.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        WriteOut()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class