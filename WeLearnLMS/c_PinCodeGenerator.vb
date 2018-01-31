Imports System.Security.Cryptography

Public Class c_PinCodeGenerator

    Public Sub New()

    End Sub

    Private Function PINCodeGenerator() As String
        Dim RandomValue As Byte() = New Byte() {}
        Dim RndGen As RandomNumberGenerator = RandomNumberGenerator.Create()
        RndGen.GetBytes(RandomValue)
        Return Convert.ToBase64String(RandomValue)
    End Function
End Class
