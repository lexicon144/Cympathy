Public Class ContextQuestMarker
    Private _Strategies As New Dictionary(Of Marker, IMarkQuestionnaire)
    Public Sub New()
        With _Strategies
            .Add(Marker.Exam, New ImpMarkQuestionnaireExam)
            .Add(Marker.Quiz, New ImpMarkQuestionnaireQuiz)
        End With
    End Sub

    Friend Sub MarkThis(ByVal Method As Marker, ByRef UserID As String, ByRef QuestID As String)
        Me._Strategies(Method).MarkThisQuest(UserID, QuestID)
    End Sub
End Class
