Public Class frmArticleCreator
    Private _NewArticle As New c_Article
    Private _ConnString As IConStringBuilder = New ImpConStringBuilder

    Friend Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "Word processing"
    ''' <summary>
    ''' Bolden the text in the richtextbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub toolStripBOLDEN_Click(sender As Object, e As EventArgs) Handles toolStripBOLDEN.Click
        rtbArticleTextbox.SelectionColor = Color.Black
        rtbArticleTextbox.SelectionFont = New Font(rtbArticleTextbox.Font, FontStyle.Bold)
    End Sub

    ''' <summary>
    ''' Italicize the text in the richtextbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub toolstripITALICIZE_Click(sender As Object, e As EventArgs) Handles toolstripITALICIZE.Click
        rtbArticleTextbox.SelectionFont = New Font(rtbArticleTextbox.Font, FontStyle.Italic)
    End Sub

    ''' <summary>
    ''' Underline the text in the richtextbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub toolstripUNDERLINE_Click(sender As Object, e As EventArgs) Handles toolstripUNDERLINE.Click
        rtbArticleTextbox.SelectionFont = New Font(rtbArticleTextbox.Font, FontStyle.Underline)
    End Sub

    ''' <summary>
    ''' Undo the text in the richtextbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub toolstripUNDO_Click(sender As Object, e As EventArgs) Handles toolstripUNDO.Click
        rtbArticleTextbox.Undo()
    End Sub

    ''' <summary>
    ''' Redo the text in the richtextbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub toolstripRedo_Click(sender As Object, e As EventArgs) Handles toolstripRedo.Click
        rtbArticleTextbox.Redo()
    End Sub

#End Region

    ''' <summary>
    ''' Write the Blob
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub WriteBlob()
        Using Connection As New MySqlConnection
            With Connection
                .ConnectionString = _ConnString.ConnString
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

    ''' <summary>
    ''' When validated, Set ArticleName as ThisTextbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub toolstripFILENAME_Validated(sender As Object, e As EventArgs) Handles toolstripFILENAME.Validated
        With Me
            ._NewArticle.ArticleName = DirectCast(sender, ToolStripTextBox).Text
        End With
    End Sub

    Private Sub SaveToBytes()

        Me._NewArticle.ArticleBase = System.Text.Encoding.UTF8.GetBytes(rtbArticleTextbox.Rtf)

    End Sub

    Private Sub toolstripSAVE_Click(sender As Object, e As EventArgs) Handles toolstripSAVE.Click
        SaveToBytes()
        WriteBlob()
    End Sub

End Class