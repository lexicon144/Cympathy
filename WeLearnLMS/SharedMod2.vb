Public Module SharedMod2
    Friend _SharedUserID As String
    Friend _SharedClassroomID As String
    Friend _SharedMainCredentials As New c_MainCredentials
    Friend _SharedAdvancedCredentials As New c_AdvancedCredentials

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

End Module
