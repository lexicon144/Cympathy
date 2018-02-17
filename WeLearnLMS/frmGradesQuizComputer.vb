Public Class frmGradesQuizComputer

    Private _AllQuizCount As UInt32
    Private _RecordedCount As UInt32
    Private _AverageDatatable As New DataTable
    Private _GradeSummation As Double = 0.0
    Private _FullAverage As Double = 0.0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

#Region "properties"
    Friend ReadOnly Property QuizCount As UInt32
        Get
            Return _AllQuizCount
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
#End Region

    ''' <summary>
    ''' Loading Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmGradesQuizComputer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub

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
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "CountQuiz"
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
            If .Columns.Contains("id") Then .Columns("id").Visible = False

        End With
    End Sub

    ''' <summary>
    ''' Display all necessary data outside to the GUI
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisplayOnTextboxes()
        With Me
            .txtFullAverage.Text = ._FullAverage.ToString
            .txtAllQuizes.Text = ._AllQuizCount.ToString
            .txtYourQuizes.Text = ._RecordedCount.ToString
            .txtFullSummation.Text = ._GradeSummation.ToString
        End With
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me._AverageDatatable = GetAnsweredQuizes(_SharedUserID, _SharedClassroom.ClassroomId)
        BackgroundWorker1.ReportProgress(20)
        'get sum of all recorded exams (YOU)
        GetRecordedCount(_RecordedCount)
        BackgroundWorker1.ReportProgress(40)
        'get count of all exams (ALL)
        Me._AllQuizCount = GetCountQuizesInClassroom(_SharedClassroom.ClassroomId)
        BackgroundWorker1.ReportProgress(60)
        'get sum of grades of all exams
        GetSumationOfQuizes()
        BackgroundWorker1.ReportProgress(80)

        Me._FullAverage = GetNewAverage(Me._GradeSummation, Me._AllQuizCount)
        BackgroundWorker1.ReportProgress(100)
    End Sub

    Friend Function ReturnFullAverage() As Double
        Me._AverageDatatable = GetAnsweredQuizes(_SharedUserID, _SharedClassroom.ClassroomId)

        'get sum of all recorded exams (YOU)
        GetRecordedCount(_RecordedCount)

        'get count of all exams (ALL)
        Me._AllQuizCount = GetCountQuizesInClassroom(_SharedClassroom.ClassroomId)

        'get sum of grades of all exams
        GetSumationOfQuizes()

        Me._FullAverage = GetNewAverage(Me._GradeSummation, Me._AllQuizCount)
        Return Me._FullAverage
    End Function

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        DisplayOnDatagridview()
        DisplayOnTextboxes()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        backgroundProgress.Value = e.ProgressPercentage
    End Sub
End Class