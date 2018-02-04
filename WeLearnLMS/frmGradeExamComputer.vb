Public Class frmGradeExamComputer

    Private _QuestionnaireCount As UInt32
    Private _RecordedCount As UInt32
    Private _AverageDatatable As New DataTable
    Private _GradeSummation As Double = 0.0
    Private _FullAverage As Double = 0.0

    Private Sub frmGradeExamComputer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Friend ReadOnly Property ExamCount As UInt32
        Get
            Return _QuestionnaireCount
        End Get
    End Property

    Friend ReadOnly Property RecordedCount As UInt32
        Get
            Return _RecordedCount
        End Get
    End Property

    Friend ReadOnly Property GradeSummation As Double
        Get
            Return _GradeSummation
        End Get
    End Property

    Friend ReadOnly Property FullAverage As Double
        Get
            Return _FullAverage
        End Get
    End Property

    ''' <summary>
    ''' Find the count of all registered Quizes in ThisClassroom
    ''' </summary>
    ''' <param name="ClassroomID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetCountQuizesInClassroom(ByRef ClassroomID As String)
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With

            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandText = "SELECT COUNT(id) FROM link_quiz WHERE drp = FALSE AND class_id = @ClassID"
                    With .Parameters
                        .AddWithValue("ClassID", ClassroomID)
                    End With
                    Return .ExecuteScalar()
                End With
            End Using
        End Using
    End Function

    ''' <summary>
    ''' Summate all the quiz grades
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetSumationOfQuizes()
        Me._GradeSummation = 0.0
        For Each Row As DataRow In Me._AverageDatatable.Rows
            Me._GradeSummation += Row("quiz_grade")
        Next
    End Sub

    ''' <summary>
    ''' Return the Count of AverageDatatable
    ''' This could also be known as the 
    ''' Count of all the Quizes the Studen Answered
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetRecordedCount(ByVal Count As UInt32)
        Count = Me._AverageDatatable.Rows.Count
    End Sub

    ''' <summary>
    ''' Get The Datatable containing all the quizes
    ''' </summary>
    ''' <param name="UserID"></param>
    ''' <param name="ClassID"></param>
    ''' <remarks></remarks>
    Friend Function GetAnsweredQuizes(ByRef UserID As String, ByRef ClassID As String) As DataTable
        Dim DimTable As New DataTable
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With

            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SelectGradesQuizes"
                    With .Parameters
                        .AddWithValue("UserID", UserID)
                        .AddWithValue("ClassID", ClassID)
                    End With
                End With
                Using Adapter As New MySqlDataAdapter(Command)
                    With Adapter
                        .Fill(DimTable)
                    End With
                End Using
            End Using
        End Using
        Return DimTable
    End Function

    ''' <summary>
    ''' Get Full average of all quizes
    ''' </summary>
    ''' <param name="Summation">The Summated grade of all quizes</param>
    ''' <param name="Count">The Count of all existing quizes</param>
    ''' <returns>a Double</returns>
    ''' <remarks></remarks>
    Private Function GetNewAverage(ByVal Summation As Double, ByVal Count As UInt32) As Double
        Return (Summation / Count)
    End Function

    ''' <summary>
    ''' Display all necessary data outside to the GUI
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisplayOnDatagridview()

        Dim btn As New DataGridViewButtonColumn()

        With btn
            .HeaderText = "Action"
            .Text = "Open"
            .Name = "btn"
            .UseColumnTextForButtonValue = True
        End With

        With DataGridView1

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DataSource = Me._AverageDatatable
            .Columns.Add(btn)
            .Refresh()
        End With
    End Sub

    ''' <summary>
    ''' Display all necessary data outside to the GUI
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisplayOnTextboxes()
        With Me
            .txtFullAverage.Text = ._FullAverage.ToString
            .txtLinkedExams.Text = ._QuestionnaireCount.ToString
            .txtRecordedExams.Text = ._RecordedCount.ToString
        End With
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me._AverageDatatable = GetAnsweredQuizes(_SharedUserID, _SharedClassroomID)
        GetRecordedCount(_RecordedCount)
        GetCountQuizesInClassroom(_SharedClassroomID)
        GetSumationOfQuizes()
        Me._FullAverage = GetNewAverage(Me._GradeSummation, Me._RecordedCount)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        DisplayOnDatagridview()
        DisplayOnTextboxes()
    End Sub

End Class