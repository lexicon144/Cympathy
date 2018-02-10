''' <summary>
''' Grades computer 
''' </summary>
''' <remarks></remarks>
Public Class frmGradesClassroomViewer

    Private _ClassroomGradesDatatable As New DataTable
    Private _UserID As String
    Private _ClassroomID As String
    ''' <summary>
    ''' Calculate All pregrades from Quiz and Exams
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef UserID As String, ByRef ClassroomID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._UserID = UserID
            ._ClassroomID = ClassroomID

        End With
    End Sub

    Private Sub frmGradesClassroomViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim classroomhub As New frmClassroomDialog()
        If classroomhub.ShowDialog = Windows.Forms.DialogResult.OK Then

            GetAllClassroomGrades(_SharedUserID, _SharedClassroom.ClassroomId)

        End If

    End Sub

    Private Sub ViewDatatable()
        Dim btn As New DataGridViewButtonColumn()

        With DataGridView1
            .DataSource = _ClassroomGradesDatatable
        End With
    End Sub

    Private Sub GetAllClassroomGrades(ByRef UserID As String, ByRef ClassroomID As String)
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
                    .CommandText = "SelectClassroomGrades"
                    With .Parameters
                        .AddWithValue("UserID", UserID)
                        .AddWithValue("ClassroomID", ClassroomID)
                    End With
                End With
                Using Adapter As New MySqlDataAdapter
                    With Adapter
                        .SelectCommand = Command
                        .Fill(_ClassroomGradesDatatable)
                    End With
                End Using
            End Using
        End Using
    End Sub

End Class