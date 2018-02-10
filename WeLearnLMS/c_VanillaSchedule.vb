Public Class c_VanillaSchedule
    Private _Day As DayOfWeek
    Private _ClassroomID As String
    Private _Hour As Integer
    Private _HourEnd As Integer
    Public Sub New()

    End Sub
    Public Sub New(ByVal Day As DayOfWeek, ByVal Hour As Integer, ByVal HourEnd As Integer, ByVal ClassroomID As String)
        With Me
            ._Day = Day
            ._Hour = Hour
            ._ClassroomID = ClassroomID
            ._HourEnd = HourEnd
        End With
    End Sub

    Friend Property Day As DayOfWeek
        Get
            Return _Day
        End Get
        Set(value As DayOfWeek)
            Me._Day = value
        End Set
    End Property

    Friend Property Hour As Integer
        Get
            Return _Hour
        End Get
        Set(value As Integer)
            Me._Hour = value
        End Set
    End Property

    Friend Property HourEnd As Integer
        Get
            Return Me._HourEnd
        End Get
        Set(value As Integer)
            Me._HourEnd = value
        End Set
    End Property

    Friend Property ClassroomID As String
        Get
            Return _ClassroomID
        End Get
        Set(value As String)
            Me._ClassroomID = value
        End Set
    End Property


End Class
