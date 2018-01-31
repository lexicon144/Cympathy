Imports System.Text.RegularExpressions
''' <summary>
''' Strategy to verify a LANDLINE number
''' </summary>
''' <remarks></remarks>
Public Class StrategyVerifyLandline
    Implements IVerifyTextInput

    Public Sub New()
        Console.WriteLine("Instantiated " & Me.ToString)
    End Sub
    ''' <summary>
    ''' Verifies if string is an Acceptable Landline 
    ''' </summary>
    ''' <param name="Subject">Keypress Events</param>
    ''' <remarks></remarks>
    Public Function Verify(ByVal Subject As String) As Boolean Implements IVerifyTextInput.Verify
        Dim regulator As New Regex("\b\d{3}[-.\s]?\d{4}\b")
        Return regulator.IsMatch(Subject)
    End Function
End Class
