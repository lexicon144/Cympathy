''' <summary>
''' Grades computer 
''' </summary>
''' <remarks></remarks>
Public Class frmGradesClassroomViewer

    Private _ClassroomGradesDatatable As New DataTable
    Private _UserID As String
    Private _ClassroomID As String

    Friend ReadOnly Property GetMyTable As DataTable
        Get
            Return Me._ClassroomGradesDatatable
        End Get
    End Property

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
            Me._ClassroomID = classroomhub.GetClassroom.ClassroomId
            GetAllClassroomGrades(_SharedUserID, Me._ClassroomID)
        End If
        ViewDatatable()
    End Sub

    Private Sub ViewDatatable()
        Dim btn As New DataGridViewButtonColumn()

        With DataGridView1
            .DataSource = _ClassroomGradesDatatable
            .Columns("id_classroomgrades").Visible = False
            .Columns("user_id").Visible = False
            .Columns("class_id").Visible = False
        End With
    End Sub

    Friend Sub GetAllClassroomGrades(ByRef UserID As String, ByRef ClassroomID As String)
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
    Friend Sub GetAllClassroomGrades(ByRef ClassroomID As String)
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
                    .CommandText = "SelectAllClassroomGrades"
                    With .Parameters
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