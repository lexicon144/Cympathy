Public Class frmLessonListHub

    Private _ClassroomDT As New DataTable
    Private _ArticleDT As New DataTable
    Private _MaterialsDT As New DataTable
    Private _QuizsDT As New DataTable
    Private _ExamsDT As New DataTable

    Private Const Articles As String = "Articles"
    Private Const Materials As String = "Materials"
    Private Const Quizes As String = "Quizes"
    Private Const Exams As String = "Exams"

    Private _Classroom As New c_Classroom

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' Create via Learning what Classroom is passed
    ''' STate will be
    ''' Browse Contents within the Classroom
    ''' </summary>
    ''' <param name="Classroom"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef Classroom As c_Classroom)
        InitializeComponent()
        Me._Classroom = Classroom
    End Sub

    Friend WriteOnly Property SetMyDatatable As DataTable
        Set(value As DataTable)
            Me._ClassroomDT = value
        End Set
    End Property

    Private Sub LoadAll()
        LoadClassroomNode(Me._Classroom.ClassroomId)
        'LoadArticlesNode(Me._Classroom.ClassroomId)
        'LoadMaterialsNode(Me._Classroom.ClassroomId)
        'LoadQuizNode(Me._Classroom.ClassroomId)
        'LoadExamsNode(Me._Classroom.ClassroomId)
    End Sub

    ''' <summary>
    ''' Select all Classrooms
    ''' present within this datatable
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadClassroomNode(ByRef ClassroomName As String)

        Using ClassroomHUB As New frmClassroomDialog
            With ClassroomHUB
                .ReturnAdminedClasses()
                Me._ClassroomDT = .ThrowMainDatatable()
            End With
        End Using

        If Me._ClassroomDT Is Nothing Then Exit Sub

        For Each row As DataRow In Me._ClassroomDT.Rows
            'If the classroom node doesnt exist yet then
            If Not TreeView1.Nodes.ContainsKey(row("id").ToString) Then
                Dim NewClassroomNode As New TreeNode
                With NewClassroomNode
                    .Name = row("id").ToString
                    .Text = row("class_name").ToString
                    With .Nodes
                        .Add(Articles)
                        .Add(Materials)
                        .Add(Quizes)
                        .Add(Exams)
                    End With
                End With
                TreeView1.Nodes.Add(NewClassroomNode)
            End If
        Next
    End Sub

    Private Sub LoadArticlesNode(ByRef ClassroomName As String)

        Using Articlehub As New frmArticleHub
            With Articlehub
                .LoadAllArticles(ClassroomName)
                Me._ArticleDT = .ThrowMainDatatable()
            End With
        End Using

        If Me._ArticleDT Is Nothing Then Exit Sub

        For Each row As DataRow In Me._ArticleDT.Rows
            'Classroom => [1st Layer] => [2ndLayerHere]
            Dim NewNode As New TreeNode(row("file_name").ToString)
            TreeView1.Nodes(ClassroomName).Nodes(Articles).Nodes.Add(NewNode)
        Next
    End Sub

    Private Sub LoadMaterialsNode(ByRef ClassroomName As String)

        Using MaterialHub As New frmStudyMaterialsHub
            With MaterialHub
                .LoadAllMaterials(ClassroomName)
                Me._MaterialsDT = .ThrowMainDatatable
            End With
        End Using

        If Me._MaterialsDT Is Nothing Then Exit Sub

        For Each row As DataRow In Me._MaterialsDT.Rows
            'Classroom => [1st Layer] => [2ndLayerHere]
            Dim NewNode As New TreeNode(row("m_name").ToString)
            TreeView1.Nodes(ClassroomName).Nodes(Materials).Nodes.Add(NewNode)
        Next
    End Sub

    Private Sub LoadQuizNode(ByRef ClassroomName As String)

        Using QuizHub As New frmQuizHub
            With QuizHub
                .LoadAllClasses(ClassroomName)
                Me._QuizsDT = .ThrowMainDatatable()
            End With
        End Using

        If Me._QuizsDT Is Nothing Then Exit Sub

        For Each row As DataRow In Me._QuizsDT.Rows
            'Classroom => [1st Layer] => [2ndLayerHere]
            Dim NewNode As New TreeNode(row("quest_name").ToString)
            TreeView1.Nodes(ClassroomName).Nodes(Quizes).Nodes.Add(NewNode)
        Next
    End Sub

    Private Sub LoadExamsNode(ByRef ClassroomName As String)

        Using ExamsHub As New frmExamsHub
            With ExamsHub
                .LoadDatagridView(ClassroomName)
                Me._ExamsDT = .ThrowMainDatatable()
            End With
        End Using

        If Me._ExamsDT Is Nothing Then Exit Sub

        For Each row As DataRow In Me._ExamsDT.Rows
            'Classroom => [1st Layer] => [2ndLayerHere]
            Dim NewNode As New TreeNode(row("exam_name").ToString)
            TreeView1.Nodes(ClassroomName).Nodes(Exams).Nodes.Add(NewNode)
        Next
    End Sub

    Private Sub frmLessonListHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAll()

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        RichTextBox1.Text = (TreeView1.SelectedNode.FullPath)
    End Sub
End Class