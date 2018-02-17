Public Class ImpMakeHTMLQuizGrades
    Implements IMakeHTML

    Private QuizName As String = ""

    Public Sub New(Optional ByRef Quizname As String = "QUESTIONNAIRE")
        Me.QuizName = Quizname
    End Sub

    Public Function MakeHTML(ByRef Datatable As DataTable) As String Implements IMakeHTML.MakeHTML
        Dim builder As New StringBuilder
        With builder
            .Append("<html >")
            .Append("<head>")
            .Append("</head>")
            .Append("<body>")
            .Append("<h1>" & Me.QuizName & "</h1>")
            .Append("<table border='3px' cellpadding='2' cellspacing='1' bgcolor='lightyellow' style='font-family:Garamond; font-size:smaller'>")
            .Append("<tr >")
            For Each myColumn As DataColumn In Datatable.Columns
                .Append("<td >")
                .Append(myColumn.ColumnName)
                .Append("</td>")
            Next
            .Append("</tr>")
            For Each myRow As DataRow In Datatable.Rows
                .Append("<tr >")
                For Each myColumn As DataColumn In Datatable.Columns
                    .Append("<td >")
                    .Append(myRow(myColumn.ColumnName).ToString())
                    .Append("</td>")
                Next
                .Append("</tr>")
            Next
            .Append("</table>")
            .Append("</body>")
            .Append("</html>")
        End With
        Return builder.ToString
    End Function
End Class
