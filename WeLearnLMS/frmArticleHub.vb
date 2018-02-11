Public Class frmArticleHub

    Private _Datatable As New DataTable

    Private _ThisClassroomID As String

    Private _IsModal As Boolean = False

    Private _ThisArticle As New c_Article

    Private _BrowseAll As Boolean = False

    Friend WriteOnly Property IsModal As Boolean
        Set(value As Boolean)
            _IsModal = True
        End Set
    End Property

    Friend ReadOnly Property RetrieveArticle As c_Article
        Get
            Return Me._ThisArticle
        End Get
    End Property

    Friend ReadOnly Property ThrowMainDatatable As DataTable
        Get
            Return Me._Datatable
        End Get
    End Property

    ''' <summary>
    ''' Modal Constructor for HUB
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._IsModal = True
    End Sub
    ''' <summary>
    ''' Non Modal Constructor
    ''' </summary>
    ''' <param name="ClassroomID"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef ClassroomID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._IsModal = False
        Me._ThisClassroomID = ClassroomID
    End Sub

    Private Sub frmArticleHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me._IsModal Then LoadAllArticles()
        If Not Me._IsModal Then LoadAllArticles(_ThisClassroomID)

        Dim btn As New DataGridViewButtonColumn()

        With btn
            .HeaderText = "Action"
            .Text = "Open"
            .Name = "btn"
            .UseColumnTextForButtonValue = True
        End With

        With DataGridView1
            .DataSource = _Datatable
            .Columns.Add(btn)

            .Columns("file_blob").Visible = False
        End With

    End Sub
    Private Sub dgvArticlesList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then

                With DataGridView1.Rows(e.RowIndex)
                    txtArticleID.Text = .Cells("id").Value.ToString()
                    txtArticleName.Text = .Cells("file_name").Value.ToString()
                    txtArticleBase.Text = System.Text.Encoding.ASCII.GetString(.Cells("file_blob").Value)
                End With

            End If
        End If
    End Sub

    Friend Sub LoadAllArticles()
        Console.WriteLine("Load all Articles")
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SelectAllArticles"

                End With
                Using Adapter As New MySqlDataAdapter
                    With Adapter
                        With Adapter
                            .SelectCommand = Command
                            .Fill(Me._Datatable)
                        End With
                    End With
                End Using
            End Using

        End Using
    End Sub

    Friend Sub LoadAllArticles(ByRef ClassroomID As String)
        Console.WriteLine("Load most Articles")
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SelectArticlesFromThisClass"
                    With .Parameters
                        .AddWithValue("@ClassroomID", ClassroomID)
                    End With
                End With
                Using Adapter As New MySqlDataAdapter

                    With Adapter
                        .SelectCommand = Command
                        .Fill(Me._Datatable)
                    End With
                End Using
            End Using

        End Using
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim ContextualArticle As New c_Article
            ParseFromTextbox(ContextualArticle)
            Dim ArticleViewer As New frmArticleViewer(ContextualArticle)
            ArticleViewer.Show()
        Catch xxx As Exception
            DisplayGeneralException(xxx)
        End Try
    End Sub

    Private Sub ParseFromTextbox()
        With Me._ThisArticle
            .ArticleID = Convert.ToUInt32(txtArticleID.Text)
            .ArticleName = txtArticleName.Text
            .ArticleBase = System.Text.Encoding.ASCII.GetBytes(txtArticleBase.Text)
        End With
    End Sub

    Private Sub ParseFromTextbox(ByRef DimArticle As c_Article)
        With DimArticle
            .ArticleID = Convert.ToUInt32(txtArticleID.Text)
            .ArticleName = txtArticleName.Text
            .ArticleBase = System.Text.Encoding.ASCII.GetBytes(txtArticleBase.Text)
        End With
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ParseFromTextbox()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class