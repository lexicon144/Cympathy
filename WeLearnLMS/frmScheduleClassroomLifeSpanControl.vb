Imports System.Text

Public Class frmScheduleClassroomLifeSpanControl

    Private _NewLifespan As New c_ClassroomLifespan
    Private _MySqlDate As DateTime
    Private _GetDate As IGetDate = New ImpGetDateOnServer

    Private _MyDatatable As New DataTable

    Private GetDate As IGetDate = New ImpGetDateOnServer()

    Private Sub frmClassroomLifespanChecker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetLifeSpan(_SharedClassroom.ClassroomId)
        Me._MySqlDate = GetDate.GetDate
        If _MyDatatable.Rows.Count = 0 Then Exit Sub
        ParseToDataTable()
        printout()
    End Sub

    Private Sub printout()
        Dim Builder As New StringBuilder
        With Builder
            .AppendLine("REPORT")
            .AppendLine()
            .AppendLine("Classroom ID: ")
            .Append(_MyDatatable.Rows(0)("id").ToString())
            .AppendLine()
            .AppendLine()
            .AppendLine("Classroom Name: ")
            .Append(_MyDatatable.Rows(0)("class_name").ToString())
            .AppendLine()
            .AppendLine()
            .AppendLine("Life span is : ")
            .Append(_NewLifespan.DateStart.ToString & " -> " & _NewLifespan.DateEnd.ToString)
            .AppendLine()
            .AppendLine()
            .AppendLine("MYSQLDATE is : ")
            .Append(_MySqlDate)
            .AppendLine()
            .AppendLine()
            .AppendLine("IS WITHIN? ")
            .Append(Evaluated)
            .AppendLine()
        End With
        RichTextBox1.Text = Builder.ToString
    End Sub

    Private Function Evaluated() As Boolean
        Return (_NewLifespan.DateStart < _MySqlDate) AndAlso (_MySqlDate < _NewLifespan.DateEnd)
    End Function

    Private Sub ParseToDataTable()

        With _NewLifespan
            .DateEnd = _MyDatatable.Rows(0)("date_end").ToString()
            .DateStart = _MyDatatable.Rows(0)("date_start").ToString()
            .ClassroomID = _MyDatatable.Rows(0)("id").ToString()
        End With
    End Sub

    Private Sub GetLifeSpan(ByRef ClassID As String)
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
                    .CommandText = "SelectClassroomLifespan"
                    With .Parameters()
                        .AddWithValue("ClassroomID", ClassID)
                    End With
                End With
                Using adapter As New MySqlDataAdapter
                    With adapter
                        .SelectCommand = Command
                        .Fill(Me._MyDatatable)
                    End With
                End Using
            End Using
        End Using
    End Sub

End Class