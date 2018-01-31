Public Class frmStudyHub

    Private _Datatable As New DataTable
    Private _Questionnaire As New c_Questionnaire
    Private _Credentials As c_MainCredentials
    Private _ClassroomID As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef ClassroomID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef Credentials As c_MainCredentials, ByRef ClassroomID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._Credentials = Credentials
        Me._ClassroomID = ClassroomID
    End Sub

    Private Sub frmStudyHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadDatagridView()
        Using Connection As New MySqlConnection
            With Connection
                .ConnectionString = _SharedConnString.ConnString
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With

            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = ""
                End With

                Using Adapter As New MySqlDataAdapter
                    With Adapter
                        .SelectCommand = Command
                        .Fill(_Datatable)
                    End With
                End Using
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class