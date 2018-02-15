Public Class ImpDisplayWeLearnExceptionSimple
    Implements IDisplayWeLearnException

    Public Sub DisplayMessage(ByRef XXX As Exception, ByRef Owner As Object) Implements IDisplayWeLearnException.DisplayMessage
        Dim NewMessage As New StringBuilder()
        With NewMessage
            .AppendLine("General Exception Occured!")
            .AppendLine(vbNewLine)
            .AppendLine("Reasons: ")
            .AppendLine(XXX.Message)
            .AppendLine(vbNewLine)
            .AppendLine("Owner: ")
            .AppendLine(Owner.ToString)
        End With
        MessageBox.Show(NewMessage.ToString, Owner.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub
End Class
