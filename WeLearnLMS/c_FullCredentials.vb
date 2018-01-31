Public Class c_FullCredentials
    Private _MCredentials As New c_MainCredentials
    Private _ACredentials As New c_AdvancedCredentials

    Public Sub New()

    End Sub

    Friend Property MainCredentials As c_MainCredentials
        Get
            Return _MCredentials
        End Get
        Set(value As c_MainCredentials)
            _MCredentials = value
        End Set
    End Property

    Friend Property AdvancedCredentials As c_AdvancedCredentials
        Get
            Return _ACredentials
        End Get
        Set(value As c_AdvancedCredentials)
            _ACredentials = value

        End Set
    End Property

End Class
