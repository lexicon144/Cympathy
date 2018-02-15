

Public Class frmLessonListHub

    Private _ClassroomDT As New DataTable
    Private _ArticleDT As New DataTable
    Private _MaterialsDT As New DataTable
    Private _QuizsDT As New DataTable
    Private _ExamsDT As New DataTable

    Private _NodeMaker As New ContextMakeLessonListNode()

    Private _Classroom As New c_Classroom
    Private _RootNode As New TreeNode
    Private _FullNodeList As New StringBuilder
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


    Private Sub LoadArticlesNode(ByRef ClassroomID As String)
        Using Articlehub As New frmArticleHub
            With Articlehub
                .LoadAllArticles(ClassroomID)
                Me._ArticleDT = .ThrowMainDatatable()
            End With
        End Using
    End Sub
    Private Sub LoadMaterialsNode(ByRef ClassroomID As String)
        Using MaterialHub As New frmStudyMaterialsHub
            With MaterialHub
                .LoadAllMaterials(ClassroomID)
                Me._MaterialsDT = .ThrowMainDatatable
            End With
        End Using
    End Sub
    Private Sub LoadQuizNode(ByRef ClassroomID As String)
        Using QuizHub As New frmQuizHub
            With QuizHub
                .LoadAllQuizes(ClassroomID)
                Me._QuizsDT = .ThrowMainDatatable()
            End With
        End Using
    End Sub
    Private Sub LoadExamsNode(ByRef ClassroomID As String)
        Using ExamsHub As New frmExamsHub
            With ExamsHub
                .LoadDatagridView(ClassroomID)
                Me._ExamsDT = .ThrowMainDatatable()
            End With
        End Using
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        RichTextBox1.Text = (TreeView1.SelectedNode.FullPath)
    End Sub

    Private Sub frmLessonListHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeViewLoader.RunWorkerAsync()
    End Sub

    Private Sub TreeViewLoader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles TreeViewLoader.DoWork
        With Me._Classroom
            TreeViewLoader.ReportProgress(10)
            LoadArticlesNode(.ClassroomId)
            TreeViewLoader.ReportProgress(20)
            LoadMaterialsNode(.ClassroomId)
            TreeViewLoader.ReportProgress(30)
            LoadExamsNode(.ClassroomId)
            TreeViewLoader.ReportProgress(40)
            LoadQuizNode(.ClassroomId)
        End With
        TreeViewLoader.ReportProgress(50)

        With Me._RootNode
            .Name = Me._Classroom.ClassroomId
            .Text = Me._Classroom.ClassroomName
            With .Nodes
                TreeViewLoader.ReportProgress(60)
                .Add(_NodeMaker.MakeTreeNode(LessonNodeTypes.ARTICLE, Me._ArticleDT))
                TreeViewLoader.ReportProgress(70)
                .Add(_NodeMaker.MakeTreeNode(LessonNodeTypes.EXAM, Me._ExamsDT))
                TreeViewLoader.ReportProgress(80)
                .Add(_NodeMaker.MakeTreeNode(LessonNodeTypes.QUIZ, Me._QuizsDT))
                TreeViewLoader.ReportProgress(90)
                .Add(_NodeMaker.MakeTreeNode(LessonNodeTypes.MATERIAL, Me._MaterialsDT))
            End With
        End With
        TreeViewLoader.ReportProgress(100)
    End Sub

    Private Sub TreeViewLoader_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles TreeViewLoader.ProgressChanged
        Me.backgroundProgressBar.Value = e.ProgressPercentage
    End Sub

    Private Sub TreeViewLoader_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles TreeViewLoader.RunWorkerCompleted
        TreeView1.Nodes.Add(Me._RootNode)
    End Sub

    Private Sub ShowAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllToolStripMenuItem.Click
       
        PrintRecursive(TreeView1.TopNode)
        Me.RichTextBox1.Text = _FullNodeList.ToString
    End Sub

    Private Sub PrintRecursive(ByVal treeNode As TreeNode)
        Me._FullNodeList.AppendLine(treeNode.Text)
        For Each tn As TreeNode In treeNode.Nodes
            PrintRecursive(tn)
        Next
    End Sub

End Class