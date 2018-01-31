Public Class c_Article

    Private _ArticleID As UInt32
    Private _ArticleSize As UInt32
    Private _ArticleName As String
    Private _ArticleBase As Byte()

    ''' <summary>
    ''' Constructor for new me
    ''' </summary>
    ''' <remarks></remarks>
    Friend Sub New()

        With Me
            ._ArticleBase = Nothing
            ._ArticleID = Nothing
            ._ArticleSize = Nothing
            ._ArticleName = Nothing
        End With

        Console.WriteLine("New {0}", Me.ToString)
    End Sub

    ''' <summary>
    ''' Article ID property
    ''' </summary>
    ''' <value>Unsigned integer 32</value>
    ''' <returns>returns Unsigned integer 32</returns>
    ''' <remarks></remarks>
    Friend Property ArticleID As UInt32
        Get
            Return _ArticleID
        End Get
        Set(value As UInt32)
            _ArticleID = value
        End Set
    End Property

    ''' <summary>
    ''' Article BASE property
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Friend Property ArticleBase As Byte()
        Get
            Return _ArticleBase
        End Get
        Set(value As Byte())
            _ArticleBase = value
        End Set
    End Property

    ''' <summary>
    ''' Article Size property
    ''' </summary>
    ''' <value>Uint32</value>
    ''' <returns>Uint32</returns>
    ''' <remarks></remarks>
    Friend Property ArticleSize As UInt32
        Get
            Return _ArticleSize
        End Get
        Set(value As UInt32)
            _ArticleSize = value
        End Set
    End Property

    ''' <summary>
    ''' Article Name property
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property ArticleName As String
        Get
            Return _ArticleName
        End Get
        Set(value As String)
            _ArticleName = value
        End Set
    End Property

End Class
