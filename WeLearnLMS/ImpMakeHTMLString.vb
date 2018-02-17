Public Class ImpMakeHTMLString
    Implements IMakeHTML

    Public Function MakeHTML(ByRef Datatable As DataTable) As String Implements IMakeHTML.MakeHTML
        Dim strHTMLBuilder As New StringBuilder
        With strHTMLBuilder

            .Append("<html >")
            .Append("<head>")
            .Append("</head>")
            .Append("<body>")
            .Append("<table border='1px' cellpadding='1' cellspacing='1' bgcolor='lightyellow' style='font-family:Garamond; font-size:smaller'>")
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

            Return .ToString
        End With
    End Function
End Class
