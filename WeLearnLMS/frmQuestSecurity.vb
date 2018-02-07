Public Class frmQuestSecurity

    Private _CorrectPIN As String
    Private _PassState As Boolean

    Private C_Exam As New c_Exam
    Private C_Quiz As New c_Quiz
    Private _IsExam As Boolean
    Private _UserID As String

    Private _ExamMarked As Boolean = True

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(ByRef UserID As String, ByRef Quiz As c_Quiz)
        InitializeComponent()
        Me._IsExam = False
        Me._UserID = UserID
    End Sub

    Public Sub New(ByRef UserID As String, ByRef Exam As c_Exam)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.C_Exam = Exam
        Me._UserID = UserID
        Me._IsExam = True
    End Sub

    Friend ReadOnly Property PassState As Boolean
        Get
            Return _PassState
        End Get
    End Property

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        _PassState = (C_Exam.PIN = TextBox1.Text)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmQuestSecurity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class