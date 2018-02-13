Imports System.IO
Imports System.Xml.Serialization

Public Class frmQuizCreator

    Private _NewQuiz As New c_Quiz
    Private _Serializer As IDataSerializer = New ImpDataSerializer
    Private _Deserializer As IDataDeserializer = New ImpDataDeserializer

    Private Sub frmQuizCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Creator As New frmQuestionnaireCreator

            Creator.ShowDialog()
            With Me._NewQuiz
                .QuestionBase = Creator.GetBASE
                .QuestionnaireType = Creator.GetQType
            End With

            ParseToTextbox()

        Catch XXX As Exception
            DisplayGeneralException(XXX)
        Finally
            txtQuizName.Focus()
        End Try

    End Sub

    Private Function ListIsNull(ByRef base As List(Of c_SmallQuestion)) As Boolean
        Return (base Is Nothing)
    End Function


    Private Sub InsertQuiz()
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Dim QuizTransaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand
                    With Command
                        .Connection = Connection
                        .CommandText = "INSERT INTO tbl_quizes(quest_name, xml_base, state_long, drp) VALUES (@QuizName, @QuizBase, @QuizState, @Drp)"
                        With .Parameters
                            .AddWithValue("@QuizName", Me.txtQuizName.Text)
                            .AddWithValue("@QuizBase", Me.rtbXMLPreview.Text)
                            .AddWithValue("@QuizState", Me._NewQuiz.QuestionnaireType)
                            .AddWithValue("@Drp", False)
                        End With
                        .ExecuteNonQuery()
                        QuizTransaction.Commit()
                        MessageBox.Show("Quiz Creation Completed Successfully. Committed Automatically", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End With
                End Using
            Catch XXX As Exception
                QuizTransaction.Rollback()
                MessageBox.Show("Quiz Creation Completed Unsuccessfully. Rolledback Automatically" & vbNewLine & XXX.Message, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End Using
    End Sub

    Private Sub btnEditor_Click(sender As Object, e As EventArgs) Handles btnEditor.Click
        If Me.rtbXMLPreview.Text = "" Then Exit Sub

        ParseFromTextbox()
        Dim Editor As New frmQuestionnaireCreator(_NewQuiz.QuestionBase, False)
        Editor.ShowDialog()
        Me._NewQuiz.QuestionBase = Editor.GetBASE
        ParseToTextbox()
    End Sub

    Private Sub ParseFromTextbox()
        With Me._NewQuiz
            .QuestionBase = _Deserializer.DataDeserialize(Me.rtbXMLPreview.Text)
            .QuestionnaireName = txtQuizName.Text
            .QuestionnaireType = [Enum].Parse(GetType(QType), txtQuizType.Text, True)
        End With
    End Sub

    Private Sub ParseToTextbox()

        Me.txtQuizType.Text = [Enum].GetName(GetType(QType), Me._NewQuiz.QuestionnaireType)
        Me.txtQuizName.Text = Me._NewQuiz.QuestionnaireName
        Me.txtQuizType.Text = Me._NewQuiz.QuestionnaireType
        Me.rtbXMLPreview.Text = _Serializer.DataSerialize(Me._NewQuiz.QuestionBase)
        Me.txtQuizName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.rtbXMLPreview.Text = "" Or Me.txtQuizName.Text = "" Then Exit Sub
        If ListIsNull(Me._NewQuiz.QuestionBase) Then
            ErrorProvider1.SetError(rtbXMLPreview, "Invalid BASE")
        End If
        InsertQuiz()
    End Sub

    Private Sub txtQuizName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtQuizName.Validating
        If Not _SharedValidator.Verify(VMethodology.Username, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid QuizName")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub txtQuizName_Validated(sender As Object, e As EventArgs) Handles txtQuizName.Validated

    End Sub
End Class