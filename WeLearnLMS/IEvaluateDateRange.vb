''' <summary>
''' Date Range where
''' First Date MUST be LESS than LAST DATE
''' </summary>
''' <remarks></remarks>
Public Interface IEvaluateDateRange
    ''' <summary>
    ''' Check if data has been evaluated
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Evaluated(ByVal StartDate As DateTime, ByVal EndDate As DateTime) As Boolean
        
End Interface
