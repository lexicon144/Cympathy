Imports System.Text

Public Class frmAttendanceControl

    Private _MyDataTable As New DataTable

    Private _MyClassroomDay As DayOfWeek
    Private _MyClassroomTimeStart As UInt16
    Private _MyClassroomTimeEnd As UInt16

    Private _MySQLDateNow As DateTime

    Private _Evaluated As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Friend ReadOnly Property Evaluated As Boolean
        Get
            Return _Evaluated
        End Get
    End Property

    Friend Function DateEvaluated(ByVal ThisDay As DayOfWeek, ByVal KnownDay As DayOfWeek) As Boolean
        Return (ThisDay = KnownDay)
    End Function
    Friend Function TimeSpanEvaluated(ByVal MIN_R As UInt16, ByVal GOLD As UInt16, ByVal MAX_R As UInt16) As Boolean
        Return (MIN_R <= GOLD <= MAX_R)
    End Function

    Private Sub frmAttendanceControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMySQLServerDate()
        GetMyClassroomDate(_SharedClassroom.ClassroomId)
        GetAllDatatable()

        If DateEvaluated(_MySQLDateNow.DayOfWeek, _MyClassroomDay) AndAlso TimeSpanEvaluated(_MyClassroomTimeStart, _MySQLDateNow.Hour, _MyClassroomTimeEnd) Then
            MessageBox.Show("Date / Time Evaluated", "WeLearnLMS")
            _Evaluated = True
        End If

        PrintOut()
    End Sub

    Private Sub PrintOut()
        Dim builder As New StringBuilder
        With builder
            .Append("CLASSDate : ")
            .Append([Enum].GetName(GetType(DayOfWeek), _MyClassroomDay))
            .Append(vbNewLine)
            .Append(vbNewLine)
            .Append("MYSQLDate : ")
            .Append([Enum].GetName(GetType(DayOfWeek), _MySQLDateNow.DayOfWeek))
            .Append(vbNewLine)
            .Append(vbNewLine)
            .Append("CLASSHour : ")
            .Append(_MyClassroomTimeStart & " -> " & _MyClassroomTimeEnd)
            .Append(vbNewLine)
            .Append(vbNewLine)
            .Append("MYSQLHOUR : ")
            .Append(_MySQLDateNow.Hour)
            .Append(vbNewLine)
            .Append(vbNewLine)
            .Append("ISWITHIN? : ")
            .Append(_Evaluated.ToString)
        End With
        Me.RichTextBox1.Text = builder.ToString
    End Sub

    Private Sub GetMyClassroomDate(ByRef ClassroomID As String)
        Using connection As New MySqlConnection(_SharedConnString.ConnString)
            With connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using Command As New MySqlCommand
                With Command
                    .Connection = connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SelectSchedulesClassroom"
                    With .Parameters
                        .AddWithValue("ClassID", ClassroomID)
                    End With
                End With
                Using Adapter As New MySqlDataAdapter()
                    With Adapter
                        .SelectCommand = Command
                        .Fill(Me._MyDataTable)
                    End With
                End Using
            End Using
        End Using
    End Sub

    Private Sub GetMySQLServerDate()
        Using Connection As New MySqlConnection(_SharedConnString.ConnString)
            With Connection
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            Using Command As New MySqlCommand
                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "GetNowDateScalar"
                    Me._MySQLDateNow = .ExecuteScalar()
                End With
            End Using
        End Using
    End Sub

    Private Sub GetAllDatatable()
        If Me._MyDataTable.Rows Is Nothing AndAlso Me._MyDataTable.Rows.Count = 0 Then Exit Sub
        With Me
            ._MyClassroomDay = ._MyDataTable.Rows(0)("day_number").ToString
            ._MyClassroomTimeStart = ._MyDataTable.Rows(0)("hour_start").ToString
            ._MyClassroomTimeEnd = ._MyDataTable.Rows(0)("hour_end").ToString
        End With

    End Sub

End Class