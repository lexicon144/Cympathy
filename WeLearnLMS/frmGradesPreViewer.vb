Public Class frmGradesPreViewer

    Private _PreGrades As New c_PreGrade

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef MyPreGrades As c_PreGrade)
        InitializeComponent()
        Me._PreGrades = MyPreGrades
    End Sub

    Private Sub frmPreGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .txtAverage.Text = _PreGrades.ReturnFullAverage
            .txtHits.Text = _PreGrades.Hits
            .txtScore.Text = _PreGrades.ReturnFullScore
            .txtTotalQuestions.Text = _PreGrades.TotalQuestions
        End With
    End Sub
End Class