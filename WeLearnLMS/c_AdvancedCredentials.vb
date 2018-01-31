Public Class c_AdvancedCredentials
    Inherits c_MainCredentials
    Private _UserFirstName As String
    Private _UserMiddleName As String
    Private _UserLastName As String
    Private _UserGender As Gender
    Private _UserCellularNumber As String
    Private _UserLandline As String
    Private _UserAddress As String
    Private _UserEmail As String
    Private _UserAge As UInt32
    Private _UserCitizenship As String
    Private _UserDOB As Date
    Private _QuestionIndex As UInt32
    Private _QuestionAnswer As String

    Public Sub New()
        MyBase.New()
        With Me
            ._UserAddress = Nothing
            ._UserCellularNumber = Nothing
            ._UserEmail = Nothing
            ._UserFirstName = Nothing
            ._UserLandline = Nothing
            ._UserLastName = Nothing
            ._UserMiddleName = Nothing
        End With
    End Sub

    Friend Property UserDOB As Date
        Get
            Return _UserDOB
        End Get
        Set(value As Date)
            _UserDOB = value
        End Set
    End Property

    Friend Property UserAge As UInt32
        Get
            Return _UserAge
        End Get
        Set(value As UInt32)
            _UserAge = value
        End Set
    End Property

    Friend Property Citizenship As String
        Get
            Return _UserCitizenship
        End Get
        Set(value As String)
            _UserCitizenship = value
        End Set
    End Property

    Friend Property SaltedAnswer As String
        Get
            Return _QuestionAnswer
        End Get
        Set(value As String)
            _QuestionAnswer = value
        End Set
    End Property

    Friend Property QuestionIndex As UInt32
        Get
            Return _QuestionIndex
        End Get
        Set(value As UInt32)
            _QuestionIndex = value
        End Set
    End Property

    Friend Property UserFirstName As String
        Get
            Return _UserFirstName
        End Get
        Set(value As String)
            _UserFirstName = value
        End Set
    End Property

    Friend Property UserMiddleName As String
        Get
            Return _UserMiddleName
        End Get
        Set(value As String)
            _UserMiddleName = value
        End Set
    End Property

    Friend Property UserLastName As String
        Get
            Return _UserLastName
        End Get
        Set(value As String)
            _UserLastName = value
        End Set
    End Property

    Friend Property UserCellularNumber As String
        Get
            Return _UserCellularNumber
        End Get
        Set(value As String)
            _UserCellularNumber = value
        End Set
    End Property

    Friend Property UserLandline As String
        Get
            Return _UserLandline
        End Get
        Set(value As String)
            _UserLandline = value
        End Set
    End Property

    Friend Property UserAddress As String
        Get
            Return _UserAddress
        End Get
        Set(value As String)
            _UserAddress = value
        End Set
    End Property

    Friend Property UserEmail As String
        Get
            Return _UserEmail
        End Get
        Set(value As String)
            _UserEmail = value
        End Set
    End Property

    Friend Property UserGender As Gender
        Get
            Return _UserGender
        End Get
        Set(value As Gender)
            _UserGender = value
        End Set
    End Property
End Class
