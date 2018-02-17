Public Class frmGradesPreViewer

    Private _PreGrades As New c_PreGrade
    Private _MyDatatable As New DataTable

    Private Enum LinkX_Grades As Integer
        ID = 0
        UserID = 1
        QID = 2
        QGrade = 3
        QHits = 4
        QQuestions = 5
        Drp = 6
        ClassID = 7
    End Enum

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmPreGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DisplayDatatable()
        Catch xxx As Exception
            WeLearnMessageDisplay.Display(WeLearnExceptions.General, Me, xxx)
        End Try
    End Sub

    friend Sub DisplayAsPregradeviewer()
        With Me
            .txtAverage.Text = _PreGrades.ReturnFullAverage
            .txtHits.Text = _PreGrades.Hits
            .txtScore.Text = _PreGrades.ReturnFullScore
            .txtTotalQuestions.Text = _PreGrades.TotalQuestions
        End With
    End Sub

    Friend Sub DisplayDatatable()

        Dim btn As New DataGridViewButtonColumn
        With btn
            .HeaderText = "Action"
            .Text = "Open"
            .Name = "btn"
            .UseColumnTextForButtonValue = True
        End With

        With Me.DataGridView1
            .DataSource = Me._MyDatatable
            .Columns(LinkX_Grades.ClassID).Visible = False
            .Columns(LinkX_Grades.Drp).Visible = False
            .Columns(LinkX_Grades.QHits).Visible = False
            .Columns(LinkX_Grades.QQuestions).Visible = False
        End With
    End Sub

    Friend Sub DisplayQuizGrades()
        Dim Displayer As New frmGradesQuizComputer()
        _MyDatatable = Displayer.GetAnsweredQuizes(_SharedUserID, _SharedClassroom.ClassroomId)
    End Sub

    Friend Sub DisplayExamGrades()
        Dim Displayer As New frmGradeExamComputer()
        _MyDatatable = Displayer.GetAnsweredExams(_SharedUserID, _SharedClassroom.ClassroomId)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then
                With DataGridView1.Rows(e.RowIndex)
                    txtAverage.Text = (.Cells(LinkX_Grades.QHits).Value / .Cells(LinkX_Grades.QQuestions).Value)
                    txtHits.Text = .Cells(LinkX_Grades.QHits).Value.ToString()
                    txtScore.Text = .Cells(LinkX_Grades.QGrade).Value.ToString()
                    txtTotalQuestions.Text = .Cells(LinkX_Grades.QQuestions).Value.ToString()
                End With
            End If
        End If
    End Sub
End Class