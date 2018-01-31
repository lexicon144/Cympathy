Public Class ImpQuestionAmount_PEXAM
    Implements IQuestionAmount

    Friend Function Validated(Amount As UInteger) As Boolean Implements IQuestionAmount.Validated
        If ((Amount <= 109) And (Amount >= 100)) Then
            'Formatting is MAXIMUM then MINIMUM
            'If the Amount is DAIJOBU then execute this data here
            Return True
            Exit Function
        End If
        Return False
    End Function
End Class
