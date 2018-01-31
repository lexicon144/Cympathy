Imports System.Text.RegularExpressions
''' <summary>
''' Strategy to verify a USERNAME
''' </summary>
''' <remarks></remarks>
Public Class StrategyVerifyUsername
    Implements IVerifyTextInput

    Public Sub New()
        Console.WriteLine("Instantiated " & Me.ToString)
    End Sub
    ''' <summary>
    ''' Verifies if string is an Acceptable USERNAME 
    ''' </summary>
    ''' <param name="Subject">Keypress Events</param>
    ''' <remarks></remarks>
    Public Function Verify(ByVal Subject As String) As Boolean Implements IVerifyTextInput.Verify
        Dim regulator As New Regex("\w")
        Return regulator.IsMatch(Subject)

    End Function
End Class
