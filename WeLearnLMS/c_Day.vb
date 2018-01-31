Public Class c_Day
    Private _DayID As String
    Private _DayDesc As String

    Public Sub New()
        With Me
            ._DayDesc = Nothing
            ._DayID = Nothing
        End With
    End Sub

    Friend Property DayID As String
        Get
            Return _DayID
        End Get
        Set(value As String)
            _DayID = value
        End Set
    End Property

    Friend Property Day As String
        Get
            Return _DayDesc
        End Get
        Set(value As String)
            _DayDesc = value
        End Set
    End Property

End Class
