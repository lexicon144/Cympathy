Public Class ImpMakeHTMLSchedules
    Implements IMakeHTML

    Private MakeCSS As IMakeCSS = New ImpMakeCSS

    Public Function MakeHTML(ByRef Datatable As DataTable) As String Implements IMakeHTML.MakeHTML
        Dim builder As New StringBuilder
        With builder
            'headers etc
            .Append(StartHTML)
            .Append(StartHEAD)
            .Append(StartSTYLE)
            .Append(MakeCSS.MakeCSS)
            .Append(EndSTYLE)
            .Append(EndHEAD)
            .Append(StartBODY)
            .Append("<div id=""ReportHeader"">")
            .Append(StartP & "WeLearn Reports" & EndP)
            .Append("<p class=""subtitle"">A Cympathy Solution</p>")
            .Append("<div id=""ReportSubHeader"">")
            .Append("<table style=""position:relative; top:1000%;left:10;font-size: 1em;"">")
            .Append(EndTABLE)
            .Append(EndDIV)
            'start of TABLE div
            .Append("<div align=""center"" style=""top:70%;border:1px"">")
            .Append("<p style=""font-family:arial"">" & "Schedules in WeLearn" & EndP)

            .Append("<table id=""ScheduleTable"">")
            .Append("<tr class=""ScheduleTable"">")
            For Each myColumn As DataColumn In Datatable.Columns
                .Append(StartTD)
                .Append(myColumn.ColumnName)
                .Append(EndTD)
            Next
            .Append(EndTR)

            For Each myRow As DataRow In Datatable.Rows
                .Append("<tr class=""ScheduleTable"">")
                For Each myColumn As DataColumn In Datatable.Columns
                    .Append(StartTD)
                    .Append(myRow(myColumn.ColumnName).ToString())
                    .Append(EndTD)
                Next
                .Append(EndTR)
            Next
            .Append(EndTABLE)
            .Append(EndDIV)
            'closing
            .Append(EndBODY)
            .Append(EndHTML)
        End With
        Return builder.ToString
    End Function
End Class
