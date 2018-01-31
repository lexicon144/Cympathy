Public Class c_Time
    Protected _TimeID As String
    Protected _TimeStart As String
    Protected _TimeDescription As String

    Public Sub New()
        With Me
            ._TimeDescription = Nothing
            ._TimeID = Nothing
            ._TimeDescription = Nothing
        End With
    End Sub

    Protected Friend Property TimeDescription As String
        Get
            Return _TimeDescription
        End Get
        Set(value As String)
            _TimeDescription = value
        End Set
    End Property
    Protected Friend Property TimeID As String
        Get
            Return _TimeID
        End Get
        Set(value As String)
            _TimeID = value
        End Set
    End Property

    Protected Friend Property TimeStart As String
        Get
            Return _TimeStart
        End Get
        Set(value As String)
            _TimeStart = value
        End Set
    End Property

    Protected Friend Function TimeEnd() As String
        Return _TimeStart + 1
    End Function

End Class
