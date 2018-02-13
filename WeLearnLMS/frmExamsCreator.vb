Imports System.IO
Imports System.Xml.Serialization

Public Class frmExamsCreator

    Private _NewExam As New c_Exam()
    Private _Serializer As IDataSerializer = New ImpDataSerializer
    Private _Deserializer As IDataDeserializer = New ImpDataDeserializer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmExamsCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Creator As New frmQuestionnaireCreator()

            Creator.ShowDialog(Me)
            With Me._NewExam

                .QuestionBase = Creator.GetBASE
                .QuestionnaireType = QType.OEXAM

            End With
            ParseToTextbox()
        Catch XXX As Exception
            DisplayGeneralException(XXX)
        Finally
            txtExamName.Focus()
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
                        .CommandText = "INSERT INTO tbl_exams(exam_name, xml_base, drp, exam_pin) VALUES (@ExamName, @ExamBase, FALSE, @ExamPin)"
                        With .Parameters
                            .AddWithValue("@ExamName", _NewExam.QuestionnaireName)
                            .AddWithValue("@ExamBase", rtbXMLPreview.Text)
                            .AddWithValue("@ExamPin", _NewExam.PIN)
                        End With
                        .ExecuteNonQuery()
                        QuizTransaction.Commit()
                        MessageBox.Show("Exam Creation Completed Successfully. Committed Automatically", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End With
                End Using
            Catch XXX As Exception
                QuizTransaction.Rollback()
                MessageBox.Show("Exam Creation Completed Unsuccessfully. Rolledback Automatically : " & vbNewLine & XXX.Message, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End Using
    End Sub

    Private Sub btnEditor_Click(sender As Object, e As EventArgs) Handles btnEditor.Click

        If Me._NewExam.QuestionBase Is Nothing Then Exit Sub

        Dim Editor As New frmQuestionnaireCreator(Me._NewExam.QuestionBase, True)
        If Editor.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Me._NewExam.QuestionBase = Editor.GetBASE
            Me._NewExam.QuestionnaireType = QType.OEXAM
        End If

        ParseToTextbox()
    End Sub

    Private Sub ParseToTextbox()
        Me.txtQType.Text = [Enum].GetName(GetType(QType), Me._NewExam.QuestionnaireType)
        Me.txtExamName.Text = Me._NewExam.QuestionnaireName
        Me.txtQType.Text = Me._NewExam.QuestionnaireType
        Me.rtbXMLPreview.Text = DataSerialize(Me._NewExam.QuestionBase)
        Me.txtExamName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.rtbXMLPreview.Text = "" Or txtExamName.Text = "" Or txtExamPIN.Text = "" Then Exit Sub
        If ListIsNull(Me._NewExam.QuestionBase) Then
            ErrorProvider1.SetError(rtbXMLPreview, "Invalid BASE")
        End If
        InsertQuiz()
    End Sub

    Private Sub txtExamName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtExamName.Validating
        If Not _SharedValidator.Verify(VMethodology.Username, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid Exam Name")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub txtExamName_Validated(sender As Object, e As EventArgs) Handles txtExamName.Validated
        Me._NewExam.QuestionnaireName = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub txtExamPIN_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtExamPIN.Validating
        If Not _SharedValidator.Verify(VMethodology.Numbers, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid PIN")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub txtExamPIN_Validated(sender As Object, e As EventArgs) Handles txtExamPIN.Validated
        Me._NewExam.PIN = DirectCast(sender, TextBox).Text
    End Sub
End Class