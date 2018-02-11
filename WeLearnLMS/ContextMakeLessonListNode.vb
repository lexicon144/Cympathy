Public Class ContextMakeLessonListNode
    Private _Strategy As New Dictionary(Of LessonNodeTypes, IMakeMyLessonTreeNode)
    Public Sub New()
        With _Strategy
            .Add(LessonNodeTypes.ARTICLE, New ImpMakeArticleNode)
            .Add(LessonNodeTypes.MATERIAL, New ImpMakeMaterialNode)
            .Add(LessonNodeTypes.EXAM, New ImpMakeExamNode)
            .Add(LessonNodeTypes.QUIZ, New ImpMakeQuizNode)
        End With
    End Sub

    Friend Function MakeTreeNode(ByVal NodeType As LessonNodeTypes, ByRef ThisDatatable As DataTable) As TreeNode
        Return Me._Strategy(NodeType).MakeLessonTreeNode(ThisDatatable)
    End Function

End Class
