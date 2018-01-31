Public Class c_MainCredentials
    Public Enum UserType
        ADM = 0
        PRO = 1
        STU = 2
    End Enum

    Protected _UserId As String
    Protected _Username As String
    Protected _Salt As String
    Protected _SaltedPassword As String
    Protected _UserType As UserType

    Public Sub New()
        Console.WriteLine("New {0}", Me.ToString)
        With Me
            ._UserId = Nothing
            ._Username = Nothing
            ._Salt = Nothing
            ._SaltedPassword = Nothing
        End With
    End Sub


    Protected Friend Property UserName As String
        Get
            Return _Username
        End Get
        Set(value As String)
            _Username = value
        End Set
    End Property

    Protected Friend Property UserID As String
        Get
            Return _UserId
        End Get
        Set(value As String)
            _UserId = value
        End Set
    End Property
    Protected Friend Property UserSalt As String
        Get
            Return _Salt
        End Get
        Set(value As String)
            _Salt = value
        End Set
    End Property

    Protected Friend Property UserSaltedPassword As String
        Get
            Return _SaltedPassword
        End Get
        Set(value As String)
            _SaltedPassword = value
        End Set
    End Property

    Friend Property MyUserType As UserType
        Get
            Return _UserType
        End Get
        Set(value As UserType)
            _UserType = value
        End Set
    End Property

End Class
