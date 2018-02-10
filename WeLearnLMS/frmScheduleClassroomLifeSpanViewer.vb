Public Class frmScheduleClassroomLifeSpanViewer

    Private _MyDatatable As New DataTable

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

    Private Sub frmScheduleClassroomLifeSpanViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ShowOnGrid()

        Dim btn As New DataGridViewButtonColumn()

        With btn
            .HeaderText = "Action"
            .Text = "<-"
            .Name = "btn"
            .UseColumnTextForButtonValue = True
        End With

        With DataGridView1
            .DataSource = _MyDatatable
            .Columns.Add(btn)

            .Columns("id").Visible = False
        End With

    End Sub

    Private Sub ViewLifespan(ByRef ClassroomID As String)
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With

            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandText = "SelectClassroomLifespan"
                    .CommandType = CommandType.StoredProcedure
                    With .Parameters
                        .AddWithValue("ClassroomID", ClassroomID)
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
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then

                With DataGridView1.Rows(e.RowIndex)
                    txtClassroomName.Text = .Cells("class_name").Value.ToString()
                    txtDateSpan.Text = .Cells("date_start").Value.ToString() & " -> " & .Cells("date_end").Value.ToString()
                End With

            End If
        End If
    End Sub
End Class