Imports System.Security.Cryptography
Imports System.Text

Public Class StrategyHashingSHA512
    Implements IHashing
    Public Sub New()
        Console.WriteLine("New {0}", Me.ToString)
    End Sub
    ''' <summary>
    ''' Hashing Strategy Implementing SHA512
    ''' </summary>
    ''' <param name="password"></param>
    ''' <param name="salt"></param>
    ''' <returns>Return the STRIng hash value</returns>
    ''' <remarks></remarks>
    Public Function HashThis(ByRef password As String, ByRef salt As String) As String Implements IHashing.HashThis
        'This function 
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult

    End Function
End Class
