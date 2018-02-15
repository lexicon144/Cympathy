Public Class ContextWeLearnException
    Private _Strategies As New Dictionary(Of WeLearnExceptions, IDisplayWeLearnException)
    Public Sub New()
        With _Strategies
            .Add(WeLearnExceptions.Simple, New ImpDisplayWeLearnExceptionSimple)
            .Add(WeLearnExceptions.General, New ImpDisplayWeLearnExceptionGeneral)
            .Add(WeLearnExceptions.Linking, New ImpDisplayWeLearnExceptionLinking)
            .Add(WeLearnExceptions.Exam, New ImpDisplayWeLearnExceptionExams)
            .Add(WeLearnExceptions.DGV, New ImpDisplayWeLearnExceptionDatagridView)
        End With
    End Sub

    Friend Sub Display(ByVal ExceptionType As WeLearnExceptions, ByRef Owner As Object, ByRef XXX As Exception)
        Me._Strategies(ExceptionType).DisplayMessage(XXX, Owner)
    End Sub
End Class
