Public Class context_QuestionAmount
    Private _Strategies As New Dictionary(Of QType, IQuestionAmount)
    Friend Sub New()
        With _Strategies
            .Add(QType.OEXAM, New ImpQuestionAmount_PEXAM)
            .Add(QType.PEXAM, New ImpQuestionAmount_PEXAM)
            .Add(QType.SQUIZ, New ImpQuestionAmount_SQUIZ)
        End With
    End Sub

    Friend Function Validate(ByVal QuestionnaireType As QType, ByRef Amount As UInt32) As Boolean
        Return _Strategies(QuestionnaireType).Validated(Amount)
    End Function
End Class
