Public Class c_Material

    Private _MaterialID As String
    Private _MaterialName As String
    Private _MaterialDescription As String
    ''' <summary>
    ''' Me Constructor
    ''' </summary>
    ''' <remarks></remarks>
    Protected Friend Sub New()
        Console.WriteLine("New {0}", Me.ToString)
    End Sub

    Protected Friend Property MaterialID As String
        Get
            Return _MaterialID
        End Get
        Set(value As String)
            _MaterialID = value
        End Set
    End Property

    Protected Friend Property MaterialName As String
        Get
            Return _MaterialName
        End Get
        Set(value As String)
            _MaterialName = value
        End Set
    End Property

    Protected Friend Property MaterialDescription As String
        Get
            Return _MaterialDescription
        End Get
        Set(value As String)
            _MaterialDescription = value
        End Set
    End Property
End Class
