Public Class c_PreGrade
    Private _TotalQuestions As UInt32
    Private _Hits As UInt32

    Public Sub New()
        With Me
            ._Hits = Nothing
            ._TotalQuestions = Nothing
        End With
    End Sub

    Friend Property TotalQuestions As UInt32
        Get
            Return _TotalQuestions
        End Get
        Set(value As UInt32)
            _TotalQuestions = value
        End Set
    End Property

    Friend Property Hits As UInt32
        Get
            Return _Hits
        End Get
        Set(value As UInt32)
            _Hits = value
        End Set
    End Property

    Friend Function ReturnFullAverage() As Double
        Return Math.Round((_Hits / _TotalQuestions), MidpointRounding.AwayFromZero)
    End Function

    Friend Function ReturnFullScore() As Double
        Return Math.Round(((_Hits / _TotalQuestions) * 100), MidpointRounding.AwayFromZero)
    End Function

End Class
