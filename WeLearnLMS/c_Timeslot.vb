Public Class c_Timeslot
    Private _ID As String
    Private _Time As c_Time
    Private _Classroom As c_Classroom

    Public Sub New()

        With Me
            ._Time = Nothing
            ._Classroom = Nothing
        End With
    End Sub

    Public Sub New(ByRef ThisTime As c_Time, ByRef ThisClassroom As c_Classroom)

        With Me
            ._Time = ThisTime
            ._Classroom = ThisClassroom
        End With
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

    Friend Property TimeslotID As String
        Get
            Return _ID
        End Get
        Set(value As String)
            _ID = value
        End Set
    End Property

End Class
