Imports System.Xml.Serialization

Public Class c_SmallQuestion

    Private Number As UInt32
    Private Question As String
    Private Answers(4) As String
    Private CorrectAnswer As String

    Public Sub New()

    End Sub

    Public Sub New(ByRef QuestionNumber As UInt32, ByRef Question As String, ByRef D1 As String, ByRef D2 As String, ByRef D3 As String, ByRef D4 As String, ByRef CorrectAnswer As String)
        With Me
            .Number = QuestionNumber
            .Question = Question
            .Answers(0) = D1
            .Answers(1) = D2
            .Answers(2) = D3
            .Answers(3) = D4
            .CorrectAnswer = CorrectAnswer
        End With
    End Sub

    <XmlElementAttribute("QuestionNumber")>
    Public Property QuestionNumber As UInt32
        Get
            Return Number
        End Get
        Set(value As UInt32)
            Number = value
        End Set
    End Property
    <XmlElementAttribute("QuestionBase")>
    Public Property QuestionBase As String
        Get
            Return Question
        End Get
        Set(value As String)
            Question = value
        End Set
    End Property
    <XmlElementAttribute("Distractor1")>
    Public Property Distractor1 As String
        Get
            Return Answers(0)
        End Get
        Set(value As String)
            Answers(0) = value
        End Set
    End Property
    <XmlElementAttribute("Distractor2")>
    Public Property Distractor2 As String
        Get
            Return Answers(1)
        End Get
        Set(value As String)
            Answers(1) = value
        End Set
    End Property
    <XmlElementAttribute("Distractor3")>
    Public Property Distractor3 As String
        Get
            Return Answers(2)
        End Get
        Set(value As String)
            Answers(2) = value
        End Set
    End Property
    <XmlElementAttribute("Distractor4")>
    Public Property Distractor4 As String
        Get
            Return Answers(3)

        End Get
        Set(value As String)
            Answers(3) = value
        End Set
    End Property
    <XmlElementAttribute("TrueAnswer")>
    Public Property TrueAnswer As String
        Get
            Return CorrectAnswer
        End Get
        Set(value As String)
            CorrectAnswer = value
        End Set
    End Property

End Class
