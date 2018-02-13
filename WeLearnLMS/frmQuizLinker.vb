Public Class frmQuizLinker

    Private _Quiz As New c_Quiz
    Private _Classroom As New c_Classroom

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef ThisQuiz As c_Quiz, ByRef ThisClassroom As c_Classroom)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._Quiz = ThisQuiz
            ._Classroom = ThisClassroom
        End With
    End Sub

    Public Sub New(ByRef ThisClassroom As c_Classroom)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._Classroom = ThisClassroom
        End With
    End Sub

    Friend WriteOnly Property SetQuiz As c_Quiz
        Set(value As c_Quiz)
            Me._Quiz = TryCast(value, c_Questionnaire)
        End Set
    End Property

    Private Sub PerformTheLink()
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)

            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
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
                            .AddWithValue("QuizID", _Quiz.QuestionnaireID)
                        End With
                        .ExecuteNonQuery()
                    End With
                    ArticleLinkingTransaction.Commit()
                    MessageBox.Show("Article Linking from " & _Classroom.ClassroomName & " ON " & _Quiz.QuestionnaireName & " has been committed successfully", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Using
            Catch Exx As Exception
                ArticleLinkingTransaction.Rollback()
                'MessageBox.Show("Article Linking from " & _Classroom.ClassroomName & " ON " & _Quiz.QuestionnaireName & " has been performed unsuccessfully. Rolledback automaticaly. Reason : " & Exx.Message, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DisplayLinkingTransactionFailed(Exx)
            End Try
        End Using
    End Sub


    Private Sub frmQuizLinker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Hub As New frmQuizHub
        If Hub.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me._Quiz = Hub.RetrieveQuiz
        End If
        Prepare()
    End Sub

    Private Sub Prepare()

        With Me
            .txtClassroomID.Text = _Classroom.ClassroomId
            .txtClassroomName.Text = _Classroom.ClassroomName
            .txtQuizID.Text = _Quiz.QuestionnaireID
            .txtQuizName.Text = _Quiz.QuestionnaireName
        End With

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PerformTheLink()
        LinkLabel1.Enabled = False

    End Sub
End Class