Imports System.Text.RegularExpressions

Public Class StrategyVerifyIPv4
    Implements IVerifyTextInput

    Public Sub New()
        Console.WriteLine("New Me {0}", Me.ToString)
    End Sub

    Public Function Verify(Subject As String) As Boolean Implements IVerifyTextInput.Verify
        Dim regulator As New Regex("\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b")
        Return regulator.IsMatch(Subject)

    End Function
End Class
