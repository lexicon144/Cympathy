Imports System.Xml.Serialization

Public Class c_Questionnaire
    Protected _QuestionBase As List(Of c_SmallQuestion)
    Protected _QuestionsName As String
    Protected _QuestionID As String
    Protected _QType As QType
    Protected _Safe As Boolean = True

    Public Sub New()
        With Me
            ._QuestionBase = Nothing
            ._QuestionID = Nothing
            ._QuestionsName = Nothing
        End With
    End Sub

    <XmlElementAttribute("QuestionnaireType")>
    Public Property QuestionnaireType As QType
        Get
            Return _QType
        End Get
        Set(value As QType)
            _QType = value
        End Set
    End Property

    <XmlElementAttribute("QuestionBase")>
    Public Property QuestionBase As List(Of c_SmallQuestion)
        Get
            If _Safe Then
                Return _QuestionBase
                Exit Property
            End If
            Return Nothing
        End Get
        Set(value As List(Of c_SmallQuestion))
            _QuestionBase = value
        End Set
    End Property

    <XmlElementAttribute("QuestionnaireName")>
    Public Property QuestionnaireName As String
        Get
            If _Safe Then
                Return _QuestionsName
                Exit Property
            End If
            Return "NOTSAFE"
        End Get
        Set(value As String)
            _QuestionsName = value
        End Set
    End Property

    <XmlElementAttribute("QuestionnaireID")>
    Public Property QuestionnaireID As String
        Get

            If _Safe Then
                Return _QuestionID
                Exit Property
            End If
            Return "NOTSAFE"
        End Get
        Set(value As String)
            _QuestionID = value
        End Set
    End Property

End Class
