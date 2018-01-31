Imports System.Text.RegularExpressions
''' <summary>
''' Strategy class for providing means of verifying valid NUMBERS
''' </summary>
''' <remarks></remarks>
Public Class StrategyVerifyNumbers
    Implements IVerifyTextInput

    Public Sub New()
        Console.WriteLine("Instantiated " & Me.ToString)
    End Sub
    ''' <summary>
    ''' Verifies if string is an Acceptable Number 
    ''' </summary>
    ''' <param name="Subject">Keypress Events</param>
    ''' <remarks></remarks>
    Public Function Verify(ByVal Subject As String) As Boolean Implements IVerifyTextInput.Verify
        Dim regulator As New Regex("\d+")
        Return regulator.IsMatch(Subject)
    End Function
End Class
