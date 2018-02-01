Imports System.Xml.Serialization
Imports System.IO

Public Class frmExamsHub

    Private _Datatable As New DataTable
    Private _ClassroomID As String
    Private _XmlBase As String

    Private _Exam As New c_Exam

    Private _IsModal As Boolean = False

    Friend ReadOnly Property RetrieveExam As c_Exam
        Get
            Return _Exam
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
        Me.btnOK.Enabled = False
        Me._IsModal = True

        LoadDatagridView()
    End Sub

    Public Sub New(ByRef ThisClassroom As c_Classroom)
        InitializeComponent()
        Me._ClassroomID = ThisClassroom.ClassroomId
        Me._IsModal = False

        LoadDatagridView(ThisClassroom.ClassroomId)
    End Sub

    Friend Sub LoadDatagridView()
        Try
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
                        .CommandText = "SELECT * FROM tbl_exams"
                    End With

                    Using Adapter As New MySqlDataAdapter
                        With Adapter
                            .SelectCommand = Command
                            .Fill(_Datatable)
                        End With
                    End Using
                End Using
            End Using
        Catch XXX As Exception
            DisplayNoDatagridView(XXX)
        End Try
    End Sub
    Friend Sub LoadDatagridView(ByRef ClassroomID As String)
        Try
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
                        .CommandText = "SelectExamsFromThisClass"
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
        Catch XXX As Exception
            DisplayNoDatagridView(XXX)
        End Try
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmExamHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Dim btn As New DataGridViewButtonColumn()

        With btn
            .HeaderText = "Action"
            .Text = "Open"
            .Name = "btn"
            .UseColumnTextForButtonValue = True
        End With
        If Me._Datatable Is Nothing And Me._Datatable.Rows.Count = 0 Then Exit Sub

        With DataGridView1
            .DataSource = _Datatable
            .Columns.Add(btn)

            .Columns("xml_base").Visible = False
        End With

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then

                With DataGridView1.Rows(e.RowIndex)
                    txtExamID.Text = .Cells("id").Value.ToString()
                    txtExamName.Text = .Cells("exam_name").Value.ToString()
                    _XmlBase = .Cells("xml_base").Value.ToString()
                End With

            End If
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim viewer As New frmExamsViewer
        viewer.ShowDialog()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs)

    End Sub
End Class