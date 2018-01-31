Public Class frmTimeSlotCreator
    Private _DaysDatatable, _TimeDatatable As New DataTable
    Private _MainCredentials As c_MainCredentials
    Private _TimeSlot As New c_Timeslot

    Friend ReadOnly Property TimeSlot As c_Timeslot
        Get
            Return Me._TimeSlot
        End Get
    End Property
    Friend WriteOnly Property Credentials As c_MainCredentials
        Set(value As c_MainCredentials)
            Me._MainCredentials = value
        End Set
    End Property

    Public Sub New(ByRef MainCredentials As c_MainCredentials)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._MainCredentials = MainCredentials
    End Sub

    Private Sub frmTimeSlotCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PerformLink()
        Using Connection As New MySqlConnection
            With Connection
                .ConnectionString = _SharedConnString.ConnString
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using Command As New MySqlCommand
                With Command
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertTimeslot"
                    With .Parameters
                        .AddWithValue("ClassroomID", _TimeSlot.Classroom.ClassroomId)
                        .AddWithValue("TimeID", _TimeSlot.Time.TimeID)
                    End With
                End With
            End Using
        End Using
    End Sub

    Private Sub btnBrowseClassroom_Click(sender As Object, e As EventArgs) Handles btnBrowseClassroom.Click
        Dim BrowseClassroom As New frmClassroomDialog(_MainCredentials)
        BrowseClassroom.ShowDialog()

        With Me
            ._TimeSlot.Classroom = BrowseClassroom.Classroom
            .txtClassroom.Text = _TimeSlot.Classroom.ClassroomName
        End With
    End Sub

    Private Sub btnBrowseTime_Click(sender As Object, e As EventArgs) Handles btnBrowseTime.Click
        Dim BrowseTime As New frmTimeDialog()
        BrowseTime.ShowDialog()

        With Me
            ._TimeSlot.Time = BrowseTime.Time
            .txtTime.Text = _TimeSlot.Time.TimeStart
        End With
    End Sub
End Class