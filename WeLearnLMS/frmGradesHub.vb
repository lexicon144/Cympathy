Public Class frmGradesHub

    Private _Grade As New c_Grades
    Private _Classroom As New c_Classroom

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmGradesHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim classroomdialog As New frmClassroomDialog()
        If classroomdialog.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub
End Class