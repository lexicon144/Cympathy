Public Class frmTimeslotDialog

    Private _ThisDataTable As New DataTable
    Private _Filter As New DataView
    Private _ThisTimeSlot As New c_Timeslot

    Friend ReadOnly Property GetTimeSlot As c_Timeslot
        Get
            Return _ThisTimeSlot
        End Get
    End Property


    Private Sub frmTimeslotDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllTimeslots()
        Me._Filter.Table = Me._ThisDataTable

        Dim btn As New DataGridViewButtonColumn()
        btn.HeaderText = "Action"
        btn.Text = "Open"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True

        With DataGridView1
            .DataSource = Me._Filter
            .Columns.Add(btn)
        End With

    End Sub

    Private Sub DataFilter(ByRef FilterString As String)
        Me._Filter.RowFilter = FilterString
        DataGridView1.Refresh()
    End Sub

    Private Sub LoadAllTimeslots()
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
                    .CommandText = "SelectDetailedTimeslots"
                    .CommandType = CommandType.StoredProcedure
                End With

                Using Adapter As New MySqlDataAdapter
                    With Adapter
                        .SelectCommand = Command
                        .Fill(_ThisDataTable)
                    End With
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        DataFilter("class_name like '" & txtFilter.Text & "'")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then

                With DataGridView1.Rows(e.RowIndex)
                    txtTimeSlotID.Text = .Cells(0).Value.ToString()
                    txtClassroomID.Text = .Cells(1).Value.ToString()
                    txtClassroomName.Text = .Cells(2).Value.ToString()
                    txtClassroomType.Text = .Cells(3).Value.ToString
                    txtTimeID.Text = .Cells(4).Value.ToString
                    txtTimeStart.Text = .Cells(5).Value.ToString
                    txtTimeDescription.Text = .Cells(6).Value.ToString
                End With

            End If
        End If
        ParseFromTextbox()
    End Sub

    Private Sub ParseFromTextbox()
        With Me
            ._ThisTimeSlot.TimeslotID = .txtTimeSlotID.Text
            ._ThisTimeSlot.Time.TimeDescription = .txtTimeDescription.Text
            ._ThisTimeSlot.Time.TimeID = .txtTimeID.Text
            ._ThisTimeSlot.Time.TimeStart = .txtTimeStart.Text
            ._ThisTimeSlot.Classroom.ClassroomDesc = .txtClassroomDescription.Text
            ._ThisTimeSlot.Classroom.ClassroomId = .txtClassroomID.Text
            ._ThisTimeSlot.Classroom.ClassroomName = .txtClassroomName.Text
            ._ThisTimeSlot.Classroom.ClassType = .txtClassroomType.Text
        End With
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class