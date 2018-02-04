Imports System.Text
Imports System.IO
Imports System.Xml.Serialization

Public Module SharedMod2
    Friend _SharedUserID As String
    Friend _SharedClassroom As New c_Classroom
    Friend _SharedMainCredentials As New c_MainCredentials
    Friend _SharedAdvancedCredentials As New c_AdvancedCredentials
    Friend _SharedValidator As New ContextVerification


    Friend Enum UserType
        ADM = 0
        PRO = 1
        STU = 2
    End Enum
    Public Enum eClassType As Integer
        SEM = 0
        TRI = 1
    End Enum
    Friend Enum Gender
        FEMALE = 0
        MALE = 1
    End Enum

    Public Enum QType
        SQUIZ = 100
        PEXAM = 200
        OEXAM = 300
    End Enum

    Public Enum VMethodology
        Numbers
        Text
        Username
        Cellular
        Landline
        Email
        Address
        VerySimple
    End Enum


    Public Function Randomizer() As StringBuilder
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb
    End Function

    Public Function DataSerialize(ByRef myList As List(Of c_SmallQuestion)) As String
        Dim sw As New StringWriter
        Dim s As New XmlSerializer(myList.GetType)
        s.Serialize(sw, myList)
        Return sw.ToString()

    End Function
End Module
