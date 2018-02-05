﻿
Public Class frmRankingCreator

    Private _MainCredentials As New c_MainCredentials
    Private _CandidateCredentials As New c_MainCredentials
    Private _Blinked As Boolean
    Private _Count As UInt32

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

    ''' <summary>
    ''' Count validated Votes of thisUserID
    ''' </summary>
    ''' <param name="CandidateID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function CountVotes(ByRef CandidateID As String) As UInt32
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

    ''' <summary>
    ''' Save Votes of ThisCandidate ID
    ''' </summary>
    ''' <param name="CandidateID"></param>
    ''' <param name="VoterID"></param>
    ''' <param name="State"></param>
    ''' <remarks></remarks>
    Friend Sub SaveVote(ByRef CandidateID As String, ByRef VoterID As String, ByVal State As Boolean)
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
                    MessageBox.Show("Cympathy cannot save your vote! Reason:: " & Exx.Message, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End Try
            End Using
        End Using
    End Sub

    Private Sub DisplayToText()
        With Me
            .txtVote.Text = ._Count.ToString
            .txtUserID.Text = ._CandidateCredentials.UserID
            .txtUserName.Text = ._CandidateCredentials.UserName
        End With
    End Sub

    Private Sub frmRankingProfessors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim browser As New frmUsersViewer()
        If browser.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me._CandidateCredentials = browser.GetSmallCredentials
        End If

        Me._Count = CountVotes(Me._CandidateCredentials.UserID)

        DisplayToText()
    End Sub

    Private Sub btnBrowseUser_Click(sender As Object, e As EventArgs) Handles btnBrowseUser.Click

        Dim browser As New frmUsersViewer()
        If browser.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me._CandidateCredentials = browser.GetSmallCredentials
        End If

        Me.txtVote.Text = CountVotes(Me._CandidateCredentials.UserID)
        Me.chkVote.Enabled = True
    End Sub

    Private Sub chkVote_CheckedChanged(sender As Object, e As EventArgs) Handles chkVote.CheckedChanged
        Timer1.Stop()
        SaveVote(Me._CandidateCredentials.UserID, Me._MainCredentials.UserID, DirectCast(sender, CheckBox).Checked)
        DirectCast(sender, CheckBox).Enabled = False
        Me.chkVote.BackColor = Me.BackColor
    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        DirectCast(sender, Label).Text = "(You)"
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        DirectCast(sender, Label).Text = "(You) are voting for..."
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If _Blinked Then
            Me.chkVote.BackColor = Color.Red
        Else
            Me.chkVote.BackColor = Me.BackColor
        End If
        _Blinked = Not _Blinked
    End Sub
End Class