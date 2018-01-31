Public Class frmTimeDialog
    Private _TimeDatatable As New DataTable
    Private _Time As New c_Time

    Friend ReadOnly Property GetTime As c_Time
        Get
            Return _Time
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmTimeViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTime()

        Dim btn As New DataGridViewButtonColumn()
        btn.HeaderText = "Action"
        btn.Text = "Open"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True

        With DataGridView1
            .DataSource = _TimeDatatable
            .Columns.Add(btn)
            .Columns("timeslotID").Visible = False
            .Columns("timestart").Visible = False
        End With
    End Sub

    Private Sub ParseFromGrid()
        With Me._Time
            .TimeID = txtTimeID.Text
            .TimeStart = txtTimeStart.Text
            .TimeDescription = txtTimeDescription.Text
        End With
    End Sub

    Private Sub LoadTime()
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
                    .CommandText = "SelectTime"
                End With

                Using Adapter As New MySqlDataAdapter
                    With Adapter
                        .SelectCommand = Command
                        .Fill(_TimeDatatable)
                    End With
                End Using
            End Using

        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then

                With DataGridView1.Rows(e.RowIndex)
                    txtTimeID.Text = .Cells(0).Value.ToString()
                    txtTimeStart.Text = .Cells(1).Value.ToString()
                    txtTimeDescription.Text = .Cells(2).Value.ToString()
                End With

            End If
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ParseFromGrid()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class