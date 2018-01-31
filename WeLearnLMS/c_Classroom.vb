Public Class c_Classroom
#Region "Fields"
    Private _ClassroomName As String
    Private _ClassroomId As String
    Private _ClassroomDesc As String
    Private _ClassroomType As eClassType
    
#End Region

#Region "Constructors"
    ''' <summary>
    ''' Constructor for me
    ''' </summary>
    ''' <remarks></remarks>
    Protected Friend Sub New()
        Console.WriteLine("New {0}", Me.ToString)
    End Sub
#End Region

#Region "Properties"
    ''' <summary>
    ''' Classroom Description property
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Protected Friend Property ClassroomDesc As String
        Get
            Return _ClassroomDesc
        End Get
        Set(value As String)
            _ClassroomDesc = value
        End Set
    End Property

    ''' <summary>
    ''' Classroom ID property
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Protected Friend Property ClassroomId As String
        Get
            Return _ClassroomId
        End Get
        Set(value As String)
            _ClassroomId = value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Friend Property ClassroomName As String
        Get
            Return _ClassroomName
        End Get
        Set(value As String)
            _ClassroomName = value
        End Set
    End Property

    ''' <summary>
    ''' Classtype property
    ''' </summary>
    ''' <value>eClassType</value>
    ''' <returns>eClassType</returns>
    ''' <remarks></remarks>
    Protected Friend Property ClassType As eClassType
        Get
            Return _ClassroomType
        End Get
        Set(value As eClassType)
            _ClassroomType = value
        End Set
    End Property
#End Region

End Class
