Imports System.IO
Imports System.Xml.Serialization

Public Class frmExamsCreator

    Private _NewExam As New c_Exam

    Private _Deserializer As IDataDeserializer = New ImpDataDeserializer
    Private _Serializer As IDataSerializer = New ImpDataSerializer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmExamsCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim Creator As New frmOfficialExamsCreator()

        If Creator.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then Me._NewExam = Creator.GetOfficialExam

        If Me._NewExam.QuestionBase Is Nothing Then Exit Sub
        ParseToTextbox()


    End Sub

    ''' <summary>
    ''' Use this to Serialize the Data
    ''' </summary>
    ''' <param name="myList">C_Exam to serialize</param>
    ''' <returns>XML String ready for being saved to the database</returns>
    ''' <remarks></remarks>
    Private Function DataSerialize(ByVal myList As List(Of c_SmallQuestion)) As String
        Dim sw As StringWriter = New StringWriter()
        Dim s As New XmlSerializer(myList.GetType())
        s.Serialize(sw, myList)
        Return sw.ToString()
    End Function

    ''' <summary>
    ''' Use this to Deserialize the data
    ''' </summary>
    ''' <param name="data">XML String to return</param>
    ''' <returns>c_ShortQuiz</returns>
    ''' <remarks></remarks>
    Public Shared Function DataDeserialize(ByVal data As String) As List(Of c_SmallQuestion)
        Dim xs As New XmlSerializer(GetType(c_Exam))
        Dim newList As List(Of c_SmallQuestion) = CType(xs.Deserialize(New StringReader(data)), List(Of c_SmallQuestion))
        Return newList
    End Function


    Private Sub InsertQuiz()
        Using Connection As New MySqlConnection
            With Connection
                .ConnectionString = _SharedConnString.ConnString
                If .State = ConnectionState.Open Then
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

        Dim Editor As New frmOfficialExamsCreator()
        If Editor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me._NewExam = Editor.GetOfficialExam
        End If

        ParseToTextbox()
    End Sub

    Private Sub ParseToTextbox()
        Try
            Me.rtbXMLPreview.Text = DataSerialize(Me._NewExam.QuestionBase)
            Me.txtExamName.Text = _NewExam.QuestionnaireName
            Me.txtExamPIN.Text = _NewExam.PIN
        Catch XXX As Exception
            DisplayExamCreationException(XXX)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.rtbXMLPreview.Text = "" Or txtExamName.Text = "" Or txtExamPIN.Text = "" Then Exit Sub
        InsertQuiz()
    End Sub
End Class