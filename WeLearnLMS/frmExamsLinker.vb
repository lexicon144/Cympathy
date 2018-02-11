Public Class frmExamsLinker

    Private _Exam As New c_Questionnaire
    Private _Classroom As New c_Classroom

    Public Sub New(ByRef Exam As c_Questionnaire, ByRef Classroom As c_Classroom)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._Exam = Exam
            ._Classroom = Classroom
        End With
    End Sub

    Public Sub New(ByRef Classroom As c_Classroom)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._Classroom = Classroom
        End With
    End Sub
    Friend WriteOnly Property SetExam As c_Exam
        Set(value As c_Exam)
            Me._Exam = value
        End Set
    End Property

    Private Sub frmExamsLinker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Hub As New frmExamsHub()
        If Hub.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me._Exam = Hub.RetrieveExam
        End If

    End Sub

    Private Sub Prepare()

        With Me
            .txtClassroomID.Text = _Classroom.ClassroomId
            .txtClassroomName.Text = _Classroom.ClassroomName
            .txtExamID.Text = _Exam.QuestionnaireID
            .txtExamName.Text = _Exam.QuestionnaireName
        End With
    End Sub

    Private Sub PerformTheLink()
        Using Connection As New MySqlConnection

            With Connection
                .ConnectionString = _SharedConnString.ConnString
            End With
            Dim ArticleLinkingTransaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand

                    With Command
                        .CommandText = "InsertLinkExamsToClass"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = Connection
                        With .Parameters
                            .AddWithValue("ClassroomID", _Classroom.ClassroomId)
                            .AddWithValue("ExamID", _Exam.QuestionnaireID)
                        End With
                        .ExecuteNonQuery()
                    End With
                    ArticleLinkingTransaction.Commit()
                    MessageBox.Show("Exam Linking from " & _Classroom.ClassroomName & " ON " & _Exam.QuestionnaireName & " has been committed successfully", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Using
            Catch Exx As Exception
                ArticleLinkingTransaction.Rollback()
                'MessageBox.Show("Exam Linking from " & _Classroom.ClassroomName & " ON " & _Exam.QuestionnaireName & " has been performed unsuccessfully. Rolledback automaticaly", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DisplayLinkingTransactionFailed(Exx)
            End Try
        End Using
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PerformTheLink()
    End Sub
End Class