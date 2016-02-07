Public Class _default
    Inherits System.Web.UI.Page

    Dim Worker As PassaFraseCore.PassaFraseCore


    Protected Sub BTNTest_Click(sender As Object, e As EventArgs) Handles BTNTest.Click
        Dim Header As TableHeaderRow
        Dim HeaderCaptionsList As New List(Of String)(New String() {"PassPhrase", "Bits", "Massive", "Offline", "Online", "MD5Hash"})
        Dim CaptionCell As TableHeaderCell
        Dim DataRow As TableRow
        Dim DataCell As TableCell

        Dim Result As String

        'Dim TestRowValues As New List(Of String)(New String() {"1", "2", "3"})

        Header = New TableHeaderRow()
        For Each HeaderCaption As String In HeaderCaptionsList
            CaptionCell = New TableHeaderCell
            CaptionCell.Text = HeaderCaption
            Header.Cells.Add(CaptionCell)
        Next

        TableResults.Rows.Add(Header)

        Worker = New PassaFraseCore.PassaFraseCore

        For PassPhraseCount As Integer = 1 To Convert.ToInt16(dropdownfrasi.SelectedValue)
            DataRow = New TableRow
            Result = Worker.GeneratepassPhrase(Convert.ToInt16(dropdownparole.SelectedValue), Convert.ToInt16(dropdowncase.SelectedValue))

            DataCell = New TableCell
            DataCell.Text = Worker.CurrentPassPhrase
            DataRow.Cells.Add(DataCell)
            DataCell = New TableCell
            DataCell.Text = Math.Round(Worker.CurrentBitsOfEntropy, 2).ToString
            DataRow.Cells.Add(DataCell)
            DataCell = New TableCell
            DataCell.Text = Math.Round(Worker.EstimatedTimeToGuessMassive / PassaFraseCore.PassaFraseCore.SecondsToYears, 2)
            DataRow.Cells.Add(DataCell)
            DataCell = New TableCell
            DataCell.Text = Math.Round(Worker.EstimatedTimeToGuessOffline / PassaFraseCore.PassaFraseCore.SecondsToYears, 2)
            DataRow.Cells.Add(DataCell)
            DataCell = New TableCell
            DataCell.Text = Math.Round(Worker.EstimatedTimeToGuessOnline / PassaFraseCore.PassaFraseCore.SecondsToYears, 2)
            DataRow.Cells.Add(DataCell)
            DataCell = New TableCell
            DataCell.Text = Worker.CurrentMD5Hash
            DataRow.Cells.Add(DataCell)

            TableResults.Rows.Add(DataRow)
        Next

        Dim CSVBuilder As Text.StringBuilder
        CSVBuilder = New Text.StringBuilder

        For Each ResultsRow As TableRow In TableResults.Rows
            For Each ResultsCell As TableCell In ResultsRow.Cells
                CSVBuilder.Append(ResultsCell.Text)
                CSVBuilder.Append(";")
            Next
            CSVBuilder.Append(Environment.NewLine)
        Next

        ViewState("TableResultsState") = CSVBuilder.ToString

    End Sub

    Protected Sub BTNExport_Click(sender As Object, e As EventArgs) Handles BTNExport.Click
        With Response
            .ContentType = "text/csv"
            .AddHeader("Content-Disposition", "attachment; filename='PFExport.csv'")
            .Write(ViewState("TableResultsState").ToString)
            .Flush()
            .End()
        End With
    End Sub
End Class