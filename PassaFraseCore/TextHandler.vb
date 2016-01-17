Imports System.IO
Imports System.Text

Public Class TextHandler
    Function textFromFile(ByVal filePath As String) As String
        Dim sourceFile As New StreamReader(filePath, System.Text.Encoding.UTF8)
        Dim page As New StringBuilder
        Dim line As String
        Dim AllText As String

        Try
            Do
                line = sourceFile.ReadLine
                page.Append(line & Environment.NewLine)
            Loop Until line Is Nothing

            AllText = page.ToString

        Catch ex As Exception
            AllText = ex.ToString
        Finally
            sourceFile.Close()
        End Try
        Return AllText
    End Function
    Function textToFile(ByVal destFile As String, ByVal data As String) As Boolean
        Dim outputFile As StreamWriter

        Try
            outputFile = New StreamWriter(destFile, True)
            outputFile.Write(data)

            outputFile.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
