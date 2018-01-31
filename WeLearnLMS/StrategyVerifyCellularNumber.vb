Imports System.Text.RegularExpressions
''' <summary>
''' Strategy to verify a CELLULAR number
''' </summary>
''' <remarks></remarks>
Public Class StrategyVerifyCellularNumber
    Implements IVerifyTextInput

    Public Sub New()
        Console.WriteLine("Instantiated " & Me.ToString)
    End Sub
    ''' <summary>
    ''' Verifies if string is an Acceptable Cellular Number 
    ''' </summary>
    ''' <param name="Subject">Keypress Events</param>
    ''' <remarks></remarks>
    Public Function Verify(ByVal Subject As String) As Boolean Implements IVerifyTextInput.Verify
        Dim regulator As New Regex("(\+63)?([\.\-])?(\d{1})?(\d{3}[\.\-]?\d{3}[\.\-]?\d{4})")
        Return regulator.IsMatch(Subject)
    End Function
End Class
