Public Class frmSQLPinger
    Private Safe As Boolean

    Friend ReadOnly Property Safety As Boolean
        Get
            Return Safe
        End Get
    End Property

    Private ConState As ConnectionState

    Friend ReadOnly Property Safeness As ConnectionState
        Get
            Return ConState
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmSQLPinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Using ConnectionObject As New MySqlConnection
                With ConnectionObject
                    .ConnectionString = _SharedConnString.ConnString
                    rtb.AppendText("New MysqlConnection...")
                    nl()
                    rtb.AppendText("This Connection:::" & ConnectionObject.GetHashCode & ":::" & .State.ToString)
                    nl()

                    If .State = ConnectionState.Closed Then
                        nl()
                        rtb.AppendText("Connection is closed! Opening ....")
                        .Open()
                        nl()
                        rtb.AppendText("Opened!")
                        Safe = True

                    End If
                    Safe = True

                End With
            End Using

        Catch XXX As Exception
            Safe = False
            nl()
            rtb.AppendText("Caught Exception: " & XXX.Message)

        End Try
        Console.WriteLine(Safe)
        Me.Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub nl()
        rtb.AppendText(vbNewLine)
    End Sub

    Private Sub rtb_TextChanged(sender As Object, e As EventArgs) Handles rtb.Click
        Timer1.Stop()
    End Sub

    Private Sub frmSQLPinger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class