Public Class c_ClassroomLifespan
    Private _DateStart As DateTime
    Private _DateEnd As DateTime
    Private _ClassroomID As String

    Public Sub New()

    End Sub
    Public Sub New(ByRef DateStart As DateTime, ByRef DateEnd As DateTime, ByRef ClassroomID As String)
        With Me
            ._DateEnd = DateEnd
            ._DateStart = DateStart
            ._ClassroomID = ClassroomID
        End With
    End Sub

    Friend Property DateStart As DateTime
        Get
            Return _DateStart
        End Get
        Set(value As DateTime)
            _DateStart = value
        End Set
    End Property

    Friend Property DateEnd As DateTime
        Get
            Return _DateEnd
        End Get
        Set(value As DateTime)
            _DateEnd = value
        End Set
    End Property

    Friend Property ClassroomID As String
        Get
            Return _ClassroomID
        End Get
        Set(value As String)
            _ClassroomID = value
        End Set
    End Property
End Class
