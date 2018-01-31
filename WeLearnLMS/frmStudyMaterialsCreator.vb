Public Class frmStudyMaterialsCreator

    Private _NewMaterial As New c_Material

    Private Sub btnAddMaterial_Click(sender As Object, e As EventArgs) Handles btnAddMaterial.Click
        InsertNewMaterial()
    End Sub

    Private Sub InsertNewMaterial()

        Using Connection As New MySqlConnection(_SharedConnString.ConnString)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim NewMaterialTransaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand
                    With Command
                        .Connection = Connection
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "InsertNewMaterial"
                        With .Parameters
                            .AddWithValue("MaterialName", Me._NewMaterial.MaterialName)
                            .AddWithValue("MaterialDescription", Me._NewMaterial.MaterialDescription)
                            .AddWithValue("SetDrop", False)
                        End With

                        .ExecuteNonQuery()
                        NewMaterialTransaction.Commit()
                        MessageBox.Show("New Material Transaction Successfull", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End With
                End Using
            Catch Exx As Exception
                NewMaterialTransaction.Rollback()
                MessageBox.Show("New Material Transaction Failed: " & vbNewLine & Exx.Message, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub txtMaterialDescription_Validated(sender As Object, e As EventArgs) Handles txtMaterialDescription.Validated
        Me._NewMaterial.MaterialDescription = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub txtMaterialName_Validated(sender As Object, e As EventArgs) Handles txtMaterialName.Validated
        Me._NewMaterial.MaterialName = DirectCast(sender, TextBox).Text
    End Sub

    Private Sub frmStudyMaterialsCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class