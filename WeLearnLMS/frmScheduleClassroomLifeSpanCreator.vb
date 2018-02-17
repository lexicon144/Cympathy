Public Class frmScheduleClassroomLifeSpanCreator

    Private _TimeSpan As New c_ClassroomLifespan()
    Private _ClassroomID As String
    ''' <summary>
    ''' Null constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    ''' <summary>
    ''' Constructor for Classroom
    ''' </summary>
    ''' <param name="ClassroomID"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef ClassroomID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._ClassroomID = ClassroomID
        txtClassroomID.Text = ClassroomID
    End Sub


    ''' <summary>
    ''' Check if data has been evaluated
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Evaluated() As Boolean
        Return (0 > DateTime.Compare(dtpStart.Value, dtpEnd.Value))
    End Function

    ''' <summary>
    ''' Parse all the data to the private object
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ParseToMyObject()
        With Me._TimeSpan
            .ClassroomID = Me._ClassroomID
            .DateEnd = dtpEnd.Value.Date
            .DateStart = dtpStart.Value.Date
        End With
    End Sub

    ''' <summary>
    ''' Perform the linking transaction
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PerformLink()
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Dim LinkingTransaction As MySqlTransaction = Connection.BeginTransaction
            Try

                Using Command As New MySqlCommand
                    With Command
                        .Connection = Connection
                        .CommandText = "InsertClassroomLifespan"
                        .CommandType = CommandType.StoredProcedure
                        With .Parameters
                            .AddWithValue("ClassroomID", Me._TimeSpan.ClassroomID)
                            .AddWithValue("DateStart", Me._TimeSpan.DateStart)
                            .AddWithValue("DateEnd", Me._TimeSpan.DateEnd)
                        End With
                        .ExecuteNonQuery()
                        LinkingTransaction.Commit()

                        MessageBox.Show("Linking Transaction was Successfull", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End With
                End Using
            Catch xxx As Exception
                LinkingTransaction.Rollback()
                WeLearnMessageDisplay.Display(WeLearnExceptions.Linking, Me, xxx)
            End Try
        End Using
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Evaluated() Then
            ParseToMyObject()
            PerformLink()
        End If
    End Sub

    Private Sub frmScheduleClassroomLifeSpanCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class