Public Class frmArticleLinker

    Private _Article As New c_Article
    Private _Classroom As New c_Classroom

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef Article As c_Article, ByRef Classroom As c_Classroom)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        With Me
            ._Article = Article
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

    Friend WriteOnly Property SetArticle As c_Article
        Set(value As c_Article)
            Me._Article = value
        End Set
    End Property

    Private Sub frmArticleLinker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Hub As New frmArticleHub()

        If Hub.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me._Article = Hub.RetrieveArticle
        End If

        With Me
            .txtArticleID.Text = ._Article.ArticleID
            .txtArticleName.Text = ._Article.ArticleName
            .txtClassroomID.Text = ._Classroom.ClassroomId
            .txtClassroomName.Text = ._Classroom.ClassroomName
        End With
    End Sub

    Private Sub ViewThisArticle()

        MessageBox.Show("Article ID: " & _Article.ArticleID & vbNewLine & "Article Name: " & _Article.ArticleName & vbNewLine, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ViewThisClassroom()

        MessageBox.Show("Classroom ID: " & _Classroom.ClassroomId & vbNewLine & "Classroom Name: " & _Classroom.ClassroomName & vbNewLine, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub PerformTheLink()
        Using Connection As New MySqlConnection

            With Connection
                .ConnectionString = _SharedConnString.ConnString
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Dim ArticleLinkingTransaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand

                    With Command
                        .CommandText = "InsertLinkArticleToClass"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = Connection
                        With .Parameters
                            .AddWithValue("ClassroomID", _Classroom.ClassroomId)
                            .AddWithValue("ArticleID", _Article.ArticleID)
                        End With
                        .ExecuteNonQuery()
                    End With
                    ArticleLinkingTransaction.Commit()
                    MessageBox.Show("Article Linking from " & _Classroom.ClassroomName & " ON " & _Article.ArticleName & " has been committed successfully", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Using
            Catch Exx As Exception
                ArticleLinkingTransaction.Rollback()
                'MessageBox.Show("Article Linking from " & _Classroom.ClassroomName & " ON " & _Article.ArticleName & " has been performed unsuccessfully. Rolledback automatically " & vbNewLine & Exx.Message, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DisplayLinkingTransactionFailed(Exx)
            End Try
        End Using
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PerformTheLink()
        LinkLabel1.Enabled = False
    End Sub
End Class