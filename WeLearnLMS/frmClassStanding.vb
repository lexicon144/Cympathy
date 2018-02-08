Public Class frmClassStanding

    Private _StandingDatatable As New DataTable

    Private Sub frmClassStanding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayAllChildren()
        ShowAll()
    End Sub

    Private Sub ShowAll()
        With Me.DataGridView1
            .DataSource = _StandingDatatable
        End With
    End Sub

    Private Sub DisplayAllChildren()
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
                    .CommandText = ""
                End With
                Using Adapter As New MySqlDataAdapter(Command)
                    With Adapter
                        .Fill(_StandingDatatable)
                    End With
                End Using
            End Using
        End Using
    End Sub

End Class