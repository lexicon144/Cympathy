Public Class ImpHappyMessageDeploy
    Implements IHappyMessage

    Private ListOfMessages As New List(Of String)

    Public Sub New()
        Try

            Dim fStream As new 
            Dim sReader As New System.IO.StringReader(fStream)

            Do While sReader.Peek >= 0
                ListOfMessages.Add(sReader.ReadLine)
            Loop

        Catch ex As Exception
            Console.WriteLine(ex.Message & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Public Function GetMyHappyMessage() As String Implements IHappyMessage.GetMyHappyMessage

        Dim rnd As New Random()
        Return ListOfMessages(rnd.Next(0, ListOfMessages.Count))
    End Function
End Class
