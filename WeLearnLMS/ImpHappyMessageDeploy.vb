Imports System.IO

Public Class ImpHappyMessageDeploy
    Implements IHappyMessage

    Private ListOfMessages As New List(Of String)

    Public Sub New()
        
        Using sr As StreamReader = New StreamReader(My.Resources.monikalovesyou)
            Dim line As String
            line = sr.ReadLine()
            While (line <> Nothing)
                Console.WriteLine(line)
                line = sr.ReadLine()
            End While
        End Using

    End Sub

    Public Function GetMyHappyMessage() As String Implements IHappyMessage.GetMyHappyMessage

        Dim rnd As New Random()
        Return ListOfMessages(rnd.Next(0, ListOfMessages.Count))
    End Function
End Class
