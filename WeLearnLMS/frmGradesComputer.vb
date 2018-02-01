Public Class frmGradesComputer

    Private _QuizesDatatable As New DataTable
    Private _UserID As String
    Private _ClassroomID As String
    Private _ListQuizPregrades As List(Of c_PreGrade)
    ''' <summary>
    ''' Calculate All pregrades from Quiz and Exams
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmGradesComputer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GetAllClassroomGrades()
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
                        .AddWithValue("UserID", Me._UserID)
                        .AddWithValue("ClassroomID", Me._ClassroomID)
                    End With
                End With
                Using Adapter As New MySqlDataAdapter
                    With Adapter
                        .SelectCommand = Command
                        .Fill(_QuizesDatatable)
                    End With
                End Using
            End Using
        End Using
    End Sub

    Private Sub GetAverageOfQuizes()

    End Sub



End Class