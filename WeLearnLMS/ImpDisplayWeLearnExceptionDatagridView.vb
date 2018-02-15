Public Class ImpDisplayWeLearnExceptionDatagridView
    Implements IDisplayWeLearnException

    Public Sub DisplayMessage(ByRef XXX As Exception, ByRef Owner As Object) Implements IDisplayWeLearnException.DisplayMessage
        Dim builder As New StringBuilder
        With builder
            .AppendLine("Error Loading The Datagridview")
            .AppendLine(vbNewLine)
            .AppendLine("Reason: ")
            .AppendLine(XXX.Message)
        End With
        MessageBox.Show(builder.ToString, Owner.ToString, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
