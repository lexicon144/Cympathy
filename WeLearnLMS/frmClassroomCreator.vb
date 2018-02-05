Imports System.Windows.Forms

Public Class frmClassroomCreator
#Region "Fields"
    Private _Classroom As New c_Classroom
    Private Verify As New ContextValidateInput
    Private _ConnString As IConStringBuilder = New ImpConStringBuilder
#End Region

#Region "Constructors"
    ''' <summary>
    ''' Null constructor for DiaClassCreation
    ''' </summary>
    ''' <remarks></remarks>
    Friend Sub New()
        InitializeComponent()
    End Sub

#End Region

#Region "Properties"
    ''' <summary>
    ''' Return the Classroom object to the form that requests it
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property GetMyResult As c_Classroom
        Get
            Return _Classroom
        End Get
    End Property

#End Region

#Region "Sub Routines and Functions"

    Private Sub diaClassCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO - ERROR IN PARSING ENUMS
        Me.Panel1.Enabled = False
        Me.OK_Button.Enabled = False
        cmbClassroomType.Items.AddRange(eClassType.GetNames(GetType(eClassType)))
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        For Each c As TextBox In Me.Controls.OfType(Of TextBox)()
            If c.Text = String.Empty Then
                c.BackColor = Color.LightYellow
                Exit Sub
            Else
                c.BackColor = Color.White
            End If
        Next
        CreateANewClass()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    ''' <summary>
    ''' Routine inserts A New Class object into 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CreateANewClass()

        Using Connection As New MySqlConnection()
            With Connection
                .ConnectionString = _ConnString.ConnString
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Dim ClassCreationTransaction As MySqlTransaction = Connection.BeginTransaction
            Try
                Using Command As New MySqlCommand()
                    With Command
                        .Connection = Connection
                        .Transaction = ClassCreationTransaction
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "InsertNewClassroom"
                        With .Parameters
                            .AddWithValue("@ClassRoomName", _Classroom.ClassroomName)
                            .AddWithValue("@ClassRoomDesc", _Classroom.ClassroomDesc)
                            .AddWithValue("@ClassRoomType", _Classroom.ClassType)
                        End With
                        .ExecuteNonQuery()

                    End With
                    ClassCreationTransaction.Commit()
                End Using
                MessageBox.Show("Class Creation Transaction succeeded.", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                ClassCreationTransaction.Rollback()
                MessageBox.Show("Class Creation Transaction failed. Changes were not applied " & vbNewLine & ex.Message, "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
    End Sub

#End Region

    Private Sub txtClassName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtClassName.Validating

        If Not Verify.UseThisVerification(VMethodology.Username, DirectCast(sender, TextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, TextBox), "Invalid Classname")
            e.Cancel = True
            DirectCast(sender, TextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, TextBox), "")
    End Sub

    Private Sub rtbClassDescription_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles rtbClassDescription.Validating

        If Not Verify.UseThisVerification(VMethodology.Username, DirectCast(sender, RichTextBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, RichTextBox), "Invalid Description")
            e.Cancel = True
            DirectCast(sender, RichTextBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, RichTextBox), "")
    End Sub

    Private Sub ComboBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbClassroomType.Validating

        If Not Verify.UseThisVerification(VMethodology.Username, DirectCast(sender, ComboBox).Text) Then
            ErrorProvider1.SetError(DirectCast(sender, ComboBox), "Invalid Period")
            e.Cancel = True
            DirectCast(sender, ComboBox).SelectAll()
            Exit Sub
        End If
        ErrorProvider1.SetError(DirectCast(sender, ComboBox), "")
    End Sub

#Region "mutators"
    Private Sub txtClassName_Validated(sender As Object, e As EventArgs) Handles txtClassName.Validated
        Me._Classroom.ClassroomName = txtClassName.Text
    End Sub

    Private Sub rtbClassDescription_Validated(sender As Object, e As EventArgs) Handles rtbClassDescription.Validated
        Me._Classroom.ClassroomDesc = rtbClassDescription.Text
    End Sub

    Private Sub ComboBox1_Validated(sender As Object, e As EventArgs) Handles cmbClassroomType.Validated
        Me._Classroom.ClassType = cmbClassroomType.SelectedValue
    End Sub
#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.OK_Button.Enabled = True
        Me.Panel1.Enabled = True
    End Sub

    Private Sub cmbClassroomType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClassroomType.SelectedIndexChanged
        With Me
            ._Classroom.ClassType = DirectCast(sender, ComboBox).SelectedValue
        End With
    End Sub
End Class
