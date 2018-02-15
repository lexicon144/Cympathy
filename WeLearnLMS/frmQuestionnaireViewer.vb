Imports System.Xml.Serialization
Imports System.IO
Imports System.Security.Cryptography

Public Class frmQuestionnaireViewer

    Private _Questionnaire As New c_Questionnaire

    Private _cQuiz As New c_Quiz
    Private _cExam As New c_Exam
    Private _IsExam As Boolean
    Private _PreGrades As New c_PreGrade

    Private _Index As UInt32

    Private _Shuffler As IAnswerArrayShuffler = New ImpAnswerArrayShuffler

    Private _MyStopwatch As New Stopwatch
    Private _Countdown As UInt16 = 3

    Private newFont As New Font("Microsoft Sans Serif", 36, FontStyle.Bold)
    Private _HappyAlreadyRan As Boolean = True

    Friend ReadOnly Property GetPregrade As c_PreGrade
        Get
            Return _PreGrades
        End Get
    End Property

    ''' <summary>
    ''' Quiz Constructor
    ''' </summary>
    ''' <param name="ThisQuiz"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef ThisQuiz As c_Quiz)
        InitializeComponent()
        Me._cQuiz = ThisQuiz
        Me._IsExam = False
        If _cQuiz.QuestionBase Is Nothing Then Exit Sub
        ForEachStuff(_cQuiz.QuestionBase)
    End Sub

    ''' <summary>
    ''' Exam Constructor
    ''' </summary>
    ''' <param name="ThisExam"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef ThisExam As c_Exam)
        InitializeComponent()
        Me._cExam = ThisExam
        Me._IsExam = True
        If _cExam.QuestionBase Is Nothing Then Exit Sub
        ForEachStuff(_cExam.QuestionBase)
    End Sub
    ''' <summary>
    ''' General Creator
    ''' </summary>
    ''' <param name="ThisQuestionnaire"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef ThisQuestionnaire As c_Questionnaire)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._Questionnaire = ThisQuestionnaire
    End Sub
    ''' <summary>
    ''' Creator Via XML String
    ''' </summary>
    ''' <param name="XMLString"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef XMLString As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me._Questionnaire = DataDeserialize(XMLString)
    End Sub

    ''' <summary>
    ''' Use this to Deserialize the data
    ''' </summary>
    ''' <param name="data">XML String to return</param>
    ''' <returns>c_ShortQuiz</returns>
    ''' <remarks></remarks>
    Private Function DataDeserialize(ByVal data As String) As c_Questionnaire
        Dim xs As New XmlSerializer(GetType(c_Questionnaire))
        Dim newList As c_Questionnaire = CType(xs.Deserialize(New StringReader(data)), c_Questionnaire)
        Return newList
    End Function

    ''' <summary>
    ''' Use this Shuffler for the Questions
    ''' </summary>
    ''' <param name="ThisCollection">c_SmallQuestions</param>
    ''' <returns>c_SmallQuestion List</returns>
    ''' <remarks></remarks>
    Private Function ShufflePartTwo(ByVal ThisCollection As List(Of c_SmallQuestion)) As List(Of c_SmallQuestion)
        Dim r As Random = New Random()
        Return ThisCollection.OrderBy(Function(a) r.Next()).ToList()
    End Function

    ''' <summary>
    ''' Use this to parse the lists to the Datagridview
    ''' AKA
    ''' Setup the datagridview
    ''' </summary>
    ''' <param name="ThisType"></param>
    ''' <remarks></remarks>
    Private Sub ForEachStuff(ByRef ThisType As List(Of c_SmallQuestion))
        Dim INDEX As UInt32 = 0
        Dim AnswerArray(4) As String

        For Each item As c_SmallQuestion In ThisType

            INDEX += 1
            With item
                AnswerArray(0) = .Distractor1
                AnswerArray(1) = .Distractor2
                AnswerArray(2) = .Distractor3
                AnswerArray(3) = .Distractor4
                '_Shuffler.Shuffle(AnswerArray)
                DataGridView1.Rows.Add(INDEX, .QuestionBase, AnswerArray(0), AnswerArray(1), AnswerArray(2), AnswerArray(3))
            End With
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            _HappyAlreadyRan = True
            
            With DataGridView1.Rows(e.RowIndex)
                Me._Index = e.RowIndex
                RichTextBox1.Text = .Cells("tttQuestionBase").Value.ToString()
                RadioButton1.Text = .Cells("tttDistractor1").Value.ToString()
                RadioButton2.Text = .Cells("tttDistractor2").Value.ToString()
                RadioButton3.Text = .Cells("tttDistractor3").Value.ToString()
                RadioButton4.Text = .Cells("tttDistractor4").Value.ToString()

            End With
        End If
        With Me
            .RadioButton1.Checked = False
            .RadioButton2.Checked = False
            .RadioButton3.Checked = False
            .RadioButton4.Checked = False
        End With
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click
        Dim i = DataGridView1.CurrentRow.Index

        With DataGridView1
            .Rows(i).Cells("tttANS").Value = DirectCast(sender, RadioButton).Text
        End With
    End Sub

    ''' <summary>
    ''' Count all the Correct Answers VS All Answers
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Counter()
        Dim AllQuestions As UInt16 = DataGridView1.Rows.Count
        Dim Hits As UInt16 = 0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("tttANS").Value = row.Cells("tttDistractor4").Value Then
                Hits += 1
            End If
        Next

        With Me._PreGrades
            .Hits = Hits
            .TotalQuestions = AllQuestions

        End With
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        With DirectCast(sender, RadioButton)
            If .Checked = True Then
                'TODO - SET THE "YOUR ANSWER" COLUMN INTO THE TEXT OF THE RADIO BUTTON!
                Dim UpdatedDataRow As DataGridViewRow
                UpdatedDataRow = DataGridView1.Rows(Me._Index)
                'Set Cells equal to the Senders Text property
                UpdatedDataRow.Cells(5).Value = .Text
            End If
        End With
    End Sub

    Private Sub frmQuestionnaireViewer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Counter()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmQuestionnaireViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings("QuestMainBackground")
        With Me
            With .DataGridView1
                .Columns("tttANS").Visible = False
                .Columns("tttDistractor1").Visible = False
                .Columns("tttDistractor2").Visible = False
                .Columns("tttDistractor3").Visible = False
                .Columns("tttDistractor4").Visible = False
                .Columns("tttANS").Visible = False
                .Columns("tttANS").Visible = False
            End With
        End With
        Dim wallop As New frmWALLOP
        wallop.ShowDialog()
        Me.WALLOP()
    End Sub

    Private Sub DevAutoFill(ByVal Limit As UInt32)
        Dim Count As UInt32 = 1
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells("tttANS").Value = row.Cells("tttDistractor4").Value
            If Count >= Limit Then Exit For
            Count += 1
        Next
    End Sub

    Private Sub btnDevAuto13_Click(sender As Object, e As EventArgs) Handles btnDevAuto13.Click
        Try
            DevAutoFill(CInt(TextBox1.Text))
        Catch XXX As Exception
            MessageBox.Show("Really bruh?")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        With Me
            .lblHours.Text = ._MyStopwatch.Elapsed.Hours
            .lblMinutes.Text = ._MyStopwatch.Elapsed.Minutes
            .lblSeconds.Text = ._MyStopwatch.Elapsed.Seconds
        End With
        CheatDetector()
    End Sub

    Private Sub WALLOP()
        Me._MyStopwatch.Start()
        Me.Timer1.Start()
    End Sub

    Private Sub CheatDetector()
        If WeLearnAC.AntiCheat() Then
            With Me
                .BackColor = Color.Red
                .TableLayoutPanel1.BackColor = Color.Red
                .RdButtonPanel.BackColor = Color.Red
                .mainpanel.Enabled = False
                With .RichTextBox1
                    .Text = "I trusted you..."
                    .SelectAll()
                    .SelectionFont = newFont
                    .BackColor = Color.Red
                End With
                .Text = RichTextBox1.Text
                .RadioButton1.Text = "I thought we were friends"
                .RadioButton2.Text = "Why would you do that?"
                .RadioButton3.Text = "Please... don't do this"
                .RadioButton4.Text = "There is still hope... reconsider!"
            End With
            _HappyAlreadyRan = False
            Exit Sub
        End If
        With Me
            With .RichTextBox1
                .BackColor = Control.DefaultBackColor
            End With
            .BackColor = Control.DefaultBackColor
            .RdButtonPanel.BackColor = Control.DefaultBackColor
            .TableLayoutPanel1.BackColor = Control.DefaultBackColor
            .Text = Me.Name
            .mainpanel.Enabled = True
            SetRadioButtons()
        End With
    End Sub

    Private Sub SetRadioButtons()
        If _HappyAlreadyRan Then Exit Sub
        With Me
            .RichTextBox1.Clear()
            .RadioButton1.Text = "Thank you"
            .RadioButton2.Text = "> salutes you"
            .RadioButton3.Text = "You can do it!! I know you can!"
            .RadioButton4.Text = "Thank you so much <3"
        End With
    End Sub

    Private Sub ChangeColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If
    End Sub
End Class