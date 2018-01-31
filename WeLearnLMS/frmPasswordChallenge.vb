Public Class frmPasswordChallenge

    Private _Success As Boolean
    Private _PreInfo As New DataTable
    Private _MainCredentials As c_MainCredentials

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmPasswordChallenge_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PrepareChallenge()
        Using Connection As New MySqlConnection
            With Connection
                .ConnectionString = _SharedConnString.ConnString
            End With

            Dim LoginTransaction As MySqlTransaction = Connection.BeginTransaction(IsolationLevel.ReadCommitted)
            Try
                Using Command As New MySqlCommand

                    With Command
                        .Connection = Connection
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SelectUserChallenge"
                        With .Parameters
                            .AddWithValue("@UserID", _MainCredentials.UserID)
                        End With
                    End With

                    Using Adapter As New MySqlDataAdapter
                        With Adapter
                            .SelectCommand = Command
                            .Fill(_PreInfo)
                        End With
                    End Using
                End Using
            Catch eee As Exception
            End Try
        End Using
    End Sub

    Private Sub DataParser()
        With Me
            .RichTextBox1.Text = _PreInfo.Rows(0)("sqTEXT").ToString()
        End With
    End Sub

    Private Function Evaluator() As Boolean
        Return txtAnswer.Text = _PreInfo.Rows(0)("sec_ans").ToString()
    End Function

End Class