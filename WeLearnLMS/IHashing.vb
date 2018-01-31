Public Interface IHashing
    Function HashThis(ByRef password As String, ByRef salt As String) As String
End Interface
