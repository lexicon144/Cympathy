Imports System.Text

Friend Module mod_ExceptionMessage
    Friend Sub DisplayNoDatagridView(ByRef XXX As Exception)
        MessageBox.Show("Error occured in trying to load the datagridview! REason: " & XXX.Message, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Friend Sub DisplayLinkingTransactionFailed(ByRef XXX As Exception)
        Dim NewMessage As New StringBuilder()
        With NewMessage
            .Append("Linking Transaction Failed!")
            .Append(vbNewLine)
            .Append(vbNewLine)
            .Append("Reasons: ")
            .Append(XXX.Message)
            .Append(vbNewLine)
            .Append(vbNewLine)
            .Append("Source: ")
            .Append(XXX.Source)
            .Append(vbNewLine)
            .Append(vbNewLine)
            .Append("Stack Trace: ")
            .Append(XXX.StackTrace)
        End With
        MessageBox.Show(NewMessage.ToString, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Friend Sub DisplayGeneralException(ByRef XXX As Exception)
        Dim NewMessage As New StringBuilder()
        With NewMessage
            .Append("General Exception Caught!")
            .Append(vbNewLine)
            .Append(vbNewLine)
            .Append("Reasons: ")
            .Append(XXX.Message)
            .Append(vbNewLine)
            .Append(vbNewLine)
            .Append("Source: ")
            .Append(XXX.Source)
            .Append(vbNewLine)
            .Append(vbNewLine)
            .Append("Stack Trace: ")
            .Append(XXX.StackTrace)
        End With
        MessageBox.Show(NewMessage.ToString, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

End Module
