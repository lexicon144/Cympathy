Public Class ImpMakeArticleNode
    Implements IMakeMyLessonTreeNode

    Friend Function MakeLessonTreeNode(ByRef ThisDatatable As DataTable) As TreeNode Implements IMakeMyLessonTreeNode.MakeLessonTreeNode
        Dim MyRootNode As New TreeNode("Articles")
        Dim TreeNodeList As New List(Of TreeNode)
        For Each row As DataRow In ThisDatatable.Rows
            Dim NewChildTreenode As New TreeNode
            With NewChildTreenode
                .Name = row("id").ToString
                .Text = row("file_name").ToString
            End With
            TreeNodeList.Add(NewChildTreenode)
        Next
        MyRootNode.Nodes.AddRange(TreeNodeList.ToArray)
        Return MyRootNode
    End Function
End Class
