Public Class frmClassroomDialog

    Private _Datatable As New DataTable

    Private _MainCredentials As New c_MainCredentials

    Private _Classroom As New c_Classroom

    Friend ReadOnly Property GetClassroom As c_Classroom
        Get
            Return Me._Classroom
        End Get
    End Property

    Friend ReadOnly Property ThrowMainDatatable As DataTable
        Get
            Return Me._Datatable
        End Get
    End Property

    Public Sub New(ByRef MainCrednetials As c_MainCredentials)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With Me
            ._MainCredentials = MainCrednetials
            If ._MainCredentials.MyUserType = c_MainCredentials.UserType.ADM Then
                ReturnClasses()
            Else
                ReturnClasses(Me._MainCredentials.UserID)
            End If
        End With
    End Sub

    Public Sub New()
        InitializeComponent()
        If _SharedAdvancedCredentials.MyUserType = c_MainCredentials.UserType.ADM Then
            ReturnClasses()
            Exit Sub
        End If
        ReturnClasses(_SharedAdvancedCredentials.UserID)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
                If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then
                    With DataGridView1.Rows(e.RowIndex)
                        txtClassId.Text = .Cells("id").Value.ToString()
                        txtClassName.Text = .Cells("class_name").Value.ToString()
                        txtClassDescription.Text = .Cells("class_description").Value.ToString()
                        txtClassType.Text = .Cells("classType").Value.ToString
                    End With
                End If
            End If
        Catch XXX As Exception
            WeLearnMessageDisplay.Display(WeLearnExceptions.General, Me, XXX)
        End Try
    End Sub

    Private Sub frmClassroomDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepareDatagrid()
    End Sub

    Private Sub PrepareDatagrid()
        Dim btn As New DataGridViewButtonColumn()
        btn.HeaderText = "Action"
        btn.Text = "Select"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True

        With DataGridView1
            .DataSource = _Datatable
            .Columns.Add(btn)
            .Columns("classType").Visible = False
            .Columns("class_description").Visible = False
        End With
    End Sub

    Friend Sub ReturnClasses()
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandText = CommandType.StoredProcedure
                    .CommandText = "SelectFullClassroom"
                End With
                Using Adapter As New MySqlDataAdapter
                    With Adapter
                        .SelectCommand = Command
                        .Fill(_Datatable)
                    End With
                End Using
            End Using
        End Using
    End Sub

    Friend Sub ReturnClasses(ByRef StudentID As String)
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandText = "SelectEnrolledClassForThisStudent"
                    .CommandType = CommandType.StoredProcedure
                    With .Parameters
                        .AddWithValue("StudentID", StudentID)
                    End With
                End With
                Using Adapter As New MySqlDataAdapter
                    With Adapter
                        .SelectCommand = Command
                        .Fill(_Datatable)
                    End With
                End Using
            End Using
        End Using
    End Sub

    Private Function ParseFromTextbox() As c_Classroom
        Dim NewClassroom As New c_Classroom
        With NewClassroom
            .ClassroomId = txtClassId.Text
            .ClassroomName = txtClassName.Text
            .ClassroomDesc = txtClassDescription.Text
            .ClassType = Val(txtClassType.Text)
        End With
        Return NewClassroom
    End Function

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim emptyTextBoxes =
            From txt In Me.TableLayoutPanel1.Controls.OfType(Of TextBox)()
            Where txt.Text.Length = 0
            Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please Select a Classroom", "WeLearnLMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation))
        Else
            Me._Classroom = ParseFromTextbox()
            _SharedClassroom = ParseFromTextbox()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
End Class