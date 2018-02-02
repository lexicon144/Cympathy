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

    Private Sub btnToggleRO_CheckedChanged(sender As Object, e As EventArgs) Handles btnToggleRO.CheckedChanged
        With Me
            .txtClassroomID.ReadOnly = DirectCast(sender, CheckBox).CheckState
            .txtClassroomName.ReadOnly = DirectCast(sender, CheckBox).CheckState
            .txtUserID.ReadOnly = DirectCast(sender, CheckBox).CheckState
            .txtUserName.ReadOnly = DirectCast(sender, CheckBox).CheckState
        End With
    End Sub

    Private Sub frmGradesFinalCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnUserBrowser_Click(sender As Object, e As EventArgs) Handles btnUserBrowser.Click
        Dim userbrowser As New frmUsersViewer()
        If userbrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            With Me._Grades
                .UserID = userbrowser.GetSmallCredentials.UserID
                .UserName = userbrowser.GetSmallCredentials.UserName
            End With
        End If
    End Sub

    Private Sub btnClassroomBrowser_Click(sender As Object, e As EventArgs) Handles btnClassroomBrowser.Click
        Dim classroombrowser As New frmClassroomDialog()
        If classroombrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            With Me._Grades
                .ClassroomID = classroombrowser.GetClassroom.ClassroomId
                .ClassroomName = classroombrowser.GetClassroom.ClassroomName
            End With
        End If
    End Sub

    Private Sub PerformTransaction(ByRef UserID As String, ByRef ClassID As String, ByRef GradeValue As Double)
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Try
                Using GradeTransaction As MySqlTransaction = Connection.BeginTransaction
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
                        End With
                    End Using
                End Using
            Catch xxx As Exception
            End Try

        End Using
    End Sub

    Private Sub btnFinalizeGrades_Click(sender As Object, e As EventArgs) Handles btnFinalizeGrades.Click

    End Sub
End Class