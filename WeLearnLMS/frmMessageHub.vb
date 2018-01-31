Public Class frmMessageHub

    Private _MainCredentials As c_MainCredentials
    Private _Datatable As New DataTable
    Private _Message As New c_Message

    Public Sub New(ByRef MainCrednetials As c_MainCredentials)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._MainCredentials = MainCrednetials
        LoadAllMessages()
    End Sub

    Private Sub frmMessageHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btn As New DataGridViewButtonColumn()

        With btn
            .HeaderText = "Action"
            .Text = "Open"
            .Name = "btn"
            .UseColumnTextForButtonValue = True
        End With

        With DataGridView1
            .DataSource = _Datatable
            .Columns.Add(btn)
        End With

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
                If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then

                    With DataGridView1.Rows(e.RowIndex)
                        _Message.Payload = .Cells("payload").Value.ToString
                        _Message.SenderID = .Cells("sender_id").Value.ToString
                        _Message.SenderName = .Cells("user_name").Value.ToString
                        _Message.ReceiverID = Me._MainCredentials.UserID
                        _Message.ReceiverName = Me._MainCredentials.UserName
                        _Message.TimeStamp = .Cells("id").ToString

                    End With

                End If
            End If
        Catch XXX As Exception

            MessageBox.Show("No messages open", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Sub LoadAllMessages()
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
                    .CommandText = "SelectAllMessages"
                    With .Parameters
                        .AddWithValue("ReceiverID", _MainCredentials.UserID)
                    End With
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


    Private Sub btnCreateFeedback_Click(sender As Object, e As EventArgs) Handles btnCreateFeedback.Click
        Dim Creator As New frmMessageCreator(_SharedUserID)
        Creator.ShowDialog()
    End Sub

    Private Sub btnViewFeedback_Click(sender As Object, e As EventArgs) Handles btnViewFeedback.Click
        Dim Viewer As New frmMessageViewer(Me._Message)
        Viewer.ShowDialog()
    End Sub
End Class