Imports System.Xml.Serialization

Public Class c_Exam
    Inherits c_Questionnaire

    Private _Key As String = Nothing
    Private _PIN As String = Nothing

    Public Sub New()
        MyBase.New()
    End Sub

    <XmlElementAttribute("Salt")>
    Public Property Salt As String
        Get
            Return _Key
        End Get
        Set(value As String)
            _Key = value
        End Set
    End Property

    <XmlElementAttribute("PIN")>
    Public Property PIN As String
        Get
            Return _PIN
        End Get
        Set(value As String)
            _PIN = value
        End Set
    End Property

End Class
