Imports System.Xml.Serialization

Public Class c_Questionnaire
    Protected _QuestionBase As List(Of c_SmallQuestion)
    Protected _QuestionsName As String
    Protected _QuestionID As String
    Protected _QType As QType

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
                Return _QuestionBase
            Return Nothing
        End Get
        Set(value As List(Of c_SmallQuestion))
            _QuestionBase = value
        End Set
    End Property

    <XmlElementAttribute("QuestionnaireName")>
    Public Property QuestionnaireName As String
        Get
                Return _QuestionsName
        End Get
        Set(value As String)
            _QuestionsName = value
        End Set
    End Property

    <XmlElementAttribute("QuestionnaireID")>
    Public Property QuestionnaireID As String
        Get

                Return _QuestionID
        End Get
        Set(value As String)
            _QuestionID = value
        End Set
    End Property

End Class
