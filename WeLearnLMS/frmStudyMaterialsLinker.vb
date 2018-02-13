Public Class frmStudyMaterialsLinker

    Private _Classroom As New c_Classroom
    Private _Material As New c_Material

    Public Sub New(ByRef Classroom As c_Classroom, ByRef Material As c_Material)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._Classroom = Classroom
            ._Material = Material
        End With
    End Sub

    Public Sub New(ByRef Classroom As c_Classroom)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._Classroom = Classroom
        End With
    End Sub

    Friend WriteOnly Property SetMaterial As c_Material
        Set(value As c_Material)
            Me._Material = value
        End Set
    End Property

    Private Sub frmStudyMaterialsLinker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Hub As New frmStudyMaterialsHub()
        If Hub.ShowDialog = Windows.Forms.DialogResult.OK Then
            Hub.ParseFromTextbox()
            Me._Material = Hub.RetrieveMaterial
        End If


        With Me
            .txtMaterialID.Text = ._Material.MaterialID
            .txtMaterialName.Text = ._Material.MaterialName
            .txtClassroomID.Text = ._Classroom.ClassroomId
            .txtClassroomName.Text = ._Classroom.ClassroomName
        End With


    End Sub


    Private Sub PerformTheLink()
        Using Connection As New MySqlConnection
            With Connection
                .ConnectionString = _SharedConnString.ConnString
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With

            Dim ArticleLinkingTransaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand

                    With Command
                        .CommandText = "InsertLinkMaterialToClass"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = Connection
                        With .Parameters
                            .AddWithValue("ClassroomID", _Classroom.ClassroomId)
                            .AddWithValue("MaterialID", _Material.MaterialID)
                        End With
                        .ExecuteNonQuery()
                    End With
                    ArticleLinkingTransaction.Commit()
                    MessageBox.Show("Material Linking from " & _Classroom.ClassroomName & " ON " & _Material.MaterialName & " has been committed successfully", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Using
            Catch Exx As Exception
                ArticleLinkingTransaction.Rollback()
                'MessageBox.Show("Article Linking from " & _Classroom.ClassroomName & " ON " & _Material.MaterialName & " has been performed unsuccessfully. Rolledback automaticaly", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DisplayLinkingTransactionFailed(Exx)
            End Try
        End Using
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PerformTheLink()
    End Sub
End Class