Public Class frmClassStanding

    Private _StandingDatatable As New DataTable

    Private Sub frmClassStanding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DisplayAllChildren(_SharedClassroom.ClassroomId)
            ShowAll()
            FormatGrid()
        Catch ex As Exception
            DisplayGeneralException(ex)
        End Try
    End Sub

    Private Sub FormatGrid()
        If Not DataGridView1.Rows.Count > 0 Then Exit Sub
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("isOnline").Value Then row.DefaultCellStyle.BackColor = Color.LightGreen Else row.DefaultCellStyle.BackColor = Color.LightGray
        Next
    End Sub

    Private Sub ShowAll()
        Dim btn As New DataGridViewButtonColumn

        With btn
            .HeaderText = "Action"
            .Text = "Open"
            .Name = "btn"
            .UseColumnTextForButtonValue = True
        End With

        With Me.DataGridView1
            .DataSource = _StandingDatatable
            .Columns.Add(btn)
            .Columns("user_id").Visible = False
            .Columns("user_fname").Visible = False
            .Columns("user_mi").Visible = False
            .Columns("user_lname").Visible = False
            .Columns("isOnline").Visible = False
            .Columns("id").Visible = False
        End With
    End Sub

    Private Sub DisplayAllChildren(ByRef ClassroomID As String)
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
                    .CommandText = "DisplayAllStudentsInThisClass"
                    With .Parameters
                        .AddWithValue("ClassroomID", ClassroomID)
                    End With
                End With
                Using Adapter As New MySqlDataAdapter(Command)
                    With Adapter
                        .Fill(_StandingDatatable)
                    End With
                End Using
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class