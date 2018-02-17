Public Class frmQuizHub

    Private _Datatable As New DataTable
    Private _ClassroomID As String
    Private _XmlBase As String


    Private _Quiz As New c_Quiz

    Private _Deserializer As IDataDeserializer = New ImpDataDeserializer

    Friend ReadOnly Property RetrieveQuiz As c_Quiz
        Get
            Return _Quiz
        End Get
    End Property

    Friend ReadOnly Property ThrowMainDatatable As DataTable
        Get
            Return _Datatable
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.btnView.Enabled = False
        Me.btnOK.Enabled = True
    End Sub

    Public Sub New(ByRef ClassroomID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Me._Credentials = Credentials
        Me._ClassroomID = ClassroomID

    End Sub

    Friend Sub LoadAllQuizes()
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
                    .CommandType = CommandType.Text
                    .CommandText = "SELECT tbl_quizes.id, tbl_quizes.quest_name, tbl_quizes.xml_base, tbl_quizes.state_long FROM tbl_quizes"
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
    Friend Sub LoadAllQuizes(ByRef ThisClassroomID As String)
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
                    .CommandText = "SelectQuizesFromThisClass"
                    With .Parameters
                        .AddWithValue("ClassroomID", ThisClassroomID)
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

    Private Sub ParseTextbox()
        With Me
            ._Quiz.QuestionnaireName = txtQuizName.Text
            ._Quiz.QuestionnaireID = txtQuizID.Text
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
                If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then
                    With DataGridView1.Rows(e.RowIndex)
                        txtQuizID.Text = .Cells("id").Value.ToString()
                        txtQuizName.Text = .Cells("quest_name").Value.ToString()
                        _XmlBase = .Cells("xml_base").Value.ToString()
                    End With
                End If
            End If
        Catch XXX As Exception
            WeLearnMessageDisplay.Display(WeLearnExceptions.General, Me, XXX)
        End Try
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ParseTextbox()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmQuizHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _SharedMainCredentials.MyUserType = c_MainCredentials.UserType.ADM Then
            LoadAllQuizes()
        Else
            LoadAllQuizes(Me._ClassroomID)
        End If

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
            If .Columns.Contains("status_long") Then .Columns("status_long").Visible = False
            If .Columns.Contains("xml_base") Then .Columns("xml_base").Visible = False
        End With

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Me._Quiz.QuestionBase = _Deserializer.DataDeserialize(_XmlBase)
            ParseTextbox()

            Dim viewer As New frmQuizViewer(Me._Quiz)
            viewer.ShowDialog()
        Catch XXX As Exception
            WeLearnMessageDisplay.Display(WeLearnExceptions.General, Me, XXX)
        End Try
    End Sub
End Class