Public Class frmScheduleViewer

    Private _MyDatatable As New DataTable
    Private _ClassroomID As String

    ''' <summary>
    ''' Admin Viewer
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadSchedules()
    End Sub

    ''' <summary>
    ''' Non Admin Viewer
    ''' </summary>
    ''' <param name="ClassroomID"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef ClassroomID As String)
        InitializeComponent()
        Me._ClassroomID = ClassroomID

        LoadSchedules(ClassroomID)
    End Sub

    Private Sub SimpleView(ByVal State As Boolean)
        With Me
            .Label1.Visible = State
            .Label9.Visible = State
            .txtClassroomID.Visible = State
            .txtDayID.Visible = State
        End With
    End Sub

    Private Sub frmScheduleViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btn As New DataGridViewButtonColumn()
        btn.HeaderText = "Action"
        btn.Text = "Open"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True

        With DataGridView1
            .DataSource = _MyDatatable
            .Columns.Add(btn)

            .Columns("id").Visible = False
            .Columns("class_description").Visible = False
            .Columns("classType").Visible = False
            .Columns("day_number").Visible = False
            .Columns("hour_start").Visible = False
            .Columns("hour_end").Visible = False
        End With
    End Sub

    Friend Sub LoadSchedules(ByRef ClassID As String)
        Try
            Using Connection As New MySqlConnection(_SharedConnString.ConnString)
                With Connection
                    If .State = ConnectionState.Closed Then
                        .Open()
                    End If
                End With
                Using MarkingTransaction As MySqlTransaction = Connection.BeginTransaction
                    Using Command As New MySqlCommand
                        With Command
                            .Connection = Connection
                            .Transaction = MarkingTransaction
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "SelectSchedulesClassroom"
                            With .Parameters
                                .AddWithValue("ClassID", ClassID)
                            End With
                        End With
                        Using Adapter As New MySqlDataAdapter
                            With Adapter
                                .SelectCommand = Command
                                .Fill(Me._MyDatatable)
                            End With
                        End Using

                    End Using
                End Using
            End Using
        Catch XXX As Exception
            WeLearnMessageDisplay.Display(WeLearnExceptions.DGV, Me, XXX)
        End Try

    End Sub

    Private Sub LoadSchedules()
        Try
            Using Connection As New MySqlConnection(_SharedConnString.ConnString)
                With Connection
                    If .State = ConnectionState.Closed Then
                        .Open()
                    End If
                End With
                Using MarkingTransaction As MySqlTransaction = Connection.BeginTransaction
                    Using Command As New MySqlCommand
                        With Command
                            .Connection = Connection
                            .Transaction = MarkingTransaction
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "SelectSchedulesDetailed"
                        End With

                        Using Adapter As New MySqlDataAdapter
                            With Adapter
                                .SelectCommand = Command
                                .Fill(Me._MyDatatable)
                            End With
                        End Using
                    End Using
                End Using
            End Using
        Catch XXX As Exception
            WeLearnMessageDisplay.Display(WeLearnExceptions.DGV, Me, XXX)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
                If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then

                    With DataGridView1.Rows(e.RowIndex)
                        txtClassroomID.Text = .Cells("id").Value.ToString()
                        txtClassroomName.Text = .Cells("class_name").Value.ToString()
                        txtClassroomType.Text = [Enum].GetName(GetType(eClassType), .Cells("classType").Value)
                        txtClassroomDescription.Text = .Cells("class_description").Value.ToString
                        txtTimeEnd.Text = .Cells("hour_end").Value.ToString
                        txtTimeStart.Text = .Cells("hour_start").Value.ToString
                        txtDayID.Text = .Cells("day_number").Value.ToString
                        txtDayDescription.Text = [Enum].GetName(GetType(DayOfWeek), .Cells("day_number").Value)
                    End With

                End If
            End If
        Catch xxx As Exception
            WeLearnMessageDisplay.Display(WeLearnExceptions.General, Me, xxx)
        End Try
    End Sub

    Private Sub chkVisible_Click(sender As Object, e As EventArgs) Handles chkVisible.Click
        SimpleView(chkVisible.Checked)
    End Sub

End Class