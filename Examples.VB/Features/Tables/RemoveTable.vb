﻿Namespace Features.Tables
    Public Class RemoveTable
        Inherits ExampleBase
        Public Overrides Sub Execute(workbook As Excel.Workbook)
            Dim data = {
                    {"Name", "City", "Birthday", "Eye color", "Weight", "Height"},
                    {"Richard", "New York", #6/8/1968#, "Blue", 67, 165},
                    {"Nia", "New York", #7/3/1972#, "Brown", 62, 134},
                    {"Jared", "New York", #3/2/1964#, "Hazel", 72, 180},
                    {"Natalie", "Washington", #8/8/1972#, "Blue", 66, 163},
                    {"Damon", "Washington", #2/2/1986#, "Hazel", 76, 176},
                    {"Angela", "Washington", #2/15/1993#, "Brown", 68, 145}
                }

            Dim worksheet As IWorksheet = workbook.Worksheets(0)
            worksheet.Range("A1:F7").Value = data

            'add table.
            Dim table As ITable = worksheet.Tables.Add(worksheet.Range("A1:F7"), True)

            'remove table
            table.Delete()
        End Sub
    End Class
End Namespace