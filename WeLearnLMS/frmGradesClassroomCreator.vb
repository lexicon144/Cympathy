Public Class frmGradesClassroomCreator

    Private _Grades As New c_Grades
    Private _UserID As String
    Private _ClassID As String
    Private _GradeValue As Double

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub RefreshData()
        With Me
            .txtClassroomID.Text = ._Grades.ClassroomID
            .txtClassroomName.Text = ._Grades.ClassroomName
            .txtUserID.Text = ._Grades.UserID
            .txtUserName.Text = ._Grades.UserName
        End With
    End Sub

    Private Sub btnToggleRO_CheckedChanged(sender As Object, e As EventArgs) Handles btnToggleRO.CheckedChanged
        With Me
            .txtClassroomID.ReadOnly = DirectCast(sender, CheckBox).CheckState
            .txtClassroomName.ReadOnly = DirectCast(sender, CheckBox).CheckState
            .txtUserID.ReadOnly = DirectCast(sender, CheckBox).CheckState
            .txtUserName.ReadOnly = DirectCast(sender, CheckBox).CheckState
        End With
    End Sub

    Private Sub frmGradesFinalCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnToggleRO.Checked = True
    End Sub

    Private Sub btnUserBrowser_Click(sender As Object, e As EventArgs) Handles btnUserBrowser.Click
        Dim userbrowser As New frmUsersViewer()
        If userbrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            With Me._Grades
                .UserID = userbrowser.GetSmallCredentials.UserID
                .UserName = userbrowser.GetSmallCredentials.UserName
            End With
        End If
        RefreshData()
    End Sub

    Private Sub btnClassroomBrowser_Click(sender As Object, e As EventArgs) Handles btnClassroomBrowser.Click
        Dim classroombrowser As New frmClassroomDialog()
        If classroombrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            With Me._Grades
                .ClassroomID = classroombrowser.GetClassroom.ClassroomId
                .ClassroomName = classroombrowser.GetClassroom.ClassroomName
            End With
        End If
        RefreshData()
    End Sub

    Private Sub PerformTransaction(ByRef UserID As String, ByRef ClassID As String, ByRef GradeValue As Double)
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With

            Dim GradeTransaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand
                    With Command
                        .Connection = Connection
                        .Transaction = GradeTransaction
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "InsertClassroomGrade"
                        With .Parameters
                            .AddWithValue("UserID", UserID)
                            .AddWithValue("ClassID", ClassID)
                            .AddWithValue("GradeValue", GradeValue)
                        End With
                        .ExecuteNonQuery()
                        GradeTransaction.Commit()
                        MessageBox.Show("Grade Transaction Succeeded", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End With
                End Using
            Catch xxx As Exception
                GradeTransaction.Rollback()
                DisplayLinkingTransactionFailed(xxx)
            End Try

        End Using
    End Sub


    Private Sub btnFinalizeGrades_Click(sender As Object, e As EventArgs) Handles btnFinalizeGrades.Click
        PerformTransaction(Me._UserID, Me._ClassID, Me._GradeValue)
    End Sub

    Private Sub btnMakeGrades_Click(sender As Object, e As EventArgs) Handles btnMakeGrades.Click
        Dim GradeComputer As New frmGradesPreCompiler()
        If GradeComputer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With Me
                .txtAverage.Text = GradeComputer.CompileAllGrades().ToString
            End With
        End If
        RefreshData()
    End Sub

End Class