Public Class frmPasswordChallenge

    Private _Success As Boolean
    Private _PreInfo As New DataTable
    Private _UserID As String

    Public Sub New(ByRef UserID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._UserID = UserID
        End With
    End Sub

    Friend ReadOnly Property Success As Boolean
        Get
            Return _Success
        End Get
    End Property

    Private Sub frmPasswordChallenge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PrepareChallenge()
            DataParser()
        Catch XXX As Exception
            WeLearnMessageDisplay.Display(WeLearnExceptions.General, Me, XXX)
        End Try
    End Sub

    Private Sub PrepareChallenge()
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using Command As New MySqlCommand

                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SelectUserChallenge"
                    With .Parameters
                        .AddWithValue("@UserID", Me._UserID)
                    End With
                End With

                Using Adapter As New MySqlDataAdapter
                    With Adapter
                        .SelectCommand = Command
                        .Fill(_PreInfo)
                    End With
                End Using
            End Using
        End Using
    End Sub

    Private Sub DataParser()
        With Me
            .RichTextBox1.Text = _PreInfo.Rows(0)("sqTEXT").ToString()
        End With
    End Sub

    Private Function Evaluated() As Boolean
        Return txtAnswer.Text = _PreInfo.Rows(0)("sec_ans").ToString()
    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Evaluated() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        Else
            Me.DialogResult = Windows.Forms.DialogResult.No
        End If
    End Sub

    Private Sub frmPasswordChallenge_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub
End Class