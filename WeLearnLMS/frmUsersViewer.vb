Public Class frmUsersViewer
    Private _Datatable As New DataTable

    Private _MainCredentials As New c_MainCredentials

    Friend ReadOnly Property GetSmallCredentials As c_MainCredentials
        Get
            Return _MainCredentials
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmUsersViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllUsers()
        Dim btn As New DataGridViewButtonColumn()
        btn.HeaderText = "Action"
        btn.Text = "Open"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True

        With DataGridView1
            .DataSource = _Datatable
            .Columns.Add(btn)
        End With
    End Sub

    Private Sub ParseFromTextbox()
        With Me._MainCredentials
            .UserID = txtUserID.Text
            .UserName = txtUserName.Text
        End With

    End Sub

    Private Sub LoadAllUsers()

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
                    .CommandText = "SELECT user_id, user_name FROM tbl_user"

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

    Private Sub btrnOK_Click(sender As Object, e As EventArgs) Handles btrnOK.Click
        ParseFromTextbox()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try

            If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
                If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then

                    With DataGridView1.Rows(e.RowIndex)
                        txtUserID.Text = .Cells("user_id").Value.ToString()
                        txtUserName.Text = .Cells("user_name").Value.ToString()
                    End With

                End If
            End If
        Catch xxx As Exception
            WeLearnMessageDisplay.Display(WeLearnExceptions.General, Me, xxx)
        End Try
    End Sub
End Class