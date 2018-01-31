Public Class frmStudyLinker

    Private _Questionnaire As New c_Questionnaire
    Private _Classroom As New c_Classroom

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef ThisQuiz As c_Questionnaire, ByRef ThisClassroom As c_Classroom)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._Questionnaire = ThisQuiz
            ._Classroom = ThisClassroom
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
                        .CommandText = "InsertLinkQuizToClass"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = Connection
                        With .Parameters
                            .AddWithValue("ClassroomID", _Classroom.ClassroomId)
                            .AddWithValue("QuizID", _Questionnaire.QuestionnaireID)
                        End With
                        .ExecuteNonQuery()
                    End With
                    ArticleLinkingTransaction.Commit()
                    MessageBox.Show("Article Linking from " & _Classroom.ClassroomName & " ON " & _Questionnaire.QuestionnaireName & " has been committed successfully", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Using
            Catch Exx As Exception
                ArticleLinkingTransaction.Rollback()
                MessageBox.Show("Article Linking from " & _Classroom.ClassroomName & " ON " & _Questionnaire.QuestionnaireName & " has been performed unsuccessfully. Rolledback automaticaly", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End Using
    End Sub

    Private Sub ViewThisArticle()

        MessageBox.Show("Article ID: " & _Questionnaire.QuestionnaireID & vbNewLine & "Article Name: " & _Questionnaire.QuestionnaireName & vbNewLine, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ViewThisClassroom()

        MessageBox.Show("Classroom ID: " & _Classroom.ClassroomId & vbNewLine & "Classroom Name: " & _Classroom.ClassroomName & vbNewLine, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub frmStudyLinker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .txtClassroomID.Text = _Classroom.ClassroomId
            .txtClassroomName.Text = _Classroom.ClassroomName
            .txtQuizID.Text = _Questionnaire.QuestionnaireID
            .txtQuizName.Text = _Questionnaire.QuestionnaireName
        End With
    End Sub
End Class