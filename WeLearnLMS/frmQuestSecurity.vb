Public Class frmQuestSecurity

    Private _Passed As Boolean

    Private C_Exam As New c_Exam
    Private MyPin As String

    ''' <summary>
    ''' MAin Constructor to Retrieve EXAM
    ''' </summary>
    ''' <param name="Exam"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef Exam As c_Exam)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.C_Exam = Exam
    End Sub

    Friend ReadOnly Property Passed As Boolean
        Get
            Return _Passed
        End Get
    End Property

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Evaluate()
        If _Passed Then
            Console.WriteLine(Me._Passed)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Exit Sub
        End If

        Me.DialogResult = Windows.Forms.DialogResult.Abort

    End Sub

    Private Sub Evaluate()
        Me._Passed = (C_Exam.PIN = MyPin)
    End Sub

    Private Sub frmQuestSecurity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With Me
            .txtExamID.Text = .C_Exam.QuestionnaireID
            .txtExamName.Text = .C_Exam.QuestionnaireName
        End With
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        If Not _SharedValidator.Verify(VMethodology.Username, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid Input")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated
        Me.MyPin = DirectCast(sender, TextBox).Text
    End Sub
End Class