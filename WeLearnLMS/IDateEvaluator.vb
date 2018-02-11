Public Interface IDateEvaluator
    ''' <summary>
    ''' Check if the Unknown Day is Equzl to the Known Day
    ''' </summary>
    ''' <param name="UnknownDay">Date of the Unknown</param>
    ''' <param name="KnownDay">Date of the Known</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Evaluated(ByVal UnknownDay As DayOfWeek, ByVal KnownDay As DayOfWeek) As Boolean
End Interface
