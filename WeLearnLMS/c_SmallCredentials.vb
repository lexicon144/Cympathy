Public Class c_SmallCredentials

    Protected _UserId As String
    Protected _Username As String

    Public Sub New()

    End Sub

    Friend Property UserName As String
        Get
            Return _Username
        End Get
        Set(value As String)
            _Username = value
        End Set
    End Property

    Friend Property UserID As String
        Get
            Return _UserId
        End Get
        Set(value As String)
            _UserId = value
        End Set
    End Property
End Class
