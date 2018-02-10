Public Class ImpHappyMessage
    Implements IHappyMessage
    Private ListOfMessages As New List(Of String)

    Public Sub New()
        Try

            Dim fStream As New System.IO.FileStream(Application.StartupPath & "\monikalovesyou.txt", IO.FileMode.Open)
            Dim sReader As New System.IO.StreamReader(fStream)

            Do While sReader.Peek >= 0
                ListOfMessages.Add(sReader.ReadLine)
            Loop

        Catch ex As Exception
            Console.WriteLine(ex.Message & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Friend Function GetMyHappyMessage() As String Implements IHappyMessage.GetMyHappyMessage
        Dim rnd As New Random()
        Return ListOfMessages(rnd.Next(0, ListOfMessages.Count))
    End Function
End Class
