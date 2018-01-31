Imports System.Text

Public Class ImpSalter
    Implements ISalter

    Public Function SaltThis() As String Implements ISalter.SaltThis
        'this is pure salt.. nothing but salt
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"
        Dim LOL As String = ""
        Dim rnd As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 100 'Length of the salt
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            LOL &= (mix.Substring(x, 1))
        Next
        Return LOL
    End Function
End Class
