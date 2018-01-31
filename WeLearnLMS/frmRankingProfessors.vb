Public Class frmRankingProfessors

    Private _MainCredentials As New c_MainCredentials
    Private _CandidateCredentials As New c_MainCredentials

    ''' <summary>
    ''' Admin Constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._MainCredentials.UserID = 0
    End Sub

    ''' <summary>
    ''' Non admin constructor
    ''' </summary>
    ''' <param name="User"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef User As c_MainCredentials)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._MainCredentials = User
    End Sub

    Private Function CountVotes(ByRef CandidateID As String) As UInt32
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
                    .CommandText = "CountVotes"
                    With .Parameters
                        .AddWithValue("CandidateID", CandidateID)
                    End With
                End With
                Return Convert.ToUInt32(Command.ExecuteScalar)
            End Using
        End Using
    End Function
    Private Sub SaveVote(ByRef CandidateID As String, ByRef VoterID As String, ByVal State As Boolean)
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using MarkingTransaction As MySqlTransaction = Connection.BeginTransaction
                Try
                    Using Command As New MySqlCommand
                        With Command
                            .Connection = Connection
                            .Transaction = MarkingTransaction
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "InsertVote"
                            With .Parameters
                                .AddWithValue("CandidateID", CandidateID)
                                .AddWithValue("VoterID", VoterID)
                                .AddWithValue("State", State)
                            End With
                            .ExecuteNonQuery()
                            MarkingTransaction.Commit()
                        End With
                    End Using
                    Console.WriteLine("Vote saved!")
                Catch Exx As Exception
                    MarkingTransaction.Rollback()
                    Console.WriteLine("Cannot save your vote!")
                    MessageBox.Show("Cympathy cannot save your vote!", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End Try
            End Using
        End Using
    End Sub

    Private Sub frmRankingProfessors_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim browser As New frmUsersViewer()
        If browser.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me._CandidateCredentials = browser.GetSmallCredentials
        End If

        Me.txtVote.Text = CountVotes(Me._CandidateCredentials.UserID)

    End Sub

    Private Sub btnBrowseUser_Click(sender As Object, e As EventArgs) Handles btnBrowseUser.Click
        SaveVote(Me._CandidateCredentials.UserID, Me._MainCredentials.UserID, Me.chkVote.Checked)
        Dim browser As New frmUsersViewer()
        If browser.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me._CandidateCredentials = browser.GetSmallCredentials
        End If

        Me.txtVote.Text = CountVotes(Me._CandidateCredentials.UserID)

    End Sub

End Class