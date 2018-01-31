Public Class frmDayDialog

    Private _Day As New c_Day
    Private _ThisDatatable As New DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend ReadOnly Property GetDay
        Get
            Return Me._Day
        End Get
    End Property

    Private Sub frmDayDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllDays()
        Dim btn As New DataGridViewButtonColumn()
        btn.HeaderText = "Action"
        btn.Text = "Open"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True

        With DataGridView1
            .DataSource = _ThisDatatable
            .Columns.Add(btn)
            .Columns("id").Visible = False
        End With
    End Sub

    Private Sub LoadAllDays()
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
                    .CommandText = "SelectDays"
                End With
                Using Adapter As New MySqlDataAdapter
                    With Adapter
                        .SelectCommand = Command
                        .Fill(Me._ThisDatatable)
                    End With
                End Using
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then

                With DataGridView1.Rows(e.RowIndex)
                    txtDayID.Text = .Cells(0).Value.ToString()
                    txtDayDescription.Text = .Cells(1).Value.ToString()
                    
                End With

            End If
        End If
    End Sub

    Private Sub ParseFromTextbox()
        With Me
            ._Day.DayID = txtDayID.Text
            ._Day.Day = txtDayDescription.Text
        End With
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ParseFromTextbox()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class