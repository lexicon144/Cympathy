Public Class ImpEndSession
    Implements IEndSession

    ''' <summary>
    ''' Completely End Session
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub EndMySession() Implements IEndSession.EndMySession
        If System.IO.File.Exists(Application.StartupPath & "\foo\*.nyooom") Then
            
            Console.WriteLine("Clearing NYOOOM Session")

            System.IO.File.Delete(Application.StartupPath & "\foo\*.nyooom")

            Console.WriteLine("NYOOOM!")
        End If
    End Sub
End Class
