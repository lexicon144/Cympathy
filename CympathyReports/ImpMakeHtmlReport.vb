Public Class ImpMakeHtmlReport
    Implements IMakeReport

    Public Sub MakeReport(ByRef MyString As String) Implements IMakeReport.MakeReport
        Using Saver As New SaveFileDialog
            With Saver
                .Filter = "HTLM File|*.HTML"
                .Title = "Save the HTML Report"
                If .ShowDialog() = DialogResult.OK Then

                    System.IO.File.WriteAllText(.FileName, MyString)
                End If
            End With
        End Using

    End Sub
End Class
