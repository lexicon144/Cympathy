Public Class c_PreGradeExam
    Inherits c_PreGrade

    Public Sub New()
        MyBase.New()
    End Sub

    Friend Property ExamID As String
        Get
            Return MyBase.QuizID
        End Get
        Set(value As String)
            MyBase.QuizID = value
        End Set
    End Property

End Class
