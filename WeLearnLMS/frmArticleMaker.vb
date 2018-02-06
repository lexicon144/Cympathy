Public Class frmArticleMaker
    Private _NewArticle As New c_Article

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' Write the Blob
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub WriteBlob()
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With

            Dim BlobTransaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand
                    With Command
                        .Connection = Connection
                        .Transaction = BlobTransaction
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "InsertNewArticle"

                        With .Parameters
                            .AddWithValue("@FileName", _NewArticle.ArticleName)
                            .AddWithValue("@FileSize", _NewArticle.ArticleSize)
                            .AddWithValue("@FileBlob", _NewArticle.ArticleBase)
                        End With

                        .ExecuteNonQuery()
                        BlobTransaction.Commit()
                        MessageBox.Show("Article Successfully Saved", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End With
                End Using
            Catch xxx As Exception
                BlobTransaction.Rollback()
                MessageBox.Show("Article Not Saved", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub toolstripFILENAME_Validated(sender As Object, e As EventArgs) Handles txtArticleName.Validated
        With Me
            ._NewArticle.ArticleName = DirectCast(sender, TextBox).Text
        End With
    End Sub

    Private Sub SaveToBytes()

        Me._NewArticle.ArticleBase = System.Text.Encoding.UTF8.GetBytes(RichTextBox1.Rtf)

    End Sub

    Private Sub toolstripSAVE_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.txtArticleName.Text = "" Or Me.RichTextBox1.Text = Nothing Then Exit Sub
        SaveToBytes()
        WriteBlob()
    End Sub

    Private Sub frmArticleCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtArticleName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtArticleName.Validating
        If Not _SharedValidator.Verify(VMethodology.Username, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid Name")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub
End Class