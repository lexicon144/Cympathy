Public Class ImpDisplayWeLearnExceptionExams
    Implements IDisplayWeLearnException

    Public Sub DisplayMessage(ByRef XXX As Exception, ByRef Owner As Object) Implements IDisplayWeLearnException.DisplayMessage
        Dim NewMessage As New StringBuilder()
        With NewMessage
            .AppendLine("Exam Exception Occured!")
            .AppendLine(vbNewLine)
            .AppendLine("Reasons: ")
            .AppendLine(XXX.Message)
            .AppendLine(vbNewLine)
            .AppendLine("Source: ")
            .AppendLine(XXX.Source)
            .AppendLine(vbNewLine)
            .AppendLine("Stack Trace: ")
            .AppendLine(XXX.StackTrace)
        End With
        MessageBox.Show(NewMessage.ToString, Owner.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub
End Class
