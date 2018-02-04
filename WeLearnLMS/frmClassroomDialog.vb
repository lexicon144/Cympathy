Public Class frmClassroomDialog

    Private _ConnString As IConStringBuilder = New ImpConStringBuilder
    Private _Datatable As New DataTable

    Private _MainCredentials As New c_MainCredentials
    Private _AdvCredentials As New c_AdvancedCredentials

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
                ReturnAdminedClasses()
            Else
                ReturnEnrolledClasses()
            End If
        End With
    End Sub

    Public Sub New()
        InitializeComponent()
        ReturnAdminedClasses()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
                If DataGridView1.Columns(e.ColumnIndex).Name = "btn" Then

                    With DataGridView1.Rows(e.RowIndex)
                        txtClassId.Text = .Cells(0).Value.ToString()
                        txtClassName.Text = .Cells(1).Value.ToString()
                        txtClassDescription.Text = .Cells(2).Value.ToString()
                        txtClassType.Text = .Cells(3).Value.ToString
                    End With

                End If
            End If
        Catch XXX As Exception
            DisplayGeneralException(XXX)
        End Try
    End Sub

    Private Sub frmClassroomDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepareDatagrid()
    End Sub

    Private Sub PrepareDatagrid()
        Dim btn As New DataGridViewButtonColumn()
        btn.HeaderText = "Action"
        btn.Text = "Open"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True

        With DataGridView1
            .DataSource = _Datatable
            .Columns.Add(btn)
        End With
    End Sub

    Friend Sub ReturnAdminedClasses()
        Using Connection As New MySqlConnection

            With Connection
                .ConnectionString = _ConnString.ConnString
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

    Friend Sub ReturnEnrolledClasses()
        Using Connection As New MySqlConnection
            With Connection
                .ConnectionString = _ConnString.ConnString
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
                        .AddWithValue("StudentID", _MainCredentials.UserID)
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
        Me._Classroom = ParseFromTextbox()
        _SharedClassroom = ParseFromTextbox()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class