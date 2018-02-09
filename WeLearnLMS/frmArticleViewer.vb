Public Class frmArticleViewer

    Private _ThisClassroom As c_Classroom
    Private _ThisArticle As New c_Article
    Private _Rtf As String

    ''' <summary>
    ''' Constructor for me
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByRef PassedArticle As c_Article)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._ThisArticle = PassedArticle
    End Sub

    Public Sub New(ByRef ThisClassroom As c_Classroom)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._ThisClassroom = ThisClassroom
        End With
    End Sub

    Private Sub frmArticleViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = Me._ThisArticle.ArticleName
            ConvertBinary()
            DisplayRichText()
        Catch Exx As Exception
            DisplayGeneralException(Exx)
        End Try

    End Sub

    ''' <summary>
    ''' Displays RichTextData from the richtext field of this class
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisplayRichText()
        With Me
            .RichTextBox1.Rtf = ._Rtf
        End With
    End Sub

    Private Sub ConvertBinary()

        If Not _ThisArticle.ArticleBase Is Nothing Then

            _Rtf = System.Text.Encoding.ASCII.GetString(_ThisArticle.ArticleBase)
        End If

    End Sub

    Private Sub DownloadBlob()

    End Sub

End Class