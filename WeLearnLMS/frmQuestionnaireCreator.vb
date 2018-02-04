Imports System.IO
Imports System.Xml.Serialization
Imports System.Text


Public Class frmQuestionnaireCreator

    Private _QuizType As QType
    'Private _Questionnaire As New c_Questionnaire
    Private _Questionnaire As New c_Quiz

    Friend ReadOnly Property GetQuiz As c_Quiz
        Get
            Return Me._Questionnaire
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' Editor Constructor VIA QUIZ
    ''' </summary>
    ''' <param name="QUIZ"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef QUIZ As c_Quiz)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        DumpForEdit(QUIZ)
        With Me
            .txtTitle.Text = QUIZ.QuestionnaireName

        End With
    End Sub

    ''' <summary>
    ''' Dump This Quiz to Textboxes
    ''' </summary>
    ''' <param name="Quiz"></param>
    ''' <remarks></remarks>
    Private Sub DumpForEdit(ByRef Quiz As c_Quiz)
        ForEachStuff(Quiz.QuestionBase)
    End Sub

    ''' <summary>
    ''' Use this to parse the lists to the Datagridview
    ''' AKA
    ''' Setup the datagridview
    ''' </summary>
    ''' <param name="ThisType">List of C_SmallQuestion</param>
    ''' <remarks></remarks>
    Private Sub ForEachStuff(ByVal ThisType As List(Of c_SmallQuestion))
        For Each item As c_SmallQuestion In ThisType
            With item
                Datagridview1.Rows.Add(.QuestionBase, .Distractor1, .Distractor2, .Distractor3, .Distractor4)
            End With
        Next
    End Sub

    ''' <summary>
    ''' Create a list of questions from the Datagridview
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreateList() As List(Of c_SmallQuestion)
        Dim QuestionList As New List(Of c_SmallQuestion)
        Dim Number As UInt32 = 0
        For Each row As DataGridViewRow In Datagridview1.Rows
            Number += 1
            If Not row.IsNewRow Then
                QuestionList.Add(
                    New c_SmallQuestion(
                        Number,
                        row.Cells(0).Value.ToString,
                        row.Cells(1).Value.ToString,
                        row.Cells(2).Value.ToString,
                        row.Cells(3).Value.ToString,
                        row.Cells(4).Value.ToString,
                        row.Cells(4).Value.ToString
                        )
                    )
            End If
        Next
        Return QuestionList
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddNewRow()
    End Sub

    Private Sub AddNewRow()
        Dim NewRow As String() = New String() {txtQuestion.Text, txtDisc1.Text, txtDisc2.Text, txtDisc3.Text, txtDisc4.Text}
        Datagridview1.Rows.Add(NewRow)

        txtQuestion.Text = Nothing
        txtDisc1.Text = Nothing
        txtDisc2.Text = Nothing
        txtDisc3.Text = Nothing
        txtDisc4.Text = Nothing
    End Sub

    ''' <summary>
    ''' Create a Questionnaire Object (METHOD IS FULL SERIALIZATION)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSerialize_Click(sender As Object, e As EventArgs) Handles btnSerialize.Click

        With Me._Questionnaire
            .QuestionBase = CreateList()
            .QuestionnaireName = txtTitle.Text
            .QuestionnaireType = _QuizType
        End With

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdSQUIZ.CheckedChanged
        Me._QuizType = QType.SQUIZ
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdPEXAM.CheckedChanged
        Me._QuizType = QType.PEXAM
    End Sub

    Private Sub Datagridview1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview1.CellContentClick

        With Datagridview1.Rows(e.RowIndex)
            txtQuestion.Text = .Cells(0).Value.ToString()
            txtDisc1.Text = .Cells(1).Value.ToString()
            txtDisc2.Text = .Cells(2).Value.ToString()
            txtDisc3.Text = .Cells(3).Value.ToString()
            txtDisc4.Text = .Cells(4).Value.ToString()
        End With

    End Sub

    Private Sub btnFillUpQuiz_Click(sender As Object, e As EventArgs) Handles btnFillUpQuiz.Click
        For I As UInt32 = 0 To 99
            txtQuestion.Text = "correct answer is : " & I
            txtDisc1.Text = Randomizer.ToString
            txtDisc2.Text = Randomizer.ToString
            txtDisc3.Text = Randomizer.ToString
            txtDisc4.Text = I.ToString

            AddNewRow()
        Next
    End Sub

    Private Function Randomizer() As StringBuilder
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb
    End Function

    Private Sub frmQuestionnaireCreator_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmQuestionnaireCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtTitle_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTitle.Validating
        If Not _SharedValidator.Verify(VMethodology.Username, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid Text")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub txtTitle_Validated(sender As Object, e As EventArgs) Handles txtTitle.Validated
        Me._Questionnaire.QuestionnaireName = DirectCast(sender, TextBox).Text
    End Sub
End Class