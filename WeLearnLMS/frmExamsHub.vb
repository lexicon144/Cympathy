Imports System.Xml.Serialization
Imports System.IO

Public Class frmExamsHub

    Private _Datatable As New DataTable
    Private _ClassroomID As String
    Private _XmlBase As String
    Private _Deserializer As IDataDeserializer = New ImpDataDeserializer
    Private _TempPIN As String
    Private _Exam As New c_Exam

    Friend ReadOnly Property GetExam As c_Exam
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
        
        LoadDatagridView()
    End Sub

    Public Sub New(ByRef ThisClassroom As c_Classroom)
        InitializeComponent()
        Me._ClassroomID = ThisClassroom.ClassroomId

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
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SelectAllExams"
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
            WeLearnMessageDisplay.Display(WeLearnExceptions.DGV, Me, XXX)
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
            WeLearnMessageDisplay.Display(WeLearnExceptions.DGV, Me, XXX)
        End Try
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtExamID.Text = "" AndAlso txtExamName.Text = "" Then Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmExamHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Dim btn As New DataGridViewButtonColumn()

        With btn
            .HeaderText = "Action"
            .Text = "Select"
            .Name = "btn"
            .UseColumnTextForButtonValue = True
        End With
        If Not Me._Datatable.Rows.Count = 0 Then

            With DataGridView1
                .DataSource = _Datatable
                .Columns.Add(btn)
                If .Columns.Contains("xml_base") Then .Columns("xml_base").Visible = False
                If .Columns.Contains("exam_pin") Then .Columns("exam_pin").Visible = False
                If .Columns.Contains("drp") Then .Columns("drp").Visible = False

            End With
        End If


    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
                If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then

                    With DataGridView1.Rows(e.RowIndex)
                        _TempPIN = .Cells("exam_pin").Value.ToString()
                        txtExamID.Text = .Cells("id").Value.ToString()
                        txtExamName.Text = .Cells("exam_name").Value.ToString()
                        _XmlBase = .Cells("xml_base").Value.ToString()

                    End With

                End If
            End If
        Catch xxx As Exception
            WeLearnMessageDisplay.Display(WeLearnExceptions.DGV, sender, xxx)
        End Try
    End Sub

    Private Sub ParseToMe()
        With Me._Exam
            .QuestionnaireID = txtExamID.Text
            .QuestionnaireName = txtExamName.Text
            .QuestionBase = _Deserializer.DataDeserialize(Me._XmlBase)
            .PIN = _TempPIN
        End With
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Me._Exam.QuestionBase = _Deserializer.DataDeserialize(Me._XmlBase)
            ParseToMe()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch xxx As Exception
            WeLearnMessageDisplay.Display(WeLearnExceptions.Simple, sender, xxx)
        End Try
    End Sub

End Class