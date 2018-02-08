Imports System.Net.Sockets
Imports System.Threading
Imports System.IO

Public Class frmNetworkPinger
    Dim Listener As New TcpListener(65535)
    Dim Client As New TcpClient
    Dim Message As String = ""

    Private Sub frmNetworkPinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ListThread As New Thread(New ThreadStart(AddressOf Listening))
        ListThread.Start()
    End Sub

    Private Sub Listening()
        Listener.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Client = New TcpClient("127.0.0.1", 65535)

        Dim Writer As New StreamWriter(Client.GetStream())
        Writer.Write(TextBox1.Text)
        Writer.Flush()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Listener.Pending = True Then
            Message = ""
            Client = Listener.AcceptTcpClient()

            Dim Reader As New StreamReader(Client.GetStream())
            While Reader.Peek > -1
                Message = Message + Convert.ToChar(Reader.Read()).ToString
            End While

            MsgBox(Message, MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub frmNetworkPinger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Listener.Stop()
    End Sub
End Class