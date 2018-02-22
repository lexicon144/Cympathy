Public Class frmStudyMaterialsHub

    Private _ClassroomID As String
    Private _StudyMaterial As New c_Material
    Private _Datatable As New DataTable

    Private _IsModal As Boolean

    Friend ReadOnly Property RetrieveMaterial As c_Material
        Get
            Return _StudyMaterial
        End Get
    End Property

    Friend ReadOnly Property ThrowMainDatatable As DataTable
        Get
            Return _Datatable
        End Get
    End Property

    ''' <summary>
    ''' Modal Constructor (return a complete Study Material)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._IsModal = True
        Me.btnOK.Enabled = True
        Me.btnView.Enabled = False
        LoadAllMaterials()
    End Sub

    ''' <summary>
    ''' NonModal Constructor
    ''' </summary>
    ''' <param name="ClassroomID">Classroom ID</param>
    ''' <remarks></remarks>
    Public Sub New(ByRef ClassroomID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._ClassroomID = ClassroomID
        Me._IsModal = False
        LoadAllMaterials(ClassroomID)
    End Sub

    Private Sub frmStudyMaterialsHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim btn As New DataGridViewButtonColumn()

        With btn
            .HeaderText = "Action"
            .Text = "Select"
            .Name = "btn"
            .UseColumnTextForButtonValue = True
        End With

        With DataGridView1
            .DataSource = Me._Datatable
            .Columns.Add(btn)

        End With

    End Sub

    Friend Sub LoadAllMaterials()
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
                    .CommandText = "SelectAllMaterials"
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
    Friend Sub LoadAllMaterials(ByRef ClassroomID As String)
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
                    .CommandText = "SelectClassroomMaterials"
                    With .Parameters
                        .AddWithValue("ClassroomID", ClassroomID)
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then

                With DataGridView1.Rows(e.RowIndex)
                    txtMaterialID.Text = .Cells("id").Value.ToString
                    txtMaterialName.Text = .Cells("m_name").Value.ToString
                    txtMaterialDescription.Text = .Cells("m_description").Value.ToString
                End With

            End If
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Friend Sub ParseFromTextbox()
        With Me._StudyMaterial
            .MaterialDescription = txtMaterialDescription.Text
            .MaterialID = txtMaterialID.Text
            .MaterialName = txtMaterialName.Text
        End With
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ParseFromTextbox()
        Dim Viewer As New frmStudyMaterialsViewer(Me._StudyMaterial)
        Viewer.ShowDialog()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs)
        Dim creator As New frmStudyMaterialsCreator()
        creator.ShowDialog()
    End Sub
End Class