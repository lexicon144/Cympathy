Public Class c_Schedule
    Private _Time As New c_Time
    Private _Classroom As New c_Classroom
    Private _Day As New c_Day

    Public Sub New()

    End Sub

    Friend Property Time As c_Time
        Get
            Return _Time
        End Get
        Set(value As c_Time)
            _Time = value
        End Set
    End Property

    Friend Property Classroom As c_Classroom
        Get
            Return _Classroom
        End Get
        Set(value As c_Classroom)
            _Classroom = value
        End Set
    End Property

    Friend Property Day As c_Day
        Get
            Return _Day
        End Get
        Set(value As c_Day)
            _Day = value
        End Set
    End Property
End Class
