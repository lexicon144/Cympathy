Public Class c_Grades

    Private _ClassroomID As String
    Private _ClassroomName As String
    Private _UserID As String
    Private _UserName As String
    Private _GradeNumber As String

    Public Sub New()

    End Sub

    Friend Property ClassroomID As String
        Get
            Return _ClassroomID
        End Get
        Set(value As String)
            _ClassroomID = value
        End Set
    End Property

    Friend Property ClassroomName As String
        Get
            Return _ClassroomName
        End Get
        Set(value As String)
            _ClassroomName = value
        End Set
    End Property

    Friend Property UserID As String
        Get
            Return _UserID

        End Get
        Set(value As String)
            _UserID = value
        End Set
    End Property

    Friend Property UserName As String
        Get
            Return _UserName
        End Get
        Set(value As String)
            _UserName = value
        End Set
    End Property
End Class
