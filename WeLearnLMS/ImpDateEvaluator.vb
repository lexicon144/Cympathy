Public Class ImpDateEvaluator
    Implements IDateEvaluator

    Public Function Evaluated(UnknownDay As DayOfWeek, KnownDay As DayOfWeek) As Boolean Implements IDateEvaluator.Evaluated
        Return (UnknownDay = KnownDay)
    End Function
End Class
