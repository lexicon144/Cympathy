Public Class c_Message
    Private _TimeStamp As String
    Private _ReceiverID As String
    Private _SenderID As String
    Private _Payload As String
    Private _ReceiverName As String
    Private _SenderName As String
    Public Sub New()
        Console.WriteLine("New " & Me.ToString)
    End Sub
    Friend Property TimeStamp As String
        Get
            Return _TimeStamp
        End Get
        Set(value As String)
            _TimeStamp = value
            Console.WriteLine(value)
        End Set
    End Property

    Friend Property ReceiverID As String
        Get
            Return _ReceiverID
        End Get
        Set(value As String)
            Console.WriteLine(value)
            _ReceiverID = value
        End Set
    End Property

    Friend Property SenderID As String
        Get
            Return _SenderID
        End Get
        Set(value As String)
            Console.WriteLine(value)
            _SenderID = value
        End Set
    End Property

    Friend Property Payload As String
        Get
            Return _Payload
        End Get
        Set(value As String)
            Console.WriteLine(value)
            _Payload = value
        End Set
    End Property

    Friend Property SenderName As String
        Get
            Return _SenderName
        End Get
        Set(value As String)
            _SenderName = value
        End Set
    End Property

    Friend Property ReceiverName As String
        Get
            Return _ReceiverName
        End Get
        Set(value As String)
            _ReceiverName = value
        End Set
    End Property
End Class
