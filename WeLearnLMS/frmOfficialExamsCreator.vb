Imports System.Text

Public Class frmOfficialExamsCreator

    Private _Questionnaire As New c_Exam

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="EXAM"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef EXAM As c_Exam)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        DumpForEdit(EXAM)
        With Me
            .txtTitle.Text = EXAM.QuestionnaireName

        End With

    End Sub


    ''' <summary>
    ''' Dump This Exam to Textboxes
    ''' </summary>
    ''' <param name="Exam"></param>
    ''' <remarks></remarks>
    Private Sub DumpForEdit(ByRef Exam As c_Exam)
        ForEachStuff(Exam.QuestionBase)
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
    ''' Return The generated Exam
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend ReadOnly Property GetOfficialExam As c_Exam
        Get
            Return _Questionnaire
        End Get
    End Property

    Private Sub Datagridview1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview1.CellContentClick

        With Datagridview1.Rows(e.RowIndex)
            txtQuestion.Text = .Cells(0).Value.ToString()
            txtDisc1.Text = .Cells(1).Value.ToString()
            txtDisc2.Text = .Cells(2).Value.ToString()
            txtDisc3.Text = .Cells(3).Value.ToString()
            txtDisc4.Text = .Cells(4).Value.ToString()
        End With

    End Sub

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

    Private Sub btnSerialize_Click(sender As Object, e As EventArgs) Handles btnSerialize.Click

        With Me._Questionnaire
            .PIN = txtPIN.Text
            .QuestionBase = CreateList()
            .QuestionnaireName = txtTitle.Text
            .QuestionnaireType = QType.OEXAM
        End With

        Me.DialogResult = Windows.Forms.DialogResult.OK
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

    Private Sub frmOfficialExamsCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFillUpQuiz_Click(sender As Object, e As EventArgs) Handles btnFillUpQuiz.Click
        For I As UInt32 = 1 To 100
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

End Class