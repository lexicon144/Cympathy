Public Class ImpEvaluateDateRange
    Implements IEvaluateDateRange

    Friend Function Evaluated(StartDate As DateTime, EndDate As DateTime) As Boolean Implements IEvaluateDateRange.Evaluated
        Return (0 > DateTime.Compare(StartDate, EndDate))
    End Function
End Class
