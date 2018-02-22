Public Class frmStudyMaterialsCreator

    Private _NewMaterial As New c_Material

    Private Sub btnAddMaterial_Click(sender As Object, e As EventArgs) Handles btnAddMaterial.Click
        Dim emptyTextBoxes =
            From txt In Me.TableLayoutPanel1.Controls.OfType(Of TextBox)()
            Where txt.Text.Length = 0
            Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please Select a Classroom", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation))
        Else
            InsertNewMaterial()
        End If

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

    Private Sub txtMaterialName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMaterialName.Validating
        If Not _SharedValidator.Verify(VMethodology.Username, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid Username")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub txtMaterialDescription_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMaterialDescription.Validating
        If Not _SharedValidator.Verify(VMethodology.Username, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid Username")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub
End Class