Imports System.Text.RegularExpressions

Public Class StrategyVerifyVerySimiple
    Implements IVerifyTextInput

    Public Sub New()
        Console.WriteLine("Instantiated " & Me.ToString)
    End Sub
    ''' <summary>
    ''' Verifies if string is an Acceptable Characters 
    ''' </summary>
    ''' <param name="Subject">STRING to Regulate</param>
    ''' <remarks></remarks>
    Public Function Verify(ByVal Subject As String) As Boolean Implements IVerifyTextInput.Verify
        Dim regulator As New Regex("/^(.+)$/")
        Return regulator.IsMatch(Subject)
    End Function
End Class
