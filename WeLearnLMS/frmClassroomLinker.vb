Public Class frmClassroomLinker

    Private _Classroom As New c_Classroom
    Private _User As New c_MainCredentials

    Friend WriteOnly Property SetUser As c_MainCredentials
        Set(value As c_MainCredentials)
            _User = value
        End Set
    End Property

    Public Sub New(ByRef Classroom As c_Classroom)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._Classroom = Classroom

    End Sub

    Private Sub frmClassroomLinker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Browser As New frmUsersViewer
        If Browser.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me._User = Browser.GetSmallCredentials
        End If
        ParseToTextbox()
    End Sub

    Private Sub ParseToTextbox()

        txtStudentID.Text = _User.UserID
        txtStudentName.Text = _User.UserName
        txtClassDesc.Text = _Classroom.ClassroomDesc
        txtClassID.Text = _Classroom.ClassroomId
        txtClassName.Text = _Classroom.ClassroomName
    End Sub

    Private Sub PerformLink()
        Using Connection As New MySqlConnection
            With Connection
                .ConnectionString = _SharedConnString.ConnString
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Dim LinkingTransaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand

                    With Command
                        .CommandText = "InsertEnrollmentRecord"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = Connection
                        With .Parameters
                            .AddWithValue("StudentID", _User.UserID)
                            .AddWithValue("ClassRoomID", _Classroom.ClassroomId)
                        End With
                        .ExecuteNonQuery()
                    End With
                    LinkingTransaction.Commit()
                    MessageBox.Show("Student Linking from " & _Classroom.ClassroomName & " ON " & _User.UserName & " has been committed successfully", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Using
            Catch Exx As Exception
                LinkingTransaction.Rollback()
                'MessageBox.Show("Student Linking from " & _Classroom.ClassroomName & " ON " & _User.UserName & " has been performed unsuccessfully. Rolledback automatically: " & vbNewLine & Exx.Message, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DisplayLinkingTransactionFailed(Exx)
            End Try
        End Using
    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        PerformLink()
    End Sub
End Class